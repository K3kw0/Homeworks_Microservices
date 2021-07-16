using System;
using System.Collections.Generic;

namespace lesson_1
{
    public class Zxc
    {
        public List<string> A { get; set; }
        public string Summary { get; set; }


        public Zxc()
        {
            A = new List<string>();
            A.Add("Добавьте метод для получения коллекции строк");
            A.Add("Возможность получить N-объект из коллекции (где N - порядковый номер)");
            A.Add("Возможность удалить все объекты");
        }

        public string Find(int x)
        {
            string current = string.Empty;
            for (int i = 0; i < A.Count; i++)
            {
                if (i + 1 == x) current = A[i];
            }
            return current;
        }

        public List<string> Clearr()
        {
            A.Clear();
            return A;
        }

        public List<string> Adda(int words)
        {
            int let = 20;
            char[] chars = "sdf jgn sdj nfg sdf ig jsod ifg jro igj sruj ntg jrse bnt jig b".ToCharArray();
            var q = new Random();
            for (int i = 0; i < words; i++)
            {
                string word = "";
                for (int e = 0; e < let; e++)
                {
                    char lett = (char)q.Next(0, chars.Length - 1);
                    word += chars[lett];
                }
                A.Add(word);
            }
            return A;
        }
    }
}
