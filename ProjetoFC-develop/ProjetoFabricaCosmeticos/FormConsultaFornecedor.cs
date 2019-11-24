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
    public partial class FormConsultaFornecedor : Form
    {
        List<Fornecedor> listaFornecedor = new List<Fornecedor>();

        public FormConsultaFornecedor()
        {
            InitializeComponent();
        }

        private void AlterarFornecedor()
        {
            try
            {
                if (listViewFornecedor.FocusedItem != null)
                {
                    int posicao = listViewFornecedor.FocusedItem.Index;
                    Fornecedor fornecedorSelecionado = this.listaFornecedor.ElementAt(posicao);
                    FormCadastroFornecedor form = new FormCadastroFornecedor(fornecedorSelecionado);
                    form.ShowDialog();
                    listViewFornecedor.Items.Clear();
                }
                else
                {
                    MessageBox.Show(" Favor selecionar o Fornecedor");
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
                Fornecedor filtro = new Fornecedor();
                if (textBoxCnpj.Text.Trim().Equals("") == false)
                {
                    filtro.cnpj = textBoxCnpj.Text.Trim();
                }
                filtro.razaoSocial = textBoxRazaoSocial.Text;
                listaFornecedor = dados.SelectFornecedor(filtro).ToList();
                listViewFornecedor.Items.Clear();
                foreach (Fornecedor a in listaFornecedor)
                {
                    ListViewItem linha = listViewFornecedor.Items.Add(a.id.ToString());
                    linha.SubItems.Add(a.cnpj);
                    linha.SubItems.Add(a.razaoSocial);
                    linha.SubItems.Add(a.logradouro);
                    linha.SubItems.Add(a.complemento);
                    linha.SubItems.Add(a.bairro);
                    linha.SubItems.Add(a.cidade);
                    linha.SubItems.Add(a.estado);
                    linha.SubItems.Add(a.cep);
                    linha.SubItems.Add(a.email);
                    linha.SubItems.Add(a.telefone);
                }

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            AlterarFornecedor();
        }
        private void listViewsFornecedor_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AlterarFornecedor();
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewFornecedor.FocusedItem != null)
                {
                    int posicao = listViewFornecedor.FocusedItem.Index;
                    Fornecedor fornecedorSelecionado = this.listaFornecedor.ElementAt(posicao);
                    Service1 dados = new Service1();
                    dados.DeleteFornecedor(fornecedorSelecionado);
                    listViewFornecedor.Items.Clear();
                    MessageBox.Show("Fornecedor removido com sucesso");

                }
                else
                {
                    MessageBox.Show(" Favor selecionar o Fornecedor");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
