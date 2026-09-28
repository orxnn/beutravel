using System;
using System.Drawing;
using System.Windows.Forms;

namespace TravelTicket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] seherler = { "Bakı Mühəndislik Universiteti", "Bakı", "Sumqayıt", "Saray", "Xalqlar metrosu" };

            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox1.Items.AddRange(seherler);
            comboBox2.Items.AddRange(seherler);

            comboBox3.Items.Clear();
            comboBox3.Items.Add("AZE");
            comboBox3.Items.Add("AA");
            comboBox3.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = temp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string haradan = comboBox1.Text;
            string haraya = comboBox2.Text;
            string tarix = maskedTextBox1.Text;
            string saat = maskedTextBox2.Text;
            string yer = numericUpDown1.Value.ToString();

            string adSoyad = textBox1.Text;
            string finSeriya = comboBox3.Text;
            string telefon = maskedTextBox4.Text;
            string email = maskedTextBox3.Text;

            richTextBox1.Text = $"Haradan: {haradan} | Haraya: {haraya} | Tarix: {tarix} | Saat: {saat} | Yer: {yer} | Ad: {adSoyad} | Seriya: {finSeriya} | Tel: {telefon} | Email: {email}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Səhifə bağlansın?", "Məlumat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}