namespace Desktop_Organizer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.organizeBtn = new System.Windows.Forms.Button();
            this.showForm2Btn = new System.Windows.Forms.Button();
            this.changePathBtn = new System.Windows.Forms.Button();
            this.pathPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.setDesktopBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pathCancelbtn = new System.Windows.Forms.Button();
            this.pathOKbtn = new System.Windows.Forms.Button();
            this.pathTxt = new System.Windows.Forms.TextBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.currentPathLbl = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.countLbl = new System.Windows.Forms.Label();
            this.pathPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // organizeBtn
            // 
            this.organizeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.organizeBtn.Location = new System.Drawing.Point(15, 14);
            this.organizeBtn.Name = "organizeBtn";
            this.organizeBtn.Size = new System.Drawing.Size(255, 52);
            this.organizeBtn.TabIndex = 1;
            this.organizeBtn.Text = "Organize Files";
            this.organizeBtn.UseVisualStyleBackColor = true;
            this.organizeBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // showForm2Btn
            // 
            this.showForm2Btn.Location = new System.Drawing.Point(276, 14);
            this.showForm2Btn.Name = "showForm2Btn";
            this.showForm2Btn.Size = new System.Drawing.Size(94, 23);
            this.showForm2Btn.TabIndex = 12;
            this.showForm2Btn.Text = "Show Filters";
            this.showForm2Btn.UseVisualStyleBackColor = true;
            this.showForm2Btn.Click += new System.EventHandler(this.button8_Click);
            // 
            // changePathBtn
            // 
            this.changePathBtn.Location = new System.Drawing.Point(276, 43);
            this.changePathBtn.Name = "changePathBtn";
            this.changePathBtn.Size = new System.Drawing.Size(94, 23);
            this.changePathBtn.TabIndex = 13;
            this.changePathBtn.Text = "Change Path";
            this.changePathBtn.UseVisualStyleBackColor = true;
            this.changePathBtn.Click += new System.EventHandler(this.changePathBtn_Click);
            // 
            // pathPanel
            // 
            this.pathPanel.Controls.Add(this.groupBox1);
            this.pathPanel.Controls.Add(this.label1);
            this.pathPanel.Controls.Add(this.pathCancelbtn);
            this.pathPanel.Controls.Add(this.pathOKbtn);
            this.pathPanel.Controls.Add(this.pathTxt);
            this.pathPanel.Controls.Add(this.browseBtn);
            this.pathPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pathPanel.Location = new System.Drawing.Point(0, 97);
            this.pathPanel.Name = "pathPanel";
            this.pathPanel.Size = new System.Drawing.Size(373, 160);
            this.pathPanel.TabIndex = 23;
            this.pathPanel.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.setDesktopBtn);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 106);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Presets";
            // 
            // setDesktopBtn
            // 
            this.setDesktopBtn.Location = new System.Drawing.Point(6, 19);
            this.setDesktopBtn.Name = "setDesktopBtn";
            this.setDesktopBtn.Size = new System.Drawing.Size(94, 23);
            this.setDesktopBtn.TabIndex = 16;
            this.setDesktopBtn.Text = "Desktop";
            this.setDesktopBtn.UseVisualStyleBackColor = true;
            this.setDesktopBtn.Click += new System.EventHandler(this.setDesktopBtn_Click_1);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(6, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Desktop";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(6, 77);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "Desktop";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(106, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "Desktop";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(106, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Desktop";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(106, 77);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 23);
            this.button6.TabIndex = 21;
            this.button6.Text = "Desktop";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Select the folder to organize:";
            // 
            // pathCancelbtn
            // 
            this.pathCancelbtn.Location = new System.Drawing.Point(313, 126);
            this.pathCancelbtn.Name = "pathCancelbtn";
            this.pathCancelbtn.Size = new System.Drawing.Size(55, 23);
            this.pathCancelbtn.TabIndex = 23;
            this.pathCancelbtn.Text = "Cancel";
            this.pathCancelbtn.UseVisualStyleBackColor = true;
            this.pathCancelbtn.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // pathOKbtn
            // 
            this.pathOKbtn.Location = new System.Drawing.Point(313, 97);
            this.pathOKbtn.Name = "pathOKbtn";
            this.pathOKbtn.Size = new System.Drawing.Size(55, 23);
            this.pathOKbtn.TabIndex = 22;
            this.pathOKbtn.Text = "OK";
            this.pathOKbtn.UseVisualStyleBackColor = true;
            this.pathOKbtn.Click += new System.EventHandler(this.pathOKbtn_Click);
            // 
            // pathTxt
            // 
            this.pathTxt.Location = new System.Drawing.Point(12, 23);
            this.pathTxt.Name = "pathTxt";
            this.pathTxt.Size = new System.Drawing.Size(294, 20);
            this.pathTxt.TabIndex = 14;
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(312, 23);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(55, 20);
            this.browseBtn.TabIndex = 15;
            this.browseBtn.Text = "...";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // currentPathLbl
            // 
            this.currentPathLbl.Location = new System.Drawing.Point(15, 73);
            this.currentPathLbl.Name = "currentPathLbl";
            this.currentPathLbl.Size = new System.Drawing.Size(255, 17);
            this.currentPathLbl.TabIndex = 24;
            this.currentPathLbl.TabStop = true;
            this.currentPathLbl.Text = "currentPath";
            this.toolTip1.SetToolTip(this.currentPathLbl, "Double-click the link to open the selected path on explorer.");
            this.currentPathLbl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.currentPathLbl_MouseDoubleClick);
            // 
            // countLbl
            // 
            this.countLbl.Location = new System.Drawing.Point(276, 73);
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(91, 17);
            this.countLbl.TabIndex = 25;
            this.countLbl.Text = "Files: 0";
            this.countLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 257);
            this.Controls.Add(this.pathPanel);
            this.Controls.Add(this.countLbl);
            this.Controls.Add(this.currentPathLbl);
            this.Controls.Add(this.showForm2Btn);
            this.Controls.Add(this.changePathBtn);
            this.Controls.Add(this.organizeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desktop Organizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pathPanel.ResumeLayout(false);
            this.pathPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button organizeBtn;
        private System.Windows.Forms.Button showForm2Btn;
        private System.Windows.Forms.Button changePathBtn;
        private System.Windows.Forms.Panel pathPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button setDesktopBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pathCancelbtn;
        private System.Windows.Forms.Button pathOKbtn;
        private System.Windows.Forms.TextBox pathTxt;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.LinkLabel currentPathLbl;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label countLbl;
    }
}

