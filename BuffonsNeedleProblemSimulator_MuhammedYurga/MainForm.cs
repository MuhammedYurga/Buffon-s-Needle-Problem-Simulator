using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace BuffonsNeedleProblemSimulator_MuhammedYurga
{
    public partial class MainForm : Form
    {
        int sayi = 0;
        Thread islem;
        Graphics line;
        Pen linepen;
        Pen NeedleRedPen;
        Pen NeedleGreenPen;
        double OnTheLineRatio1;
        double OnTheLineRatio2;
        bool Ratio1orRatio2;
        public MainForm()
        {
            InitializeComponent();
            line = simulationpanel.CreateGraphics();
            Ratio1orRatio2 = false;
        }

        private void speedtrack_ValueChanged(object sender, EventArgs e)
        {
            if(speedtrack.Value == 0)
            {
                speedtrack.Value = 1;
            }
            speedud.Value = (int)speedtrack.Value;
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            
            btnstart.Visible = false;
            btnstop.Visible = true;
            linepen = new Pen(Color.Black, 2);
            line.Clear(Color.White);
            //1184; 474
            int Wi = simulationpanel.Size.Width;
            int He = simulationpanel.Size.Height;
            int needlelen = (int)needlelentrack.Value;
            int[] lineX = new int[(int)(Wi/needlelen)+1]; //It will keep X points of reference lines.
            int lineXcounter = 0;
            for (int j = needlelen/2; j < Wi-1; j=j+needlelen)
            {
                line.DrawLine(linepen, j, 0, j, He);
                lineX[lineXcounter] = j;
                lineXcounter++;
            }
            NeedleRedPen = new Pen(Color.Red, needlelen/10);
            NeedleGreenPen = new Pen(Color.Green, needlelen / 10);
            islem = new Thread(() =>
            {
                int DropTimes = (int)droptimesud.Value;
                bool IsInfınıty = false;
                if(DropTimes == 0)
                {
                    IsInfınıty = true;
                    DropTimes = 1;
                }
                float oldx1 = -1, oldy1 = -1, oldAngle = -1;
                Stopwatch stp = new Stopwatch();
                stp.Start();
                for (int j = 0; j < DropTimes; j++)
                {
                    float x1;
                    float y1;
                    float x2 = 0;
                    float y2 = 0;
                    float Angle;
                    do
                    {
                        Random rnd = new Random();
                        x1 = rnd.Next(Wi - (2 * needlelen)) + needlelen;
                        y1 = rnd.Next(He - (2 * needlelen)) + needlelen;
                        Angle = rnd.Next(360);
                    } while (oldx1 == x1 && oldy1 == y1 && oldAngle == Angle);
                    oldx1 = x1;
                    oldy1 = y1;
                    oldAngle = Angle;
                    if (Angle <= 90)
                    {
                        x2 = x1 + ((float)Math.Cos((Angle * Math.PI) / 180) * needlelen);
                        y2 = y1 + ((float)Math.Sin((Angle * Math.PI) / 180) * needlelen);
                    }
                    else if (Angle >= 180)
                    {
                        x2 = x1 - ((float)Math.Cos((Angle * Math.PI) / 180) * needlelen);
                        y2 = y1 + ((float)Math.Sin((Angle * Math.PI) / 180) * needlelen);
                    }
                    else if (Angle >= 270)
                    {
                        x2 = x1 - ((float)Math.Cos((Angle * Math.PI) / 180) * needlelen);
                        y2 = y1 - ((float)Math.Sin((Angle * Math.PI) / 180) * needlelen);
                    }
                    else
                    {
                        x2 = x1 + ((float)Math.Cos((Angle * Math.PI) / 180) * needlelen);
                        y2 = y1 - ((float)Math.Sin((Angle * Math.PI) / 180) * needlelen);
                    }
                    bool IsOnLine1 = false;
                    bool IsOnLine2 = false;
                    for(int i = 0; i < lineXcounter; i++)
                    {
                        if ((x1 - lineX[i]) * (x2 - lineX[i]) <= 0)
                        {
                            IsOnLine1 = true;
                        }
                        if ((x1 - lineX[i]) * (x2 - lineX[i]) < 0)
                        {
                            IsOnLine2 = true;
                        }
                    }
                    bool IsRed = false;
                    if (Ratio1orRatio2)
                    {
                        if (IsOnLine1)
                        {
                            line.DrawLine(NeedleRedPen, x1, y1, x2, y2);
                            lblOnLineCount.Text = Convert.ToInt32(lblOnLineCount.Text) + 1 + "";
                            Ratio1orRatio2 = false;
                            IsRed = true;
                        }
                    }
                    else
                    {
                        if (IsOnLine2)
                        {
                            line.DrawLine(NeedleRedPen, x1, y1, x2, y2);
                            lblOnLineCount.Text = Convert.ToInt32(lblOnLineCount.Text) + 1 + "";
                            Ratio1orRatio2 = true;
                            IsRed = true;
                        }
                    }
                    if(!IsRed)
                    {
                        line.DrawLine(NeedleGreenPen, x1, y1, x2, y2);
                    }
                    lblDropCount.Text = Convert.ToInt32(lblDropCount.Text) + 1 + "";
                    Thread.Sleep(1560 / (int)speedtrack.Value);
                    if (IsInfınıty == true)
                    {
                        j = j - 1;
                    }
                }
                stp.Stop();
                lblratio.Text = stp.Elapsed+"";
                btnstart.Visible = true;
                btnstop.Visible = false;
                islem.Abort();

            });
            islem.Start();
                        
        }
        
        private void btnstop_Click(object sender, EventArgs e)
        {
            btnstart.Visible = true;
            btnstop.Visible = false;
            islem.Abort();
        }

        private void speedud_ValueChanged(object sender, EventArgs e)
        {
            speedtrack.Value = (int)speedud.Value;
        }

        private void needlelentrack_ValueChanged(object sender, EventArgs e)
        {
            needlelenud.Value = (int)needlelentrack.Value;
        }

        private void needlelenud_ValueChanged(object sender, EventArgs e)
        {
            needlelentrack.Value = (int)needlelenud.Value;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(btnstart.Visible == false)
            {
                islem.Abort();
            }
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            if (btnstart.Visible)
            {
                line.Clear(Color.White);
                lblDropCount.Text = "0";
                lblOnLineCount.Text = "0";
                OnTheLineRatio1 = 0;
                OnTheLineRatio2 = 0;
            }            
        }

        private void lblDropCount_TextChanged(object sender, EventArgs e)
        {
            if(lblOnLineCount.Text != "0")
            {
                lblratio.Text = 2 * Convert.ToDouble(lblDropCount.Text) / Convert.ToDouble(lblOnLineCount.Text)+"";
            }
        }
    }
}

