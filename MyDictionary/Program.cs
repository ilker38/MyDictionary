using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int,string > isimler = new MyList<int,string>();
            isimler.Add(84,"Veli");
            Console.WriteLine(isimler.Length);
            isimler.Add(48, "Ali");
            Console.WriteLine(isimler.Length);
            foreach (var item in isimler.Values)
            {
                Console.WriteLine(item);
            }


        }
    }
    
}
