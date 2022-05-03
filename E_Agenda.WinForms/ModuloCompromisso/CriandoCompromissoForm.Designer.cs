namespace E_Agenda.WinForms.ModuloCompromisso
{
    partial class CriandoCompromissoForm
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
            this.listBoxContatos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLocal = new System.Windows.Forms.TextBox();
            this.textBoxAssunto = new System.Windows.Forms.TextBox();
            this.maskedTextBoxDataCompromisso = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.maskedTextBoxHoraInicial = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxHoraFinal = new System.Windows.Forms.MaskedTextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxContatos
            // 
            this.listBoxContatos.FormattingEnabled = true;
            this.listBoxContatos.ItemHeight = 20;
            this.listBoxContatos.Location = new System.Drawing.Point(229, 12);
            this.listBoxContatos.Name = "listBoxContatos";
            this.listBoxContatos.ScrollAlwaysVisible = true;
            this.listBoxContatos.Size = new System.Drawing.Size(376, 124);
            this.listBoxContatos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione o Contato :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite a Data Do Compromisso :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(319, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Digite a Hora inicial do Compromisso :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(309, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Digite a Hora final do Compromisso :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Digite o assunto do Compromisso :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(13, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(270, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Digite o local do Compromisso :";
            // 
            // textBoxLocal
            // 
            this.textBoxLocal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLocal.Location = new System.Drawing.Point(332, 363);
            this.textBoxLocal.Name = "textBoxLocal";
            this.textBoxLocal.Size = new System.Drawing.Size(170, 30);
            this.textBoxLocal.TabIndex = 10;
            // 
            // textBoxAssunto
            // 
            this.textBoxAssunto.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAssunto.Location = new System.Drawing.Point(332, 420);
            this.textBoxAssunto.Name = "textBoxAssunto";
            this.textBoxAssunto.Size = new System.Drawing.Size(170, 30);
            this.textBoxAssunto.TabIndex = 11;
            // 
            // maskedTextBoxDataCompromisso
            // 
            this.maskedTextBoxDataCompromisso.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBoxDataCompromisso.Location = new System.Drawing.Point(332, 192);
            this.maskedTextBoxDataCompromisso.Mask = "00/00/0000";
            this.maskedTextBoxDataCompromisso.Name = "maskedTextBoxDataCompromisso";
            this.maskedTextBoxDataCompromisso.Size = new System.Drawing.Size(170, 30);
            this.maskedTextBoxDataCompromisso.TabIndex = 12;
            this.maskedTextBoxDataCompromisso.ValidatingType = typeof(System.DateTime);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(524, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "Concluir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonConcluir_Click);
            // 
            // maskedTextBoxHoraInicial
            // 
            this.maskedTextBoxHoraInicial.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBoxHoraInicial.Location = new System.Drawing.Point(332, 249);
            this.maskedTextBoxHoraInicial.Mask = "00:00";
            this.maskedTextBoxHoraInicial.Name = "maskedTextBoxHoraInicial";
            this.maskedTextBoxHoraInicial.Size = new System.Drawing.Size(64, 30);
            this.maskedTextBoxHoraInicial.TabIndex = 14;
            this.maskedTextBoxHoraInicial.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxHoraFinal
            // 
            this.maskedTextBoxHoraFinal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBoxHoraFinal.Location = new System.Drawing.Point(332, 306);
            this.maskedTextBoxHoraFinal.Mask = "00:00";
            this.maskedTextBoxHoraFinal.Name = "maskedTextBoxHoraFinal";
            this.maskedTextBoxHoraFinal.Size = new System.Drawing.Size(64, 30);
            this.maskedTextBoxHoraFinal.TabIndex = 15;
            this.maskedTextBoxHoraFinal.ValidatingType = typeof(System.DateTime);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Location = new System.Drawing.Point(624, 440);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 16;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // CriandoCompromissoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(730, 481);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.maskedTextBoxHoraFinal);
            this.Controls.Add(this.maskedTextBoxHoraInicial);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedTextBoxDataCompromisso);
            this.Controls.Add(this.textBoxAssunto);
            this.Controls.Add(this.textBoxLocal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxContatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CriandoCompromissoForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criando Compromisso";
            this.Load += new System.EventHandler(this.CriandoCompromissoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxContatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLocal;
        private System.Windows.Forms.TextBox textBoxAssunto;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataCompromisso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHoraInicial;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHoraFinal;
        private System.Windows.Forms.Button buttonCancelar;
    }
}