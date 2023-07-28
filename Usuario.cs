using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSAula15_gerenciador_de_clientes
{
    internal class Usuario
    {
        
        public String user, pass;
        public Usuario(string usuario, string senha)
        {
            this.user = usuario;
            this.pass = senha;
            
        }
    }
}
