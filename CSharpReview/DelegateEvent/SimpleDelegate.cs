using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvent
{
    public delegate int Comparer(object obj1, object obj2);
    
    class SimpleDelegate
    {
        Name[] names = new Name[5];

        public SimpleDelegate()
        {
            names[0] = new Name("A","a");
            names[1] = new Name("B","b");
            names[2] = new Name("C","c");
            names[3] = new Name("D","d");
            names[4] = new Name("E","e");
        }

        public static void Main(string[] args)
        {
            SimpleDelegate sd = new SimpleDelegate();

            //this is the delegate instantiation
            Comparer cmp = new Comparer(Name.CompareFirstNames);

            Console.WriteLine("\n Before Sort:\n");
            sd.PrintNames();

            sd.Sort(cmp);

            Console.WriteLine("\nAfter Sort: \n");

            sd.PrintNames();

        }

        public void Sort(Comparer compare)
        {
            object temp;

            for (int i = 0; i < names.Length; i++ )
            {
                for (int j = i; j < names.Length; j++)
                {
                    // using delegate "compare" just like
                    // a normal method
                    if (compare(names[i], names[j]) > 0)
                    {
                        temp = names[i];
                        names[i] = names[j];
                        names[j] = (Name)temp;
                    }
                }
            }
        }
    
        public void PrintNames()
        {
            Console.WriteLine("Names: \n");
            foreach(Name name in names)
            {
                Console.WriteLine(name.ToString());
            }
        }
    }
}
