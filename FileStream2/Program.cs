using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileStream2
{
    class FileStrem
    {
        public static void Read(string line1 , string[]text)
        {
            
            
            using(FileStream fs = new FileStream(line1, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(line1))
                    {
                        for(int i = 0; i < text.Length; i++)
                        {
                            text[i] = sr.ReadLine();
                        }
                    }
            }
            Console.WriteLine("Text copied to array succesfully.");
        }
        public static void CreateAndWrite(string[] lines , string line2)
        {
            
                using(StreamWriter sw = new StreamWriter(line2,true))
                {
                    for(int i = 0; i<lines.Length; i++)
                    {
                        sw.WriteLine(lines[i]);
                    }
                }
                Console.WriteLine("Text is wrote to array succesfully.");
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write source adress of text : ");
            string path1 = Console.ReadLine();
            Console.WriteLine("Write finally file : ");
            string path2 = Console.ReadLine();
            string[] text = new string[17];
            FileStrem.Read(path1,text);
            FileStrem.CreateAndWrite(text, path2);
        }
    }
}
