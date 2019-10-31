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
    class PagamentoDAO
    {

        public List<Pagamento> ListarTodos()
        {
            List<Pagamento> listaPagamentos = new List<Pagamento>();
            try
            {
                String SQL = "SELECT * FROM pagamento;";

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Pagamento p = new Pagamento();

                    p.Id = data.GetInt64(0);
                    p.Valor = data.GetFloat(1);
                    p.FormaPagamento = data.GetString(2);

                    listaPagamentos.Add(p);
                }

                data.Close();
                BD.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listaPagamentos;
        }

        public Pagamento BuscarPorID(Int64 _id)
        {
            Pagamento p = null;
            try
            {
                String SQL = String.Format("SELECT * FROM pagamento WHERE id = {0} ", _id);

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                if (data.Read())
                {
                    p = new Pagamento();

                    p.Id = data.GetInt64(0);
                    p.Valor = data.GetFloat(1);
                    p.FormaPagamento = data.GetString(2);
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

        public Boolean InserirBD(Pagamento _objeto)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("INSERT INTO pagamento (valor, forma_de_pagamento) VALUES ('{0}', '{1}')",
                    _objeto.Valor,
                    _objeto.FormaPagamento);

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

        public Boolean AlterarBD(Pagamento _objeto)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("UPDATE pagamento SET valor = '{0}', forma_de_pagamento = '{1}' WHERE id = {2};",
                    _objeto.Valor,
                    _objeto.FormaPagamento,
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
                String SQL = String.Format("DELETE FROM pagamento WHERE id = {0};", _id);

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
