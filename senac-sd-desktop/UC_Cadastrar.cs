using Firebase.Database;
using Firebase.Database.Query;
using Firebase.Storage;
using System;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace senac_sd_desktop
{
    public partial class UC_Cadastrar : UserControl
    {
        public UC_Cadastrar()
        {
            InitializeComponent();
        }

        private async void btCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textNome.Text))
            {
                MessageBox.Show("Nome inválido");
                return;
            }

            if (string.IsNullOrEmpty(textPreco.Text))
            {
                MessageBox.Show("Preço inválido");
                return;
            }

            try
            {
                if (double.Parse(textPreco.Text) <= 0)
                {
                    MessageBox.Show("Preço inválido");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Preço inválido");
                return;
            }

            if (comboTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Tipo inválido");
                return;
            }

            if (string.IsNullOrEmpty(textDesc.Text))
            {
                MessageBox.Show("Descrição inválida");
                return;
            }

            if (pictureBox.Image == null)
            {
                MessageBox.Show("Imagem inválida");
                return;
            }

            var firebaseClient = new FirebaseClient("https://senacpos-sd.firebaseio.com/");

            Produto produto = new Produto();
            produto.Nome = textNome.Text.Trim();
            produto.Descricao = textDesc.Text.Trim();
            produto.Tipo = comboTipo.Text.Trim();
            produto.Preco = double.Parse(textPreco.Text);

            progressBar.Visible = true;
            btCadastrar.Visible = false;
            textNome.Enabled = false;
            textPreco.Enabled = false;
            comboTipo.Enabled = false;
            textDesc.Enabled = false;
            btProcurar.Enabled = false;

            var prod = await firebaseClient.Child("produtos").Child(produto.Tipo).PostAsync(produto);

            var stream = new MemoryStream();
            pictureBox.Image.Save(stream, ImageFormat.Png);
            stream.Position = 0;

            var task = new FirebaseStorage("senacpos-sd.appspot.com").Child(prod.Key).PutAsync(stream);

            await task;

            MessageBox.Show("Produto cadastrado com sucesso");

            progressBar.Visible = false;
            btCadastrar.Visible = true;
            textNome.Enabled = true;
            textPreco.Enabled = true;
            comboTipo.Enabled = true;
            textDesc.Enabled = true;
            btProcurar.Enabled = true;
        }

        private void btProcurar_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != "")
            {
                pictureBox.Load(openFileDialog.FileName);
            }
        }
    }
}