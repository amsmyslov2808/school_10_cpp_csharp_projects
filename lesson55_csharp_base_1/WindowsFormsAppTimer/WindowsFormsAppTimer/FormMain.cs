using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTimer
{
    public partial class FormMain : Form
    {
        int totalMsec, totalSec, totalMin, totalHour;
        int lapMsec, lapSec, lapMin, lapHour;

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            timer.Stop();

            totalMsec = totalSec = totalMin = totalHour = 0;
            lapMsec = lapSec = lapMin = lapHour = 0;
            countLap = 0;
            currentLap = 1;

            labelTotalTime.Text = "00:00:00.0000";
            labelLapTime.Text = "00:00:00.0000";

            labelCountLap.Text = "0";
            labelCurrentLap.Text = "1";

            listBoxLapsTime.Items.Clear();
        }

        private void buttonLap_Click(object sender, EventArgs e)
        {
            listBoxLapsTime.Items.Add($"Круг {currentLap}: {lapHour:00}:{lapMin:00}:{lapSec:00}.{lapMsec:0000}");

            lapMsec = lapSec = lapMin = lapHour = 0;

            currentLap++;
            countLap++;
            
            labelCountLap.Text = countLap.ToString();
            labelCurrentLap.Text = currentLap.ToString();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            totalMsec += 10;
            if (totalMsec >= 1000)
            {
                totalMsec = 0;
                totalSec++;
                if (totalSec >= 60)
                {
                    totalSec = 0;
                    totalMin++;
                    if (totalMin >= 60)
                    {
                        totalMin = 0;
                        totalHour++;
                    }
                }
            }

            lapMsec += 10;
            if (lapMsec >= 1000)
            {
                lapMsec = 0;
                lapSec++;
                if (lapSec >= 60)
                {
                    lapSec = 0;
                    lapMin++;
                    if (lapMin >= 60)
                    {
                        lapMin = 0;
                        lapHour++;
                    }
                }
            }

            labelTotalTime.Text = $"{totalHour:00}:{totalMin:00}:{totalSec:00}.{totalMsec:0000}";
            labelLapTime.Text = $"{lapHour:00}:{lapMin:00}:{lapSec:00}.{lapMsec:0000}";
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        int countLap;
        int currentLap;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            totalMsec = totalSec = totalMin = totalHour = 0;
            lapMsec = lapSec = lapMin = lapHour = 0;
            countLap = 0;
            currentLap = 1;

            labelTotalTime.Text = "00:00:00.0000";
            labelLapTime.Text = "00:00:00.0000";

            labelCountLap.Text = "0";
            labelCurrentLap.Text = "1";
        }
    }
}
