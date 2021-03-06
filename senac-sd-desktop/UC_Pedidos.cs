﻿/*
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

using Firebase.Database;
using Firebase.Database.Query;
using senac_sd_desktop.Classes;
using System;
using System.Windows.Forms;

namespace senac_sd_desktop
{
    public partial class UC_Pedidos : UserControl
    {
        private int counter = 1;
        private FirebaseClient firebaseClient;

        public UC_Pedidos()
        {
            InitializeComponent();

            firebaseClient = new FirebaseClient("https://senacpos-sd.firebaseio.com/");
        }

        private void UC_Pedidos_Load(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count > 0 || FormSplash.getPedidos().Count == 0)
            {
                return;
            }

            foreach (var pedido in FormSplash.getPedidos())
            {
                dataGridView.Rows.Add(pedido.Id, counter, pedido.Hora, pedido.Cliente, pedido.TelefoneCliente,
                    "Finalizar Pedido", pedido.Descricao, pedido.Endereco, pedido.FormaPagamento, pedido.Total);
                counter++;
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                textCliente.Text = "";
                textPedido.Text = "";
                textEndereco.Text = "";
                textFormaP.Text = "";
                textTotal.Text = "";
            }
            else
            {
                textCliente.Text = dataGridView.SelectedRows[0].Cells[4].Value.ToString() + " - " +
                dataGridView.SelectedRows[0].Cells[3].Value.ToString();
                textPedido.Text = dataGridView.SelectedRows[0].Cells[2].Value.ToString() + " - " +
                    dataGridView.SelectedRows[0].Cells[6].Value.ToString();
                textEndereco.Text = dataGridView.SelectedRows[0].Cells[7].Value.ToString();
                textFormaP.Text = dataGridView.SelectedRows[0].Cells[8].Value.ToString();
                textTotal.Text = "R$ " + string.Format("{0:#.00}", Convert.ToDecimal(
                    dataGridView.SelectedRows[0].Cells[9].Value.ToString()));
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (MessageBox.Show("Deseja finalizar o pedido?", "Confirmação", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    FormSplash.setIdPedidoDeletado(dataGridView.SelectedRows[0].Cells[0].Value.ToString());
                    FormSplash.removePedido(dataGridView.CurrentCell.RowIndex);
                    firebaseClient.Child("pedidos").Child(dataGridView.SelectedRows[0].Cells[0].Value.ToString()).DeleteAsync();
                    dataGridView.Rows.Remove(dataGridView.SelectedRows[0]);
                }
            }
        }

        public void addPedidoDataGrid(Pedido pedido)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    addPedidoDataGrid(pedido);
                });
                return;
            }

            dataGridView.Rows.Add(pedido.Id, counter, pedido.Hora, pedido.Cliente, pedido.TelefoneCliente,
                    "Finalizar Pedido", pedido.Descricao, pedido.Endereco, pedido.FormaPagamento, pedido.Total);
            counter++;
        }
    }
}