using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StringDeal
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "孙小东;张金刚;任鲲先;全魁;何海熙;谢皓;王永猛;张波(赛迪技术);徐林伟;何春来;王水根;夏强强;周涛(赛迪技术);贾鸿盛;艾宇;袁黎;陈栋梁;段成财;李昕祎;杨世辉;吴开基;赵运建;穆杨;雷磊;刘强;王万慧;冀文娟;王宏宇;刘中保;谢建;赵宽;胡堃;余云飞;朱科(赛迪技术);李朋;漆锐;赵晓锋;杨军波;曹龙腾;张翔(赛迪技术);张瑶;丁向东;罗灵燕;曾令勇;常圣;姜玖辉;何洪;万小丽;刘常坤;陶迎;蔡春扬;郑成坤;孙丹;邓比涛;徐超琼;何元媛;曾建成;涂霞;李妍星;方文;高威;张燕彤;余晨韵;汤槟;谢兰梅;丘全科;贾新露;周文靖;高剑;徐诗鑫;陈波;翟波;谢小东;何文馨;陈增;王汶;陶术江;林柏云;王洁玉;吴曼玲;陈桔伍;李开兴;杨东海;程娇娇;魏莹盈;庞殊杨;杨安琪;陈锦斌;孙广彪;刘江豪;刘雨佳;任良银;伍志强;李士果;祝捷;王大滨;周德亮;王玥;包家奇;陈建晖;周洪安;王作学;张洁瑜";
            string str2 = "胡狄辛、何立、李邈、柳昊、李昕祎、陈开、曾令勇、刘常坤、周文靖、刘波、林柏云、任良银、伍志强、张波、贾鸿盛、汤槟、翟波、杨东海、庞殊杨、陈锦斌、祝捷、包家奇、谢永辉、袁嘉明、冀文娟、曹龙腾、丁向东、曾建成、高剑、陈桔伍、王玥、张洁、谯墙、毛尚伟、郑成坤、谢小东、陈增、王汶、陶术江、程娇娇、魏莹盈、杨安琪、李冰、孙广彪、刘江豪、刘雨佳、李士果、周德亮、陈建晖、黄铭、陈立丹、王龙、陈敏、李盛、姜根成、钟渝、徐林伟、杨军波、张瑶、姜玖辉、何洪、陶迎、孙丹、徐超琼、王作学、陈彦智、何新军、常圣、谢皓、雷磊、王洁玉、张翔、刘中保、赵宽、周洪安、孙小东、张沛";


           var strAry1 = str1.Split(';').ToList();

            var strAry2= str2.Split('、').ToArray();

            var result = new List<string>();
            foreach (var item1 in strAry1)
            {
                bool isContain = false;
                foreach (var item2 in strAry2)
                {
                    if (item1==item2)
                    {
                        isContain = true;
                        break;
                    } 
                }
                if (!isContain)
                {
                    result.Add(item1+";");
                }

            }

            string str=null;
            foreach (var item in result)
            {
                str += item;

            }
            StreamWriter sw = new StreamWriter("name.txt");
            sw.Write(str);
            sw.Close();

            
 
             



        }
    }
}
