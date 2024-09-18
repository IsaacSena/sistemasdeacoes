namespace sistemasdeacoes.View
{
    partial class telaCadastro
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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cbx_tipoAtivoCadastrar = new ComboBox();
            cbx_AtivoCadastrar = new ComboBox();
            dtp_dataCompraCadastrar = new DateTimePicker();
            nud_quantidadeCadastrar = new NumericUpDown();
            tbx_precoAtivoCadastrar = new TextBox();
            tbx_custoAtivosCadastrar = new TextBox();
            valortotal = new Label();
            but_cancelarCadastrar = new Button();
            but_salvarCadastrar = new Button();
            ((System.ComponentModel.ISupportInitialize)nud_quantidadeCadastrar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(132, 9);
            label1.Name = "label1";
            label1.Size = new Size(192, 25);
            label1.TabIndex = 0;
            label1.Text = "Adicionar Transação";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 104);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 1;
            label2.Text = "Tipo de ativo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 156);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 2;
            label3.Text = "Ativo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(97, 214);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 3;
            label4.Text = "Data da compra";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(97, 278);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 4;
            label5.Text = "Preço em R$";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(255, 214);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 5;
            label6.Text = "Quantidade";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(255, 278);
            label7.Name = "label7";
            label7.Size = new Size(80, 15);
            label7.TabIndex = 6;
            label7.Text = "Outros custos";
            // 
            // cbx_tipoAtivoCadastrar
            // 
            cbx_tipoAtivoCadastrar.FormattingEnabled = true;
            cbx_tipoAtivoCadastrar.Items.AddRange(new object[] { "Ações", "Fundos de Investimentos", "FIIS", "Criptomoedas", "Stock", "Reit", "BDRS", "ETFS", "ETFS Internacionais", "Tesouro Direto", "Renda Fixa", "Outros" });
            cbx_tipoAtivoCadastrar.Location = new Point(97, 122);
            cbx_tipoAtivoCadastrar.Name = "cbx_tipoAtivoCadastrar";
            cbx_tipoAtivoCadastrar.Size = new Size(278, 23);
            cbx_tipoAtivoCadastrar.TabIndex = 7;
            // 
            // cbx_AtivoCadastrar
            // 
            cbx_AtivoCadastrar.FormattingEnabled = true;
            cbx_AtivoCadastrar.Location = new Point(97, 174);
            cbx_AtivoCadastrar.Name = "cbx_AtivoCadastrar";
            cbx_AtivoCadastrar.Size = new Size(278, 23);
            cbx_AtivoCadastrar.TabIndex = 8;
            // 
            // dtp_dataCompraCadastrar
            // 
            dtp_dataCompraCadastrar.Location = new Point(97, 237);
            dtp_dataCompraCadastrar.Name = "dtp_dataCompraCadastrar";
            dtp_dataCompraCadastrar.Size = new Size(125, 23);
            dtp_dataCompraCadastrar.TabIndex = 9;
            // 
            // nud_quantidadeCadastrar
            // 
            nud_quantidadeCadastrar.Location = new Point(255, 237);
            nud_quantidadeCadastrar.Name = "nud_quantidadeCadastrar";
            nud_quantidadeCadastrar.Size = new Size(120, 23);
            nud_quantidadeCadastrar.TabIndex = 10;
            nud_quantidadeCadastrar.ValueChanged += valortotal_Click;
            nud_quantidadeCadastrar.Click += valortotal_Click;
            // 
            // tbx_precoAtivoCadastrar
            // 
            tbx_precoAtivoCadastrar.Location = new Point(97, 296);
            tbx_precoAtivoCadastrar.Name = "tbx_precoAtivoCadastrar";
            tbx_precoAtivoCadastrar.Size = new Size(125, 23);
            tbx_precoAtivoCadastrar.TabIndex = 11;
            tbx_precoAtivoCadastrar.Text = "0,00";
            tbx_precoAtivoCadastrar.TextChanged += valortotal_Click;
            // 
            // tbx_custoAtivosCadastrar
            // 
            tbx_custoAtivosCadastrar.Location = new Point(255, 296);
            tbx_custoAtivosCadastrar.Name = "tbx_custoAtivosCadastrar";
            tbx_custoAtivosCadastrar.Size = new Size(120, 23);
            tbx_custoAtivosCadastrar.TabIndex = 12;
            tbx_custoAtivosCadastrar.Text = " 0,00";
            tbx_custoAtivosCadastrar.TextChanged += valortotal_Click;
            // 
            // valortotal
            // 
            valortotal.BackColor = SystemColors.ControlDark;
            valortotal.Location = new Point(97, 355);
            valortotal.Name = "valortotal";
            valortotal.Size = new Size(278, 27);
            valortotal.TabIndex = 13;
            valortotal.Text = "Valor total: R$ 0,00";
            valortotal.TextAlign = ContentAlignment.MiddleCenter;
            valortotal.Click += valortotal_Click;
            // 
            // but_cancelarCadastrar
            // 
            but_cancelarCadastrar.BackColor = SystemColors.ActiveCaptionText;
            but_cancelarCadastrar.ForeColor = SystemColors.ButtonFace;
            but_cancelarCadastrar.Location = new Point(97, 397);
            but_cancelarCadastrar.Name = "but_cancelarCadastrar";
            but_cancelarCadastrar.Size = new Size(91, 32);
            but_cancelarCadastrar.TabIndex = 14;
            but_cancelarCadastrar.Text = "Cancelar";
            but_cancelarCadastrar.UseVisualStyleBackColor = false;
            but_cancelarCadastrar.Click += but_cancelarCadastrar_Click;
            // 
            // but_salvarCadastrar
            // 
            but_salvarCadastrar.BackColor = SystemColors.ControlText;
            but_salvarCadastrar.ForeColor = SystemColors.ButtonFace;
            but_salvarCadastrar.Location = new Point(287, 397);
            but_salvarCadastrar.Name = "but_salvarCadastrar";
            but_salvarCadastrar.Size = new Size(88, 32);
            but_salvarCadastrar.TabIndex = 15;
            but_salvarCadastrar.Text = "Salvar";
            but_salvarCadastrar.UseVisualStyleBackColor = false;
            but_salvarCadastrar.Click += but_salvarCadastrar_Click;
            // 
            // telaCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(467, 432);
            Controls.Add(but_salvarCadastrar);
            Controls.Add(but_cancelarCadastrar);
            Controls.Add(valortotal);
            Controls.Add(tbx_custoAtivosCadastrar);
            Controls.Add(tbx_precoAtivoCadastrar);
            Controls.Add(nud_quantidadeCadastrar);
            Controls.Add(dtp_dataCompraCadastrar);
            Controls.Add(cbx_AtivoCadastrar);
            Controls.Add(cbx_tipoAtivoCadastrar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "telaCadastro";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Ações";
            Load += telaCadastro_Load;
            ((System.ComponentModel.ISupportInitialize)nud_quantidadeCadastrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cbx_tipoAtivoCadastrar;
        private ComboBox cbx_AtivoCadastrar;
        private DateTimePicker dtp_dataCompraCadastrar;
        private NumericUpDown nud_quantidadeCadastrar;
        private TextBox tbx_precoAtivoCadastrar;
        private TextBox tbx_custoAtivosCadastrar;
        private Label valortotal;
        private Button but_cancelarCadastrar;
        private Button but_salvarCadastrar;
    }
}