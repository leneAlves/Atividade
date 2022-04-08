using MySql.Data.MySqlClient;
using ProjetoTarefa.br.com.projeto.conexao;
using ProjetoTarefa.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTarefa.br.com.projeto.dao
{
    public class TarefaDAO
    {
        private MySqlConnection conexao;

        public TarefaDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region Listar todas as tarefas
        public DataTable listarTarefas()
        {
            try
            {
                DataTable tabelatarefa = new DataTable();
                string sql = "select * from tbtarefa";

       
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                executacmd.ExecuteNonQuery();


                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelatarefa);

                conexao.Close();

                return tabelatarefa;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
                return null;
            }
        }
        #endregion

        #region AdicionarTarefa
        public void AdicionarTarefa(Tarefa obj)
        {
            try
            {
                string sql = "insert into tbtarefa (titulo, assunto, data, importancia) values (@titulo, @assunto, @data, @importancia)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@titulo", obj.titulo);
                executacmd.Parameters.AddWithValue("@assunto", obj.assunto);
                executacmd.Parameters.AddWithValue("@data", obj.data);
                executacmd.Parameters.AddWithValue("@importancia", obj.importancia);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Tarefa cadastrada com sucesso");

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            } 

        }

        #endregion

        #region ExcluirTarefa
        public void excluirTarefa(Tarefa obj)
        {
            try
            {
                string sql = @"delete from tbtarefa where id = @id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@id", obj.id);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Tarefa excluida com sucesso!");

                conexao.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }

        #endregion

        #region EditarTarefa
        public void editarTarefa(Tarefa obj)
        {
            try
            {
                string sql = @"update tbtarefa set titulo=@titulo, assunto=@assunto, data=@data, importancia=@importancia where id=@id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@titulo", obj.titulo);
                executacmd.Parameters.AddWithValue("@assunto", obj.assunto);
                executacmd.Parameters.AddWithValue("@data", obj.data);
                executacmd.Parameters.AddWithValue("@importancia", obj.importancia);
                executacmd.Parameters.AddWithValue("@id", obj.id);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Tarefa Alterado com sucesso!");

                conexao.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }
        #endregion
    }
}
