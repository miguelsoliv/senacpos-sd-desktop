using Firebase.Database;
using Firebase.Database.Query;
using senac_sd_desktop.Classes;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace senac_sd_desktop
{
    public partial class FormSplash : Form
    {
        private static string idPedidoDeletado;
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