using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeparaFotos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void selecionarPastaButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();


            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                caminhoTextBox.Text = fbd.SelectedPath;
                processarButton.Enabled = true;
            }
        }

        public void AtualizarStatus(string mensagem)
        {
            infoTextBox.AppendText(mensagem);
            infoTextBox.AppendText(Environment.NewLine);
            infoTextBox.SelectionStart = infoTextBox.TextLength;
            infoTextBox.ScrollToCaret();
            infoTextBox.Refresh();
        }

        private void processarButton_Click(object sender, EventArgs e)
        {

            if (quantidadeFotosTextBox.Text != "")
            {
                try
                {

                    processarButton.Enabled = false;
                    quantidadeFotosTextBox.Enabled = false;
                    selecionarPastaButton.Enabled = false;
                    caminhoTextBox.Enabled = false;

                    AtualizarStatus($"Verificando a quantidade de fotos - {DateTime.Now}");
                    List<string> filesArquivos = Directory.GetFiles(caminhoTextBox.Text).ToList();

                    AtualizarStatus($"Criando pasta - {DateTime.Now}");
                    string folder = $"{caminhoTextBox.Text}\\fotosTrecho";
                    if (Directory.Exists(folder))
                    {
                        Directory.Delete(folder,true);
                        Directory.CreateDirectory(folder);
                    }
                    else 
                    {
                        Directory.CreateDirectory(folder);
                    }

                    AtualizarStatus($"Copiando Fotos - {DateTime.Now}");
                    int fotos = 0;
                    foreach (var item in filesArquivos)
                    {
                        FileInfo fileFoto = new FileInfo(item);
                        if (fotos != Convert.ToInt32(quantidadeFotosTextBox.Text))
                        {
                            File.Copy(item,$"{folder}\\{fileFoto.Name}",true);
                            fotos++;
                        }
                        else
                        {
                            fotos = 0;
                        }
                    }

                    processarButton.Enabled = true;
                    quantidadeFotosTextBox.Enabled = true;
                    selecionarPastaButton.Enabled = true;
                    caminhoTextBox.Enabled = true;

                    AtualizarStatus($"Fotos copiadas com sucesso - {DateTime.Now}");

                }
                catch (Exception ex)
                {
                    processarButton.Enabled = true;
                    quantidadeFotosTextBox.Enabled = true;
                    selecionarPastaButton.Enabled = true;
                    caminhoTextBox.Enabled = true;

                    AtualizarStatus($"Erro {ex.Message} - {DateTime.Now}");
                }
            }
            else
            {
                MessageBox.Show("Informe o intervalo da foto a ser deletada", "Atenção", MessageBoxButtons.OK);
            }

        }

        private void quantidadeFotosTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }
    }
}
