﻿
namespace esDataBindings1
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPersone = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cbNomeCompleto = new System.Windows.Forms.ComboBox();
            this.cbId = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cognome Persona";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Scrivi nella textbox1";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(54, 315);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cognome e Nome Persona";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ridimensiona il form e prova a scrivere le dimensione";
            // 
            // cbPersone
            // 
            this.cbPersone.FormattingEnabled = true;
            this.cbPersone.Location = new System.Drawing.Point(58, 110);
            this.cbPersone.Name = "cbPersone";
            this.cbPersone.Size = new System.Drawing.Size(177, 21);
            this.cbPersone.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 219);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(56, 266);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(211, 20);
            this.textBox2.TabIndex = 7;
            // 
            // cbNomeCompleto
            // 
            this.cbNomeCompleto.FormattingEnabled = true;
            this.cbNomeCompleto.Location = new System.Drawing.Point(378, 110);
            this.cbNomeCompleto.Name = "cbNomeCompleto";
            this.cbNomeCompleto.Size = new System.Drawing.Size(177, 21);
            this.cbNomeCompleto.TabIndex = 8;
            // 
            // cbId
            // 
            this.cbId.FormattingEnabled = true;
            this.cbId.Location = new System.Drawing.Point(378, 137);
            this.cbId.Name = "cbId";
            this.cbId.Size = new System.Drawing.Size(177, 21);
            this.cbId.TabIndex = 9;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(601, 111);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "label3";
            // 
            // tbSize
            // 
            this.tbSize.Location = new System.Drawing.Point(378, 219);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(211, 20);
            this.tbSize.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 68);
            this.button1.TabIndex = 12;
            this.button1.Text = "ESERCIZIO 2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbSize);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cbId);
            this.Controls.Add(this.cbNomeCompleto);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbPersone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbPersone;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cbNomeCompleto;
        private System.Windows.Forms.ComboBox cbId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.Button button1;
    }
}

