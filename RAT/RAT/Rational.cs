using System;
using System.Collections.Generic;
using System.Text;

namespace RAT
{
    class Rational
    {
        public int numer;
        public int denumer;

        public Rational(int numer, int denumer)
        {
            this.numer = numer;
            this.denumer = denumer;
        }

        public Rational Multyply(Rational second)
        {
            Rational res = new Rational(second.numer, second.denumer);
            res.numer = this.numer * second.numer;
            res.denumer = this.denumer * second.denumer;

            return res;
        }
        public Rational Divide(Rational second)
        {
            Rational res = new Rational(second.numer, second.denumer);
            res.numer = this.numer / second.numer;
            res.denumer = this.denumer / second.denumer;

            return res;
        }
        public Rational Sum(Rational second)
        {
            Rational res = new Rational(second.numer, second.denumer);
            if (this.denumer == second.denumer)
            {
                res.numer = this.numer + second.numer;
                res.denumer = this.denumer;
            }
            if (this.denumer != second.denumer)
            {
                res.numer = this.numer * second.denumer + second.numer * this.denumer;
                res.denumer = this.denumer * second.denumer;
            }
            return res;
        }
        public Rational Razn(Rational second)
        {
            Rational res = new Rational(second.numer, second.denumer);
            if (this.denumer == second.denumer)
            {
                res.numer = this.numer - second.numer;
                res.denumer = this.denumer;
            }
            if (this.denumer != second.denumer)
            {
                res.numer = this.numer * second.denumer - second.numer * this.denumer;
                res.denumer = this.denumer * second.denumer;
            }
            return res;
        }
        public static Rational operator +(Rational c, Rational z)
        {

            return c.Sum(z);
        }
        public static Rational operator -(Rational c, Rational z)
        {

            return c.Razn(z);
        }
        public static Rational operator *(Rational c, Rational z)
        {

            return c.Multyply(z);
        }
        public static Rational operator /(Rational c, Rational z)
        {

            return c.Divide(z);
        }
    }
}

