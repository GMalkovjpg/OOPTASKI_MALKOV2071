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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void data1_Click(object sender, EventArgs e)
        {
            int day = Convert.ToInt32(daytext.Text);
            int month = Convert.ToInt32(monthtext.Text);
            int year = Convert.ToInt32(yeartext.Text);
            MyDate date = new MyDate(day, month, year);
            #region Проверка
            if (date.Valid() == true)
            {
                #region Вывод
                datalabelD.Text = date.Visualday();
                datalabelM.Text = date.Visualmonth();
                datalabelY.Text = date.Visualyear();
                #endregion
            }
            else
            {
                MessageBox.Show("Введите корректную дату");
            }
        }
        #endregion
        private void vpered_Click_1(object sender, EventArgs e)
        {
            int day = Convert.ToInt32(datalabelD.Text);
            int month = Convert.ToInt32(datalabelM.Text);
            int year = Convert.ToInt32(datalabelY.Text);
            MyDate date = new MyDate(day, month, year);
            //Datal.Text = date.Visual();
            #region Вывод
            datalabelD.Text = date.NextDate(day, month, year).Visualday();
            datalabelM.Text = date.NextDate(day, month, year).Visualmonth();
            datalabelY.Text = date.NextDate(day, month, year).Visualyear();
            #endregion
        }


    } 
}
