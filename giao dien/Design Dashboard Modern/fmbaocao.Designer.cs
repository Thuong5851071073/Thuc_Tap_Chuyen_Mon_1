namespace Design_Dashboard_Modern
{
    partial class fmbaocao
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.charttheongaythang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtmanguoidug = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btxuathoadon = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toingay = new System.Windows.Forms.DateTimePicker();
            this.tungay = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charttheongaythang)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.charttheongaythang);
            this.panel1.Location = new System.Drawing.Point(29, 296);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 464);
            this.panel1.TabIndex = 0;
            // 
            // charttheongaythang
            // 
            chartArea1.Name = "ChartArea1";
            this.charttheongaythang.ChartAreas.Add(chartArea1);
            this.charttheongaythang.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.charttheongaythang.Legends.Add(legend1);
            this.charttheongaythang.Location = new System.Drawing.Point(0, 0);
            this.charttheongaythang.Name = "charttheongaythang";
            series1.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series1.BorderColor = System.Drawing.Color.Yellow;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series1.Legend = "Legend1";
            series1.Name = "Doanhthutheothang";
            this.charttheongaythang.Series.Add(series1);
            this.charttheongaythang.Size = new System.Drawing.Size(762, 464);
            this.charttheongaythang.TabIndex = 0;
            this.charttheongaythang.Text = "chart1";
            this.charttheongaythang.Click += new System.EventHandler(this.charttheongaythang_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.txtmanguoidug);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btxuathoadon);
            this.panel3.Controls.Add(this.bunifuFlatButton3);
            this.panel3.Controls.Add(this.bunifuFlatButton1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.toingay);
            this.panel3.Controls.Add(this.tungay);
            this.panel3.Location = new System.Drawing.Point(29, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1394, 255);
            this.panel3.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Yellow;
            this.panel7.Location = new System.Drawing.Point(893, 67);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(356, 1);
            this.panel7.TabIndex = 12;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Yellow;
            this.panel6.Location = new System.Drawing.Point(463, 67);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(356, 1);
            this.panel6.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Location = new System.Drawing.Point(65, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 1);
            this.panel2.TabIndex = 10;
            // 
            // txtmanguoidug
            // 
            this.txtmanguoidug.Location = new System.Drawing.Point(1057, 35);
            this.txtmanguoidug.Name = "txtmanguoidug";
            this.txtmanguoidug.Size = new System.Drawing.Size(192, 22);
            this.txtmanguoidug.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(908, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mã Nhân viên";
            // 
            // btxuathoadon
            // 
            this.btxuathoadon.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btxuathoadon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btxuathoadon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btxuathoadon.BorderRadius = 0;
            this.btxuathoadon.ButtonText = "In Ra Phiếu Hóa Đơn";
            this.btxuathoadon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btxuathoadon.DisabledColor = System.Drawing.Color.Gray;
            this.btxuathoadon.Iconcolor = System.Drawing.Color.Transparent;
            this.btxuathoadon.Iconimage = global::Design_Dashboard_Modern.Properties.Resources.print_48px;
            this.btxuathoadon.Iconimage_right = null;
            this.btxuathoadon.Iconimage_right_Selected = null;
            this.btxuathoadon.Iconimage_Selected = null;
            this.btxuathoadon.IconMarginLeft = 0;
            this.btxuathoadon.IconMarginRight = 0;
            this.btxuathoadon.IconRightVisible = true;
            this.btxuathoadon.IconRightZoom = 0D;
            this.btxuathoadon.IconVisible = true;
            this.btxuathoadon.IconZoom = 90D;
            this.btxuathoadon.IsTab = false;
            this.btxuathoadon.Location = new System.Drawing.Point(553, 103);
            this.btxuathoadon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btxuathoadon.Name = "btxuathoadon";
            this.btxuathoadon.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btxuathoadon.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btxuathoadon.OnHoverTextColor = System.Drawing.Color.White;
            this.btxuathoadon.selected = false;
            this.btxuathoadon.Size = new System.Drawing.Size(266, 67);
            this.btxuathoadon.TabIndex = 7;
            this.btxuathoadon.Text = "In Ra Phiếu Hóa Đơn";
            this.btxuathoadon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btxuathoadon.Textcolor = System.Drawing.Color.Yellow;
            this.btxuathoadon.TextFont = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxuathoadon.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Thống Kê Tổng Tiền Phải Trả";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = global::Design_Dashboard_Modern.Properties.Resources.fund_accounting_48px1;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(76, 169);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(266, 67);
            this.bunifuFlatButton3.TabIndex = 6;
            this.bunifuFlatButton3.Text = "Thống Kê Tổng Tiền Phải Trả";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.Yellow;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Thống Kê Doanh Thu Bán ";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::Design_Dashboard_Modern.Properties.Resources.combo_chart_48px1;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(76, 94);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(266, 67);
            this.bunifuFlatButton1.TabIndex = 4;
            this.bunifuFlatButton1.Text = "Thống Kê Doanh Thu Bán ";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Yellow;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(471, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Từ Ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(72, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Từ Ngày:";
            // 
            // toingay
            // 
            this.toingay.Location = new System.Drawing.Point(553, 39);
            this.toingay.Name = "toingay";
            this.toingay.Size = new System.Drawing.Size(249, 22);
            this.toingay.TabIndex = 1;
            // 
            // tungay
            // 
            this.tungay.Location = new System.Drawing.Point(171, 39);
            this.tungay.Name = "tungay";
            this.tungay.Size = new System.Drawing.Size(250, 22);
            this.tungay.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Yellow;
            this.panel4.Location = new System.Drawing.Point(29, 289);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1394, 1);
            this.panel4.TabIndex = 4;
            // 
            // fmbaocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "fmbaocao";
            this.Size = new System.Drawing.Size(1467, 918);
            this.Load += new System.EventHandler(this.fmbaocao_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.charttheongaythang)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart charttheongaythang;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker toingay;
        private System.Windows.Forms.DateTimePicker tungay;
        private Bunifu.Framework.UI.BunifuFlatButton btxuathoadon;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtmanguoidug;
        private System.Windows.Forms.Label label3;
    }
}
