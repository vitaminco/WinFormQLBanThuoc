namespace AppQLNhaThuoc
{
    partial class Warehouse
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataWare = new System.Windows.Forms.DataGridView();
            this.Option = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.delCate = new System.Windows.Forms.Button();
            this.updateCate = new System.Windows.Forms.Button();
            this.addCate = new System.Windows.Forms.Button();
            this.txtdonGia = new System.Windows.Forms.TextBox();
            this.txtsoLuong = new System.Windows.Forms.TextBox();
            this.txtmaThuoc = new System.Windows.Forms.TextBox();
            this.txtmaDH = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataWare)).BeginInit();
            this.Option.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataWare);
            this.groupBox1.Location = new System.Drawing.Point(5, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(791, 273);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // dataWare
            // 
            this.dataWare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataWare.Location = new System.Drawing.Point(0, 18);
            this.dataWare.Name = "dataWare";
            this.dataWare.RowHeadersWidth = 51;
            this.dataWare.RowTemplate.Height = 24;
            this.dataWare.Size = new System.Drawing.Size(790, 269);
            this.dataWare.TabIndex = 0;
            this.dataWare.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataWare_CellContentClick);
            // 
            // Option
            // 
            this.Option.Controls.Add(this.label4);
            this.Option.Controls.Add(this.label3);
            this.Option.Controls.Add(this.label2);
            this.Option.Controls.Add(this.label1);
            this.Option.Controls.Add(this.delCate);
            this.Option.Controls.Add(this.updateCate);
            this.Option.Controls.Add(this.addCate);
            this.Option.Controls.Add(this.txtdonGia);
            this.Option.Controls.Add(this.txtsoLuong);
            this.Option.Controls.Add(this.txtmaThuoc);
            this.Option.Controls.Add(this.txtmaDH);
            this.Option.Location = new System.Drawing.Point(9, 4);
            this.Option.Name = "Option";
            this.Option.Size = new System.Drawing.Size(785, 169);
            this.Option.TabIndex = 3;
            this.Option.TabStop = false;
            this.Option.Text = "Option";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Đơn giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Số lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã thuốc:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã đơn hàng:";
            // 
            // delCate
            // 
            this.delCate.BackColor = System.Drawing.Color.OliveDrab;
            this.delCate.ForeColor = System.Drawing.Color.White;
            this.delCate.Location = new System.Drawing.Point(625, 105);
            this.delCate.Name = "delCate";
            this.delCate.Size = new System.Drawing.Size(122, 30);
            this.delCate.TabIndex = 5;
            this.delCate.Text = "Xóa";
            this.delCate.UseVisualStyleBackColor = false;
            this.delCate.Click += new System.EventHandler(this.delCate_Click);
            // 
            // updateCate
            // 
            this.updateCate.BackColor = System.Drawing.Color.OliveDrab;
            this.updateCate.ForeColor = System.Drawing.Color.White;
            this.updateCate.Location = new System.Drawing.Point(625, 69);
            this.updateCate.Name = "updateCate";
            this.updateCate.Size = new System.Drawing.Size(122, 30);
            this.updateCate.TabIndex = 6;
            this.updateCate.Text = "Sửa";
            this.updateCate.UseVisualStyleBackColor = false;
            this.updateCate.Click += new System.EventHandler(this.updateCate_Click);
            // 
            // addCate
            // 
            this.addCate.BackColor = System.Drawing.Color.OliveDrab;
            this.addCate.ForeColor = System.Drawing.Color.White;
            this.addCate.Location = new System.Drawing.Point(625, 33);
            this.addCate.Name = "addCate";
            this.addCate.Size = new System.Drawing.Size(122, 30);
            this.addCate.TabIndex = 7;
            this.addCate.Text = "Thêm";
            this.addCate.UseVisualStyleBackColor = false;
            this.addCate.Click += new System.EventHandler(this.addCate_Click);
            // 
            // txtdonGia
            // 
            this.txtdonGia.Location = new System.Drawing.Point(154, 127);
            this.txtdonGia.Name = "txtdonGia";
            this.txtdonGia.Size = new System.Drawing.Size(396, 22);
            this.txtdonGia.TabIndex = 3;
            // 
            // txtsoLuong
            // 
            this.txtsoLuong.Location = new System.Drawing.Point(154, 91);
            this.txtsoLuong.Name = "txtsoLuong";
            this.txtsoLuong.Size = new System.Drawing.Size(395, 22);
            this.txtsoLuong.TabIndex = 2;
            // 
            // txtmaThuoc
            // 
            this.txtmaThuoc.Location = new System.Drawing.Point(154, 56);
            this.txtmaThuoc.Name = "txtmaThuoc";
            this.txtmaThuoc.Size = new System.Drawing.Size(396, 22);
            this.txtmaThuoc.TabIndex = 1;
            // 
            // txtmaDH
            // 
            this.txtmaDH.Location = new System.Drawing.Point(154, 21);
            this.txtmaDH.Name = "txtmaDH";
            this.txtmaDH.Size = new System.Drawing.Size(397, 22);
            this.txtmaDH.TabIndex = 0;
            // 
            // Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Option);
            this.Name = "Warehouse";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Warehouse_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataWare)).EndInit();
            this.Option.ResumeLayout(false);
            this.Option.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataWare;
        private System.Windows.Forms.GroupBox Option;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delCate;
        private System.Windows.Forms.Button updateCate;
        private System.Windows.Forms.Button addCate;
        private System.Windows.Forms.TextBox txtdonGia;
        private System.Windows.Forms.TextBox txtsoLuong;
        private System.Windows.Forms.TextBox txtmaThuoc;
        private System.Windows.Forms.TextBox txtmaDH;
    }
}