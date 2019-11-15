﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Data;

namespace Dao
{
    public class BD
    {
        static String strConn = @"Data Source=C:\Users\aluno.unilasalle\Documents\thiagog\construcaodeprojetodeti\MyDatabase#1.sdf;Password=admin;Persist Security Info=True";
        static SqlCeConnection conexao = null;

        public static void AbrirConexao()
        {
            try
            {
                if (conexao != null)
                {
                    conexao.ConnectionString = strConn;

                    if (conexao.State == ConnectionState.Closed)
                    {
                        conexao.Open();
                    }
                }
                else
                {
                    conexao = new SqlCeConnection();

                    conexao.ConnectionString = strConn;

                    conexao.Open();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO AO ABRIR CONEXÃO: " + ex.Message);
            }
        }

        public static void FecharConexao()
        {
            try
            {
                if (conexao != null)
                {
                    if (conexao.State == ConnectionState.Open)
                    {
                        conexao.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO AO FECHAR CONEXÃO: " + ex.Message);
            }
        }

        public static SqlCeDataReader ExecutarSelect(String _SQL)
        {
            try
            {
                AbrirConexao();

                SqlCeCommand comando = new SqlCeCommand(_SQL, conexao);

                SqlCeDataReader data = comando.ExecuteReader();

                return data;
            }
            catch (Exception ex)
            {
                FecharConexao();
                throw new Exception("ERRO AO EXECUTAR SELECT: " + ex.Message);
            }
        }

        public static int ExecutarIDU(String _SQL)
        {
            int linhaAfetadas = 0;
            try
            {
                AbrirConexao();

                SqlCeCommand comando = new SqlCeCommand(_SQL, conexao);

                linhaAfetadas = comando.ExecuteNonQuery();

                FecharConexao();

                return linhaAfetadas;
            }
            catch (Exception ex)
            {
                FecharConexao();
                throw new Exception("ERRO AO EXECUTAR OPERAÇÃO DE INS/ALT/DEL NO BD: " + ex.Message);
            }
        }
    }
}
