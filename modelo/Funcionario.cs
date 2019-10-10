using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Funcionario
    {

        public Funcionario()
        { 
            locacoes = new List<Locacao>();
        }

        public Int64 Id { set; get; }

        public string Nome { get; set; }

        public string Matricula { get; set; }

        public string Senha { get; set; }

        public string Sexo { get; set; }

        List<Locacao> locacoes { set; get; }
    }
}
