namespace StariApp
{
    partial class Form6
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trajanjeUHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeIPrezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stariAppDBDataSet9 = new StariApp.StariAppDBDataSet9();
            this.workViewTableAdapter = new StariApp.StariAppDBDataSet9TableAdapters.WorkViewTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idZaposlenikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeIPrezimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stariAppDBDataSet10 = new StariApp.StariAppDBDataSet10();
            this.workersViewTableAdapter = new StariApp.StariAppDBDataSet10TableAdapters.WorkersViewTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stariAppDBDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stariAppDBDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 83);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(133, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(12, 119);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(133, 20);
            this.textBox6.TabIndex = 4;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id radnika u danu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Trajanje(Sati)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Datum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Id Posla";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Nadodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(12, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Izbriši";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.trajanjeUHDataGridViewTextBoxColumn,
            this.imeIPrezimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.workViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(344, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 210);
            this.dataGridView1.TabIndex = 13;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // trajanjeUHDataGridViewTextBoxColumn
            // 
            this.trajanjeUHDataGridViewTextBoxColumn.DataPropertyName = "Trajanje u h";
            this.trajanjeUHDataGridViewTextBoxColumn.HeaderText = "Trajanje u h";
            this.trajanjeUHDataGridViewTextBoxColumn.Name = "trajanjeUHDataGridViewTextBoxColumn";
            // 
            // imeIPrezimeDataGridViewTextBoxColumn
            // 
            this.imeIPrezimeDataGridViewTextBoxColumn.DataPropertyName = "Ime i Prezime";
            this.imeIPrezimeDataGridViewTextBoxColumn.HeaderText = "Ime i Prezime";
            this.imeIPrezimeDataGridViewTextBoxColumn.Name = "imeIPrezimeDataGridViewTextBoxColumn";
            this.imeIPrezimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workViewBindingSource
            // 
            this.workViewBindingSource.DataMember = "WorkView";
            this.workViewBindingSource.DataSource = this.stariAppDBDataSet9;
            // 
            // stariAppDBDataSet9
            // 
            this.stariAppDBDataSet9.DataSetName = "StariAppDBDataSet9";
            this.stariAppDBDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workViewTableAdapter
            // 
            this.workViewTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idZaposlenikaDataGridViewTextBoxColumn,
            this.imeIPrezimeDataGridViewTextBoxColumn1,
            this.positionDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.workersViewBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(445, 246);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(343, 192);
            this.dataGridView2.TabIndex = 14;
            // 
            // idZaposlenikaDataGridViewTextBoxColumn
            // 
            this.idZaposlenikaDataGridViewTextBoxColumn.DataPropertyName = "Id Zaposlenika";
            this.idZaposlenikaDataGridViewTextBoxColumn.HeaderText = "Id Zaposlenika";
            this.idZaposlenikaDataGridViewTextBoxColumn.Name = "idZaposlenikaDataGridViewTextBoxColumn";
            // 
            // imeIPrezimeDataGridViewTextBoxColumn1
            // 
            this.imeIPrezimeDataGridViewTextBoxColumn1.DataPropertyName = "Ime i Prezime";
            this.imeIPrezimeDataGridViewTextBoxColumn1.HeaderText = "Ime i Prezime";
            this.imeIPrezimeDataGridViewTextBoxColumn1.Name = "imeIPrezimeDataGridViewTextBoxColumn1";
            this.imeIPrezimeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // workersViewBindingSource
            // 
            this.workersViewBindingSource.DataMember = "WorkersView";
            this.workersViewBindingSource.DataSource = this.stariAppDBDataSet10;
            // 
            // stariAppDBDataSet10
            // 
            this.stariAppDBDataSet10.DataSetName = "StariAppDBDataSet10";
            this.stariAppDBDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workersViewTableAdapter
            // 
            this.workersViewTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(309, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "*U redak Id radnika u danu se unose Id-jevi radnika s razmakom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "*Brisanje posla se izvršava tako da se unese Id posla";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(109, 206);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stariAppDBDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stariAppDBDataSet10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private StariAppDBDataSet9 stariAppDBDataSet9;
        private System.Windows.Forms.BindingSource workViewBindingSource;
        private StariAppDBDataSet9TableAdapters.WorkViewTableAdapter workViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trajanjeUHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeIPrezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private StariAppDBDataSet10 stariAppDBDataSet10;
        private System.Windows.Forms.BindingSource workersViewBindingSource;
        private StariAppDBDataSet10TableAdapters.WorkersViewTableAdapter workersViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idZaposlenikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeIPrezimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}