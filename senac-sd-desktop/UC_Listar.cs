using System;
using System.Windows.Forms;

namespace senac_sd_desktop
{
    public partial class UC_Listar : UserControl
    {
        public UC_Listar()
        {
            InitializeComponent();
        }

        private void UC_Listar_Load(object sender, EventArgs e)
        {
            int counter = 1;

            foreach (var produto in FormSplash.getProdutos())
            {
                dataGridView.Rows.Add(produto.Id, counter, produto.Nome, produto.Preco, produto.Tipo, produto.Descricao);
                counter++;
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            textNome.Text = dataGridView.SelectedRows[0].Cells[2].Value.ToString();
            textPreco.Text = dataGridView.SelectedRows[0].Cells[3].Value.ToString();
            textTipo.Text = dataGridView.SelectedRows[0].Cells[4].Value.ToString();
            textDesc.Text = dataGridView.SelectedRows[0].Cells[5].Value.ToString();
            pictureBox.Load(FormSplash.getImagens()[(int)dataGridView.SelectedRows[0].Cells[1].Value - 1].URL);
        }
    }
}