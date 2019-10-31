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
    class ClienteDAO
    {
        
        public List<Cliente> ListarTodos()
        {
            List<Cliente> listaClientes = new List<Cliente>();
            try
            {
                String SQL = "SELECT * FROM cliente;";

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Cliente p = new Cliente();

                    p.Id = data.GetInt64(0);
                    p.Nome = data.GetString(1);
                    p.Cpf = data.GetString(2);
                    p.Endereco = data.GetString(3);
                    p.Sexo = data.GetString(4);
                    p.Deficiencia = data.GetBoolean(5);
                    p.IdadeDeRisco = data.GetBoolean(6);

                    listaClientes.Add(p);
                }

                data.Close();
                BD.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listaClientes;
        }

        public Cliente BuscarPorID(Int64 _id)
        {
            Cliente p = null;
            try
            {
                String SQL = String.Format("SELECT * FROM cliente WHERE id = {0} ", _id);

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                if (data.Read())
                {
                    p = new Cliente();

                    p.Id = data.GetInt64(0);
                    p.Nome = data.GetString(1);
                    p.Cpf = data.GetString(2);
                    p.Endereco = data.GetString(3);
                    p.Sexo = data.GetString(4);
                    p.Deficiencia = data.GetString(5);
                    p.IdadeDeRisco = data.GetString(6);
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

        public Boolean InserirBD(Cliente _objeto)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("INSERT INTO cliente (nome, cpf, endereco, sexo, deficiencia, idade_de_risco) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                    _objeto.Nome,
                    _objeto.Cpf,
                    _objeto.Endereco,
                    _objeto.Sexo,
                    _objeto.Deficiencia,
                    _objeto.IdadeDeRisco);

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

        public Boolean AlterarBD(Cliente _objeto)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("UPDATE cliente SET nome = '{0}', cpf = '{1}', endereco = '{2}', sexo = '{3}', deficiencia = '{4}', idade_de_risco = '{5}' WHERE id = {6};",
                    _objeto.Nome,
                    _objeto.Cpf,
                    _objeto.Endereco,
                    _objeto.Sexo,
                    _objeto.Deficiencia,
                    _objeto.IdadeDeRisco,
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
                String SQL = String.Format("DELETE FROM cliente WHERE id = {0};", _id);

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
