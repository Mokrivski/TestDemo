namespace Sueta_1
{
    partial class Admin
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
            this.btSotrudnik = new System.Windows.Forms.Button();
            this.btZakazchik = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSotrudnik
            // 
            this.btSotrudnik.Location = new System.Drawing.Point(425, 192);
            this.btSotrudnik.Name = "btSotrudnik";
            this.btSotrudnik.Size = new System.Drawing.Size(213, 40);
            this.btSotrudnik.TabIndex = 1;
            this.btSotrudnik.Text = "Сотрудники";
            this.btSotrudnik.UseVisualStyleBackColor = true;
            this.btSotrudnik.Click += new System.EventHandler(this.btSotrudnik_Click);
            // 
            // btZakazchik
            // 
            this.btZakazchik.Location = new System.Drawing.Point(139, 192);
            this.btZakazchik.Name = "btZakazchik";
            this.btZakazchik.Size = new System.Drawing.Size(213, 40);
            this.btZakazchik.TabIndex = 2;
            this.btZakazchik.Text = "Заказчик";
            this.btZakazchik.UseVisualStyleBackColor = true;
            this.btZakazchik.Click += new System.EventHandler(this.btZakazchik_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "Администратор";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(696, 401);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(92, 37);
            this.btClose.TabIndex = 4;
            this.btClose.Text = "Назад";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 5;
            this.label2.Visible = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btZakazchik);
            this.Controls.Add(this.btSotrudnik);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSotrudnik;
        private System.Windows.Forms.Button btZakazchik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label label2;
    }
}