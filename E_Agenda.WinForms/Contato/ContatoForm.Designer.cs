namespace E_Agenda.WinForms
{
    partial class ContatoForm
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
            this.listBoxContatos = new System.Windows.Forms.ListBox();
            this.buttonAdicionarContato = new System.Windows.Forms.Button();
            this.buttonEditarContato = new System.Windows.Forms.Button();
            this.buttonExcluirContato = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxContatos
            // 
            this.listBoxContatos.FormattingEnabled = true;
            this.listBoxContatos.ItemHeight = 25;
            this.listBoxContatos.Location = new System.Drawing.Point(157, 12);
            this.listBoxContatos.Name = "listBoxContatos";
            this.listBoxContatos.Size = new System.Drawing.Size(529, 479);
            this.listBoxContatos.TabIndex = 0;
            this.listBoxContatos.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonAdicionarContato
            // 
            this.buttonAdicionarContato.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdicionarContato.Location = new System.Drawing.Point(12, 12);
            this.buttonAdicionarContato.Name = "buttonAdicionarContato";
            this.buttonAdicionarContato.Size = new System.Drawing.Size(139, 94);
            this.buttonAdicionarContato.TabIndex = 1;
            this.buttonAdicionarContato.Text = "Adicionar Contato";
            this.buttonAdicionarContato.UseVisualStyleBackColor = false;
            // 
            // buttonEditarContato
            // 
            this.buttonEditarContato.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEditarContato.Location = new System.Drawing.Point(12, 112);
            this.buttonEditarContato.Name = "buttonEditarContato";
            this.buttonEditarContato.Size = new System.Drawing.Size(139, 94);
            this.buttonEditarContato.TabIndex = 2;
            this.buttonEditarContato.Text = "Editar Contato";
            this.buttonEditarContato.UseVisualStyleBackColor = false;
            this.buttonEditarContato.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonExcluirContato
            // 
            this.buttonExcluirContato.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonExcluirContato.Location = new System.Drawing.Point(12, 212);
            this.buttonExcluirContato.Name = "buttonExcluirContato";
            this.buttonExcluirContato.Size = new System.Drawing.Size(139, 94);
            this.buttonExcluirContato.TabIndex = 3;
            this.buttonExcluirContato.Text = "Excluir Contato";
            this.buttonExcluirContato.UseVisualStyleBackColor = false;
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVoltar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonVoltar.Location = new System.Drawing.Point(900, 463);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(121, 29);
            this.buttonVoltar.TabIndex = 9;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // ContatoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1033, 504);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonExcluirContato);
            this.Controls.Add(this.buttonEditarContato);
            this.Controls.Add(this.buttonAdicionarContato);
            this.Controls.Add(this.listBoxContatos);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ContatoForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Contatos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxContatos;
        private System.Windows.Forms.Button buttonAdicionarContato;
        private System.Windows.Forms.Button buttonEditarContato;
        private System.Windows.Forms.Button buttonExcluirContato;
        private System.Windows.Forms.Button buttonVoltar;
    }
}
