namespace ControleEstoque
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
            txtNome = new TextBox();
            txtQuantidade = new TextBox();
            txtPreco = new TextBox();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(55, 37);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(336, 27);
            txtNome.TabIndex = 0;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(55, 89);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.PlaceholderText = "Quantidade";
            txtQuantidade.Size = new Size(336, 27);
            txtQuantidade.TabIndex = 1;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(55, 148);
            txtPreco.Name = "txtPreco";
            txtPreco.PlaceholderText = "Preço";
            txtPreco.Size = new Size(336, 27);
            txtPreco.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPreco);
            Controls.Add(txtQuantidade);
            Controls.Add(txtNome);
            Name = "Form1";
            Text = "Controle de Estoque";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtQuantidade;
        private TextBox txtPreco;
    }
}
