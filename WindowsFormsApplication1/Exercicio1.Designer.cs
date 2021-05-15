namespace WindowsFormsApplication1
{
    partial class Exercicio1
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSalarioFinalVendedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorRecebe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalarioFixo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalVanda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroCarros = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "R$:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Salário Final do Vendedor";
            // 
            // txtSalarioFinalVendedor
            // 
            this.txtSalarioFinalVendedor.Location = new System.Drawing.Point(180, 133);
            this.txtSalarioFinalVendedor.Name = "txtSalarioFinalVendedor";
            this.txtSalarioFinalVendedor.ReadOnly = true;
            this.txtSalarioFinalVendedor.Size = new System.Drawing.Size(97, 20);
            this.txtSalarioFinalVendedor.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Valor Recebe por Carro";
            // 
            // txtValorRecebe
            // 
            this.txtValorRecebe.Location = new System.Drawing.Point(159, 105);
            this.txtValorRecebe.Name = "txtValorRecebe";
            this.txtValorRecebe.Size = new System.Drawing.Size(118, 20);
            this.txtValorRecebe.TabIndex = 17;
            this.txtValorRecebe.TextChanged += new System.EventHandler(this.txtValorRecebe_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Salário Fixo";
            // 
            // txtSalarioFixo
            // 
            this.txtSalarioFixo.Location = new System.Drawing.Point(159, 79);
            this.txtSalarioFixo.Name = "txtSalarioFixo";
            this.txtSalarioFixo.Size = new System.Drawing.Size(118, 20);
            this.txtSalarioFixo.TabIndex = 15;
            this.txtSalarioFixo.TextChanged += new System.EventHandler(this.txtSalarioFixo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Valor Total Venda";
            // 
            // txtTotalVanda
            // 
            this.txtTotalVanda.Location = new System.Drawing.Point(159, 53);
            this.txtTotalVanda.Name = "txtTotalVanda";
            this.txtTotalVanda.Size = new System.Drawing.Size(118, 20);
            this.txtTotalVanda.TabIndex = 13;
            this.txtTotalVanda.TextChanged += new System.EventHandler(this.txtTotalVanda_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nº Carros";
            // 
            // txtNumeroCarros
            // 
            this.txtNumeroCarros.Location = new System.Drawing.Point(159, 27);
            this.txtNumeroCarros.Name = "txtNumeroCarros";
            this.txtNumeroCarros.Size = new System.Drawing.Size(118, 20);
            this.txtNumeroCarros.TabIndex = 11;
            this.txtNumeroCarros.TextChanged += new System.EventHandler(this.txtNumeroCarros_TextChanged);
            // 
            // Exercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 188);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSalarioFinalVendedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValorRecebe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSalarioFixo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalVanda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumeroCarros);
            this.Name = "Exercicio1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamento de Funcionário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSalarioFinalVendedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorRecebe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalarioFixo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalVanda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroCarros;
    }
}