namespace XIIRPL2_24_Ticketing.MasterForm
{
    partial class FrmMasterBandara
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNegara = new ComboBox();
            txtJumlahTerminal = new NumericUpDown();
            label5 = new Label();
            txtNama = new TextBox();
            txtKodeIATA = new TextBox();
            txtKota = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtAlamat = new TextBox();
            label8 = new Label();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            BtnEdit = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)txtJumlahTerminal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 265);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 5;
            label1.Text = "Nama";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 294);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 6;
            label2.Text = "Kode Data";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 323);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 7;
            label3.Text = "Kota";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 352);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 8;
            label4.Text = "Negara";
            label4.Click += label4_Click;
            // 
            // txtNegara
            // 
            txtNegara.FormattingEnabled = true;
            txtNegara.Location = new Point(107, 349);
            txtNegara.Name = "txtNegara";
            txtNegara.Size = new Size(240, 23);
            txtNegara.TabIndex = 9;
            txtNegara.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtJumlahTerminal
            // 
            txtJumlahTerminal.Location = new Point(492, 257);
            txtJumlahTerminal.Name = "txtJumlahTerminal";
            txtJumlahTerminal.Size = new Size(236, 23);
            txtJumlahTerminal.TabIndex = 10;
            txtJumlahTerminal.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(382, 259);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 11;
            label5.Text = "Jumlah Terminal";
            label5.Click += label5_Click;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(107, 262);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(240, 23);
            txtNama.TabIndex = 12;
            txtNama.TextChanged += txtNama_TextChanged;
            // 
            // txtKodeIATA
            // 
            txtKodeIATA.Location = new Point(107, 291);
            txtKodeIATA.Name = "txtKodeIATA";
            txtKodeIATA.Size = new Size(240, 23);
            txtKodeIATA.TabIndex = 13;
            // 
            // txtKota
            // 
            txtKota.Location = new Point(107, 320);
            txtKota.Name = "txtKota";
            txtKota.Size = new Size(240, 23);
            txtKota.TabIndex = 14;
            txtKota.TextChanged += textBox3_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(18, 9);
            label6.Name = "label6";
            label6.Size = new Size(129, 21);
            label6.TabIndex = 15;
            label6.Text = "Master Bandara";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 40);
            label7.Name = "label7";
            label7.Size = new Size(272, 15);
            label7.TabIndex = 16;
            label7.Text = "Semua bandara yang terdaftar akan muncul di sini";
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(492, 286);
            txtAlamat.Multiline = true;
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(236, 86);
            txtAlamat.TabIndex = 17;
            txtAlamat.TextChanged += textBox4_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(430, 289);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 18;
            label8.Text = "Alamat";
            // 
            // button1
            // 
            button1.Location = new Point(532, 405);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 19;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(613, 405);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 20;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(19, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(783, 150);
            dataGridView1.TabIndex = 21;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BtnEdit
            // 
            BtnEdit.HeaderText = "Edit";
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Text = "Edit";
            BtnEdit.UseColumnTextForButtonValue = true;
            // 
            // BtnDelete
            // 
            BtnDelete.HeaderText = "Delete";
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Text = "Delete";
            BtnDelete.UseColumnTextForButtonValue = true;
            // 
            // FrmMasterBandara
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(txtAlamat);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtKota);
            Controls.Add(txtKodeIATA);
            Controls.Add(txtNama);
            Controls.Add(label5);
            Controls.Add(txtJumlahTerminal);
            Controls.Add(txtNegara);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMasterBandara";
            Text = "FrmMasterBandara";
            Load += FrmMasterBandara_Load_2;
            ((System.ComponentModel.ISupportInitialize)txtJumlahTerminal).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox txtNegara;
        private NumericUpDown txtJumlahTerminal;
        private Label label5;
        private TextBox txtNama;
        private TextBox txtKodeIATA;
        private TextBox txtKota;
        private Label label6;
        private Label label7;
        private TextBox txtAlamat;
        private Label label8;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
    }
}