using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Pagamento  
    {
        public Int64 Id { set; get; }

        public float Valor { get; set; }

        public string FormaPagamento { get; set; }

        public Locacao Locacao { set; get; }

    }
}
