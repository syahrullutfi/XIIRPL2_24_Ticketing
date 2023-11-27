namespace XIIRPL2_24_Ticketing.MasterForm
{
    partial class FrmMasterMaskapai
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
            btnsimpan = new Button();
            button1 = new Button();
            label8 = new Label();
            txtdeskripsi = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txtperusahaan = new TextBox();
            txtnama = new TextBox();
            label5 = new Label();
            txtjumlahkru = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            BtnEdit = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)txtjumlahkru).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnsimpan
            // 
            btnsimpan.Location = new Point(598, 404);
            btnsimpan.Name = "btnsimpan";
            btnsimpan.Size = new Size(75, 23);
            btnsimpan.TabIndex = 37;
            btnsimpan.Text = "simpan";
            btnsimpan.UseVisualStyleBackColor = true;
            btnsimpan.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(517, 404);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 36;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(421, 299);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 35;
            label8.Text = "Deskripsi";
            label8.Click += label8_Click;
            // 
            // txtdeskripsi
            // 
            txtdeskripsi.Location = new Point(481, 291);
            txtdeskripsi.Multiline = true;
            txtdeskripsi.Name = "txtdeskripsi";
            txtdeskripsi.Size = new Size(236, 99);
            txtdeskripsi.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 40);
            label7.Name = "label7";
            label7.Size = new Size(279, 15);
            label7.TabIndex = 33;
            label7.Text = "Semua maskapai yang terdaftar akan muncul di sini";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(19, 9);
            label6.Name = "label6";
            label6.Size = new Size(139, 21);
            label6.TabIndex = 32;
            label6.Text = "Master Maskapai";
            // 
            // txtperusahaan
            // 
            txtperusahaan.Location = new Point(107, 320);
            txtperusahaan.Name = "txtperusahaan";
            txtperusahaan.Size = new Size(240, 23);
            txtperusahaan.TabIndex = 30;
            txtperusahaan.TextChanged += textBox2_TextChanged;
            // 
            // txtnama
            // 
            txtnama.Location = new Point(107, 291);
            txtnama.Name = "txtnama";
            txtnama.Size = new Size(240, 23);
            txtnama.TabIndex = 29;
            txtnama.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 351);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 28;
            label5.Text = "Jumlah Kru";
            label5.Click += label5_Click;
            // 
            // txtjumlahkru
            // 
            txtjumlahkru.Location = new Point(107, 349);
            txtjumlahkru.Name = "txtjumlahkru";
            txtjumlahkru.Size = new Size(240, 23);
            txtjumlahkru.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 323);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 23;
            label2.Text = "Perusahaan";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 294);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 22;
            label1.Text = "Nama";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(2, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(798, 150);
            dataGridView1.TabIndex = 38;
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
            // FrmMasterMaskapai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnsimpan);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(txtdeskripsi);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtperusahaan);
            Controls.Add(txtnama);
            Controls.Add(label5);
            Controls.Add(txtjumlahkru);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMasterMaskapai";
            Text = "FrmMasterMaskapai";
            ((System.ComponentModel.ISupportInitialize)txtjumlahkru).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnsimpan;
        private Button button1;
        private Label label8;
        private TextBox txtdeskripsi;
        private Label label7;
        private Label label6;
        private TextBox txtperusahaan;
        private TextBox txtnama;
        private Label label5;
        private NumericUpDown txtjumlahkru;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
    }
}