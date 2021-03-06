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
using System.Collections.Generic;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace senac_sd_desktop
{
    public partial class FormSplash : Form
    {
        private static string idPedidoDeletado;
        private SoundPlayer player;
        private Form1 form;
        private static List<Produto> produtosLista;
        private static List<Imagem> imagensLista;
        private static List<Pedido> pedidosLista;

        public FormSplash(Form1 form)
        {
            InitializeComponent();

            this.form = form;
            produtosLista = new List<Produto>();
            imagensLista = new List<Imagem>();
            pedidosLista = new List<Pedido>();

            player = new SoundPlayer();
            player.Stream = Properties.Resources.MGS_Alert;
        }

        private async void FormSplash_Load(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                FirebaseClient firebaseClient = new FirebaseClient("https://senacpos-sd.firebaseio.com/");

                var produtos = await firebaseClient.Child("produtos").OnceAsync<Produto>();

                foreach (var prod in produtos)
                {
                    prod.Object.Id = prod.Key;
                    produtosLista.Add(prod.Object);

                    var imagens = await firebaseClient.Child("imagensUrl").Child(prod.Key).OnceAsync<Imagem>();

                    foreach (var img in imagens)
                    {
                        imagensLista.Add(img.Object);
                    }
                }

                var pedidos = await firebaseClient.Child("pedidos").OnceAsync<Pedido>();

                if (pedidos.Count > 0)
                {
                    player.Play();
                }

                foreach (var pedido in pedidos)
                {
                    pedido.Object.Id = pedido.Key;
                    pedidosLista.Add(pedido.Object);
                }
            });

            form.Opacity = 100;
            form.ShowInTaskbar = true;
            form.splashClosed();
            this.Close();
        }

        public static List<Produto> getProdutos()
        {
            return produtosLista;
        }

        public static void addProduto(Produto prod)
        {
            produtosLista.Add(prod);
        }

        public static List<Imagem> getImagens()
        {
            return imagensLista;
        }

        public static void addImagem(Imagem img)
        {
            imagensLista.Add(img);
        }

        public static List<Pedido> getPedidos()
        {
            return pedidosLista;
        }

        public static void addPedido(Pedido pedido)
        {
            pedidosLista.Add(pedido);
        }

        public static void removePedido(int index)
        {
            pedidosLista.RemoveAt(index);
        }

        public static string getIdPedidoDeletado()
        {
            return idPedidoDeletado;
        }

        public static void setIdPedidoDeletado(string id)
        {
            idPedidoDeletado = id;
        }
    }
}