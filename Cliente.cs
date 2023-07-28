using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSAula15_gerenciador_de_clientes
{
    internal class Cliente
    {
        public string name;
        public int years;
        public Usuario usuario;

        public Cliente(string nome, int idade, Usuario usuario)
        {
            this.name = nome;
            this.years = idade;
            this.usuario = usuario;
        }
    }
}

