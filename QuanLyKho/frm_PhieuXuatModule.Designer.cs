namespace QuanLyKho
{
    partial class frm_PhieuXuatModule
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdatePX = new System.Windows.Forms.Button();
            this.btnSavePX = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbNguoiXuat = new System.Windows.Forms.ComboBox();
            this.txtNguoiXuat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ckbTenSP = new System.Windows.Forms.ComboBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaPX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.datePKPX = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(33, 341);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 32);
            this.btnClose.TabIndex = 60;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(453, 341);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 32);
            this.btnClear.TabIndex = 59;
            this.btnClear.Text = "Xóa";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdatePX
            // 
            this.btnUpdatePX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUpdatePX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatePX.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePX.Location = new System.Drawing.Point(345, 341);
            this.btnUpdatePX.Name = "btnUpdatePX";
            this.btnUpdatePX.Size = new System.Drawing.Size(96, 32);
            this.btnUpdatePX.TabIndex = 58;
            this.btnUpdatePX.Text = "Cập nhập";
            this.btnUpdatePX.UseVisualStyleBackColor = false;
            this.btnUpdatePX.Click += new System.EventHandler(this.btnUpdatePX_Click);
            // 
            // btnSavePX
            // 
            this.btnSavePX.BackColor = System.Drawing.Color.Lime;
            this.btnSavePX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePX.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePX.Location = new System.Drawing.Point(233, 341);
            this.btnSavePX.Name = "btnSavePX";
            this.btnSavePX.Size = new System.Drawing.Size(96, 32);
            this.btnSavePX.TabIndex = 57;
            this.btnSavePX.Text = "Lưu";
            this.btnSavePX.UseVisualStyleBackColor = false;
            this.btnSavePX.Click += new System.EventHandler(this.btnSavePX_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 50);
            this.panel1.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(267, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phiếu Xuất";
            // 
            // ckbNguoiXuat
            // 
            this.ckbNguoiXuat.FormattingEnabled = true;
            this.ckbNguoiXuat.Location = new System.Drawing.Point(387, 297);
            this.ckbNguoiXuat.Name = "ckbNguoiXuat";
            this.ckbNguoiXuat.Size = new System.Drawing.Size(131, 23);
            this.ckbNguoiXuat.TabIndex = 82;
            this.ckbNguoiXuat.SelectedValueChanged += new System.EventHandler(this.ckbNguoiXuat_SelectedValueChanged);
            // 
            // txtNguoiXuat
            // 
            this.txtNguoiXuat.Location = new System.Drawing.Point(205, 297);
            this.txtNguoiXuat.Name = "txtNguoiXuat";
            this.txtNguoiXuat.Size = new System.Drawing.Size(161, 22);
            this.txtNguoiXuat.TabIndex = 81;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 80;
            this.label4.Text = "Người xuất :";
            // 
            // ckbTenSP
            // 
            this.ckbTenSP.FormattingEnabled = true;
            this.ckbTenSP.Location = new System.Drawing.Point(387, 159);
            this.ckbTenSP.Name = "ckbTenSP";
            this.ckbTenSP.Size = new System.Drawing.Size(131, 23);
            this.ckbTenSP.TabIndex = 79;
            this.ckbTenSP.SelectedValueChanged += new System.EventHandler(this.ckbTenSP_SelectedValueChanged);
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(205, 159);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(161, 22);
            this.txtTenSP.TabIndex = 78;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(74, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 19);
            this.label7.TabIndex = 75;
            this.label7.Text = "Tên khách hàng :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(109, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 19);
            this.label6.TabIndex = 73;
            this.label6.Text = "Ngày xuất :";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(205, 207);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(313, 22);
            this.txtSoLuong.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 19);
            this.label5.TabIndex = 71;
            this.label5.Text = "Số lượng xuất :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 19);
            this.label3.TabIndex = 70;
            this.label3.Text = "Tên sản phẩm :";
            // 
            // txtMaPX
            // 
            this.txtMaPX.Location = new System.Drawing.Point(205, 70);
            this.txtMaPX.Name = "txtMaPX";
            this.txtMaPX.Size = new System.Drawing.Size(313, 22);
            this.txtMaPX.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 68;
            this.label2.Text = "Mã phiếu xuất :";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(205, 112);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(313, 22);
            this.txtTenKH.TabIndex = 83;
            // 
            // datePKPX
            // 
            this.datePKPX.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePKPX.Location = new System.Drawing.Point(205, 256);
            this.datePKPX.Name = "datePKPX";
            this.datePKPX.Size = new System.Drawing.Size(313, 22);
            this.datePKPX.TabIndex = 84;
            // 
            // frm_PhieuXuatModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 391);
            this.Controls.Add(this.datePKPX);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.ckbNguoiXuat);
            this.Controls.Add(this.txtNguoiXuat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ckbTenSP);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaPX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdatePX);
            this.Controls.Add(this.btnSavePX);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frm_PhieuXuatModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_PhieuXuatModule";
            this.Load += new System.EventHandler(this.frm_PhieuXuatModule_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Button btnUpdatePX;
        public System.Windows.Forms.Button btnSavePX;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox ckbNguoiXuat;
        public System.Windows.Forms.TextBox txtNguoiXuat;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox ckbTenSP;
        public System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtMaPX;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtTenKH;
        public System.Windows.Forms.DateTimePicker datePKPX;
    }
}