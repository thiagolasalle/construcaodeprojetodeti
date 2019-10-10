﻿using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Cliente
    {

        public Cliente()
        { 
            locacoes = new List<Locacao>();
        }
        
        public Int64 Id { set; get; }

        public String Nome { set; get; }

        public String Cpf { set; get; }

        public String Endereco { set; get; }

        public String Sexo { set; get; }

        public Boolean Deficiencia { set; get; }

        public Boolean IdadeDeRisco { set; get; }

        List<Locacao> locacoes { set; get; }
    }
}
