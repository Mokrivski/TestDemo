namespace Sueta_1
{
    partial class Objekt
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
            this.tbRazmer = new System.Windows.Forms.TextBox();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.tbStoimost = new System.Windows.Forms.TextBox();
            this.tbKolVo = new System.Windows.Forms.TextBox();
            this.btInsert = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.dataGridViewObjekt = new System.Windows.Forms.DataGridView();
            this.btClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbBrig = new System.Windows.Forms.ComboBox();
            this.brigadaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.so_AKOPDataSet2 = new Sueta_1.So_AKOPDataSet2();
            this.cbZak = new System.Windows.Forms.ComboBox();
            this.zakazchikBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.so_AKOPDataSet1 = new Sueta_1.So_AKOPDataSet1();
            this.brigadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brigadaTableAdapter = new Sueta_1.So_AKOPDataSet1TableAdapters.BrigadaTableAdapter();
            this.zakazchikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zakazchikTableAdapter = new Sueta_1.So_AKOPDataSet1TableAdapters.ZakazchikTableAdapter();
            this.zakazchikTableAdapter1 = new Sueta_1.So_AKOPDataSet2TableAdapters.ZakazchikTableAdapter();
            this.brigadaTableAdapter1 = new Sueta_1.So_AKOPDataSet2TableAdapters.BrigadaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObjekt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brigadaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.so_AKOPDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazchikBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.so_AKOPDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brigadaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazchikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbRazmer
            // 
            this.tbRazmer.Location = new System.Drawing.Point(12, 92);
            this.tbRazmer.Multiline = true;
            this.tbRazmer.Name = "tbRazmer";
            this.tbRazmer.Size = new System.Drawing.Size(193, 28);
            this.tbRazmer.TabIndex = 0;
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(12, 158);
            this.tbTime.Multiline = true;
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(193, 29);
            this.tbTime.TabIndex = 1;
            // 
            // tbStoimost
            // 
            this.tbStoimost.Location = new System.Drawing.Point(12, 232);
            this.tbStoimost.Multiline = true;
            this.tbStoimost.Name = "tbStoimost";
            this.tbStoimost.Size = new System.Drawing.Size(193, 28);
            this.tbStoimost.TabIndex = 2;
            // 
            // tbKolVo
            // 
            this.tbKolVo.Location = new System.Drawing.Point(12, 295);
            this.tbKolVo.Multiline = true;
            this.tbKolVo.Name = "tbKolVo";
            this.tbKolVo.Size = new System.Drawing.Size(193, 28);
            this.tbKolVo.TabIndex = 3;
            // 
            // btInsert
            // 
            this.btInsert.Location = new System.Drawing.Point(331, 60);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(137, 26);
            this.btInsert.TabIndex = 4;
            this.btInsert.Text = "Добавить";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(474, 60);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(137, 26);
            this.btUpdate.TabIndex = 5;
            this.btUpdate.Text = "Изменить";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(617, 60);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(137, 26);
            this.btDelete.TabIndex = 6;
            this.btDelete.Text = "Удалить";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // dataGridViewObjekt
            // 
            this.dataGridViewObjekt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewObjekt.Location = new System.Drawing.Point(215, 92);
            this.dataGridViewObjekt.Name = "dataGridViewObjekt";
            this.dataGridViewObjekt.RowHeadersWidth = 51;
            this.dataGridViewObjekt.RowTemplate.Height = 24;
            this.dataGridViewObjekt.Size = new System.Drawing.Size(950, 327);
            this.dataGridViewObjekt.TabIndex = 7;
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(1049, 425);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(116, 37);
            this.btClose.TabIndex = 8;
            this.btClose.Text = "Назад";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Корпус";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Время работы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Количество продуктов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Количество бригад";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "ID_Бригады";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "ID_Заказчика";
            // 
            // cbBrig
            // 
            this.cbBrig.DataSource = this.brigadaBindingSource1;
            this.cbBrig.DisplayMember = "Id_Brigada";
            this.cbBrig.FormattingEnabled = true;
            this.cbBrig.Location = new System.Drawing.Point(47, 362);
            this.cbBrig.Name = "cbBrig";
            this.cbBrig.Size = new System.Drawing.Size(121, 24);
            this.cbBrig.TabIndex = 15;
            // 
            // brigadaBindingSource1
            // 
            this.brigadaBindingSource1.DataMember = "Brigada";
            this.brigadaBindingSource1.DataSource = this.so_AKOPDataSet2;
            // 
            // so_AKOPDataSet2
            // 
            this.so_AKOPDataSet2.DataSetName = "So_AKOPDataSet2";
            this.so_AKOPDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbZak
            // 
            this.cbZak.DataSource = this.zakazchikBindingSource1;
            this.cbZak.DisplayMember = "Id_Zakazchik";
            this.cbZak.FormattingEnabled = true;
            this.cbZak.Location = new System.Drawing.Point(47, 412);
            this.cbZak.Name = "cbZak";
            this.cbZak.Size = new System.Drawing.Size(121, 24);
            this.cbZak.TabIndex = 16;
            this.cbZak.ValueMember = "Id_Zakazchik";
            // 
            // zakazchikBindingSource1
            // 
            this.zakazchikBindingSource1.DataMember = "Zakazchik";
            this.zakazchikBindingSource1.DataSource = this.so_AKOPDataSet2;
            // 
            // so_AKOPDataSet1
            // 
            this.so_AKOPDataSet1.DataSetName = "So_AKOPDataSet1";
            this.so_AKOPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // brigadaBindingSource
            // 
            this.brigadaBindingSource.DataMember = "Brigada";
            this.brigadaBindingSource.DataSource = this.so_AKOPDataSet1;
            // 
            // brigadaTableAdapter
            // 
            this.brigadaTableAdapter.ClearBeforeFill = true;
            // 
            // zakazchikBindingSource
            // 
            this.zakazchikBindingSource.DataMember = "Zakazchik";
            this.zakazchikBindingSource.DataSource = this.so_AKOPDataSet1;
            // 
            // zakazchikTableAdapter
            // 
            this.zakazchikTableAdapter.ClearBeforeFill = true;
            // 
            // zakazchikTableAdapter1
            // 
            this.zakazchikTableAdapter1.ClearBeforeFill = true;
            // 
            // brigadaTableAdapter1
            // 
            this.brigadaTableAdapter1.ClearBeforeFill = true;
            // 
            // Objekt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1170, 474);
            this.Controls.Add(this.cbZak);
            this.Controls.Add(this.cbBrig);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.dataGridViewObjekt);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.tbKolVo);
            this.Controls.Add(this.tbStoimost);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.tbRazmer);
            this.Name = "Objekt";
            this.Text = "Objekt";
            this.Load += new System.EventHandler(this.Objekt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObjekt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brigadaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.so_AKOPDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazchikBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.so_AKOPDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brigadaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazchikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRazmer;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.TextBox tbStoimost;
        private System.Windows.Forms.TextBox tbKolVo;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.DataGridView dataGridViewObjekt;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbBrig;
        private System.Windows.Forms.ComboBox cbZak;
        private So_AKOPDataSet1 so_AKOPDataSet1;
        private System.Windows.Forms.BindingSource brigadaBindingSource;
        private So_AKOPDataSet1TableAdapters.BrigadaTableAdapter brigadaTableAdapter;
        private System.Windows.Forms.BindingSource zakazchikBindingSource;
        private So_AKOPDataSet1TableAdapters.ZakazchikTableAdapter zakazchikTableAdapter;
        private So_AKOPDataSet2 so_AKOPDataSet2;
        private System.Windows.Forms.BindingSource zakazchikBindingSource1;
        private So_AKOPDataSet2TableAdapters.ZakazchikTableAdapter zakazchikTableAdapter1;
        private System.Windows.Forms.BindingSource brigadaBindingSource1;
        private So_AKOPDataSet2TableAdapters.BrigadaTableAdapter brigadaTableAdapter1;
    }
}