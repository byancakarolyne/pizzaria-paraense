namespace Pizzaria.Desktop
{
    partial class FrmCategoriaProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategoriaProduto));
            this.dataGridCategoriaProduto = new System.Windows.Forms.DataGridView();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProcurarCategoriaProduto = new System.Windows.Forms.Button();
            this.btnExcluirCategoriaProduto = new System.Windows.Forms.Button();
            this.btnIncluirCategoriaProduto = new System.Windows.Forms.Button();
            this.btnEditarCategoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategoriaProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCategoriaProduto
            // 
            this.dataGridCategoriaProduto.AllowUserToAddRows = false;
            this.dataGridCategoriaProduto.AllowUserToResizeRows = false;
            this.dataGridCategoriaProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCategoriaProduto.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCategoriaProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCategoriaProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Categoria});
            this.dataGridCategoriaProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridCategoriaProduto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridCategoriaProduto.Location = new System.Drawing.Point(119, 75);
            this.dataGridCategoriaProduto.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridCategoriaProduto.MultiSelect = false;
            this.dataGridCategoriaProduto.Name = "dataGridCategoriaProduto";
            this.dataGridCategoriaProduto.ReadOnly = true;
            this.dataGridCategoriaProduto.RowHeadersVisible = false;
            this.dataGridCategoriaProduto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridCategoriaProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCategoriaProduto.Size = new System.Drawing.Size(334, 296);
            this.dataGridCategoriaProduto.TabIndex = 1;
            this.dataGridCategoriaProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCategoriaProduto_CellContentClick);
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "Nome";
            this.Categoria.HeaderText = "CATEGORIA";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // btnProcurarCategoriaProduto
            // 
            this.btnProcurarCategoriaProduto.BackColor = System.Drawing.Color.White;
            this.btnProcurarCategoriaProduto.Location = new System.Drawing.Point(197, 379);
            this.btnProcurarCategoriaProduto.Margin = new System.Windows.Forms.Padding(4);
            this.btnProcurarCategoriaProduto.Name = "btnProcurarCategoriaProduto";
            this.btnProcurarCategoriaProduto.Size = new System.Drawing.Size(140, 36);
            this.btnProcurarCategoriaProduto.TabIndex = 12;
            this.btnProcurarCategoriaProduto.Text = "PROCURAR";
            this.btnProcurarCategoriaProduto.UseVisualStyleBackColor = false;
            this.btnProcurarCategoriaProduto.Click += new System.EventHandler(this.btnProcurarCategoriaProduto_Click);
            // 
            // btnExcluirCategoriaProduto
            // 
            this.btnExcluirCategoriaProduto.BackColor = System.Drawing.Color.Red;
            this.btnExcluirCategoriaProduto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnExcluirCategoriaProduto.Location = new System.Drawing.Point(380, 31);
            this.btnExcluirCategoriaProduto.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluirCategoriaProduto.Name = "btnExcluirCategoriaProduto";
            this.btnExcluirCategoriaProduto.Size = new System.Drawing.Size(140, 36);
            this.btnExcluirCategoriaProduto.TabIndex = 11;
            this.btnExcluirCategoriaProduto.Text = "EXCLUIR";
            this.btnExcluirCategoriaProduto.UseVisualStyleBackColor = false;
            this.btnExcluirCategoriaProduto.Click += new System.EventHandler(this.btnExcluirCategoriaProduto_Click);
            // 
            // btnIncluirCategoriaProduto
            // 
            this.btnIncluirCategoriaProduto.BackColor = System.Drawing.Color.Blue;
            this.btnIncluirCategoriaProduto.Location = new System.Drawing.Point(197, 31);
            this.btnIncluirCategoriaProduto.Margin = new System.Windows.Forms.Padding(4);
            this.btnIncluirCategoriaProduto.Name = "btnIncluirCategoriaProduto";
            this.btnIncluirCategoriaProduto.Size = new System.Drawing.Size(140, 36);
            this.btnIncluirCategoriaProduto.TabIndex = 10;
            this.btnIncluirCategoriaProduto.Text = "CADASTRAR";
            this.btnIncluirCategoriaProduto.UseVisualStyleBackColor = false;
            this.btnIncluirCategoriaProduto.Click += new System.EventHandler(this.btnIncluirCategoriaProduto_Click);
            // 
            // btnEditarCategoria
            // 
            this.btnEditarCategoria.BackColor = System.Drawing.Color.Gold;
            this.btnEditarCategoria.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnEditarCategoria.Location = new System.Drawing.Point(16, 31);
            this.btnEditarCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarCategoria.Name = "btnEditarCategoria";
            this.btnEditarCategoria.Size = new System.Drawing.Size(133, 36);
            this.btnEditarCategoria.TabIndex = 13;
            this.btnEditarCategoria.Text = "EDITAR";
            this.btnEditarCategoria.UseVisualStyleBackColor = false;
            this.btnEditarCategoria.Click += new System.EventHandler(this.btnEditarCategoria_Click);
            // 
            // FrmCategoriaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(550, 435);
            this.Controls.Add(this.btnEditarCategoria);
            this.Controls.Add(this.btnProcurarCategoriaProduto);
            this.Controls.Add(this.btnExcluirCategoriaProduto);
            this.Controls.Add(this.btnIncluirCategoriaProduto);
            this.Controls.Add(this.dataGridCategoriaProduto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCategoriaProduto";
            this.Text = "CATEGORIA PRODUTO";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategoriaProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCategoriaProduto;
        private System.Windows.Forms.Button btnProcurarCategoriaProduto;
        private System.Windows.Forms.Button btnExcluirCategoriaProduto;
        private System.Windows.Forms.Button btnIncluirCategoriaProduto;
        private System.Windows.Forms.Button btnEditarCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
    }
}