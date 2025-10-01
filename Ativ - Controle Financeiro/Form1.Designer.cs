namespace Ativ___Controle_Finaneceiro
{
    partial class Form1
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
            label1 = new Label();
            txbValor = new TextBox();
            btnDebito = new Button();
            txbDescr = new TextBox();
            label2 = new Label();
            txbData = new TextBox();
            label3 = new Label();
            btnCredito = new Button();
            btnExport = new Button();
            label4 = new Label();
            lblSaldo = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(178, 203);
            label1.Name = "label1";
            label1.Size = new Size(65, 22);
            label1.TabIndex = 0;
            label1.Text = "Valor:";
            // 
            // txbValor
            // 
            txbValor.Font = new Font("Arial Narrow", 14.25F);
            txbValor.Location = new Point(178, 229);
            txbValor.Name = "txbValor";
            txbValor.Size = new Size(123, 29);
            txbValor.TabIndex = 1;
            // 
            // btnDebito
            // 
            btnDebito.BackColor = Color.LightCoral;
            btnDebito.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            btnDebito.ForeColor = SystemColors.ButtonHighlight;
            btnDebito.Location = new Point(178, 326);
            btnDebito.Name = "btnDebito";
            btnDebito.Size = new Size(98, 34);
            btnDebito.TabIndex = 2;
            btnDebito.Text = "Débito";
            btnDebito.UseVisualStyleBackColor = false;
            btnDebito.Click += btnDebito_Click;
            // 
            // txbDescr
            // 
            txbDescr.Font = new Font("Arial Narrow", 14.25F);
            txbDescr.Location = new Point(178, 77);
            txbDescr.Name = "txbDescr";
            txbDescr.Size = new Size(379, 29);
            txbDescr.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(178, 51);
            label2.Name = "label2";
            label2.Size = new Size(111, 22);
            label2.TabIndex = 3;
            label2.Text = "Descrição:";
            // 
            // txbData
            // 
            txbData.Font = new Font("Arial Narrow", 14.25F);
            txbData.Location = new Point(179, 151);
            txbData.Name = "txbData";
            txbData.Size = new Size(156, 29);
            txbData.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(179, 125);
            label3.Name = "label3";
            label3.Size = new Size(59, 22);
            label3.TabIndex = 5;
            label3.Text = "Data:";
            // 
            // btnCredito
            // 
            btnCredito.BackColor = Color.LightSteelBlue;
            btnCredito.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            btnCredito.ForeColor = Color.AliceBlue;
            btnCredito.Location = new Point(298, 326);
            btnCredito.Name = "btnCredito";
            btnCredito.Size = new Size(98, 34);
            btnCredito.TabIndex = 7;
            btnCredito.Text = "Crédito";
            btnCredito.UseVisualStyleBackColor = false;
            btnCredito.Click += btnCredito_Click;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.NavajoWhite;
            btnExport.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            btnExport.ForeColor = Color.DarkGoldenrod;
            btnExport.Location = new Point(417, 326);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(98, 34);
            btnExport.TabIndex = 8;
            btnExport.Text = "Extrato";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(177, 280);
            label4.Name = "label4";
            label4.Size = new Size(147, 22);
            label4.TabIndex = 9;
            label4.Text = "Saldo atual R$ ";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            lblSaldo.ForeColor = Color.Black;
            lblSaldo.Location = new Point(330, 280);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(59, 22);
            lblSaldo.TabIndex = 10;
            lblSaldo.Text = "00,00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSaldo);
            Controls.Add(label4);
            Controls.Add(btnExport);
            Controls.Add(btnCredito);
            Controls.Add(txbData);
            Controls.Add(label3);
            Controls.Add(txbDescr);
            Controls.Add(label2);
            Controls.Add(btnDebito);
            Controls.Add(txbValor);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbValor;
        private Button btnDebito;
        private TextBox txbDescr;
        private Label label2;
        private TextBox txbData;
        private Label label3;
        private Button btnCredito;
        private Button btnExport;
        private Label label4;
        private Label lblSaldo;
    }
}
