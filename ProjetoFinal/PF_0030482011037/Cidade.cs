using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PF_0030482011037
{
    class Cidade
    {
        private int idCidade;
        private string nomeCidade;
        private string ufCidade;

        public int IdCidade
        {
            get
            {
                return idCidade;
            }
            set
            {
                idCidade = value;
            }
        }

        public string NomeCidade
        {
            get
            {
                return nomeCidade;
            }
            set
            {
                nomeCidade = value;
            }
        }

        public string UfCidade
        {
            get
            {
                return ufCidade;
            }
            set
            {
                ufCidade = value;
            }
        }

        public DataTable Listar()
        {
            SqlDataAdapter daCidade;

            DataTable dtCidade = new DataTable();

            try
            {
                daCidade = new SqlDataAdapter(
                    "SELECT * FROM TBCIDADE",
                    frmPrincipal.conexao
                );
                daCidade.Fill(dtCidade);
                daCidade.FillSchema(dtCidade, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtCidade;
        }

        public int Salvar()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;
                int numeroRegistros;

                mycommand = new SqlCommand(
                    "INSERT INTO TBCIDADE VALUES (@nome_cidade, @uf_cidade)",
                    frmPrincipal.conexao
                );

                mycommand.Parameters.Add(new SqlParameter("@nome_cidade", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@uf_cidade", SqlDbType.Char));

                mycommand.Parameters["@nome_cidade"].Value = nomeCidade;
                mycommand.Parameters["@uf_cidade"].Value = ufCidade;

                numeroRegistros = mycommand.ExecuteNonQuery();

                if (numeroRegistros > 0)
                {
                    retorno = numeroRegistros;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return retorno;
        }

        public int Alterar()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;

                int numeroRegistros = 0;

                mycommand = new SqlCommand(
                    "UPDATE TBCIDADE SET nome_cidade = @nome_cidade, uf_cidade = @uf_cidade " +
                    "WHERE id_cidade = @id_cidade",
                    frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@id_cidade", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@nome_cidade", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@uf_cidade", SqlDbType.Char));

                mycommand.Parameters["@id_cidade"].Value = idCidade;
                mycommand.Parameters["@nome_cidade"].Value = nomeCidade;
                mycommand.Parameters["@uf_cidade"].Value = ufCidade;

                numeroRegistros = mycommand.ExecuteNonQuery();

                if (numeroRegistros > 0)
                {
                    retorno = numeroRegistros;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return retorno;
        }

        public int Excluir()
        {
            int numeroRegistros = 0;

            try
            {
                SqlCommand mycommand;

                mycommand = new SqlCommand(
                    "DELETE FROM TBCIDADE WHERE " +
                    "id_cidade = @id_cidade", frmPrincipal.conexao);
                
                mycommand.Parameters.Add(new SqlParameter("@id_cidade", SqlDbType.Int));
                mycommand.Parameters["@id_cidade"].Value = Convert.ToInt16(idCidade);
                numeroRegistros = mycommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return numeroRegistros;
        }
    }
}
