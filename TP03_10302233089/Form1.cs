namespace TP03_10302233089
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            String nama = textBox1.Text;
            if (string.IsNullOrEmpty(nama))
            {
                label1.Text = "Masukkan nama terlebih dahulu!";
            }
            else
            {
                label1.Text = nama;
            }

        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            String nama = textBox1.Text;
            if (string.IsNullOrEmpty(nama))
            {
                label1.Text = "Kamu siapa?";
                return;
            }
            else
            {
                label1.Text = "Halo " + nama;
            }
        }

        private void lblOutput_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
