using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Veiculo
    {

        public Veiculo()
        { 
            locacoes = new List<Locacao>();
        }

        public Int64 Id { set; get; }

        public string Marca { get; set; }

        public string Cor { get; set; }

        public string Placa { get; set; }

        public string status { get; set; }

        List<Locacao> locacoes { set; get; }
    }
}
