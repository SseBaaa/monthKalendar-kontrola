using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace month_kalendar_kontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void buttontermin_Click(object sender, EventArgs e)
        {
            TimeSpan odabir = monthCalendar.SelectionEnd - monthCalendar.SelectionStart;

            if(odabir.Days < 1)
            {
                MessageBox.Show("Niste odabrali niti jedan datum stisnite shift za odabranje datuma: " , "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Vaša rezervacija pocinje od: " + monthCalendar.SelectionStart.ToShortDateString() + " do" + monthCalendar.SelectionEnd.ToShortDateString(), "Greska", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
