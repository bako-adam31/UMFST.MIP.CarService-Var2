namespace UMFST.MIP.CarService
{
    partial class MainWindow
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageWorkOrders = new System.Windows.Forms.TabPage();
            this.dgvWorkOrders = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.tabPageClients = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvClinets = new System.Windows.Forms.DataGridView();
            this.dgvCars = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMake = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageDiagnostics = new System.Windows.Forms.TabPage();
            this.dgvTests = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageWorkOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkOrders)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPageClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClinets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPageDiagnostics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTests)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageWorkOrders);
            this.tabControl1.Controls.Add(this.tabPageClients);
            this.tabControl1.Controls.Add(this.tabPageDiagnostics);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1371, 807);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageWorkOrders
            // 
            this.tabPageWorkOrders.Controls.Add(this.dgvWorkOrders);
            this.tabPageWorkOrders.Controls.Add(this.panel1);
            this.tabPageWorkOrders.Location = new System.Drawing.Point(8, 39);
            this.tabPageWorkOrders.Name = "tabPageWorkOrders";
            this.tabPageWorkOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWorkOrders.Size = new System.Drawing.Size(1355, 760);
            this.tabPageWorkOrders.TabIndex = 0;
            this.tabPageWorkOrders.Text = "Work Orders";
            this.tabPageWorkOrders.UseVisualStyleBackColor = true;
            // 
            // dgvWorkOrders
            // 
            this.dgvWorkOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWorkOrders.Location = new System.Drawing.Point(3, 3);
            this.dgvWorkOrders.Name = "dgvWorkOrders";
            this.dgvWorkOrders.RowHeadersWidth = 82;
            this.dgvWorkOrders.RowTemplate.Height = 33;
            this.dgvWorkOrders.Size = new System.Drawing.Size(1349, 505);
            this.dgvWorkOrders.TabIndex = 1;
            this.dgvWorkOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorkOrders_CellContentClick);
            this.dgvWorkOrders.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvWorkOrders_CellFormatting);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 508);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1349, 249);
            this.panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(527, 16);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(138, 60);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(361, 16);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(140, 60);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(197, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 60);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(18, 16);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(173, 60);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "EXPORT SUMMARY";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // tabPageClients
            // 
            this.tabPageClients.Controls.Add(this.splitContainer1);
            this.tabPageClients.Controls.Add(this.panel2);
            this.tabPageClients.Location = new System.Drawing.Point(8, 39);
            this.tabPageClients.Name = "tabPageClients";
            this.tabPageClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClients.Size = new System.Drawing.Size(1355, 760);
            this.tabPageClients.TabIndex = 1;
            this.tabPageClients.Text = "Clients & Cars";
            this.tabPageClients.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 359);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvClinets);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvCars);
            this.splitContainer1.Size = new System.Drawing.Size(1349, 398);
            this.splitContainer1.SplitterDistance = 646;
            this.splitContainer1.TabIndex = 1;
            // 
            // dgvClinets
            // 
            this.dgvClinets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClinets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClinets.Location = new System.Drawing.Point(0, 0);
            this.dgvClinets.Name = "dgvClinets";
            this.dgvClinets.RowHeadersWidth = 82;
            this.dgvClinets.RowTemplate.Height = 33;
            this.dgvClinets.Size = new System.Drawing.Size(646, 398);
            this.dgvClinets.TabIndex = 0;
            this.dgvClinets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClinets_CellContentClick);
            this.dgvClinets.SelectionChanged += new System.EventHandler(this.dgvClinets_SelectionChanged);
            // 
            // dgvCars
            // 
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCars.Location = new System.Drawing.Point(0, 0);
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.RowHeadersWidth = 82;
            this.dgvCars.RowTemplate.Height = 33;
            this.dgvCars.Size = new System.Drawing.Size(699, 398);
            this.dgvCars.TabIndex = 0;
            this.dgvCars.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCars_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnFilter);
            this.panel2.Controls.Add(this.txtYear);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmbMake);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1349, 356);
            this.panel2.TabIndex = 0;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(30, 153);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(143, 46);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "FILTER";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(139, 77);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(121, 31);
            this.txtYear.TabIndex = 3;
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Year";
            // 
            // cmbMake
            // 
            this.cmbMake.FormattingEnabled = true;
            this.cmbMake.Location = new System.Drawing.Point(139, 16);
            this.cmbMake.Name = "cmbMake";
            this.cmbMake.Size = new System.Drawing.Size(121, 33);
            this.cmbMake.TabIndex = 1;
            this.cmbMake.SelectedIndexChanged += new System.EventHandler(this.cmbMake_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make";
            // 
            // tabPageDiagnostics
            // 
            this.tabPageDiagnostics.Controls.Add(this.dgvTests);
            this.tabPageDiagnostics.Controls.Add(this.panel3);
            this.tabPageDiagnostics.Location = new System.Drawing.Point(8, 39);
            this.tabPageDiagnostics.Name = "tabPageDiagnostics";
            this.tabPageDiagnostics.Size = new System.Drawing.Size(1355, 760);
            this.tabPageDiagnostics.TabIndex = 2;
            this.tabPageDiagnostics.Text = "Diagnostics";
            this.tabPageDiagnostics.UseVisualStyleBackColor = true;
            // 
            // dgvTests
            // 
            this.dgvTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTests.Location = new System.Drawing.Point(0, 0);
            this.dgvTests.Name = "dgvTests";
            this.dgvTests.RowHeadersWidth = 82;
            this.dgvTests.RowTemplate.Height = 33;
            this.dgvTests.Size = new System.Drawing.Size(1355, 451);
            this.dgvTests.TabIndex = 1;
            this.dgvTests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTests_CellContentClick);
            this.dgvTests.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTests_CellFormatting);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnReset);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 451);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1355, 309);
            this.panel3.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(14, 19);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(332, 54);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset DB + Reimport JSON";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 807);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageWorkOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkOrders)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabPageClients.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClinets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPageDiagnostics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTests)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageWorkOrders;
        private System.Windows.Forms.TabPage tabPageClients;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPageDiagnostics;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbMake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvClinets;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCars;
        private System.Windows.Forms.DataGridView dgvTests;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvWorkOrders;
    }
}

