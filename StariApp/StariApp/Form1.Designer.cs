namespace StariApp
{
    partial class form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.eventsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stariAppDBDataSet6 = new StariApp.StariAppDBDataSet6();
            this.eventsViewTableAdapter = new StariApp.StariAppDBDataSet6TableAdapters.EventsViewTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SideMenuPanel = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.eventsViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stariAppDBDataSet6)).BeginInit();
            this.SideMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventsViewBindingSource
            // 
            this.eventsViewBindingSource.DataMember = "EventsView";
            this.eventsViewBindingSource.DataSource = this.stariAppDBDataSet6;
            // 
            // stariAppDBDataSet6
            // 
            this.stariAppDBDataSet6.DataSetName = "StariAppDBDataSet6";
            this.stariAppDBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventsViewTableAdapter
            // 
            this.eventsViewTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 485);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(136, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "Zaposlenici";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(0, 421);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 64);
            this.button2.TabIndex = 1;
            this.button2.Text = "Resursi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(0, 357);
            this.button4.Name = "button4";
            this.button4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button4.Size = new System.Drawing.Size(136, 64);
            this.button4.TabIndex = 2;
            this.button4.Text = "Napomene";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(0, 293);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 64);
            this.button3.TabIndex = 3;
            this.button3.Text = "Pozicije";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(0, 229);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 64);
            this.button5.TabIndex = 4;
            this.button5.Text = "Radovi";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // SideMenuPanel
            // 
            this.SideMenuPanel.Controls.Add(this.button7);
            this.SideMenuPanel.Controls.Add(this.panel1);
            this.SideMenuPanel.Controls.Add(this.button6);
            this.SideMenuPanel.Controls.Add(this.button5);
            this.SideMenuPanel.Controls.Add(this.button3);
            this.SideMenuPanel.Controls.Add(this.button4);
            this.SideMenuPanel.Controls.Add(this.button2);
            this.SideMenuPanel.Controls.Add(this.button1);
            this.SideMenuPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.SideMenuPanel.Location = new System.Drawing.Point(750, 0);
            this.SideMenuPanel.Name = "SideMenuPanel";
            this.SideMenuPanel.Size = new System.Drawing.Size(136, 549);
            this.SideMenuPanel.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(0, 101);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(136, 64);
            this.button7.TabIndex = 7;
            this.button7.Text = "Period";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 104);
            this.panel1.TabIndex = 6;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(0, 165);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(136, 64);
            this.button6.TabIndex = 5;
            this.button6.Text = "Skladište";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(723, 525);
            this.panel2.TabIndex = 1;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(886, 549);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SideMenuPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "form1";
            this.Text = "Aplikacija_Rad";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventsViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stariAppDBDataSet6)).EndInit();
            this.SideMenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private StariAppDBDataSet6 stariAppDBDataSet6;
        private System.Windows.Forms.BindingSource eventsViewBindingSource;
        private StariAppDBDataSet6TableAdapters.EventsViewTableAdapter eventsViewTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel SideMenuPanel;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel2;
    }
}

