using System;
using System.IO;
using System.Collections.Generic;
using inter_face_icomparable.Entities;

namespace inter_face_icomparable
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\mathe\list.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Eployww> list = new List<Eployww>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Eployww(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Eployww str in list)
                    {
                        Console.WriteLine(str);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }

    
    }
}
