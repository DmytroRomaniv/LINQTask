using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTask
{
    class Group1
    {
        public static IEnumerable<string> Task1(IEnumerable<string> data)
        {
            IEnumerable<string> array = data.Where(i => Int32.TryParse(i, out int integer) && Int32.Parse(i) > 0).ToList();
            return array;
        }

        public static IEnumerable<string> Task2(IEnumerable<string> data)
        {
            IEnumerable<string> array = data.Where(i => Int32.TryParse(i, out int integer) && Int32.Parse(i) % 2 == 0).Distinct();
            return array;
        }

        public static IEnumerable<string> Task3(IEnumerable<string> data)
        {
            IEnumerable<string> array = data.Where(i => Int32.TryParse(i, out int integer) && Int32.Parse(i) > 9 && Int32.Parse(i) < 100).OrderBy(i => Int32.Parse(i));
            return array;
        }

        public static IEnumerable<string> Task4(IEnumerable<string> data)
        {
            IEnumerable<string> array = data.Where(i =>
            {
                foreach (var c in i.ToLower())
                {
                    if (c < 'a' || c > 'z' )
                        return false;
                }
                return true;
            }
            ).OrderBy(i => i.Length).ThenByDescending(i => i);
            return array;
        }

        public static IEnumerable<string> Task5(IEnumerable<string> data)
        {
            int d = Int32.Parse(data.Take(1).ToList()[0]);
            IEnumerable<string> array = data.Skip(1).SkipWhile(i => Int32.TryParse(i, out int integer) && Int32.Parse(i) < d).Where(i => Int32.Parse(i) > 0 && Int32.Parse(i) % 2 == 1).OrderByDescending(i => i);
            return array;
        }
    }
}
