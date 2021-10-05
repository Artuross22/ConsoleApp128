 using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;



namespace ConsoleApp128
{
        class Program
        {
            static void Main(string[] args)
            {

                string mytxt = @"D:\SaveFile\BigTXT.txt";
                string text = "";
                text = File.ReadAllText(mytxt);
                string[] lines = text.Split();
                //1
                for (int i = 0; i < lines.Length; i++)
                    Console.WriteLine("Line {0}: {1} symbols", i, lines[i].Length);
                //2) 
                int minLength = lines.Min(e => e.Length);
                var minLines = from s1 in lines
                               where s1.Length == minLength
                               select s1;
                Console.WriteLine("\nMin line length: " + minLength + "\nLine text:\n" + minLines.ToArray()[0]);

                int maxLength = lines.Max(e => e.Length);
                var maxLines = from s2 in lines
                               where s2.Length == maxLength
                               select s2;
                Console.WriteLine("\nMax line length: " + maxLength + "\nLine text:\n" + maxLines.First()); ;
                //3)    
                IEnumerable<string> linesVar = lines.Where((l) => l.Contains("var"));
                Console.WriteLine("Lines containing \"var\":");
                foreach (string l in linesVar)
                    Console.WriteLine(l);
            }
        }
    }



