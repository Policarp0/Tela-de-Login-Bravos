namespace WinFormsApp1
{
    public partial class Idenitifcacao : Form
    {
        public Idenitifcacao()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text == "POLI" && txtSenha.Text == "123")
                {
                    MessageBox.Show("Bem vindo Usuário", "Olá", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorreto", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSenha.SelectAll();
                }
            }
            catch
            {

            }


        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
