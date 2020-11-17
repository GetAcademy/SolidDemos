using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SolidDemos
{
    class TextFileLineCounter
    {
        private readonly string _filename;

        public TextFileLineCounter(string filename)
        {
            _filename = filename;
        }

        public int Count()
        {
            var lines = File.ReadAllLines(_filename);
            var count = lines.Length;
            return count;
        }
    }
}
