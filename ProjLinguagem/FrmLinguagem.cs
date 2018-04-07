using Controle;
using Entidade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjLinguagem
{
    public partial class FrmLinguagem : Form
    {
        public FrmLinguagem()
        {
            InitializeComponent();
        }

        private void linguagemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Linguagem linguagem = new Linguagem();
            linguagem.Id = Convert.ToInt32(txtId.Text);
            linguagem.Nome = txtNome.Text;
            linguagem.Pontuacao = Convert.ToInt32(txtPontuacao.Text);

            // MessageBox.Show("Olaaa!! \n ID: " + tipo.Id + "\n Descricao: " +tipo.Descricao); //exibe esta mensagem quando clica no botão

            // MessageBox.Show("Olaaa!! " + tipo);

            if (new LinguagemDB().insert(linguagem))
            {

                MessageBox.Show("Registro Inserido!");
                CarregarGrid();

            }
            else
            {

                MessageBox.Show("Erro ao inserir registro!");

            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmLinguagem_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            dgLinguagem.DataSource = new LinguagemDB().ListarLinguagem();
        }
    }
}
