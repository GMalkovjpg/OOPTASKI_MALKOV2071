using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ООП_4_Календарь
{
    class MyDate
    {
        private int day;
        private int month;
        private int year;
        public MyDate(int day, int month, int year) //setdate по заданию
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public bool VicocosYear()
        {
            bool res1;
            if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
                res1= true;
            else res1= false;
            return res1;
        }
        public MyDate NextDate(int day, int month, int year)
        {
            MyDate date = new MyDate(day, month, year);
            #region Проверка
            if (month == 12 && day == 31)
            {
                date.day = 1;
                date.month = 1;
                date.year += 1;
            }
            else
            {
                if ((month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10) && day == 31)
                {
                    date.day = 1;
                    date.month += 1;
                }
                else
                {
                    if ((month == 4 || month == 6 || month == 9 || month == 11) && day == 30)
                    {
                        date.day = 1;
                        date.month += 1;
                    }
                    else
                    {
                        if (month == 2 && date.VicocosYear() == true && day == 29)
                        {
                            date.day = 1;
                            date.month += 1;
                        }
                        else
                        {

                            if (month == 2 && date.VicocosYear() == false && day == 28)
                            {
                                date.day = 1;
                                date.month += 1;
                            }
                            else
                            {
                                date.day += 1;
                            }
                        }
                    }
                }
            }
            return date;
            #endregion
        }
        public bool Valid()
        {
            bool res = true;
            MyDate date = new MyDate(day, month, year);
            if (month > 12 || month < 1)
            {
                res=false;
            }
            else
            {
                if (year <= 0)
                {
                    res= false;
                }
                else
                {
                    if ((month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10) && day > 31)
                    {
                        res= false;
                    }
                    else
                    {
                        if ((month == 4 || month == 6 || month == 9 || month == 11) && day > 30)
                        {
                            res= false;
                        }
                        else
                        {
                            if (month == 2 && date.VicocosYear() == true && day > 29)
                            {
                                res= false;
                            }
                            else
                            {
                                if (month == 2 && date.VicocosYear() == false && day > 28)
                                {
                                    res= false;
                                }
                            }
                        }
                    }
                }
            }
            return res;
        }
        #region Visual
        public string Visualday()
        {
            string Day = day.ToString();
                return Day;
        }
        public string Visualmonth()
        {
            string Month = month.ToString();
            return Month;

        }
        public string Visualyear()
        {
            string Year = year.ToString();
            return Year;

        }
        #endregion 
    }
}




