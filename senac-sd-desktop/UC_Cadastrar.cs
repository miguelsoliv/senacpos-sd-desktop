using Firebase.Database;
using Firebase.Database.Query;
using Firebase.Storage;
using senac_sd_desktop.Classes;
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

            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            string sep = string.Empty, codecName;

            foreach (var c in codecs)
            {
                codecName = c.CodecName.Substring(8).Replace("Codec", "Files").Trim();
                openFileDialog.Filter = string.Format("{0}{1}{2} ({3})|{3}", openFileDialog.Filter, sep, codecName, c.FilenameExtension);
                sep = "|";
            }

            openFileDialog.Filter = string.Format("{0}{1}{2} ({3})|{3}", openFileDialog.Filter, sep, "All Files", "*.*");
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
            produto.Preco = double.Parse(textPreco.Text.Replace('.', ','));

            progressBar.Visible = true;
            btCadastrar.Visible = false;
            textNome.Enabled = false;
            textPreco.Enabled = false;
            comboTipo.Enabled = false;
            textDesc.Enabled = false;
            btProcurar.Enabled = false;

            var prod = await firebaseClient.Child("produtos").PostAsync(produto);

            var stream = new MemoryStream();
            pictureBox.Image.Save(stream, ImageFormat.Png);
            stream.Position = 0;

            var prodImagem = await new FirebaseStorage("senacpos-sd.appspot.com").Child(prod.Key).PutAsync(stream);

            Imagem img = new Imagem();
            img.URL = prodImagem;

            await firebaseClient.Child("imagensUrl").Child(prod.Key).PostAsync(img);

            progressBar.Visible = false;
            btCadastrar.Visible = true;
            textNome.Enabled = true;
            textPreco.Enabled = true;
            comboTipo.Enabled = true;
            textDesc.Enabled = true;
            btProcurar.Enabled = true;

            textNome.Text = "";
            textPreco.Text = "";
            comboTipo.SelectedIndex = -1;
            textDesc.Text = "";
            pictureBox.Image = null;

            MessageBox.Show("Produto '" + produto.Nome + "' cadastrado com sucesso");
        }

        private void btProcurar_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileName != "")
                {
                    pictureBox.Load(openFileDialog.FileName);
                }
            }
        }
    }
}