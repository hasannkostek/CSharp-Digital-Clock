using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dijital_Saat_Uygulaması
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timerZaman_Tick(object sender, EventArgs e)
        {
            DateTime zaman = DateTime.Now; // zamana Şimdiki Zamanı atadık.
            labelZaman.Text = zaman.ToString();
            // ayrı ayrı yıl,ay,gün metodlarıyla eşleştirdik.
            labelYıl.Text = zaman.Year.ToString();
            // c# kütüphanesini kullandık ("using System.Globalization;")
            labelAy.Text = CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat.MonthNames[zaman.Month-1]; // ocak ayını "0" kabul ettiği için
            labelGun.Text = CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat.DayNames[(int)zaman.DayOfWeek];

        }
    }
}
