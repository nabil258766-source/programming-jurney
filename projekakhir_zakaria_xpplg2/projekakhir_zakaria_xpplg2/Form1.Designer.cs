namespace projekakhir_zakaria_xpplg2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            splitter1 = new Splitter();
            label4 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            dataGridView1 = new DataGridView();
            jenbar = new DataGridViewTextBoxColumn();
            jumbar = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            Nm = new DataGridViewTextBoxColumn();
            Jebar = new DataGridViewTextBoxColumn();
            Jepes = new DataGridViewTextBoxColumn();
            Habar = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 142);
            label1.Name = "label1";
            label1.Size = new Size(71, 30);
            label1.TabIndex = 0;
            label1.Text = "Nama";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 237);
            label2.Name = "label2";
            label2.Size = new Size(137, 30);
            label2.TabIndex = 1;
            label2.Text = "Jenis Barang";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(14, 316);
            label3.Name = "label3";
            label3.Size = new Size(84, 30);
            label3.TabIndex = 2;
            label3.Text = "Jumlah";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(231, 141);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 738);
            splitter1.TabIndex = 5;
            splitter1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Algerian", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Linen;
            label4.Location = new Point(452, 19);
            label4.Name = "label4";
            label4.Size = new Size(577, 54);
            label4.TabIndex = 7;
            label4.Text = "DAFTAR PESAN BARANG";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Knuckle", "Desert Eagle", "Stick base ball", "ak-47" });
            comboBox1.Location = new Point(229, 234);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            comboBox2.Location = new Point(229, 317);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { jenbar, jumbar });
            dataGridView1.Location = new Point(1094, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(422, 207);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // jenbar
            // 
            jenbar.HeaderText = "jenis barang";
            jenbar.MinimumWidth = 8;
            jenbar.Name = "jenbar";
            jenbar.Width = 150;
            // 
            // jumbar
            // 
            jumbar.HeaderText = "jumlah barang";
            jumbar.MinimumWidth = 8;
            jumbar.Name = "jumbar";
            jumbar.Width = 150;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Nm, Jebar, Jepes, Habar });
            dataGridView2.Location = new Point(519, 429);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(798, 267);
            dataGridView2.TabIndex = 11;
            // 
            // Nm
            // 
            Nm.HeaderText = "Nama";
            Nm.MinimumWidth = 8;
            Nm.Name = "Nm";
            Nm.ReadOnly = true;
            Nm.Width = 150;
            // 
            // Jebar
            // 
            Jebar.HeaderText = "Jenis Barang";
            Jebar.MinimumWidth = 8;
            Jebar.Name = "Jebar";
            Jebar.ReadOnly = true;
            Jebar.Width = 150;
            // 
            // Jepes
            // 
            Jepes.HeaderText = "Jenis Pesanan";
            Jepes.MinimumWidth = 8;
            Jepes.Name = "Jepes";
            Jepes.ReadOnly = true;
            Jepes.Width = 150;
            // 
            // Habar
            // 
            Habar.HeaderText = "Harga Barang";
            Habar.MinimumWidth = 8;
            Habar.Name = "Habar";
            Habar.ReadOnly = true;
            Habar.Width = 150;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Location = new Point(14, 398);
            button1.Name = "button1";
            button1.Size = new Size(137, 60);
            button1.TabIndex = 12;
            button1.Text = "Pesan";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(229, 398);
            button2.Name = "button2";
            button2.Size = new Size(152, 56);
            button2.TabIndex = 13;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(105, 572);
            button3.Name = "button3";
            button3.Size = new Size(158, 54);
            button3.TabIndex = 14;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1635, 738);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(splitter1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Splitter splitter1;
        private Label label4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn jenbar;
        private DataGridViewTextBoxColumn jumbar;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Nm;
        private DataGridViewTextBoxColumn Jebar;
        private DataGridViewTextBoxColumn Jepes;
        private DataGridViewTextBoxColumn Habar;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
