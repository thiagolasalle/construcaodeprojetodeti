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
    public class FuncionarioDAO
    {
        
        public List<Funcionario> ListarTodos()
        {
            List<Funcionario> listaFuncionarios = new List<Funcionario>();
            try
            {
                String SQL = "SELECT * FROM funcionario;";

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Funcionario p = new Funcionario();

                    p.Id = data.GetInt64(0);
                    p.Nome = data.GetString(1);
                    p.Matricula = data.GetString(2);
                    p.Senha = data.GetString(3);
                    p.Sexo = data.GetString(4);

                    listaFuncionarios.Add(p);
                }

                data.Close();
                BD.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listaFuncionarios;
        }

        public Funcionario BuscarPorID(Int64 _id)
        {
            Funcionario p = null;
            try
            {
                String SQL = String.Format("SELECT * FROM funcionario WHERE id = {0} ", _id);

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                if (data.Read())
                {
                    p = new Funcionario();

                    p.Id = data.GetInt64(0);
                    p.Nome = data.GetString(1);
                    p.Matricula = data.GetString(2);
                    p.Senha = data.GetString(3);
                    p.Sexo = data.GetString(4);
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

        public Boolean InserirBD(Funcionario _objeto)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("INSERT INTO funcionario (nome, matricula, senha, sexo) VALUES ('{0}', '{1}', '{2}', '{3}')",
                    _objeto.Nome,
                    _objeto.Matricula,
                    _objeto.Senha,
                    _objeto.Sexo);

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

        public Boolean AlterarBD(Funcionario _objeto)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("UPDATE funcionario SET nome = '{0}', matricula = '{1}', senha = '{2}', sexo = '{3}' WHERE id = {4};",
                    _objeto.Nome,
                    _objeto.Matricula,
                    _objeto.Senha,
                    _objeto.Sexo,
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
                String SQL = String.Format("DELETE FROM funcionario WHERE id = {0};", _id);

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
