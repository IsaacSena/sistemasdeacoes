namespace sistemasdeacoes.View
{
    partial class TelaPesquisarCodigo
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
            groupBox1 = new GroupBox();
            tbx_qdtCodigo = new TextBox();
            tbx_precoAtivo = new TextBox();
            tbx_ativoPesquisa = new TextBox();
            tbx_tipoAtivotelaPesquisa = new TextBox();
            dtp_pesquisaCodigo = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            tbx_pesquisarTelaPesquisar = new TextBox();
            but_telaPesquisar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 104);
            label1.Name = "label1";
            label1.Size = new Size(180, 21);
            label1.TabIndex = 0;
            label1.Text = "Digite o Código do Ativo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(178, 9);
            label2.Name = "label2";
            label2.Size = new Size(249, 32);
            label2.TabIndex = 1;
            label2.Text = "Pesquisa por Código";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbx_qdtCodigo);
            groupBox1.Controls.Add(tbx_precoAtivo);
            groupBox1.Controls.Add(tbx_ativoPesquisa);
            groupBox1.Controls.Add(tbx_tipoAtivotelaPesquisa);
            groupBox1.Controls.Add(dtp_pesquisaCodigo);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(87, 163);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(481, 216);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pesquisa";
            // 
            // tbx_qdtCodigo
            // 
            tbx_qdtCodigo.Location = new Point(287, 131);
            tbx_qdtCodigo.Name = "tbx_qdtCodigo";
            tbx_qdtCodigo.Size = new Size(100, 23);
            tbx_qdtCodigo.TabIndex = 9;
            // 
            // tbx_precoAtivo
            // 
            tbx_precoAtivo.Location = new Point(93, 133);
            tbx_precoAtivo.Name = "tbx_precoAtivo";
            tbx_precoAtivo.Size = new Size(100, 23);
            tbx_precoAtivo.TabIndex = 8;
            // 
            // tbx_ativoPesquisa
            // 
            tbx_ativoPesquisa.Location = new Point(123, 57);
            tbx_ativoPesquisa.Name = "tbx_ativoPesquisa";
            tbx_ativoPesquisa.Size = new Size(243, 23);
            tbx_ativoPesquisa.TabIndex = 7;
            // 
            // tbx_tipoAtivotelaPesquisa
            // 
            tbx_tipoAtivotelaPesquisa.Location = new Point(123, 22);
            tbx_tipoAtivotelaPesquisa.Name = "tbx_tipoAtivotelaPesquisa";
            tbx_tipoAtivotelaPesquisa.Size = new Size(243, 23);
            tbx_tipoAtivotelaPesquisa.TabIndex = 6;
            // 
            // dtp_pesquisaCodigo
            // 
            dtp_pesquisaCodigo.Location = new Point(179, 92);
            dtp_pesquisaCodigo.Name = "dtp_pesquisaCodigo";
            dtp_pesquisaCodigo.Size = new Size(135, 23);
            dtp_pesquisaCodigo.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(242, 131);
            label7.Name = "label7";
            label7.Size = new Size(39, 21);
            label7.TabIndex = 4;
            label7.Text = "Qtd:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(35, 133);
            label6.Name = "label6";
            label6.Size = new Size(52, 21);
            label6.TabIndex = 3;
            label6.Text = "Preço:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(68, 93);
            label5.Name = "label5";
            label5.Size = new Size(105, 21);
            label5.TabIndex = 2;
            label5.Text = "Data Compra:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(68, 57);
            label4.Name = "label4";
            label4.Size = new Size(49, 21);
            label4.TabIndex = 1;
            label4.Text = "Ativo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(68, 24);
            label3.Name = "label3";
            label3.Size = new Size(43, 21);
            label3.TabIndex = 0;
            label3.Text = "Tipo:";
            // 
            // tbx_pesquisarTelaPesquisar
            // 
            tbx_pesquisarTelaPesquisar.Location = new Point(213, 105);
            tbx_pesquisarTelaPesquisar.Name = "tbx_pesquisarTelaPesquisar";
            tbx_pesquisarTelaPesquisar.Size = new Size(223, 23);
            tbx_pesquisarTelaPesquisar.TabIndex = 3;
            // 
            // but_telaPesquisar
            // 
            but_telaPesquisar.Location = new Point(460, 100);
            but_telaPesquisar.Name = "but_telaPesquisar";
            but_telaPesquisar.Size = new Size(88, 30);
            but_telaPesquisar.TabIndex = 4;
            but_telaPesquisar.Text = "Pesquisar";
            but_telaPesquisar.UseVisualStyleBackColor = true;
            but_telaPesquisar.Click += button1_Click;
            // 
            // TelaPesquisarCodigo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(641, 436);
            Controls.Add(but_telaPesquisar);
            Controls.Add(tbx_pesquisarTelaPesquisar);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "TelaPesquisarCodigo";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Ações";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox tbx_qdtCodigo;
        private TextBox tbx_precoAtivo;
        private TextBox tbx_ativoPesquisa;
        private TextBox tbx_tipoAtivotelaPesquisa;
        private DateTimePicker dtp_pesquisaCodigo;
        private TextBox tbx_pesquisarTelaPesquisar;
        private Button but_telaPesquisar;
    }
}