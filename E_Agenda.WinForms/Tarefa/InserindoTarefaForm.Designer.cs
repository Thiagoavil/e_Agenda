﻿namespace E_Agenda.WinForms
{
    partial class InserindoTarefaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.radioButtonAlta = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonMedia = new System.Windows.Forms.RadioButton();
            this.radioButtonBaixa = new System.Windows.Forms.RadioButton();
            this.btnGravar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo :";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTitulo.Location = new System.Drawing.Point(123, 27);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(125, 30);
            this.textBoxTitulo.TabIndex = 1;
            this.textBoxTitulo.TextChanged += new System.EventHandler(this.textBoxTitulo_TextChanged);
            // 
            // radioButtonAlta
            // 
            this.radioButtonAlta.AutoSize = true;
            this.radioButtonAlta.Location = new System.Drawing.Point(136, 88);
            this.radioButtonAlta.Name = "radioButtonAlta";
            this.radioButtonAlta.Size = new System.Drawing.Size(57, 24);
            this.radioButtonAlta.TabIndex = 2;
            this.radioButtonAlta.TabStop = true;
            this.radioButtonAlta.Text = "Alta\r\n";
            this.radioButtonAlta.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prioridade :";
            // 
            // radioButtonMedia
            // 
            this.radioButtonMedia.AutoSize = true;
            this.radioButtonMedia.Location = new System.Drawing.Point(136, 118);
            this.radioButtonMedia.Name = "radioButtonMedia";
            this.radioButtonMedia.Size = new System.Drawing.Size(72, 24);
            this.radioButtonMedia.TabIndex = 4;
            this.radioButtonMedia.TabStop = true;
            this.radioButtonMedia.Text = "Media";
            this.radioButtonMedia.UseVisualStyleBackColor = true;
            // 
            // radioButtonBaixa
            // 
            this.radioButtonBaixa.AutoSize = true;
            this.radioButtonBaixa.Location = new System.Drawing.Point(136, 148);
            this.radioButtonBaixa.Name = "radioButtonBaixa";
            this.radioButtonBaixa.Size = new System.Drawing.Size(66, 24);
            this.radioButtonBaixa.TabIndex = 5;
            this.radioButtonBaixa.TabStop = true;
            this.radioButtonBaixa.Text = "Baixa";
            this.radioButtonBaixa.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(475, 175);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(94, 38);
            this.btnGravar.TabIndex = 6;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // InserindoTarefaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(581, 225);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.radioButtonBaixa);
            this.Controls.Add(this.radioButtonMedia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButtonAlta);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InserindoTarefaForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserindo Tarefa";
            this.Load += new System.EventHandler(this.InserindoTarefaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.RadioButton radioButtonAlta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonMedia;
        private System.Windows.Forms.RadioButton radioButtonBaixa;
        private System.Windows.Forms.Button btnGravar;
    }
}