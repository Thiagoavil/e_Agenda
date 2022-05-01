namespace E_Agenda.WinForms
{
    partial class TarefaForm
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
            this.listBoxTarefaConcluida = new System.Windows.Forms.ListBox();
            this.buttonAdicionarTarefa = new System.Windows.Forms.Button();
            this.buttonEditarTarefa = new System.Windows.Forms.Button();
            this.buttonExcluirTarefa = new System.Windows.Forms.Button();
            this.buttonMarcarItems = new System.Windows.Forms.Button();
            this.buttonAdicionarItems = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxTarefaIncompletas = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxTarefaConcluida
            // 
            this.listBoxTarefaConcluida.FormattingEnabled = true;
            this.listBoxTarefaConcluida.ItemHeight = 25;
            this.listBoxTarefaConcluida.Location = new System.Drawing.Point(0, 0);
            this.listBoxTarefaConcluida.Name = "listBoxTarefaConcluida";
            this.listBoxTarefaConcluida.Size = new System.Drawing.Size(459, 429);
            this.listBoxTarefaConcluida.TabIndex = 0;
            // 
            // buttonAdicionarTarefa
            // 
            this.buttonAdicionarTarefa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdicionarTarefa.Location = new System.Drawing.Point(12, 12);
            this.buttonAdicionarTarefa.Name = "buttonAdicionarTarefa";
            this.buttonAdicionarTarefa.Size = new System.Drawing.Size(213, 80);
            this.buttonAdicionarTarefa.TabIndex = 1;
            this.buttonAdicionarTarefa.Text = "Adicionar Tarefa";
            this.buttonAdicionarTarefa.UseVisualStyleBackColor = false;
            this.buttonAdicionarTarefa.Click += new System.EventHandler(this.btnAdicionarTarefa_Click);
            // 
            // buttonEditarTarefa
            // 
            this.buttonEditarTarefa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEditarTarefa.Location = new System.Drawing.Point(12, 112);
            this.buttonEditarTarefa.Name = "buttonEditarTarefa";
            this.buttonEditarTarefa.Size = new System.Drawing.Size(213, 80);
            this.buttonEditarTarefa.TabIndex = 2;
            this.buttonEditarTarefa.Text = "Editar Tarefa";
            this.buttonEditarTarefa.UseVisualStyleBackColor = false;
            this.buttonEditarTarefa.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // buttonExcluirTarefa
            // 
            this.buttonExcluirTarefa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonExcluirTarefa.Location = new System.Drawing.Point(12, 212);
            this.buttonExcluirTarefa.Name = "buttonExcluirTarefa";
            this.buttonExcluirTarefa.Size = new System.Drawing.Size(213, 80);
            this.buttonExcluirTarefa.TabIndex = 3;
            this.buttonExcluirTarefa.Text = "Excluir Tarefa";
            this.buttonExcluirTarefa.UseVisualStyleBackColor = false;
            this.buttonExcluirTarefa.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonMarcarItems
            // 
            this.buttonMarcarItems.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMarcarItems.Location = new System.Drawing.Point(12, 412);
            this.buttonMarcarItems.Name = "buttonMarcarItems";
            this.buttonMarcarItems.Size = new System.Drawing.Size(213, 80);
            this.buttonMarcarItems.TabIndex = 7;
            this.buttonMarcarItems.Text = "Marcar/Desmarcar items";
            this.buttonMarcarItems.UseVisualStyleBackColor = false;
            // 
            // buttonAdicionarItems
            // 
            this.buttonAdicionarItems.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdicionarItems.Location = new System.Drawing.Point(12, 312);
            this.buttonAdicionarItems.Name = "buttonAdicionarItems";
            this.buttonAdicionarItems.Size = new System.Drawing.Size(213, 80);
            this.buttonAdicionarItems.TabIndex = 6;
            this.buttonAdicionarItems.Text = "Adicionar items";
            this.buttonAdicionarItems.UseVisualStyleBackColor = false;
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(900, 463);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(121, 29);
            this.buttonVoltar.TabIndex = 8;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleName = "";
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(257, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(467, 468);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBoxTarefaConcluida);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(459, 430);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Concluidas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxTarefaIncompletas);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(459, 430);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Incompletas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxTarefaIncompletas
            // 
            this.listBoxTarefaIncompletas.FormattingEnabled = true;
            this.listBoxTarefaIncompletas.ItemHeight = 25;
            this.listBoxTarefaIncompletas.Location = new System.Drawing.Point(0, 1);
            this.listBoxTarefaIncompletas.Name = "listBoxTarefaIncompletas";
            this.listBoxTarefaIncompletas.Size = new System.Drawing.Size(459, 429);
            this.listBoxTarefaIncompletas.TabIndex = 1;
            this.listBoxTarefaIncompletas.SelectedIndexChanged += new System.EventHandler(this.listBoxTarefaIncompletas_SelectedIndexChanged);
            // 
            // TarefaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1033, 504);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonMarcarItems);
            this.Controls.Add(this.buttonAdicionarItems);
            this.Controls.Add(this.buttonExcluirTarefa);
            this.Controls.Add(this.buttonEditarTarefa);
            this.Controls.Add(this.buttonAdicionarTarefa);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TarefaForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarefa";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTarefaConcluida;
        private System.Windows.Forms.Button buttonAdicionarTarefa;
        private System.Windows.Forms.Button buttonEditarTarefa;
        private System.Windows.Forms.Button buttonExcluirTarefa;
        private System.Windows.Forms.Button buttonMarcarItems;
        private System.Windows.Forms.Button buttonAdicionarItems;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBoxTarefaIncompletas;
    }
}
