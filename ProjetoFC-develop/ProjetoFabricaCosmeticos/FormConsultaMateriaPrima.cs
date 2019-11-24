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
    public partial class FormConsultaMateriaPrima : Form
    {
        List<MateriaPrima> listaMateriaPrima = new List<MateriaPrima>();

        public FormConsultaMateriaPrima()
        {
            InitializeComponent();
        }
        
        private void AlterarMateriaPrima()
        {
            try
            {
                if (listViewMateriaPrima.FocusedItem != null)
                {
                    int posicao = listViewMateriaPrima.FocusedItem.Index;
                    MateriaPrima materiaprimaSelecionada = this.listaMateriaPrima.ElementAt(posicao);
                    FormCadastroMateriaPrima form = new FormCadastroMateriaPrima(materiaprimaSelecionada);
                    form.ShowDialog();
                    listViewMateriaPrima.Items.Clear();
                }
                else
                {
                    MessageBox.Show("Favor selecionar a materia prima");
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
                MateriaPrima filtro = new MateriaPrima();
                if (textBoxNome.Text.Trim().Equals("") == false)
                {
                    filtro.nome = textBoxNome.Text.Trim();
                }
                filtro.descricao = textBoxDescricao.Text;
                listaMateriaPrima = dados.SelectMateriaPrima(filtro).ToList();
                listViewMateriaPrima.Items.Clear();
                foreach (MateriaPrima m in listaMateriaPrima)
                {
                    ListViewItem linha = listViewMateriaPrima.Items.Add(m.id.ToString());
                    linha.SubItems.Add(m.nome);
                    linha.SubItems.Add(m.descricao);
                    linha.SubItems.Add(m.lote);
                    linha.SubItems.Add(Convert.ToString(m.validade));
                    linha.SubItems.Add(Convert.ToString(m.estoqueAtual));
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            AlterarMateriaPrima();
        }

        private void listViewMateriaPrima_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AlterarMateriaPrima();
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewMateriaPrima.FocusedItem != null)
                {
                    int posicao = listViewMateriaPrima.FocusedItem.Index;
                    MateriaPrima materiaprimaSelecionada = this.listaMateriaPrima.ElementAt(posicao);
                    Service1 dados = new Service1();
                    dados.DeleteMateriaPrima(materiaprimaSelecionada);
                    listViewMateriaPrima.Items.Clear();
                    MessageBox.Show("Materia prima removida com sucesso");

                }
                else
                {
                    MessageBox.Show(" Favor selecionar a materia prima");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
