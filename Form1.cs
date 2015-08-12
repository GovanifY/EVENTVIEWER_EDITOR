using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAR_Editor;
using Microsoft.SqlServer.Server;

namespace Eventviewer_Editor
{
    public partial class Form1 : Form
    {
        private uint nentries;
        internal Dictionary<uint, EVENT> EVENTS = new Dictionary<uint, EVENT>();
        internal Dictionary<uint, EVENT> EVENTS2 = new Dictionary<uint, EVENT>();
        internal Dictionary<uint, STRING> STRINGS = new Dictionary<uint, STRING>();
        private uint newentry;
        private static readonly System.Diagnostics.FileVersionInfo program = System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetEntryAssembly().Location);
        private class typeEntry
        {
            public string ext;
            public string name;

            public typeEntry(string e, string n)
            {
                this.ext = e;
                this.name = n;
            }
        }

        private BAR.BARFile b;
        private BAR bar = null;
        private string fileName;

        public Form1()
        {
            InitializeComponent();
            this.Text = program.ProductName + " " + program.FileVersion + " [" + program.CompanyName + "]";
        }

        private void Cleanup()
        {
            this.buttonSave.Enabled =
                this.numericUpDown1.Enabled =
                    this.numericUpDown2.Enabled =
                        this.numericUpDown3.Enabled =
                            this.numericUpDown4.Enabled =
                                this.numericUpDown5.Enabled = this.numericUpDown6.Enabled = false;
            this.listBox1.Items.Clear();
            EVENTS.Clear();
            if (bar == null)
            {
                bar = null;
                fileName = "";
            }
        }

        private void SetUp()
        {
            this.buttonSave.Enabled =
                this.buttonLoad.Enabled =
                    this.numericUpDown1.Enabled =
                        this.numericUpDown2.Enabled =
                            this.numericUpDown3.Enabled =
                                this.numericUpDown4.Enabled =
                                    this.numericUpDown5.Enabled = this.numericUpDown6.Enabled = true;
        }

        #region Buttons shits

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "BAR file|*.bar";
            openFileDialog1.FileName = "";
            openFileDialog1.DefaultExt = "bar";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFile(openFileDialog1.FileName, openFileDialog1.ReadOnlyChecked);
            }
        }

        private void button1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void button1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] filePaths = (string[]) (e.Data.GetData(DataFormats.FileDrop));
                foreach (string fileLoc in filePaths)
                {
                    if (System.IO.File.Exists(fileLoc))
                    {
                        openFile(fileLoc);
                        break;
                    }
                }
            }
        }

        private void buttonStr_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "BAR file|*.bar";
            openFileDialog1.FileName = "";
            openFileDialog1.DefaultExt = "bar";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LoadStr(openFileDialog1.FileName, openFileDialog1.ReadOnlyChecked);
            }
        }

        private void buttonStr_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void buttonStr_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] filePaths = (string[]) (e.Data.GetData(DataFormats.FileDrop));
                foreach (string fileLoc in filePaths)
                {
                    if (System.IO.File.Exists(fileLoc))
                    {
                        LoadStr(fileLoc);
                        break;
                    }
                }
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "BAR file|*.bar";
            saveFileDialog1.FileName = "";
            saveFileDialog1.DefaultExt = "bar";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                RebuildFile(saveFileDialog1.FileName);
            }
        }

        #endregion

        private void openFile(string filename, bool ro = false)
        {
            try
            {
                Cleanup();
                try
                {
                    bar =
                        new BAR(System.IO.File.Open(filename, System.IO.FileMode.Open, System.IO.FileAccess.Read,
                            System.IO.FileShare.None));
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Fatal error opening file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bar = null;
                    return;
                }
                fileName = System.IO.Path.GetFileName(filename);
                b = this.bar.fileList[0];
                //Now let's extract the file
                if (bar.fileCount != 1)
                {
                    MessageBox.Show("This BAR files contains more than one file!\nAre you sure it is eventviewer.bar?",
                        "Fatal error opening file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bar = null;
                    return;
                }
                if (b.id != "even")
                {
                    MessageBox.Show(
                        "This BAR files don't have a file called even!\nAre you sure it is eventviewer.bar?",
                        "Fatal error opening file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bar = null;
                    return;
                }


                string nameextractedevent =
                    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                        System.IO.Path.GetTempFileName());
                try
                {
                    System.IO.File.WriteAllBytes(nameextractedevent, b.data);
                }
                catch
                {
                    MessageBox.Show(
                        "Event file can't be extracted in temp folder!\nDo you have enough access to write in the TEMP folder?",
                        "Fatal error opening file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bar = null;
                    return;
                }
                //Fun part:let's load it!
                uint version;
                BinaryReader br = new BinaryReader(new FileStream(nameextractedevent, FileMode.Open));
                br.BaseStream.Position = 0;
                version = br.ReadUInt32();
                nentries = br.ReadUInt32();
                this.listBox1.BeginUpdate();

                for (uint i = 0; i < nentries; i++)
                {
                    //Read shits
                    var Contents = new EVENT();
                    Contents.IsSubLevel = br.ReadUInt16();
                    Contents.StringID = br.ReadUInt16();
                    Contents.WorldID = br.ReadUInt16();
                    Contents.EnID = br.ReadUInt16();
                    Contents.JAID = br.ReadUInt16();
                    Contents.RestrictionID = br.ReadUInt16();
                    Contents.number = i;
                    EVENTS.Add(Contents.StringID, Contents);
                    this.listBox1.Items.Add(Contents.StringID.ToString("X4"));
                }
                this.listBox1.EndUpdate();
                SetUp();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Fatal error opening file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bar = null;
            }

        }

        private void LoadStr(string filename, bool ro = false)
        {
            try
            {
                bar =
                    new BAR(System.IO.File.Open(filename, System.IO.FileMode.Open, System.IO.FileAccess.Read,
                        System.IO.FileShare.None));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Fatal error opening file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bar = null;
                return;
            }
            fileName = System.IO.Path.GetFileName(filename);
            b = this.bar.fileList[0];
            //Now let's extract the file
            if (bar.fileCount != 2)
            {
                MessageBox.Show("This BAR files contains more than two file!\nAre you sure it is title.bar?",
                    "Fatal error opening file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bar = null;
                return;
            }
            if (b.id != "titl")
            {
                MessageBox.Show("This BAR files don't have a file called titl!\nAre you sure it is title.bar?",
                    "Fatal error opening file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bar = null;
                return;
            }


            string nameextractedstr = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), System.IO.Path.GetTempFileName());
            try
            {
                System.IO.File.WriteAllBytes(nameextractedstr, b.data);
            }
            catch
            {
                MessageBox.Show(
                    "Text file can't be extracted in temp folder!\nDo you have enough access to write in the TEMP folder?",
                    "Fatal error opening file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bar = null;
                return;
            }
            //Now let's load this shit inside a dictionnary
            uint version;
            uint nentriesStr;
            long brpos = 0;
            bool jap = false;
            STRINGS.Clear();

            BinaryReader br = new BinaryReader(new FileStream(nameextractedstr, FileMode.Open));
            br.BaseStream.Position = 0;
            version = br.ReadUInt32();
            nentriesStr = br.ReadUInt32();
            for (int i = 0; i < nentriesStr; i++)
            {
                var Contents = new STRING();
                Contents.ID = br.ReadUInt32();
                brpos = br.BaseStream.Position + 4;
                br.BaseStream.Position = br.ReadUInt32();
                //Contents.Offset = (uint) br.BaseStream.Position;
                //MessageBox.Show(Contents.Offset.ToString(), nameextractedstr, MessageBoxButtons.OK, MessageBoxIcon.Error);
                bar = null;
                byte c = br.ReadByte();
                while (true)
                {
                    Contents.text = Contents.bytetotext(c, Contents.text, jap);
                        c = br.ReadByte();
                    if (c == 0)
                    {
                        goto next;
                    }
                }
                next:
                //MessageBox.Show(Contents.text, nameextractedstr, MessageBoxButtons.OK, MessageBoxIcon.Error);
                bar = null;
                if (checkBox1.Checked)
                {
                    jap = true;
                }
                STRINGS.Add(Contents.ID, Contents);
                br.BaseStream.Position = brpos;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = "";
            retry:
            try { curItem = listBox1.SelectedItem.ToString(); }
            catch { listBox1.SelectedIndex = 0; goto retry; }
            uint key = Convert.ToUInt16(curItem, 16);
            if (EVENTS.ContainsKey(key))
            {
                var Values = EVENTS[key];
                this.numericUpDown6.Value = Values.RestrictionID;
                this.numericUpDown5.Value = Values.IsSubLevel;
                this.numericUpDown4.Value = Values.WorldID;
                this.numericUpDown3.Value = Values.JAID;
                this.numericUpDown2.Value = Values.EnID;
                this.numericUpDown1.Value = Values.StringID;
            }
            else
            {
                MessageBox.Show("Contents of the event can't be loaded!", "Fatal error opening file",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                bar = null;
                return;
            }
            if (STRINGS.ContainsKey((key)))
            {
                var Values = STRINGS[key];
                textBox1.Text = Values.text;
            }
            else
            {
                textBox1.Text = "NULL or String Mapping not loaded!";
            }
        }

        private void listBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var item = listBox1.IndexFromPoint(e.Location);
                if (item >= 0)
                {
                    listBox1.SelectedIndex = item;
                    contextMenuStrip1.Show(listBox1, e.Location);
                }
            }
        }

        #region Saving shits when numerics are changed

            private
            void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            string curItem = listBox1.SelectedItem.ToString();
            uint key = Convert.ToUInt16(curItem, 16);
            var ChangedEvent = EVENTS[key];
            ChangedEvent.StringID = (uint) numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            string curItem = listBox1.SelectedItem.ToString();
            uint key = Convert.ToUInt16(curItem, 16);
            var ChangedEvent = EVENTS[key];
            ChangedEvent.EnID = (uint) numericUpDown2.Value;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            string curItem = listBox1.SelectedItem.ToString();
            uint key = Convert.ToUInt16(curItem, 16);
            var ChangedEvent = EVENTS[key];
            ChangedEvent.JAID = (uint) numericUpDown3.Value;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            string curItem = listBox1.SelectedItem.ToString();
            uint key = Convert.ToUInt16(curItem, 16);
            var ChangedEvent = EVENTS[key];
            ChangedEvent.WorldID = (uint) numericUpDown4.Value;
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            string curItem = listBox1.SelectedItem.ToString();
            uint key = Convert.ToUInt16(curItem, 16);
            var ChangedEvent = EVENTS[key];
            ChangedEvent.IsSubLevel = (uint) numericUpDown5.Value;
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            string curItem = listBox1.SelectedItem.ToString();
            uint key = Convert.ToUInt16(curItem, 16);
            var ChangedEvent = EVENTS[key];
            ChangedEvent.RestrictionID = (uint) numericUpDown6.Value;
        }

        #endregion


        private void RebuildFile(string filename)
        {
            var tempname = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),System.IO.Path.GetTempFileName());
            FileStream fs = new FileStream(tempname, FileMode.OpenOrCreate);
            BinaryWriter bw = new BinaryWriter(fs);
            const uint version = 0x00000001;
            bw.Write(version);
            bw.Write(nentries);//As long as the var isn't changed let's use this.
            foreach (var entry in EVENTS)
            {
                var Values = entry.Value;
                //All Values are in UInt32 OR we need to write 'em to UInt16 so let's convert!
                    var sub16 = Convert.ToUInt16(Values.IsSubLevel);
                    var string16 = Convert.ToUInt16(Values.StringID);
                    var world16 = Convert.ToUInt16(Values.WorldID);
                    var en16 = Convert.ToUInt16(Values.EnID);
                    var ja16 = Convert.ToUInt16(Values.JAID);
                    var res16 = Convert.ToUInt16(Values.RestrictionID);
                    bw.Write(sub16);
                    bw.Write(string16);
                    bw.Write(world16);
                    bw.Write(en16);
                    bw.Write(ja16);
                    bw.Write(res16);
            }
            fs.Close();
            byte[] evt = File.ReadAllBytes(tempname);
            var file = System.IO.File.Open(filename, System.IO.FileMode.Create, System.IO.FileAccess.Write,
                System.IO.FileShare.None);
            var bwfinal = new BinaryWriter(file);
            long basePos = file.Position;
            bwfinal.Write(0x01524142u);
            int fileC = 1;
            bwfinal.Write(fileC);
            bwfinal.Write(0u);
            bwfinal.Write(0u);
            uint offset = 16*((uint) fileC + 1);
            for (int i = 0; i < fileC; i++)
            {
                file.Position = basePos + 16*(i + 1);
                BAR.BARFile bf = bar.fileList[i];
                bwfinal.Write(bf.type);
                bwfinal.Write(bf._id);
                bwfinal.Write(offset);
                bwfinal.Write(evt.Length);
                uint szPad = (uint) Math.Ceiling((double) evt.Length/16)*16;
                file.Position = basePos + offset;
                bwfinal.Write(evt);
                offset += szPad;
                bwfinal.Close();
                file.Close();



            }

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
                        string curItem = listBox1.SelectedItem.ToString();
            uint key = Convert.ToUInt16(curItem, 16);
            if (EVENTS.ContainsKey(key))
            {
                EVENTS.Remove(key);
            }
            int i = this.listBox1.SelectedIndex;
            if (i != -1)
            { listBox1.Items.RemoveAt(i); }
            try { this.listBox1.SelectedIndex = i + 1; }
            catch { this.listBox1.SelectedIndex = 1; }

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Contents = new EVENT();
            foreach (var entry2 in EVENTS)
                EVENTS2.Add(entry2.Value.StringID, entry2.Value);
            EVENTS.Clear();
            int y = this.listBox1.SelectedIndex + 1;
            int i = 0;
            listBox1.BeginUpdate();
            listBox1.Items.Clear();
            foreach (var entry in EVENTS2)
            {
                i++;
                if (i == y)
                {
                    Contents.IsSubLevel = 0;
                    Contents.StringID = 0x5500 + newentry;
                    Contents.WorldID = 0;
                    Contents.EnID = 0;
                    Contents.JAID = 0;
                    Contents.RestrictionID = 0;
                    EVENTS.Add(entry.Value.StringID, entry.Value);
                    this.listBox1.Items.Add(entry.Value.StringID.ToString("X4"));
                    try
                    {
                        EVENTS.Add(Contents.StringID, Contents);
                        this.listBox1.Items.Add(Contents.StringID.ToString("X4"));
                    }
                    catch
                    {
                        Contents.StringID = Contents.StringID + 1;
                        EVENTS.Add(Contents.StringID, Contents);
                        this.listBox1.Items.Add(Contents.StringID.ToString("X4"));
                    }
                }
                else
                {
                    EVENTS.Add(entry.Value.StringID, entry.Value);
                    this.listBox1.Items.Add(entry.Value.StringID.ToString("X4"));
                }
            }
            newentry++;
            nentries++;
            EVENTS2.Clear();
            listBox1.SelectedItem = Contents.StringID.ToString("X4");
            listBox1.EndUpdate();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Cleanup();
            this.listBox1.BeginUpdate();
            var Contents = new EVENT();
                    Contents.IsSubLevel = 0;
                    Contents.StringID = 0x5500;
                    Contents.WorldID = 0;
                    Contents.EnID = 0;
                    Contents.JAID = 0;
                    Contents.RestrictionID = 0;
                    EVENTS.Add(Contents.StringID, Contents);
                    this.listBox1.Items.Add(Contents.StringID.ToString("X4"));
                    nentries++;
                    listBox1.SelectedItem = Contents.StringID.ToString("X4");
            this.listBox1.EndUpdate();
            SetUp();
        }
    }
}
