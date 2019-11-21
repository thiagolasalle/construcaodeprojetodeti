using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Dao;

namespace Controle
{
    public class LocacaoController
    {
        public Object ExecutarOpBD(char _c, Locacao _o)
        {
            try
            {
                LocacaoDAO dao = new LocacaoDAO();
                switch (_c)
                {
                    case 'i':
                        return dao.InserirBD(_o);
                    case 'd':
                        return dao.DeletarBD(_o.Id);
                    case 'a':
                        return dao.AlterarBD(_o);
                    case 't':
                        return dao.ListarTodos();
                    case 'o':
                        return dao.BuscarPorID(_o.Id);
                    default:
                        return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
