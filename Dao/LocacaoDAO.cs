using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.IO;
using System.Data.SqlServerCe;

namespace Dao
{
    public class LocacaoDAO
    {

        public List<Locacao> ListarTodos()
        {
            List<Locacao> listaLocacaos = new List<Locacao>();
            try
            {
                String SQL = "SELECT * FROM locacao;";

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Locacao p = new Locacao();

                    p.Id = data.GetInt64(0);
                    p.DataLocacao = data.GetDateTime(1);
                    p.DataEntrega = data.GetDateTime(2);
                    p.Status = data.GetString(3);

                    listaLocacaos.Add(p);
                }

                data.Close();
                BD.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listaLocacaos;
        }

        public Locacao BuscarPorID(Int64 _id)
        {
            Locacao p = null;
            try
            {
                String SQL = String.Format("SELECT * FROM locacao WHERE id = {0} ", _id);

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                if (data.Read())
                {
                    p = new Locacao();

                    p.Id = data.GetInt64(0);
                    p.DataLocacao = data.GetDateTime(1);
                    p.DataEntrega = data.GetDateTime(2);
                    p.Status = data.GetString(3);
                }

                data.Close();
                BD.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return p;
        }

        public Boolean InserirBD(Locacao _objeto)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("INSERT INTO locacao (data_locacao, data_entrega, status) VALUES ('{0}', '{1}', '{2}')",
                    _objeto.DataLocacao,
                    _objeto.DataEntrega,
                    _objeto.Status);

                int linhaAfetadas = BD.ExecutarIDU(SQL);

                if (linhaAfetadas > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return resultado;
        }

        public Boolean AlterarBD(Locacao _objeto)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("UPDATE locacao SET data_locacao = '{0}', data_entrega = '{1}', status = '{2}' WHERE id = {3};",
                    _objeto.DataLocacao,
                    _objeto.DataEntrega,
                    _objeto.Status,
                    _objeto.Id);

                int linhaAfetadas = BD.ExecutarIDU(SQL);

                if (linhaAfetadas > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return resultado;
        }

        public Boolean DeletarBD(Int64 _id)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("DELETE FROM locacao WHERE id = {0};", _id);

                int linhaAfetadas = BD.ExecutarIDU(SQL);

                if (linhaAfetadas > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return resultado;
        }
    }
}
