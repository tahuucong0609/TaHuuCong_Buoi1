namespace TaHuuCong_Buoi1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txta = new TextBox();
            lblketqua = new Label();
            label6 = new Label();
            ntbgiai = new Button();
            lblxoa = new Button();
            lblthoat = new Button();
            txtb = new TextBox();
            txtc = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F);
            label1.Location = new Point(172, 9);
            label1.Name = "label1";
            label1.Size = new Size(500, 51);
            label1.TabIndex = 0;
            label1.Text = "GIẢI PHƯƠNG TRÌNH BẬC 2 ";
            // 
            // label2
            // 
            label2.Location = new Point(168, 82);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 0;
            label2.Text = "A:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(168, 129);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 0;
            label3.Text = "B:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(168, 174);
            label4.Name = "label4";
            label4.Size = new Size(18, 15);
            label4.TabIndex = 0;
            label4.Text = "C:";
            // 
            // txta
            // 
            txta.Location = new Point(212, 79);
            txta.Name = "txta";
            txta.Size = new Size(164, 23);
            txta.TabIndex = 1;
            // 
            // lblketqua
            // 
            lblketqua.BackColor = SystemColors.ControlDark;
            lblketqua.Location = new Point(195, 229);
            lblketqua.Name = "lblketqua";
            lblketqua.Size = new Size(191, 28);
            lblketqua.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(114, 286);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 0;
            label6.Text = "Chọn thao tác";
            // 
            // ntbgiai
            // 
            ntbgiai.Location = new Point(162, 338);
            ntbgiai.Name = "ntbgiai";
            ntbgiai.Size = new Size(75, 23);
            ntbgiai.TabIndex = 2;
            ntbgiai.Text = "Giải";
            ntbgiai.UseVisualStyleBackColor = true;
            ntbgiai.Click += ntbgiai_Click;
            // 
            // lblxoa
            // 
            lblxoa.Location = new Point(345, 338);
            lblxoa.Name = "lblxoa";
            lblxoa.Size = new Size(75, 23);
            lblxoa.TabIndex = 2;
            lblxoa.Text = "Xóa trắng";
            lblxoa.UseVisualStyleBackColor = true;
            lblxoa.Click += lblxoa_Click;
            // 
            // lblthoat
            // 
            lblthoat.Location = new Point(518, 338);
            lblthoat.Name = "lblthoat";
            lblthoat.Size = new Size(75, 23);
            lblthoat.TabIndex = 2;
            lblthoat.Text = "Thoát";
            lblthoat.UseVisualStyleBackColor = true;
            lblthoat.Click += lblthoat_Click;
            // 
            // txtb
            // 
            txtb.Location = new Point(212, 121);
            txtb.Name = "txtb";
            txtb.Size = new Size(164, 23);
            txtb.TabIndex = 1;
            // 
            // txtc
            // 
            txtc.Location = new Point(212, 166);
            txtc.Name = "txtc";
            txtc.Size = new Size(164, 23);
            txtc.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(260, 204);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 3;
            label7.Text = "KET QUA";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(lblthoat);
            Controls.Add(lblxoa);
            Controls.Add(ntbgiai);
            Controls.Add(txtc);
            Controls.Add(txtb);
            Controls.Add(txta);
            Controls.Add(label6);
            Controls.Add(lblketqua);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txta;
        private Label lblketqua;
        private Label label6;
        private Button ntbgiai;
        private Button lblxoa;
        private Button lblthoat;
        private TextBox txtb;
        private TextBox txtc;
        private Label label7;
    }
}
