namespace Sueta_1
{
    partial class Klient
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
            this.components = new System.ComponentModel.Container();
            this.label6 = new System.Windows.Forms.Label();
            this.tbKlinika = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.dataGridViewKlient = new System.Windows.Forms.DataGridView();
            this.btDelete = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btInsert = new System.Windows.Forms.Button();
            this.tbFizLic = new System.Windows.Forms.TextBox();
            this.tbVedom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbID = new System.Windows.Forms.ComboBox();
            this.firmiBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.so_AKOPDataSet2 = new Sueta_1.So_AKOPDataSet2();
            this.so_AKOPDataSet1 = new Sueta_1.So_AKOPDataSet1();
            this.firmiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firmiTableAdapter = new Sueta_1.So_AKOPDataSet1TableAdapters.FirmiTableAdapter();
            this.firmiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.firmiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.firmiTableAdapter1 = new Sueta_1.So_AKOPDataSet2TableAdapters.FirmiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKlient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmiBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.so_AKOPDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.so_AKOPDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmiBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 46;
            this.label6.Text = "Частные заводы";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tbKlinika
            // 
            this.tbKlinika.Location = new System.Drawing.Point(2, 89);
            this.tbKlinika.Multiline = true;
            this.tbKlinika.Name = "tbKlinika";
            this.tbKlinika.Size = new System.Drawing.Size(193, 28);
            this.tbKlinika.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Физические лица";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Продуктовые магазины";
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(810, 395);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(116, 37);
            this.btClose.TabIndex = 38;
            this.btClose.Text = "Назад";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // dataGridViewKlient
            // 
            this.dataGridViewKlient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKlient.Location = new System.Drawing.Point(201, 50);
            this.dataGridViewKlient.Name = "dataGridViewKlient";
            this.dataGridViewKlient.RowHeadersWidth = 51;
            this.dataGridViewKlient.RowTemplate.Height = 24;
            this.dataGridViewKlient.Size = new System.Drawing.Size(725, 339);
            this.dataGridViewKlient.TabIndex = 37;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(603, 18);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(137, 26);
            this.btDelete.TabIndex = 36;
            this.btDelete.Text = "Удалить";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(460, 18);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(137, 26);
            this.btUpdate.TabIndex = 35;
            this.btUpdate.Text = "Изменить";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btInsert
            // 
            this.btInsert.Location = new System.Drawing.Point(317, 18);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(137, 26);
            this.btInsert.TabIndex = 34;
            this.btInsert.Text = "Добавить";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // tbFizLic
            // 
            this.tbFizLic.Location = new System.Drawing.Point(2, 269);
            this.tbFizLic.Multiline = true;
            this.tbFizLic.Name = "tbFizLic";
            this.tbFizLic.Size = new System.Drawing.Size(193, 29);
            this.tbFizLic.TabIndex = 31;
            this.tbFizLic.TextChanged += new System.EventHandler(this.tbFizLic_TextChanged);
            // 
            // tbVedom
            // 
            this.tbVedom.Location = new System.Drawing.Point(2, 178);
            this.tbVedom.Multiline = true;
            this.tbVedom.Name = "tbVedom";
            this.tbVedom.Size = new System.Drawing.Size(193, 28);
            this.tbVedom.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 47;
            this.label3.Text = "ID_Продукта";
            // 
            // cbID
            // 
            this.cbID.DataSource = this.firmiBindingSource3;
            this.cbID.DisplayMember = "Id_Firmi";
            this.cbID.FormattingEnabled = true;
            this.cbID.Location = new System.Drawing.Point(36, 354);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(121, 24);
            this.cbID.TabIndex = 48;
            // 
            // firmiBindingSource3
            // 
            this.firmiBindingSource3.DataMember = "Firmi";
            this.firmiBindingSource3.DataSource = this.so_AKOPDataSet2;
            // 
            // so_AKOPDataSet2
            // 
            this.so_AKOPDataSet2.DataSetName = "So_AKOPDataSet2";
            this.so_AKOPDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // so_AKOPDataSet1
            // 
            this.so_AKOPDataSet1.DataSetName = "So_AKOPDataSet1";
            this.so_AKOPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firmiBindingSource
            // 
            this.firmiBindingSource.DataMember = "Firmi";
            this.firmiBindingSource.DataSource = this.so_AKOPDataSet1;
            // 
            // firmiTableAdapter
            // 
            this.firmiTableAdapter.ClearBeforeFill = true;
            // 
            // firmiBindingSource1
            // 
            this.firmiBindingSource1.DataMember = "Firmi";
            this.firmiBindingSource1.DataSource = this.so_AKOPDataSet1;
            // 
            // firmiBindingSource2
            // 
            this.firmiBindingSource2.DataMember = "Firmi";
            this.firmiBindingSource2.DataSource = this.so_AKOPDataSet2;
            // 
            // firmiTableAdapter1
            // 
            this.firmiTableAdapter1.ClearBeforeFill = true;
            // 
            // Klient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(938, 450);
            this.Controls.Add(this.cbID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbKlinika);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.dataGridViewKlient);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.tbFizLic);
            this.Controls.Add(this.tbVedom);
            this.Name = "Klient";
            this.Text = "Klient";
            this.Load += new System.EventHandler(this.Klient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKlient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmiBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.so_AKOPDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.so_AKOPDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmiBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbKlinika;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.DataGridView dataGridViewKlient;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.TextBox tbFizLic;
        private System.Windows.Forms.TextBox tbVedom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbID;
        private So_AKOPDataSet1 so_AKOPDataSet1;
        private System.Windows.Forms.BindingSource firmiBindingSource;
        private So_AKOPDataSet1TableAdapters.FirmiTableAdapter firmiTableAdapter;
        private System.Windows.Forms.BindingSource firmiBindingSource1;
        private So_AKOPDataSet2 so_AKOPDataSet2;
        private System.Windows.Forms.BindingSource firmiBindingSource2;
        private So_AKOPDataSet2TableAdapters.FirmiTableAdapter firmiTableAdapter1;
        private System.Windows.Forms.BindingSource firmiBindingSource3;
    }
}