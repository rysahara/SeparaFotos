
namespace SeparaFotos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selecionarPastaButton = new System.Windows.Forms.Button();
            this.caminhoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.processarButton = new System.Windows.Forms.Button();
            this.quantidadeFotosTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selecionarPastaButton);
            this.groupBox1.Controls.Add(this.caminhoTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pasta das Fotos";
            // 
            // selecionarPastaButton
            // 
            this.selecionarPastaButton.Location = new System.Drawing.Point(378, 22);
            this.selecionarPastaButton.Name = "selecionarPastaButton";
            this.selecionarPastaButton.Size = new System.Drawing.Size(81, 23);
            this.selecionarPastaButton.TabIndex = 2;
            this.selecionarPastaButton.Text = "Selecionar";
            this.selecionarPastaButton.UseVisualStyleBackColor = true;
            this.selecionarPastaButton.Click += new System.EventHandler(this.selecionarPastaButton_Click);
            // 
            // caminhoTextBox
            // 
            this.caminhoTextBox.Location = new System.Drawing.Point(6, 22);
            this.caminhoTextBox.Name = "caminhoTextBox";
            this.caminhoTextBox.Size = new System.Drawing.Size(366, 23);
            this.caminhoTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.processarButton);
            this.groupBox2.Controls.Add(this.quantidadeFotosTextBox);
            this.groupBox2.Location = new System.Drawing.Point(488, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 62);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Excluir a cada x Fotos";
            // 
            // processarButton
            // 
            this.processarButton.Location = new System.Drawing.Point(111, 16);
            this.processarButton.Name = "processarButton";
            this.processarButton.Size = new System.Drawing.Size(117, 35);
            this.processarButton.TabIndex = 1;
            this.processarButton.Text = "Processar";
            this.processarButton.UseVisualStyleBackColor = true;
            this.processarButton.Click += new System.EventHandler(this.processarButton_Click);
            // 
            // quantidadeFotosTextBox
            // 
            this.quantidadeFotosTextBox.Location = new System.Drawing.Point(16, 23);
            this.quantidadeFotosTextBox.Name = "quantidadeFotosTextBox";
            this.quantidadeFotosTextBox.Size = new System.Drawing.Size(77, 23);
            this.quantidadeFotosTextBox.TabIndex = 0;
            this.quantidadeFotosTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantidadeFotosTextBox_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.infoTextBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 369);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informações de Processamento";
            // 
            // infoTextBox
            // 
            this.infoTextBox.Location = new System.Drawing.Point(6, 22);
            this.infoTextBox.Multiline = true;
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.infoTextBox.Size = new System.Drawing.Size(764, 341);
            this.infoTextBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 464);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Separar Fotos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button selecionarPastaButton;
        private System.Windows.Forms.TextBox caminhoTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button processarButton;
        private System.Windows.Forms.TextBox quantidadeFotosTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox infoTextBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

