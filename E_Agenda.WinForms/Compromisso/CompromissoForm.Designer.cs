namespace E_Agenda.WinForms
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
            this.listBoxCompromisso = new System.Windows.Forms.ListBox();
            this.buttonAdicionarCompromisso = new System.Windows.Forms.Button();
            this.buttonEditarCompromisso = new System.Windows.Forms.Button();
            this.buttonExcluirContato = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxCompromisso
            // 
            this.listBoxCompromisso.FormattingEnabled = true;
            this.listBoxCompromisso.ItemHeight = 25;
            this.listBoxCompromisso.Location = new System.Drawing.Point(0, 0);
            this.listBoxCompromisso.Name = "listBoxCompromisso";
            this.listBoxCompromisso.Size = new System.Drawing.Size(596, 404);
            this.listBoxCompromisso.TabIndex = 0;
            this.listBoxCompromisso.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonAdicionarCompromisso
            // 
            this.buttonAdicionarCompromisso.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdicionarCompromisso.Location = new System.Drawing.Point(12, 12);
            this.buttonAdicionarCompromisso.Name = "buttonAdicionarCompromisso";
            this.buttonAdicionarCompromisso.Size = new System.Drawing.Size(139, 94);
            this.buttonAdicionarCompromisso.TabIndex = 1;
            this.buttonAdicionarCompromisso.Text = "Adicionar Compromisso";
            this.buttonAdicionarCompromisso.UseVisualStyleBackColor = false;
            // 
            // buttonEditarCompromisso
            // 
            this.buttonEditarCompromisso.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEditarCompromisso.Location = new System.Drawing.Point(241, 12);
            this.buttonEditarCompromisso.Name = "buttonEditarCompromisso";
            this.buttonEditarCompromisso.Size = new System.Drawing.Size(139, 94);
            this.buttonEditarCompromisso.TabIndex = 2;
            this.buttonEditarCompromisso.Text = "Editar Compromisso";
            this.buttonEditarCompromisso.UseVisualStyleBackColor = false;
            this.buttonEditarCompromisso.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonExcluirContato
            // 
            this.buttonExcluirContato.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonExcluirContato.Location = new System.Drawing.Point(469, 12);
            this.buttonExcluirContato.Name = "buttonExcluirContato";
            this.buttonExcluirContato.Size = new System.Drawing.Size(139, 94);
            this.buttonExcluirContato.TabIndex = 3;
            this.buttonExcluirContato.Text = "Excluir Compromisso";
            this.buttonExcluirContato.UseVisualStyleBackColor = false;
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
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.buttonFiltrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.listBoxCompromisso);
            this.panel1.Location = new System.Drawing.Point(12, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 369);
            this.panel1.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Completos",
            "Incompletos"});
            this.comboBox2.Location = new System.Drawing.Point(602, 148);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(184, 33);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.Location = new System.Drawing.Point(647, 329);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(94, 29);
            this.buttonFiltrar.TabIndex = 3;
            this.buttonFiltrar.Text = "Filtrar";
            this.buttonFiltrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(602, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Visualiza por :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Por dia",
            "Por mês",
            "Por Ano"});
            this.comboBox1.Location = new System.Drawing.Point(602, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 33);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CompromissoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1033, 504);
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
            this.Load += new System.EventHandler(this.Compromisso_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCompromisso;
        private System.Windows.Forms.Button buttonAdicionarCompromisso;
        private System.Windows.Forms.Button buttonEditarCompromisso;
        private System.Windows.Forms.Button buttonExcluirContato;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}