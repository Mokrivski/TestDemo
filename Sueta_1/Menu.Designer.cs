namespace Sueta_1
{
    partial class Menu
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
            this.btObjekt = new System.Windows.Forms.Button();
            this.btFirma = new System.Windows.Forms.Button();
            this.btBrigada = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btObjekt
            // 
            this.btObjekt.Location = new System.Drawing.Point(113, 120);
            this.btObjekt.Name = "btObjekt";
            this.btObjekt.Size = new System.Drawing.Size(213, 40);
            this.btObjekt.TabIndex = 2;
            this.btObjekt.Text = "Корпус";
            this.btObjekt.UseVisualStyleBackColor = true;
            this.btObjekt.Click += new System.EventHandler(this.btObjekt_Click);
            // 
            // btFirma
            // 
            this.btFirma.Location = new System.Drawing.Point(281, 186);
            this.btFirma.Name = "btFirma";
            this.btFirma.Size = new System.Drawing.Size(213, 40);
            this.btFirma.TabIndex = 3;
            this.btFirma.Text = "Продукты";
            this.btFirma.UseVisualStyleBackColor = true;
            this.btFirma.Click += new System.EventHandler(this.btFirma_Click);
            // 
            // btBrigada
            // 
            this.btBrigada.Location = new System.Drawing.Point(447, 120);
            this.btBrigada.Name = "btBrigada";
            this.btBrigada.Size = new System.Drawing.Size(213, 40);
            this.btBrigada.TabIndex = 4;
            this.btBrigada.Text = "Бригады поваров";
            this.btBrigada.UseVisualStyleBackColor = true;
            this.btBrigada.Click += new System.EventHandler(this.btBrigada_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(713, 402);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(90, 36);
            this.btClose.TabIndex = 7;
            this.btClose.Text = "Выход";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 55);
            this.label1.TabIndex = 8;
            this.label1.Text = "СТОЛОВАЯ МПТ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(815, 36);
            this.label2.TabIndex = 9;
            this.label2.Text = "Начальник";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(815, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btBrigada);
            this.Controls.Add(this.btFirma);
            this.Controls.Add(this.btObjekt);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btObjekt;
        private System.Windows.Forms.Button btFirma;
        private System.Windows.Forms.Button btBrigada;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}