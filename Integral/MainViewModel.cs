﻿using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Axes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integral
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            this.MyModel1 = new PlotModel { Title = "Время от разбиения посл." };
            MyModel1.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Bottom,
                /*Maximum = 150,
                Minimum = 0,*/
                Title = "Время, мск",
                //Title = "Кол-во разбиений, n*100000",
                TitleFontSize = 15,
            });
            MyModel1.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                /*  Maximum = 20,
                  Minimum = 0,*/
                //Title = "Время, мск",
                Title = "Кол-во разбиений, n*100000",
                TitleFontSize = 10
            });
            var series1 = new LineSeries
            {
                MarkerType = MarkerType.Circle,
                MarkerSize = 5,
                MarkerStroke = OxyColors.Black
            };
            this.MyModel1.Series.Add(series1);



            this.MyModel2 = new PlotModel { Title = "Время от разбиения парал." };
            MyModel2.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Bottom,
               /* Maximum = 150,
                Minimum = 0,*/
                Title = "Время, мск",
                //Title = "Кол-во разбиений, n*100000",
                TitleFontSize = 15,
            });
            MyModel2.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                /*  Maximum = 20,
               Minimum = 0,*/
                //Title = "Время, мск",
                Title = "Кол-во разбиений, n*100000",
                TitleFontSize = 10
            });
            // this.MyModel2 = new PlotModel { Title = "График 2" };
            var series2 = new LineSeries
            {
                MarkerType = MarkerType.Circle,
                MarkerSize = 5,
                MarkerStroke = OxyColors.Black
            };

            this.MyModel2.Series.Add(series2);


            this.MyModel3 = new PlotModel { Title = "Столбчатая диаграмма" };
            MyModel3.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                /*Maximum = 150,
                Minimum = 0,*/
                Title = "Время, мск",
                //Title = "Кол-во разбиений, n*100000",
                TitleFontSize = 15,
            });
            MyModel3.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Bottom,
                /*  Maximum = 20,
               Minimum = 0,*/
                //Title = "Время, мск",
                Title = "Кол-во разбиений, n*100000",
                TitleFontSize = 10
            });
            ColumnSeries series3 = new ColumnSeries();

            

            this.MyModel3.Series.Add(series3);

            // this.MyModel2 = new PlotModel { Title = "График 2" };



        }

        public PlotModel MyModel1 { get; private set; }
        public PlotModel MyModel2 { get; private set; }
        public PlotModel MyModel3 { get; private set; }

    }
}
