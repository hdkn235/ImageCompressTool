namespace 图片压缩小工具
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbStart = new System.Windows.Forms.GroupBox();
            this.lblProgess = new System.Windows.Forms.Label();
            this.btnStartCompress = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbCompress = new System.Windows.Forms.ProgressBar();
            this.gbFileList = new System.Windows.Forms.GroupBox();
            this.cbSelAll = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelSel = new System.Windows.Forms.Button();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.dgvFileList = new System.Windows.Forms.DataGridView();
            this.Sel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ImgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImgPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbSet = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numPercent = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numLimitSize = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbSelSaveType = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtOtherFolder = new System.Windows.Forms.TextBox();
            this.rbtnSaveSelf = new System.Windows.Forms.RadioButton();
            this.rbtnSaveOther = new System.Windows.Forms.RadioButton();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbStart.SuspendLayout();
            this.gbFileList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileList)).BeginInit();
            this.gbSet.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLimitSize)).BeginInit();
            this.gbSelSaveType.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbStart);
            this.splitContainer1.Panel1.Controls.Add(this.gbFileList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbSet);
            this.splitContainer1.Size = new System.Drawing.Size(823, 521);
            this.splitContainer1.SplitterDistance = 558;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // gbStart
            // 
            this.gbStart.Controls.Add(this.lblProgess);
            this.gbStart.Controls.Add(this.btnStartCompress);
            this.gbStart.Controls.Add(this.label1);
            this.gbStart.Controls.Add(this.pbCompress);
            this.gbStart.Location = new System.Drawing.Point(4, 427);
            this.gbStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbStart.Name = "gbStart";
            this.gbStart.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbStart.Size = new System.Drawing.Size(554, 89);
            this.gbStart.TabIndex = 1;
            this.gbStart.TabStop = false;
            this.gbStart.Text = "开始压缩";
            // 
            // lblProgess
            // 
            this.lblProgess.AutoSize = true;
            this.lblProgess.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblProgess.Location = new System.Drawing.Point(89, 26);
            this.lblProgess.Name = "lblProgess";
            this.lblProgess.Size = new System.Drawing.Size(0, 20);
            this.lblProgess.TabIndex = 6;
            // 
            // btnStartCompress
            // 
            this.btnStartCompress.Location = new System.Drawing.Point(430, 49);
            this.btnStartCompress.Name = "btnStartCompress";
            this.btnStartCompress.Size = new System.Drawing.Size(75, 30);
            this.btnStartCompress.TabIndex = 5;
            this.btnStartCompress.Text = "开始压缩";
            this.btnStartCompress.UseVisualStyleBackColor = true;
            this.btnStartCompress.Click += new System.EventHandler(this.btnStartCompress_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "压缩进度:";
            // 
            // pbCompress
            // 
            this.pbCompress.Location = new System.Drawing.Point(15, 53);
            this.pbCompress.Name = "pbCompress";
            this.pbCompress.Size = new System.Drawing.Size(393, 23);
            this.pbCompress.TabIndex = 0;
            // 
            // gbFileList
            // 
            this.gbFileList.Controls.Add(this.cbSelAll);
            this.gbFileList.Controls.Add(this.btnClear);
            this.gbFileList.Controls.Add(this.btnDelSel);
            this.gbFileList.Controls.Add(this.btnAddFolder);
            this.gbFileList.Controls.Add(this.btnAddFile);
            this.gbFileList.Controls.Add(this.dgvFileList);
            this.gbFileList.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFileList.Location = new System.Drawing.Point(0, 0);
            this.gbFileList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbFileList.Name = "gbFileList";
            this.gbFileList.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbFileList.Size = new System.Drawing.Size(558, 427);
            this.gbFileList.TabIndex = 0;
            this.gbFileList.TabStop = false;
            this.gbFileList.Text = "选择要压缩的文件";
            // 
            // cbSelAll
            // 
            this.cbSelAll.AutoSize = true;
            this.cbSelAll.Location = new System.Drawing.Point(14, 33);
            this.cbSelAll.Name = "cbSelAll";
            this.cbSelAll.Size = new System.Drawing.Size(15, 14);
            this.cbSelAll.TabIndex = 5;
            this.cbSelAll.UseVisualStyleBackColor = true;
            this.cbSelAll.CheckedChanged += new System.EventHandler(this.cbSelAll_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(403, 389);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 30);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "清空列表";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelSel
            // 
            this.btnDelSel.Location = new System.Drawing.Point(279, 389);
            this.btnDelSel.Name = "btnDelSel";
            this.btnDelSel.Size = new System.Drawing.Size(89, 30);
            this.btnDelSel.TabIndex = 3;
            this.btnDelSel.Text = "删除选中项";
            this.btnDelSel.UseVisualStyleBackColor = true;
            this.btnDelSel.Click += new System.EventHandler(this.btnDelSel_Click);
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Location = new System.Drawing.Point(155, 389);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(89, 30);
            this.btnAddFolder.TabIndex = 2;
            this.btnAddFolder.Text = "添加文件夹";
            this.btnAddFolder.UseVisualStyleBackColor = true;
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(45, 389);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(75, 30);
            this.btnAddFile.TabIndex = 1;
            this.btnAddFile.Text = "添加文件";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // dgvFileList
            // 
            this.dgvFileList.AllowUserToAddRows = false;
            this.dgvFileList.AllowUserToDeleteRows = false;
            this.dgvFileList.AllowUserToResizeRows = false;
            this.dgvFileList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFileList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFileList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sel,
            this.ImgName,
            this.ImgPath});
            this.dgvFileList.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvFileList.Location = new System.Drawing.Point(4, 19);
            this.dgvFileList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvFileList.Name = "dgvFileList";
            this.dgvFileList.RowHeadersVisible = false;
            this.dgvFileList.RowTemplate.Height = 23;
            this.dgvFileList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFileList.Size = new System.Drawing.Size(550, 355);
            this.dgvFileList.StandardTab = true;
            this.dgvFileList.TabIndex = 0;
            // 
            // Sel
            // 
            this.Sel.FalseValue = "0";
            this.Sel.HeaderText = "";
            this.Sel.Name = "Sel";
            this.Sel.TrueValue = "1";
            this.Sel.Width = 30;
            // 
            // ImgName
            // 
            this.ImgName.DataPropertyName = "ImgName";
            this.ImgName.HeaderText = "图片名称";
            this.ImgName.Name = "ImgName";
            this.ImgName.ReadOnly = true;
            this.ImgName.Width = 200;
            // 
            // ImgPath
            // 
            this.ImgPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImgPath.DataPropertyName = "ImgPath";
            this.ImgPath.HeaderText = "图片完整路径";
            this.ImgPath.Name = "ImgPath";
            this.ImgPath.ReadOnly = true;
            // 
            // gbSet
            // 
            this.gbSet.Controls.Add(this.groupBox1);
            this.gbSet.Controls.Add(this.gbSelSaveType);
            this.gbSet.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSet.Location = new System.Drawing.Point(0, 0);
            this.gbSet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSet.Name = "gbSet";
            this.gbSet.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSet.Size = new System.Drawing.Size(260, 516);
            this.gbSet.TabIndex = 0;
            this.gbSet.TabStop = false;
            this.gbSet.Text = "设置";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numPercent);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numLimitSize);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(7, 282);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 227);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "压缩设置";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "%";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numPercent
            // 
            this.numPercent.Location = new System.Drawing.Point(97, 89);
            this.numPercent.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPercent.Name = "numPercent";
            this.numPercent.Size = new System.Drawing.Size(87, 26);
            this.numPercent.TabIndex = 12;
            this.numPercent.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "压缩比率:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numLimitSize
            // 
            this.numLimitSize.Location = new System.Drawing.Point(97, 44);
            this.numLimitSize.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numLimitSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLimitSize.Name = "numLimitSize";
            this.numLimitSize.Size = new System.Drawing.Size(87, 26);
            this.numLimitSize.TabIndex = 10;
            this.numLimitSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(5, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 102);
            this.label5.TabIndex = 9;
            this.label5.Text = "注意:起始值大小是指只有大小超过这个值的图片才会被压缩\r\n压缩比率是指对图片像素大小的压缩\r\n";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "KB";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "起始值大小:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbSelSaveType
            // 
            this.gbSelSaveType.Controls.Add(this.label2);
            this.gbSelSaveType.Controls.Add(this.btnBrowse);
            this.gbSelSaveType.Controls.Add(this.txtOtherFolder);
            this.gbSelSaveType.Controls.Add(this.rbtnSaveSelf);
            this.gbSelSaveType.Controls.Add(this.rbtnSaveOther);
            this.gbSelSaveType.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSelSaveType.Location = new System.Drawing.Point(4, 24);
            this.gbSelSaveType.Name = "gbSelSaveType";
            this.gbSelSaveType.Size = new System.Drawing.Size(252, 252);
            this.gbSelSaveType.TabIndex = 0;
            this.gbSelSaveType.TabStop = false;
            this.gbSelSaveType.Text = "选择保存方式";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(14, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 71);
            this.label2.TabIndex = 5;
            this.label2.Text = "注意:选中覆盖自身,建议先备份好原有图片,以免造成损失.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Enabled = false;
            this.btnBrowse.Location = new System.Drawing.Point(18, 105);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 30);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "浏览";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtOtherFolder
            // 
            this.txtOtherFolder.Enabled = false;
            this.txtOtherFolder.Location = new System.Drawing.Point(18, 73);
            this.txtOtherFolder.Name = "txtOtherFolder";
            this.txtOtherFolder.Size = new System.Drawing.Size(230, 26);
            this.txtOtherFolder.TabIndex = 2;
            // 
            // rbtnSaveSelf
            // 
            this.rbtnSaveSelf.AutoSize = true;
            this.rbtnSaveSelf.Location = new System.Drawing.Point(18, 153);
            this.rbtnSaveSelf.Name = "rbtnSaveSelf";
            this.rbtnSaveSelf.Size = new System.Drawing.Size(111, 24);
            this.rbtnSaveSelf.TabIndex = 1;
            this.rbtnSaveSelf.TabStop = true;
            this.rbtnSaveSelf.Tag = "2";
            this.rbtnSaveSelf.Text = "覆盖自身文件";
            this.rbtnSaveSelf.UseVisualStyleBackColor = true;
            // 
            // rbtnSaveOther
            // 
            this.rbtnSaveOther.AutoSize = true;
            this.rbtnSaveOther.Location = new System.Drawing.Point(18, 40);
            this.rbtnSaveOther.Name = "rbtnSaveOther";
            this.rbtnSaveOther.Size = new System.Drawing.Size(153, 24);
            this.rbtnSaveOther.TabIndex = 0;
            this.rbtnSaveOther.TabStop = true;
            this.rbtnSaveOther.Tag = "1";
            this.rbtnSaveOther.Text = "保存到另一个文件夹";
            this.rbtnSaveOther.UseVisualStyleBackColor = true;
            this.rbtnSaveOther.CheckedChanged += new System.EventHandler(this.rbtnSaveOther_CheckedChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 521);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图片压缩小工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.gbStart.ResumeLayout(false);
            this.gbStart.PerformLayout();
            this.gbFileList.ResumeLayout(false);
            this.gbFileList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileList)).EndInit();
            this.gbSet.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLimitSize)).EndInit();
            this.gbSelSaveType.ResumeLayout(false);
            this.gbSelSaveType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbStart;
        private System.Windows.Forms.GroupBox gbFileList;
        private System.Windows.Forms.DataGridView dgvFileList;
        private System.Windows.Forms.GroupBox gbSet;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelSel;
        private System.Windows.Forms.Button btnAddFolder;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.Button btnStartCompress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pbCompress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbSelSaveType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtOtherFolder;
        private System.Windows.Forms.RadioButton rbtnSaveSelf;
        private System.Windows.Forms.RadioButton rbtnSaveOther;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Sel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImgPath;
        private System.Windows.Forms.CheckBox cbSelAll;
        private System.Windows.Forms.Label lblProgess;
        private System.Windows.Forms.NumericUpDown numLimitSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numPercent;
        private System.Windows.Forms.Label label6;
    }
}