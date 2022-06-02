namespace Sueta_1
{
    partial class Brigada
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.dataGridViewBrigada = new System.Windows.Forms.DataGridView();
            this.btDelete = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btInsert = new System.Windows.Forms.Button();
            this.tbSpecial = new System.Windows.Forms.TextBox();
            this.tbKolSotr = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.so_AKOPDataSet = new Sueta_1.So_AKOPDataSet();
            this.brigadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brigadaTableAdapter = new Sueta_1.So_AKOPDataSetTableAdapters.BrigadaTableAdapter();
            this.sotrudnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sotrudnikTableAdapter = new Sueta_1.So_AKOPDataSetTableAdapters.SotrudnikTableAdapter();
            this.cbID = new System.Windows.Forms.ComboBox();
            this.sotrudnikBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.so_AKOPDataSet1 = new Sueta_1.So_AKOPDataSet1();
            this.sotrudnikBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sotrudnikBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sotrudnikTableAdapter1 = new Sueta_1.So_AKOPDataSet1TableAdapters.SotrudnikTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBrigada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.so_AKOPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brigadaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.so_AKOPDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Специализация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Количество сотрудников";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Название бригады";
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(820, 401);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(116, 37);
            this.btClose.TabIndex = 21;
            this.btClose.Text = "Назад";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // dataGridViewBrigada
            // 
            this.dataGridViewBrigada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBrigada.Location = new System.Drawing.Point(203, 56);
            this.dataGridViewBrigada.Name = "dataGridViewBrigada";
            this.dataGridViewBrigada.RowHeadersWidth = 51;
            this.dataGridViewBrigada.RowTemplate.Height = 24;
            this.dataGridViewBrigada.Size = new System.Drawing.Size(733, 339);
            this.dataGridViewBrigada.TabIndex = 20;
            this.dataGridViewBrigada.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBrigada_CellContentClick);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(605, 24);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(137, 26);
            this.btDelete.TabIndex = 19;
            this.btDelete.Text = "Удалить";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(462, 24);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(137, 26);
            this.btUpdate.TabIndex = 18;
            this.btUpdate.Text = "Изменить";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btInsert
            // 
            this.btInsert.Location = new System.Drawing.Point(319, 24);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(137, 26);
            this.btInsert.TabIndex = 17;
            this.btInsert.Text = "Добавить";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // tbSpecial
            // 
            this.tbSpecial.Location = new System.Drawing.Point(4, 271);
            this.tbSpecial.Multiline = true;
            this.tbSpecial.Name = "tbSpecial";
            this.tbSpecial.Size = new System.Drawing.Size(193, 28);
            this.tbSpecial.TabIndex = 15;
            // 
            // tbKolSotr
            // 
            this.tbKolSotr.Location = new System.Drawing.Point(4, 191);
            this.tbKolSotr.Multiline = true;
            this.tbKolSotr.Name = "tbKolSotr";
            this.tbKolSotr.Size = new System.Drawing.Size(193, 29);
            this.tbKolSotr.TabIndex = 14;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(4, 99);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(193, 28);
            this.tbName.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Id Сотрудника";
            // 
            // so_AKOPDataSet
            // 
            this.so_AKOPDataSet.DataSetName = "So_AKOPDataSet";
            this.so_AKOPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // brigadaBindingSource
            // 
            this.brigadaBindingSource.DataMember = "Brigada";
            this.brigadaBindingSource.DataSource = this.so_AKOPDataSet;
            // 
            // brigadaTableAdapter
            // 
            this.brigadaTableAdapter.ClearBeforeFill = true;
            // 
            // sotrudnikBindingSource
            // 
            this.sotrudnikBindingSource.DataMember = "Sotrudnik";
            this.sotrudnikBindingSource.DataSource = this.so_AKOPDataSet;
            // 
            // sotrudnikTableAdapter
            // 
            this.sotrudnikTableAdapter.ClearBeforeFill = true;
            // 
            // cbID
            // 
            this.cbID.DataSource = this.sotrudnikBindingSource3;
            this.cbID.DisplayMember = "Id_Sotrudnik";
            this.cbID.FormattingEnabled = true;
            this.cbID.Location = new System.Drawing.Point(15, 347);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(158, 24);
            this.cbID.TabIndex = 26;
            this.cbID.ValueMember = "Id_Sotrudnik";
            // 
            // sotrudnikBindingSource3
            // 
            this.sotrudnikBindingSource3.DataMember = "Sotrudnik";
            this.sotrudnikBindingSource3.DataSource = this.so_AKOPDataSet1;
            // 
            // so_AKOPDataSet1
            // 
            this.so_AKOPDataSet1.DataSetName = "So_AKOPDataSet1";
            this.so_AKOPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sotrudnikBindingSource1
            // 
            this.sotrudnikBindingSource1.DataMember = "Sotrudnik";
            this.sotrudnikBindingSource1.DataSource = this.so_AKOPDataSet;
            // 
            // sotrudnikBindingSource2
            // 
            this.sotrudnikBindingSource2.DataMember = "Sotrudnik";
            this.sotrudnikBindingSource2.DataSource = this.so_AKOPDataSet;
            // 
            // sotrudnikTableAdapter1
            // 
            this.sotrudnikTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 32);
            this.button1.TabIndex = 27;
            this.button1.Text = "Экспорт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Brigada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(948, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.dataGridViewBrigada);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.tbSpecial);
            this.Controls.Add(this.tbKolSotr);
            this.Controls.Add(this.tbName);
            this.Name = "Brigada";
            this.Load += new System.EventHandler(this.Brigada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBrigada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.so_AKOPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brigadaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.so_AKOPDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.DataGridView dataGridViewBrigada;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.TextBox tbSpecial;
        private System.Windows.Forms.TextBox tbKolSotr;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label4;
        private So_AKOPDataSet so_AKOPDataSet;
        private System.Windows.Forms.BindingSource brigadaBindingSource;
        private So_AKOPDataSetTableAdapters.BrigadaTableAdapter brigadaTableAdapter;
        private System.Windows.Forms.BindingSource sotrudnikBindingSource;
        private So_AKOPDataSetTableAdapters.SotrudnikTableAdapter sotrudnikTableAdapter;
        private System.Windows.Forms.ComboBox cbID;
        private System.Windows.Forms.BindingSource sotrudnikBindingSource1;
        private System.Windows.Forms.BindingSource sotrudnikBindingSource2;
        private So_AKOPDataSet1 so_AKOPDataSet1;
        private System.Windows.Forms.BindingSource sotrudnikBindingSource3;
        private So_AKOPDataSet1TableAdapters.SotrudnikTableAdapter sotrudnikTableAdapter1;
        private System.Windows.Forms.Button button1;
    }
}