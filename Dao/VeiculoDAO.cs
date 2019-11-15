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
    public class VeiculoDAO
    {

        public List<Veiculo> ListarTodos()
        {
            List<Veiculo> listaVeiculos = new List<Veiculo>();
            try
            {
                String SQL = "SELECT * FROM veiculo;";

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Veiculo p = new Veiculo();

                    p.Id = data.GetInt64(0);
                    p.Marca = data.GetString(1);
                    p.Cor = data.GetString(2);
                    p.Placa = data.GetString(3);
                    p.status = data.GetString(4);

                    listaVeiculos.Add(p);
                }

                data.Close();
                BD.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listaVeiculos;
        }

        public Veiculo BuscarPorID(Int64 _id)
        {
            Veiculo p = null;
            try
            {
                String SQL = String.Format("SELECT * FROM veiculo WHERE id = {0} ", _id);

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                if (data.Read())
                {
                    p = new Veiculo();

                    p.Id = data.GetInt64(0);
                    p.Marca = data.GetString(1);
                    p.Cor = data.GetString(2);
                    p.Placa = data.GetString(3);
                    p.status = data.GetString(4);
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

        public Boolean InserirBD(Veiculo _objeto)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("INSERT INTO veiculo (marca, cor, placa, status) VALUES ('{0}', '{1}', '{2}', '{3}')",
                    _objeto.Marca,
                    _objeto.Cor,
                    _objeto.Placa,
                    _objeto.status);

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

        public Boolean AlterarBD(Veiculo _objeto)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("UPDATE veiculo SET marca = '{0}', cor = '{1}', placa = '{2}', status= '{3}' WHERE id = {4};",
                    _objeto.Marca,
                    _objeto.Cor,
                    _objeto.Placa,
                    _objeto.status,
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
                String SQL = String.Format("DELETE FROM veiculo WHERE id = {0};", _id);

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
