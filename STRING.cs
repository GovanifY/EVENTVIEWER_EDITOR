//Ver 1.3

namespace Eventviewer_Editor
{
    internal class STRING
    {
        public uint ID;
        public uint Offset;
        public byte[] data;
        public byte lastbyte = 0;
        public byte lastbyte2 = 0;
        public string text;
        //byte to text have to be called like this while (true) { try{c = br.ReadByte(); Contents.bytetotext(c, Contents.text, jap); } catch { goto next; } }
        public string bytetotext(byte kh2map, string output, bool jap)
        {
            if (jap)
            {
                #region Japanese String Mapping code
                string tempmapping = "";

                if (lastbyte == 0)
                {
                    switch (kh2map)
                    {
                        case 0:
                            tempmapping = "{eol}";
                            break;
                        case 1:
                            tempmapping = " ";
                            break;
                        case 2:
                            tempmapping = "{lf}";
                            break;
                        case 25:
                            lastbyte2 = 25;
                            break;
                        case 26:
                            lastbyte2 = 26;
                            break;
                        case 27:
                            lastbyte2 = 27;
                            break;
                        case 28:
                            lastbyte2 = 28;
                            break;
                        case 29:
                            lastbyte2 = 29;
                            break;
                        case 30:
                            lastbyte2 = 30;
                            break;
                        case 31:
                            lastbyte2 = 31;
                            break;
                        case 33:
                            tempmapping = "0";
                            break;
                        case 34:
                            tempmapping = "1";
                            break;
                        case 35:
                            tempmapping = "2";
                            break;
                        case 36:
                            tempmapping = "3";
                            break;
                        case 37:
                            tempmapping = "4";
                            break;
                        case 38:
                            tempmapping = "5";
                            break;
                        case 39:
                            tempmapping = "6";
                            break;
                        case 40:
                            tempmapping = "7";
                            break;
                        case 41:
                            tempmapping = "8";
                            break;
                        case 42:
                            tempmapping = "9";
                            break;
                        case 43:
                            tempmapping = "+";
                            break;
                        case 44:
                            tempmapping = "-";
                            break;
                        case 45:
                            tempmapping = "{mX}";
                            break;
                        case 46:
                            tempmapping = "A";
                            break;
                        case 47:
                            tempmapping = "B";
                            break;
                        case 48:
                            tempmapping = "C";
                            break;
                        case 49:
                            tempmapping = "D";
                            break;
                        case 50:
                            tempmapping = "E";
                            break;
                        case 51:
                            tempmapping = "F";
                            break;
                        case 52:
                            tempmapping = "G";
                            break;
                        case 53:
                            tempmapping = "H";
                            break;
                        case 54:
                            tempmapping = "I";
                            break;
                        case 55:
                            tempmapping = "J";
                            break;
                        case 56:
                            tempmapping = "K";
                            break;
                        case 57:
                            tempmapping = "L";
                            break;
                        case 58:
                            tempmapping = "M";
                            break;
                        case 59:
                            tempmapping = "N";
                            break;
                        case 60:
                            tempmapping = "O";
                            break;
                        case 61:
                            tempmapping = "P";
                            break;
                        case 62:
                            tempmapping = "Q";
                            break;
                        case 63:
                            tempmapping = "R";
                            break;
                        case 64:
                            tempmapping = "S";
                            break;
                        case 65:
                            tempmapping = "T";
                            break;
                        case 66:
                            tempmapping = "U";
                            break;
                        case 67:
                            tempmapping = "V";
                            break;
                        case 68:
                            tempmapping = "W";
                            break;
                        case 69:
                            tempmapping = "X";
                            break;
                        case 70:
                            tempmapping = "Y";
                            break;
                        case 71:
                            tempmapping = "Z";
                            break;
                        case 72:
                            tempmapping = "!";
                            break;
                        case 73:
                            tempmapping = "?";
                            break;
                        case 74:
                            tempmapping = "%";
                            break;
                        case 75:
                            tempmapping = "/";
                            break;
                        case 76:
                            tempmapping = "※";
                            break;
                        case 77:
                            tempmapping = "、";
                            break;
                        case 78:
                            tempmapping = "。";
                            break;
                        case 79:
                            tempmapping = ".";
                            break;
                        case 80:
                            tempmapping = ",";
                            break;
                        case 81:
                            tempmapping = "・";
                            break;
                        case 82:
                            tempmapping = ":";
                            break;
                        case 83:
                            tempmapping = "{•••}";
                            break;
                        case 84:
                            tempmapping = "-";
                            break;
                        case 85:
                            tempmapping = "ー";
                            break;
                        case 86:
                            tempmapping = "～";
                            break;
                        case 87:
                            tempmapping = "'";
                            break;
                        case 88:
                            tempmapping = "゛";
                            break;
                        case 89:
                            tempmapping = "{゛b}";
                            break;
                        case 90:
                            tempmapping = "(";
                            break;
                        case 91:
                            tempmapping = ")";
                            break;
                        case 92:
                            tempmapping = "「";
                            break;
                        case 93:
                            tempmapping = "」";
                            break;
                        case 94:
                            tempmapping = "『";
                            break;
                        case 95:
                            tempmapping = "』";
                            break;
                        case 96:
                            tempmapping = "“";
                            break;
                        case 97:
                            tempmapping = "”";
                            break;
                        case 98:
                            tempmapping = "[";
                            break;
                        case 99:
                            tempmapping = "]";
                            break;
                        case 100:
                            tempmapping = "<";
                            break;
                        case 101:
                            tempmapping = ">";
                            break;
                        case 102:
                            tempmapping = "－";
                            break;
                        case 103:
                            tempmapping = "{－}";
                            break;
                        case 104:
                            tempmapping = "↳";
                            break;
                        case 105:
                            tempmapping = "♪";
                            break;
                        case 106:
                            tempmapping = "→";
                            break;
                        case 107:
                            tempmapping = "←";
                            break;
                        case 108:
                            tempmapping = "全";
                            break;
                        case 109:
                            tempmapping = "合";
                            break;
                        case 110:
                            tempmapping = "成";
                            break;
                        case 111:
                            tempmapping = "半";
                            break;
                        case 112:
                            tempmapping = "○";
                            break;
                        case 113:
                            tempmapping = "×";
                            break;
                        case 114:
                            tempmapping = "△";
                            break;
                        case 115:
                            tempmapping = "□";
                            break;
                        case 116:
                            tempmapping = "▲";
                            break;
                        case 117:
                            tempmapping = "▼";
                            break;
                        case 118:
                            tempmapping = "►";
                            break;
                        case 119:
                            tempmapping = "◄";
                            break;
                        case 130:
                            tempmapping = "★";
                            break;
                        case 131:
                            tempmapping = "☆";
                            break;
                        case 132:
                            tempmapping = "l";
                            break;
                        case 133:
                            tempmapping = "a";
                            break;
                        case 134:
                            tempmapping = "r";
                            break;
                        case 135:
                            tempmapping = "t";
                            break;
                        case 136:
                            tempmapping = "i";
                            break;
                        case 137:
                            tempmapping = "o";
                            break;
                        case 138:
                            tempmapping = "n";
                            break;
                        case 139:
                            tempmapping = "r";
                            break;
                        case 140:
                            tempmapping = "■";
                            break;
                        case 141:
                            tempmapping = "前";
                            break;
                        case 142:
                            tempmapping = "選";
                            break;
                        case 143:
                            tempmapping = "一";
                            break;
                        case 144:
                            tempmapping = "あ";
                            break;
                        case 145:
                            tempmapping = "い";
                            break;
                        case 146:
                            tempmapping = "う";
                            break;
                        case 147:
                            tempmapping = "え";
                            break;
                        case 148:
                            tempmapping = "お";
                            break;
                        case 149:
                            tempmapping = "か";
                            break;
                        case 150:
                            tempmapping = "き";
                            break;
                        case 151:
                            tempmapping = "く";
                            break;
                        case 152:
                            tempmapping = "け";
                            break;
                        case 153:
                            tempmapping = "こ";
                            break;
                        case 154:
                            tempmapping = "さ";
                            break;
                        case 155:
                            tempmapping = "し";
                            break;
                        case 156:
                            tempmapping = "す";
                            break;
                        case 157:
                            tempmapping = "せ";
                            break;
                        case 158:
                            tempmapping = "そ";
                            break;
                        case 159:
                            tempmapping = "た";
                            break;
                        case 160:
                            tempmapping = "ち";
                            break;
                        case 161:
                            tempmapping = "つ";
                            break;
                        case 162:
                            tempmapping = "て";
                            break;
                        case 163:
                            tempmapping = "と";
                            break;
                        case 164:
                            tempmapping = "な";
                            break;
                        case 165:
                            tempmapping = "に";
                            break;
                        case 166:
                            tempmapping = "ぬ";
                            break;
                        case 167:
                            tempmapping = "ね";
                            break;
                        case 168:
                            tempmapping = "の";
                            break;
                        case 169:
                            tempmapping = "は";
                            break;
                        case 170:
                            tempmapping = "ひ";
                            break;
                        case 171:
                            tempmapping = "ふ";
                            break;
                        case 172:
                            tempmapping = "へ";
                            break;
                        case 173:
                            tempmapping = "ほ";
                            break;
                        case 174:
                            tempmapping = "ま";
                            break;
                        case 175:
                            tempmapping = "み";
                            break;
                        case 176:
                            tempmapping = "む";
                            break;
                        case 177:
                            tempmapping = "め";
                            break;
                        case 178:
                            tempmapping = "も";
                            break;
                        case 179:
                            tempmapping = "や";
                            break;
                        case 180:
                            tempmapping = "ゆ";
                            break;
                        case 181:
                            tempmapping = "よ";
                            break;
                        case 182:
                            tempmapping = "ら";
                            break;
                        case 183:
                            tempmapping = "り";
                            break;
                        case 184:
                            tempmapping = "る";
                            break;
                        case 185:
                            tempmapping = "れ";
                            break;
                        case 186:
                            tempmapping = "ろ";
                            break;
                        case 187:
                            tempmapping = "わ";
                            break;
                        case 188:
                            tempmapping = "を";
                            break;
                        case 189:
                            tempmapping = "ん";
                            break;
                        case 190:
                            tempmapping = "が";
                            break;
                        case 191:
                            tempmapping = "ぎ";
                            break;
                        case 192:
                            tempmapping = "ぐ";
                            break;
                        case 193:
                            tempmapping = "げ";
                            break;
                        case 194:
                            tempmapping = "ご";
                            break;
                        case 195:
                            tempmapping = "ざ";
                            break;
                        case 196:
                            tempmapping = "じ";
                            break;
                        case 197:
                            tempmapping = "ず";
                            break;
                        case 198:
                            tempmapping = "ぜ";
                            break;
                        case 199:
                            tempmapping = "ぞ";
                            break;
                        case 200:
                            tempmapping = "だ";
                            break;
                        case 201:
                            tempmapping = "ぢ";
                            break;
                        case 202:
                            tempmapping = "づ";
                            break;
                        case 203:
                            tempmapping = "で";
                            break;
                        case 204:
                            tempmapping = "ど";
                            break;
                        case 205:
                            tempmapping = "ば";
                            break;
                        case 206:
                            tempmapping = "び";
                            break;
                        case 207:
                            tempmapping = "ぶ";
                            break;
                        case 208:
                            tempmapping = "べ";
                            break;
                        case 209:
                            tempmapping = "ぼ";
                            break;
                        case 210:
                            tempmapping = "ぱ";
                            break;
                        case 211:
                            tempmapping = "ぴ";
                            break;
                        case 212:
                            tempmapping = "ぷ";
                            break;
                        case 213:
                            tempmapping = "ぺ";
                            break;
                        case 214:
                            tempmapping = "ぽ";
                            break;
                        case 215:
                            tempmapping = "ぁ";
                            break;
                        case 216:
                            tempmapping = "ぃ";
                            break;
                        case 217:
                            tempmapping = "ぅ";
                            break;
                        case 218:
                            tempmapping = "ぇ";
                            break;
                        case 219:
                            tempmapping = "ぉ";
                            break;
                        case 220:
                            tempmapping = "ゃ";
                            break;
                        case 221:
                            tempmapping = "ゅ";
                            break;
                        case 222:
                            tempmapping = "ょ";
                            break;
                        case 223:
                            tempmapping = "っ";
                            break;
                        case 224:
                            tempmapping = "ア";
                            break;
                        case 225:
                            tempmapping = "イ";
                            break;
                        case 226:
                            tempmapping = "ウ";
                            break;
                        case 227:
                            tempmapping = "エ";
                            break;
                        case 228:
                            tempmapping = "オ";
                            break;
                        case 229:
                            tempmapping = "カ";
                            break;
                        case 230:
                            tempmapping = "キ";
                            break;
                        case 231:
                            tempmapping = "ク";
                            break;
                        case 232:
                            tempmapping = "ケ";
                            break;
                        case 233:
                            tempmapping = "コ";
                            break;
                        case 234:
                            tempmapping = "サ";
                            break;
                        case 235:
                            tempmapping = "シ";
                            break;
                        case 236:
                            tempmapping = "ス";
                            break;
                        case 237:
                            tempmapping = "セ";
                            break;
                        case 238:
                            tempmapping = "ソ";
                            break;
                        case 239:
                            tempmapping = "タ";
                            break;
                        case 240:
                            tempmapping = "チ";
                            break;
                        case 241:
                            tempmapping = "ツ";
                            break;
                        case 242:
                            tempmapping = "テ";
                            break;
                        case 243:
                            tempmapping = "ト";
                            break;
                        case 244:
                            tempmapping = "ナ";
                            break;
                        case 245:
                            tempmapping = "ニ";
                            break;
                        case 246:
                            tempmapping = "ヌ";
                            break;
                        case 247:
                            tempmapping = "ネ";
                            break;
                        case 248:
                            tempmapping = "ノ";
                            break;
                        case 249:
                            tempmapping = "ハ";
                            break;
                        case 250:
                            tempmapping = "ヒ";
                            break;
                        case 251:
                            tempmapping = "フ";
                            break;
                        case 252:
                            tempmapping = "ヘ";
                            break;
                        case 253:
                            tempmapping = "ホ";
                            break;
                        case 254:
                            tempmapping = "マ";
                            break;
                        case 255:
                            tempmapping = "ミ";
                            break;
                    }
                    if (lastbyte == 25)
                    {
                        lastbyte = 0;
                        switch (kh2map)
                        {
                            case 0:
                                tempmapping = "ム";
                                break;
                            case 1:
                                tempmapping = "メ";
                                break;
                            case 2:
                                tempmapping = "モ";
                                break;
                            case 3:
                                tempmapping = "ヤ";
                                break;
                            case 4:
                                tempmapping = "ユ";
                                break;
                            case 5:
                                tempmapping = "ヨ";
                                break;
                            case 6:
                                tempmapping = "ラ";
                                break;
                            case 7:
                                tempmapping = "リ";
                                break;
                            case 8:
                                tempmapping = "ル";
                                break;
                            case 9:
                                tempmapping = "レ";
                                break;
                            case 10:
                                tempmapping = "ロ";
                                break;
                            case 11:
                                tempmapping = "ワ";
                                break;
                            case 12:
                                tempmapping = "ヲ";
                                break;
                            case 13:
                                tempmapping = "ン";
                                break;
                            case 14:
                                tempmapping = "ガ";
                                break;
                            case 15:
                                tempmapping = "ギ";
                                break;
                            case 16:
                                tempmapping = "グ";
                                break;
                            case 17:
                                tempmapping = "ゲ";
                                break;
                            case 18:
                                tempmapping = "ゴ";
                                break;
                            case 19:
                                tempmapping = "ザ";
                                break;
                            case 20:
                                tempmapping = "ジ";
                                break;
                            case 21:
                                tempmapping = "ズ";
                                break;
                            case 22:
                                tempmapping = "ゼ";
                                break;
                            case 23:
                                tempmapping = "ゾ";
                                break;
                            case 24:
                                tempmapping = "ダ";
                                break;
                            case 25:
                                tempmapping = "ヂ";
                                break;
                            case 26:
                                tempmapping = "ヅ";
                                break;
                            case 27:
                                tempmapping = "デ";
                                break;
                            case 28:
                                tempmapping = "ド";
                                break;
                            case 29:
                                tempmapping = "バ";
                                break;
                            case 30:
                                tempmapping = "ビ";
                                break;
                            case 31:
                                tempmapping = "ブ";
                                break;
                            case 32:
                                tempmapping = "ベ";
                                break;
                            case 33:
                                tempmapping = "ボ";
                                break;
                            case 34:
                                tempmapping = "ヴ";
                                break;
                            case 35:
                                tempmapping = "パ";
                                break;
                            case 36:
                                tempmapping = "ピ";
                                break;
                            case 37:
                                tempmapping = "プ";
                                break;
                            case 38:
                                tempmapping = "ペ";
                                break;
                            case 39:
                                tempmapping = "ポ";
                                break;
                            case 40:
                                tempmapping = "ァ";
                                break;
                            case 41:
                                tempmapping = "ィ";
                                break;
                            case 42:
                                tempmapping = "ゥ";
                                break;
                            case 43:
                                tempmapping = "ェ";
                                break;
                            case 44:
                                tempmapping = "ォ";
                                break;
                            case 45:
                                tempmapping = "ャ";
                                break;
                            case 46:
                                tempmapping = "ュ";
                                break;
                            case 47:
                                tempmapping = "ョ";
                                break;
                            case 48:
                                tempmapping = "ッ";
                                break;
                            case 49:
                                tempmapping = "端";
                                break;
                            case 50:
                                tempmapping = "子";
                                break;
                            case 51:
                                tempmapping = "接";
                                break;
                            case 52:
                                tempmapping = "続";
                                break;
                            case 53:
                                tempmapping = "正";
                                break;
                            case 54:
                                tempmapping = "常";
                                break;
                            case 55:
                                tempmapping = "発";
                                break;
                            case 56:
                                tempmapping = "生";
                                break;
                            case 57:
                                tempmapping = "使";
                                break;
                            case 58:
                                tempmapping = "用";
                                break;
                            case 59:
                                tempmapping = "専";
                                break;
                            case 60:
                                tempmapping = "付";
                                break;
                            case 61:
                                tempmapping = "属";
                                break;
                            case 62:
                                tempmapping = "取";
                                break;
                            case 63:
                                tempmapping = "扱";
                                break;
                            case 64:
                                tempmapping = "説";
                                break;
                            case 65:
                                tempmapping = "明";
                                break;
                            case 66:
                                tempmapping = "書";
                                break;
                            case 67:
                                tempmapping = "指";
                                break;
                            case 68:
                                tempmapping = "示";
                                break;
                            case 69:
                                tempmapping = "従";
                                break;
                            case 70:
                                tempmapping = "修";
                                break;
                            case 71:
                                tempmapping = "復";
                                break;
                            case 72:
                                tempmapping = "下";
                                break;
                            case 73:
                                tempmapping = "空";
                                break;
                            case 74:
                                tempmapping = "容";
                                break;
                            case 75:
                                tempmapping = "量";
                                break;
                            case 76:
                                tempmapping = "不";
                                break;
                            case 77:
                                tempmapping = "足";
                                break;
                            case 78:
                                tempmapping = "以";
                                break;
                            case 79:
                                tempmapping = "上";
                                break;
                            case 80:
                                tempmapping = "必";
                                break;
                            case 81:
                                tempmapping = "要";
                                break;
                            case 82:
                                tempmapping = "開";
                                break;
                            case 83:
                                tempmapping = "始";
                                break;
                            case 84:
                                tempmapping = "本";
                                break;
                            case 85:
                                tempmapping = "魔";
                                break;
                            case 86:
                                tempmapping = "石";
                                break;
                            case 87:
                                tempmapping = "晶";
                                break;
                            case 88:
                                tempmapping = "結";
                                break;
                            case 89:
                                tempmapping = "大";
                                break;
                            case 90:
                                tempmapping = "紋";
                                break;
                            case 91:
                                tempmapping = "盾";
                                break;
                            case 92:
                                tempmapping = "凍";
                                break;
                            case 93:
                                tempmapping = "透";
                                break;
                            case 94:
                                tempmapping = "燃";
                                break;
                            case 95:
                                tempmapping = "水";
                                break;
                            case 96:
                                tempmapping = "気";
                                break;
                            case 97:
                                tempmapping = "炎";
                                break;
                            case 98:
                                tempmapping = "士";
                                break;
                            case 99:
                                tempmapping = "守";
                                break;
                            case 100:
                                tempmapping = "証";
                                break;
                            case 101:
                                tempmapping = "吹";
                                break;
                            case 102:
                                tempmapping = "闘";
                                break;
                            case 103:
                                tempmapping = "力";
                                break;
                            case 104:
                                tempmapping = "木";
                                break;
                            case 105:
                                tempmapping = "人";
                                break;
                            case 106:
                                tempmapping = "飲";
                                break;
                            case 107:
                                tempmapping = "過";
                                break;
                            case 108:
                                tempmapping = "丸";
                                break;
                            case 109:
                                tempmapping = "騎";
                                break;
                            case 110:
                                tempmapping = "去";
                                break;
                            case 111:
                                tempmapping = "魚";
                                break;
                            case 112:
                                tempmapping = "剣";
                                break;
                            case 113:
                                tempmapping = "荒";
                                break;
                            case 114:
                                tempmapping = "氏";
                                break;
                            case 115:
                                tempmapping = "杖";
                                break;
                            case 116:
                                tempmapping = "束";
                                break;
                            case 117:
                                tempmapping = "太";
                                break;
                            case 118:
                                tempmapping = "鳥";
                                break;
                            case 119:
                                tempmapping = "導";
                                break;
                            case 120:
                                tempmapping = "布";
                                break;
                            case 121:
                                tempmapping = "風";
                                break;
                            case 122:
                                tempmapping = "満";
                                break;
                            case 123:
                                tempmapping = "約";
                                break;
                            case 124:
                                tempmapping = "源";
                                break;
                            case 125:
                                tempmapping = "出";
                                break;
                            case 126:
                                tempmapping = "実";
                                break;
                            case 127:
                                tempmapping = "海";
                                break;
                            case 128:
                                tempmapping = "思";
                                break;
                            case 129:
                                tempmapping = "王";
                                break;
                            case 130:
                                tempmapping = "自";
                                break;
                            case 131:
                                tempmapping = "名";
                                break;
                            case 132:
                                tempmapping = "喚";
                                break;
                            case 133:
                                tempmapping = "召";
                                break;
                            case 134:
                                tempmapping = "地";
                                break;
                            case 135:
                                tempmapping = "家";
                                break;
                            case 136:
                                tempmapping = "火";
                                break;
                            case 137:
                                tempmapping = "森";
                                break;
                            case 138:
                                tempmapping = "皆";
                                break;
                            case 139:
                                tempmapping = "許";
                                break;
                            case 140:
                                tempmapping = "怖";
                                break;
                            case 141:
                                tempmapping = "古";
                                break;
                            case 142:
                                tempmapping = "轟";
                                break;
                            case 143:
                                tempmapping = "魂";
                                break;
                            case 144:
                                tempmapping = "臭";
                                break;
                            case 145:
                                tempmapping = "章";
                                break;
                            case 146:
                                tempmapping = "雲";
                                break;
                            case 147:
                                tempmapping = "雪";
                                break;
                            case 148:
                                tempmapping = "然";
                                break;
                            case 149:
                                tempmapping = "達";
                                break;
                            case 150:
                                tempmapping = "嘆";
                                break;
                            case 151:
                                tempmapping = "潰";
                                break;
                            case 152:
                                tempmapping = "瓜";
                                break;
                            case 153:
                                tempmapping = "伝";
                                break;
                            case 154:
                                tempmapping = "怒";
                                break;
                            case 155:
                                tempmapping = "悲";
                                break;
                            case 156:
                                tempmapping = "怖";
                                break;
                            case 157:
                                tempmapping = "鳴";
                                break;
                            case 158:
                                tempmapping = "免";
                                break;
                            case 159:
                                tempmapping = "雷";
                                break;
                            case 160:
                                tempmapping = "林";
                                break;
                            case 161:
                                tempmapping = "様";
                                break;
                            case 162:
                                tempmapping = "巻";
                                break;
                            case 163:
                                tempmapping = "片";
                                break;
                            case 164:
                                tempmapping = "翼";
                                break;
                            case 165:
                                tempmapping = "天";
                                break;
                            case 166:
                                tempmapping = "則";
                                break;
                            case 167:
                                tempmapping = "四";
                                break;
                            case 168:
                                tempmapping = "掲";
                                break;
                            case 169:
                                tempmapping = "坂";
                                break;
                            case 170:
                                tempmapping = "登";
                                break;
                            case 171:
                                tempmapping = "孫";
                                break;
                        }
                    }
                    if (lastbyte == 26)
                    {
                        lastbyte = 0;
                        switch (kh2map)
                        {
                            case 1:
                                tempmapping = "誠";
                                break;
                            case 2:
                                tempmapping = "納";
                                break;
                            case 3:
                                tempmapping = "泡";
                                break;
                            case 4:
                                tempmapping = "程";
                                break;
                            case 5:
                                tempmapping = "析";
                                break;
                            case 6:
                                tempmapping = "遮";
                                break;
                            case 7:
                                tempmapping = "戒";
                                break;
                            case 8:
                                tempmapping = "井";
                                break;
                            case 9:
                                tempmapping = "及";
                                break;
                            case 10:
                                tempmapping = "模";
                                break;
                            case 11:
                                tempmapping = "算";
                                break;
                            case 12:
                                tempmapping = "霧";
                                break;
                            case 13:
                                tempmapping = "熟";
                                break;
                            case 14:
                                tempmapping = "＃";
                                break;
                            case 15:
                                tempmapping = "鈍";
                                break;
                            case 16:
                                tempmapping = "賭";
                                break;
                            case 17:
                                tempmapping = "欺";
                                break;
                            case 18:
                                tempmapping = "鹿";
                                break;
                            case 19:
                                tempmapping = "式";
                                break;
                            case 20:
                                tempmapping = "炸";
                                break;
                            case 21:
                                tempmapping = "裂";
                                break;
                            case 22:
                                tempmapping = "索";
                                break;
                            case 23:
                                tempmapping = "詮";
                                break;
                            case 24:
                                tempmapping = "眩";
                                break;
                            case 25:
                                tempmapping = "罠";
                                break;
                            case 26:
                                tempmapping = "千";
                                break;
                            case 27:
                                tempmapping = "塗";
                                break;
                            case 28:
                                tempmapping = "羽";
                                break;
                            case 29:
                                tempmapping = "柵";
                                break;
                            case 30:
                                tempmapping = "緊";
                                break;
                            case 31:
                                tempmapping = "粗";
                                break;
                            case 32:
                                tempmapping = "何";
                                break;
                            case 33:
                                tempmapping = "俺";
                                break;
                            case 34:
                                tempmapping = "行";
                                break;
                            case 35:
                                tempmapping = "世";
                                break;
                            case 36:
                                tempmapping = "界";
                                break;
                            case 37:
                                tempmapping = "紀";
                                break;
                            case 38:
                                tempmapping = "事";
                                break;
                            case 39:
                                tempmapping = "前";
                                break;
                            case 40:
                                tempmapping = "符";
                                break;
                            case 41:
                                tempmapping = "来";
                                break;
                            case 42:
                                tempmapping = "見";
                                break;
                            case 43:
                                tempmapping = "{一}";
                                break;
                            case 44:
                                tempmapping = "絡";
                                break;
                            case 45:
                                tempmapping = "分";
                                break;
                            case 46:
                                tempmapping = "寂";
                                break;
                            case 47:
                                tempmapping = "心";
                                break;
                            case 48:
                                tempmapping = "賃";
                                break;
                            case 49:
                                tempmapping = "言";
                                break;
                            case 50:
                                tempmapping = "物";
                                break;
                            case 51:
                                tempmapping = "知";
                                break;
                            case 52:
                                tempmapping = "外";
                                break;
                            case 53:
                                tempmapping = "君";
                                break;
                            case 54:
                                tempmapping = "私";
                                break;
                            case 55:
                                tempmapping = "宛";
                                break;
                            case 56:
                                tempmapping = "今";
                                break;
                            case 57:
                                tempmapping = "男";
                                break;
                            case 58:
                                tempmapping = "島";
                                break;
                            case 59:
                                tempmapping = "老";
                                break;
                            case 60:
                                tempmapping = "緒";
                                break;
                            case 61:
                                tempmapping = "幕";
                                break;
                            case 62:
                                tempmapping = "処";
                                break;
                            case 63:
                                tempmapping = "菓";
                                break;
                            case 64:
                                tempmapping = "場";
                                break;
                            case 65:
                                tempmapping = "鎖";
                                break;
                            case 66:
                                tempmapping = "食";
                                break;
                            case 67:
                                tempmapping = "夢";
                                break;
                            case 68:
                                tempmapping = "女";
                                break;
                            case 69:
                                tempmapping = "賞";
                                break;
                            case 70:
                                tempmapping = "所";
                                break;
                            case 71:
                                tempmapping = "者";
                                break;
                            case 72:
                                tempmapping = "時";
                                break;
                            case 73:
                                tempmapping = "消";
                                break;
                            case 74:
                                tempmapping = "探";
                                break;
                            case 75:
                                tempmapping = "当";
                                break;
                            case 76:
                                tempmapping = "無";
                                break;
                            case 77:
                                tempmapping = "儀";
                                break;
                            case 78:
                                tempmapping = "話";
                                break;
                            case 79:
                                tempmapping = "鍵";
                                break;
                            case 80:
                                tempmapping = "捜";
                                break;
                            case 81:
                                tempmapping = "中";
                                break;
                            case 82:
                                tempmapping = "目";
                                break;
                            case 83:
                                tempmapping = "公";
                                break;
                            case 84:
                                tempmapping = "声";
                                break;
                            case 85:
                                tempmapping = "謎";
                                break;
                            case 86:
                                tempmapping = "間";
                                break;
                            case 87:
                                tempmapping = "為";
                                break;
                            case 88:
                                tempmapping = "鍵";
                                break;
                            case 89:
                                tempmapping = "密";
                                break;
                            case 90:
                                tempmapping = "闇";
                                break;
                            case 91:
                                tempmapping = "掌";
                                break;
                            case 92:
                                tempmapping = "僕";
                                break;
                            case 93:
                                tempmapping = "留";
                                break;
                            case 94:
                                tempmapping = "句";
                                break;
                            case 95:
                                tempmapping = "般";
                                break;
                            case 96:
                                tempmapping = "誰";
                                break;
                            case 97:
                                tempmapping = "聞";
                                break;
                            case 98:
                                tempmapping = "連";
                                break;
                            case 99:
                                tempmapping = "夫";
                                break;
                            case 100:
                                tempmapping = "扉";
                                break;
                            case 101:
                                tempmapping = "統";
                                break;
                            case 102:
                                tempmapping = "顔";
                                break;
                            case 103:
                                tempmapping = "丈";
                                break;
                            case 104:
                                tempmapping = "少";
                                break;
                            case 105:
                                tempmapping = "我";
                                break;
                            case 106:
                                tempmapping = "他";
                                break;
                            case 107:
                                tempmapping = "立";
                                break;
                            case 108:
                                tempmapping = "合";
                                break;
                            case 109:
                                tempmapping = "助";
                                break;
                            case 110:
                                tempmapping = "対";
                                break;
                            case 111:
                                tempmapping = "刀";
                                break;
                            case 112:
                                tempmapping = "侮";
                                break;
                            case 113:
                                tempmapping = "辱";
                                break;
                            case 114:
                                tempmapping = "秘";
                                break;
                            case 115:
                                tempmapping = "通";
                                break;
                            case 116:
                                tempmapping = "頼";
                                break;
                            case 117:
                                tempmapping = "冒";
                                break;
                            case 118:
                                tempmapping = "帰";
                                break;
                            case 119:
                                tempmapping = "刑";
                                break;
                            case 120:
                                tempmapping = "夜";
                                break;
                            case 121:
                                tempmapping = "絶";
                                break;
                            case 122:
                                tempmapping = "船";
                                break;
                            case 123:
                                tempmapping = "即";
                                break;
                            case 124:
                                tempmapping = "方";
                                break;
                            case 125:
                                tempmapping = "込";
                                break;
                            case 126:
                                tempmapping = "全";
                                break;
                            case 127:
                                tempmapping = "良";
                                break;
                            case 128:
                                tempmapping = "忘";
                                break;
                            case 129:
                                tempmapping = "凱";
                                break;
                            case 130:
                                tempmapping = "追";
                                break;
                            case 131:
                                tempmapping = "旅";
                                break;
                            case 132:
                                tempmapping = "起";
                                break;
                            case 133:
                                tempmapping = "険";
                                break;
                            case 134:
                                tempmapping = "供";
                                break;
                            case 135:
                                tempmapping = "抜";
                                break;
                            case 136:
                                tempmapping = "遠";
                                break;
                            case 137:
                                tempmapping = "最";
                                break;
                            case 138:
                                tempmapping = "感";
                                break;
                            case 139:
                                tempmapping = "役";
                                break;
                            case 140:
                                tempmapping = "各";
                                break;
                            case 141:
                                tempmapping = "入";
                                break;
                            case 142:
                                tempmapping = "旋";
                                break;
                            case 143:
                                tempmapping = "遂";
                                break;
                            case 144:
                                tempmapping = "日";
                                break;
                            case 145:
                                tempmapping = "欠";
                                break;
                            case 146:
                                tempmapping = "堅";
                                break;
                            case 147:
                                tempmapping = "主";
                                break;
                            case 148:
                                tempmapping = "会";
                                break;
                            case 149:
                                tempmapping = "向";
                                break;
                            case 150:
                                tempmapping = "年";
                                break;
                            case 151:
                                tempmapping = "早";
                                break;
                            case 152:
                                tempmapping = "別";
                                break;
                            case 153:
                                tempmapping = "褒";
                                break;
                            case 154:
                                tempmapping = "宝";
                                break;
                            case 155:
                                tempmapping = "変";
                                break;
                            case 156:
                                tempmapping = "度";
                                break;
                            case 157:
                                tempmapping = "後";
                                break;
                            case 158:
                                tempmapping = "星";
                                break;
                            case 159:
                                tempmapping = "授";
                                break;
                            case 160:
                                tempmapping = "矢";
                                break;
                            case 161:
                                tempmapping = "配";
                                break;
                            case 162:
                                tempmapping = "現";
                                break;
                            case 163:
                                tempmapping = "覚";
                                break;
                            case 164:
                                tempmapping = "選";
                                break;
                            case 165:
                                tempmapping = "急";
                                break;
                            case 166:
                                tempmapping = "二";
                                break;
                            case 167:
                                tempmapping = "居";
                                break;
                            case 168:
                                tempmapping = "座";
                                break;
                            case 169:
                                tempmapping = "願";
                                break;
                            case 170:
                                tempmapping = "勝";
                                break;
                            case 171:
                                tempmapping = "怪";
                                break;
                            case 172:
                                tempmapping = "漁";
                                break;
                            case 173:
                                tempmapping = "鼻";
                                break;
                            case 174:
                                tempmapping = "影";
                                break;
                            case 175:
                                tempmapping = "違";
                                break;
                            case 176:
                                tempmapping = "離";
                                break;
                            case 177:
                                tempmapping = "遅";
                                break;
                            case 178:
                                tempmapping = "訣";
                                break;
                            case 179:
                                tempmapping = "繋";
                                break;
                            case 180:
                                tempmapping = "視";
                                break;
                            case 181:
                                tempmapping = "勇";
                                break;
                            case 182:
                                tempmapping = "笑";
                                break;
                            case 183:
                                tempmapping = "奪";
                                break;
                            case 184:
                                tempmapping = "馳";
                                break;
                            case 185:
                                tempmapping = "々";
                                break;
                            case 186:
                                tempmapping = "切";
                                break;
                            case 187:
                                tempmapping = "厄";
                                break;
                            case 188:
                                tempmapping = "父";
                                break;
                            case 189:
                                tempmapping = "犬";
                                break;
                            case 190:
                                tempmapping = "白";
                                break;
                            case 191:
                                tempmapping = "跳";
                                break;
                            case 192:
                                tempmapping = "祝";
                                break;
                            case 193:
                                tempmapping = "仮";
                                break;
                            case 194:
                                tempmapping = "強";
                                break;
                            case 195:
                                tempmapping = "押";
                                break;
                            case 196:
                                tempmapping = "仲";
                                break;
                            case 197:
                                tempmapping = "面";
                                break;
                            case 198:
                                tempmapping = "毛";
                                break;
                            case 199:
                                tempmapping = "回";
                                break;
                            case 200:
                                tempmapping = "倒";
                                break;
                            case 201:
                                tempmapping = "拒";
                                break;
                            case 202:
                                tempmapping = "持";
                                break;
                            case 203:
                                tempmapping = "画";
                                break;
                            case 204:
                                tempmapping = "近";
                                break;
                            case 205:
                                tempmapping = "戻";
                                break;
                            case 206:
                                tempmapping = "望";
                                break;
                            case 207:
                                tempmapping = "負";
                                break;
                            case 208:
                                tempmapping = "傷";
                                break;
                            case 209:
                                tempmapping = "刀";
                                break;
                            case 210:
                                tempmapping = "拐";
                                break;
                            case 211:
                                tempmapping = "優";
                                break;
                            case 212:
                                tempmapping = "内";
                                break;
                            case 213:
                                tempmapping = "赦";
                                break;
                            case 214:
                                tempmapping = "秒";
                                break;
                            case 215:
                                tempmapping = "数";
                                break;
                            case 216:
                                tempmapping = "敵";
                                break;
                            case 217:
                                tempmapping = "槍";
                                break;
                            case 218:
                                tempmapping = "珍";
                                break;
                            case 219:
                                tempmapping = "姿";
                                break;
                            case 220:
                                tempmapping = "歩";
                                break;
                            case 221:
                                tempmapping = "左";
                                break;
                            case 222:
                                tempmapping = "英";
                                break;
                            case 223:
                                tempmapping = "雄";
                                break;
                            case 224:
                                tempmapping = "破";
                                break;
                            case 225:
                                tempmapping = "求";
                                break;
                            case 226:
                                tempmapping = "鷹";
                                break;
                            case 227:
                                tempmapping = "周";
                                break;
                            case 228:
                                tempmapping = "蹴";
                                break;
                            case 229:
                                tempmapping = "費";
                                break;
                            case 230:
                                tempmapping = "衝";
                                break;
                            case 231:
                                tempmapping = "狙";
                                break;
                            case 232:
                                tempmapping = "経";
                                break;
                            case 233:
                                tempmapping = "験";
                                break;
                            case 234:
                                tempmapping = "値";
                                break;
                            case 235:
                                tempmapping = "便";
                                break;
                            case 236:
                                tempmapping = "表";
                                break;
                            case 237:
                                tempmapping = "歳";
                                break;
                            case 238:
                                tempmapping = "元";
                                break;
                            case 239:
                                tempmapping = "災";
                                break;
                            case 240:
                                tempmapping = "先";
                                break;
                            case 241:
                                tempmapping = "宙";
                                break;
                            case 242:
                                tempmapping = "残";
                                break;
                            case 243:
                                tempmapping = "閉";
                                break;
                            case 244:
                                tempmapping = "移";
                                break;
                            case 245:
                                tempmapping = "動";
                                break;
                            case 246:
                                tempmapping = "走";
                                break;
                            case 247:
                                tempmapping = "眠";
                                break;
                            case 248:
                                tempmapping = "与";
                                break;
                            case 249:
                                tempmapping = "敢";
                                break;
                            case 250:
                                tempmapping = "壊";
                                break;
                            case 251:
                                tempmapping = "臆";
                                break;
                            case 252:
                                tempmapping = "病";
                                break;
                            case 253:
                                tempmapping = "犠";
                                break;
                            case 254:
                                tempmapping = "牲";
                                break;
                            case 255:
                                tempmapping = "滅";
                                break;
                        }
                    }
                    if (lastbyte == 27)
                    {
                        lastbyte = 0;
                        switch (kh2map)
                        {
                            case 0:
                                tempmapping = "竜";
                                break;
                            case 1:
                                tempmapping = "床";
                                break;
                            case 2:
                                tempmapping = "落";
                                break;
                            case 3:
                                tempmapping = "思";
                                break;
                            case 4:
                                tempmapping = "踏";
                                break;
                            case 5:
                                tempmapping = "特";
                                break;
                            case 6:
                                tempmapping = "加";
                                break;
                            case 7:
                                tempmapping = "停";
                                break;
                            case 8:
                                tempmapping = "応";
                                break;
                            case 9:
                                tempmapping = "化";
                                break;
                            case 10:
                                tempmapping = "右";
                                break;
                            case 11:
                                tempmapping = "死";
                                break;
                            case 12:
                                tempmapping = "襲";
                                break;
                            case 13:
                                tempmapping = "由";
                                break;
                            case 14:
                                tempmapping = "進";
                                break;
                            case 15:
                                tempmapping = "滑";
                                break;
                            case 16:
                                tempmapping = "陽";
                                break;
                            case 17:
                                tempmapping = "頭";
                                break;
                            case 18:
                                tempmapping = "済";
                                break;
                            case 19:
                                tempmapping = "限";
                                break;
                            case 20:
                                tempmapping = "昼";
                                break;
                            case 21:
                                tempmapping = "五";
                                break;
                            case 22:
                                tempmapping = "楽";
                                break;
                            case 23:
                                tempmapping = "道";
                                break;
                            case 24:
                                tempmapping = "昇";
                                break;
                            case 25:
                                tempmapping = "朝";
                                break;
                            case 26:
                                tempmapping = "照";
                                break;
                            case 27:
                                tempmapping = "確";
                                break;
                            case 28:
                                tempmapping = "甲";
                                break;
                            case 29:
                                tempmapping = "更";
                                break;
                            case 30:
                                tempmapping = "辿";
                                break;
                            case 31:
                                tempmapping = "着";
                                break;
                            case 32:
                                tempmapping = "断";
                                break;
                            case 33:
                                tempmapping = "途";
                                break;
                            case 34:
                                tempmapping = "光";
                                break;
                            case 35:
                                tempmapping = "身";
                                break;
                            case 36:
                                tempmapping = "番";
                                break;
                            case 37:
                                tempmapping = "武";
                                break;
                            case 38:
                                tempmapping = "器";
                                break;
                            case 39:
                                tempmapping = "考";
                                break;
                            case 40:
                                tempmapping = "傑";
                                break;
                            case 41:
                                tempmapping = "性";
                                break;
                            case 42:
                                tempmapping = "意";
                                break;
                            case 43:
                                tempmapping = "味";
                                break;
                            case 44:
                                tempmapping = "同";
                                break;
                            case 45:
                                tempmapping = "景";
                                break;
                            case 46:
                                tempmapping = "色";
                                break;
                            case 47:
                                tempmapping = "長";
                                break;
                            case 48:
                                tempmapping = "待";
                                break;
                            case 49:
                                tempmapping = "彼";
                                break;
                            case 50:
                                tempmapping = "悪";
                                break;
                            case 51:
                                tempmapping = "穴";
                                break;
                            case 52:
                                tempmapping = "飛";
                                break;
                            case 53:
                                tempmapping = "友";
                                break;
                            case 54:
                                tempmapping = "集";
                                break;
                            case 55:
                                tempmapping = "植";
                                break;
                            case 56:
                                tempmapping = "逃";
                                break;
                            case 57:
                                tempmapping = "雅";
                                break;
                            case 58:
                                tempmapping = "料";
                                break;
                            case 59:
                                tempmapping = "街";
                                break;
                            case 60:
                                tempmapping = "幸";
                                break;
                            case 61:
                                tempmapping = "危";
                                break;
                            case 62:
                                tempmapping = "決";
                                break;
                            case 63:
                                tempmapping = "房";
                                break;
                            case 64:
                                tempmapping = "記";
                                break;
                            case 65:
                                tempmapping = "判";
                                break;
                            case 66:
                                tempmapping = "掃";
                                break;
                            case 67:
                                tempmapping = "部";
                                break;
                            case 68:
                                tempmapping = "備";
                                break;
                            case 69:
                                tempmapping = "完";
                                break;
                            case 70:
                                tempmapping = "隠";
                                break;
                            case 71:
                                tempmapping = "試";
                                break;
                            case 72:
                                tempmapping = "遊";
                                break;
                            case 73:
                                tempmapping = "姫";
                                break;
                            case 74:
                                tempmapping = "形";
                                break;
                            case 75:
                                tempmapping = "撫";
                                break;
                            case 76:
                                tempmapping = "規";
                                break;
                            case 77:
                                tempmapping = "材";
                                break;
                            case 78:
                                tempmapping = "成";
                                break;
                            case 79:
                                tempmapping = "置";
                                break;
                            case 80:
                                tempmapping = "尾";
                                break;
                            case 81:
                                tempmapping = "計";
                                break;
                            case 82:
                                tempmapping = "作";
                                break;
                            case 83:
                                tempmapping = "準";
                                break;
                            case 84:
                                tempmapping = "卵";
                                break;
                            case 85:
                                tempmapping = "仕";
                                break;
                            case 86:
                                tempmapping = "命";
                                break;
                            case 87:
                                tempmapping = "真";
                                break;
                            case 88:
                                tempmapping = "音";
                                break;
                            case 89:
                                tempmapping = "宮";
                                break;
                            case 90:
                                tempmapping = "裁";
                                break;
                            case 91:
                                tempmapping = "娘";
                                break;
                            case 92:
                                tempmapping = "聴";
                                break;
                            case 93:
                                tempmapping = "嘘";
                                break;
                            case 94:
                                tempmapping = "殿";
                                break;
                            case 95:
                                tempmapping = "憶";
                                break;
                            case 96:
                                tempmapping = "信";
                                break;
                            case 97:
                                tempmapping = "城";
                                break;
                            case 98:
                                tempmapping = "奴";
                                break;
                            case 99:
                                tempmapping = "福";
                                break;
                            case 100:
                                tempmapping = "返";
                                break;
                            case 101:
                                tempmapping = "己";
                                break;
                            case 102:
                                tempmapping = "拠";
                                break;
                            case 103:
                                tempmapping = "戦";
                                break;
                            case 104:
                                tempmapping = "冗";
                                break;
                            case 105:
                                tempmapping = "談";
                                break;
                            case 106:
                                tempmapping = "康";
                                break;
                            case 107:
                                tempmapping = "答";
                                break;
                            case 108:
                                tempmapping = "弱";
                                break;
                            case 109:
                                tempmapping = "黙";
                                break;
                            case 110:
                                tempmapping = "呑";
                                break;
                            case 111:
                                tempmapping = "欲";
                                break;
                            case 112:
                                tempmapping = "理";
                                break;
                            case 113:
                                tempmapping = "調";
                                break;
                            case 114:
                                tempmapping = "犯";
                                break;
                            case 115:
                                tempmapping = "予";
                                break;
                            case 116:
                                tempmapping = "止";
                                break;
                            case 117:
                                tempmapping = "博";
                                break;
                            case 118:
                                tempmapping = "件";
                                break;
                            case 119:
                                tempmapping = "解";
                                break;
                            case 120:
                                tempmapping = "削";
                                break;
                            case 121:
                                tempmapping = "舎";
                                break;
                            case 122:
                                tempmapping = "渡";
                                break;
                            case 123:
                                tempmapping = "深";
                                break;
                            case 124:
                                tempmapping = "策";
                                break;
                            case 125:
                                tempmapping = "屈";
                                break;
                            case 126:
                                tempmapping = "装";
                                break;
                            case 127:
                                tempmapping = "努";
                                break;
                            case 128:
                                tempmapping = "挽";
                                break;
                            case 129:
                                tempmapping = "捕";
                                break;
                            case 130:
                                tempmapping = "失";
                                break;
                            case 131:
                                tempmapping = "刻";
                                break;
                            case 132:
                                tempmapping = "例";
                                break;
                            case 133:
                                tempmapping = "息";
                                break;
                            case 134:
                                tempmapping = "航";
                                break;
                            case 135:
                                tempmapping = "敗";
                                break;
                            case 136:
                                tempmapping = "得";
                                break;
                            case 137:
                                tempmapping = "訳";
                                break;
                            case 138:
                                tempmapping = "放";
                                break;
                            case 139:
                                tempmapping = "矛";
                                break;
                            case 140:
                                tempmapping = "告";
                                break;
                            case 141:
                                tempmapping = "罪";
                                break;
                            case 142:
                                tempmapping = "次";
                                break;
                            case 143:
                                tempmapping = "参";
                                break;
                            case 144:
                                tempmapping = "機";
                                break;
                            case 145:
                                tempmapping = "巣";
                                break;
                            case 146:
                                tempmapping = "金";
                                break;
                            case 147:
                                tempmapping = "情";
                                break;
                            case 148:
                                tempmapping = "令";
                                break;
                            case 149:
                                tempmapping = "貸";
                                break;
                            case 150:
                                tempmapping = "突";
                                break;
                            case 151:
                                tempmapping = "円";
                                break;
                            case 152:
                                tempmapping = "妙";
                                break;
                            case 153:
                                tempmapping = "録";
                                break;
                            case 154:
                                tempmapping = "笛";
                                break;
                            case 155:
                                tempmapping = "境";
                                break;
                            case 156:
                                tempmapping = "田";
                                break;
                            case 157:
                                tempmapping = "秀";
                                break;
                            case 158:
                                tempmapping = "根";
                                break;
                            case 159:
                                tempmapping = "相";
                                break;
                            case 160:
                                tempmapping = "終";
                                break;
                            case 161:
                                tempmapping = "広";
                                break;
                            case 162:
                                tempmapping = "乗";
                                break;
                            case 163:
                                tempmapping = "駄";
                                break;
                            case 164:
                                tempmapping = "的";
                                break;
                            case 165:
                                tempmapping = "宇";
                                break;
                            case 166:
                                tempmapping = "邪";
                                break;
                            case 167:
                                tempmapping = "冷";
                                break;
                            case 168:
                                tempmapping = "投";
                                break;
                            case 169:
                                tempmapping = "呼";
                                break;
                            case 170:
                                tempmapping = "葉";
                                break;
                            case 171:
                                tempmapping = "暴";
                                break;
                            case 172:
                                tempmapping = "百";
                                break;
                            case 173:
                                tempmapping = "黄";
                                break;
                            case 174:
                                tempmapping = "新";
                                break;
                            case 175:
                                tempmapping = "町";
                                break;
                            case 176:
                                tempmapping = "喰";
                                break;
                            case 177:
                                tempmapping = "捨";
                                break;
                            case 178:
                                tempmapping = "避";
                                break;
                            case 179:
                                tempmapping = "妃";
                                break;
                            case 180:
                                tempmapping = "安";
                                break;
                            case 181:
                                tempmapping = "頃";
                                break;
                            case 182:
                                tempmapping = "枚";
                                break;
                            case 183:
                                tempmapping = "尻";
                                break;
                            case 184:
                                tempmapping = "没";
                                break;
                            case 185:
                                tempmapping = "嵐";
                                break;
                            case 186:
                                tempmapping = "季";
                                break;
                            case 187:
                                tempmapping = "節";
                                break;
                            case 188:
                                tempmapping = "困";
                                break;
                            case 189:
                                tempmapping = "悔";
                                break;
                            case 190:
                                tempmapping = "汽";
                                break;
                            case 191:
                                tempmapping = "暗";
                                break;
                            case 192:
                                tempmapping = "排";
                                break;
                            case 193:
                                tempmapping = "体";
                                break;
                            case 194:
                                tempmapping = "状";
                                break;
                            case 195:
                                tempmapping = "況";
                                break;
                            case 196:
                                tempmapping = "流";
                                break;
                            case 197:
                                tempmapping = "条";
                                break;
                            case 198:
                                tempmapping = "希";
                                break;
                            case 199:
                                tempmapping = "店";
                                break;
                            case 200:
                                tempmapping = "被";
                                break;
                            case 201:
                                tempmapping = "再";
                                break;
                            case 202:
                                tempmapping = "第";
                                break;
                            case 203:
                                tempmapping = "僧";
                                break;
                            case 204:
                                tempmapping = "練";
                                break;
                            case 205:
                                tempmapping = "習";
                                break;
                            case 206:
                                tempmapping = "末";
                                break;
                            case 207:
                                tempmapping = "契";
                                break;
                            case 208:
                                tempmapping = "果";
                                break;
                            case 209:
                                tempmapping = "可";
                                break;
                            case 210:
                                tempmapping = "族";
                                break;
                            case 211:
                                tempmapping = "滝";
                                break;
                            case 212:
                                tempmapping = "反";
                                break;
                            case 213:
                                tempmapping = "組";
                                break;
                            case 214:
                                tempmapping = "多";
                                break;
                            case 215:
                                tempmapping = "協";
                                break;
                            case 216:
                                tempmapping = "支";
                                break;
                            case 217:
                                tempmapping = "念";
                                break;
                            case 218:
                                tempmapping = "了";
                                break;
                            case 219:
                                tempmapping = "誘";
                                break;
                            case 220:
                                tempmapping = "卒";
                                break;
                            case 221:
                                tempmapping = "業";
                                break;
                            case 222:
                                tempmapping = "泳";
                                break;
                            case 223:
                                tempmapping = "嬢";
                                break;
                            case 224:
                                tempmapping = "灯";
                                break;
                            case 225:
                                tempmapping = "賊";
                                break;
                            case 226:
                                tempmapping = "張";
                                break;
                            case 227:
                                tempmapping = "嫌";
                                break;
                            case 228:
                                tempmapping = "員";
                                break;
                            case 229:
                                tempmapping = "隊";
                                break;
                            case 230:
                                tempmapping = "争";
                                break;
                            case 231:
                                tempmapping = "服";
                                break;
                            case 232:
                                tempmapping = "黒";
                                break;
                            case 233:
                                tempmapping = "→";
                                break;
                            case 234:
                                tempmapping = "←";
                                break;
                            case 235:
                                tempmapping = "口";
                                break;
                            case 236:
                                tempmapping = "忙";
                                break;
                            case 237:
                                tempmapping = "映";
                                break;
                            case 238:
                                tempmapping = "写";
                                break;
                            case 239:
                                tempmapping = "砂";
                                break;
                            case 240:
                                tempmapping = "漠";
                                break;
                            case 241:
                                tempmapping = "妖";
                                break;
                            case 242:
                                tempmapping = "精";
                                break;
                            case 243:
                                tempmapping = "粉";
                                break;
                            case 244:
                                tempmapping = "存";
                                break;
                            case 245:
                                tempmapping = "在";
                                break;
                            case 246:
                                tempmapping = "♪";
                                break;
                            case 247:
                                tempmapping = "野";
                                break;
                            case 248:
                                tempmapping = "郎";
                                break;
                            case 249:
                                tempmapping = "降";
                                break;
                            case 250:
                                tempmapping = "想";
                                break;
                            case 251:
                                tempmapping = "像";
                                break;
                            case 252:
                                tempmapping = "数";
                                break;
                            case 253:
                                tempmapping = "激";
                                break;
                            case 254:
                                tempmapping = "国";
                                break;
                            case 255:
                                tempmapping = "務";
                                break;
                        }
                    }
                    if (lastbyte == 28)
                    {
                        lastbyte = 0;
                        switch (kh2map)
                        {
                            case 0:
                                tempmapping = "操";
                                break;
                            case 1:
                                tempmapping = "縦";
                                break;
                            case 2:
                                tempmapping = "洞";
                                break;
                            case 3:
                                tempmapping = "整";
                                break;
                            case 4:
                                tempmapping = "鼓";
                                break;
                            case 5:
                                tempmapping = "室";
                                break;
                            case 6:
                                tempmapping = "屋";
                                break;
                            case 7:
                                tempmapping = "貝";
                                break;
                            case 8:
                                tempmapping = "騒";
                                break;
                            case 9:
                                tempmapping = "問";
                                break;
                            case 10:
                                tempmapping = "題";
                                break;
                            case 11:
                                tempmapping = "簡";
                                break;
                            case 12:
                                tempmapping = "単";
                                break;
                            case 13:
                                tempmapping = "関";
                                break;
                            case 14:
                                tempmapping = "係";
                                break;
                            case 15:
                                tempmapping = "祈";
                                break;
                            case 16:
                                tempmapping = "辺";
                                break;
                            case 17:
                                tempmapping = "昔";
                                break;
                            case 18:
                                tempmapping = "匹";
                                break;
                            case 19:
                                tempmapping = "母";
                                break;
                            case 20:
                                tempmapping = "礼";
                                break;
                            case 21:
                                tempmapping = "任";
                                break;
                            case 22:
                                tempmapping = "腹";
                                break;
                            case 23:
                                tempmapping = "輩";
                                break;
                            case 24:
                                tempmapping = "侵";
                                break;
                            case 25:
                                tempmapping = "非";
                                break;
                            case 26:
                                tempmapping = "距";
                                break;
                            case 27:
                                tempmapping = "学";
                                break;
                            case 28:
                                tempmapping = "愚";
                                break;
                            case 29:
                                tempmapping = "点";
                                break;
                            case 30:
                                tempmapping = "活";
                                break;
                            case 31:
                                tempmapping = "躍";
                                break;
                            case 32:
                                tempmapping = "臣";
                                break;
                            case 33:
                                tempmapping = "喜";
                                break;
                            case 34:
                                tempmapping = "板";
                                break;
                            case 35:
                                tempmapping = "岩";
                                break;
                            case 36:
                                tempmapping = "茶";
                                break;
                            case 37:
                                tempmapping = "異";
                                break;
                            case 38:
                                tempmapping = "線";
                                break;
                            case 39:
                                tempmapping = "沈";
                                break;
                            case 40:
                                tempmapping = "迷";
                                break;
                            case 41:
                                tempmapping = "働";
                                break;
                            case 42:
                                tempmapping = "秩";
                                break;
                            case 43:
                                tempmapping = "序";
                                break;
                            case 44:
                                tempmapping = "規";
                                break;
                            case 45:
                                tempmapping = "＃";
                                break;
                            case 46:
                                tempmapping = "貴";
                                break;
                            case 47:
                                tempmapping = "送";
                                break;
                            case 48:
                                tempmapping = "静";
                                break;
                            case 49:
                                tempmapping = "初";
                                break;
                            case 50:
                                tempmapping = "六";
                                break;
                            case 51:
                                tempmapping = "払";
                                break;
                            case 52:
                                tempmapping = "客";
                                break;
                            case 53:
                                tempmapping = "薬";
                                break;
                            case 54:
                                tempmapping = "暮";
                                break;
                            case 55:
                                tempmapping = "青";
                                break;
                            case 56:
                                tempmapping = "諸";
                                break;
                            case 57:
                                tempmapping = "舵";
                                break;
                            case 58:
                                tempmapping = "旗";
                                break;
                            case 59:
                                tempmapping = "廃";
                                break;
                            case 60:
                                tempmapping = "墟";
                                break;
                            case 61:
                                tempmapping = "陰";
                                break;
                            case 62:
                                tempmapping = "奇";
                                break;
                            case 63:
                                tempmapping = "懐";
                                break;
                            case 64:
                                tempmapping = "染";
                                break;
                            case 65:
                                tempmapping = "横";
                                break;
                            case 66:
                                tempmapping = "響";
                                break;
                            case 67:
                                tempmapping = "逆";
                                break;
                            case 68:
                                tempmapping = "苦";
                                break;
                            case 69:
                                tempmapping = "威";
                                break;
                            case 70:
                                tempmapping = "廷";
                                break;
                            case 71:
                                tempmapping = "育";
                                break;
                            case 72:
                                tempmapping = "群";
                                break;
                            case 73:
                                tempmapping = "悟";
                                break;
                            case 74:
                                tempmapping = "奥";
                                break;
                            case 75:
                                tempmapping = "査";
                                break;
                            case 76:
                                tempmapping = "慎";
                                break;
                            case 77:
                                tempmapping = "好";
                                break;
                            case 78:
                                tempmapping = "利";
                                break;
                            case 79:
                                tempmapping = "有";
                                break;
                            case 80:
                                tempmapping = "住";
                                break;
                            case 81:
                                tempmapping = "平";
                                break;
                            case 82:
                                tempmapping = "和";
                                break;
                            case 83:
                                tempmapping = "壁";
                                break;
                            case 84:
                                tempmapping = "瞬";
                                break;
                            case 85:
                                tempmapping = "難";
                                break;
                            case 86:
                                tempmapping = "干";
                                break;
                            case 87:
                                tempmapping = "渉";
                                break;
                            case 88:
                                tempmapping = "乱";
                                break;
                            case 89:
                                tempmapping = "窟";
                                break;
                            case 90:
                                tempmapping = "窓";
                                break;
                            case 91:
                                tempmapping = "研";
                                break;
                            case 92:
                                tempmapping = "究";
                                break;
                            case 93:
                                tempmapping = "香";
                                break;
                            case 94:
                                tempmapping = "台";
                                break;
                            case 95:
                                tempmapping = "ヶ";
                                break;
                            case 96:
                                tempmapping = "救";
                                break;
                            case 97:
                                tempmapping = "態";
                                break;
                            case 98:
                                tempmapping = "村";
                                break;
                            case 99:
                                tempmapping = "驚";
                                break;
                            case 100:
                                tempmapping = "伸";
                                break;
                            case 101:
                                tempmapping = "咲";
                                break;
                            case 102:
                                tempmapping = "繁";
                                break;
                            case 103:
                                tempmapping = "価";
                                break;
                            case 104:
                                tempmapping = "甘";
                                break;
                            case 105:
                                tempmapping = "獲";
                                break;
                            case 106:
                                tempmapping = "案";
                                break;
                            case 107:
                                tempmapping = "誤";
                                break;
                            case 108:
                                tempmapping = "賛";
                                break;
                            case 109:
                                tempmapping = "舞";
                                break;
                            case 110:
                                tempmapping = "迎";
                                break;
                            case 111:
                                tempmapping = "保";
                                break;
                            case 112:
                                tempmapping = "識";
                                break;
                            case 113:
                                tempmapping = "庫";
                                break;
                            case 114:
                                tempmapping = "慣";
                                break;
                            case 115:
                                tempmapping = "冠";
                                break;
                            case 116:
                                tempmapping = "魅";
                                break;
                            case 117:
                                tempmapping = "増";
                                break;
                            case 118:
                                tempmapping = "狐";
                                break;
                            case 119:
                                tempmapping = "握";
                                break;
                            case 120:
                                tempmapping = "班";
                                break;
                            case 121:
                                tempmapping = "散";
                                break;
                            case 122:
                                tempmapping = "転";
                                break;
                            case 123:
                                tempmapping = "弁";
                                break;
                            case 124:
                                tempmapping = "至";
                                break;
                            case 125:
                                tempmapping = "律";
                                break;
                            case 126:
                                tempmapping = "亡";
                                break;
                            case 127:
                                tempmapping = "万";
                                break;
                            case 128:
                                tempmapping = "油";
                                break;
                            case 129:
                                tempmapping = "等";
                                break;
                            case 130:
                                tempmapping = "席";
                                break;
                            case 131:
                                tempmapping = "興";
                                break;
                            case 132:
                                tempmapping = "局";
                                break;
                            case 133:
                                tempmapping = "位";
                                break;
                            case 134:
                                tempmapping = "図";
                                break;
                            case 135:
                                tempmapping = "宿";
                                break;
                            case 136:
                                tempmapping = "申";
                                break;
                            case 137:
                                tempmapping = "憎";
                                break;
                            case 138:
                                tempmapping = "焼";
                                break;
                            case 139:
                                tempmapping = "惑";
                                break;
                            case 140:
                                tempmapping = "凶";
                                break;
                            case 141:
                                tempmapping = "北";
                                break;
                            case 142:
                                tempmapping = "謝";
                                break;
                            case 143:
                                tempmapping = "議";
                                break;
                            case 144:
                                tempmapping = "紹";
                                break;
                            case 145:
                                tempmapping = "介";
                                break;
                            case 146:
                                tempmapping = "複";
                                break;
                            case 147:
                                tempmapping = "雑";
                                break;
                            case 148:
                                tempmapping = "才";
                                break;
                            case 149:
                                tempmapping = "虜";
                                break;
                            case 150:
                                tempmapping = "恩";
                                break;
                            case 151:
                                tempmapping = "順";
                                break;
                            case 152:
                                tempmapping = "格";
                                break;
                            case 153:
                                tempmapping = "皮";
                                break;
                            case 154:
                                tempmapping = "質";
                                break;
                            case 155:
                                tempmapping = "雨";
                                break;
                            case 156:
                                tempmapping = "直";
                                break;
                            case 157:
                                tempmapping = "胸";
                                break;
                            case 158:
                                tempmapping = "近";
                                break;
                            case 159:
                                tempmapping = "媒";
                                break;
                            case 160:
                                tempmapping = "路";
                                break;
                            case 161:
                                tempmapping = "未";
                                break;
                            case 162:
                                tempmapping = "吸";
                                break;
                            case 163:
                                tempmapping = "志";
                                break;
                            case 164:
                                tempmapping = "封";
                                break;
                            case 165:
                                tempmapping = "土";
                                break;
                            case 166:
                                tempmapping = "牢";
                                break;
                            case 167:
                                tempmapping = "獄";
                                break;
                            case 168:
                                tempmapping = "溶";
                                break;
                            case 169:
                                tempmapping = "哀";
                                break;
                            case 170:
                                tempmapping = "届";
                                break;
                            case 171:
                                tempmapping = "徒";
                                break;
                            case 172:
                                tempmapping = "択";
                                break;
                            case 173:
                                tempmapping = "勢";
                                break;
                            case 174:
                                tempmapping = "踊";
                                break;
                            case 175:
                                tempmapping = "祭";
                                break;
                            case 176:
                                tempmapping = "叩";
                                break;
                            case 177:
                                tempmapping = "叱";
                                break;
                            case 178:
                                tempmapping = "厳";
                                break;
                            case 179:
                                tempmapping = "報";
                                break;
                            case 180:
                                tempmapping = "寸";
                                break;
                            case 181:
                                tempmapping = "似";
                                break;
                            case 182:
                                tempmapping = "引";
                                break;
                            case 183:
                                tempmapping = "受";
                                break;
                            case 184:
                                tempmapping = "囲";
                                break;
                            case 185:
                                tempmapping = "振";
                                break;
                            case 186:
                                tempmapping = "＃";
                                break;
                            case 187:
                                tempmapping = "嬉";
                                break;
                            case 188:
                                tempmapping = "背";
                                break;
                            case 189:
                                tempmapping = "曲";
                                break;
                            case 190:
                                tempmapping = "芽";
                                break;
                            case 191:
                                tempmapping = "偶";
                                break;
                            case 192:
                                tempmapping = "借";
                                break;
                            case 193:
                                tempmapping = "休";
                                break;
                            case 194:
                                tempmapping = "伏";
                                break;
                            case 195:
                                tempmapping = "陛";
                                break;
                            case 196:
                                tempmapping = "除";
                                break;
                            case 197:
                                tempmapping = "緑";
                                break;
                            case 198:
                                tempmapping = "換";
                                break;
                            case 199:
                                tempmapping = "舟";
                                break;
                            case 200:
                                tempmapping = "覆";
                                break;
                            case 201:
                                tempmapping = "叶";
                                break;
                            case 202:
                                tempmapping = "{a}";
                                break;
                            case 203:
                                tempmapping = "詳";
                                break;
                            case 204:
                                tempmapping = "焦";
                                break;
                            case 205:
                                tempmapping = "惜";
                                break;
                            case 206:
                                tempmapping = "久";
                                break;
                            case 207:
                                tempmapping = "企";
                                break;
                            case 208:
                                tempmapping = "互";
                                break;
                            case 209:
                                tempmapping = "招";
                                break;
                            case 210:
                                tempmapping = "汚";
                                break;
                            case 211:
                                tempmapping = "差";
                                break;
                            case 212:
                                tempmapping = "塔";
                                break;
                            case 213:
                                tempmapping = "吐";
                                break;
                            case 214:
                                tempmapping = "渦";
                                break;
                            case 215:
                                tempmapping = "{e}";
                                break;
                            case 216:
                                tempmapping = "狭";
                                break;
                            case 217:
                                tempmapping = "尽";
                                break;
                            case 218:
                                tempmapping = "構";
                                break;
                            case 219:
                                tempmapping = "固";
                                break;
                            case 220:
                                tempmapping = "紙";
                                break;
                            case 221:
                                tempmapping = "読";
                                break;
                            case 222:
                                tempmapping = "{i}";
                                break;
                            case 223:
                                tempmapping = "競";
                                break;
                            case 224:
                                tempmapping = "姉";
                                break;
                            case 225:
                                tempmapping = "検";
                                break;
                            case 226:
                                tempmapping = "審";
                                break;
                            case 227:
                                tempmapping = "担";
                                break;
                            case 228:
                                tempmapping = "売";
                                break;
                            case 229:
                                tempmapping = "買";
                                break;
                            case 230:
                                tempmapping = "率";
                                break;
                            case 231:
                                tempmapping = "{k}";
                                break;
                            case 232:
                                tempmapping = "美";
                                break;
                            case 233:
                                tempmapping = "獣";
                                break;
                            case 234:
                                tempmapping = "兵";
                                break;
                            case 235:
                                tempmapping = "{n}";
                                break;
                            case 236:
                                tempmapping = "{o}";
                                break;
                            case 237:
                                tempmapping = "冥";
                                break;
                            case 238:
                                tempmapping = "短";
                                break;
                            case 239:
                                tempmapping = "忠";
                                break;
                            case 240:
                                tempmapping = "盗";
                                break;
                            case 241:
                                tempmapping = "赤";
                                break;
                            case 242:
                                tempmapping = "耳";
                                break;
                            case 243:
                                tempmapping = "故";
                                break;
                            case 244:
                                tempmapping = "郷";
                                break;
                            case 245:
                                tempmapping = "刺";
                                break;
                            case 246:
                                tempmapping = "勉";
                                break;
                            case 247:
                                tempmapping = "印";
                                break;
                            case 248:
                                tempmapping = "功";
                                break;
                            case 249:
                                tempmapping = "鬼";
                                break;
                            case 250:
                                tempmapping = "{r}";
                                break;
                            case 251:
                                tempmapping = "蒸";
                                break;
                            case 252:
                                tempmapping = "愛";
                                break;
                            case 253:
                                tempmapping = "婚";
                                break;
                            case 254:
                                tempmapping = "恋";
                                break;
                            case 255:
                                tempmapping = "賢";
                                break;
                        }
                    }
                    if (lastbyte == 29)
                    {
                        lastbyte = 0;
                        switch (kh2map)
                        {
                            case 0:
                                tempmapping = "猫";
                                break;
                            case 1:
                                tempmapping = "責";
                                break;
                            case 2:
                                tempmapping = "熱";
                                break;
                            case 3:
                                tempmapping = "若";
                                break;
                            case 4:
                                tempmapping = "市";
                                break;
                            case 5:
                                tempmapping = "歌";
                                break;
                            case 6:
                                tempmapping = "袋";
                                break;
                            case 7:
                                tempmapping = "虫";
                                break;
                            case 8:
                                tempmapping = "裏";
                                break;
                            case 9:
                                tempmapping = "義";
                                break;
                            case 10:
                                tempmapping = "畑";
                                break;
                            case 11:
                                tempmapping = "西";
                                break;
                            case 12:
                                tempmapping = "囚";
                                break;
                            case 13:
                                tempmapping = "弟";
                                break;
                            case 14:
                                tempmapping = "妻";
                                break;
                            case 15:
                                tempmapping = "{s}";
                                break;
                            case 16:
                                tempmapping = "善";
                                break;
                            case 17:
                                tempmapping = "禁";
                                break;
                            case 18:
                                tempmapping = "占";
                                break;
                            case 19:
                                tempmapping = "芸";
                                break;
                            case 20:
                                tempmapping = "幽";
                                break;
                            case 21:
                                tempmapping = "霊";
                                break;
                            case 22:
                                tempmapping = "清";
                                break;
                            case 23:
                                tempmapping = "個";
                                break;
                            case 24:
                                tempmapping = "{l}";
                                break;
                            case 25:
                                tempmapping = "{p}";
                                break;
                            case 26:
                                tempmapping = "Ⅲ";
                                break;
                            case 27:
                                tempmapping = "Ⅶ";
                                break;
                            case 28:
                                tempmapping = "Ⅷ";
                                break;
                            case 29:
                                tempmapping = "Ⅹ";
                                break;
                            case 30:
                                tempmapping = "高";
                                break;
                            case 31:
                                tempmapping = "工";
                                break;
                            case 32:
                                tempmapping = "敷";
                                break;
                            case 33:
                                tempmapping = "科";
                                break;
                            case 34:
                                tempmapping = "恵";
                                break;
                            case 35:
                                tempmapping = "痛";
                                break;
                            case 36:
                                tempmapping = "毎";
                                break;
                            case 37:
                                tempmapping = "注";
                                break;
                            case 38:
                                tempmapping = "軽";
                                break;
                            case 39:
                                tempmapping = "橋";
                                break;
                            case 40:
                                tempmapping = "殖";
                                break;
                            case 41:
                                tempmapping = "球";
                                break;
                            case 42:
                                tempmapping = "陣";
                                break;
                            case 43:
                                tempmapping = "打";
                                break;
                            case 44:
                                tempmapping = "崩";
                                break;
                            case 45:
                                tempmapping = "品";
                                break;
                            case 46:
                                tempmapping = "退";
                                break;
                            case 47:
                                tempmapping = "催";
                                break;
                            case 48:
                                tempmapping = "永";
                                break;
                            case 49:
                                tempmapping = "遺";
                                break;
                            case 50:
                                tempmapping = "脱";
                                break;
                            case 51:
                                tempmapping = "疑";
                                break;
                            case 52:
                                tempmapping = "民";
                                break;
                            case 53:
                                tempmapping = "尊";
                                break;
                            case 54:
                                tempmapping = "敬";
                                break;
                            case 55:
                                tempmapping = "純";
                                break;
                            case 56:
                                tempmapping = "純";
                                break;
                            case 57:
                                tempmapping = "治";
                                break;
                            case 58:
                                tempmapping = "潜";
                                break;
                            case 59:
                                tempmapping = "種";
                                break;
                            case 60:
                                tempmapping = "類";
                                break;
                            case 61:
                                tempmapping = "抑";
                                break;
                            case 62:
                                tempmapping = "制";
                                break;
                            case 63:
                                tempmapping = "幅";
                                break;
                            case 64:
                                tempmapping = "領";
                                break;
                            case 65:
                                tempmapping = "域";
                                break;
                            case 66:
                                tempmapping = "療";
                                break;
                            case 67:
                                tempmapping = "施";
                                break;
                            case 68:
                                tempmapping = "具";
                                break;
                            case 69:
                                tempmapping = "称";
                                break;
                            case 70:
                                tempmapping = "収";
                                break;
                            case 71:
                                tempmapping = "象";
                                break;
                            case 72:
                                tempmapping = "跡";
                                break;
                            case 73:
                                tempmapping = "察";
                                break;
                            case 74:
                                tempmapping = "糧";
                                break;
                            case 75:
                                tempmapping = "統";
                                break;
                            case 76:
                                tempmapping = "観";
                                break;
                            case 77:
                                tempmapping = "触";
                                break;
                            case 78:
                                tempmapping = "揺";
                                break;
                            case 79:
                                tempmapping = "標";
                                break;
                            case 80:
                                tempmapping = "到";
                                break;
                            case 81:
                                tempmapping = "拐";
                                break;
                            case 82:
                                tempmapping = "超";
                                break;
                            case 83:
                                tempmapping = "測";
                                break;
                            case 84:
                                tempmapping = "弾";
                                break;
                            case 85:
                                tempmapping = "富";
                                break;
                            case 86:
                                tempmapping = "留";
                                break;
                            case 87:
                                tempmapping = "易";
                                break;
                            case 88:
                                tempmapping = "文";
                                break;
                            case 89:
                                tempmapping = "献";
                                break;
                            case 90:
                                tempmapping = "採";
                                break;
                            case 91:
                                tempmapping = "漂";
                                break;
                            case 92:
                                tempmapping = "語";
                                break;
                            case 93:
                                tempmapping = "造";
                                break;
                            case 94:
                                tempmapping = "稼";
                                break;
                            case 95:
                                tempmapping = "改";
                                break;
                            case 96:
                                tempmapping = "能";
                                break;
                            case 97:
                                tempmapping = "比";
                                break;
                            case 98:
                                tempmapping = "較";
                                break;
                            case 99:
                                tempmapping = "区";
                                break;
                            case 100:
                                tempmapping = "訪";
                                break;
                            case 101:
                                tempmapping = "往";
                                break;
                            case 102:
                                tempmapping = "混";
                                break;
                            case 103:
                                tempmapping = "沌";
                                break;
                            case 104:
                                tempmapping = "底";
                                break;
                            case 105:
                                tempmapping = "原";
                                break;
                            case 106:
                                tempmapping = "墓";
                                break;
                            case 107:
                                tempmapping = "普";
                                break;
                            case 108:
                                tempmapping = "絵";
                                break;
                            case 109:
                                tempmapping = "額";
                                break;
                            case 110:
                                tempmapping = "又";
                                break;
                            case 111:
                                tempmapping = "暇";
                                break;
                            case 112:
                                tempmapping = "縮";
                                break;
                            case 113:
                                tempmapping = "呪";
                                break;
                            case 114:
                                tempmapping = "掛";
                                break;
                            case 115:
                                tempmapping = "慮";
                                break;
                            case 116:
                                tempmapping = "＃";
                                break;
                            case 117:
                                tempmapping = "癒";
                                break;
                            case 118:
                                tempmapping = "階";
                                break;
                            case 119:
                                tempmapping = "鐘";
                                break;
                            case 120:
                                tempmapping = "描";
                                break;
                            case 121:
                                tempmapping = "秋";
                                break;
                            case 122:
                                tempmapping = "冬";
                                break;
                            case 123:
                                tempmapping = "夏";
                                break;
                            case 124:
                                tempmapping = "泊";
                                break;
                            case 125:
                                tempmapping = "東";
                                break;
                            case 126:
                                tempmapping = "展";
                                break;
                            case 127:
                                tempmapping = "戸";
                                break;
                            case 128:
                                tempmapping = "舷";
                                break;
                            case 129:
                                tempmapping = "浮";
                                break;
                            case 130:
                                tempmapping = "毒";
                                break;
                            case 131:
                                tempmapping = "氷";
                                break;
                            case 132:
                                tempmapping = "幻";
                                break;
                            case 133:
                                tempmapping = "胃";
                                break;
                            case 134:
                                tempmapping = "腸";
                                break;
                            case 135:
                                tempmapping = "誕";
                                break;
                            case 136:
                                tempmapping = "椅";
                                break;
                            case 137:
                                tempmapping = "館";
                                break;
                            case 138:
                                tempmapping = "廊";
                                break;
                            case 139:
                                tempmapping = "堂";
                                break;
                            case 140:
                                tempmapping = "斎";
                                break;
                            case 141:
                                tempmapping = "玉";
                                break;
                            case 142:
                                tempmapping = "械";
                                break;
                            case 143:
                                tempmapping = "砲";
                                break;
                            case 144:
                                tempmapping = "聖";
                                break;
                            case 145:
                                tempmapping = "針";
                                break;
                            case 146:
                                tempmapping = "春";
                                break;
                            case 147:
                                tempmapping = "冬";
                                break;
                            case 148:
                                tempmapping = "南";
                                break;
                            case 149:
                                tempmapping = "山";
                                break;
                            case 150:
                                tempmapping = "川";
                                break;
                            case 151:
                                tempmapping = "谷";
                                break;
                            case 152:
                                tempmapping = "渓";
                                break;
                            case 153:
                                tempmapping = "崖";
                                break;
                            case 154:
                                tempmapping = "岸";
                                break;
                            case 155:
                                tempmapping = "{t}";
                                break;
                            case 156:
                                tempmapping = "棺";
                                break;
                            case 157:
                                tempmapping = "門";
                                break;
                            case 158:
                                tempmapping = "月";
                                break;
                            case 159:
                                tempmapping = "丘";
                                break;
                            case 160:
                                tempmapping = "吊";
                                break;
                            case 161:
                                tempmapping = "拷";
                                break;
                            case 162:
                                tempmapping = "倉";
                                break;
                            case 163:
                                tempmapping = "蔵";
                                break;
                            case 164:
                                tempmapping = "浜";
                                break;
                            case 165:
                                tempmapping = "江";
                                break;
                            case 166:
                                tempmapping = "淵";
                                break;
                            case 167:
                                tempmapping = "溝";
                                break;
                            case 168:
                                tempmapping = "庭";
                                break;
                            case 169:
                                tempmapping = "園";
                                break;
                            case 170:
                                tempmapping = "峡";
                                break;
                            case 171:
                                tempmapping = "潮";
                                break;
                            case 172:
                                tempmapping = "段";
                                break;
                            case 173:
                                tempmapping = "柱";
                                break;
                            case 174:
                                tempmapping = "基";
                                break;
                            case 175:
                                tempmapping = "{h}";
                                break;
                            case 176:
                                tempmapping = "汝";
                                break;
                            case 177:
                                tempmapping = "楼";
                                break;
                            case 178:
                                tempmapping = "拝";
                                break;
                            case 179:
                                tempmapping = "草";
                                break;
                            case 180:
                                tempmapping = "竹";
                                break;
                            case 181:
                                tempmapping = "沼";
                                break;
                            case 182:
                                tempmapping = "層";
                                break;
                            case 183:
                                tempmapping = "虚";
                                break;
                            case 184:
                                tempmapping = "噴";
                                break;
                            case 185:
                                tempmapping = "交";
                                break;
                            case 186:
                                tempmapping = "花";
                                break;
                            case 187:
                                tempmapping = "輝";
                                break;
                            case 188:
                                tempmapping = "護";
                                break;
                            case 189:
                                tempmapping = "巧";
                                break;
                            case 190:
                                tempmapping = "師";
                                break;
                            case 191:
                                tempmapping = "首";
                                break;
                            case 192:
                                tempmapping = "術";
                                break;
                            case 193:
                                tempmapping = "飾";
                                break;
                            case 194:
                                tempmapping = "神";
                                break;
                            case 195:
                                tempmapping = "箱";
                                break;
                            case 196:
                                tempmapping = "輪";
                                break;
                            case 197:
                                tempmapping = "腕";
                                break;
                            case 198:
                                tempmapping = "手";
                                break;
                            case 199:
                                tempmapping = "防";
                                break;
                            case 200:
                                tempmapping = "御";
                                break;
                            case 201:
                                tempmapping = "撃";
                                break;
                            case 202:
                                tempmapping = "攻";
                                break;
                            case 203:
                                tempmapping = "小";
                                break;
                            case 204:
                                tempmapping = "定";
                                break;
                            case 205:
                                tempmapping = "認";
                                break;
                            case 206:
                                tempmapping = "法";
                                break;
                            case 207:
                                tempmapping = "技";
                                break;
                            case 208:
                                tempmapping = "巨";
                                break;
                            case 209:
                                tempmapping = "樹";
                                break;
                            case 210:
                                tempmapping = "効";
                                break;
                            case 211:
                                tempmapping = "系";
                                break;
                            case 212:
                                tempmapping = "運";
                                break;
                            case 213:
                                tempmapping = "半";
                                break;
                            case 214:
                                tempmapping = "字";
                                break;
                            case 215:
                                tempmapping = "鉱";
                                break;
                            case 216:
                                tempmapping = "三";
                                break;
                            case 217:
                                tempmapping = "型";
                                break;
                            case 218:
                                tempmapping = "耐";
                                break;
                            case 219:
                                tempmapping = "速";
                                break;
                            case 220:
                                tempmapping = "設";
                                break;
                            case 221:
                                tempmapping = "低";
                                break;
                            case 222:
                                tempmapping = "共";
                                break;
                            case 223:
                                tempmapping = "{g}";
                                break;
                            case 224:
                                tempmapping = "側";
                                break;
                            case 225:
                                tempmapping = "阻";
                                break;
                            case 226:
                                tempmapping = "両";
                                break;
                            case 227:
                                tempmapping = "級";
                                break;
                            case 228:
                                tempmapping = "殻";
                                break;
                            case 229:
                                tempmapping = "圧";
                                break;
                            case 230:
                                tempmapping = "亜";
                                break;
                            case 231:
                                tempmapping = "劣";
                                break;
                            case 232:
                                tempmapping = "胴";
                                break;
                            case 233:
                                tempmapping = "脚";
                                break;
                            case 234:
                                tempmapping = "独";
                                break;
                            case 235:
                                tempmapping = "射";
                                break;
                            case 236:
                                tempmapping = "偉";
                                break;
                            case 237:
                                tempmapping = "勘";
                                break;
                            case 238:
                                tempmapping = "頂";
                                break;
                            case 239:
                                tempmapping = "戴";
                                break;
                            case 240:
                                tempmapping = "忍";
                                break;
                            case 241:
                                tempmapping = "素";
                                break;
                            case 242:
                                tempmapping = "{b}";
                                break;
                            case 243:
                                tempmapping = "＆";
                                break;
                            case 244:
                                tempmapping = "則";
                                break;
                            case 245:
                                tempmapping = "四";
                                break;
                            case 246:
                                tempmapping = "掲";
                                break;
                            case 247:
                                tempmapping = "板";
                                break;
                            case 248:
                                tempmapping = "登";
                                break;
                            case 249:
                                tempmapping = "孫";
                                break;
                            case 250:
                                tempmapping = "締";
                                break;
                            case 251:
                                tempmapping = "憐";
                                break;
                            case 252:
                                tempmapping = "鮮";
                                break;
                            case 253:
                                tempmapping = "歪";
                                break;
                            case 254:
                                tempmapping = "叫";
                                break;
                            case 255:
                                tempmapping = "推";
                                break;
                        }
                    }
                    if (lastbyte == 30)
                    {
                        lastbyte = 0;
                        switch (kh2map)
                        {
                            case 0:
                                tempmapping = "旧";
                                break;
                            case 1:
                                tempmapping = "臨";
                                break;
                            case 2:
                                tempmapping = "奈";
                                break;
                            case 3:
                                tempmapping = "摩";
                                break;
                            case 4:
                                tempmapping = "{y}";
                                break;
                            case 5:
                                tempmapping = "細";
                                break;
                            case 6:
                                tempmapping = "肉";
                                break;
                            case 7:
                                tempmapping = "因";
                                break;
                            case 8:
                                tempmapping = "財";
                                break;
                            case 9:
                                tempmapping = "疲";
                                break;
                            case 10:
                                tempmapping = "婆";
                                break;
                            case 11:
                                tempmapping = "省";
                                break;
                            case 12:
                                tempmapping = "寒";
                                break;
                            case 13:
                                tempmapping = "沢";
                                break;
                            case 14:
                                tempmapping = "商";
                                break;
                            case 15:
                                tempmapping = "却";
                                break;
                            case 16:
                                tempmapping = "派";
                                break;
                            case 17:
                                tempmapping = "盛";
                                break;
                            case 18:
                                tempmapping = "泥";
                                break;
                            case 19:
                                tempmapping = "棄";
                                break;
                            case 20:
                                tempmapping = "";
                                break;
                            case 21:
                                tempmapping = "代";
                                break;
                            case 22:
                                tempmapping = "晩";
                                break;
                            case 23:
                                tempmapping = "枯";
                                break;
                            case 24:
                                tempmapping = "期";
                                break;
                            case 25:
                                tempmapping = "譲";
                                break;
                            case 26:
                                tempmapping = "晴";
                                break;
                            case 27:
                                tempmapping = "卑";
                                break;
                            case 28:
                                tempmapping = "越";
                                break;
                            case 29:
                                tempmapping = "縁";
                                break;
                            case 30:
                                tempmapping = "権";
                                break;
                            case 31:
                                tempmapping = "極";
                                break;
                            case 32:
                                tempmapping = "磨";
                                break;
                            case 33:
                                tempmapping = "替";
                                break;
                            case 34:
                                tempmapping = "宣";
                                break;
                            case 35:
                                tempmapping = "歓";
                                break;
                            case 36:
                                tempmapping = "績";
                                break;
                            case 37:
                                tempmapping = "繰";
                                break;
                            case 38:
                                tempmapping = "栄";
                                break;
                            case 39:
                                tempmapping = "淑";
                                break;
                            case 40:
                                tempmapping = "幾";
                                break;
                            case 41:
                                tempmapping = "杯";
                                break;
                            case 42:
                                tempmapping = "紳";
                                break;
                            case 43:
                                tempmapping = "候";
                                break;
                            case 44:
                                tempmapping = "壁";
                                break;
                            case 45:
                                tempmapping = "杭";
                                break;
                            case 46:
                                tempmapping = "補";
                                break;
                            case 47:
                                tempmapping = "懲";
                                break;
                            case 48:
                                tempmapping = "酬";
                                break;
                            case 49:
                                tempmapping = "勤";
                                break;
                            case 50:
                                tempmapping = "怯";
                                break;
                            case 51:
                                tempmapping = "余";
                                break;
                            case 52:
                                tempmapping = "労";
                                break;
                            case 53:
                                tempmapping = "匂";
                                break;
                            case 54:
                                tempmapping = "罰";
                                break;
                            case 55:
                                tempmapping = "糸";
                                break;
                            case 56:
                                tempmapping = "辛";
                                break;
                            case 57:
                                tempmapping = "棟";
                                break;
                            case 58:
                                tempmapping = "課";
                                break;
                            case 59:
                                tempmapping = "荷";
                                break;
                            case 60:
                                tempmapping = "頑";
                                break;
                            case 61:
                                tempmapping = "恥";
                                break;
                            case 62:
                                tempmapping = "酷";
                                break;
                            case 63:
                                tempmapping = "随";
                                break;
                            case 64:
                                tempmapping = "醜";
                                break;
                            case 65:
                                tempmapping = "詞";
                                break;
                            case 66:
                                tempmapping = "償";
                                break;
                            case 67:
                                tempmapping = "棒";
                                break;
                            case 68:
                                tempmapping = "隣";
                                break;
                            case 69:
                                tempmapping = "励";
                                break;
                            case 70:
                                tempmapping = "倍";
                                break;
                            case 71:
                                tempmapping = "充";
                                break;
                            case 72:
                                tempmapping = "＃";
                                break;
                            case 73:
                                tempmapping = "雰";
                                break;
                            case 74:
                                tempmapping = "涙";
                                break;
                            case 75:
                                tempmapping = "脅";
                                break;
                            case 76:
                                tempmapping = "泣";
                                break;
                            case 77:
                                tempmapping = "泥";
                                break;
                            case 78:
                                tempmapping = "党";
                                break;
                            case 79:
                                tempmapping = "洪";
                                break;
                            case 80:
                                tempmapping = "{XIII}";
                                break;
                            case 81:
                                tempmapping = "討";
                                break;
                            case 82:
                                tempmapping = "伐";
                                break;
                            case 83:
                                tempmapping = "皇";
                                break;
                            case 84:
                                tempmapping = "帝";
                                break;
                            case 85:
                                tempmapping = "殺";
                                break;
                            case 86:
                                tempmapping = "編";
                                break;
                            case 87:
                                tempmapping = "窮";
                                break;
                            case 88:
                                tempmapping = "恨";
                                break;
                            case 89:
                                tempmapping = "腰";
                                break;
                            case 90:
                                tempmapping = "飯";
                                break;
                            case 91:
                                tempmapping = "貨";
                                break;
                            case 92:
                                tempmapping = "港";
                                break;
                            case 93:
                                tempmapping = "軍";
                                break;
                            case 94:
                                tempmapping = "号";
                                break;
                            case 95:
                                tempmapping = "血";
                                break;
                            case 96:
                                tempmapping = "掟";
                                break;
                            case 97:
                                tempmapping = "浴";
                                break;
                            case 98:
                                tempmapping = "範";
                                break;
                            case 99:
                                tempmapping = "謹";
                                break;
                            case 100:
                                tempmapping = "寄";
                                break;
                            case 101:
                                tempmapping = "豪";
                                break;
                            case 102:
                                tempmapping = "詰";
                                break;
                            case 103:
                                tempmapping = "慢";
                                break;
                            case 104:
                                tempmapping = "損";
                                break;
                            case 105:
                                tempmapping = "史";
                                break;
                            case 106:
                                tempmapping = "略";
                                break;
                            case 107:
                                tempmapping = "抱";
                                break;
                            case 108:
                                tempmapping = "遭";
                                break;
                            case 109:
                                tempmapping = "慈";
                                break;
                            case 110:
                                tempmapping = "際";
                                break;
                            case 111:
                                tempmapping = "誉";
                                break;
                            case 112:
                                tempmapping = "縄";
                                break;
                            case 113:
                                tempmapping = "銘";
                                break;
                            case 114:
                                tempmapping = "肝";
                                break;
                            case 115:
                                tempmapping = "並";
                                break;
                            case 116:
                                tempmapping = "殴";
                                break;
                            case 117:
                                tempmapping = "利";
                                break;
                            case 118:
                                tempmapping = "誇";
                                break;
                            case 119:
                                tempmapping = "謁";
                                break;
                            case 120:
                                tempmapping = "憩";
                                break;
                            case 121:
                                tempmapping = "祖";
                                break;
                            case 122:
                                tempmapping = "官";
                                break;
                            case 123:
                                tempmapping = "都";
                                break;
                            case 124:
                                tempmapping = "司";
                                break;
                            case 125:
                                tempmapping = "駆";
                                break;
                            case 126:
                                tempmapping = "柄";
                                break;
                            case 127:
                                tempmapping = "挑";
                                break;
                            case 128:
                                tempmapping = "偽";
                                break;
                            case 129:
                                tempmapping = "吉";
                                break;
                            case 130:
                                tempmapping = "堤";
                                break;
                            case 131:
                                tempmapping = "建";
                                break;
                            case 132:
                                tempmapping = "銅";
                                break;
                            case 133:
                                tempmapping = "車";
                                break;
                            case 134:
                                tempmapping = "贈";
                                break;
                            case 135:
                                tempmapping = "唯";
                                break;
                            case 136:
                                tempmapping = "資";
                                break;
                            case 137:
                                tempmapping = "預";
                                break;
                            case 138:
                                tempmapping = "委";
                                break;
                            case 139:
                                tempmapping = "埋";
                                break;
                            case 140:
                                tempmapping = "督";
                                break;
                            case 141:
                                tempmapping = "謀";
                                break;
                            case 142:
                                tempmapping = "穏";
                                break;
                            case 143:
                                tempmapping = "筋";
                                break;
                            case 144:
                                tempmapping = "適";
                                break;
                            case 145:
                                tempmapping = "迫";
                                break;
                            case 146:
                                tempmapping = "殊";
                                break;
                            case 147:
                                tempmapping = "絆";
                                break;
                            case 148:
                                tempmapping = "狼";
                                break;
                            case 149:
                                tempmapping = "割";
                                break;
                            case 150:
                                tempmapping = "砦";
                                break;
                            case 151:
                                tempmapping = "徐";
                                break;
                            case 152:
                                tempmapping = "煙";
                                break;
                            case 153:
                                tempmapping = "肖";
                                break;
                            case 154:
                                tempmapping = "慌";
                                break;
                            case 155:
                                tempmapping = "訓";
                                break;
                            case 156:
                                tempmapping = "芝";
                                break;
                            case 157:
                                tempmapping = "桟";
                                break;
                            case 158:
                                tempmapping = "灰";
                                break;
                            case 159:
                                tempmapping = "障";
                                break;
                            case 160:
                                tempmapping = "砕";
                                break;
                            case 161:
                                tempmapping = "幼";
                                break;
                            case 162:
                                tempmapping = "製";
                                break;
                            case 163:
                                tempmapping = "鋭";
                                break;
                            case 164:
                                tempmapping = "骨";
                                break;
                            case 165:
                                tempmapping = "馬";
                                break;
                            case 166:
                                tempmapping = "拾";
                                break;
                            case 167:
                                tempmapping = "掘";
                                break;
                            case 168:
                                tempmapping = "温";
                                break;
                            case 169:
                                tempmapping = "微";
                                break;
                            case 170:
                                tempmapping = "歯";
                                break;
                            case 171:
                                tempmapping = "将";
                                break;
                            case 172:
                                tempmapping = "兄";
                                break;
                            case 173:
                                tempmapping = "駅";
                                break;
                            case 174:
                                tempmapping = "忌";
                                break;
                            case 175:
                                tempmapping = "坊";
                                break;
                            case 176:
                                tempmapping = "慕";
                                break;
                            case 177:
                                tempmapping = "執";
                                break;
                            case 178:
                                tempmapping = "寝";
                                break;
                            case 179:
                                tempmapping = "酒";
                                break;
                            case 180:
                                tempmapping = "管";
                                break;
                            case 181:
                                tempmapping = "華";
                                break;
                            case 182:
                                tempmapping = "{VI}";
                                break;
                            case 183:
                                tempmapping = "{IX}";
                                break;
                            case 184:
                                tempmapping = "狂";
                                break;
                            case 185:
                                tempmapping = "網";
                                break;
                            case 186:
                                tempmapping = "雲";
                                break;
                            case 187:
                                tempmapping = "征";
                                break;
                            case 188:
                                tempmapping = "総";
                                break;
                            case 189:
                                tempmapping = "衆";
                                break;
                            case 190:
                                tempmapping = "冶";
                                break;
                            case 191:
                                tempmapping = "雇";
                                break;
                            case 192:
                                tempmapping = "髪";
                                break;
                            case 193:
                                tempmapping = "燭";
                                break;
                            case 194:
                                tempmapping = "鉄";
                                break;
                            case 195:
                                tempmapping = "監";
                                break;
                            case 196:
                                tempmapping = "団";
                                break;
                            case 197:
                                tempmapping = "継";
                                break;
                            case 198:
                                tempmapping = "肩";
                                break;
                            case 199:
                                tempmapping = "電";
                                break;
                            case 200:
                                tempmapping = "給";
                                break;
                            case 201:
                                tempmapping = "評";
                                break;
                            case 202:
                                tempmapping = "営";
                                break;
                            case 203:
                                tempmapping = "依";
                                break;
                            case 204:
                                tempmapping = "職";
                                break;
                            case 205:
                                tempmapping = "憧";
                                break;
                            case 206:
                                tempmapping = "麗";
                                break;
                            case 207:
                                tempmapping = "症";
                                break;
                            case 208:
                                tempmapping = "衣";
                                break;
                            case 209:
                                tempmapping = "眼";
                                break;
                            case 210:
                                tempmapping = "揮";
                                break;
                            case 211:
                                tempmapping = "鋼";
                                break;
                            case 212:
                                tempmapping = "瞳";
                                break;
                            case 213:
                                tempmapping = "匠";
                                break;
                            case 214:
                                tempmapping = "貫";
                                break;
                            case 215:
                                tempmapping = "克";
                                break;
                            case 216:
                                tempmapping = "歴";
                                break;
                            case 217:
                                tempmapping = "養";
                                break;
                            case 218:
                                tempmapping = "織";
                                break;
                            case 219:
                                tempmapping = "礎";
                                break;
                            case 220:
                                tempmapping = "讐";
                                break;
                            case 221:
                                tempmapping = "演";
                                break;
                            case 222:
                                tempmapping = "衛";
                                break;
                            case 223:
                                tempmapping = "狩";
                                break;
                            case 224:
                                tempmapping = "減";
                                break;
                            case 225:
                                tempmapping = "波";
                                break;
                            case 226:
                                tempmapping = "丁";
                                break;
                            case 227:
                                tempmapping = "積";
                                break;
                            case 228:
                                tempmapping = "環";
                                break;
                            case 229:
                                tempmapping = "銃";
                                break;
                            case 230:
                                tempmapping = "警";
                                break;
                            case 231:
                                tempmapping = "龍";
                                break;
                            case 232:
                                tempmapping = "峠";
                                break;
                            case 233:
                                tempmapping = "脈";
                                break;
                            case 234:
                                tempmapping = "宅";
                                break;
                            case 235:
                                tempmapping = "創";
                                break;
                            case 236:
                                tempmapping = "社";
                                break;
                            case 237:
                                tempmapping = "論";
                                break;
                            case 238:
                                tempmapping = "枢";
                                break;
                            case 239:
                                tempmapping = "否";
                                break;
                            case 240:
                                tempmapping = "列";
                                break;
                            case 241:
                                tempmapping = "包";
                                break;
                            case 242:
                                tempmapping = "奮";
                                break;
                            case 243:
                                tempmapping = "七";
                                break;
                            case 244:
                                tempmapping = "噂";
                                break;
                            case 245:
                                tempmapping = "坂";
                                break;
                            case 246:
                                tempmapping = "貼";
                                break;
                            case 247:
                                tempmapping = "逮";
                                break;
                            case 248:
                                tempmapping = "幕";
                                break;
                            case 249:
                                tempmapping = "帯";
                                break;
                            case 250:
                                tempmapping = "銀";
                                break;
                            case 251:
                                tempmapping = "援";
                                break;
                            case 252:
                                tempmapping = "悩";
                                break;
                            case 253:
                                tempmapping = "凄";
                                break;
                            case 254:
                                tempmapping = "昨";
                                break;
                            case 255:
                                tempmapping = "妬";
                                break;
                        }
                    }
                    if (lastbyte == 31)
                    {
                        lastbyte = 0;
                        switch (kh2map)
                        {
                            case 0:
                                tempmapping = "捧";
                                break;
                            case 1:
                                tempmapping = "怠";
                                break;
                            case 2:
                                tempmapping = "裕";
                                break;
                            case 3:
                                tempmapping = "十";
                                break;
                        }
                    }
                }
                output = output + tempmapping;
                lastbyte = lastbyte2;
                return output;
                #endregion
            }
            else
            {
                #region English String Mapping code

                string tempmapping = "";

                switch (kh2map)
                {
                    case 0:
                        tempmapping = "{eol}";
                        break;
                    case 1:
                        tempmapping = " ";
                        break;
                    case 2:
                        tempmapping = "{lf}";
                        break;
                    case 33:
                        tempmapping = "0";
                        break;
                    case 34:
                        tempmapping = "1";
                        break;
                    case 35:
                        tempmapping = "2";
                        break;
                    case 36:
                        tempmapping = "3";
                        break;
                    case 37:
                        tempmapping = "4";
                        break;
                    case 38:
                        tempmapping = "5";
                        break;
                    case 39:
                        tempmapping = "6";
                        break;
                    case 40:
                        tempmapping = "7";
                        break;
                    case 41:
                        tempmapping = "8";
                        break;
                    case 42:
                        tempmapping = "9";
                        break;
                    case 43:
                        tempmapping = "+";
                        break;
                    case 44:
                        tempmapping = "-";
                        break;
                    case 45:
                        tempmapping = "{mX}";
                        break;
                    case 46:
                        tempmapping = "A";
                        break;
                    case 47:
                        tempmapping = "B";
                        break;
                    case 48:
                        tempmapping = "C";
                        break;
                    case 49:
                        tempmapping = "D";
                        break;
                    case 50:
                        tempmapping = "E";
                        break;
                    case 51:
                        tempmapping = "F";
                        break;
                    case 52:
                        tempmapping = "G";
                        break;
                    case 53:
                        tempmapping = "H";
                        break;
                    case 54:
                        tempmapping = "I";
                        break;
                    case 55:
                        tempmapping = "J";
                        break;
                    case 56:
                        tempmapping = "K";
                        break;
                    case 57:
                        tempmapping = "L";
                        break;
                    case 58:
                        tempmapping = "M";
                        break;
                    case 59:
                        tempmapping = "N";
                        break;
                    case 60:
                        tempmapping = "O";
                        break;
                    case 61:
                        tempmapping = "P";
                        break;
                    case 62:
                        tempmapping = "Q";
                        break;
                    case 63:
                        tempmapping = "R";
                        break;
                    case 64:
                        tempmapping = "S";
                        break;
                    case 65:
                        tempmapping = "T";
                        break;
                    case 66:
                        tempmapping = "U";
                        break;
                    case 67:
                        tempmapping = "V";
                        break;
                    case 68:
                        tempmapping = "W";
                        break;
                    case 69:
                        tempmapping = "X";
                        break;
                    case 70:
                        tempmapping = "Y";
                        break;
                    case 71:
                        tempmapping = "Z";
                        break;
                    case 72:
                        tempmapping = "!";
                        break;
                    case 73:
                        tempmapping = "?";
                        break;
                    case 74:
                        tempmapping = "%";
                        break;
                    case 75:
                        tempmapping = "/";
                        break;
                    case 76:
                        tempmapping = "※";
                        break;
                    case 77:
                        tempmapping = "、";
                        break;
                    case 78:
                        tempmapping = "。";
                        break;
                    case 79:
                        tempmapping = ".";
                        break;
                    case 80:
                        tempmapping = ",";
                        break;
                    case 81:
                        tempmapping = ";";
                        break;
                    case 82:
                        tempmapping = ":";
                        break;
                    case 83:
                        tempmapping = "{•••}";
                        break;
                    case 84:
                        tempmapping = "{-}";
                        break;
                    case 85:
                        tempmapping = "{--}";
                        break;
                    case 86:
                        tempmapping = "〜";
                        break;
                    case 87:
                        tempmapping = "'";
                        break;
                    case 90:
                        tempmapping = "(";
                        break;
                    case 91:
                        tempmapping = ")";
                        break;
                    case 92:
                        tempmapping = "「";
                        break;
                    case 93:
                        tempmapping = "」";
                        break;
                    case 94:
                        tempmapping = "『";
                        break;
                    case 95:
                        tempmapping = "』";
                        break;
                    case 96:
                        tempmapping = "“";
                        break;
                    case 97:
                        tempmapping = "”";
                        break;
                    case 98:
                        tempmapping = "[";
                        break;
                    case 99:
                        tempmapping = "]";
                        break;
                    case 100:
                        tempmapping = "<";
                        break;
                    case 101:
                        tempmapping = ">";
                        break;
                    case 102:
                        tempmapping = "{-2}";
                        break;
                    case 103:
                        tempmapping = "ー";
                        break;
                    case 104:
                        tempmapping = "↳";
                        break;
                    case 105:
                        tempmapping = "♪";
                        break;
                    case 106:
                        tempmapping = "→";
                        break;
                    case 107:
                        tempmapping = "←";
                        break;
                    case 116:
                        tempmapping = "{I}";
                        break;
                    case 117:
                        tempmapping = "{II}";
                        break;
                    case 118:
                        tempmapping = "{III}";
                        break;
                    case 119:
                        tempmapping = "{IV}";
                        break;
                    case 120:
                        tempmapping = "{V}";
                        break;
                    case 121:
                        tempmapping = "{VI}";
                        break;
                    case 122:
                        tempmapping = "{VII}";
                        break;
                    case 123:
                        tempmapping = "{VIII}";
                        break;
                    case 124:
                        tempmapping = "{IX}";
                        break;
                    case 125:
                        tempmapping = "{X}";
                        break;
                    case 126:
                        tempmapping = "{XIII}";
                        break;
                    case 127:
                        tempmapping = "α";
                        break;
                    case 128:
                        tempmapping = "β";
                        break;
                    case 129:
                        tempmapping = "{r}";
                        break;
                    case 130:
                        tempmapping = "★";
                        break;
                    case 131:
                        tempmapping = "☆";
                        break;
                    case 132:
                        tempmapping = "{XI}";
                        break;
                    case 133:
                        tempmapping = "{XII}";
                        break;
                    case 134:
                        tempmapping = "&";
                        break;
                    case 135:
                        tempmapping = "#";
                        break;
                    case 136:
                        tempmapping = "®";
                        break;
                    case 137:
                        tempmapping = "▲";
                        break;
                    case 138:
                        tempmapping = "▼";
                        break;
                    case 139:
                        tempmapping = "►";
                        break;
                    case 140:
                        tempmapping = "◄";
                        break;
                    case 144:
                        tempmapping = "0";
                        break;
                    case 145:
                        tempmapping = "1";
                        break;
                    case 146:
                        tempmapping = "2";
                        break;
                    case 147:
                        tempmapping = "3";
                        break;
                    case 148:
                        tempmapping = "4";
                        break;
                    case 149:
                        tempmapping = "5";
                        break;
                    case 150:
                        tempmapping = "6";
                        break;
                    case 151:
                        tempmapping = "7";
                        break;
                    case 152:
                        tempmapping = "8";
                        break;
                    case 153:
                        tempmapping = "9";
                        break;
                    case 154:
                        tempmapping = "a";
                        break;
                    case 155:
                        tempmapping = "b";
                        break;
                    case 156:
                        tempmapping = "c";
                        break;
                    case 157:
                        tempmapping = "d";
                        break;
                    case 158:
                        tempmapping = "e";
                        break;
                    case 159:
                        tempmapping = "f";
                        break;
                    case 160:
                        tempmapping = "g";
                        break;
                    case 161:
                        tempmapping = "h";
                        break;
                    case 162:
                        tempmapping = "i";
                        break;
                    case 163:
                        tempmapping = "j";
                        break;
                    case 164:
                        tempmapping = "k";
                        break;
                    case 165:
                        tempmapping = "l";
                        break;
                    case 166:
                        tempmapping = "m";
                        break;
                    case 167:
                        tempmapping = "n";
                        break;
                    case 168:
                        tempmapping = "o";
                        break;
                    case 169:
                        tempmapping = "p";
                        break;
                    case 170:
                        tempmapping = "q";
                        break;
                    case 171:
                        tempmapping = "r";
                        break;
                    case 172:
                        tempmapping = "s";
                        break;
                    case 173:
                        tempmapping = "t";
                        break;
                    case 174:
                        tempmapping = "u";
                        break;
                    case 175:
                        tempmapping = "v";
                        break;
                    case 176:
                        tempmapping = "w";
                        break;
                    case 177:
                        tempmapping = "x";
                        break;
                    case 178:
                        tempmapping = "y";
                        break;
                    case 179:
                        tempmapping = "z";
                        break;
                    case 180:
                        tempmapping = "Œ";
                        break;
                    case 181:
                        tempmapping = "æ";
                        break;
                    case 182:
                        tempmapping = "ß";
                        break;
                    case 183:
                        tempmapping = "à";
                        break;
                    case 184:
                        tempmapping = "á";
                        break;
                    case 185:
                        tempmapping = "â";
                        break;
                    case 186:
                        tempmapping = "ä";
                        break;
                    case 187:
                        tempmapping = "è";
                        break;
                    case 188:
                        tempmapping = "é";
                        break;
                    case 189:
                        tempmapping = "ê";
                        break;
                    case 190:
                        tempmapping = "ë";
                        break;
                    case 191:
                        tempmapping = "ì";
                        break;
                    case 192:
                        tempmapping = "í";
                        break;
                    case 193:
                        tempmapping = "î";
                        break;
                    case 194:
                        tempmapping = "ï";
                        break;
                    case 195:
                        tempmapping = "ñ";
                        break;
                    case 196:
                        tempmapping = "ò";
                        break;
                    case 197:
                        tempmapping = "ó";
                        break;
                    case 198:
                        tempmapping = "ô";
                        break;
                    case 199:
                        tempmapping = "ö";
                        break;
                    case 200:
                        tempmapping = "ù";
                        break;
                    case 201:
                        tempmapping = "ú";
                        break;
                    case 202:
                        tempmapping = "û";
                        break;
                    case 203:
                        tempmapping = "ü";
                        break;
                    case 204:
                        tempmapping = "°";
                        break;
                    case 205:
                        tempmapping = "{ー}";
                        break;
                    case 206:
                        tempmapping = "«";
                        break;
                    case 207:
                        tempmapping = "»";
                        break;
                    case 208:
                        tempmapping = "À";
                        break;
                    case 209:
                        tempmapping = "Á";
                        break;
                    case 210:
                        tempmapping = "Â";
                        break;
                    case 211:
                        tempmapping = "Ä";
                        break;
                    case 212:
                        tempmapping = "È";
                        break;
                    case 213:
                        tempmapping = "É";
                        break;
                    case 214:
                        tempmapping = "Ê";
                        break;
                    case 215:
                        tempmapping = "Ë";
                        break;
                    case 216:
                        tempmapping = "Ì";
                        break;
                    case 217:
                        tempmapping = "Í";
                        break;
                    case 218:
                        tempmapping = "Î";
                        break;
                    case 219:
                        tempmapping = "Ï";
                        break;
                    case 220:
                        tempmapping = "Ñ";
                        break;
                    case 221:
                        tempmapping = "Ò";
                        break;
                    case 222:
                        tempmapping = "Ó";
                        break;
                    case 223:
                        tempmapping = "Ô";
                        break;
                    case 224:
                        tempmapping = "Ö";
                        break;
                    case 225:
                        tempmapping = "Ù";
                        break;
                    case 226:
                        tempmapping = "Ú";
                        break;
                    case 227:
                        tempmapping = "Û";
                        break;
                    case 228:
                        tempmapping = "Ü";
                        break;
                    case 229:
                        tempmapping = "¡";
                        break;
                    case 230:
                        tempmapping = "¿";
                        break;
                    case 231:
                        tempmapping = "Ç";
                        break;
                    case 232:
                        tempmapping = "ç";
                        break;
                    case 233:
                        tempmapping = "{“}";
                        break;
                    case 234:
                        tempmapping = "{”}";
                        break;
                    case 235:
                        tempmapping = "‘";
                        break;
                    case 236:
                        tempmapping = "’";
                        break;
                    case 237:
                        tempmapping = "'";
                        break;
                    case 238:
                        tempmapping = "{'}";
                        break;
                    case 239:
                        tempmapping = "{★}";
                        break;
                    case 240:
                        tempmapping = "{☆}";
                        break;
                    case 241:
                        tempmapping = "■";
                        break;
                    case 242:
                        tempmapping = "□";
                        break;
                    case 243:
                        tempmapping = "▲";
                        break;
                    case 244:
                        tempmapping = "△";
                        break;
                    case 245:
                        tempmapping = "●";
                        break;
                    case 246:
                        tempmapping = "○";
                        break;
                    case 247:
                        tempmapping = "{♪}";
                        break;
                    case 248:
                        tempmapping = "♫";
                        break;
                    case 249:
                        tempmapping = "{→}";
                        break;
                    case 250:
                        tempmapping = "{←}";
                        break;
                    case 251:
                        tempmapping = "↑";
                        break;
                    case 252:
                        tempmapping = "{↓}";
                        break;
                    case 253:
                        tempmapping = "・";
                        break;
                    case 254:
                        tempmapping = "❤";
                        break;
                    case 255:
                        tempmapping = "{■}";
                        break;
                }
                output = output + tempmapping;
                return output;

                #endregion
            }
        }
    }
}