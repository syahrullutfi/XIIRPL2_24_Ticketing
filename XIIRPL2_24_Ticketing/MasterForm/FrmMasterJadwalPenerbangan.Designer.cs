namespace XIIRPL2_24_Ticketing.MasterForm
{
    partial class FrmMasterJadwalPenerbangan
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
            button2 = new Button();
            button1 = new Button();
            label7 = new Label();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            txtkodepenerbangan = new TextBox();
            txtbandarakeberangkatanid = new ComboBox();
            label3 = new Label();
            txtbandaratujuanid = new ComboBox();
            txtmaskapaiid = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            txttanggalwaktukeberangkatan = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            txtwaktukeberangkatan = new TextBox();
            txtdurasipenerbangan = new TextBox();
            label10 = new Label();
            txthargapertiket = new NumericUpDown();
            dataGridView2 = new DataGridView();
            BtnEdit = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)txthargapertiket).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(718, 425);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 37;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(637, 425);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 36;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 40);
            label7.Name = "label7";
            label7.Size = new Size(337, 15);
            label7.TabIndex = 33;
            label7.Text = "Semua Jadwal Penerbangan yang terdaftar akan muncul di sini";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(225, 21);
            label6.TabIndex = 32;
            label6.Text = "Master Jadwal Penerbangan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 262);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 38;
            label1.Text = "Kode Penerbangan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 291);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 39;
            label2.Text = "Dari";
            label2.Click += label2_Click;
            // 
            // txtkodepenerbangan
            // 
            txtkodepenerbangan.Location = new Point(144, 262);
            txtkodepenerbangan.Name = "txtkodepenerbangan";
            txtkodepenerbangan.Size = new Size(225, 23);
            txtkodepenerbangan.TabIndex = 40;
            // 
            // txtbandarakeberangkatanid
            // 
            txtbandarakeberangkatanid.FormattingEnabled = true;
            txtbandarakeberangkatanid.Location = new Point(144, 291);
            txtbandarakeberangkatanid.Name = "txtbandarakeberangkatanid";
            txtbandarakeberangkatanid.Size = new Size(225, 23);
            txtbandarakeberangkatanid.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 320);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 42;
            label3.Text = "Ke";
            // 
            // txtbandaratujuanid
            // 
            txtbandaratujuanid.FormattingEnabled = true;
            txtbandaratujuanid.Location = new Point(144, 320);
            txtbandaratujuanid.Name = "txtbandaratujuanid";
            txtbandaratujuanid.Size = new Size(225, 23);
            txtbandaratujuanid.TabIndex = 43;
            txtbandaratujuanid.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // txtmaskapaiid
            // 
            txtmaskapaiid.FormattingEnabled = true;
            txtmaskapaiid.Location = new Point(144, 349);
            txtmaskapaiid.Name = "txtmaskapaiid";
            txtmaskapaiid.Size = new Size(225, 23);
            txtmaskapaiid.TabIndex = 44;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 349);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 45;
            label4.Text = "Maskapai";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(433, 262);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 46;
            label5.Text = "Tanggal";
            // 
            // txttanggalwaktukeberangkatan
            // 
            txttanggalwaktukeberangkatan.Location = new Point(610, 262);
            txttanggalwaktukeberangkatan.Name = "txttanggalwaktukeberangkatan";
            txttanggalwaktukeberangkatan.Size = new Size(225, 23);
            txttanggalwaktukeberangkatan.TabIndex = 47;
            txttanggalwaktukeberangkatan.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(433, 328);
            label8.Name = "label8";
            label8.Size = new Size(113, 15);
            label8.TabIndex = 48;
            label8.Text = "Durasi Penerbangan";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(433, 299);
            label9.Name = "label9";
            label9.Size = new Size(123, 15);
            label9.TabIndex = 49;
            label9.Text = "Waktu Keberangkatan";
            // 
            // txtwaktukeberangkatan
            // 
            txtwaktukeberangkatan.Location = new Point(610, 296);
            txtwaktukeberangkatan.Name = "txtwaktukeberangkatan";
            txtwaktukeberangkatan.Size = new Size(225, 23);
            txtwaktukeberangkatan.TabIndex = 50;
            // 
            // txtdurasipenerbangan
            // 
            txtdurasipenerbangan.Location = new Point(610, 328);
            txtdurasipenerbangan.Name = "txtdurasipenerbangan";
            txtdurasipenerbangan.Size = new Size(225, 23);
            txtdurasipenerbangan.TabIndex = 51;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(433, 357);
            label10.Name = "label10";
            label10.Size = new Size(87, 15);
            label10.TabIndex = 52;
            label10.Text = "Harga per Tiket";
            // 
            // txthargapertiket
            // 
            txthargapertiket.Location = new Point(610, 357);
            txthargapertiket.Name = "txthargapertiket";
            txthargapertiket.Size = new Size(225, 23);
            txthargapertiket.TabIndex = 53;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView2.Location = new Point(-2, 75);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(910, 150);
            dataGridView2.TabIndex = 54;
            dataGridView2.CellClick += dataGridView2_CellClick;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
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
            // FrmMasterJadwalPenerbangan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 461);
            Controls.Add(dataGridView2);
            Controls.Add(txthargapertiket);
            Controls.Add(label10);
            Controls.Add(txtdurasipenerbangan);
            Controls.Add(txtwaktukeberangkatan);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txttanggalwaktukeberangkatan);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtmaskapaiid);
            Controls.Add(txtbandaratujuanid);
            Controls.Add(label3);
            Controls.Add(txtbandarakeberangkatanid);
            Controls.Add(txtkodepenerbangan);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Name = "FrmMasterJadwalPenerbangan";
            Text = "FrmMasterJadwalPenerbangan";
            ((System.ComponentModel.ISupportInitialize)txthargapertiket).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Label label7;
        private Label label6;
        private Label label1;
        private Label label2;
        private TextBox txtkodepenerbangan;
        private ComboBox txtbandarakeberangkatanid;
        private Label label3;
        private ComboBox txtbandaratujuanid;
        private ComboBox txtmaskapaiid;
        private Label label4;
        private Label label5;
        private DateTimePicker txttanggalwaktukeberangkatan;
        private Label label8;
        private Label label9;
        private TextBox txtwaktukeberangkatan;
        private TextBox txtdurasipenerbangan;
        private Label label10;
        private NumericUpDown txthargapertiket;
        private DataGridView dataGridView2;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
    }
}