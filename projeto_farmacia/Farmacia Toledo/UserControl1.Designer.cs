namespace Farmacia_Toledo
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.Alterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAtualizarRegistros = new System.Windows.Forms.Button();
            this.btnNewUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 38);
            this.label1.TabIndex = 30;
            this.label1.Text = "Usuários";
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Alterar});
            this.dataGridViewUser.Location = new System.Drawing.Point(40, 62);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.Size = new System.Drawing.Size(576, 316);
            this.dataGridViewUser.TabIndex = 32;
            this.dataGridViewUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUser_CellContentClick);
            // 
            // Alterar
            // 
            this.Alterar.HeaderText = "Alterar";
            this.Alterar.Name = "Alterar";
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
            this.btnAtualizarRegistros.Location = new System.Drawing.Point(439, 26);
            this.btnAtualizarRegistros.Name = "btnAtualizarRegistros";
            this.btnAtualizarRegistros.Size = new System.Drawing.Size(177, 31);
            this.btnAtualizarRegistros.TabIndex = 34;
            this.btnAtualizarRegistros.Text = " Atualizar Regitros";
            this.btnAtualizarRegistros.UseVisualStyleBackColor = false;
            this.btnAtualizarRegistros.Click += new System.EventHandler(this.btnAtualizarRegistros_Click);
            // 
            // btnNewUser
            // 
            this.btnNewUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNewUser.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNewUser.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnNewUser.FlatAppearance.BorderSize = 0;
            this.btnNewUser.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewUser.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUser.ForeColor = System.Drawing.Color.White;
            this.btnNewUser.Location = new System.Drawing.Point(533, 383);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(83, 31);
            this.btnNewUser.TabIndex = 35;
            this.btnNewUser.Text = "+ NOVO";
            this.btnNewUser.UseVisualStyleBackColor = false;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click_1);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.btnAtualizarRegistros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewUser);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(653, 428);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.Button btnAtualizarRegistros;
        private System.Windows.Forms.DataGridViewButtonColumn Alterar;
        private System.Windows.Forms.Button btnNewUser;
    }
}
