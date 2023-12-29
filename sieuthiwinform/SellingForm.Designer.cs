namespace sieuthiwinform
{
    partial class SellingForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellingForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.billDGV = new System.Windows.Forms.DataGridView();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.inbillbtn = new Guna.UI2.WinForms.Guna2Button();
            this.tongtientb = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.refreshbtn = new Guna.UI2.WinForms.Guna2Button();
            this.nhanvientb = new System.Windows.Forms.Label();
            this.datetb = new System.Windows.Forms.Label();
            this.orderDGV = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanphamDGV = new System.Windows.Forms.DataGridView();
            this.phanloaicb = new System.Windows.Forms.ComboBox();
            this.giatb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.soluongtb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tensptb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanphamDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.billDGV);
            this.panel1.Controls.Add(this.guna2Button2);
            this.panel1.Controls.Add(this.inbillbtn);
            this.panel1.Controls.Add(this.tongtientb);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.refreshbtn);
            this.panel1.Controls.Add(this.nhanvientb);
            this.panel1.Controls.Add(this.datetb);
            this.panel1.Controls.Add(this.orderDGV);
            this.panel1.Controls.Add(this.sanphamDGV);
            this.panel1.Controls.Add(this.phanloaicb);
            this.panel1.Controls.Add(this.giatb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.soluongtb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tensptb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.idtb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1320, 652);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // billDGV
            // 
            this.billDGV.BackgroundColor = System.Drawing.Color.White;
            this.billDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billDGV.Location = new System.Drawing.Point(553, 445);
            this.billDGV.Name = "billDGV";
            this.billDGV.RowHeadersWidth = 51;
            this.billDGV.RowTemplate.Height = 29;
            this.billDGV.Size = new System.Drawing.Size(758, 155);
            this.billDGV.TabIndex = 29;
            this.billDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.billDGV_CellClick);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.White;
            this.guna2Button2.BorderRadius = 10;
            this.guna2Button2.CustomizableEdges = customizableEdges1;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.White;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2Button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Button2.Location = new System.Drawing.Point(619, 399);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.guna2Button2.Size = new System.Drawing.Size(152, 40);
            this.guna2Button2.TabIndex = 28;
            this.guna2Button2.Text = "add";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // inbillbtn
            // 
            this.inbillbtn.BackColor = System.Drawing.Color.White;
            this.inbillbtn.BorderRadius = 10;
            this.inbillbtn.CustomizableEdges = customizableEdges3;
            this.inbillbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.inbillbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.inbillbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.inbillbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.inbillbtn.FillColor = System.Drawing.Color.White;
            this.inbillbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inbillbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inbillbtn.Location = new System.Drawing.Point(865, 399);
            this.inbillbtn.Name = "inbillbtn";
            this.inbillbtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            this.inbillbtn.Size = new System.Drawing.Size(152, 40);
            this.inbillbtn.TabIndex = 27;
            this.inbillbtn.Text = "In hóa đơn";
            this.inbillbtn.Click += new System.EventHandler(this.inbillbtn_Click);
            // 
            // tongtientb
            // 
            this.tongtientb.AutoSize = true;
            this.tongtientb.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tongtientb.ForeColor = System.Drawing.Color.White;
            this.tongtientb.Location = new System.Drawing.Point(851, 603);
            this.tongtientb.Name = "tongtientb";
            this.tongtientb.Size = new System.Drawing.Size(86, 41);
            this.tongtientb.TabIndex = 25;
            this.tongtientb.Text = "1000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(685, 603);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 41);
            this.label6.TabIndex = 23;
            this.label6.Text = "Tổng Tiền :";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.White;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.CustomizableEdges = customizableEdges5;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Button1.Location = new System.Drawing.Point(206, 213);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            this.guna2Button1.Size = new System.Drawing.Size(152, 40);
            this.guna2Button1.TabIndex = 24;
            this.guna2Button1.Text = "Thêm mới";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // refreshbtn
            // 
            this.refreshbtn.BackColor = System.Drawing.Color.White;
            this.refreshbtn.BorderRadius = 10;
            this.refreshbtn.CustomizableEdges = customizableEdges7;
            this.refreshbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.refreshbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.refreshbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.refreshbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.refreshbtn.FillColor = System.Drawing.Color.White;
            this.refreshbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.refreshbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.refreshbtn.Location = new System.Drawing.Point(311, 259);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.ShadowDecoration.CustomizableEdges = customizableEdges8;
            this.refreshbtn.Size = new System.Drawing.Size(177, 40);
            this.refreshbtn.TabIndex = 23;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // nhanvientb
            // 
            this.nhanvientb.AutoSize = true;
            this.nhanvientb.ForeColor = System.Drawing.Color.White;
            this.nhanvientb.Location = new System.Drawing.Point(32, 11);
            this.nhanvientb.Name = "nhanvientb";
            this.nhanvientb.Size = new System.Drawing.Size(75, 20);
            this.nhanvientb.TabIndex = 22;
            this.nhanvientb.Text = "Nhan vien";
            // 
            // datetb
            // 
            this.datetb.AutoSize = true;
            this.datetb.ForeColor = System.Drawing.Color.White;
            this.datetb.Location = new System.Drawing.Point(1183, 11);
            this.datetb.Name = "datetb";
            this.datetb.Size = new System.Drawing.Size(41, 20);
            this.datetb.TabIndex = 21;
            this.datetb.Text = "Date";
            // 
            // orderDGV
            // 
            this.orderDGV.BackgroundColor = System.Drawing.Color.White;
            this.orderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.tensp,
            this.gia,
            this.soluong,
            this.tongtien});
            this.orderDGV.Location = new System.Drawing.Point(553, 73);
            this.orderDGV.Name = "orderDGV";
            this.orderDGV.RowHeadersWidth = 51;
            this.orderDGV.RowTemplate.Height = 29;
            this.orderDGV.Size = new System.Drawing.Size(758, 320);
            this.orderDGV.TabIndex = 20;
            // 
            // Id
            // 
            this.Id.HeaderText = "prodid";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // tensp
            // 
            this.tensp.HeaderText = "tên sản phẩm";
            this.tensp.MinimumWidth = 6;
            this.tensp.Name = "tensp";
            this.tensp.Width = 125;
            // 
            // gia
            // 
            this.gia.HeaderText = "Giá";
            this.gia.MinimumWidth = 6;
            this.gia.Name = "gia";
            this.gia.Width = 125;
            // 
            // soluong
            // 
            this.soluong.HeaderText = "Số Lượng";
            this.soluong.MinimumWidth = 6;
            this.soluong.Name = "soluong";
            this.soluong.Width = 125;
            // 
            // tongtien
            // 
            this.tongtien.HeaderText = "Tổng";
            this.tongtien.MinimumWidth = 6;
            this.tongtien.Name = "tongtien";
            this.tongtien.Width = 125;
            // 
            // sanphamDGV
            // 
            this.sanphamDGV.BackgroundColor = System.Drawing.Color.White;
            this.sanphamDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sanphamDGV.Location = new System.Drawing.Point(14, 306);
            this.sanphamDGV.Name = "sanphamDGV";
            this.sanphamDGV.RowHeadersWidth = 51;
            this.sanphamDGV.RowTemplate.Height = 29;
            this.sanphamDGV.Size = new System.Drawing.Size(473, 338);
            this.sanphamDGV.TabIndex = 17;
            this.sanphamDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sanphamDGV_CellClick);
            // 
            // phanloaicb
            // 
            this.phanloaicb.FormattingEnabled = true;
            this.phanloaicb.Items.AddRange(new object[] {
            "Nhan Vien",
            "Quan ly"});
            this.phanloaicb.Location = new System.Drawing.Point(32, 271);
            this.phanloaicb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phanloaicb.Name = "phanloaicb";
            this.phanloaicb.Size = new System.Drawing.Size(273, 28);
            this.phanloaicb.TabIndex = 12;
            this.phanloaicb.Text = "Chọn ";
            this.phanloaicb.SelectionChangeCommitted += new System.EventHandler(this.phanloaicb_SelectionChangeCommitted);
            // 
            // giatb
            // 
            this.giatb.Location = new System.Drawing.Point(144, 172);
            this.giatb.Name = "giatb";
            this.giatb.Size = new System.Drawing.Size(343, 27);
            this.giatb.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(32, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Giá";
            // 
            // soluongtb
            // 
            this.soluongtb.Location = new System.Drawing.Point(144, 139);
            this.soluongtb.Name = "soluongtb";
            this.soluongtb.Size = new System.Drawing.Size(343, 27);
            this.soluongtb.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Số Lượng";
            // 
            // tensptb
            // 
            this.tensptb.Location = new System.Drawing.Point(144, 106);
            this.tensptb.Name = "tensptb";
            this.tensptb.Size = new System.Drawing.Size(343, 27);
            this.tensptb.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên sản phẩm";
            // 
            // idtb
            // 
            this.idtb.Location = new System.Drawing.Point(144, 73);
            this.idtb.Name = "idtb";
            this.idtb.Size = new System.Drawing.Size(343, 27);
            this.idtb.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(515, -5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 41);
            this.label5.TabIndex = 9;
            this.label5.Text = "Siêu thị minh cầu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(1275, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "X";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(19, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Logout";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 695);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanphamDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private DataGridView orderDGV;
        private DataGridView sanphamDGV;
        private ComboBox phanloaicb;
        private TextBox giatb;
        private Label label4;
        private TextBox soluongtb;
        private Label label3;
        private TextBox tensptb;
        private Label label2;
        private TextBox idtb;
        private Label label1;
        private Label datetb;
        private Label label5;
        private Label label8;
        private Label tongtientb;
        private Label label6;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button refreshbtn;
        private Label nhanvientb;
        private Guna.UI2.WinForms.Guna2Button inbillbtn;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn tensp;
        private DataGridViewTextBoxColumn gia;
        private DataGridViewTextBoxColumn soluong;
        private DataGridViewTextBoxColumn tongtien;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private DataGridView billDGV;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Label label7;
    }
}