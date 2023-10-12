using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitoringSystemUI
{
    public partial class summaryForm : Form
    {
        private int num;
        public summaryForm()
        {
            InitializeComponent();
            num = 0;
        }

        private int totalPeople;
        private int totalInflux;
        private int totalOutflux;
        private int totalPeopleSitting;
        private int totalPeopleStanding;
        private void setValue(int totalPeople,int        totalInflux,int totalOutflux,int totalPeopleSitting,int totalPeopleStanding)
        {
            this.totalPeople = totalPeople;
            this.totalInflux = totalInflux;
            this.totalOutflux = totalOutflux;
            this.totalPeopleSitting= totalPeopleSitting;
            this.totalPeopleStanding=totalPeopleStanding;
            label10.Text = totalPeople.ToString();
            label11.Text=totalInflux.ToString();
            label13.Text = totalOutflux.ToString();
            label15.Text = totalPeopleSitting.ToString();
            label17.Text = totalPeopleStanding.ToString();
        }
        private void summaryForm_Load(object sender, EventArgs e)
        {
            setValue(10, 5, 8, 7, 9);
            chartSummary.Series["People"].Points.AddXY("Total People", totalPeople);
            chartSummary.Series["People"].Points.AddXY("Total Influx", totalInflux);
            chartSummary.Series["People"].Points.AddXY("Total Outflux", totalOutflux);
            chartSummary.Series["People"].Points.AddXY("Total Sitting", totalPeopleSitting);
            chartSummary.Series["People"].Points.AddXY("Total Standing", totalPeopleStanding);
            chartSummary.Series["People"].Points.AddXY("Total Gait Analysis ", 10);

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            chartSummary.Series["People"].Points.Clear();
         num++;
            num = num % 3;
            if (num == 0)
            {
                setValue(10, 15, 5, 7, 3);
                chartSummary.Series["People"].Points.AddXY("Total People", totalPeople);
                chartSummary.Series["People"].Points.AddXY("Total Influx", totalInflux);
                chartSummary.Series["People"].Points.AddXY("Total Outflux", totalOutflux);
                chartSummary.Series["People"].Points.AddXY("Total Sitting", totalPeopleSitting);
                chartSummary.Series["People"].Points.AddXY("Total Standing", totalPeopleStanding);

                chartSummary.Series["People"].Points.AddXY("Total Gait Analysis ", 10);

            }
            else if (num == 1)
            {
                setValue(12, 18, 6, 2, 10);
                chartSummary.Series["People"].Points.AddXY("Total People", totalPeople);
                chartSummary.Series["People"].Points.AddXY("Total Influx", totalInflux);
                chartSummary.Series["People"].Points.AddXY("Total Outflux", totalOutflux);
                chartSummary.Series["People"].Points.AddXY("Total Sitting", totalPeopleSitting);
                chartSummary.Series["People"].Points.AddXY("Total Standing", totalPeopleStanding);
          
                chartSummary.Series["People"].Points.AddXY("Total Gait Analysis ", 10);
            }
            else if (num == 2)
            {
                setValue(15,17,2,11,4);
                chartSummary.Series["People"].Points.AddXY("Total People", totalPeople);
                chartSummary.Series["People"].Points.AddXY("Total Influx", totalInflux);
                chartSummary.Series["People"].Points.AddXY("Total Outflux", totalOutflux);
                chartSummary.Series["People"].Points.AddXY("Total Sitting", totalPeopleSitting);
                chartSummary.Series["People"].Points.AddXY("Total Standing", totalPeopleStanding);
             
                chartSummary.Series["People"].Points.AddXY("Total Gait Analysis ", 10);
            }

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
