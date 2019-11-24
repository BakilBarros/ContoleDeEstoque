using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFabricaCosmeticos
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroFornecedor form = new FormCadastroFornecedor();
            form.ShowDialog();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaFornecedor formc = new FormConsultaFornecedor();
            formc.Show();
        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCadastroProduto form = new FormCadastroProduto();
            form.ShowDialog();
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormConsultaProduto form = new FormConsultaProduto();
            form.Show();
        }

        private void cadastroToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormCadastroMateriaPrima form = new FormCadastroMateriaPrima();
            form.ShowDialog();
        }
        private void cadastroToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormConsultaMateriaPrima form = new FormConsultaMateriaPrima();
            form.ShowDialog();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroFormula form = new FormCadastroFormula();
            form.ShowDialog();
        }

        private void cadastrarItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroItemFormula form = new FormCadastroItemFormula();
            form.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaFormula form = new FormConsultaFormula();
            form.Show();
        }

        private void cadastroToolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            FormCadastroCompra form = new FormCadastroCompra();
            form.Show();
        }

        private void consultaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormConsultaCompra form = new FormConsultaCompra();
            form.Show();
        }
    }
}
