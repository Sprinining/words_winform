using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;

using Newtonsoft.Json.Linq;


namespace words_winform
{
    class WordHelper
    {
        public static string strReadFilePath = @"../../wordlist.json";
        public static WordList wordlist;
        public static readonly string jsonText = "";
        static WordHelper()
        {
            //读取json文件，转为字符串
            StreamReader srReadFile = new StreamReader(strReadFilePath);

            while (!srReadFile.EndOfStream)
            {
                jsonText += srReadFile.ReadLine();
            }
            //Console.WriteLine(jsonText);
            wordlist = JsonConvert.DeserializeObject<WordList>(jsonText);
        }
        public WordHelper() {
            
            
            
            //Console.WriteLine(wordlist["5"]["stater"].Chinese);
           
        }
        


        /// <summary>
        /// 对单词排序输出
        /// </summary>
        /// <param name="order">0为原顺序，1为正序，2为逆序，3为随机</param>
        /// <param name="kind">0为中英文，1为英文，2为中文，3为隐藏</param>
        /// <param name="unit">第几单元，默认输出所有单元</param>
        /// <returns></returns>
        public List<Word> Display(int order=0, int kind=0, string unit="")
        {
            //浅拷贝*****
            //wordlist = JsonConvert.DeserializeObject<WordList>(jsonText);
            //选词
            List<Word> temp = new List<Word>();//单词列表
            if (unit == "")
            {
                //所有单元的单词
                foreach(var l in wordlist.wordUnits)
                {
                    foreach(var w in l.words)
                    {
                        temp.Add(w);
                    }
                    
                }
            }
            else
            {
                //第unit单元的单词
                temp = wordlist[unit].words;
            }

            //排序
            switch (order)
            {
                case 0:
                    break;
                case 1:
                    temp.Sort();
                    break;
                case 2:
                    temp.Sort();
                    temp.Reverse();
                    break;
                case 3:
                    for(int i = 0; i < temp.Count; i++)
                    {
                        int randomIndex = new Random().Next(0, temp.Count-1);
                        Word tempword = temp[i];
                        temp[i] = temp[randomIndex];
                        temp[randomIndex] = tempword;
                    }
                    break;
                default:
                    Console.WriteLine("未知的排序方式!!!");
                    break;
            }

            //    //输出内容
            //    if(unit == "")
            //    {
            //        Console.WriteLine("所有单元的单词：");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"UNIT{unit}的单词：");
            //    }
            //    switch (kind)
            //    {
            //        case 0:
            //            foreach(var w in temp)
            //            {
            //                Console.Write(w.ToString());
            //            }
            //            break;
            //        case 1:
            //            foreach(var w in temp)
            //            {
            //                Console.WriteLine($"英文：{w.English}");
            //            }
            //            break;
            //        case 2:
            //            foreach (var w in temp)
            //            {
            //                Console.WriteLine($"中文：{w.Chinese}");
            //            }
            //            break;
            //        default:
            //            Console.WriteLine("未知输出形式!!!");
            //            break;
            //    }
            return temp;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="unit">默认所有单元</param>
        /// <returns></returns>
        public Word RandomWord(string unit="")
        {
            List<Word> temp = new List<Word>();//单词列表
            if (unit == "")
            {
                //所有单元的单词
                foreach (var l in wordlist.wordUnits)
                {
                    foreach (var w in l.words)
                    {
                        temp.Add(w);
                    }

                }
            }
            else
            {
                //第unit单元的单词
                temp = wordlist[unit].words;
            }

            int randomIndex = new Random().Next(0, temp.Count - 1);

            return temp[randomIndex];
        }
    }
}
