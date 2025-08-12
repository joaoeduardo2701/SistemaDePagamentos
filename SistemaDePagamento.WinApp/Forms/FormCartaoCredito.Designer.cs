namespace SistemaDePagamento.WinApp
{
    partial class FormCartaoCredito
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            txtNumeroCartao = new MaskedTextBox();
            txtNomeTitular = new TextBox();
            txtDataValidade = new MaskedTextBox();
            txtCvv = new MaskedTextBox();
            valorCompra = new NumericUpDown();
            valor_label = new Label();
            ((System.ComponentModel.ISupportInitialize)valorCompra).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 50);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 0;
            label1.Text = "Número do Cartão:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 83);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome do Titular:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(205, 123);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Validade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(227, 162);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 3;
            label4.Text = "CVV:";
            // 
            // button1
            // 
            button1.Location = new Point(227, 263);
            button1.Name = "button1";
            button1.Size = new Size(87, 33);
            button1.TabIndex = 4;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtNumeroCartao
            // 
            txtNumeroCartao.Location = new Point(265, 47);
            txtNumeroCartao.Mask = "0000 0000 0000 0000";
            txtNumeroCartao.Name = "txtNumeroCartao";
            txtNumeroCartao.Size = new Size(100, 23);
            txtNumeroCartao.TabIndex = 5;
            // 
            // txtNomeTitular
            // 
            txtNomeTitular.Location = new Point(265, 80);
            txtNomeTitular.Name = "txtNomeTitular";
            txtNomeTitular.Size = new Size(100, 23);
            txtNomeTitular.TabIndex = 6;
            // 
            // txtDataValidade
            // 
            txtDataValidade.Location = new Point(265, 120);
            txtDataValidade.Mask = "00/00";
            txtDataValidade.Name = "txtDataValidade";
            txtDataValidade.Size = new Size(100, 23);
            txtDataValidade.TabIndex = 7;
            // 
            // txtCvv
            // 
            txtCvv.Location = new Point(265, 159);
            txtCvv.Mask = "000";
            txtCvv.Name = "txtCvv";
            txtCvv.Size = new Size(100, 23);
            txtCvv.TabIndex = 8;
            // 
            // valorCompra
            // 
            valorCompra.DecimalPlaces = 2;
            valorCompra.Location = new Point(265, 198);
            valorCompra.Name = "valorCompra";
            valorCompra.Size = new Size(100, 23);
            valorCompra.TabIndex = 10;
            // 
            // valor_label
            // 
            valor_label.AutoSize = true;
            valor_label.Location = new Point(223, 200);
            valor_label.Name = "valor_label";
            valor_label.Size = new Size(36, 15);
            valor_label.TabIndex = 9;
            valor_label.Text = "Valor:";
            // 
            // FormCartaoCredito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 335);
            Controls.Add(valorCompra);
            Controls.Add(valor_label);
            Controls.Add(txtCvv);
            Controls.Add(txtDataValidade);
            Controls.Add(txtNomeTitular);
            Controls.Add(txtNumeroCartao);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCartaoCredito";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cartão de Crédito";
            ((System.ComponentModel.ISupportInitialize)valorCompra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private MaskedTextBox txtNumeroCartao;
        private TextBox txtNomeTitular;
        private MaskedTextBox txtDataValidade;
        private MaskedTextBox txtCvv;
        private NumericUpDown valorCompra;
        private Label valor_label;
    }
}