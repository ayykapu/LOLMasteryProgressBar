using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Champion
    {
        public int ChampionId { get; set; }
        public string ChampionName { get; set; }
        public int ChampionPoints { get; set; }

        public Champion(int championId, int championPoints, string? championName = null)
        {
            ChampionId = championId;
            ChampionPoints = championPoints;
            ChampionName = championName;
            if (championName == null)
            {
                ChampionName = getName(championId);
            }

            if (ChampionPoints > 21600)
            {
                Methods.fiveOrMore++;
            }
        }

        string getName(int id)
        {
            switch (id)
            {
                case 266:
                    return Methods.championNames[0];
                case 103:
                    return Methods.championNames[1];
                case 84:
                    return Methods.championNames[2];
                case 166:
                    return Methods.championNames[3];
                case 12:
                    return Methods.championNames[4];
                case 32:
                    return Methods.championNames[5];
                case 34:
                    return Methods.championNames[6];
                case 1:
                    return Methods.championNames[7];
                case 523:
                    return Methods.championNames[8];
                case 22:
                    return Methods.championNames[9];
                case 136:
                    return Methods.championNames[10];
                case 268:
                    return Methods.championNames[11];
                case 432:
                    return Methods.championNames[12];
                case 200:
                    return Methods.championNames[13];
                case 53:
                    return Methods.championNames[14];
                case 63:
                    return Methods.championNames[15];
                case 201:
                    return Methods.championNames[16];
                case 233:
                    return Methods.championNames[17];
                case 51:
                    return Methods.championNames[18];
                case 164:
                    return Methods.championNames[19];
                case 69:
                    return Methods.championNames[20];
                case 31:
                    return Methods.championNames[21];
                case 42:
                    return Methods.championNames[22];
                case 122:
                    return Methods.championNames[23];
                case 131:
                    return Methods.championNames[24];
                case 119:
                    return Methods.championNames[25];
                case 36:
                    return Methods.championNames[26];
                case 245:
                    return Methods.championNames[27];
                case 60:
                    return Methods.championNames[28];
                case 28:
                    return Methods.championNames[29];
                case 81:
                    return Methods.championNames[30];
                case 9:
                    return Methods.championNames[31];
                case 114:
                    return Methods.championNames[32];
                case 105:
                    return Methods.championNames[33];
                case 3:
                    return Methods.championNames[34];
                case 41:
                    return Methods.championNames[35];
                case 86:
                    return Methods.championNames[36];
                case 150:
                    return Methods.championNames[37];
                case 79:
                    return Methods.championNames[38];
                case 104:
                    return Methods.championNames[39];
                case 887:
                    return Methods.championNames[40];
                case 120:
                    return Methods.championNames[41];
                case 74:
                    return Methods.championNames[42];
                case 910:
                    return Methods.championNames[43];
                case 420:
                    return Methods.championNames[44];
                case 39:
                    return Methods.championNames[45];
                case 427:
                    return Methods.championNames[46];
                case 40:
                    return Methods.championNames[47];
                case 59:
                    return Methods.championNames[48];
                case 24:
                    return Methods.championNames[49];
                case 126:
                    return Methods.championNames[50];
                case 202:
                    return Methods.championNames[51];
                case 222:
                    return Methods.championNames[52];
                case 145:
                    return Methods.championNames[53];
                case 429:
                    return Methods.championNames[54];
                case 43:
                    return Methods.championNames[55];
                case 30:
                    return Methods.championNames[56];
                case 38:
                    return Methods.championNames[57];
                case 55:
                    return Methods.championNames[58];
                case 10:
                    return Methods.championNames[59];
                case 141:
                    return Methods.championNames[60];
                case 85:
                    return Methods.championNames[61];
                case 121:
                    return Methods.championNames[62];
                case 203:
                    return Methods.championNames[63];
                case 240:
                    return Methods.championNames[64];
                case 96:
                    return Methods.championNames[65];
                case 897:
                    return Methods.championNames[66];
                case 7:
                    return Methods.championNames[67];
                case 64:
                    return Methods.championNames[68];
                case 89:
                    return Methods.championNames[69];
                case 876:
                    return Methods.championNames[70];
                case 127:
                    return Methods.championNames[71];
                case 236:
                    return Methods.championNames[72];
                case 117:
                    return Methods.championNames[73];
                case 99:
                    return Methods.championNames[74];
                case 54:
                    return Methods.championNames[75];
                case 90:
                    return Methods.championNames[76];
                case 57:
                    return Methods.championNames[77];
                case 11:
                    return Methods.championNames[78];
                case 902:
                    return Methods.championNames[79];
                case 21:
                    return Methods.championNames[80];
                case 62:
                    return Methods.championNames[81];
                case 82:
                    return Methods.championNames[82];
                case 25:
                    return Methods.championNames[83];
                case 950:
                    return Methods.championNames[84];
                case 267:
                    return Methods.championNames[85];
                case 75:
                    return Methods.championNames[86];
                case 111:
                    return Methods.championNames[87];
                case 518:
                    return Methods.championNames[88];
                case 76:
                    return Methods.championNames[89];
                case 895:
                    return Methods.championNames[90];
                case 56:
                    return Methods.championNames[91];
                case 20:
                    return Methods.championNames[92];
                case 2:
                    return Methods.championNames[93];
                case 61:
                    return Methods.championNames[94];
                case 516:
                    return Methods.championNames[95];
                case 80:
                    return Methods.championNames[96];
                case 78:
                    return Methods.championNames[97];
                case 555:
                    return Methods.championNames[98];
                case 246:
                    return Methods.championNames[99];
                case 133:
                    return Methods.championNames[100];
                case 497:
                    return Methods.championNames[101];
                case 33:
                    return Methods.championNames[102];
                case 421:
                    return Methods.championNames[103];
                case 526:
                    return Methods.championNames[104];
                case 888:
                    return Methods.championNames[105];
                case 58:
                    return Methods.championNames[106];
                case 107:
                    return Methods.championNames[107];
                case 92:
                    return Methods.championNames[108];
                case 68:
                    return Methods.championNames[109];
                case 13:
                    return Methods.championNames[110];
                case 360:
                    return Methods.championNames[111];
                case 113:
                    return Methods.championNames[112];
                case 235:
                    return Methods.championNames[113];
                case 147:
                    return Methods.championNames[114];
                case 875:
                    return Methods.championNames[115];
                case 35:
                    return Methods.championNames[116];
                case 98:
                    return Methods.championNames[117];
                case 102:
                    return Methods.championNames[118];
                case 27:
                    return Methods.championNames[119];
                case 14:
                    return Methods.championNames[120];
                case 15:
                    return Methods.championNames[121];
                case 72:
                    return Methods.championNames[122];
                case 901:
                    return Methods.championNames[123];
                case 37:
                    return Methods.championNames[124];
                case 16:
                    return Methods.championNames[125];
                case 50:
                    return Methods.championNames[126];
                case 517:
                    return Methods.championNames[127];
                case 134:
                    return Methods.championNames[128];
                case 223:
                    return Methods.championNames[129];
                case 163:
                    return Methods.championNames[130];
                case 91:
                    return Methods.championNames[131];
                case 44:
                    return Methods.championNames[132];
                case 17:
                    return Methods.championNames[133];
                case 412:
                    return Methods.championNames[134];
                case 18:
                    return Methods.championNames[135];
                case 48:
                    return Methods.championNames[136];
                case 23:
                    return Methods.championNames[137];
                case 4:
                    return Methods.championNames[138];
                case 29:
                    return Methods.championNames[139];
                case 77:
                    return Methods.championNames[140];
                case 6:
                    return Methods.championNames[141];
                case 110:
                    return Methods.championNames[142];
                case 67:
                    return Methods.championNames[143];
                case 45:
                    return Methods.championNames[144];
                case 161:
                    return Methods.championNames[145];
                case 711:
                    return Methods.championNames[146];
                case 254:
                    return Methods.championNames[147];
                case 234:
                    return Methods.championNames[148];
                case 112:
                    return Methods.championNames[149];
                case 8:
                    return Methods.championNames[150];
                case 106:
                    return Methods.championNames[151];
                case 19:
                    return Methods.championNames[152];
                case 498:
                    return Methods.championNames[153];
                case 101:
                    return Methods.championNames[154];
                case 5:
                    return Methods.championNames[155];
                case 157:
                    return Methods.championNames[156];
                case 777:
                    return Methods.championNames[157];
                case 83:
                    return Methods.championNames[158];
                case 350:
                    return Methods.championNames[159];
                case 154:
                    return Methods.championNames[160];
                case 238:
                    return Methods.championNames[161];
                case 221:
                    return Methods.championNames[162];
                case 115:
                    return Methods.championNames[163];
                case 26:
                    return Methods.championNames[164];
                case 142:
                    return Methods.championNames[165];
                case 143:
                    return Methods.championNames[166];
                default:
                    return "Champion not found";
            }
        }



    }

}
