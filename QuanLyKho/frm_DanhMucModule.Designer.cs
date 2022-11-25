namespace QuanLyKho
{
    partial class frm_DanhMucModule
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
            this.txtTenDM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaDM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdateDM = new System.Windows.Forms.Button();
            this.btnSaveDM = new System.Windows.Forms.Button();
            this.ckbNCC = new System.Windows.Forms.ComboBox();
            this.txtMaNCCDM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTenDM
            // 
            this.txtTenDM.Location = new System.Drawing.Point(190, 131);
            this.txtTenDM.Name = "txtTenDM";
            this.txtTenDM.Size = new System.Drawing.Size(313, 20);
            this.txtTenDM.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tên danh mục :";
            // 
            // txtMaDM
            // 
            this.txtMaDM.Location = new System.Drawing.Point(190, 88);
            this.txtMaDM.Name = "txtMaDM";
            this.txtMaDM.Size = new System.Drawing.Size(313, 20);
            this.txtMaDM.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mã danh mục :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(186, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm Danh Mục";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 50);
            this.panel1.TabIndex = 25;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(11, 211);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 32);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(431, 211);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 32);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Xóa";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdateDM
            // 
            this.btnUpdateDM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUpdateDM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDM.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDM.Location = new System.Drawing.Point(323, 211);
            this.btnUpdateDM.Name = "btnUpdateDM";
            this.btnUpdateDM.Size = new System.Drawing.Size(96, 32);
            this.btnUpdateDM.TabIndex = 27;
            this.btnUpdateDM.Text = "Cập nhập";
            this.btnUpdateDM.UseVisualStyleBackColor = false;
            this.btnUpdateDM.Click += new System.EventHandler(this.btnUpdateDM_Click);
            // 
            // btnSaveDM
            // 
            this.btnSaveDM.BackColor = System.Drawing.Color.Lime;
            this.btnSaveDM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDM.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDM.Location = new System.Drawing.Point(211, 211);
            this.btnSaveDM.Name = "btnSaveDM";
            this.btnSaveDM.Size = new System.Drawing.Size(96, 32);
            this.btnSaveDM.TabIndex = 26;
            this.btnSaveDM.Text = "Lưu";
            this.btnSaveDM.UseVisualStyleBackColor = false;
            this.btnSaveDM.Click += new System.EventHandler(this.btnSaveDM_Click);
            // 
            // ckbNCC
            // 
            this.ckbNCC.FormattingEnabled = true;
            this.ckbNCC.Location = new System.Drawing.Point(372, 172);
            this.ckbNCC.Name = "ckbNCC";
            this.ckbNCC.Size = new System.Drawing.Size(131, 21);
            this.ckbNCC.TabIndex = 47;
            this.ckbNCC.SelectedValueChanged += new System.EventHandler(this.ckbNCC_SelectedValueChanged);
            // 
            // txtMaNCCDM
            // 
            this.txtMaNCCDM.Location = new System.Drawing.Point(190, 172);
            this.txtMaNCCDM.Name = "txtMaNCCDM";
            this.txtMaNCCDM.Size = new System.Drawing.Size(161, 20);
            this.txtMaNCCDM.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 19);
            this.label7.TabIndex = 45;
            this.label7.Text = "Mã nhà cung cấp :";
            // 
            // frm_DanhMucModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 270);
            this.Controls.Add(this.ckbNCC);
            this.Controls.Add(this.txtMaNCCDM);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdateDM);
            this.Controls.Add(this.btnSaveDM);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTenDM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaDM);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_DanhMucModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_DanhMucModule";
            this.Load += new System.EventHandler(this.frm_DanhMucModule_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtTenDM;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtMaDM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Button btnUpdateDM;
        public System.Windows.Forms.Button btnSaveDM;
        private System.Windows.Forms.ComboBox ckbNCC;
        public System.Windows.Forms.TextBox txtMaNCCDM;
        private System.Windows.Forms.Label label7;
    }
}