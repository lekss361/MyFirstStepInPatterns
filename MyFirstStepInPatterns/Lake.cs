using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstStepInPatterns
{
    public class Lake
    {
        public string Name { get; set; }

        public void QQQ()
        {
            Console.WriteLine("sdfsgfdsgdsfgsdfgsdfg");
        }


        private static Lake _lake; 

        private Lake()
        {

        }

        public static Lake GetLake()
        {
            if (_lake is null)
            {
                _lake= new Lake();
            }
            return _lake;
        }
    }
}
