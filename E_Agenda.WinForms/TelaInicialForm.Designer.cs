namespace E_Agenda.WinForms
{
    partial class TelaInicialForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAcessarTarefas = new System.Windows.Forms.Button();
            this.btnAcessarContatos = new System.Windows.Forms.Button();
            this.btnAcessarCompromisso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAcessarTarefas
            // 
            this.btnAcessarTarefas.Location = new System.Drawing.Point(249, 122);
            this.btnAcessarTarefas.Name = "btnAcessarTarefas";
            this.btnAcessarTarefas.Size = new System.Drawing.Size(172, 94);
            this.btnAcessarTarefas.TabIndex = 0;
            this.btnAcessarTarefas.Text = "Acessar Tarefas";
            this.btnAcessarTarefas.UseVisualStyleBackColor = true;
            this.btnAcessarTarefas.Click += new System.EventHandler(this.buttonAcessarTarefas_Click);
            // 
            // btnAcessarContatos
            // 
            this.btnAcessarContatos.Location = new System.Drawing.Point(374, 227);
            this.btnAcessarContatos.Name = "btnAcessarContatos";
            this.btnAcessarContatos.Size = new System.Drawing.Size(172, 94);
            this.btnAcessarContatos.TabIndex = 1;
            this.btnAcessarContatos.Text = "Acessar Contatos";
            this.btnAcessarContatos.UseVisualStyleBackColor = true;
            this.btnAcessarContatos.Click += new System.EventHandler(this.btnAcessarContatos_Click);
            // 
            // btnAcessarCompromisso
            // 
            this.btnAcessarCompromisso.Location = new System.Drawing.Point(499, 332);
            this.btnAcessarCompromisso.Name = "btnAcessarCompromisso";
            this.btnAcessarCompromisso.Size = new System.Drawing.Size(172, 94);
            this.btnAcessarCompromisso.TabIndex = 2;
            this.btnAcessarCompromisso.Text = "Acessar Compromisso";
            this.btnAcessarCompromisso.UseVisualStyleBackColor = true;
            this.btnAcessarCompromisso.Click += new System.EventHandler(this.buttonAcessarCompromisso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(283, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bem Vindo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 41);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selecione a tela:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TelaInicialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAcessarCompromisso);
            this.Controls.Add(this.btnAcessarContatos);
            this.Controls.Add(this.btnAcessarTarefas);
            this.Name = "TelaInicialForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Inicial";
            this.Load += new System.EventHandler(this.TelaInicialForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAcessarTarefas;
        private System.Windows.Forms.Button btnAcessarContatos;
        private System.Windows.Forms.Button btnAcessarCompromisso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}