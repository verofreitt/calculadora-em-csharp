namespace Atividade_01___01
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSoma = new System.Windows.Forms.Label();
            this.lblMultiplicação = new System.Windows.Forms.Label();
            this.lblSubtração = new System.Windows.Forms.Label();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 146);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(421, 40);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "NÚMERO 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "NÚMERO 2";
            // 
            // lblSoma
            // 
            this.lblSoma.AutoSize = true;
            this.lblSoma.Location = new System.Drawing.Point(59, 222);
            this.lblSoma.Name = "lblSoma";
            this.lblSoma.Size = new System.Drawing.Size(41, 13);
            this.lblSoma.TabIndex = 5;
            this.lblSoma.Text = "SOMA:";
            // 
            // lblMultiplicação
            // 
            this.lblMultiplicação.AutoSize = true;
            this.lblMultiplicação.Location = new System.Drawing.Point(178, 222);
            this.lblMultiplicação.Name = "lblMultiplicação";
            this.lblMultiplicação.Size = new System.Drawing.Size(95, 13);
            this.lblMultiplicação.TabIndex = 6;
            this.lblMultiplicação.Text = "MULTIPLICAÇÃO:";
            // 
            // lblSubtração
            // 
            this.lblSubtração.AutoSize = true;
            this.lblSubtração.Location = new System.Drawing.Point(331, 222);
            this.lblSubtração.Name = "lblSubtração";
            this.lblSubtração.Size = new System.Drawing.Size(76, 13);
            this.lblSubtração.TabIndex = 7;
            this.lblSubtração.Text = "SUBTRAÇÃO:";
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(171, 38);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(45, 20);
            this.txtNumero1.TabIndex = 8;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(171, 89);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(45, 20);
            this.txtNumero2.TabIndex = 9;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(334, 41);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(87, 64);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 272);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.lblSubtração);
            this.Controls.Add(this.lblMultiplicação);
            this.Controls.Add(this.lblSoma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "AMILIS LINDA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSoma;
        private System.Windows.Forms.Label lblMultiplicação;
        private System.Windows.Forms.Label lblSubtração;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Button btnLimpar;
    }
}

