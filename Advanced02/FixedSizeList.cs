using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced02
{
    internal class FixedSizeList<T>
    {

        public T[] FixedList { set; get; }
        public int Count { get; set; } = 0;


        public FixedSizeList(int _fixedcapcity)
        {
            FixedList = new T[_fixedcapcity];
        }

        
        public void AddElementToTheList(T value) 
        {
            if (FixedList.Length== Count)
            {
                throw new InvalidOperationException("list is already full");
            }

            FixedList[Count]  = value;
            Count++;
        }

        public T GetElementAtSpecificIndex(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException();
            }

            return FixedList[index];
        }

        public  int TheFirstNonRepeatedCharacter(string word)
        {
            char charword;
            Dictionary<char, int> Char = new Dictionary<char, int>();

            Dictionary<char, int> RepatedChar = new Dictionary<char, int>();

            for (int i = 0; i < word.Length; i++)
            {
                charword = word[i];

                if (Char.ContainsKey(charword))
                {
                    RepatedChar.Add(charword, i);
                    continue;
                }
                else
                {
                    Char.Add(charword, i);
                }
                
            }

            if (RepatedChar.Count == 0)
            {
                return 0;
            }

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < RepatedChar.Count; j++)
                {
                    if (!RepatedChar.ContainsKey(word[i]))
                    {
                        return i;
                    }
                }
            }


            return -1;
        }
    }
}
