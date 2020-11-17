using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDemos
{
    class TextStatistics
    {
        private string _text;

        public TextStatistics(string text)
        {
            _text = text;
        }
        public int CountLines()
        {
            return _text.Split('\n').Length;
        }

        public int CountTabs()
        {
            return _text.Split('\t').Length;
        }
    }
}
