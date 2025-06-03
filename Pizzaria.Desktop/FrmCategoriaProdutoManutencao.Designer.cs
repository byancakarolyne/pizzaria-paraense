namespace Pizzaria.Desktop
{
    partial class FrmCategoriaProdutoManutencao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategoriaProdutoManutencao));
            this.btnSalvarCategoriaProduto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoCategoriaProduto = new System.Windows.Forms.TextBox();
            this.txtNomeCategoriaProduto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalvarCategoriaProduto
            // 
            this.btnSalvarCategoriaProduto.BackColor = System.Drawing.Color.Green;
            this.btnSalvarCategoriaProduto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnSalvarCategoriaProduto.Location = new System.Drawing.Point(220, 110);
            this.btnSalvarCategoriaProduto.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvarCategoriaProduto.Name = "btnSalvarCategoriaProduto";
            this.btnSalvarCategoriaProduto.Size = new System.Drawing.Size(169, 42);
            this.btnSalvarCategoriaProduto.TabIndex = 0;
            this.btnSalvarCategoriaProduto.Text = "SALVAR";
            this.btnSalvarCategoriaProduto.UseVisualStyleBackColor = false;
            this.btnSalvarCategoriaProduto.Click += new System.EventHandler(this.btnSalvarCategoriaProduto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOME CATEGORIA";
            // 
            // txtCodigoCategoriaProduto
            // 
            this.txtCodigoCategoriaProduto.Enabled = false;
            this.txtCodigoCategoriaProduto.Location = new System.Drawing.Point(182, 22);
            this.txtCodigoCategoriaProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoCategoriaProduto.Name = "txtCodigoCategoriaProduto";
            this.txtCodigoCategoriaProduto.Size = new System.Drawing.Size(295, 22);
            this.txtCodigoCategoriaProduto.TabIndex = 3;
            // 
            // txtNomeCategoriaProduto
            // 
            this.txtNomeCategoriaProduto.Location = new System.Drawing.Point(182, 61);
            this.txtNomeCategoriaProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeCategoriaProduto.Name = "txtNomeCategoriaProduto";
            this.txtNomeCategoriaProduto.Size = new System.Drawing.Size(295, 22);
            this.txtNomeCategoriaProduto.TabIndex = 4;
            // 
            // FrmCategoriaProdutoManutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(504, 165);
            this.Controls.Add(this.txtNomeCategoriaProduto);
            this.Controls.Add(this.txtCodigoCategoriaProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvarCategoriaProduto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCategoriaProdutoManutencao";
            this.Text = "CADASTRO CATEGORIA PRODUTO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvarCategoriaProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoCategoriaProduto;
        private System.Windows.Forms.TextBox txtNomeCategoriaProduto;
    }
}