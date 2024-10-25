namespace AppQLNhaThuoc
{
    partial class Home
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
            this.btnChiNhanh = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnEmploy = new System.Windows.Forms.Button();
            this.btnCate = new System.Windows.Forms.Button();
            this.btnMedi = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.data = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChiNhanh
            // 
            this.btnChiNhanh.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnChiNhanh.ForeColor = System.Drawing.Color.White;
            this.btnChiNhanh.Location = new System.Drawing.Point(11, 21);
            this.btnChiNhanh.Name = "btnChiNhanh";
            this.btnChiNhanh.Size = new System.Drawing.Size(114, 40);
            this.btnChiNhanh.TabIndex = 0;
            this.btnChiNhanh.Text = "Chi nhánh";
            this.btnChiNhanh.UseVisualStyleBackColor = false;
            this.btnChiNhanh.Click += new System.EventHandler(this.btnChiNhanh_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(553, 21);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(114, 40);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "Hóa đơn";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnEmploy
            // 
            this.btnEmploy.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnEmploy.ForeColor = System.Drawing.Color.White;
            this.btnEmploy.Location = new System.Drawing.Point(737, 21);
            this.btnEmploy.Name = "btnEmploy";
            this.btnEmploy.Size = new System.Drawing.Size(114, 40);
            this.btnEmploy.TabIndex = 0;
            this.btnEmploy.Text = "Nhân viên";
            this.btnEmploy.UseVisualStyleBackColor = false;
            this.btnEmploy.Click += new System.EventHandler(this.btnEmploy_Click);
            // 
            // btnCate
            // 
            this.btnCate.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnCate.ForeColor = System.Drawing.Color.White;
            this.btnCate.Location = new System.Drawing.Point(180, 21);
            this.btnCate.Name = "btnCate";
            this.btnCate.Size = new System.Drawing.Size(114, 40);
            this.btnCate.TabIndex = 0;
            this.btnCate.Text = "Danh mục";
            this.btnCate.UseVisualStyleBackColor = false;
            this.btnCate.Click += new System.EventHandler(this.btnCate_Click);
            // 
            // btnMedi
            // 
            this.btnMedi.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnMedi.ForeColor = System.Drawing.Color.White;
            this.btnMedi.Location = new System.Drawing.Point(373, 21);
            this.btnMedi.Name = "btnMedi";
            this.btnMedi.Size = new System.Drawing.Size(114, 40);
            this.btnMedi.TabIndex = 0;
            this.btnMedi.Text = "Thuốc";
            this.btnMedi.UseVisualStyleBackColor = false;
            this.btnMedi.Click += new System.EventHandler(this.btnMedi_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(942, 21);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 40);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEmploy);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnChiNhanh);
            this.groupBox1.Controls.Add(this.btnCate);
            this.groupBox1.Controls.Add(this.btnMedi);
            this.groupBox1.Controls.Add(this.btnOrder);
            this.groupBox1.Location = new System.Drawing.Point(38, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1075, 86);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Option";
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(38, 220);
            this.data.Name = "data";
            this.data.RowHeadersWidth = 51;
            this.data.RowTemplate.Height = 24;
            this.data.Size = new System.Drawing.Size(1075, 446);
            this.data.TabIndex = 2;
            this.data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellContentClick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 678);
            this.Controls.Add(this.data);
            this.Controls.Add(this.groupBox1);
            this.Name = "Home";
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.Home_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChiNhanh;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnEmploy;
        private System.Windows.Forms.Button btnCate;
        private System.Windows.Forms.Button btnMedi;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView data;
    }
}

