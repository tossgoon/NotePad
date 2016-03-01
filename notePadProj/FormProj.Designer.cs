namespace notePadProj
{
    partial class FormProj
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProj));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnUploadAtt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnSave = new System.Windows.Forms.ToolStripButton();
            this.lbProjName = new System.Windows.Forms.Label();
            this.txtProjName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtProjContent = new System.Windows.Forms.RichTextBox();
            this.lblAttachment = new System.Windows.Forms.Label();
            this.dtProjDate = new System.Windows.Forms.DateTimePicker();
            this.lblProjDate = new System.Windows.Forms.Label();
            this.chboxIsProjFinished = new System.Windows.Forms.CheckBox();
            this.txtProjDate = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tstripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstripProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.dgvAttachment = new System.Windows.Forms.DataGridView();
            this.colAttID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAttName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAttFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAttFileOpen = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colAttDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.chboxIsTop = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttachment)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnClear,
            this.toolStripSeparator1,
            this.tbtnUploadAtt,
            this.toolStripSeparator2,
            this.tbtnSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(648, 25);
            this.toolStrip1.TabIndex = 30;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtnClear
            // 
            this.tbtnClear.Image = global::notePadProj.Properties.Resources.newfile;
            this.tbtnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnClear.Name = "tbtnClear";
            this.tbtnClear.Size = new System.Drawing.Size(76, 22);
            this.tbtnClear.Text = "新增事项";
            this.tbtnClear.Click += new System.EventHandler(this.tbtnClear_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtnUploadAtt
            // 
            this.tbtnUploadAtt.Image = global::notePadProj.Properties.Resources.addattachment;
            this.tbtnUploadAtt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnUploadAtt.Name = "tbtnUploadAtt";
            this.tbtnUploadAtt.Size = new System.Drawing.Size(76, 22);
            this.tbtnUploadAtt.Text = "添加附件";
            this.tbtnUploadAtt.Click += new System.EventHandler(this.tbtnUploadAtt_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtnSave
            // 
            this.tbtnSave.Image = global::notePadProj.Properties.Resources.save;
            this.tbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnSave.Name = "tbtnSave";
            this.tbtnSave.Size = new System.Drawing.Size(52, 22);
            this.tbtnSave.Text = "保存";
            this.tbtnSave.Click += new System.EventHandler(this.tbtnSave_Click);
            // 
            // lbProjName
            // 
            this.lbProjName.AutoSize = true;
            this.lbProjName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbProjName.Location = new System.Drawing.Point(16, 38);
            this.lbProjName.Name = "lbProjName";
            this.lbProjName.Size = new System.Drawing.Size(57, 12);
            this.lbProjName.TabIndex = 31;
            this.lbProjName.Text = "事项名称";
            // 
            // txtProjName
            // 
            this.txtProjName.Location = new System.Drawing.Point(74, 34);
            this.txtProjName.Name = "txtProjName";
            this.txtProjName.Size = new System.Drawing.Size(562, 21);
            this.txtProjName.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 31;
            this.label1.Text = "详细内容";
            // 
            // rtxtProjContent
            // 
            this.rtxtProjContent.Location = new System.Drawing.Point(74, 94);
            this.rtxtProjContent.Name = "rtxtProjContent";
            this.rtxtProjContent.Size = new System.Drawing.Size(562, 87);
            this.rtxtProjContent.TabIndex = 35;
            this.rtxtProjContent.Text = "";
            // 
            // lblAttachment
            // 
            this.lblAttachment.AutoSize = true;
            this.lblAttachment.Location = new System.Drawing.Point(18, 192);
            this.lblAttachment.Name = "lblAttachment";
            this.lblAttachment.Size = new System.Drawing.Size(53, 12);
            this.lblAttachment.TabIndex = 31;
            this.lblAttachment.Text = "附件信息";
            // 
            // dtProjDate
            // 
            this.dtProjDate.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtProjDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtProjDate.Location = new System.Drawing.Point(75, 63);
            this.dtProjDate.Name = "dtProjDate";
            this.dtProjDate.Size = new System.Drawing.Size(157, 21);
            this.dtProjDate.TabIndex = 38;
            this.dtProjDate.Value = new System.DateTime(2016, 1, 1, 9, 15, 0, 0);
            this.dtProjDate.CloseUp += new System.EventHandler(this.dtProjDate_CloseUp);
            this.dtProjDate.ValueChanged += new System.EventHandler(this.dtProjDate_ValueChanged);
            // 
            // lblProjDate
            // 
            this.lblProjDate.AutoSize = true;
            this.lblProjDate.Location = new System.Drawing.Point(19, 66);
            this.lblProjDate.Name = "lblProjDate";
            this.lblProjDate.Size = new System.Drawing.Size(53, 12);
            this.lblProjDate.TabIndex = 31;
            this.lblProjDate.Text = "事项日期";
            // 
            // chboxIsProjFinished
            // 
            this.chboxIsProjFinished.AutoSize = true;
            this.chboxIsProjFinished.Location = new System.Drawing.Point(552, 68);
            this.chboxIsProjFinished.Name = "chboxIsProjFinished";
            this.chboxIsProjFinished.Size = new System.Drawing.Size(84, 16);
            this.chboxIsProjFinished.TabIndex = 39;
            this.chboxIsProjFinished.Text = "事项已完成";
            this.chboxIsProjFinished.UseVisualStyleBackColor = true;
            // 
            // txtProjDate
            // 
            this.txtProjDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProjDate.Location = new System.Drawing.Point(77, 66);
            this.txtProjDate.Name = "txtProjDate";
            this.txtProjDate.Size = new System.Drawing.Size(115, 14);
            this.txtProjDate.TabIndex = 40;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstripLabel,
            this.tstripProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 421);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(648, 22);
            this.statusStrip1.TabIndex = 41;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tstripLabel
            // 
            this.tstripLabel.AutoSize = false;
            this.tstripLabel.Name = "tstripLabel";
            this.tstripLabel.Size = new System.Drawing.Size(200, 17);
            this.tstripLabel.Text = " ";
            // 
            // tstripProgress
            // 
            this.tstripProgress.Name = "tstripProgress";
            this.tstripProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // dgvAttachment
            // 
            this.dgvAttachment.AllowUserToAddRows = false;
            this.dgvAttachment.AllowUserToDeleteRows = false;
            this.dgvAttachment.AllowUserToResizeColumns = false;
            this.dgvAttachment.AllowUserToResizeRows = false;
            this.dgvAttachment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAttachment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAttachment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAttachment.ColumnHeadersHeight = 25;
            this.dgvAttachment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAttachment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAttID,
            this.colAttName,
            this.colAttFilePath,
            this.colAttFileOpen,
            this.colAttDelete});
            this.dgvAttachment.EnableHeadersVisualStyles = false;
            this.dgvAttachment.Location = new System.Drawing.Point(73, 186);
            this.dgvAttachment.MultiSelect = false;
            this.dgvAttachment.Name = "dgvAttachment";
            this.dgvAttachment.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAttachment.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAttachment.RowHeadersWidth = 30;
            this.dgvAttachment.RowTemplate.Height = 23;
            this.dgvAttachment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvAttachment.Size = new System.Drawing.Size(564, 232);
            this.dgvAttachment.TabIndex = 36;
            this.dgvAttachment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttachment_CellClick);
            // 
            // colAttID
            // 
            this.colAttID.HeaderText = "attID";
            this.colAttID.Name = "colAttID";
            this.colAttID.ReadOnly = true;
            this.colAttID.Visible = false;
            // 
            // colAttName
            // 
            this.colAttName.HeaderText = "附件名称";
            this.colAttName.Name = "colAttName";
            this.colAttName.ReadOnly = true;
            // 
            // colAttFilePath
            // 
            this.colAttFilePath.HeaderText = "文件路径";
            this.colAttFilePath.Name = "colAttFilePath";
            this.colAttFilePath.ReadOnly = true;
            this.colAttFilePath.Visible = false;
            // 
            // colAttFileOpen
            // 
            this.colAttFileOpen.FillWeight = 10F;
            this.colAttFileOpen.HeaderText = "打开";
            this.colAttFileOpen.Name = "colAttFileOpen";
            this.colAttFileOpen.ReadOnly = true;
            this.colAttFileOpen.Text = "打开";
            this.colAttFileOpen.UseColumnTextForButtonValue = true;
            // 
            // colAttDelete
            // 
            this.colAttDelete.FillWeight = 8F;
            this.colAttDelete.HeaderText = "删除";
            this.colAttDelete.Name = "colAttDelete";
            this.colAttDelete.ReadOnly = true;
            this.colAttDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAttDelete.Text = "×";
            this.colAttDelete.UseColumnTextForButtonValue = true;
            // 
            // chboxIsTop
            // 
            this.chboxIsTop.AutoSize = true;
            this.chboxIsTop.Location = new System.Drawing.Point(455, 68);
            this.chboxIsTop.Name = "chboxIsTop";
            this.chboxIsTop.Size = new System.Drawing.Size(48, 16);
            this.chboxIsTop.TabIndex = 39;
            this.chboxIsTop.Text = "置顶";
            this.chboxIsTop.UseVisualStyleBackColor = true;
            // 
            // FormProj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 443);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtProjDate);
            this.Controls.Add(this.chboxIsTop);
            this.Controls.Add(this.chboxIsProjFinished);
            this.Controls.Add(this.dtProjDate);
            this.Controls.Add(this.dgvAttachment);
            this.Controls.Add(this.rtxtProjContent);
            this.Controls.Add(this.txtProjName);
            this.Controls.Add(this.lblAttachment);
            this.Controls.Add(this.lblProjDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbProjName);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormProj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新增事项";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttachment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label lbProjName;
        private System.Windows.Forms.TextBox txtProjName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxtProjContent;
        private System.Windows.Forms.Label lblAttachment;
        private System.Windows.Forms.ToolStripButton tbtnClear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbtnUploadAtt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tbtnSave;
        private System.Windows.Forms.DataGridView dgvAttachment;
        private System.Windows.Forms.DateTimePicker dtProjDate;
        private System.Windows.Forms.Label lblProjDate;
        private System.Windows.Forms.CheckBox chboxIsProjFinished;
        private System.Windows.Forms.TextBox txtProjDate;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tstripLabel;
        private System.Windows.Forms.ToolStripProgressBar tstripProgress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttFilePath;
        private System.Windows.Forms.DataGridViewButtonColumn colAttFileOpen;
        private System.Windows.Forms.DataGridViewButtonColumn colAttDelete;
        private System.Windows.Forms.CheckBox chboxIsTop;
    }
}