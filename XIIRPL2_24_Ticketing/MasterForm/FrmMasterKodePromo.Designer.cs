namespace XIIRPL2_24_Ticketing.MasterForm
{
    partial class FrmMasterKodePromo
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
            label7 = new Label();
            label6 = new Label();
            txtkodepromo = new TextBox();
            label1 = new Label();
            txtberlakusampai = new ComboBox();
            label2 = new Label();
            txtpresentasediskon = new NumericUpDown();
            txtmaksimumdiskon = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            btnSimpan = new Button();
            button1 = new Button();
            label8 = new Label();
            txtdeskripsi = new TextBox();
            dataGridView1 = new DataGridView();
            BtnEdit = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)txtpresentasediskon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtmaksimumdiskon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 40);
            label7.Name = "label7";
            label7.Size = new Size(295, 15);
            label7.TabIndex = 36;
            label7.Text = "Semua Kode Promo yang terdaftar akan muncul di sini";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(160, 21);
            label6.TabIndex = 35;
            label6.Text = "Master Kode Promo";
            // 
            // txtkodepromo
            // 
            txtkodepromo.Location = new Point(129, 260);
            txtkodepromo.Name = "txtkodepromo";
            txtkodepromo.Size = new Size(206, 23);
            txtkodepromo.TabIndex = 37;
            txtkodepromo.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 260);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 38;
            label1.Text = "Kode Promo";
            // 
            // txtberlakusampai
            // 
            txtberlakusampai.FormattingEnabled = true;
            txtberlakusampai.Location = new Point(129, 289);
            txtberlakusampai.Name = "txtberlakusampai";
            txtberlakusampai.Size = new Size(206, 23);
            txtberlakusampai.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 289);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 41;
            label2.Text = "Berlaku Sampai";
            // 
            // txtpresentasediskon
            // 
            txtpresentasediskon.Location = new Point(129, 318);
            txtpresentasediskon.Name = "txtpresentasediskon";
            txtpresentasediskon.Size = new Size(206, 23);
            txtpresentasediskon.TabIndex = 42;
            txtpresentasediskon.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // txtmaksimumdiskon
            // 
            txtmaksimumdiskon.Location = new Point(129, 347);
            txtmaksimumdiskon.Name = "txtmaksimumdiskon";
            txtmaksimumdiskon.Size = new Size(206, 23);
            txtmaksimumdiskon.TabIndex = 43;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 318);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 44;
            label3.Text = "Persentase Diskon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 347);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 45;
            label4.Text = "Maksimum Diskon";
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(561, 387);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 23);
            btnSimpan.TabIndex = 49;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // button1
            // 
            button1.Location = new Point(480, 387);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 48;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(384, 257);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 47;
            label8.Text = "Deskripsi";
            // 
            // txtdeskripsi
            // 
            txtdeskripsi.Location = new Point(444, 257);
            txtdeskripsi.Multiline = true;
            txtdeskripsi.Name = "txtdeskripsi";
            txtdeskripsi.Size = new Size(236, 66);
            txtdeskripsi.TabIndex = 46;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(2, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(797, 150);
            dataGridView1.TabIndex = 50;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BtnEdit
            // 
            BtnEdit.HeaderText = "Edit";
            BtnEdit.Name = "BtnEdit";
            BtnEdit.UseColumnTextForButtonValue = true;
            // 
            // BtnDelete
            // 
            BtnDelete.HeaderText = "Delete";
            BtnDelete.Name = "BtnDelete";
            BtnDelete.UseColumnTextForButtonValue = true;
            // 
            // FrmMasterKodePromo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnSimpan);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(txtdeskripsi);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtmaksimumdiskon);
            Controls.Add(txtpresentasediskon);
            Controls.Add(label2);
            Controls.Add(txtberlakusampai);
            Controls.Add(label1);
            Controls.Add(txtkodepromo);
            Controls.Add(label7);
            Controls.Add(label6);
            Name = "FrmMasterKodePromo";
            Text = "FrmMasterKodePromo";
            ((System.ComponentModel.ISupportInitialize)txtpresentasediskon).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtmaksimumdiskon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private TextBox txtkodepromo;
        private Label label1;
        private ComboBox txtberlakusampai;
        private Label label2;
        private NumericUpDown txtpresentasediskon;
        private NumericUpDown txtmaksimumdiskon;
        private Label label3;
        private Label label4;
        private Button btnSimpan;
        private Button button1;
        private Label label8;
        private TextBox txtdeskripsi;
        private DataGridView dataGridView1;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
    }
}