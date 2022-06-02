namespace Sueta_1
{
    partial class Sotrudnik
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.dataGridViewSotrudnik = new System.Windows.Forms.DataGridView();
            this.btDelete = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btInsert = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbTelephone = new System.Windows.Forms.TextBox();
            this.tbOthestvo = new System.Windows.Forms.TextBox();
            this.tbFamiliya = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPasport = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbID = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.so_AKOPDataSet1 = new Sueta_1.So_AKOPDataSet1();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postTableAdapter = new Sueta_1.So_AKOPDataSet1TableAdapters.PostTableAdapter();
            this.so_AKOPDataSet2 = new Sueta_1.So_AKOPDataSet2();
            this.postBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.postTableAdapter1 = new Sueta_1.So_AKOPDataSet2TableAdapters.PostTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSotrudnik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.so_AKOPDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.so_AKOPDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Почта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Номер телефона";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Отчество сотрудника";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Фамилия Сотрудника";
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(1137, 501);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(116, 37);
            this.btClose.TabIndex = 21;
            this.btClose.Text = "Назад";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // dataGridViewSotrudnik
            // 
            this.dataGridViewSotrudnik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSotrudnik.Location = new System.Drawing.Point(203, 56);
            this.dataGridViewSotrudnik.Name = "dataGridViewSotrudnik";
            this.dataGridViewSotrudnik.RowHeadersWidth = 51;
            this.dataGridViewSotrudnik.RowTemplate.Height = 24;
            this.dataGridViewSotrudnik.Size = new System.Drawing.Size(1079, 433);
            this.dataGridViewSotrudnik.TabIndex = 20;
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
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(4, 326);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(193, 28);
            this.tbEmail.TabIndex = 16;
            // 
            // tbTelephone
            // 
            this.tbTelephone.Location = new System.Drawing.Point(4, 263);
            this.tbTelephone.Multiline = true;
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(193, 28);
            this.tbTelephone.TabIndex = 15;
            // 
            // tbOthestvo
            // 
            this.tbOthestvo.Location = new System.Drawing.Point(4, 201);
            this.tbOthestvo.Multiline = true;
            this.tbOthestvo.Name = "tbOthestvo";
            this.tbOthestvo.Size = new System.Drawing.Size(193, 29);
            this.tbOthestvo.TabIndex = 14;
            // 
            // tbFamiliya
            // 
            this.tbFamiliya.Location = new System.Drawing.Point(4, 142);
            this.tbFamiliya.Multiline = true;
            this.tbFamiliya.Name = "tbFamiliya";
            this.tbFamiliya.Size = new System.Drawing.Size(193, 28);
            this.tbFamiliya.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Данные паспорта";
            // 
            // tbPasport
            // 
            this.tbPasport.Location = new System.Drawing.Point(4, 391);
            this.tbPasport.Multiline = true;
            this.tbPasport.Name = "tbPasport";
            this.tbPasport.Size = new System.Drawing.Size(193, 28);
            this.tbPasport.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Имя сотрудника";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(4, 77);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(193, 28);
            this.tbName.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 481);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "ID_Post";
            // 
            // cbID
            // 
            this.cbID.DataSource = this.postBindingSource1;
            this.cbID.DisplayMember = "Id_Post";
            this.cbID.FormattingEnabled = true;
            this.cbID.Location = new System.Drawing.Point(46, 501);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(121, 24);
            this.cbID.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(76, 422);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "Пароль";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 442);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 29);
            this.textBox1.TabIndex = 33;
            // 
            // so_AKOPDataSet1
            // 
            this.so_AKOPDataSet1.DataSetName = "So_AKOPDataSet1";
            this.so_AKOPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataMember = "Post";
            this.postBindingSource.DataSource = this.so_AKOPDataSet1;
            // 
            // postTableAdapter
            // 
            this.postTableAdapter.ClearBeforeFill = true;
            // 
            // so_AKOPDataSet2
            // 
            this.so_AKOPDataSet2.DataSetName = "So_AKOPDataSet2";
            this.so_AKOPDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postBindingSource1
            // 
            this.postBindingSource1.DataMember = "Post";
            this.postBindingSource1.DataSource = this.so_AKOPDataSet2;
            // 
            // postTableAdapter1
            // 
            this.postTableAdapter1.ClearBeforeFill = true;
            // 
            // Sotrudnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1316, 545);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbPasport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.dataGridViewSotrudnik);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbTelephone);
            this.Controls.Add(this.tbOthestvo);
            this.Controls.Add(this.tbFamiliya);
            this.Name = "Sotrudnik";
            this.Text = "Sotrudnik";
            this.Load += new System.EventHandler(this.Sotrudnik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSotrudnik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.so_AKOPDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.so_AKOPDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.DataGridView dataGridViewSotrudnik;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbTelephone;
        private System.Windows.Forms.TextBox tbOthestvo;
        private System.Windows.Forms.TextBox tbFamiliya;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPasport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private So_AKOPDataSet1 so_AKOPDataSet1;
        private System.Windows.Forms.BindingSource postBindingSource;
        private So_AKOPDataSet1TableAdapters.PostTableAdapter postTableAdapter;
        private So_AKOPDataSet2 so_AKOPDataSet2;
        private System.Windows.Forms.BindingSource postBindingSource1;
        private So_AKOPDataSet2TableAdapters.PostTableAdapter postTableAdapter1;
    }
}