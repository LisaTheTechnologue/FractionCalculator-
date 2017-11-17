using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionLib
{
    public class Fraction
    {
        public int Top;
        public int Bottom;
        public Fraction (int top = 0, int bottom = 1)
        {
            Top = top;
            Bottom = bottom;
        }
        public static Fraction operator +(Fraction left,Fraction right)
        {
            int top = left.Top*right.Bottom + right.Top*left.Bottom;
            int bottom = left.Bottom * right.Bottom;
            return new Fraction(top, bottom);
        }
        public static Fraction operator -(Fraction left, Fraction right)
        {
            int top = left.Top * right.Bottom - right.Top * left.Bottom;
            int bottom = left.Bottom * right.Bottom;
            return new Fraction(top, bottom);
        }
        public override string ToString()
        {
            return string.Format("{0}/{1}", Top, Bottom);
        }
    }
}
