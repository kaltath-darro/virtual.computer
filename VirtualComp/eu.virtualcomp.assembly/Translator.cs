using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualComp.eu.virtualcomp.assembly
{
    public static class Translator
    {
        private static IDictionary<string, byte> mapping = new Dictionary<string, byte>()
        {
            {"mov", 0b00000001 },
            {"r1", 0b00000001 },
            {"r2", 0b00000010 },
            {"dat", 0b00000010 },
        };

        public static void Load(string path)
        {
            using (TextReader stringReader = new StreamReader(@"d:\test.asm")) 
            {
                bool working = true;
                while (working)
                {
                    string line = stringReader.ReadLine();
                    if (line != null)
                    {
                        string trimmed = line.Trim();
                        string lowered = trimmed.ToLower();
                        string opkod = lowered.Substring(0, 3);

                        int index = lowered.IndexOf(' ');
                        string inst1 = lowered.Substring(index, lowered.IndexOf(',') - index);
                        inst1 = inst1.Trim();

                        int index2 = lowered.IndexOf(',') + 1;
                        string inst2 = lowered.Substring(index2, lowered.Length - index2);
                        inst2 = inst2.Trim();
                    }
                    else
                    {
                        working = false;
                    }
                }
            }
        }
    }
}
