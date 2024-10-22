namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblMensagem.Text = "Outra mensagem qualquer";
            //lblMensagem.Visible = false;
            Console.WriteLine(lblMensagem.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Font largeFont = new Font("Consolas", 21);
            lblMensagem.Font = largeFont;
            int resultado, num1, num2;
            num1 = int.Parse(txt1.Text);
            num2 = int.Parse(txt2.Text);
            resultado = num1 + num2;
            // lblMensagem.Text = resultado.ToString();
            MessageBox.Show(resultado.ToString(), "O resultado da soma", MessageBoxButtons.OK);
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
