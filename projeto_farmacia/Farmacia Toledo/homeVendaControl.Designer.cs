namespace Farmacia_Toledo
{
    partial class homeVendaControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAtualizarRegistros = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNovoProduto = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Alterar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtualizarRegistros
            // 
            this.btnAtualizarRegistros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAtualizarRegistros.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAtualizarRegistros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizarRegistros.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnAtualizarRegistros.FlatAppearance.BorderSize = 0;
            this.btnAtualizarRegistros.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnAtualizarRegistros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarRegistros.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarRegistros.ForeColor = System.Drawing.Color.White;
            this.btnAtualizarRegistros.Location = new System.Drawing.Point(436, 21);
            this.btnAtualizarRegistros.Name = "btnAtualizarRegistros";
            this.btnAtualizarRegistros.Size = new System.Drawing.Size(177, 31);
            this.btnAtualizarRegistros.TabIndex = 36;
            this.btnAtualizarRegistros.Text = " Atualizar Regitros";
            this.btnAtualizarRegistros.UseVisualStyleBackColor = false;
            this.btnAtualizarRegistros.Click += new System.EventHandler(this.btnAtualizarRegistros_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 38);
            this.label2.TabIndex = 38;
            this.label2.Text = "Histórico de Vendas";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnNovoProduto
            // 
            this.btnNovoProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNovoProduto.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNovoProduto.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnNovoProduto.FlatAppearance.BorderSize = 0;
            this.btnNovoProduto.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNovoProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoProduto.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoProduto.ForeColor = System.Drawing.Color.White;
            this.btnNovoProduto.Location = new System.Drawing.Point(530, 338);
            this.btnNovoProduto.Name = "btnNovoProduto";
            this.btnNovoProduto.Size = new System.Drawing.Size(83, 31);
            this.btnNovoProduto.TabIndex = 39;
            this.btnNovoProduto.Text = "+ VENDA";
            this.btnNovoProduto.UseVisualStyleBackColor = false;
            this.btnNovoProduto.Click += new System.EventHandler(this.btnNovoProduto_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Alterar});
            this.dataGridView1.Location = new System.Drawing.Point(37, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(576, 273);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Alterar
            // 
            this.Alterar.HeaderText = "Alterar";
            this.Alterar.Name = "Alterar";
            this.Alterar.Text = "Alterar";
            // 
            // homeVendaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnNovoProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAtualizarRegistros);
            this.Name = "homeVendaControl";
            this.Size = new System.Drawing.Size(661, 381);
            this.Load += new System.EventHandler(this.homeVendaControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtualizarRegistros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNovoProduto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Alterar;
    }
}
