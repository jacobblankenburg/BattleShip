﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    public class FileReader
    {
        public string ReadFromFile(string fileName)
        {
            StreamReader file = new StreamReader(fileName);
            string inPut = file.ReadToEnd();
            Console.WriteLine(inPut);
            file.Close();
            return inPut;
        }
    }
}