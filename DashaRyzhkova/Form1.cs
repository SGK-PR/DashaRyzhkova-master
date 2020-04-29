using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashaRyzhkova
{
    public partial class Form1 : Form
    {
        private string[] vs = new string[] { "1 неделя", "2 неделя", "3 неделя", "4 неделя", "5 неделя", "6 неделя", "7 неделя",
                "8 неделя","9 неделя", "10 неделя", "11 неделя", "12 неделя", "13 неделя", "14 неделя", "15 неделя", "16 неделя","17 неделя", "18 неделя", "19 неделя", "20 неделя",
                "21 неделя", "22 неделя", "23 неделя", "24 неделя","24 неделя", "25 неделя", "26 неделя", "27 неделя", "28 неделя", "29 неделя", "30 неделя", "31 неделя","32 неделя",
                "33 неделя", "34 неделя", "35 неделя", "36 неделя", "37 неделя", "38 неделя","39 неделя","40 неделя" };


        public Form1()
        {
            InitializeComponent();

            cbTerm.Items.AddRange(vs);
        }

        public void butStart_Click(object sender, EventArgs e)
        {
           for(int i=0;i<100;i++)
            {
                Thread.Sleep(50);
            }
            
            
      
        }

        public int GetInt(string z)
        {
            
            string[] massiv = z.Split(' ');
            int x = Convert.ToInt32(massiv[0]);
            return x;
        }

        private void butStop_Click(object sender, EventArgs e)
        {
            double x, y;
            x = Convert.ToDouble(tbHeight.Text);
            y = Convert.ToDouble(tbWeight.Text);
        }

        private void Raschet(object input)
        {
            Invoke(new Action(() =>
            {
                double x, y;
                y = 0;
                try
                {
                    x = Convert.ToDouble(tbHeight.Text);
                    y = Convert.ToDouble(tbWeight.Text);
                }
                catch
                {
                    tbRezult.Text = "Введите нормальные значения";
                    return;
                }



                string z = cbTerm.SelectedItem.ToString();

                int numberWeek = GetInt(z);

                tbRezult.Text = Convert.ToString(y + numberWeek * 0.4 + " на " + numberWeek + " неделе");
            }));
        }
    }
}
