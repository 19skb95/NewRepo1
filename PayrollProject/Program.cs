﻿using FileReadWriteLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // string TextToBeWritten=FileOperation.WriteFile(@"E:\testfile.txt");
          //  string[] arr = FileOperation.ReadLines(@"E:\testfile.txt");
           string Result = FileOperation.WriteFile(@"E:\testfile.txt");
        }
    }
}
