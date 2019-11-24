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
    public partial class FormCadastroItemFormula : Form
    {
        List<MateriaPrima> listaMateria = new List<MateriaPrima>();
        List<Produto> listaProduto = new List<Produto>();

        public FormCadastroItemFormula()
        {
            InitializeComponent();
            ListarProdutoCombo();
            ListarMateriaCombo();
        }

        private void ListarProdutoCombo()
        {
            try
            {
                Service1 dados = new Service1();
                Produto filtro = new Produto();
                listaProduto = dados.SelectProduto(filtro).ToList();
                comboBoxProduto.Items.Clear();
                foreach (Produto p in listaProduto)
                {
                    comboBoxProduto.Items.Add(p.nome);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListarMateriaCombo()
        {
            try
            {
                Service1 dados = new Service1();
                MateriaPrima filtro = new MateriaPrima();
                listaMateria = dados.SelectMateriaPrima(filtro).ToList();
                comboBoxMateriaPrima.Items.Clear();
                foreach (MateriaPrima m in listaMateria)
                {
                    comboBoxMateriaPrima.Items.Add(m.nome);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                int indexProduto = comboBoxProduto.SelectedIndex;
                if (indexProduto < 0)
                {
                    MessageBox.Show("Selecionar o produto");
                    comboBoxProduto.Focus();
                    return;
                }

                int indexMateriaPrima = comboBoxMateriaPrima.SelectedIndex;
                if (indexMateriaPrima < 0)
                {
                    MessageBox.Show("Selecionar a matéria prima");
                    comboBoxMateriaPrima.Focus();
                    return;
                }

                MateriaPrima materiaPrima = listaMateria.ElementAt(indexMateriaPrima);
                materiaPrima.produto = new Produto[1];
                materiaPrima.produto[0] = listaProduto.ElementAt(indexProduto);

                Service1 dados = new Service1();
                dados.CadastrarItemFormula(materiaPrima);
                MessageBox.Show("Formula cadastrada com sucesso");

                comboBoxProduto.SelectedIndex = -1;
                comboBoxMateriaPrima.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
