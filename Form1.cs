namespace PSAula15_gerenciador_de_clientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void clear_inicial()
        {
            txtSenha.Clear();
            txtUsuario.Clear();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            for (int i = 0; i < Program.clientes.Count; i++)
            {
                if (Program.clientes[i].usuario.user == usuario && Program.clientes[i].usuario.pass == senha)
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                    clear_inicial();
                    
                }
                else
                {
                    MessageBox.Show("Há alguma credencial incorreta !!", "Digite novamente !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    clear_inicial();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario("usuario", "senha");
            Cliente admin = new Cliente("admin", 0, usuario);
            Program.clientes.Add(admin);


        }
    }
}