namespace AppQLNhaThuoc
{
    partial class Option
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaT = new System.Windows.Forms.TextBox();
            this.btnCloseOp = new System.Windows.Forms.Button();
            this.delThuoc = new System.Windows.Forms.Button();
            this.updateThuoc = new System.Windows.Forms.Button();
            this.addThuoc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblHSD = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataOption = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOption)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(8, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "HSD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(8, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên thuốc";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaT);
            this.groupBox2.Controls.Add(this.btnCloseOp);
            this.groupBox2.Controls.Add(this.delThuoc);
            this.groupBox2.Controls.Add(this.updateThuoc);
            this.groupBox2.Controls.Add(this.addThuoc);
            this.groupBox2.Location = new System.Drawing.Point(569, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(228, 437);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // txtMaT
            // 
            this.txtMaT.Location = new System.Drawing.Point(58, 313);
            this.txtMaT.Name = "txtMaT";
            this.txtMaT.Size = new System.Drawing.Size(135, 22);
            this.txtMaT.TabIndex = 17;
            // 
            // btnCloseOp
            // 
            this.btnCloseOp.BackColor = System.Drawing.Color.Red;
            this.btnCloseOp.ForeColor = System.Drawing.Color.White;
            this.btnCloseOp.Location = new System.Drawing.Point(55, 378);
            this.btnCloseOp.Name = "btnCloseOp";
            this.btnCloseOp.Size = new System.Drawing.Size(122, 30);
            this.btnCloseOp.TabIndex = 14;
            this.btnCloseOp.Text = "Đóng";
            this.btnCloseOp.UseVisualStyleBackColor = false;
            this.btnCloseOp.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // delThuoc
            // 
            this.delThuoc.BackColor = System.Drawing.Color.OliveDrab;
            this.delThuoc.ForeColor = System.Drawing.Color.White;
            this.delThuoc.Location = new System.Drawing.Point(55, 217);
            this.delThuoc.Name = "delThuoc";
            this.delThuoc.Size = new System.Drawing.Size(122, 30);
            this.delThuoc.TabIndex = 14;
            this.delThuoc.Text = "Xóa";
            this.delThuoc.UseVisualStyleBackColor = false;
            // 
            // updateThuoc
            // 
            this.updateThuoc.BackColor = System.Drawing.Color.OliveDrab;
            this.updateThuoc.ForeColor = System.Drawing.Color.White;
            this.updateThuoc.Location = new System.Drawing.Point(55, 181);
            this.updateThuoc.Name = "updateThuoc";
            this.updateThuoc.Size = new System.Drawing.Size(122, 30);
            this.updateThuoc.TabIndex = 15;
            this.updateThuoc.Text = "Sửa";
            this.updateThuoc.UseVisualStyleBackColor = false;
            // 
            // addThuoc
            // 
            this.addThuoc.BackColor = System.Drawing.Color.OliveDrab;
            this.addThuoc.ForeColor = System.Drawing.Color.White;
            this.addThuoc.Location = new System.Drawing.Point(55, 145);
            this.addThuoc.Name = "addThuoc";
            this.addThuoc.Size = new System.Drawing.Size(122, 30);
            this.addThuoc.TabIndex = 16;
            this.addThuoc.Text = "Thêm";
            this.addThuoc.UseVisualStyleBackColor = false;
            this.addThuoc.Click += new System.EventHandler(this.addThuoc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gía";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(708, 498);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 4;
            this.txtId.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblHSD);
            this.groupBox1.Controls.Add(this.lblGia);
            this.groupBox1.Controls.Add(this.lblTen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(551, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn hàng";
            // 
            // lblHSD
            // 
            this.lblHSD.AutoSize = true;
            this.lblHSD.Location = new System.Drawing.Point(191, 135);
            this.lblHSD.Name = "lblHSD";
            this.lblHSD.Size = new System.Drawing.Size(36, 16);
            this.lblHSD.TabIndex = 25;
            this.lblHSD.Text = "HSD";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(191, 92);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(28, 16);
            this.lblGia.TabIndex = 25;
            this.lblGia.Text = "Gía";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(191, 44);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(66, 16);
            this.lblTen.TabIndex = 25;
            this.lblTen.Text = "Tên thuốc";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 187);
            this.panel1.TabIndex = 3;
            // 
            // dataOption
            // 
            this.dataOption.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOption.Location = new System.Drawing.Point(3, 195);
            this.dataOption.Name = "dataOption";
            this.dataOption.RowHeadersWidth = 51;
            this.dataOption.RowTemplate.Height = 24;
            this.dataOption.Size = new System.Drawing.Size(559, 253);
            this.dataOption.TabIndex = 6;
            this.dataOption.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataOption_CellContentClick);
            // 
            // Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataOption);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.panel1);
            this.Name = "Option";
            this.Text = "Option";
            this.Load += new System.EventHandler(this.Option_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataOption)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataOption;
        private System.Windows.Forms.Button delThuoc;
        private System.Windows.Forms.Button updateThuoc;
        private System.Windows.Forms.Button addThuoc;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblHSD;
        private System.Windows.Forms.Button btnCloseOp;
        private System.Windows.Forms.TextBox txtMaT;
    }
}