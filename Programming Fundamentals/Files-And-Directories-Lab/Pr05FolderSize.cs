﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pr05FolderSize
{
    class Pr05FolderSize
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles("TestFolder");
            double sum = 0;
            foreach (var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                sum += fileInfo.Length;
            }
            sum = sum / 1024 / 1024;
            File.WriteAllText("output.txt", sum.ToString());
        }
    }
}
