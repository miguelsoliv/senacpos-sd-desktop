/*
 * MIT License
 * 
 * Copyright (c) 2019 Miguel Soares de Oliveira
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
*/

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
            textPreco.Text = "R$ " + string.Format("{0:#.00}", Convert.ToDecimal(
                dataGridView.SelectedRows[0].Cells[3].Value.ToString()));
            textTipo.Text = dataGridView.SelectedRows[0].Cells[4].Value.ToString();
            textDesc.Text = dataGridView.SelectedRows[0].Cells[5].Value.ToString();
            pictureBox.Image = null;
            btCarregar.Visible = true;
        }

        private void btCarregar_Click(object sender, EventArgs e)
        {
            btCarregar.Visible = false;
            pictureBox.Load(FormSplash.getImagens()[(int)dataGridView.SelectedRows[0].Cells[1].Value - 1].URL);
        }
    }
}