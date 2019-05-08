using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TaxApp
{
    public partial class Form1 : Form
    {
        public static double totalFedTaxes = 0;
        public static double totalStateTaxes = 0;
        public static double netIncome = 0;
        public static double allTaxes = 0;
        public static double monthly = 0;
        public static double exp = 0;
        public static double income;
        public static double pay;
        public static double deduction = 0;
        public static int hidden = 0;
        //public static double gross;
        public static double ss;
        public bool isPressed = false;

        //public Form1()
        //{
        //    InitializeComponent();
        //}

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        public void runner()
        {
            isPressed = true;
            if (comboBox1.Text == "Single" || comboBox1.Text == "Married filing separately" || comboBox1.Text == "")
            {
                deduction = 12000;
            }
            else if (comboBox1.Text == "Head of Household")
            {
                deduction = 18000;
            }
            else if (comboBox1.Text == "Married filing jointly")
            {
                deduction = 24000;
            }
            

            try
            {
                pay = Double.Parse(tb_gross.Text);
                income = pay - deduction;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                pay = 0;
                income = 0;
                //button1.Enabled = true;
            }


            double dub = Resource.difference1(Resource.difference(income, comboBox1.Text), comboBox1.Text);
            double dub1 = Resource.difference2(Resource.difference1(Resource.difference(income, comboBox1.Text), comboBox1.Text), comboBox1.Text);
            double dub2 = Resource.difference3(Resource.difference2(Resource.difference1(Resource.difference(income, comboBox1.Text), comboBox1.Text), comboBox1.Text), comboBox1.Text);

            double[] fedBracket = new double[5];
            fedBracket[0] = Resource.brackets0(income, comboBox1.Text);
            fedBracket[1] = Resource.brackets1(Resource.difference(income, comboBox1.Text), comboBox1.Text);
            fedBracket[2] = Resource.brackets2(dub, comboBox1.Text);
            fedBracket[3] = Resource.brackets3(dub1, comboBox1.Text);
            fedBracket[4] = Resource.brackets4(dub2, comboBox1.Text);

            string[] fp = new string[6];
            fp[0] = "10%";
            fp[1] = "12%";
            fp[2] = "22%";
            fp[3] = "24%";
            fp[4] = "32%";

            int fcount = 0;
            foreach (double d in fedBracket)
            {
                if (d != 0)
                {
                    richTextBox1.Text += Environment.NewLine + "Fed Brackets " + String.Format("{0:n}", d) + " at " + fp[fcount];


                }
                fcount++;
            }
            richTextBox1.Text += Environment.NewLine + "----------------------";

            //String.Format("{0:n}",netIncome)

            double[] fedTaxes = new double[5];
            fedTaxes[0] = FedTaxesResources.tax0(fedBracket[0]);
            fedTaxes[1] = FedTaxesResources.tax1(fedBracket[1]);
            fedTaxes[2] = FedTaxesResources.tax2(fedBracket[2]);

            foreach (double d in fedTaxes)
            {
                totalFedTaxes += d;
            }

            double dbw = STR.stateDifference3(
                STR.stateDifference2(STR.stateDifference1(STR.stateDifference1(STR.stateDifference(pay)))));

            double[] stateBracket = new double[6];
            stateBracket[0] = STR.stateBrackets0(pay);
            stateBracket[1] = STR.stateBrackets1(STR.stateDifference(pay));
            stateBracket[2] = STR.stateBrackets2(STR.stateDifference1(STR.stateDifference(pay)));
            stateBracket[3] = STR.stateBrackets3(STR.stateDifference2(STR.stateDifference1(STR.stateDifference(pay))));
            stateBracket[4] = STR.stateBrackets4(STR.stateDifference3(
                    STR.stateDifference2(STR.stateDifference1(STR.stateDifference1(STR.stateDifference(pay))))));
            stateBracket[5] = STR.stateBrackets5(STR.stateDifference4(dbw));

            int scount = 0;
            string[] sp = new string[6];
            sp[0] = "4%";
            sp[1] = "4.5%";
            sp[2] = "5.25%";
            sp[3] = "5.9%";
            sp[4] = "6.33%";
            sp[5] = "6.57%";
            foreach (double d in stateBracket)
            {
                //Console.WriteLine("State Brackets " + d + " at " + sp[scount]);
                if (d != 0)
                {
                    richTextBox1.Text += Environment.NewLine + "State Brackets " + String.Format("{0:n}", d) + " at " + sp[scount];

                }
                scount++;

            }

            double[] stateTaxes = new double[6];
            stateTaxes[0] = StateTaxResource.tax0(stateBracket[0]);
            stateTaxes[1] = StateTaxResource.tax1(stateBracket[1]);
            stateTaxes[2] = StateTaxResource.tax2(stateBracket[2]);
            stateTaxes[3] = StateTaxResource.tax3(stateBracket[3]);
            stateTaxes[4] = StateTaxResource.tax4(stateBracket[4]);
            stateTaxes[5] = StateTaxResource.tax5(stateBracket[5]);

            foreach (double d in stateTaxes)
            {
                totalStateTaxes += d;
            }

            ss = 0.062 * pay;

            netIncome = pay - totalStateTaxes - totalFedTaxes - ss;
            allTaxes = totalStateTaxes + totalFedTaxes + ss;
            monthly = netIncome / 12;

            try
            {
                exp = netIncome - Double.Parse(textBox1.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Source);
                exp = netIncome;
            }
            tb_taxes.Text = "Tax & Social Security: $" + String.Format("{0:n}", allTaxes);
            tb_net.Text = "Net Income: $" + String.Format("{0:n}", netIncome);
            tb_monthly.Text = "Earned Monthly: $" + String.Format("{0:n}", monthly);
            tb_expenses.Text = "You Keep Annually: $" + String.Format("{0:n}", exp);
            button1.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            netIncome = 0;
            ss = 0;
            allTaxes = 0;
            monthly = 0;
            exp = 0;
            totalFedTaxes = 0;
            totalStateTaxes = 0;
            //tb_gross.Text = "";
            //textBox1.Text = "";
            tb_taxes.Text = "";
            tb_net.Text = "";
            tb_monthly.Text = "";
            tb_expenses.Text = "";
            richTextBox1.Text = "";
            runner();
        }
        //protected override void OnPaintBackground(PaintEventArgs e)
        //{
        //    var sb = new SolidBrush(Color.FromArgb(100, 100, 100, 100));
        //    e.Graphics.FillRectangle(sb, this.DisplayRectangle);
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }
        public void clear()
        {
            netIncome = 0;
            ss = 0;
            allTaxes = 0;
            monthly = 0;
            exp = 0;
            totalFedTaxes = 0;
            totalStateTaxes = 0;
            tb_gross.Text = "";
            textBox1.Text = "";
            tb_taxes.Text = "";
            tb_net.Text = "";
            tb_monthly.Text = "";
            tb_expenses.Text = "";
            richTextBox1.Text = "";
            richTextBox1.Visible = false;
            tb_taxes.Visible = true;
            tb_net.Visible = true;
            tb_monthly.Visible = true;
            tb_expenses.Visible = true;
            button1.Enabled = true;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            //this.Close();
            notifyIcon1.Visible = true;
            this.Hide();
            notifyIcon1.Icon = Properties.Resources.iconfinder_21_1933179;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = "Minimized to system tray. Right click to reopen or exit application.";
            
            notifyIcon1.ShowBalloonTip(2000);
            //e.Cancel = true;

        }
       
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                
            }
        }
               
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void details_btn_Click(object sender, EventArgs e)
        {
            hidden++;
            //hidden_lbl.Text += 1;

            if (hidden % 2 == 0)
            {
                richTextBox1.Visible = false;
                tb_taxes.Visible = true;
                tb_net.Visible = true;
                tb_monthly.Visible = true;
                tb_expenses.Visible = true;
            }
            else
            {
                richTextBox1.Visible = true;
                tb_taxes.Visible = false;
                tb_net.Visible = false;
                tb_monthly.Visible = false;
                tb_expenses.Visible = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void tb_gross_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }
    }
}
