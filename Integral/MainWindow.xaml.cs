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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace Integral
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool flag = true;
        public MainWindow()
        {
            InitializeComponent();

        }



        void Default()
        {
            _resultText.Text = "";
            _timeText.Text = "";

        }
        double a;
        double b;

        void Calculate()
        {
            Integral_calculate integral = new Integral_calculate();
            int n = Convert.ToInt32(this._n.Text);

            double In;
            a = Convert.ToInt32(this._a.Text);
            b = Convert.ToInt32(this._b.Text);
            Stopwatch timer = new Stopwatch();
            if (_check.IsChecked.Value == true)
            {
                timer.Start();
                In = integral.calcParr(n, a, b, x => 32 * x - Math.Log10(2 * x) - 41);
                timer.Stop();
                this._resultText.Text = Convert.ToString(In);
                this._timeText.Text = Convert.ToString(timer.ElapsedMilliseconds);
                timer.Reset();
            }
            if (_check.IsChecked.Value == false)
            {
                timer.Start();
                In = integral.calcPosl(n, a, b, x => 32 * x - Math.Log10(2 * x) - 41);
                timer.Stop();
                this._resultText.Text = Convert.ToString(In);
                this._timeText.Text = Convert.ToString(timer.ElapsedMilliseconds);
                timer.Reset();
            }



        }

        private void ButtonCulc_Click(object sender, RoutedEventArgs e)
        {
            // if ()
            ///  double.TryParse
            try
            {
                Convert.ToDouble(_n.Text);
            }
            catch
            {
                MessageBox.Show("Введите целое число");
                return;
            }

            if (Convert.ToDouble(_n.Text) <= 0) {
                MessageBox.Show("Введите n больше 0");
                return;
            }


            if (Convert.ToDouble(_a.Text) >= Convert.ToDouble(_b.Text)) {
                MessageBox.Show("Нижняя граница не должна превышать или быть равной верхней");
                return;
            }
            


            Default();
            Calculate();

            /* else {
                 MessageBox.Show("Введите целое число");
             }*/
        }
        Posl_graph posl = new Posl_graph();
        Paral_graph paral = new Paral_graph();
        Bars bar = new Bars();


        private void PoslGraph_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToDouble(_a.Text) >= Convert.ToDouble(_b.Text))
            {
                MessageBox.Show("Нижняя граница не должна превышать или быть равной верхней");
                return;
            }
            posl.culc(a,b);
            posl.Show();

        }

        private void ParalGraph_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToDouble(_a.Text) >= Convert.ToDouble(_b.Text))
            {
                MessageBox.Show("Нижняя граница не должна превышать или быть равной верхней");
                return;
            }
            paral.culc(a, b);
            paral.Show();
        }

        private void barGraph_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToDouble(_a.Text) >= Convert.ToDouble(_b.Text))
            {
                MessageBox.Show("Нижняя граница не должна превышать или быть равной верхней");
                return;
            }
            bar.culc(a, b);
            bar.Show();

        }
    }
}
