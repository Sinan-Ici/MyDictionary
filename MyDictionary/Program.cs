using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> kitap = new MyDictionary<int, string>();
            kitap.Add(101, "Yabancı");
            kitap.Add(102, "Dönüşüm");
            kitap.Add(103, "Veba");
            kitap.Add(104, "Dava");
            
        }
    }
}
