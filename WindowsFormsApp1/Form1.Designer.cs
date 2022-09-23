
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.Entrada1 = new System.Windows.Forms.TextBox();
            this.Nota1 = new System.Windows.Forms.Label();
            this.Nota2 = new System.Windows.Forms.Label();
            this.Entrada2 = new System.Windows.Forms.TextBox();
            this.Nota3 = new System.Windows.Forms.Label();
            this.Nota4 = new System.Windows.Forms.Label();
            this.Entrada3 = new System.Windows.Forms.TextBox();
            this.Entrada4 = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnler = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsair = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Entrada1
            // 
            this.Entrada1.Location = new System.Drawing.Point(72, 57);
            this.Entrada1.Name = "Entrada1";
            this.Entrada1.Size = new System.Drawing.Size(100, 20);
            this.Entrada1.TabIndex = 0;
            this.Entrada1.TextChanged += new System.EventHandler(this.Entrada1_TextChanged);
            // 
            // Nota1
            // 
            this.Nota1.AutoSize = true;
            this.Nota1.Location = new System.Drawing.Point(16, 64);
            this.Nota1.Name = "Nota1";
            this.Nota1.Size = new System.Drawing.Size(41, 13);
            this.Nota1.TabIndex = 1;
            this.Nota1.Text = "Nota1";
            // 
            // Nota2
            // 
            this.Nota2.AutoSize = true;
            this.Nota2.Location = new System.Drawing.Point(16, 102);
            this.Nota2.Name = "Nota2";
            this.Nota2.Size = new System.Drawing.Size(41, 13);
            this.Nota2.TabIndex = 2;
            this.Nota2.Text = "Nota2";
            // 
            // Entrada2
            // 
            this.Entrada2.Location = new System.Drawing.Point(72, 95);
            this.Entrada2.Name = "Entrada2";
            this.Entrada2.Size = new System.Drawing.Size(100, 20);
            this.Entrada2.TabIndex = 3;
            // 
            // Nota3
            // 
            this.Nota3.AutoSize = true;
            this.Nota3.Location = new System.Drawing.Point(16, 142);
            this.Nota3.Name = "Nota3";
            this.Nota3.Size = new System.Drawing.Size(41, 13);
            this.Nota3.TabIndex = 4;
            this.Nota3.Text = "Nota3";
            // 
            // Nota4
            // 
            this.Nota4.AutoSize = true;
            this.Nota4.Location = new System.Drawing.Point(16, 178);
            this.Nota4.Name = "Nota4";
            this.Nota4.Size = new System.Drawing.Size(41, 13);
            this.Nota4.TabIndex = 5;
            this.Nota4.Text = "Nota4";
            // 
            // Entrada3
            // 
            this.Entrada3.Location = new System.Drawing.Point(72, 135);
            this.Entrada3.Name = "Entrada3";
            this.Entrada3.Size = new System.Drawing.Size(100, 20);
            this.Entrada3.TabIndex = 6;
            // 
            // Entrada4
            // 
            this.Entrada4.Location = new System.Drawing.Point(72, 171);
            this.Entrada4.Name = "Entrada4";
            this.Entrada4.Size = new System.Drawing.Size(100, 20);
            this.Entrada4.TabIndex = 7;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(60, 259);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 8;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(127, 354);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 9;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(172, 259);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 23);
            this.btnsalvar.TabIndex = 10;
            this.btnsalvar.Text = "Salvar notas";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btnler
            // 
            this.btnler.Location = new System.Drawing.Point(295, 259);
            this.btnler.Name = "btnler";
            this.btnler.Size = new System.Drawing.Size(75, 23);
            this.btnler.TabIndex = 11;
            this.btnler.Text = "Ler notas";
            this.btnler.UseVisualStyleBackColor = true;
            this.btnler.Click += new System.EventHandler(this.btnler_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(178, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 168);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Qtde de notas >= a 7:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Soma das notas impares:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Soma das notas pares:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Menor nota:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Menor nota:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maior nota:";
            // 
            // btnsair
            // 
            this.btnsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.Location = new System.Drawing.Point(246, 354);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 13;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.Entrada1);
            this.groupBox2.Controls.Add(this.btnler);
            this.groupBox2.Controls.Add(this.Nota1);
            this.groupBox2.Controls.Add(this.btnsalvar);
            this.groupBox2.Controls.Add(this.Nota2);
            this.groupBox2.Controls.Add(this.Nota3);
            this.groupBox2.Controls.Add(this.btncalcular);
            this.groupBox2.Controls.Add(this.Nota4);
            this.groupBox2.Controls.Add(this.Entrada4);
            this.groupBox2.Controls.Add(this.Entrada2);
            this.groupBox2.Controls.Add(this.Entrada3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(12, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(467, 318);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "AppNotas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(516, 413);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Name = "Form1";
            this.Text = "AppNotas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Entrada1;
        private System.Windows.Forms.Label Nota1;
        private System.Windows.Forms.Label Nota2;
        private System.Windows.Forms.TextBox Entrada2;
        private System.Windows.Forms.Label Nota3;
        private System.Windows.Forms.Label Nota4;
        private System.Windows.Forms.TextBox Entrada3;
        private System.Windows.Forms.TextBox Entrada4;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btnler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsair;
        public System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
    }
}

