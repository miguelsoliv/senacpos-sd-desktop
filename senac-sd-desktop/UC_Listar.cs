using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Database;
using Firebase.Database.Query;
using senac_sd_desktop.Classes;

namespace senac_sd_desktop
{
    public partial class UC_Listar : UserControl
    {
        private FirebaseClient firebaseClient;

        public UC_Listar()
        {
            InitializeComponent();
            firebaseClient = new FirebaseClient("https://senacpos-sd.firebaseio.com/");
        }

        private async void UC_Listar_Load(object sender, EventArgs e)
        {
            var produtos = await firebaseClient.Child("produtos").OnceAsync<Produto>();

            List<FirebaseObject<Produto>> produtosLista = new List<FirebaseObject<Produto>>(produtos);
            produtosLista.Sort((x, y) => x.Object.Nome.CompareTo(y.Object.Nome));

            progressBar.Visible = false;
            dataGridView.Visible = true;
            int counter = 1;
            string precoFormatado;

            foreach (var produto in produtosLista)
            {
                precoFormatado = string.Format("{0:#.00}", Convert.ToDecimal(produto.Object.Preco));
                dataGridView.Rows.Add(produto.Key, counter, produto.Object.Nome, precoFormatado, produto.Object.Tipo, produto.Object.Descricao);
                counter++;
            }

            progressBar.Location = new System.Drawing.Point(134, 291);
            firebaseClient.Dispose();
        }

        private async void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView.Enabled = false;
            panelInfo.Visible = false;
            progressBar.Visible = true;

            textNome.Text = dataGridView.SelectedRows[0].Cells[2].Value.ToString();
            textPreco.Text = dataGridView.SelectedRows[0].Cells[3].Value.ToString();
            textTipo.Text = dataGridView.SelectedRows[0].Cells[4].Value.ToString();
            textDesc.Text = dataGridView.SelectedRows[0].Cells[5].Value.ToString();

            await Task.Run(async () =>
            {
                var url = await firebaseClient.Child("imagensUrl")
                    .Child(dataGridView.SelectedRows[0].Cells[0].Value.ToString())
                    .OnceAsync<Imagem>();

                foreach (var imagemUrl in url)
                {
                    pictureBox.Load(imagemUrl.Object.URL);
                }
            });

            progressBar.Visible = false;
            dataGridView.Enabled = true;
            panelInfo.Visible = true;
        }
    }
}