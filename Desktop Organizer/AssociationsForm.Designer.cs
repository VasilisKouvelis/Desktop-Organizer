namespace Desktop_Organizer
{
    partial class AssociationsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssociationsForm));
            this.accsView = new System.Windows.Forms.ListView();
            this.extenionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.destPathHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.exitBtn = new System.Windows.Forms.Button();
            this.editPanel = new System.Windows.Forms.Panel();
            this.closeEditPanelBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.editFilterBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addFilterBtn = new System.Windows.Forms.Button();
            this.browseBtn = new System.Windows.Forms.Button();
            this.extensionTxt = new System.Windows.Forms.TextBox();
            this.destpathTxt = new System.Windows.Forms.TextBox();
            this.addEditBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.folderPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addFolder = new System.Windows.Forms.Button();
            this.folderBrowerBtn = new System.Windows.Forms.Button();
            this.shortcutTxt = new System.Windows.Forms.TextBox();
            this.folderTxt = new System.Windows.Forms.TextBox();
            this.folderLV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.editPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.folderPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // accsView
            // 
            this.accsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.extenionHeader,
            this.destPathHeader});
            this.accsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accsView.FullRowSelect = true;
            this.accsView.GridLines = true;
            this.accsView.Location = new System.Drawing.Point(3, 3);
            this.accsView.MultiSelect = false;
            this.accsView.Name = "accsView";
            this.accsView.Size = new System.Drawing.Size(537, 537);
            this.accsView.TabIndex = 0;
            this.accsView.UseCompatibleStateImageBehavior = false;
            this.accsView.View = System.Windows.Forms.View.Details;
            this.accsView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.accsView_MouseDoubleClick);
            // 
            // extenionHeader
            // 
            this.extenionHeader.Text = "Extension";
            this.extenionHeader.Width = 104;
            // 
            // destPathHeader
            // 
            this.destPathHeader.Text = "Destination Path";
            this.destPathHeader.Width = 429;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(459, 573);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(88, 32);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Save && Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // editPanel
            // 
            this.editPanel.BackColor = System.Drawing.SystemColors.Control;
            this.editPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editPanel.Controls.Add(this.closeEditPanelBtn);
            this.editPanel.Controls.Add(this.groupBox1);
            this.editPanel.Location = new System.Drawing.Point(53, 168);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(436, 207);
            this.editPanel.TabIndex = 2;
            this.editPanel.Visible = false;
            // 
            // closeEditPanelBtn
            // 
            this.closeEditPanelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeEditPanelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeEditPanelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeEditPanelBtn.Location = new System.Drawing.Point(410, -1);
            this.closeEditPanelBtn.Name = "closeEditPanelBtn";
            this.closeEditPanelBtn.Size = new System.Drawing.Size(25, 25);
            this.closeEditPanelBtn.TabIndex = 13;
            this.closeEditPanelBtn.Text = "X";
            this.closeEditPanelBtn.UseVisualStyleBackColor = true;
            this.closeEditPanelBtn.Click += new System.EventHandler(this.closeEditPanelBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.editFilterBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.addFilterBtn);
            this.groupBox1.Controls.Add(this.browseBtn);
            this.groupBox1.Controls.Add(this.extensionTxt);
            this.groupBox1.Controls.Add(this.destpathTxt);
            this.groupBox1.Location = new System.Drawing.Point(8, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 166);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Edit Filter";
            // 
            // editFilterBtn
            // 
            this.editFilterBtn.Location = new System.Drawing.Point(153, 100);
            this.editFilterBtn.Name = "editFilterBtn";
            this.editFilterBtn.Size = new System.Drawing.Size(118, 46);
            this.editFilterBtn.TabIndex = 14;
            this.editFilterBtn.Text = "Edit Filter";
            this.editFilterBtn.UseVisualStyleBackColor = true;
            this.editFilterBtn.Visible = false;
            this.editFilterBtn.Click += new System.EventHandler(this.editFilterBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Where to move:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Extension:";
            // 
            // addFilterBtn
            // 
            this.addFilterBtn.Location = new System.Drawing.Point(147, 100);
            this.addFilterBtn.Name = "addFilterBtn";
            this.addFilterBtn.Size = new System.Drawing.Size(118, 46);
            this.addFilterBtn.TabIndex = 8;
            this.addFilterBtn.Text = "Add Filter";
            this.addFilterBtn.UseVisualStyleBackColor = true;
            this.addFilterBtn.Click += new System.EventHandler(this.addAsc_Click);
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(368, 74);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(44, 20);
            this.browseBtn.TabIndex = 11;
            this.browseBtn.Text = "...";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // extensionTxt
            // 
            this.extensionTxt.Location = new System.Drawing.Point(6, 35);
            this.extensionTxt.Name = "extensionTxt";
            this.extensionTxt.Size = new System.Drawing.Size(406, 20);
            this.extensionTxt.TabIndex = 9;
            // 
            // destpathTxt
            // 
            this.destpathTxt.Location = new System.Drawing.Point(6, 74);
            this.destpathTxt.Name = "destpathTxt";
            this.destpathTxt.Size = new System.Drawing.Size(356, 20);
            this.destpathTxt.TabIndex = 10;
            // 
            // addEditBtn
            // 
            this.addEditBtn.Location = new System.Drawing.Point(7, 573);
            this.addEditBtn.Name = "addEditBtn";
            this.addEditBtn.Size = new System.Drawing.Size(88, 32);
            this.addEditBtn.TabIndex = 3;
            this.addEditBtn.Text = "Add New";
            this.addEditBtn.UseVisualStyleBackColor = true;
            this.addEditBtn.Click += new System.EventHandler(this.addEditBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(101, 573);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(88, 32);
            this.removeBtn.TabIndex = 6;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(551, 569);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.editPanel);
            this.tabPage1.Controls.Add(this.accsView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(543, 543);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Extensions";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.folderPanel);
            this.tabPage2.Controls.Add(this.folderLV);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(543, 543);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Custom Folders";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // folderPanel
            // 
            this.folderPanel.BackColor = System.Drawing.SystemColors.Control;
            this.folderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.folderPanel.Controls.Add(this.button1);
            this.folderPanel.Controls.Add(this.groupBox2);
            this.folderPanel.Location = new System.Drawing.Point(53, 168);
            this.folderPanel.Name = "folderPanel";
            this.folderPanel.Size = new System.Drawing.Size(436, 207);
            this.folderPanel.TabIndex = 4;
            this.folderPanel.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(410, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 13;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.addFolder);
            this.groupBox2.Controls.Add(this.folderBrowerBtn);
            this.groupBox2.Controls.Add(this.shortcutTxt);
            this.groupBox2.Controls.Add(this.folderTxt);
            this.groupBox2.Location = new System.Drawing.Point(8, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 166);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add / Edit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Folder:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Shortcut:";
            // 
            // addFolder
            // 
            this.addFolder.Location = new System.Drawing.Point(150, 100);
            this.addFolder.Name = "addFolder";
            this.addFolder.Size = new System.Drawing.Size(118, 46);
            this.addFolder.TabIndex = 8;
            this.addFolder.Text = "Add Folder";
            this.addFolder.UseVisualStyleBackColor = true;
            this.addFolder.Click += new System.EventHandler(this.addFolder_Click);
            // 
            // folderBrowerBtn
            // 
            this.folderBrowerBtn.Location = new System.Drawing.Point(368, 74);
            this.folderBrowerBtn.Name = "folderBrowerBtn";
            this.folderBrowerBtn.Size = new System.Drawing.Size(44, 20);
            this.folderBrowerBtn.TabIndex = 11;
            this.folderBrowerBtn.Text = "...";
            this.folderBrowerBtn.UseVisualStyleBackColor = true;
            this.folderBrowerBtn.Click += new System.EventHandler(this.folderBrowerBtn_Click);
            // 
            // shortcutTxt
            // 
            this.shortcutTxt.Location = new System.Drawing.Point(6, 35);
            this.shortcutTxt.Name = "shortcutTxt";
            this.shortcutTxt.Size = new System.Drawing.Size(406, 20);
            this.shortcutTxt.TabIndex = 9;
            // 
            // folderTxt
            // 
            this.folderTxt.Location = new System.Drawing.Point(6, 74);
            this.folderTxt.Name = "folderTxt";
            this.folderTxt.Size = new System.Drawing.Size(356, 20);
            this.folderTxt.TabIndex = 10;
            // 
            // folderLV
            // 
            this.folderLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.folderLV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folderLV.FullRowSelect = true;
            this.folderLV.GridLines = true;
            this.folderLV.Location = new System.Drawing.Point(3, 3);
            this.folderLV.MultiSelect = false;
            this.folderLV.Name = "folderLV";
            this.folderLV.Size = new System.Drawing.Size(537, 537);
            this.folderLV.TabIndex = 3;
            this.folderLV.UseCompatibleStateImageBehavior = false;
            this.folderLV.View = System.Windows.Forms.View.Details;
            this.folderLV.SelectedIndexChanged += new System.EventHandler(this.folderLV_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Shortcut";
            this.columnHeader1.Width = 104;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Folder Path";
            this.columnHeader2.Width = 429;
            // 
            // AssociationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 611);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.addEditBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.exitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AssociationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filters & Folders";
            this.Load += new System.EventHandler(this.AssociationsForm_Load);
            this.editPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.folderPanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView accsView;
        private System.Windows.Forms.ColumnHeader extenionHeader;
        private System.Windows.Forms.ColumnHeader destPathHeader;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.TextBox destpathTxt;
        private System.Windows.Forms.TextBox extensionTxt;
        private System.Windows.Forms.Button addFilterBtn;
        private System.Windows.Forms.Button addEditBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button closeEditPanelBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel folderPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addFolder;
        private System.Windows.Forms.Button folderBrowerBtn;
        private System.Windows.Forms.TextBox shortcutTxt;
        private System.Windows.Forms.TextBox folderTxt;
        private System.Windows.Forms.ListView folderLV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button editFilterBtn;
    }
}