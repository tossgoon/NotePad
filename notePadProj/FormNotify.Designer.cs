namespace notePadProj
{
    partial class FormNotify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNotify));
            this.dgvProjNotify = new notePadProj.CDoubleBufferDataGridView();
            this.colProjID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjRemainTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjNotify)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProjNotify
            // 
            this.dgvProjNotify.AllowUserToAddRows = false;
            this.dgvProjNotify.AllowUserToDeleteRows = false;
            this.dgvProjNotify.AllowUserToResizeColumns = false;
            this.dgvProjNotify.AllowUserToResizeRows = false;
            this.dgvProjNotify.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProjNotify.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProjNotify.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProjNotify.ColumnHeadersHeight = 25;
            this.dgvProjNotify.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProjNotify.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProjID,
            this.colProjName,
            this.colProjDate,
            this.colProjRemainTime});
            this.dgvProjNotify.EnableHeadersVisualStyles = false;
            this.dgvProjNotify.Location = new System.Drawing.Point(2, 2);
            this.dgvProjNotify.MultiSelect = false;
            this.dgvProjNotify.Name = "dgvProjNotify";
            this.dgvProjNotify.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProjNotify.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProjNotify.RowHeadersWidth = 30;
            this.dgvProjNotify.RowTemplate.Height = 23;
            this.dgvProjNotify.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProjNotify.Size = new System.Drawing.Size(503, 277);
            this.dgvProjNotify.TabIndex = 37;
            // 
            // colProjID
            // 
            this.colProjID.HeaderText = "attID";
            this.colProjID.Name = "colProjID";
            this.colProjID.ReadOnly = true;
            this.colProjID.Visible = false;
            // 
            // colProjName
            // 
            this.colProjName.HeaderText = "事项名称";
            this.colProjName.Name = "colProjName";
            this.colProjName.ReadOnly = true;
            // 
            // colProjDate
            // 
            this.colProjDate.FillWeight = 35F;
            this.colProjDate.HeaderText = "事项日期";
            this.colProjDate.Name = "colProjDate";
            this.colProjDate.ReadOnly = true;
            // 
            // colProjRemainTime
            // 
            this.colProjRemainTime.FillWeight = 35F;
            this.colProjRemainTime.HeaderText = "剩余时间";
            this.colProjRemainTime.Name = "colProjRemainTime";
            this.colProjRemainTime.ReadOnly = true;
            // 
            // FormNotify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 281);
            this.Controls.Add(this.dgvProjNotify);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormNotify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "提醒：以下事项待办";
            this.Load += new System.EventHandler(this.FormNotify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjNotify)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CDoubleBufferDataGridView dgvProjNotify;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjRemainTime;

    }
}