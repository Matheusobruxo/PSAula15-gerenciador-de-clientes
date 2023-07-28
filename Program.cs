namespace PSAula15_gerenciador_de_clientes
{
    internal class Program
    {
        public static List<Cliente> clientes = new List<Cliente>();
        public List<Usuario> usuarios = new List<Usuario>();

        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

        }
    }
}