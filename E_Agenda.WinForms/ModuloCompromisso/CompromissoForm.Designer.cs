namespace E_Agenda.WinForms.ModuloCompromisso
{
    partial class CompromissoForm
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
            this.listBoxCompromissoFuturos = new System.Windows.Forms.ListBox();
            this.buttonAdicionarCompromisso = new System.Windows.Forms.Button();
            this.buttonEditarCompromisso = new System.Windows.Forms.Button();
            this.buttonExcluirContato = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.maskedTextBoxDataFinal = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxDataInicial = new System.Windows.Forms.MaskedTextBox();
            this.DataInicial = new System.Windows.Forms.Label();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.tabControlCompromissoPassado = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxCompromissospassados = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControlCompromissoPassado.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxCompromissoFuturos
            // 
            this.listBoxCompromissoFuturos.FormattingEnabled = true;
            this.listBoxCompromissoFuturos.ItemHeight = 25;
            this.listBoxCompromissoFuturos.Location = new System.Drawing.Point(-1, -2);
            this.listBoxCompromissoFuturos.Name = "listBoxCompromissoFuturos";
            this.listBoxCompromissoFuturos.Size = new System.Drawing.Size(602, 354);
            this.listBoxCompromissoFuturos.TabIndex = 0;
            // 
            // buttonAdicionarCompromisso
            // 
            this.buttonAdicionarCompromisso.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdicionarCompromisso.Location = new System.Drawing.Point(12, 12);
            this.buttonAdicionarCompromisso.Name = "buttonAdicionarCompromisso";
            this.buttonAdicionarCompromisso.Size = new System.Drawing.Size(188, 73);
            this.buttonAdicionarCompromisso.TabIndex = 1;
            this.buttonAdicionarCompromisso.Text = "Adicionar Compromisso";
            this.buttonAdicionarCompromisso.UseVisualStyleBackColor = false;
            this.buttonAdicionarCompromisso.Click += new System.EventHandler(this.buttonAdicionarCompromisso_Click);
            // 
            // buttonEditarCompromisso
            // 
            this.buttonEditarCompromisso.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEditarCompromisso.Location = new System.Drawing.Point(206, 12);
            this.buttonEditarCompromisso.Name = "buttonEditarCompromisso";
            this.buttonEditarCompromisso.Size = new System.Drawing.Size(188, 73);
            this.buttonEditarCompromisso.TabIndex = 2;
            this.buttonEditarCompromisso.Text = "Editar Compromisso";
            this.buttonEditarCompromisso.UseVisualStyleBackColor = false;
            this.buttonEditarCompromisso.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonExcluirContato
            // 
            this.buttonExcluirContato.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonExcluirContato.Location = new System.Drawing.Point(400, 12);
            this.buttonExcluirContato.Name = "buttonExcluirContato";
            this.buttonExcluirContato.Size = new System.Drawing.Size(188, 73);
            this.buttonExcluirContato.TabIndex = 3;
            this.buttonExcluirContato.Text = "Excluir Compromisso";
            this.buttonExcluirContato.UseVisualStyleBackColor = false;
            this.buttonExcluirContato.Click += new System.EventHandler(this.buttonExcluirCompromisso_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(900, 463);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(121, 29);
            this.buttonVoltar.TabIndex = 9;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.maskedTextBoxDataFinal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.maskedTextBoxDataInicial);
            this.panel1.Controls.Add(this.DataInicial);
            this.panel1.Controls.Add(this.buttonFiltrar);
            this.panel1.Location = new System.Drawing.Point(12, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 369);
            this.panel1.TabIndex = 10;
            // 
            // maskedTextBoxDataFinal
            // 
            this.maskedTextBoxDataFinal.Location = new System.Drawing.Point(616, 186);
            this.maskedTextBoxDataFinal.Mask = "00/00/0000";
            this.maskedTextBoxDataFinal.Name = "maskedTextBoxDataFinal";
            this.maskedTextBoxDataFinal.Size = new System.Drawing.Size(125, 31);
            this.maskedTextBoxDataFinal.TabIndex = 7;
            this.maskedTextBoxDataFinal.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(611, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Data Final";
            // 
            // maskedTextBoxDataInicial
            // 
            this.maskedTextBoxDataInicial.Location = new System.Drawing.Point(616, 46);
            this.maskedTextBoxDataInicial.Mask = "00/00/0000";
            this.maskedTextBoxDataInicial.Name = "maskedTextBoxDataInicial";
            this.maskedTextBoxDataInicial.Size = new System.Drawing.Size(125, 31);
            this.maskedTextBoxDataInicial.TabIndex = 5;
            this.maskedTextBoxDataInicial.ValidatingType = typeof(System.DateTime);
            // 
            // DataInicial
            // 
            this.DataInicial.AutoSize = true;
            this.DataInicial.Location = new System.Drawing.Point(611, 18);
            this.DataInicial.Name = "DataInicial";
            this.DataInicial.Size = new System.Drawing.Size(103, 25);
            this.DataInicial.TabIndex = 4;
            this.DataInicial.Text = "Data Inicial";
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.Location = new System.Drawing.Point(647, 329);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(94, 29);
            this.buttonFiltrar.TabIndex = 3;
            this.buttonFiltrar.Text = "Filtrar";
            this.buttonFiltrar.UseVisualStyleBackColor = true;
            this.buttonFiltrar.Click += new System.EventHandler(this.buttonFiltrar_Click);
            // 
            // tabControlCompromissoPassado
            // 
            this.tabControlCompromissoPassado.Controls.Add(this.tabPage1);
            this.tabControlCompromissoPassado.Controls.Add(this.tabPage2);
            this.tabControlCompromissoPassado.Location = new System.Drawing.Point(12, 102);
            this.tabControlCompromissoPassado.Name = "tabControlCompromissoPassado";
            this.tabControlCompromissoPassado.SelectedIndex = 0;
            this.tabControlCompromissoPassado.Size = new System.Drawing.Size(610, 401);
            this.tabControlCompromissoPassado.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBoxCompromissoFuturos);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(602, 363);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Compromissos futuros";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxCompromissospassados);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(602, 363);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Compromissos passados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxCompromissospassados
            // 
            this.listBoxCompromissospassados.FormattingEnabled = true;
            this.listBoxCompromissospassados.ItemHeight = 25;
            this.listBoxCompromissospassados.Location = new System.Drawing.Point(0, 1);
            this.listBoxCompromissospassados.Name = "listBoxCompromissospassados";
            this.listBoxCompromissospassados.Size = new System.Drawing.Size(602, 354);
            this.listBoxCompromissospassados.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(594, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 73);
            this.button1.TabIndex = 12;
            this.button1.Text = "Carregar todos os Compromissos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonVisualizarTodas_Click);
            // 
            // CompromissoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1033, 504);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControlCompromissoPassado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonExcluirContato);
            this.Controls.Add(this.buttonEditarCompromisso);
            this.Controls.Add(this.buttonAdicionarCompromisso);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CompromissoForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compromisso";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControlCompromissoPassado.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCompromissoFuturos;
        private System.Windows.Forms.Button buttonAdicionarCompromisso;
        private System.Windows.Forms.Button buttonEditarCompromisso;
        private System.Windows.Forms.Button buttonExcluirContato;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataInicial;
        private System.Windows.Forms.Label DataInicial;
        private System.Windows.Forms.TabControl tabControlCompromissoPassado;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBoxCompromissospassados;
        private System.Windows.Forms.Button button1;
    }
}