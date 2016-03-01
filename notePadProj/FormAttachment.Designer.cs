namespace notePadProj
{
    partial class FormAttachment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAttachment));
            this.lblProjName = new System.Windows.Forms.Label();
            this.txtProjName = new System.Windows.Forms.TextBox();
            this.lblFolderPath = new System.Windows.Forms.Label();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.splitContainerAtt = new System.Windows.Forms.SplitContainer();
            this.pboxAtt = new System.Windows.Forms.PictureBox();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProjDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProjCreateDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProjFinishDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProjStatus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProjContent = new System.Windows.Forms.TextBox();
            this.dgvAttachment = new notePadProj.CDoubleBufferDataGridView();
            this.colAttID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAttPreview = new System.Windows.Forms.DataGridViewImageColumn();
            this.colAttName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAttFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAttUploadDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAttOpen = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAtt)).BeginInit();
            this.splitContainerAtt.Panel1.SuspendLayout();
            this.splitContainerAtt.Panel2.SuspendLayout();
            this.splitContainerAtt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAtt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttachment)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProjName
            // 
            this.lblProjName.AutoSize = true;
            this.lblProjName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblProjName.Location = new System.Drawing.Point(17, 17);
            this.lblProjName.Name = "lblProjName";
            this.lblProjName.Size = new System.Drawing.Size(64, 12);
            this.lblProjName.TabIndex = 0;
            this.lblProjName.Text = "事项名称:";
            // 
            // txtProjName
            // 
            this.txtProjName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProjName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.txtProjName.Enabled = false;
            this.txtProjName.Location = new System.Drawing.Point(84, 13);
            this.txtProjName.Name = "txtProjName";
            this.txtProjName.ReadOnly = true;
            this.txtProjName.Size = new System.Drawing.Size(872, 21);
            this.txtProjName.TabIndex = 1;
            // 
            // lblFolderPath
            // 
            this.lblFolderPath.AutoSize = true;
            this.lblFolderPath.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFolderPath.Location = new System.Drawing.Point(17, 228);
            this.lblFolderPath.Name = "lblFolderPath";
            this.lblFolderPath.Size = new System.Drawing.Size(64, 12);
            this.lblFolderPath.TabIndex = 0;
            this.lblFolderPath.Text = "附件目录:";
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolderPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.txtFolderPath.Enabled = false;
            this.txtFolderPath.Location = new System.Drawing.Point(84, 224);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.ReadOnly = true;
            this.txtFolderPath.Size = new System.Drawing.Size(764, 21);
            this.txtFolderPath.TabIndex = 1;
            // 
            // splitContainerAtt
            // 
            this.splitContainerAtt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerAtt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerAtt.Location = new System.Drawing.Point(12, 251);
            this.splitContainerAtt.Name = "splitContainerAtt";
            // 
            // splitContainerAtt.Panel1
            // 
            this.splitContainerAtt.Panel1.Controls.Add(this.dgvAttachment);
            // 
            // splitContainerAtt.Panel2
            // 
            this.splitContainerAtt.Panel2.Controls.Add(this.pboxAtt);
            this.splitContainerAtt.Size = new System.Drawing.Size(949, 269);
            this.splitContainerAtt.SplitterDistance = 524;
            this.splitContainerAtt.TabIndex = 3;
            // 
            // pboxAtt
            // 
            this.pboxAtt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pboxAtt.Location = new System.Drawing.Point(0, 0);
            this.pboxAtt.Name = "pboxAtt";
            this.pboxAtt.Size = new System.Drawing.Size(419, 267);
            this.pboxAtt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxAtt.TabIndex = 0;
            this.pboxAtt.TabStop = false;
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFolder.Image = global::notePadProj.Properties.Resources.openfolder;
            this.btnOpenFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenFolder.Location = new System.Drawing.Point(923, 223);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(33, 23);
            this.btnOpenFolder.TabIndex = 2;
            this.btnOpenFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(854, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "打开文件夹";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(17, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "事项日期:";
            // 
            // txtProjDate
            // 
            this.txtProjDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.txtProjDate.Enabled = false;
            this.txtProjDate.Location = new System.Drawing.Point(84, 40);
            this.txtProjDate.Name = "txtProjDate";
            this.txtProjDate.ReadOnly = true;
            this.txtProjDate.Size = new System.Drawing.Size(144, 21);
            this.txtProjDate.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(263, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "创建日期:";
            // 
            // txtProjCreateDate
            // 
            this.txtProjCreateDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.txtProjCreateDate.Enabled = false;
            this.txtProjCreateDate.Location = new System.Drawing.Point(330, 40);
            this.txtProjCreateDate.Name = "txtProjCreateDate";
            this.txtProjCreateDate.ReadOnly = true;
            this.txtProjCreateDate.Size = new System.Drawing.Size(144, 21);
            this.txtProjCreateDate.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(742, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "完成日期:";
            // 
            // txtProjFinishDate
            // 
            this.txtProjFinishDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.txtProjFinishDate.Enabled = false;
            this.txtProjFinishDate.Location = new System.Drawing.Point(809, 40);
            this.txtProjFinishDate.Name = "txtProjFinishDate";
            this.txtProjFinishDate.ReadOnly = true;
            this.txtProjFinishDate.Size = new System.Drawing.Size(144, 21);
            this.txtProjFinishDate.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(502, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "当前状态:";
            // 
            // txtProjStatus
            // 
            this.txtProjStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.txtProjStatus.Enabled = false;
            this.txtProjStatus.Location = new System.Drawing.Point(569, 40);
            this.txtProjStatus.Name = "txtProjStatus";
            this.txtProjStatus.ReadOnly = true;
            this.txtProjStatus.Size = new System.Drawing.Size(144, 21);
            this.txtProjStatus.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(17, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "事项内容:";
            // 
            // txtProjContent
            // 
            this.txtProjContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProjContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.txtProjContent.Enabled = false;
            this.txtProjContent.Location = new System.Drawing.Point(84, 67);
            this.txtProjContent.Multiline = true;
            this.txtProjContent.Name = "txtProjContent";
            this.txtProjContent.ReadOnly = true;
            this.txtProjContent.Size = new System.Drawing.Size(869, 140);
            this.txtProjContent.TabIndex = 1;
            // 
            // dgvAttachment
            // 
            this.dgvAttachment.AllowUserToAddRows = false;
            this.dgvAttachment.AllowUserToDeleteRows = false;
            this.dgvAttachment.AllowUserToResizeColumns = false;
            this.dgvAttachment.AllowUserToResizeRows = false;
            this.dgvAttachment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAttachment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAttachment.ColumnHeadersHeight = 30;
            this.dgvAttachment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAttachment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAttID,
            this.colAttPreview,
            this.colAttName,
            this.colAttFilePath,
            this.colAttUploadDate,
            this.colAttOpen});
            this.dgvAttachment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAttachment.EnableHeadersVisualStyles = false;
            this.dgvAttachment.Location = new System.Drawing.Point(0, 0);
            this.dgvAttachment.MultiSelect = false;
            this.dgvAttachment.Name = "dgvAttachment";
            this.dgvAttachment.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAttachment.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAttachment.RowHeadersWidth = 30;
            this.dgvAttachment.RowTemplate.Height = 23;
            this.dgvAttachment.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAttachment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvAttachment.Size = new System.Drawing.Size(522, 267);
            this.dgvAttachment.TabIndex = 37;
            this.dgvAttachment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttachment_CellClick);
            this.dgvAttachment.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAttachment_CellFormatting);
            this.dgvAttachment.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttachment_RowEnter);
            // 
            // colAttID
            // 
            this.colAttID.HeaderText = "attID";
            this.colAttID.Name = "colAttID";
            this.colAttID.ReadOnly = true;
            this.colAttID.Visible = false;
            // 
            // colAttPreview
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colAttPreview.DefaultCellStyle = dataGridViewCellStyle2;
            this.colAttPreview.FillWeight = 20F;
            this.colAttPreview.HeaderText = "缩略图";
            this.colAttPreview.Image = global::notePadProj.Properties.Resources.nonpicture;
            this.colAttPreview.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colAttPreview.Name = "colAttPreview";
            this.colAttPreview.ReadOnly = true;
            // 
            // colAttName
            // 
            this.colAttName.HeaderText = "附件名称";
            this.colAttName.Name = "colAttName";
            this.colAttName.ReadOnly = true;
            // 
            // colAttFilePath
            // 
            this.colAttFilePath.HeaderText = "附件路径";
            this.colAttFilePath.Name = "colAttFilePath";
            this.colAttFilePath.ReadOnly = true;
            this.colAttFilePath.Visible = false;
            // 
            // colAttUploadDate
            // 
            this.colAttUploadDate.FillWeight = 40F;
            this.colAttUploadDate.HeaderText = "上传日期";
            this.colAttUploadDate.Name = "colAttUploadDate";
            this.colAttUploadDate.ReadOnly = true;
            // 
            // colAttOpen
            // 
            this.colAttOpen.FillWeight = 15F;
            this.colAttOpen.HeaderText = "查看";
            this.colAttOpen.Name = "colAttOpen";
            this.colAttOpen.ReadOnly = true;
            this.colAttOpen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAttOpen.Text = "打开";
            this.colAttOpen.UseColumnTextForButtonValue = true;
            // 
            // FormAttachment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 523);
            this.Controls.Add(this.splitContainerAtt);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.txtFolderPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFolderPath);
            this.Controls.Add(this.txtProjFinishDate);
            this.Controls.Add(this.txtProjStatus);
            this.Controls.Add(this.txtProjCreateDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProjContent);
            this.Controls.Add(this.txtProjDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtProjName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblProjName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAttachment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "附件信息";
            this.splitContainerAtt.Panel1.ResumeLayout(false);
            this.splitContainerAtt.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAtt)).EndInit();
            this.splitContainerAtt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxAtt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttachment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjName;
        private System.Windows.Forms.TextBox txtProjName;
        private System.Windows.Forms.Label lblFolderPath;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.SplitContainer splitContainerAtt;
        private System.Windows.Forms.PictureBox pboxAtt;
        private CDoubleBufferDataGridView dgvAttachment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttID;
        private System.Windows.Forms.DataGridViewImageColumn colAttPreview;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttFilePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttUploadDate;
        private System.Windows.Forms.DataGridViewButtonColumn colAttOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProjDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProjCreateDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProjFinishDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProjStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProjContent;
    }
}