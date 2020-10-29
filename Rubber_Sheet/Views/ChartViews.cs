using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rubber_Sheet.Models;

using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Defaults;

namespace Rubber_Sheet
{
    public partial class ChartViews : UserControl
    {
        public ChartViews()
        {
            InitializeComponent();

            LineChartConfigure();
            LineChartConfigure2();
        }

        private void timer1Update_Tick(object sender, EventArgs e)
        {
            txtTS3.Text = DataTemperature.TS2.ToString("00.00");
            txtTS3.Text = DataTemperature.TS3.ToString("00.00");
            txtTS4.Text = DataTemperature.TS4.ToString("00.00");
            txtTS5.Text = DataTemperature.TS5.ToString("00.00");
            txtTS6.Text = DataTemperature.TS6.ToString("00.00");
            txtTempSET.Text = DataTemperature.TemperatureSET.ToString("00.00");
            //
            txtRH.Text = DataTemperature.TS_RH.ToString("00.00");
            txtRH_SET.Text = DataTemperature.HumiditySET.ToString("00.00");

        }

        private void timer2Chart_Tick(object sender, EventArgs e)
        {
            UpdateChartLine();
            UpdateChartLine2();
        }
        //
        public void LineChartConfigure()
        {
            var lineTempTS1Series = new LineSeries();
            lineTempTS1Series.Title = "Nhiệt độ TS3";
            lineTempTS1Series.Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(0)
                    };
            lineTempTS1Series.PointGeometrySize = 6;

            var lineTempTS2Series = new LineSeries();
            lineTempTS2Series.Title = "Nhiệt độ TS4";
            lineTempTS2Series.Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(0)
                    };
            lineTempTS2Series.PointGeometrySize = 6;

            var lineTempTS3Series = new LineSeries();
            lineTempTS3Series.Title = "Nhiệt độ TS5";
            lineTempTS3Series.Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(0)
                    };
            lineTempTS3Series.PointGeometrySize = 6;

            var lineTempTS4Series = new LineSeries();
            lineTempTS4Series.Title = "Nhiệt độ TS6";
            lineTempTS4Series.Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(0)
                    };
            lineTempTS4Series.PointGeometrySize = 6;

            var lineTempTS5Series = new LineSeries();
            lineTempTS5Series.Title = "Nhiệt độ REF";
            lineTempTS5Series.Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(0)
                    };
            lineTempTS5Series.PointGeometrySize = 6;

            cartesianChart1.Series = new SeriesCollection
            {
                lineTempTS1Series,
                lineTempTS2Series,
                lineTempTS3Series,
                lineTempTS4Series,
                lineTempTS5Series,
            };
            //
            var tooltip = new DefaultTooltip
            {
                SelectionMode = TooltipSelectionMode.SharedYValues
            };

            cartesianChart1.DataTooltip = tooltip;
            cartesianChart1.LegendLocation = LegendLocation.Bottom;


        }
        public void LineChartConfigure2()
        {
            var lineTempTS1Series = new LineSeries();
            lineTempTS1Series.Title = "Độ ẩm sấy";
            lineTempTS1Series.Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(0)
                    };
            lineTempTS1Series.PointGeometrySize = 6;

            var lineTempTS2Series = new LineSeries();
            lineTempTS2Series.Title = "Độ ẩm đặt";
            lineTempTS2Series.Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(0)
                    };
            lineTempTS2Series.PointGeometrySize = 6;


            cartesianChart2.Series = new SeriesCollection
            {
                lineTempTS1Series,
                lineTempTS2Series,

            };
            //
            var tooltip = new DefaultTooltip
            {
                SelectionMode = TooltipSelectionMode.SharedYValues
            };

            cartesianChart2.DataTooltip = tooltip;
            cartesianChart2.LegendLocation = LegendLocation.Bottom;


        }
        int nSampeTemp = 100;
        private void UpdateChartLine()
        {
            if (cartesianChart1.Series[0].Values.Count > nSampeTemp)
            {
                cartesianChart1.Series[0].Values.RemoveAt(0);
            }
            cartesianChart1.Series[0].Values.Add(new ObservableValue(DataTemperature.TS3));

            if (cartesianChart1.Series[1].Values.Count > nSampeTemp)
            {
                cartesianChart1.Series[1].Values.RemoveAt(0);
            }
            cartesianChart1.Series[1].Values.Add(new ObservableValue(DataTemperature.TS4));

            if (cartesianChart1.Series[2].Values.Count > nSampeTemp)
            {
                cartesianChart1.Series[2].Values.RemoveAt(0);
            }
            cartesianChart1.Series[2].Values.Add(new ObservableValue(DataTemperature.TS5));

            if (cartesianChart1.Series[3].Values.Count > nSampeTemp)
            {
                cartesianChart1.Series[3].Values.RemoveAt(0);
            }
            cartesianChart1.Series[3].Values.Add(new ObservableValue(DataTemperature.TS6));

            if (cartesianChart1.Series[4].Values.Count > nSampeTemp)
            {
                cartesianChart1.Series[4].Values.RemoveAt(0);
            }
            cartesianChart1.Series[4].Values.Add(new ObservableValue(DataTemperature.TemperatureSET));

        }
        int nSampeHumidity = 100;
        private void UpdateChartLine2()
        {
            if (cartesianChart2.Series[0].Values.Count > nSampeHumidity)
            {
                cartesianChart2.Series[0].Values.RemoveAt(0);
            }
            cartesianChart2.Series[0].Values.Add(new ObservableValue(DataTemperature.TS_RH));

            if (cartesianChart2.Series[1].Values.Count > nSampeHumidity)
            {
                cartesianChart2.Series[1].Values.RemoveAt(0);
            }
            cartesianChart2.Series[1].Values.Add(new ObservableValue(DataTemperature.HumiditySET));
        }

    }
}
