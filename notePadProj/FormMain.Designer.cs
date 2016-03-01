namespace notePadProj
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.基础信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnNewProj = new System.Windows.Forms.ToolStripButton();
            this.tbtnUpdateProj = new System.Windows.Forms.ToolStripButton();
            this.tbtnDeleteProj = new System.Windows.Forms.ToolStripButton();
            this.tbtnChangeProjStatus = new System.Windows.Forms.ToolStripButton();
            this.tbtnTop = new System.Windows.Forms.ToolStripButton();
            this.tbtnRefreshProj = new System.Windows.Forms.ToolStripButton();
            this.tbtnAttachment = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnSelectAll = new System.Windows.Forms.ToolStripButton();
            this.tbtnReverseSelect = new System.Windows.Forms.ToolStripButton();
            this.tbtnNoSelect = new System.Windows.Forms.ToolStripButton();
            this.tbtnExportProj = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnNotifyRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnEmail = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tstripLabelMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerNotify = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tbCtrlMain = new System.Windows.Forms.TabControl();
            this.tbPageNotFinish = new System.Windows.Forms.TabPage();
            this.tbPageFinish = new System.Windows.Forms.TabPage();
            this.tbPageSearch = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboxProjDateType = new System.Windows.Forms.ComboBox();
            this.cboxProjFinish = new System.Windows.Forms.ComboBox();
            this.cboxDateChooseSearch = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKeyWords = new System.Windows.Forms.TextBox();
            this.label118 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label119 = new System.Windows.Forms.Label();
            this.label120 = new System.Windows.Forms.Label();
            this.dtpBeginDateSearch = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDateSearch = new System.Windows.Forms.DateTimePicker();
            this.dgvNotepad = new notePadProj.CDoubleBufferDataGridView();
            this.colProjID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colProjName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNotepadFinished = new notePadProj.CDoubleBufferDataGridView();
            this.colProjIDFinished = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjCheckFinished = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colProjNameFinished = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjDateFinished = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjCreateDateFinished = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjFinishedDateFinished = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjContentFinished = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProjSearch = new notePadProj.CDoubleBufferDataGridView();
            this.colProjIDSearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjChekcSearch = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colProjNameSearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjDateSearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjCreateDateSearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjFinishStatusSearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjFinishDateSearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjContentSearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tbCtrlMain.SuspendLayout();
            this.tbPageNotFinish.SuspendLayout();
            this.tbPageFinish.SuspendLayout();
            this.tbPageSearch.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotepad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotepadFinished)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基础信息ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1112, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 基础信息ToolStripMenuItem
            // 
            this.基础信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户设置ToolStripMenuItem});
            this.基础信息ToolStripMenuItem.Name = "基础信息ToolStripMenuItem";
            this.基础信息ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.基础信息ToolStripMenuItem.Text = "【基础信息】";
            // 
            // 用户设置ToolStripMenuItem
            // 
            this.用户设置ToolStripMenuItem.Name = "用户设置ToolStripMenuItem";
            this.用户设置ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.用户设置ToolStripMenuItem.Text = "系统设置...";
            this.用户设置ToolStripMenuItem.Click += new System.EventHandler(this.用户设置ToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnNewProj,
            this.tbtnUpdateProj,
            this.tbtnDeleteProj,
            this.tbtnChangeProjStatus,
            this.tbtnTop,
            this.tbtnRefreshProj,
            this.tbtnAttachment,
            this.toolStripSeparator2,
            this.tbtnSelectAll,
            this.tbtnReverseSelect,
            this.tbtnNoSelect,
            this.tbtnExportProj,
            this.toolStripSeparator3,
            this.tbtnNotifyRefresh,
            this.toolStripSeparator1,
            this.tbtnEmail});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1112, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtnNewProj
            // 
            this.tbtnNewProj.Image = global::notePadProj.Properties.Resources._new;
            this.tbtnNewProj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnNewProj.Name = "tbtnNewProj";
            this.tbtnNewProj.Size = new System.Drawing.Size(52, 22);
            this.tbtnNewProj.Text = "新增";
            this.tbtnNewProj.Click += new System.EventHandler(this.tbtnNewProj_Click);
            // 
            // tbtnUpdateProj
            // 
            this.tbtnUpdateProj.Image = global::notePadProj.Properties.Resources.edit;
            this.tbtnUpdateProj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnUpdateProj.Name = "tbtnUpdateProj";
            this.tbtnUpdateProj.Size = new System.Drawing.Size(52, 22);
            this.tbtnUpdateProj.Text = "修改";
            this.tbtnUpdateProj.Click += new System.EventHandler(this.tbtnUpdateProj_Click);
            // 
            // tbtnDeleteProj
            // 
            this.tbtnDeleteProj.Image = global::notePadProj.Properties.Resources.atsmissing1;
            this.tbtnDeleteProj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnDeleteProj.Name = "tbtnDeleteProj";
            this.tbtnDeleteProj.Size = new System.Drawing.Size(52, 22);
            this.tbtnDeleteProj.Text = "删除";
            this.tbtnDeleteProj.Click += new System.EventHandler(this.tbtnDeleteProj_Click);
            // 
            // tbtnChangeProjStatus
            // 
            this.tbtnChangeProjStatus.Image = global::notePadProj.Properties.Resources._switch;
            this.tbtnChangeProjStatus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnChangeProjStatus.Name = "tbtnChangeProjStatus";
            this.tbtnChangeProjStatus.Size = new System.Drawing.Size(52, 22);
            this.tbtnChangeProjStatus.Text = "完成";
            this.tbtnChangeProjStatus.ToolTipText = "完成/取消完成";
            this.tbtnChangeProjStatus.Click += new System.EventHandler(this.tbtnChangeProjStatus_Click);
            // 
            // tbtnTop
            // 
            this.tbtnTop.Image = global::notePadProj.Properties.Resources.topred;
            this.tbtnTop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnTop.Name = "tbtnTop";
            this.tbtnTop.Size = new System.Drawing.Size(52, 22);
            this.tbtnTop.Text = "置顶";
            this.tbtnTop.ToolTipText = "置顶/取消置顶";
            this.tbtnTop.Click += new System.EventHandler(this.tbtnTop_Click);
            // 
            // tbtnRefreshProj
            // 
            this.tbtnRefreshProj.Image = global::notePadProj.Properties.Resources.refresh21;
            this.tbtnRefreshProj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnRefreshProj.Name = "tbtnRefreshProj";
            this.tbtnRefreshProj.Size = new System.Drawing.Size(76, 22);
            this.tbtnRefreshProj.Text = "刷新工程";
            this.tbtnRefreshProj.ToolTipText = "完成/取消完成";
            this.tbtnRefreshProj.Click += new System.EventHandler(this.tbtnRefreshProj_Click);
            // 
            // tbtnAttachment
            // 
            this.tbtnAttachment.Image = global::notePadProj.Properties.Resources.attachment;
            this.tbtnAttachment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnAttachment.Name = "tbtnAttachment";
            this.tbtnAttachment.Size = new System.Drawing.Size(52, 22);
            this.tbtnAttachment.Text = "查看";
            this.tbtnAttachment.ToolTipText = "完成/取消完成";
            this.tbtnAttachment.Click += new System.EventHandler(this.tbtnAttachment_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtnSelectAll
            // 
            this.tbtnSelectAll.Image = global::notePadProj.Properties.Resources.select1;
            this.tbtnSelectAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnSelectAll.Name = "tbtnSelectAll";
            this.tbtnSelectAll.Size = new System.Drawing.Size(52, 22);
            this.tbtnSelectAll.Text = "全选";
            this.tbtnSelectAll.Click += new System.EventHandler(this.tbtnSelectAll_Click);
            // 
            // tbtnReverseSelect
            // 
            this.tbtnReverseSelect.Image = global::notePadProj.Properties.Resources.select;
            this.tbtnReverseSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnReverseSelect.Name = "tbtnReverseSelect";
            this.tbtnReverseSelect.Size = new System.Drawing.Size(52, 22);
            this.tbtnReverseSelect.Text = "反选";
            this.tbtnReverseSelect.Click += new System.EventHandler(this.tbtnReverseSelect_Click);
            // 
            // tbtnNoSelect
            // 
            this.tbtnNoSelect.Image = global::notePadProj.Properties.Resources.clear;
            this.tbtnNoSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnNoSelect.Name = "tbtnNoSelect";
            this.tbtnNoSelect.Size = new System.Drawing.Size(64, 22);
            this.tbtnNoSelect.Text = "全不选";
            this.tbtnNoSelect.Click += new System.EventHandler(this.tbtnNoSelect_Click);
            // 
            // tbtnExportProj
            // 
            this.tbtnExportProj.Image = global::notePadProj.Properties.Resources.export;
            this.tbtnExportProj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnExportProj.Name = "tbtnExportProj";
            this.tbtnExportProj.Size = new System.Drawing.Size(106, 22);
            this.tbtnExportProj.Text = "导出word文件";
            this.tbtnExportProj.ToolTipText = "导出";
            this.tbtnExportProj.Click += new System.EventHandler(this.tbtnExportProj_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtnNotifyRefresh
            // 
            this.tbtnNotifyRefresh.Image = global::notePadProj.Properties.Resources.notify;
            this.tbtnNotifyRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnNotifyRefresh.Name = "tbtnNotifyRefresh";
            this.tbtnNotifyRefresh.Size = new System.Drawing.Size(76, 22);
            this.tbtnNotifyRefresh.Text = "本地提醒";
            this.tbtnNotifyRefresh.ToolTipText = "刷新";
            this.tbtnNotifyRefresh.Click += new System.EventHandler(this.tbtnRefresh_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtnEmail
            // 
            this.tbtnEmail.Image = global::notePadProj.Properties.Resources.seneemail;
            this.tbtnEmail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnEmail.Name = "tbtnEmail";
            this.tbtnEmail.Size = new System.Drawing.Size(76, 22);
            this.tbtnEmail.Text = "发送邮箱";
            this.tbtnEmail.ToolTipText = "刷新";
            this.tbtnEmail.Click += new System.EventHandler(this.tbtnEmail_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstripLabelMain});
            this.statusStrip1.Location = new System.Drawing.Point(0, 590);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1112, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tstripLabelMain
            // 
            this.tstripLabelMain.AutoSize = false;
            this.tstripLabelMain.Name = "tstripLabelMain";
            this.tstripLabelMain.Size = new System.Drawing.Size(200, 17);
            this.tstripLabelMain.Text = " ";
            this.tstripLabelMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerNotify
            // 
            this.timerNotify.Enabled = true;
            this.timerNotify.Interval = 3600000;
            this.timerNotify.Tick += new System.EventHandler(this.timerNotify_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "记事本";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // tbCtrlMain
            // 
            this.tbCtrlMain.Controls.Add(this.tbPageNotFinish);
            this.tbCtrlMain.Controls.Add(this.tbPageFinish);
            this.tbCtrlMain.Controls.Add(this.tbPageSearch);
            this.tbCtrlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCtrlMain.ItemSize = new System.Drawing.Size(60, 25);
            this.tbCtrlMain.Location = new System.Drawing.Point(0, 50);
            this.tbCtrlMain.Name = "tbCtrlMain";
            this.tbCtrlMain.SelectedIndex = 0;
            this.tbCtrlMain.Size = new System.Drawing.Size(1112, 540);
            this.tbCtrlMain.TabIndex = 16;
            this.tbCtrlMain.SelectedIndexChanged += new System.EventHandler(this.tbCtrlMain_SelectedIndexChanged);
            // 
            // tbPageNotFinish
            // 
            this.tbPageNotFinish.Controls.Add(this.dgvNotepad);
            this.tbPageNotFinish.Location = new System.Drawing.Point(4, 29);
            this.tbPageNotFinish.Name = "tbPageNotFinish";
            this.tbPageNotFinish.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageNotFinish.Size = new System.Drawing.Size(1104, 507);
            this.tbPageNotFinish.TabIndex = 0;
            this.tbPageNotFinish.Text = " 未完成 ";
            this.tbPageNotFinish.UseVisualStyleBackColor = true;
            // 
            // tbPageFinish
            // 
            this.tbPageFinish.Controls.Add(this.dgvNotepadFinished);
            this.tbPageFinish.Location = new System.Drawing.Point(4, 29);
            this.tbPageFinish.Name = "tbPageFinish";
            this.tbPageFinish.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageFinish.Size = new System.Drawing.Size(1104, 507);
            this.tbPageFinish.TabIndex = 1;
            this.tbPageFinish.Text = " 已完成 ";
            this.tbPageFinish.UseVisualStyleBackColor = true;
            // 
            // tbPageSearch
            // 
            this.tbPageSearch.Controls.Add(this.dgvProjSearch);
            this.tbPageSearch.Controls.Add(this.panel5);
            this.tbPageSearch.Location = new System.Drawing.Point(4, 29);
            this.tbPageSearch.Name = "tbPageSearch";
            this.tbPageSearch.Size = new System.Drawing.Size(1104, 507);
            this.tbPageSearch.TabIndex = 2;
            this.tbPageSearch.Text = " 查 询 ";
            this.tbPageSearch.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnSearch);
            this.panel5.Controls.Add(this.cboxProjDateType);
            this.panel5.Controls.Add(this.cboxProjFinish);
            this.panel5.Controls.Add(this.cboxDateChooseSearch);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.txtKeyWords);
            this.panel5.Controls.Add(this.label118);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.label119);
            this.panel5.Controls.Add(this.label120);
            this.panel5.Controls.Add(this.dtpBeginDateSearch);
            this.panel5.Controls.Add(this.dtpEndDateSearch);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1101, 61);
            this.panel5.TabIndex = 16;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.Image = global::notePadProj.Properties.Resources.search3;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.Location = new System.Drawing.Point(1008, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 34);
            this.btnSearch.TabIndex = 39;
            this.btnSearch.Text = "查 询";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboxProjDateType
            // 
            this.cboxProjDateType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxProjDateType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxProjDateType.FormattingEnabled = true;
            this.cboxProjDateType.Items.AddRange(new object[] {
            "事项日期",
            "创建日期",
            "完成日期",
            ""});
            this.cboxProjDateType.Location = new System.Drawing.Point(314, 31);
            this.cboxProjDateType.Name = "cboxProjDateType";
            this.cboxProjDateType.Size = new System.Drawing.Size(121, 20);
            this.cboxProjDateType.TabIndex = 38;
            this.cboxProjDateType.SelectedIndexChanged += new System.EventHandler(this.cboxProjDateType_SelectedIndexChanged);
            // 
            // cboxProjFinish
            // 
            this.cboxProjFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxProjFinish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxProjFinish.FormattingEnabled = true;
            this.cboxProjFinish.Items.AddRange(new object[] {
            "全部",
            "未完成",
            "已完成"});
            this.cboxProjFinish.Location = new System.Drawing.Point(852, 31);
            this.cboxProjFinish.Name = "cboxProjFinish";
            this.cboxProjFinish.Size = new System.Drawing.Size(121, 20);
            this.cboxProjFinish.TabIndex = 38;
            // 
            // cboxDateChooseSearch
            // 
            this.cboxDateChooseSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxDateChooseSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxDateChooseSearch.FormattingEnabled = true;
            this.cboxDateChooseSearch.Items.AddRange(new object[] {
            "本月",
            "上一月",
            "本季度",
            "上季度",
            "本年度",
            ""});
            this.cboxDateChooseSearch.Location = new System.Drawing.Point(442, 31);
            this.cboxDateChooseSearch.Name = "cboxDateChooseSearch";
            this.cboxDateChooseSearch.Size = new System.Drawing.Size(119, 20);
            this.cboxDateChooseSearch.TabIndex = 36;
            this.cboxDateChooseSearch.SelectedIndexChanged += new System.EventHandler(this.cbx_tongji_dateselect_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(181)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "关键词";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(181)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(314, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "日期类型";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtKeyWords
            // 
            this.txtKeyWords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKeyWords.Location = new System.Drawing.Point(5, 31);
            this.txtKeyWords.Name = "txtKeyWords";
            this.txtKeyWords.Size = new System.Drawing.Size(275, 21);
            this.txtKeyWords.TabIndex = 12;
            // 
            // label118
            // 
            this.label118.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label118.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(181)))));
            this.label118.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label118.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label118.ForeColor = System.Drawing.Color.White;
            this.label118.Location = new System.Drawing.Point(441, 8);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(119, 20);
            this.label118.TabIndex = 35;
            this.label118.Text = "日期选择";
            this.label118.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(181)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(852, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "完成情况";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label119
            // 
            this.label119.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label119.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(181)))));
            this.label119.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label119.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label119.ForeColor = System.Drawing.Color.White;
            this.label119.Location = new System.Drawing.Point(695, 8);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(119, 20);
            this.label119.TabIndex = 33;
            this.label119.Text = "结束日期:";
            this.label119.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label120
            // 
            this.label120.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label120.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(181)))));
            this.label120.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label120.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label120.ForeColor = System.Drawing.Color.White;
            this.label120.Location = new System.Drawing.Point(568, 8);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(119, 20);
            this.label120.TabIndex = 34;
            this.label120.Text = "起始日期";
            this.label120.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpBeginDateSearch
            // 
            this.dtpBeginDateSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpBeginDateSearch.Checked = false;
            this.dtpBeginDateSearch.CustomFormat = "yyyy/MM/dd";
            this.dtpBeginDateSearch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBeginDateSearch.Location = new System.Drawing.Point(568, 31);
            this.dtpBeginDateSearch.Name = "dtpBeginDateSearch";
            this.dtpBeginDateSearch.ShowCheckBox = true;
            this.dtpBeginDateSearch.Size = new System.Drawing.Size(119, 21);
            this.dtpBeginDateSearch.TabIndex = 31;
            // 
            // dtpEndDateSearch
            // 
            this.dtpEndDateSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEndDateSearch.Checked = false;
            this.dtpEndDateSearch.CustomFormat = "yyyy/MM/dd";
            this.dtpEndDateSearch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDateSearch.Location = new System.Drawing.Point(694, 31);
            this.dtpEndDateSearch.Name = "dtpEndDateSearch";
            this.dtpEndDateSearch.ShowCheckBox = true;
            this.dtpEndDateSearch.Size = new System.Drawing.Size(119, 21);
            this.dtpEndDateSearch.TabIndex = 32;
            // 
            // dgvNotepad
            // 
            this.dgvNotepad.AllowUserToAddRows = false;
            this.dgvNotepad.AllowUserToDeleteRows = false;
            this.dgvNotepad.AllowUserToResizeColumns = false;
            this.dgvNotepad.AllowUserToResizeRows = false;
            this.dgvNotepad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNotepad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotepad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNotepad.ColumnHeadersHeight = 25;
            this.dgvNotepad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNotepad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProjID,
            this.colProjCheck,
            this.colProjName,
            this.colProjDate,
            this.colProjCreateDate,
            this.colProjContent});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNotepad.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNotepad.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvNotepad.EnableHeadersVisualStyles = false;
            this.dgvNotepad.Location = new System.Drawing.Point(3, 3);
            this.dgvNotepad.MultiSelect = false;
            this.dgvNotepad.Name = "dgvNotepad";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotepad.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNotepad.RowHeadersWidth = 30;
            this.dgvNotepad.RowTemplate.Height = 23;
            this.dgvNotepad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvNotepad.Size = new System.Drawing.Size(1098, 501);
            this.dgvNotepad.TabIndex = 13;
            this.dgvNotepad.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotepad_RowEnter);
            // 
            // colProjID
            // 
            this.colProjID.HeaderText = "projID";
            this.colProjID.Name = "colProjID";
            this.colProjID.Visible = false;
            // 
            // colProjCheck
            // 
            this.colProjCheck.FillWeight = 15F;
            this.colProjCheck.HeaderText = "选择";
            this.colProjCheck.Name = "colProjCheck";
            this.colProjCheck.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colProjCheck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colProjName
            // 
            this.colProjName.HeaderText = "事项名称";
            this.colProjName.Name = "colProjName";
            this.colProjName.ReadOnly = true;
            // 
            // colProjDate
            // 
            this.colProjDate.FillWeight = 40F;
            this.colProjDate.HeaderText = "事项日期";
            this.colProjDate.Name = "colProjDate";
            this.colProjDate.ReadOnly = true;
            // 
            // colProjCreateDate
            // 
            this.colProjCreateDate.FillWeight = 40F;
            this.colProjCreateDate.HeaderText = "创建日期";
            this.colProjCreateDate.Name = "colProjCreateDate";
            this.colProjCreateDate.ReadOnly = true;
            // 
            // colProjContent
            // 
            this.colProjContent.FillWeight = 150F;
            this.colProjContent.HeaderText = "事项内容";
            this.colProjContent.Name = "colProjContent";
            this.colProjContent.ReadOnly = true;
            // 
            // dgvNotepadFinished
            // 
            this.dgvNotepadFinished.AllowUserToAddRows = false;
            this.dgvNotepadFinished.AllowUserToDeleteRows = false;
            this.dgvNotepadFinished.AllowUserToResizeColumns = false;
            this.dgvNotepadFinished.AllowUserToResizeRows = false;
            this.dgvNotepadFinished.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNotepadFinished.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotepadFinished.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNotepadFinished.ColumnHeadersHeight = 25;
            this.dgvNotepadFinished.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNotepadFinished.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProjIDFinished,
            this.colProjCheckFinished,
            this.colProjNameFinished,
            this.colProjDateFinished,
            this.colProjCreateDateFinished,
            this.colProjFinishedDateFinished,
            this.colProjContentFinished});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNotepadFinished.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvNotepadFinished.EnableHeadersVisualStyles = false;
            this.dgvNotepadFinished.Location = new System.Drawing.Point(3, 3);
            this.dgvNotepadFinished.MultiSelect = false;
            this.dgvNotepadFinished.Name = "dgvNotepadFinished";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotepadFinished.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvNotepadFinished.RowHeadersWidth = 30;
            this.dgvNotepadFinished.RowTemplate.Height = 23;
            this.dgvNotepadFinished.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvNotepadFinished.Size = new System.Drawing.Size(1098, 501);
            this.dgvNotepadFinished.TabIndex = 14;
            this.dgvNotepadFinished.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotepad_RowEnter);
            // 
            // colProjIDFinished
            // 
            this.colProjIDFinished.HeaderText = "projID";
            this.colProjIDFinished.Name = "colProjIDFinished";
            this.colProjIDFinished.Visible = false;
            // 
            // colProjCheckFinished
            // 
            this.colProjCheckFinished.FillWeight = 15F;
            this.colProjCheckFinished.HeaderText = "选择";
            this.colProjCheckFinished.Name = "colProjCheckFinished";
            // 
            // colProjNameFinished
            // 
            this.colProjNameFinished.HeaderText = "事项名称";
            this.colProjNameFinished.Name = "colProjNameFinished";
            this.colProjNameFinished.ReadOnly = true;
            // 
            // colProjDateFinished
            // 
            this.colProjDateFinished.FillWeight = 40F;
            this.colProjDateFinished.HeaderText = "事项日期";
            this.colProjDateFinished.Name = "colProjDateFinished";
            this.colProjDateFinished.ReadOnly = true;
            // 
            // colProjCreateDateFinished
            // 
            this.colProjCreateDateFinished.FillWeight = 40F;
            this.colProjCreateDateFinished.HeaderText = "创建日期";
            this.colProjCreateDateFinished.Name = "colProjCreateDateFinished";
            this.colProjCreateDateFinished.ReadOnly = true;
            // 
            // colProjFinishedDateFinished
            // 
            this.colProjFinishedDateFinished.FillWeight = 40F;
            this.colProjFinishedDateFinished.HeaderText = "完成日期";
            this.colProjFinishedDateFinished.Name = "colProjFinishedDateFinished";
            this.colProjFinishedDateFinished.ReadOnly = true;
            // 
            // colProjContentFinished
            // 
            this.colProjContentFinished.FillWeight = 150F;
            this.colProjContentFinished.HeaderText = "事项内容";
            this.colProjContentFinished.Name = "colProjContentFinished";
            this.colProjContentFinished.ReadOnly = true;
            // 
            // dgvProjSearch
            // 
            this.dgvProjSearch.AllowUserToAddRows = false;
            this.dgvProjSearch.AllowUserToDeleteRows = false;
            this.dgvProjSearch.AllowUserToResizeColumns = false;
            this.dgvProjSearch.AllowUserToResizeRows = false;
            this.dgvProjSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProjSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProjSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProjSearch.ColumnHeadersHeight = 25;
            this.dgvProjSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProjSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProjIDSearch,
            this.colProjChekcSearch,
            this.colProjNameSearch,
            this.colProjDateSearch,
            this.colProjCreateDateSearch,
            this.colProjFinishStatusSearch,
            this.colProjFinishDateSearch,
            this.colProjContentSearch});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProjSearch.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvProjSearch.EnableHeadersVisualStyles = false;
            this.dgvProjSearch.Location = new System.Drawing.Point(3, 65);
            this.dgvProjSearch.MultiSelect = false;
            this.dgvProjSearch.Name = "dgvProjSearch";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProjSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvProjSearch.RowHeadersWidth = 30;
            this.dgvProjSearch.RowTemplate.Height = 23;
            this.dgvProjSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvProjSearch.Size = new System.Drawing.Size(1098, 439);
            this.dgvProjSearch.TabIndex = 17;
            // 
            // colProjIDSearch
            // 
            this.colProjIDSearch.HeaderText = "projID";
            this.colProjIDSearch.Name = "colProjIDSearch";
            this.colProjIDSearch.Visible = false;
            // 
            // colProjChekcSearch
            // 
            this.colProjChekcSearch.FillWeight = 20F;
            this.colProjChekcSearch.HeaderText = "选择";
            this.colProjChekcSearch.Name = "colProjChekcSearch";
            // 
            // colProjNameSearch
            // 
            this.colProjNameSearch.HeaderText = "事项名称";
            this.colProjNameSearch.Name = "colProjNameSearch";
            this.colProjNameSearch.ReadOnly = true;
            // 
            // colProjDateSearch
            // 
            this.colProjDateSearch.FillWeight = 40F;
            this.colProjDateSearch.HeaderText = "事项日期";
            this.colProjDateSearch.Name = "colProjDateSearch";
            this.colProjDateSearch.ReadOnly = true;
            // 
            // colProjCreateDateSearch
            // 
            this.colProjCreateDateSearch.FillWeight = 40F;
            this.colProjCreateDateSearch.HeaderText = "创建日期";
            this.colProjCreateDateSearch.Name = "colProjCreateDateSearch";
            this.colProjCreateDateSearch.ReadOnly = true;
            // 
            // colProjFinishStatusSearch
            // 
            this.colProjFinishStatusSearch.HeaderText = "是否完成";
            this.colProjFinishStatusSearch.Name = "colProjFinishStatusSearch";
            this.colProjFinishStatusSearch.ReadOnly = true;
            // 
            // colProjFinishDateSearch
            // 
            this.colProjFinishDateSearch.FillWeight = 40F;
            this.colProjFinishDateSearch.HeaderText = "完成日期";
            this.colProjFinishDateSearch.Name = "colProjFinishDateSearch";
            this.colProjFinishDateSearch.ReadOnly = true;
            // 
            // colProjContentSearch
            // 
            this.colProjContentSearch.FillWeight = 150F;
            this.colProjContentSearch.HeaderText = "事项内容";
            this.colProjContentSearch.Name = "colProjContentSearch";
            this.colProjContentSearch.ReadOnly = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1112, 612);
            this.Controls.Add(this.tbCtrlMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "记事本V1.0";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.SizeChanged += new System.EventHandler(this.FormMain_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tbCtrlMain.ResumeLayout(false);
            this.tbPageNotFinish.ResumeLayout(false);
            this.tbPageFinish.ResumeLayout(false);
            this.tbPageSearch.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotepad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotepadFinished)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 基础信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnNewProj;
        private CDoubleBufferDataGridView dgvNotepad;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tstripLabelMain;
        private System.Windows.Forms.ToolStripButton tbtnUpdateProj;
        private System.Windows.Forms.ToolStripButton tbtnDeleteProj;
        private System.Windows.Forms.ToolStripButton tbtnChangeProjStatus;
        private System.Windows.Forms.ToolStripButton tbtnAttachment;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tbtnNotifyRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tbtnExportProj;
        private System.Windows.Forms.Timer timerNotify;
        private System.Windows.Forms.ToolStripMenuItem 用户设置ToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripButton tbtnSelectAll;
        private System.Windows.Forms.ToolStripButton tbtnReverseSelect;
        private System.Windows.Forms.ToolStripButton tbtnNoSelect;
        private System.Windows.Forms.TabControl tbCtrlMain;
        private System.Windows.Forms.TabPage tbPageNotFinish;
        private System.Windows.Forms.TabPage tbPageFinish;
        private CDoubleBufferDataGridView dgvNotepadFinished;
        private System.Windows.Forms.TabPage tbPageSearch;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboxProjDateType;
        private System.Windows.Forms.ComboBox cboxProjFinish;
        private System.Windows.Forms.ComboBox cboxDateChooseSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKeyWords;
        private System.Windows.Forms.Label label118;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label119;
        private System.Windows.Forms.Label label120;
        private System.Windows.Forms.DateTimePicker dtpBeginDateSearch;
        private System.Windows.Forms.DateTimePicker dtpEndDateSearch;
        private CDoubleBufferDataGridView dgvProjSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colProjCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjCreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjContent;
        private System.Windows.Forms.ToolStripButton tbtnRefreshProj;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjIDFinished;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colProjCheckFinished;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjNameFinished;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjDateFinished;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjCreateDateFinished;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjFinishedDateFinished;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjContentFinished;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjIDSearch;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colProjChekcSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjNameSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjDateSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjCreateDateSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjFinishStatusSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjFinishDateSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjContentSearch;
        private System.Windows.Forms.ToolStripButton tbtnEmail;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbtnTop;
    }
}