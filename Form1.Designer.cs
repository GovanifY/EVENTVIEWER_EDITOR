﻿namespace Eventviewer_Editor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
        	this.components = new System.ComponentModel.Container();
        	this.listBox1 = new System.Windows.Forms.ListBox();
        	this.buttonLoad = new System.Windows.Forms.Button();
        	this.buttonSave = new System.Windows.Forms.Button();
        	this.buttonStr = new System.Windows.Forms.Button();
        	this.groupBox1 = new System.Windows.Forms.GroupBox();
        	this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
        	this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
        	this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
        	this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
        	this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
        	this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
        	this.label6 = new System.Windows.Forms.Label();
        	this.label5 = new System.Windows.Forms.Label();
        	this.label4 = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.label1 = new System.Windows.Forms.Label();
        	this.groupBox2 = new System.Windows.Forms.GroupBox();
        	this.checkBox1 = new System.Windows.Forms.CheckBox();
        	this.textBox1 = new System.Windows.Forms.TextBox();
        	this.label7 = new System.Windows.Forms.Label();
        	this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
        	this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
        	this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
        	this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.button1 = new System.Windows.Forms.Button();
        	this.groupBox1.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
        	this.groupBox2.SuspendLayout();
        	this.contextMenuStrip1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// listBox1
        	// 
        	this.listBox1.FormattingEnabled = true;
        	this.listBox1.Location = new System.Drawing.Point(12, 37);
        	this.listBox1.Name = "listBox1";
        	this.listBox1.Size = new System.Drawing.Size(120, 199);
        	this.listBox1.TabIndex = 1;
        	this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
        	this.listBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseUp);
        	// 
        	// buttonLoad
        	// 
        	this.buttonLoad.Location = new System.Drawing.Point(12, 8);
        	this.buttonLoad.Name = "buttonLoad";
        	this.buttonLoad.Size = new System.Drawing.Size(92, 23);
        	this.buttonLoad.TabIndex = 1;
        	this.buttonLoad.Text = "Load";
        	this.buttonLoad.UseVisualStyleBackColor = true;
        	this.buttonLoad.Click += new System.EventHandler(this.button1_Click);
        	this.buttonLoad.DragDrop += new System.Windows.Forms.DragEventHandler(this.button1_DragDrop);
        	this.buttonLoad.DragEnter += new System.Windows.Forms.DragEventHandler(this.button1_DragEnter);
        	// 
        	// buttonSave
        	// 
        	this.buttonSave.Enabled = false;
        	this.buttonSave.Location = new System.Drawing.Point(210, 8);
        	this.buttonSave.Name = "buttonSave";
        	this.buttonSave.Size = new System.Drawing.Size(94, 23);
        	this.buttonSave.TabIndex = 2;
        	this.buttonSave.Text = "Save as...";
        	this.buttonSave.UseVisualStyleBackColor = true;
        	this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
        	// 
        	// buttonStr
        	// 
        	this.buttonStr.Location = new System.Drawing.Point(313, 8);
        	this.buttonStr.Name = "buttonStr";
        	this.buttonStr.Size = new System.Drawing.Size(92, 23);
        	this.buttonStr.TabIndex = 3;
        	this.buttonStr.Text = "Load strings";
        	this.buttonStr.UseVisualStyleBackColor = true;
        	this.buttonStr.Click += new System.EventHandler(this.buttonStr_Click);
        	this.buttonStr.DragDrop += new System.Windows.Forms.DragEventHandler(this.buttonStr_DragDrop);
        	this.buttonStr.DragEnter += new System.Windows.Forms.DragEventHandler(this.buttonStr_DragEnter);
        	// 
        	// groupBox1
        	// 
        	this.groupBox1.Controls.Add(this.numericUpDown6);
        	this.groupBox1.Controls.Add(this.numericUpDown5);
        	this.groupBox1.Controls.Add(this.numericUpDown4);
        	this.groupBox1.Controls.Add(this.numericUpDown3);
        	this.groupBox1.Controls.Add(this.numericUpDown2);
        	this.groupBox1.Controls.Add(this.numericUpDown1);
        	this.groupBox1.Controls.Add(this.label6);
        	this.groupBox1.Controls.Add(this.label5);
        	this.groupBox1.Controls.Add(this.label4);
        	this.groupBox1.Controls.Add(this.label3);
        	this.groupBox1.Controls.Add(this.label2);
        	this.groupBox1.Controls.Add(this.label1);
        	this.groupBox1.Location = new System.Drawing.Point(138, 37);
        	this.groupBox1.Name = "groupBox1";
        	this.groupBox1.Size = new System.Drawing.Size(339, 107);
        	this.groupBox1.TabIndex = 4;
        	this.groupBox1.TabStop = false;
        	this.groupBox1.Text = "eventviewer";
        	// 
        	// numericUpDown6
        	// 
        	this.numericUpDown6.Enabled = false;
        	this.numericUpDown6.Hexadecimal = true;
        	this.numericUpDown6.Location = new System.Drawing.Point(271, 73);
        	this.numericUpDown6.Maximum = new decimal(new int[] {
			65535,
			0,
			0,
			0});
        	this.numericUpDown6.Name = "numericUpDown6";
        	this.numericUpDown6.Size = new System.Drawing.Size(62, 20);
        	this.numericUpDown6.TabIndex = 17;
        	this.numericUpDown6.ValueChanged += new System.EventHandler(this.numericUpDown6_ValueChanged);
        	// 
        	// numericUpDown5
        	// 
        	this.numericUpDown5.Enabled = false;
        	this.numericUpDown5.Hexadecimal = true;
        	this.numericUpDown5.Location = new System.Drawing.Point(271, 45);
        	this.numericUpDown5.Maximum = new decimal(new int[] {
			65535,
			0,
			0,
			0});
        	this.numericUpDown5.Name = "numericUpDown5";
        	this.numericUpDown5.Size = new System.Drawing.Size(62, 20);
        	this.numericUpDown5.TabIndex = 16;
        	this.numericUpDown5.ValueChanged += new System.EventHandler(this.numericUpDown5_ValueChanged);
        	// 
        	// numericUpDown4
        	// 
        	this.numericUpDown4.Enabled = false;
        	this.numericUpDown4.Hexadecimal = true;
        	this.numericUpDown4.Location = new System.Drawing.Point(271, 19);
        	this.numericUpDown4.Maximum = new decimal(new int[] {
			65535,
			0,
			0,
			0});
        	this.numericUpDown4.Name = "numericUpDown4";
        	this.numericUpDown4.Size = new System.Drawing.Size(62, 20);
        	this.numericUpDown4.TabIndex = 15;
        	this.numericUpDown4.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
        	// 
        	// numericUpDown3
        	// 
        	this.numericUpDown3.Enabled = false;
        	this.numericUpDown3.Hexadecimal = true;
        	this.numericUpDown3.Location = new System.Drawing.Point(72, 73);
        	this.numericUpDown3.Maximum = new decimal(new int[] {
			65535,
			0,
			0,
			0});
        	this.numericUpDown3.Name = "numericUpDown3";
        	this.numericUpDown3.Size = new System.Drawing.Size(62, 20);
        	this.numericUpDown3.TabIndex = 14;
        	this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
        	// 
        	// numericUpDown2
        	// 
        	this.numericUpDown2.Enabled = false;
        	this.numericUpDown2.Hexadecimal = true;
        	this.numericUpDown2.Location = new System.Drawing.Point(72, 45);
        	this.numericUpDown2.Maximum = new decimal(new int[] {
			65535,
			0,
			0,
			0});
        	this.numericUpDown2.Name = "numericUpDown2";
        	this.numericUpDown2.Size = new System.Drawing.Size(62, 20);
        	this.numericUpDown2.TabIndex = 13;
        	this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
        	// 
        	// numericUpDown1
        	// 
        	this.numericUpDown1.Enabled = false;
        	this.numericUpDown1.Hexadecimal = true;
        	this.numericUpDown1.Location = new System.Drawing.Point(72, 19);
        	this.numericUpDown1.Maximum = new decimal(new int[] {
			65535,
			0,
			0,
			0});
        	this.numericUpDown1.Name = "numericUpDown1";
        	this.numericUpDown1.Size = new System.Drawing.Size(62, 20);
        	this.numericUpDown1.TabIndex = 12;
        	this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
        	// 
        	// label6
        	// 
        	this.label6.AutoSize = true;
        	this.label6.Location = new System.Drawing.Point(194, 75);
        	this.label6.Name = "label6";
        	this.label6.Size = new System.Drawing.Size(71, 13);
        	this.label6.TabIndex = 10;
        	this.label6.Text = "Restriction ID";
        	// 
        	// label5
        	// 
        	this.label5.AutoSize = true;
        	this.label5.Location = new System.Drawing.Point(184, 50);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(83, 13);
        	this.label5.TabIndex = 8;
        	this.label5.Text = "Is in a sublevel?";
        	// 
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.Location = new System.Drawing.Point(218, 21);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(49, 13);
        	this.label4.TabIndex = 6;
        	this.label4.Text = "World ID";
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Location = new System.Drawing.Point(6, 76);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(67, 13);
        	this.label3.TabIndex = 4;
        	this.label3.Text = "Japanese ID";
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(11, 50);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(55, 13);
        	this.label2.TabIndex = 3;
        	this.label2.Text = "English ID";
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(15, 22);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(48, 13);
        	this.label1.TabIndex = 1;
        	this.label1.Text = "String ID";
        	// 
        	// groupBox2
        	// 
        	this.groupBox2.Controls.Add(this.checkBox1);
        	this.groupBox2.Controls.Add(this.textBox1);
        	this.groupBox2.Controls.Add(this.label7);
        	this.groupBox2.Location = new System.Drawing.Point(138, 150);
        	this.groupBox2.Name = "groupBox2";
        	this.groupBox2.Size = new System.Drawing.Size(339, 86);
        	this.groupBox2.TabIndex = 5;
        	this.groupBox2.TabStop = false;
        	this.groupBox2.Text = "String Mapping";
        	// 
        	// checkBox1
        	// 
        	this.checkBox1.AutoSize = true;
        	this.checkBox1.Enabled = false;
        	this.checkBox1.Location = new System.Drawing.Point(6, 63);
        	this.checkBox1.Name = "checkBox1";
        	this.checkBox1.Size = new System.Drawing.Size(323, 17);
        	this.checkBox1.TabIndex = 2;
        	this.checkBox1.Text = "Japanese String Mapping(to choose before loading the strings!)";
        	this.checkBox1.UseVisualStyleBackColor = true;
        	// 
        	// textBox1
        	// 
        	this.textBox1.Enabled = false;
        	this.textBox1.Location = new System.Drawing.Point(97, 38);
        	this.textBox1.Name = "textBox1";
        	this.textBox1.Size = new System.Drawing.Size(236, 20);
        	this.textBox1.TabIndex = 1;
        	this.textBox1.Text = "NULL or String Mapping not loaded!";
        	// 
        	// label7
        	// 
        	this.label7.AutoSize = true;
        	this.label7.Location = new System.Drawing.Point(15, 41);
        	this.label7.Name = "label7";
        	this.label7.Size = new System.Drawing.Size(66, 13);
        	this.label7.TabIndex = 0;
        	this.label7.Text = "Event Name";
        	// 
        	// openFileDialog1
        	// 
        	this.openFileDialog1.FileName = "openFileDialog1";
        	// 
        	// contextMenuStrip1
        	// 
        	this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.addToolStripMenuItem,
			this.deleteToolStripMenuItem});
        	this.contextMenuStrip1.Name = "contextMenuStrip1";
        	this.contextMenuStrip1.Size = new System.Drawing.Size(108, 48);
        	// 
        	// addToolStripMenuItem
        	// 
        	this.addToolStripMenuItem.Name = "addToolStripMenuItem";
        	this.addToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
        	this.addToolStripMenuItem.Text = "Add";
        	this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
        	// 
        	// deleteToolStripMenuItem
        	// 
        	this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
        	this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
        	this.deleteToolStripMenuItem.Text = "Delete";
        	this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
        	// 
        	// button1
        	// 
        	this.button1.Location = new System.Drawing.Point(110, 8);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(94, 23);
        	this.button1.TabIndex = 6;
        	this.button1.Text = "New...";
        	this.button1.UseVisualStyleBackColor = true;
        	this.button1.Click += new System.EventHandler(this.button1_Click_1);
        	// 
        	// Form1
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(489, 245);
        	this.Controls.Add(this.button1);
        	this.Controls.Add(this.groupBox2);
        	this.Controls.Add(this.groupBox1);
        	this.Controls.Add(this.buttonStr);
        	this.Controls.Add(this.buttonSave);
        	this.Controls.Add(this.buttonLoad);
        	this.Controls.Add(this.listBox1);
        	this.Name = "Form1";
        	this.Text = "Eventviewer Editor";
        	this.groupBox1.ResumeLayout(false);
        	this.groupBox1.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
        	this.groupBox2.ResumeLayout(false);
        	this.groupBox2.PerformLayout();
        	this.contextMenuStrip1.ResumeLayout(false);
        	this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonStr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

