using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Veiculo
    {
        public Int64 Id { set; get; }

        public string Marca { get; set; }

        public string Cor { get; set; }

        public string Placa { get; set; }

        public string status { get; set; }
    }
}
