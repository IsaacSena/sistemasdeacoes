namespace sistemasdeacoes.View
{
    partial class TelaPesquisarNome
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
            tbx_barrapesquisa = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dgv_ativo = new DataGridView();
            Código = new DataGridViewTextBoxColumn();
            tipoAtivo = new DataGridViewTextBoxColumn();
            ativo = new DataGridViewTextBoxColumn();
            dataCompra = new DataGridViewTextBoxColumn();
            qdtAtivo = new DataGridViewTextBoxColumn();
            precoAtivo = new DataGridViewTextBoxColumn();
            custoAtivo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_ativo).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(235, 141);
            button1.Name = "button1";
            button1.Size = new Size(437, 35);
            button1.TabIndex = 9;
            button1.Text = "Pesquisar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbx_barrapesquisa
            // 
            tbx_barrapesquisa.Location = new Point(373, 94);
            tbx_barrapesquisa.Name = "tbx_barrapesquisa";
            tbx_barrapesquisa.Size = new Size(335, 23);
            tbx_barrapesquisa.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(343, 9);
            label2.Name = "label2";
            label2.Size = new Size(228, 32);
            label2.TabIndex = 6;
            label2.Text = "Pesquisa por Ativo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(190, 93);
            label1.Name = "label1";
            label1.Size = new Size(173, 21);
            label1.TabIndex = 5;
            label1.Text = "Digite o Nome do Ativo";
            // 
            // dgv_ativo
            // 
            dgv_ativo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ativo.Columns.AddRange(new DataGridViewColumn[] { Código, tipoAtivo, ativo, dataCompra, qdtAtivo, precoAtivo, custoAtivo });
            dgv_ativo.Location = new Point(71, 228);
            dgv_ativo.Name = "dgv_ativo";
            dgv_ativo.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv_ativo.RowHeadersVisible = false;
            dgv_ativo.Size = new Size(704, 172);
            dgv_ativo.TabIndex = 10;
            // 
            // Código
            // 
            Código.HeaderText = "Código";
            Código.Name = "Código";
            // 
            // tipoAtivo
            // 
            tipoAtivo.HeaderText = "Tipo Ativo";
            tipoAtivo.Name = "tipoAtivo";
            // 
            // ativo
            // 
            ativo.HeaderText = "Ativo";
            ativo.Name = "ativo";
            // 
            // dataCompra
            // 
            dataCompra.HeaderText = "Data da Compra";
            dataCompra.Name = "dataCompra";
            // 
            // qdtAtivo
            // 
            qdtAtivo.HeaderText = "Quantidade Ativo";
            qdtAtivo.Name = "qdtAtivo";
            // 
            // precoAtivo
            // 
            precoAtivo.HeaderText = "Preço Ativo";
            precoAtivo.Name = "precoAtivo";
            // 
            // custoAtivo
            // 
            custoAtivo.HeaderText = "Custo Ativo";
            custoAtivo.Name = "custoAtivo";
            // 
            // TelaPesquisarNome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(886, 455);
            Controls.Add(dgv_ativo);
            Controls.Add(button1);
            Controls.Add(tbx_barrapesquisa);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "TelaPesquisarNome";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Ações";
            ((System.ComponentModel.ISupportInitialize)dgv_ativo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox tbx_barrapesquisa;
        private Label label2;
        private Label label1;
        private DataGridView dgv_ativo;
        private DataGridViewTextBoxColumn Código;
        private DataGridViewTextBoxColumn tipoAtivo;
        private DataGridViewTextBoxColumn ativo;
        private DataGridViewTextBoxColumn dataCompra;
        private DataGridViewTextBoxColumn qdtAtivo;
        private DataGridViewTextBoxColumn precoAtivo;
        private DataGridViewTextBoxColumn custoAtivo;
    }
}