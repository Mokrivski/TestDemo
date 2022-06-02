namespace Sueta_1
{
    partial class Firmi
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
            this.label6 = new System.Windows.Forms.Label();
            this.tbKol = new System.Windows.Forms.TextBox();
            this.btClose = new System.Windows.Forms.Button();
            this.dataGridViewfirma = new System.Windows.Forms.DataGridView();
            this.btDelete = new System.Windows.Forms.Button();
            this.btInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewfirma)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(32, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 17);
            this.label6.TabIndex = 57;
            this.label6.Text = "Название продукта";
            // 
            // tbKol
            // 
            this.tbKol.Location = new System.Drawing.Point(2, 174);
            this.tbKol.Multiline = true;
            this.tbKol.Name = "tbKol";
            this.tbKol.Size = new System.Drawing.Size(193, 28);
            this.tbKol.TabIndex = 56;
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(492, 395);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(116, 37);
            this.btClose.TabIndex = 53;
            this.btClose.Text = "Назад";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // dataGridViewfirma
            // 
            this.dataGridViewfirma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewfirma.Location = new System.Drawing.Point(201, 50);
            this.dataGridViewfirma.Name = "dataGridViewfirma";
            this.dataGridViewfirma.RowHeadersWidth = 51;
            this.dataGridViewfirma.RowTemplate.Height = 24;
            this.dataGridViewfirma.Size = new System.Drawing.Size(407, 339);
            this.dataGridViewfirma.TabIndex = 52;
            this.dataGridViewfirma.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewfirma_CellContentClick);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(417, 18);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(137, 26);
            this.btDelete.TabIndex = 51;
            this.btDelete.Text = "Удалить";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btInsert
            // 
            this.btInsert.Location = new System.Drawing.Point(274, 18);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(137, 26);
            this.btInsert.TabIndex = 49;
            this.btInsert.Text = "Добавить";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // Firmi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(624, 433);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbKol);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.dataGridViewfirma);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btInsert);
            this.Name = "Firmi";
            this.Text = "Firmi";
            this.Load += new System.EventHandler(this.Firmi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewfirma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbKol;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.DataGridView dataGridViewfirma;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btInsert;
    }
}