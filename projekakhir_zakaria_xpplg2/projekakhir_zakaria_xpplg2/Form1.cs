namespace projekakhir_zakaria_xpplg2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Rows.Add("knuckle", "200.00");
            dataGridView1.Rows.Add("Desert Eagle", "5.000.00");
            dataGridView1.Rows.Add("Stick base ball", "500.00");
            dataGridView1.Rows.Add("ak-47", "15.000.00");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama = textBox1.Text;
            string jenbar = comboBox1.SelectedItem?.ToString();
            string jumbar = comboBox2.SelectedItem?.ToString();
            int harga = 0;

            /*
             Knuckle
Desert Eagle
Stick base ball
ak-47*/

            if (jenbar == "Knuckle") harga = 200000 * Convert.ToInt32(jumbar);
            if (jenbar == "Desert Eagle") harga = 500000 * Convert.ToInt32(jumbar);
            if (jenbar == "Stick base ball") harga = 50000 * Convert.ToInt32(jumbar);
            if (jenbar == "ak-47") harga = 1500000 * Convert.ToInt32(jumbar);
            dataGridView2.Rows.Add(nama, jenbar, jumbar, harga);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            textBox1.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            MessageBox.Show(" PILIHAN TELAH DIRESET ");
        }
    }
    
}
