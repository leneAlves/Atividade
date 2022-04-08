using MySql.Data.MySqlClient;
using ProjetoTarefa.br.com.projeto.conexao;
using ProjetoTarefa.br.com.projeto.dao;
using ProjetoTarefa.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTarefa
{
    public partial class tela_secundaria : Form
    {
        public tela_secundaria()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tela_secundaria_Load(object sender, EventArgs e)
        {
            TarefaDAO dao = new TarefaDAO();
            dgtarefas.DataSource = dao.listarTarefas();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            Tarefa obj = new Tarefa();
            obj.titulo = txttitulo.Text;
            obj.assunto = txtassunto.Text;
            obj.data = Convert.ToDateTime(dateTimeData.Text);

            if (rbbaixa.Checked)
            {
                obj.importancia = "Baixa";
            }
            else if (rbmedia.Checked)
            {
                obj.importancia = "Média";
            }
            else if (rbalta.Checked)
            {
                obj.importancia = "Alta";
            }

            TarefaDAO dao = new TarefaDAO();
            dao.AdicionarTarefa(obj);

            dgtarefas.DataSource = dao.listarTarefas();

            txtid.Clear();
            txttitulo.Clear();
            txtassunto.Clear();


        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            Tarefa obj = new Tarefa();
            obj.titulo = txttitulo.Text;
            obj.assunto = txtassunto.Text;
            obj.data = Convert.ToDateTime(dateTimeData.Text);
            obj.id = int.Parse(txtid.Text);

            if (rbbaixa.Checked)
            {
                obj.importancia = "Baixa";
            }
            else if (rbmedia.Checked)
            {
                obj.importancia = "Média";
            }
            else if (rbalta.Checked)
            {
                obj.importancia = "Alta";
            }

            TarefaDAO dao = new TarefaDAO();
            dao.editarTarefa(obj);

            dgtarefas.DataSource = dao.listarTarefas();

            txtid.Clear();
            txttitulo.Clear();
            txtassunto.Clear();

        }


        private void btndeletar_Click(object sender, EventArgs e)
        {
            Tarefa obj = new Tarefa();
            obj.id = int.Parse(txtid.Text);

            TarefaDAO dao = new TarefaDAO();
            dao.excluirTarefa(obj);

            dgtarefas.DataSource = dao.listarTarefas();

            txtid.Clear();
            txttitulo.Clear();
            txtassunto.Clear();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dgtarefas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgtarefas.CurrentRow.Cells[0].Value.ToString();
            txttitulo.Text = dgtarefas.CurrentRow.Cells[1].Value.ToString();
            txtassunto.Text = dgtarefas.CurrentRow.Cells[2].Value.ToString();
            dateTimeData.Text = dgtarefas.CurrentRow.Cells[3].Value.ToString();

            string tipoimpo = dgtarefas.CurrentRow.Cells[4].Value.ToString();

            if (tipoimpo.Equals("Baixa"))
            {
                rbbaixa.Checked = true;
            }

            else if (tipoimpo.Equals("Média"))
            {
                rbmedia.Checked = true;
            }
            else if (tipoimpo.Equals("Alta"))
            {
                rbalta.Checked = true;
            }

        }

        private void dgtarefas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
