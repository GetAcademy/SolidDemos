using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDemos
{
    class SpecialColor : Color
    {
        private int _specialEffect;

        public SpecialColor()
        {
            //_red = 5;
        }

        public override void Invert()
        {
            base.Invert();
            
        }
    }
}
