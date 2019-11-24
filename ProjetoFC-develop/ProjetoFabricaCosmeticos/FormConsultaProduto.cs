using ProjetoFabricaCosmeticos.localhost;
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
    public partial class FormConsultaProduto : Form
    {
        List<Produto> listaProduto = new List<Produto>();

        public FormConsultaProduto()
        {
            InitializeComponent();
        }

        private void AlterarProduto()
        {
            try
            {
                if (listViewProduto.FocusedItem != null)
                {
                    int posicao = listViewProduto.FocusedItem.Index;
                    Produto produtoSelecionado = this.listaProduto.ElementAt(posicao);
                    FormCadastroProduto form = new FormCadastroProduto(produtoSelecionado);
                    form.ShowDialog();
                    listViewProduto.Items.Clear();
                }
                else
                {
                    MessageBox.Show(" Favor selecionar o produto");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {

            try
            {
                Service1 dados = new Service1();
                Produto filtro = new Produto();

                if (textBoxId.Text.Trim().Equals("") == false)
                {
                    filtro.id = Int32.Parse(textBoxId.Text.Trim());
                }
                filtro.nome = textBoxNome.Text;
                listaProduto = dados.SelectProduto(filtro).ToList();

                listViewProduto.Items.Clear();
                foreach (Produto p in listaProduto)
                {
                    ListViewItem linha = listViewProduto.Items.Add(p.id.ToString());
                    linha.SubItems.Add(p.nome);
                    linha.SubItems.Add(p.unidadeFornecimento);
                    linha.SubItems.Add(p.descricao);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            AlterarProduto();
        }

        private void listViewProduto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AlterarProduto();
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewProduto.FocusedItem != null)
                {
                    int posicao = listViewProduto.FocusedItem.Index;
                    Produto produtoSelecionado = this.listaProduto.ElementAt(posicao);

                    Service1 dados = new Service1();
                    dados.DeleteProduto(produtoSelecionado);

                    listViewProduto.Items.Clear();
                    MessageBox.Show("Produto removido com sucesso");
                }
                else
                {
                    MessageBox.Show("Favor selecionar o produto");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
