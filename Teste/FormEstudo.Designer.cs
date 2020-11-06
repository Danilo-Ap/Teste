namespace Teste
{
    partial class FormEstudo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.btnNome = new System.Windows.Forms.Button();
            this.btnDataHora = new System.Windows.Forms.Button();
            this.btnNota = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxAltura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxBase = new System.Windows.Forms.TextBox();
            this.btnTriangulo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxValor = new System.Windows.Forms.TextBox();
            this.txtBoxQtde = new System.Windows.Forms.TextBox();
            this.btnCalcValor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(18, 23);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(103, 32);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(127, 33);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(89, 22);
            this.txtBoxNome.TabIndex = 1;
            // 
            // btnNome
            // 
            this.btnNome.Location = new System.Drawing.Point(24, 73);
            this.btnNome.Name = "btnNome";
            this.btnNome.Size = new System.Drawing.Size(162, 50);
            this.btnNome.TabIndex = 2;
            this.btnNome.Text = "&Clique aqui";
            this.btnNome.UseVisualStyleBackColor = true;
            this.btnNome.Click += new System.EventHandler(this.btnNome_Click);
            // 
            // btnDataHora
            // 
            this.btnDataHora.Location = new System.Drawing.Point(24, 129);
            this.btnDataHora.Name = "btnDataHora";
            this.btnDataHora.Size = new System.Drawing.Size(162, 50);
            this.btnDataHora.TabIndex = 3;
            this.btnDataHora.Text = "Data/Hora";
            this.btnDataHora.UseVisualStyleBackColor = true;
            this.btnDataHora.Click += new System.EventHandler(this.btnDataHora_Click);
            // 
            // btnNota
            // 
            this.btnNota.Location = new System.Drawing.Point(24, 185);
            this.btnNota.Name = "btnNota";
            this.btnNota.Size = new System.Drawing.Size(162, 50);
            this.btnNota.TabIndex = 4;
            this.btnNota.Text = "Nota";
            this.btnNota.UseVisualStyleBackColor = true;
            this.btnNota.Click += new System.EventHandler(this.btnNota_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Triângulo Altura:";
            // 
            // txtBoxAltura
            // 
            this.txtBoxAltura.Location = new System.Drawing.Point(571, 23);
            this.txtBoxAltura.Name = "txtBoxAltura";
            this.txtBoxAltura.Size = new System.Drawing.Size(63, 22);
            this.txtBoxAltura.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(428, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Triângulo Base:";
            // 
            // txtBoxBase
            // 
            this.txtBoxBase.Location = new System.Drawing.Point(571, 51);
            this.txtBoxBase.Name = "txtBoxBase";
            this.txtBoxBase.Size = new System.Drawing.Size(63, 22);
            this.txtBoxBase.TabIndex = 8;
            // 
            // btnTriangulo
            // 
            this.btnTriangulo.Location = new System.Drawing.Point(665, 23);
            this.btnTriangulo.Name = "btnTriangulo";
            this.btnTriangulo.Size = new System.Drawing.Size(97, 50);
            this.btnTriangulo.TabIndex = 9;
            this.btnTriangulo.Text = "Calc Área";
            this.btnTriangulo.UseVisualStyleBackColor = true;
            this.btnTriangulo.Click += new System.EventHandler(this.btnTriangulo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(478, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Valor Cx:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(481, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Qtde Cx:";
            // 
            // txtBoxValor
            // 
            this.txtBoxValor.Location = new System.Drawing.Point(571, 109);
            this.txtBoxValor.Name = "txtBoxValor";
            this.txtBoxValor.Size = new System.Drawing.Size(63, 22);
            this.txtBoxValor.TabIndex = 12;
            // 
            // txtBoxQtde
            // 
            this.txtBoxQtde.Location = new System.Drawing.Point(571, 137);
            this.txtBoxQtde.Name = "txtBoxQtde";
            this.txtBoxQtde.Size = new System.Drawing.Size(63, 22);
            this.txtBoxQtde.TabIndex = 13;
            // 
            // btnCalcValor
            // 
            this.btnCalcValor.Location = new System.Drawing.Point(665, 112);
            this.btnCalcValor.Name = "btnCalcValor";
            this.btnCalcValor.Size = new System.Drawing.Size(97, 47);
            this.btnCalcValor.TabIndex = 14;
            this.btnCalcValor.Text = "Calc Valor";
            this.btnCalcValor.UseVisualStyleBackColor = true;
            this.btnCalcValor.Click += new System.EventHandler(this.btnCalcValor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(481, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(567, 182);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 20);
            this.lblTotal.TabIndex = 16;
            // 
            // FormEstudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalcValor);
            this.Controls.Add(this.txtBoxQtde);
            this.Controls.Add(this.txtBoxValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTriangulo);
            this.Controls.Add(this.txtBoxBase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxAltura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNota);
            this.Controls.Add(this.btnDataHora);
            this.Controls.Add(this.btnNome);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.lblNome);
            this.Name = "FormEstudo";
            this.Text = "Estudo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.Button btnNome;
        private System.Windows.Forms.Button btnDataHora;
        private System.Windows.Forms.Button btnNota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxAltura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxBase;
        private System.Windows.Forms.Button btnTriangulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxValor;
        private System.Windows.Forms.TextBox txtBoxQtde;
        private System.Windows.Forms.Button btnCalcValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotal;
    }
}

