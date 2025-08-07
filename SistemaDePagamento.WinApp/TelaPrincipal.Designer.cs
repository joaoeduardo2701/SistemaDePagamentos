namespace SistemaDePagamento.WinApp
{
    partial class TelaPrincipal
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            valor_label = new Label();
            label1 = new Label();
            EfetuarPagamento = new Button();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            rdbCredito = new RadioButton();
            rdbBoleto = new RadioButton();
            rdbPix = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // valor_label
            // 
            valor_label.AutoSize = true;
            valor_label.Location = new Point(310, 141);
            valor_label.Name = "valor_label";
            valor_label.Size = new Size(36, 15);
            valor_label.TabIndex = 1;
            valor_label.Text = "Valor:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(222, 180);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 5;
            label1.Text = "Forma de Pagamento:";
            // 
            // EfetuarPagamento
            // 
            EfetuarPagamento.Location = new Point(349, 326);
            EfetuarPagamento.Name = "EfetuarPagamento";
            EfetuarPagamento.Size = new Size(124, 33);
            EfetuarPagamento.TabIndex = 6;
            EfetuarPagamento.Text = "Efetuar Pagamento";
            EfetuarPagamento.UseVisualStyleBackColor = true;
            EfetuarPagamento.Click += EfetuarPagamento_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label2.Location = new Point(222, 41);
            label2.Name = "label2";
            label2.Size = new Size(351, 41);
            label2.TabIndex = 7;
            label2.Text = "Sistema de Pagamentos";
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Location = new Point(353, 139);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 8;
            // 
            // rdbCredito
            // 
            rdbCredito.AutoSize = true;
            rdbCredito.Checked = true;
            rdbCredito.Location = new Point(357, 181);
            rdbCredito.Name = "rdbCredito";
            rdbCredito.Size = new Size(118, 19);
            rdbCredito.TabIndex = 10;
            rdbCredito.TabStop = true;
            rdbCredito.Text = "Cartão de Crédito";
            rdbCredito.UseVisualStyleBackColor = true;
            // 
            // rdbBoleto
            // 
            rdbBoleto.AutoSize = true;
            rdbBoleto.Location = new Point(357, 216);
            rdbBoleto.Name = "rdbBoleto";
            rdbBoleto.Size = new Size(108, 19);
            rdbBoleto.TabIndex = 11;
            rdbBoleto.TabStop = true;
            rdbBoleto.Text = "Boleto Bancário";
            rdbBoleto.UseVisualStyleBackColor = true;
            // 
            // rdbPix
            // 
            rdbPix.AutoSize = true;
            rdbPix.Location = new Point(357, 252);
            rdbPix.Name = "rdbPix";
            rdbPix.Size = new Size(41, 19);
            rdbPix.TabIndex = 12;
            rdbPix.TabStop = true;
            rdbPix.Text = "Pix";
            rdbPix.UseVisualStyleBackColor = true;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rdbPix);
            Controls.Add(rdbBoleto);
            Controls.Add(rdbCredito);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(EfetuarPagamento);
            Controls.Add(label1);
            Controls.Add(valor_label);
            Name = "TelaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Pagamentos";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private Label valor_label;
        private Label label1;
        private Button EfetuarPagamento;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private RadioButton rdbCredito;
        private RadioButton rdbBoleto;
        private RadioButton rdbPix;
    }
}
