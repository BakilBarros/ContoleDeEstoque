
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
    public partial class FormCadastroFornecedor : Form
    {
        int operacao;
        int filtro;

        public FormCadastroFornecedor()
        {
            InitializeComponent();
            this.operacao = 0;
            buttonCadastraFornecedor.Text = "Cadastrar";
            this.Text = "Cadastro de Fornecedor";
        }

        public FormCadastroFornecedor(Fornecedor f)
        {
            InitializeComponent();
            textBoxCnpj.Text = f.cnpj;
            textBoxRazaoSocial.Text = f.razaoSocial;
            textBoxEmail.Text = f.email;
            textBoxTelefone.Text = f.telefone;
            textBoxCep.Text = f.cep;
            textBoxLogradouro.Text = f.logradouro;
            textBoxComplemento.Text = f.complemento;
            textBoxBairro.Text = f.bairro;
            textBoxCidade.Text = f.cidade;
            textBoxEstado.Text = f.estado;
            this.filtro = f.id;
            this.operacao = 1;
            buttonCadastraFornecedor.Text = "Atualizar";
            this.Text = "Atualização de Fornecedor";
        }

        private void buttonCadastraFornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                Fornecedor f = new Fornecedor();
                f.cnpj = textBoxCnpj.Text;
                f.razaoSocial = textBoxRazaoSocial.Text;
                f.email = textBoxEmail.Text;
                f.telefone = textBoxTelefone.Text;
                f.cep = textBoxCep.Text;
                f.logradouro = textBoxLogradouro.Text;
                f.complemento = textBoxComplemento.Text;
                f.bairro = textBoxBairro.Text;
                f.cidade = textBoxCidade.Text;
                f.estado = textBoxEstado.Text;



                Service1 dados = new Service1();
                if (this.operacao == 0)
                {
                    dados.InsertFornecedor(f);
                    MessageBox.Show("Fornecedor cadastrado com sucesso");
                }
                else
                {
                    f.id = this.filtro;
                    dados.UpdateFornecedor(f);
                    MessageBox.Show("Fornecedor alterado com sucesso");
                }

                textBoxCnpj.Clear();
                textBoxRazaoSocial.Clear();
                textBoxEmail.Clear();
                textBoxCep.Clear();
                textBoxTelefone.Clear();
                textBoxEstado.Clear();
                textBoxCidade.Clear();
                textBoxBairro.Clear();
                textBoxLogradouro.Clear();
                textBoxComplemento.Clear();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
