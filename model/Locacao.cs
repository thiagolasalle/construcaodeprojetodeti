using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Locacao
    {

        public Int64 Id { set; get; }

        public DateTime DataLocacao { set; get; }

        public DateTime DataEntrega { set; get; }

        public String Status { set; get; }

        public Funcionario Funcionario { set; get; }

        public Veiculo Veiculo { set; get; }

        public Cliente Cliente { set; get; }

        public Pagamento Pagamento { set; get; }
    }
}
