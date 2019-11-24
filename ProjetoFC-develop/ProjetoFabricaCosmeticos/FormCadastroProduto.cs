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
    public partial class FormCadastroProduto : Form
    {
        int operacao;
        int filtro;

        public FormCadastroProduto()
        {
            InitializeComponent();
            this.operacao = 0;
            buttonCadastrar.Text = "Cadastrar";
            this.Text = "Cadastro de Produto";
        }

        public FormCadastroProduto(Produto p)
        {
            InitializeComponent();
            textBoxNome.Text = p.nome;
            textBoxUnidadeFornecimento.Text = p.unidadeFornecimento;
            textBoxDescricao.Text = p.descricao;
            this.filtro = p.id;
            this.operacao = 1;
            buttonCadastrar.Text = "Atualizar";
            this.Text = "Atualização de Produto";
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Produto p = new Produto();
                p.nome = textBoxNome.Text;
                p.unidadeFornecimento = textBoxUnidadeFornecimento.Text;
                p.descricao = textBoxDescricao.Text;

                Service1 dados = new Service1();
                if (this.operacao == 0)
                {
                    dados.InsertProduto(p);
                    MessageBox.Show("Produto cadastrado com sucesso");
                }
                else
                {
                    p.id = this.filtro;
                    dados.UpdateProduto(p);
                    MessageBox.Show("Produto alterado com sucesso");
                }
                 
                textBoxNome.Clear();
                textBoxUnidadeFornecimento.Clear();
                textBoxDescricao.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
