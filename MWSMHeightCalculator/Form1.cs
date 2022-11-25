using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MWSMHeightCalculator
{
    public partial class frmMwsmHeightCal : Form
    {
        public frmMwsmHeightCal()
        {
            InitializeComponent();
        }
        double lbV1num = 0;
        double lbV2num = 0;
        double lbV3num = 0;
        double lbI1num = 0;
        double lbI2num = 0;
        double lbI3num = 0;
        double totalV;
        double totalI;
        double v1;
        double v2;
        double v3;
        double i1;
        double i2;
        double i3;

        private void button1_Click(object sender, EventArgs e)
        {
            lbV1num += 1;
            lbV1.Text = Convert.ToString(lbV1num);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lbV1num != 0 )
            {
                lbV1num -= 1;
                lbV1.Text = Convert.ToString(lbV1num);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbV2num += 1;
            lbV2.Text = Convert.ToString(lbV2num);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (lbV2num != 0)
            {
                lbV2num -= 1;
                lbV2.Text = Convert.ToString(lbV2num);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbV3num += 1;
            lbV3.Text = Convert.ToString(lbV3num);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (lbV3num != 0)
            {
                lbV3num -= 1;
                lbV3.Text = Convert.ToString(lbV3num);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            lbI1num += 1;
            lbI1.Text = Convert.ToString(lbI1num);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (lbI1num != 0)
            {
                lbI1num -= 1;
                lbI1.Text = Convert.ToString(lbI1num);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            lbI2num += 1;
            lbI2.Text = Convert.ToString(lbI2num);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (lbI2num != 0)
            {
                lbI2num -= 1;
                lbI2.Text = Convert.ToString(lbI2num);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            lbI3num += 1;
            lbI3.Text = Convert.ToString(lbI3num);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (lbI3num != 0)
            {
                lbI3num -= 1;
                lbI3.Text = Convert.ToString(lbI3num);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (txtM.Text == "" || txtM.Text == "0")
            {
                MessageBox.Show("Please enter the weight of the system.", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (lbV1num + lbV2num + lbV3num < 2 )
            {
                MessageBox.Show("Please select at least two beams.", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {

                totalV = (lbV1num * 34 + lbV2num * 42.5 + lbV3num * 50) + 108 + 40 + Convert.ToDouble(txtM.Text);
                totalV = totalV * 2.205;
                if (totalV < 1000)
                {
                    v1 = 0.75;
                    v2 = 1.75;
                    v3 = 1.75;
                }
                else if(totalV >= 1000 && totalV < 2000)
                {
                    v1 = 1;
                    v2 = 2;
                    v3 = 2;
                }
                else if (totalV >= 2000 && totalV < 3000)
                {
                    v1 = 1.25;
                    v2 = 2.25;
                    v3 = 2.25;
                }
                else if (totalV >= 3000 && totalV < 3500)
                {
                    v1 = 1.5;
                    v2 = 2.5;
                    v3 = 2.5;
                }
                else if (totalV >= 3500 && totalV < 4000)
                {
                    v1 = 1.75;
                    v2 = 2.75;
                    v3 = 2.75;
                }
                else if (totalV >= 4000 && totalV < 4200)
                {
                    v1 = 2;
                    v2 = 3;
                    v3 = 3;
                }
                else if (totalV >= 4200 && totalV < 4400)
                {
                    v1 = 2;
                    v2 = 3.25;
                    v3 = 3.25;
                }
                else if (totalV >= 4400 && totalV < 4600)
                {
                    v1 = 2;
                    v2 = 3.5;
                    v3 = 3.5;
                }
                else if (totalV >= 4600 && totalV < 4800)
                {
                    v1 = 2.25;
                    v2 = 3.75;
                    v3 = 3.75;
                }
                else if (totalV >= 4800 && totalV < 5000)
                {
                    v1 = 2.25;
                    v2 = 4;
                    v3 = 4;
                }
                else if (totalV >= 5000 && totalV < 5200)
                {
                    v1 = 2.5;
                    v2 = 4.5;
                    v3 = 4.5;
                }
                else if (totalV >= 5200 && totalV < 5400)
                {
                    v1 = 2.5;
                    v2 = 5;
                    v3 = 5;
                }
                else if (totalV >= 5400 && totalV < 5600)
                {
                    v1 = 2.5;
                    v2 = 5.5;
                    v3 = 5.5;
                }
                else if (totalV >= 5600 && totalV < 6200)
                {
                    v1 = 2.75;
                    v2 = 5.5;
                    v3 = 5.5;
                }
                else if (totalV >= 6200 && totalV < 6800)
                {
                    v1 = 3;
                    v2 = 5.5;
                    v3 = 5.5;
                }
                else if (totalV >= 6800 )
                {
                    v1 = 3.25;
                    v2 = 5.5;
                    v3 = 5.5;
                }

                lbVR1.Text = Convert.ToString(v1);
                lbVR2.Text = Convert.ToString(v2);
                lbVR3.Text = Convert.ToString(v2);
                tlpRV.Visible = true;
                lbVMassKg.Visible = true;
                lbVMassLbs.Visible = true;
                lbVMassKg.Text = Convert.ToString(Math.Round(totalV/2.2,1));
                lbVMassLbs.Text = Convert.ToString(Math.Round(totalV,1));

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (txtM.Text == "" || txtM.Text == "0")
            {
                MessageBox.Show("Please enter the weight of the system.", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (lbI1num + lbI2num + lbI3num < 2)
            {
                MessageBox.Show("Please select at least two beams.", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                totalI = (lbI1num * 34 + lbI2num * 42.5 + lbI3num * 50) + 771 + 108 +Convert.ToDouble(txtM.Text);
                totalI = totalI * 2.205;
                if (totalI < 1000)
                {
                    i1 = 0.75;
                    i2 = 1.75;
                    i3 = 1.75;
                }
                else if (totalI >= 1000 && totalI < 2000)
                {
                    i1 = 1;
                    i2 = 2;
                    i3 = 2;
                }
                else if (totalI >= 2000 && totalI < 3000)
                {
                    i1 = 1.25;
                    i2 = 2.25;
                    i3 = 2.25;
                }
                else if (totalI >= 3000 && totalI < 3500)
                {
                    i1 = 1.5;
                    i2 = 2.5;
                    i3 = 2.5;
                }
                else if (totalI >= 3500 && totalI < 4000)
                {
                    i1 = 1.75;
                    i2 = 2.75;
                    i3 = 2.75;
                }
                else if (totalI >= 4000 && totalI < 4200)
                {
                    i1 = 2;
                    i2 = 3;
                    i3 = 3;
                }
                else if (totalI >= 4200 && totalI < 4400)
                {
                    i1 = 2;
                    i2 = 3.25;
                    i3 = 3.25;
                }
                else if (totalI >= 4400 && totalI < 4600)
                {
                    i1 = 2;
                    i2 = 3.5;
                    i3 = 3.5;
                }
                else if (totalI >= 4600 && totalI < 4800)
                {
                    i1 = 2.25;
                    i2 = 3.75;
                    i3 = 3.75;
                }
                else if (totalI >= 4800 && totalI < 5000)
                {
                    i1 = 2.25;
                    i2 = 4;
                    i3 = 4;
                }
                else if (totalI >= 5000 && totalI < 5200)
                {
                    i1 = 2.5;
                    i2 = 4.5;
                    i3 = 4.5;
                }
                else if (totalI >= 5200 && totalI < 5400)
                {
                    i1 = 2.5;
                    i2 = 5;
                    i3 = 5;
                }
                else if (totalI >= 5400 && totalI < 5600)
                {
                    i1 = 2.5;
                    i2 = 5.5;
                    i3 = 5.5;
                }
                else if (totalI >= 5600 && totalI < 6200)
                {
                    i1 = 2.75;
                    i2 = 5.5;
                    i3 = 5.5;
                }
                else if (totalI >= 6200 && totalI < 6800)
                {
                    i1 = 3;
                    i2 = 5.5;
                    i3 = 5.5;
                }
                else if (totalI >= 6800)
                {
                    i1 = 3.25;
                    i2 = 5.5;
                    i3 = 5.5;
                }

                lbIR1.Text = Convert.ToString(i1);
                lbIR2.Text = Convert.ToString(i2);
                lbIR3.Text = Convert.ToString(i2);
                tlpRI.Visible = true;
                lbIMassKg.Visible = true;
                lbIMassLbs.Visible = true;
                lbIMassKg.Text = Convert.ToString(Math.Round(totalI / 2.2, 1));
                lbIMassLbs.Text = Convert.ToString(Math.Round(totalI, 1));
            }

        }

        private void txtM_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46);
            if (txtM.Text.Length == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtM.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (txtM.Text.StartsWith("0") && !txtM.Text.StartsWith("0.") && e.KeyChar != '\b' && e.KeyChar != (int)'.')
            {
                e.Handled = true;
            }
        }
        //sdsds
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtM.Text = "";
            lbV1num = 0;
            lbV2num = 0;
            lbV3num = 0;
            lbI1num = 0;
            lbI2num = 0;
            lbI3num = 0;
            tlpRV.Visible = false;
            tlpRI.Visible = false;
            lbV1.Text = "0";
            lbV2.Text = "0";
            lbV3.Text = "0";
            lbI1.Text = "0";
            lbI2.Text = "0";
            lbI3.Text = "0";
            lbVMassKg.Visible = false;
            lbVMassLbs.Visible = false;
            lbIMassKg.Visible = false;
            lbIMassLbs.Visible = false;
        }
    }
}
