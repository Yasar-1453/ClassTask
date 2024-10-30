using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List
{
    internal class CustomList<T>
    {
        T[] List = new T[0];
        public int Count { get; set; }
        public int Capacity { get; set; }


        public void Add(T item)
        {
            if (Capacity == 0)
            {
                Capacity += 4;
                Array.Resize(ref List, List.Length + 4);
                List[Count] = item;
            }
            else if(Capacity == Count)
            {
                Capacity *= 2;
                Array.Resize(ref List, List.Length * 2);
                List[Count] = item;

            }
            else
            {
                List[Count] = item;
            }
            Count++;
        }
      

        public CustomList<T> FindAllCustom(Predicate<T> predicate)
        {
            CustomList<T> results = new CustomList<T>();
            foreach (T item in List)
            {
                if (predicate(item))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        public T FindCustom(Predicate<T> predicate)
        {
            foreach (T item in List)
            {
                if (predicate(item))
                {
                    return item;
                }
            }
            return default;
        }

        public T FirstOrDefault(Func<T, bool> predicate)
        {
            foreach (T item in List)
            {
                if (predicate(item))
                {
                    return item;
                }
            }
            return default;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return List[i];
            }
        }
        
    }
}
