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
            label1 = new Label();
            EfetuarPagamento = new Button();
            label2 = new Label();
            rdbCredito = new RadioButton();
            rdbBoleto = new RadioButton();
            rdbPix = new RadioButton();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(356, 143);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 5;
            label1.Text = "Forma de Pagamento:";
            // 
            // EfetuarPagamento
            // 
            EfetuarPagamento.Location = new Point(346, 329);
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
            // rdbCredito
            // 
            rdbCredito.AutoSize = true;
            rdbCredito.Checked = true;
            rdbCredito.Location = new Point(362, 186);
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
            rdbBoleto.Location = new Point(362, 221);
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
            rdbPix.Location = new Point(362, 257);
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
            Controls.Add(label2);
            Controls.Add(EfetuarPagamento);
            Controls.Add(label1);
            Name = "TelaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Pagamentos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private Button EfetuarPagamento;
        private Label label2;
        private RadioButton rdbCredito;
        private RadioButton rdbBoleto;
        private RadioButton rdbPix;
    }
}
