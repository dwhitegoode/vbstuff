namespace TaxApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb_gross = new System.Windows.Forms.TextBox();
            this.tb_net = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_taxes = new System.Windows.Forms.TextBox();
            this.tb_monthly = new System.Windows.Forms.TextBox();
            this.tb_expenses = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.exp_tb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.details_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_gross
            // 
            this.tb_gross.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tb_gross.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_gross.Location = new System.Drawing.Point(119, 37);
            this.tb_gross.Name = "tb_gross";
            this.tb_gross.Size = new System.Drawing.Size(111, 23);
            this.tb_gross.TabIndex = 0;
            this.tb_gross.TextChanged += new System.EventHandler(this.tb_gross_TextChanged);
            // 
            // tb_net
            // 
            this.tb_net.BackColor = System.Drawing.Color.SlateGray;
            this.tb_net.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_net.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_net.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tb_net.Location = new System.Drawing.Point(13, 195);
            this.tb_net.Name = "tb_net";
            this.tb_net.ReadOnly = true;
            this.tb_net.Size = new System.Drawing.Size(217, 16);
            this.tb_net.TabIndex = 1;
            this.tb_net.TabStop = false;
            this.tb_net.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(32, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(20, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gross Pay";
            // 
            // tb_taxes
            // 
            this.tb_taxes.BackColor = System.Drawing.Color.SlateGray;
            this.tb_taxes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_taxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_taxes.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tb_taxes.Location = new System.Drawing.Point(13, 166);
            this.tb_taxes.Name = "tb_taxes";
            this.tb_taxes.ReadOnly = true;
            this.tb_taxes.Size = new System.Drawing.Size(217, 16);
            this.tb_taxes.TabIndex = 5;
            this.tb_taxes.TabStop = false;
            this.tb_taxes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_monthly
            // 
            this.tb_monthly.BackColor = System.Drawing.Color.SlateGray;
            this.tb_monthly.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_monthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_monthly.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tb_monthly.Location = new System.Drawing.Point(13, 224);
            this.tb_monthly.Name = "tb_monthly";
            this.tb_monthly.ReadOnly = true;
            this.tb_monthly.Size = new System.Drawing.Size(217, 16);
            this.tb_monthly.TabIndex = 7;
            this.tb_monthly.TabStop = false;
            this.tb_monthly.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_expenses
            // 
            this.tb_expenses.BackColor = System.Drawing.Color.SlateGray;
            this.tb_expenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_expenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_expenses.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tb_expenses.Location = new System.Drawing.Point(13, 253);
            this.tb_expenses.Name = "tb_expenses";
            this.tb_expenses.ReadOnly = true;
            this.tb_expenses.Size = new System.Drawing.Size(217, 16);
            this.tb_expenses.TabIndex = 9;
            this.tb_expenses.TabStop = false;
            this.tb_expenses.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(124, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(119, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(111, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // exp_tb
            // 
            this.exp_tb.AutoSize = true;
            this.exp_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exp_tb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exp_tb.Location = new System.Drawing.Point(20, 72);
            this.exp_tb.Name = "exp_tb";
            this.exp_tb.Size = new System.Drawing.Size(93, 17);
            this.exp_tb.TabIndex = 13;
            this.exp_tb.Text = "Cost of Living";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.BackgroundImage = global::TaxApp.Properties.Resources._2;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 19);
            this.panel1.TabIndex = 14;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Orange;
            this.pictureBox2.Image = global::TaxApp.Properties.Resources.minimazar;
            this.pictureBox2.Location = new System.Drawing.Point(197, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Image = global::TaxApp.Properties.Resources.cerrar;
            this.pictureBox1.Location = new System.Drawing.Point(218, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 48);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Location = new System.Drawing.Point(13, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 162);
            this.panel2.TabIndex = 15;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.SlateGray;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(-3, -2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(220, 162);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Single",
            "Head of Household",
            "Married filing jointly",
            "Married filing separately"});
            this.comboBox1.Location = new System.Drawing.Point(13, 120);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(13, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Filing Status (default: single)";
            // 
            // details_btn
            // 
            this.details_btn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.details_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.details_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.details_btn.Location = new System.Drawing.Point(157, 120);
            this.details_btn.Name = "details_btn";
            this.details_btn.Size = new System.Drawing.Size(75, 23);
            this.details_btn.TabIndex = 18;
            this.details_btn.Text = "Details";
            this.details_btn.UseVisualStyleBackColor = false;
            this.details_btn.Click += new System.EventHandler(this.details_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(244, 360);
            this.Controls.Add(this.details_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exp_tb);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_gross);
            this.Controls.Add(this.tb_taxes);
            this.Controls.Add(this.tb_net);
            this.Controls.Add(this.tb_monthly);
            this.Controls.Add(this.tb_expenses);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_gross;
        private System.Windows.Forms.TextBox tb_net;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_taxes;
        private System.Windows.Forms.TextBox tb_monthly;
        private System.Windows.Forms.TextBox tb_expenses;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label exp_tb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button details_btn;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

