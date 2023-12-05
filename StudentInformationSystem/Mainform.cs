using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace StudentInformationSystem
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
            cartesianChart1.Series = new SeriesCollection()
            {
                new LineSeries()
                {
                    Title = "Men",
                    Values = new ChartValues<double> {598, 547, 573, 890, 802, 890, 857},
                    PointGeometrySize = 10
                },
                new LineSeries()
                {
                    Title = "Women",
                    Values = new ChartValues<double> {458, 398, 456, 350, 588, 212, 599},
                    PointGeometrySize = 10,
                    
                },
                new LineSeries()
                {
                    Title = "Total",
                    Values = new ChartValues<double> {1056, 945, 1029, 1240, 1390, 1102, 1456},
                    PointGeometrySize = 0,
                    Stroke = System.Windows.Media.Brushes.Transparent,
                    Fill = System.Windows.Media.Brushes.Transparent
                }
            };

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Year",
                Labels = new[] {"2017", "2018", "2019", "2020", "2021", "2022", "2023"},
                Foreground = System.Windows.Media.Brushes.Black
               
        });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Total Students",
                Foreground = System.Windows.Media.Brushes.Black
            });

            cartesianChart1.LegendLocation = LegendLocation.Top;

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            this.Hide();
            login.Show();
        }

        bool expand = false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(expand == false) {
                panel3.Height += 15;
                if(panel3.Height >= panel3.MaximumSize.Height)
                {
                    timer1.Stop();
                    expand = true;
                }
            }
            else
            {
                panel3.Height -= 15;
                if(panel3.Height <= panel3.MinimumSize.Height)
                {
                    timer1.Stop();
                    expand = false;
                }
            }
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnMaintenance_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
