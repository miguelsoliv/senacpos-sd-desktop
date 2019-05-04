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

using Firebase.Database;
using senac_sd_desktop.Classes;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace senac_sd_desktop
{
    public partial class Form1 : Form
    {
        private Button buttonSelected;
        private Color selectedButtonColor = Color.FromArgb(21, 101, 192);
        private Color normalButtonColor = Color.FromArgb(94, 146, 243);
        private UC_Pedidos uc_pedidos;
        private SoundPlayer player;
        private FirebaseClient firebaseClient;

        public Form1()
        {
            InitializeComponent();

            uc_pedidos = new UC_Pedidos();
            FormSplash formSplash = new FormSplash(this);
            formSplash.Show();

            player = new SoundPlayer();
            player.Stream = Properties.Resources.MGS_Alert;

            firebaseClient = new FirebaseClient("https://senacpos-sd.firebaseio.com/");
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;

            if (bt.BackColor == selectedButtonColor)
            {
                return;
            }

            Control c = null;

            switch (bt.Name)
            {
                case "btCadastrar":
                    c = new UC_Cadastrar();
                    break;
                case "btListar":
                    c = new UC_Listar();
                    break;
                case "btPedidos":
                    c = uc_pedidos;
                    break;
                case "btSobre":
                    break;
            }

            if (buttonSelected != null)
            {
                buttonSelected.BackColor = normalButtonColor;
                buttonSelected.ForeColor = Color.Black;
            }

            buttonSelected = bt;
            bt.BackColor = selectedButtonColor;
            bt.ForeColor = Color.White;

            if (c != null)
            {
                c.Dock = DockStyle.Fill;
                panelContent.Controls.Clear();
                panelContent.Controls.Add(c);
            }
        }

        private void btMinim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void splashClosed()
        {
            // Firebase registra toda a movimentação na "tabela" 'pedidos', incluindo exclusões
            firebaseClient.Child("pedidos").AsObservable<Pedido>().Subscribe(p =>
            {
                if (p.Object != null)
                {
                    bool check = false;

                    for (int i = 0; i < FormSplash.getPedidos().Count; i++)
                    {
                        if (FormSplash.getPedidos()[i].Id.Equals(p.Key))
                        {
                            check = true;
                            break;
                        }
                    }

                    if (btPedidos.BackColor != selectedButtonColor)
                    {
                        newPedido();
                    }

                    if (!check)
                    {
                        // Não adicionar o pedido que foi finalizado
                        if (FormSplash.getIdPedidoDeletado() != p.Key)
                        {
                            player.Play();
                            p.Object.Id = p.Key;
                            FormSplash.addPedido(p.Object);
                            uc_pedidos.addPedidoDataGrid(p.Object);
                        }
                    }
                }
            });
        }

        private void newPedido()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(this.newPedido));
            }
            else
            {
                if (buttonSelected != null)
                {
                    buttonSelected.BackColor = normalButtonColor;
                    buttonSelected.ForeColor = Color.Black;
                }

                buttonSelected = btPedidos;
                btPedidos.BackColor = selectedButtonColor;
                btPedidos.ForeColor = Color.White;

                uc_pedidos.Dock = DockStyle.Fill;
                panelContent.Controls.Clear();
                panelContent.Controls.Add(uc_pedidos);
            }
        }
    }
}