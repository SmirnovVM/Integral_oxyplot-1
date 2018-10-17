using OxyPlot;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Diagnostics;


namespace Integral
{
    /// <summary>
    /// Логика взаимодействия для Bars.xaml
    /// </summary>
    public partial class Bars : Window
    {
        public Bars()
        {
            InitializeComponent();
        }





        public void culc()
        {
            (graph3.Model.Series[0] as BarSeries).Items.Clear();
            Stopwatch timer = new Stopwatch();
            double n = 100000;
            double In1 = 0;
            int kol = 7;
            Random rnd = new Random();
            Integral_calculate integ = new Integral_calculate();
            for (int k = 0; k < kol; k++)
            {


                timer.Start();
                In1 = integ.calcParr(n);
                timer.Stop();
                (graph3.Model.Series[0] as BarSeries).Items.Add(new BarItem(timer.ElapsedMilliseconds, (int)n / 100000));         //new DataPoint(timer.ElapsedMilliseconds, n / 100000));
                timer.Reset();

                timer.Reset();

                graph3.InvalidatePlot();
                // MessageBox.Show(In1 + "  " + In2);
                n *= 2;
            }
            graph3.InvalidatePlot();
        }



    }
}
