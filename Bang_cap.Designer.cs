namespace PTUD_với_CSDL
{
    partial class Bang_cap
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
            this.btn_Sua1 = new System.Windows.Forms.Button();
            this.btn_Xoa1 = new System.Windows.Forms.Button();
            this.btn_Them1 = new System.Windows.Forms.Button();
            this.DGV_BangCap = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_TBC = new System.Windows.Forms.TextBox();
            this.txt_MBC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Sua2 = new System.Windows.Forms.Button();
            this.btn_Xoa2 = new System.Windows.Forms.Button();
            this.btn_Them2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbb_XL = new System.Windows.Forms.ComboBox();
            this.cbb_MBC = new System.Windows.Forms.ComboBox();
            this.txt_MNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DGV_NhanVien = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_BangCap)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_NhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Sua1
            // 
            this.btn_Sua1.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.btn_Sua1.Location = new System.Drawing.Point(227, 322);
            this.btn_Sua1.Name = "btn_Sua1";
            this.btn_Sua1.Size = new System.Drawing.Size(130, 50);
            this.btn_Sua1.TabIndex = 13;
            this.btn_Sua1.Text = "Sửa";
            this.btn_Sua1.UseVisualStyleBackColor = true;
            this.btn_Sua1.Click += new System.EventHandler(this.btn_Sua1_Click);
            // 
            // btn_Xoa1
            // 
            this.btn_Xoa1.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.btn_Xoa1.Location = new System.Drawing.Point(415, 322);
            this.btn_Xoa1.Name = "btn_Xoa1";
            this.btn_Xoa1.Size = new System.Drawing.Size(130, 50);
            this.btn_Xoa1.TabIndex = 12;
            this.btn_Xoa1.Text = "Xóa";
            this.btn_Xoa1.UseVisualStyleBackColor = true;
            this.btn_Xoa1.Click += new System.EventHandler(this.btn_Xoa1_Click);
            // 
            // btn_Them1
            // 
            this.btn_Them1.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.btn_Them1.Location = new System.Drawing.Point(43, 322);
            this.btn_Them1.Name = "btn_Them1";
            this.btn_Them1.Size = new System.Drawing.Size(130, 50);
            this.btn_Them1.TabIndex = 11;
            this.btn_Them1.Text = "Thêm";
            this.btn_Them1.UseVisualStyleBackColor = true;
            this.btn_Them1.Click += new System.EventHandler(this.btn_Them1_Click);
            // 
            // DGV_BangCap
            // 
            this.DGV_BangCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_BangCap.Location = new System.Drawing.Point(43, 411);
            this.DGV_BangCap.Name = "DGV_BangCap";
            this.DGV_BangCap.RowHeadersWidth = 62;
            this.DGV_BangCap.RowTemplate.Height = 28;
            this.DGV_BangCap.Size = new System.Drawing.Size(502, 300);
            this.DGV_BangCap.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_TBC);
            this.groupBox1.Controls.Add(this.txt_MBC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(43, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 250);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bằng cấp";
            // 
            // txt_TBC
            // 
            this.txt_TBC.Location = new System.Drawing.Point(193, 136);
            this.txt_TBC.Name = "txt_TBC";
            this.txt_TBC.Size = new System.Drawing.Size(269, 33);
            this.txt_TBC.TabIndex = 6;
            // 
            // txt_MBC
            // 
            this.txt_MBC.Location = new System.Drawing.Point(193, 61);
            this.txt_MBC.Name = "txt_MBC";
            this.txt_MBC.Size = new System.Drawing.Size(178, 33);
            this.txt_MBC.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên bằng cấp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã bằng cấp:";
            // 
            // btn_Sua2
            // 
            this.btn_Sua2.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.btn_Sua2.Location = new System.Drawing.Point(811, 322);
            this.btn_Sua2.Name = "btn_Sua2";
            this.btn_Sua2.Size = new System.Drawing.Size(130, 50);
            this.btn_Sua2.TabIndex = 18;
            this.btn_Sua2.Text = "Sửa";
            this.btn_Sua2.UseVisualStyleBackColor = true;
            this.btn_Sua2.Click += new System.EventHandler(this.btn_Sua2_Click);
            // 
            // btn_Xoa2
            // 
            this.btn_Xoa2.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.btn_Xoa2.Location = new System.Drawing.Point(997, 322);
            this.btn_Xoa2.Name = "btn_Xoa2";
            this.btn_Xoa2.Size = new System.Drawing.Size(130, 50);
            this.btn_Xoa2.TabIndex = 17;
            this.btn_Xoa2.Text = "Xóa";
            this.btn_Xoa2.UseVisualStyleBackColor = true;
            this.btn_Xoa2.Click += new System.EventHandler(this.btn_Xoa2_Click);
            // 
            // btn_Them2
            // 
            this.btn_Them2.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.btn_Them2.Location = new System.Drawing.Point(627, 322);
            this.btn_Them2.Name = "btn_Them2";
            this.btn_Them2.Size = new System.Drawing.Size(130, 50);
            this.btn_Them2.TabIndex = 16;
            this.btn_Them2.Text = "Thêm";
            this.btn_Them2.UseVisualStyleBackColor = true;
            this.btn_Them2.Click += new System.EventHandler(this.btn_Them2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbb_XL);
            this.groupBox2.Controls.Add(this.cbb_MBC);
            this.groupBox2.Controls.Add(this.txt_MNV);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(627, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 250);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhân viên";
            // 
            // cbb_XL
            // 
            this.cbb_XL.FormattingEnabled = true;
            this.cbb_XL.Location = new System.Drawing.Point(196, 177);
            this.cbb_XL.Name = "cbb_XL";
            this.cbb_XL.Size = new System.Drawing.Size(178, 33);
            this.cbb_XL.TabIndex = 9;
            // 
            // cbb_MBC
            // 
            this.cbb_MBC.FormattingEnabled = true;
            this.cbb_MBC.Location = new System.Drawing.Point(196, 113);
            this.cbb_MBC.Name = "cbb_MBC";
            this.cbb_MBC.Size = new System.Drawing.Size(250, 33);
            this.cbb_MBC.TabIndex = 8;
            // 
            // txt_MNV
            // 
            this.txt_MNV.Location = new System.Drawing.Point(196, 48);
            this.txt_MNV.Name = "txt_MNV";
            this.txt_MNV.Size = new System.Drawing.Size(178, 33);
            this.txt_MNV.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Xếp loại: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mã bằng cấp:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã nhân viên:";
            // 
            // DGV_NhanVien
            // 
            this.DGV_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_NhanVien.Location = new System.Drawing.Point(627, 411);
            this.DGV_NhanVien.Name = "DGV_NhanVien";
            this.DGV_NhanVien.RowHeadersWidth = 62;
            this.DGV_NhanVien.RowTemplate.Height = 28;
            this.DGV_NhanVien.Size = new System.Drawing.Size(500, 299);
            this.DGV_NhanVien.TabIndex = 19;
            // 
            // Bang_cap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.DGV_NhanVien);
            this.Controls.Add(this.btn_Sua2);
            this.Controls.Add(this.btn_Xoa2);
            this.Controls.Add(this.btn_Them2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_Sua1);
            this.Controls.Add(this.btn_Xoa1);
            this.Controls.Add(this.btn_Them1);
            this.Controls.Add(this.DGV_BangCap);
            this.Controls.Add(this.groupBox1);
            this.Name = "Bang_cap";
            this.Text = "Bang_cap";
            this.Load += new System.EventHandler(this.Bang_cap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_BangCap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_NhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Sua1;
        private System.Windows.Forms.Button btn_Xoa1;
        private System.Windows.Forms.Button btn_Them1;
        private System.Windows.Forms.DataGridView DGV_BangCap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_TBC;
        private System.Windows.Forms.TextBox txt_MBC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Sua2;
        private System.Windows.Forms.Button btn_Xoa2;
        private System.Windows.Forms.Button btn_Them2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_MNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView DGV_NhanVien;
        private System.Windows.Forms.ComboBox cbb_MBC;
        private System.Windows.Forms.ComboBox cbb_XL;
    }
}