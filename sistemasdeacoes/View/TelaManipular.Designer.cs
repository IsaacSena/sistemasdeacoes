namespace sistemasdeacoes.View
{
    partial class TelaManipular
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
            button1 = new Button();
            tbx_pesquisarTelaPesquisar = new TextBox();
            groupBox1 = new GroupBox();
            nud_quantidadeCadastrar = new TextBox();
            tbx_precoAtivo = new TextBox();
            tbx_ativoPesquisa = new TextBox();
            tbx_tipoAtivotelaPesquisa = new TextBox();
            dtp_pesquisaCodigo = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(497, 116);
            button1.Name = "button1";
            button1.Size = new Size(88, 30);
            button1.TabIndex = 9;
            button1.Text = "Pesquisar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbx_pesquisarTelaPesquisar
            // 
            tbx_pesquisarTelaPesquisar.Location = new Point(250, 121);
            tbx_pesquisarTelaPesquisar.Name = "tbx_pesquisarTelaPesquisar";
            tbx_pesquisarTelaPesquisar.Size = new Size(223, 23);
            tbx_pesquisarTelaPesquisar.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nud_quantidadeCadastrar);
            groupBox1.Controls.Add(tbx_precoAtivo);
            groupBox1.Controls.Add(tbx_ativoPesquisa);
            groupBox1.Controls.Add(tbx_tipoAtivotelaPesquisa);
            groupBox1.Controls.Add(dtp_pesquisaCodigo);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(94, 179);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(481, 216);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pesquisa";
            // 
            // nud_quantidadeCadastrar
            // 
            nud_quantidadeCadastrar.Location = new Point(287, 131);
            nud_quantidadeCadastrar.Name = "nud_quantidadeCadastrar";
            nud_quantidadeCadastrar.Size = new Size(100, 23);
            nud_quantidadeCadastrar.TabIndex = 9;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(185, 25);
            label2.Name = "label2";
            label2.Size = new Size(302, 32);
            label2.TabIndex = 6;
            label2.Text = "Gerenciamento de Ativos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(67, 120);
            label1.Name = "label1";
            label1.Size = new Size(177, 21);
            label1.TabIndex = 5;
            label1.Text = "Digite o Código da Ação";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(130, 404);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "Alterar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(462, 404);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 11;
            button3.Text = "Excluir";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // TelaManipular
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(641, 436);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tbx_pesquisarTelaPesquisar);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "TelaManipular";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Ações";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox tbx_pesquisarTelaPesquisar;
        private GroupBox groupBox1;
        private TextBox nud_quantidadeCadastrar;
        private TextBox tbx_precoAtivo;
        private TextBox tbx_ativoPesquisa;
        private TextBox tbx_tipoAtivotelaPesquisa;
        private DateTimePicker dtp_pesquisaCodigo;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button3;
    }
}