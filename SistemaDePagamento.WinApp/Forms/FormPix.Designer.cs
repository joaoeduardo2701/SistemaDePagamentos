namespace SistemaDePagamento.WinApp.Forms
{
    partial class FormPix
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
            valorCompra = new NumericUpDown();
            valor_label = new Label();
            efetuarPagamento = new Button();
            txtChavePix = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)valorCompra).BeginInit();
            SuspendLayout();
            // 
            // valorCompra
            // 
            valorCompra.DecimalPlaces = 2;
            valorCompra.Location = new Point(254, 127);
            valorCompra.Name = "valorCompra";
            valorCompra.Size = new Size(100, 23);
            valorCompra.TabIndex = 12;
            // 
            // valor_label
            // 
            valor_label.AutoSize = true;
            valor_label.Location = new Point(212, 129);
            valor_label.Name = "valor_label";
            valor_label.Size = new Size(36, 15);
            valor_label.TabIndex = 11;
            valor_label.Text = "Valor:";
            // 
            // efetuarPagamento
            // 
            efetuarPagamento.Location = new Point(239, 226);
            efetuarPagamento.Name = "efetuarPagamento";
            efetuarPagamento.Size = new Size(87, 33);
            efetuarPagamento.TabIndex = 15;
            efetuarPagamento.Text = "Confirmar";
            efetuarPagamento.UseVisualStyleBackColor = true;
            efetuarPagamento.Click += efetuarPagamento_Click;
            // 
            // txtChavePix
            // 
            txtChavePix.Location = new Point(254, 75);
            txtChavePix.Name = "txtChavePix";
            txtChavePix.Size = new Size(100, 23);
            txtChavePix.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(186, 78);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 16;
            label1.Text = "Chave Pix:";
            // 
            // FormPix
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 344);
            Controls.Add(txtChavePix);
            Controls.Add(label1);
            Controls.Add(efetuarPagamento);
            Controls.Add(valorCompra);
            Controls.Add(valor_label);
            Name = "FormPix";
            Text = "Pix";
            ((System.ComponentModel.ISupportInitialize)valorCompra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown valorCompra;
        private Label valor_label;
        private Button efetuarPagamento;
        private TextBox txtChavePix;
        private Label label1;
    }
}