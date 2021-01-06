using System;
using System.Collections.Generic;
using System.Text;

namespace words_winform
{
    public class WordList
    {
        public List<WordUnit> wordUnits { get; set; }
        
        //根据单元号索引
        public WordUnit this[string unit]
        {
            get
            {
                foreach(var l in wordUnits)
                {
                    if (l.unit.Equals(unit))
                    {
                        return l;
                    }
                }
                Console.WriteLine($"没有第{unit}单元的单词!!!");
                return new WordUnit();
            }
        }
        public override string ToString()
        {
            string str = "";
            foreach(var l in wordUnits)
            {
                str += l.ToString();
            }
            return str;
        }
    }
    public class WordUnit
    {
        public string unit { set; get; }
        public List<Word> words { get; set; }

        //根据英文索引
        public Word this[string English]
        {
            get
            {
                if(words != null)
                {
                    foreach (var w in words)
                    {
                        if (w.English.Equals(English))
                        {
                            return w;
                        }
                    }
                }
                Console.WriteLine($"没有单词{English}!!!");
                return new Word();
            }
        }
        public override string ToString()
        {
            string str = "";
            str += $"UNIT{unit}：\n";
            foreach(var w in words)
            {
               str += w.ToString();
            }
            return str + "\n";
        }
    }
    public class Word:IComparable<Word>
    {
        public string English { set; get; }
        public string Chinese { set; get; }

        public override string ToString()
        {
            return String.Format("英文：{0}\t中文：{1}\n", English, Chinese);
        }

        public int CompareTo(Word w)
        {
            return English.CompareTo(w.English);
        }
    }
}
