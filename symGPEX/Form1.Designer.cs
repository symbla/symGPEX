namespace symGPEX
{
    partial class gpexBase
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gpexLblComponentFile = new System.Windows.Forms.Label();
            this.gpexTxtPHPPath = new System.Windows.Forms.TextBox();
            this.gpexLblPHPPath = new System.Windows.Forms.Label();
            this.gpexBtnBrowsePHPPath = new System.Windows.Forms.Button();
            this.gpexBtnBrowseComponentFile = new System.Windows.Forms.Button();
            this.gpexTxtComponentPath = new System.Windows.Forms.TextBox();
            this.gpexGrpProjectData = new System.Windows.Forms.GroupBox();
            this.gpexLblProjectSizeCounter = new System.Windows.Forms.Label();
            this.gpexLblProjectSize = new System.Windows.Forms.Label();
            this.gpexLblProjectDirsCounter = new System.Windows.Forms.Label();
            this.gpexLblProjectFilesCounter = new System.Windows.Forms.Label();
            this.gpexLblProjectDirs = new System.Windows.Forms.Label();
            this.gpexLblProjectFiles = new System.Windows.Forms.Label();
            this.gpexGrpLog = new System.Windows.Forms.GroupBox();
            this.gpexLinkExportLog = new System.Windows.Forms.LinkLabel();
            this.gpexLinkClearLog = new System.Windows.Forms.LinkLabel();
            this.gpexTxtLogOutput = new System.Windows.Forms.TextBox();
            this.gpexGrpExtensionList = new System.Windows.Forms.GroupBox();
            this.gpexGridExtensions = new System.Windows.Forms.DataGridView();
            this.gpexLblCopyright = new System.Windows.Forms.Label();
            this.gpexBtnRun = new System.Windows.Forms.Button();
            this.gpexBtnClearData = new System.Windows.Forms.Button();
            this.gpexGrpExtensionData = new System.Windows.Forms.GroupBox();
            this.gpexLinkExtensionOnline = new System.Windows.Forms.LinkLabel();
            this.gpexLblExtensionLink = new System.Windows.Forms.Label();
            this.gpexLblExtensionNativeData = new System.Windows.Forms.Label();
            this.gpexLblExtensionName = new System.Windows.Forms.Label();
            this.gpexLblExtensionNameData = new System.Windows.Forms.Label();
            this.gpexLblExtensionNative = new System.Windows.Forms.Label();
            this.gpexCheckReadRecursive = new System.Windows.Forms.CheckBox();
            this.gpexCheckOnlyPHPFiles = new System.Windows.Forms.CheckBox();
            this.gpexLblDescription = new System.Windows.Forms.Label();
            this.gpexGrpSettings = new System.Windows.Forms.GroupBox();
            this.gpexCheckRunInBackground = new System.Windows.Forms.CheckBox();
            this.gpexCheckIgnoreMeta = new System.Windows.Forms.CheckBox();
            this.gpexTrayContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.öffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpexGrpFilter = new System.Windows.Forms.GroupBox();
            this.gpexColExtensionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpexColExtensionNative = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpexColExtensionPHPNetLink = new System.Windows.Forms.DataGridViewLinkColumn();
            this.gpexGrpProjectData.SuspendLayout();
            this.gpexGrpLog.SuspendLayout();
            this.gpexGrpExtensionList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpexGridExtensions)).BeginInit();
            this.gpexGrpExtensionData.SuspendLayout();
            this.gpexGrpSettings.SuspendLayout();
            this.gpexTrayContext.SuspendLayout();
            this.gpexGrpFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpexLblComponentFile
            // 
            this.gpexLblComponentFile.AutoSize = true;
            this.gpexLblComponentFile.Location = new System.Drawing.Point(12, 12);
            this.gpexLblComponentFile.Name = "gpexLblComponentFile";
            this.gpexLblComponentFile.Size = new System.Drawing.Size(94, 13);
            this.gpexLblComponentFile.TabIndex = 1;
            this.gpexLblComponentFile.Text = "Komponentenpfad";
            // 
            // gpexTxtPHPPath
            // 
            this.gpexTxtPHPPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gpexTxtPHPPath.Location = new System.Drawing.Point(12, 67);
            this.gpexTxtPHPPath.Name = "gpexTxtPHPPath";
            this.gpexTxtPHPPath.Size = new System.Drawing.Size(277, 20);
            this.gpexTxtPHPPath.TabIndex = 0;
            // 
            // gpexLblPHPPath
            // 
            this.gpexLblPHPPath.AutoSize = true;
            this.gpexLblPHPPath.Location = new System.Drawing.Point(12, 51);
            this.gpexLblPHPPath.Name = "gpexLblPHPPath";
            this.gpexLblPHPPath.Size = new System.Drawing.Size(61, 13);
            this.gpexLblPHPPath.TabIndex = 1;
            this.gpexLblPHPPath.Text = "Projektpfad";
            // 
            // gpexBtnBrowsePHPPath
            // 
            this.gpexBtnBrowsePHPPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpexBtnBrowsePHPPath.Location = new System.Drawing.Point(296, 65);
            this.gpexBtnBrowsePHPPath.Name = "gpexBtnBrowsePHPPath";
            this.gpexBtnBrowsePHPPath.Size = new System.Drawing.Size(69, 23);
            this.gpexBtnBrowsePHPPath.TabIndex = 2;
            this.gpexBtnBrowsePHPPath.Text = "Auswählen";
            this.gpexBtnBrowsePHPPath.UseVisualStyleBackColor = true;
            this.gpexBtnBrowsePHPPath.Click += new System.EventHandler(this.gpexBtnBrowsePHPPath_Click);
            // 
            // gpexBtnBrowseComponentFile
            // 
            this.gpexBtnBrowseComponentFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpexBtnBrowseComponentFile.Location = new System.Drawing.Point(296, 26);
            this.gpexBtnBrowseComponentFile.Name = "gpexBtnBrowseComponentFile";
            this.gpexBtnBrowseComponentFile.Size = new System.Drawing.Size(69, 23);
            this.gpexBtnBrowseComponentFile.TabIndex = 3;
            this.gpexBtnBrowseComponentFile.Text = "Auswählen";
            this.gpexBtnBrowseComponentFile.UseVisualStyleBackColor = true;
            this.gpexBtnBrowseComponentFile.Click += new System.EventHandler(this.gpexBtnBrowseComponentFile_Click);
            // 
            // gpexTxtComponentPath
            // 
            this.gpexTxtComponentPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gpexTxtComponentPath.Location = new System.Drawing.Point(12, 28);
            this.gpexTxtComponentPath.Name = "gpexTxtComponentPath";
            this.gpexTxtComponentPath.Size = new System.Drawing.Size(277, 20);
            this.gpexTxtComponentPath.TabIndex = 0;
            // 
            // gpexGrpProjectData
            // 
            this.gpexGrpProjectData.Controls.Add(this.gpexLblProjectSizeCounter);
            this.gpexGrpProjectData.Controls.Add(this.gpexLblProjectSize);
            this.gpexGrpProjectData.Controls.Add(this.gpexLblProjectDirsCounter);
            this.gpexGrpProjectData.Controls.Add(this.gpexLblProjectFilesCounter);
            this.gpexGrpProjectData.Controls.Add(this.gpexLblProjectDirs);
            this.gpexGrpProjectData.Controls.Add(this.gpexLblProjectFiles);
            this.gpexGrpProjectData.Location = new System.Drawing.Point(12, 93);
            this.gpexGrpProjectData.Name = "gpexGrpProjectData";
            this.gpexGrpProjectData.Size = new System.Drawing.Size(157, 79);
            this.gpexGrpProjectData.TabIndex = 4;
            this.gpexGrpProjectData.TabStop = false;
            this.gpexGrpProjectData.Text = "Projekt Details";
            // 
            // gpexLblProjectSizeCounter
            // 
            this.gpexLblProjectSizeCounter.AutoSize = true;
            this.gpexLblProjectSizeCounter.Location = new System.Drawing.Point(64, 56);
            this.gpexLblProjectSizeCounter.Name = "gpexLblProjectSizeCounter";
            this.gpexLblProjectSizeCounter.Size = new System.Drawing.Size(10, 13);
            this.gpexLblProjectSizeCounter.TabIndex = 5;
            this.gpexLblProjectSizeCounter.Text = "-";
            // 
            // gpexLblProjectSize
            // 
            this.gpexLblProjectSize.AutoSize = true;
            this.gpexLblProjectSize.Location = new System.Drawing.Point(7, 56);
            this.gpexLblProjectSize.Name = "gpexLblProjectSize";
            this.gpexLblProjectSize.Size = new System.Drawing.Size(39, 13);
            this.gpexLblProjectSize.TabIndex = 4;
            this.gpexLblProjectSize.Text = "Größe:";
            // 
            // gpexLblProjectDirsCounter
            // 
            this.gpexLblProjectDirsCounter.AutoSize = true;
            this.gpexLblProjectDirsCounter.Location = new System.Drawing.Point(64, 38);
            this.gpexLblProjectDirsCounter.Name = "gpexLblProjectDirsCounter";
            this.gpexLblProjectDirsCounter.Size = new System.Drawing.Size(10, 13);
            this.gpexLblProjectDirsCounter.TabIndex = 3;
            this.gpexLblProjectDirsCounter.Text = "-";
            // 
            // gpexLblProjectFilesCounter
            // 
            this.gpexLblProjectFilesCounter.AutoSize = true;
            this.gpexLblProjectFilesCounter.Location = new System.Drawing.Point(64, 20);
            this.gpexLblProjectFilesCounter.Name = "gpexLblProjectFilesCounter";
            this.gpexLblProjectFilesCounter.Size = new System.Drawing.Size(10, 13);
            this.gpexLblProjectFilesCounter.TabIndex = 2;
            this.gpexLblProjectFilesCounter.Text = "-";
            // 
            // gpexLblProjectDirs
            // 
            this.gpexLblProjectDirs.AutoSize = true;
            this.gpexLblProjectDirs.Location = new System.Drawing.Point(7, 38);
            this.gpexLblProjectDirs.Name = "gpexLblProjectDirs";
            this.gpexLblProjectDirs.Size = new System.Drawing.Size(42, 13);
            this.gpexLblProjectDirs.TabIndex = 1;
            this.gpexLblProjectDirs.Text = "Ordner:";
            // 
            // gpexLblProjectFiles
            // 
            this.gpexLblProjectFiles.AutoSize = true;
            this.gpexLblProjectFiles.Location = new System.Drawing.Point(7, 20);
            this.gpexLblProjectFiles.Name = "gpexLblProjectFiles";
            this.gpexLblProjectFiles.Size = new System.Drawing.Size(47, 13);
            this.gpexLblProjectFiles.TabIndex = 0;
            this.gpexLblProjectFiles.Text = "Dateien:";
            // 
            // gpexGrpLog
            // 
            this.gpexGrpLog.Controls.Add(this.gpexLinkExportLog);
            this.gpexGrpLog.Controls.Add(this.gpexLinkClearLog);
            this.gpexGrpLog.Controls.Add(this.gpexTxtLogOutput);
            this.gpexGrpLog.Location = new System.Drawing.Point(12, 264);
            this.gpexGrpLog.Name = "gpexGrpLog";
            this.gpexGrpLog.Size = new System.Drawing.Size(836, 169);
            this.gpexGrpLog.TabIndex = 5;
            this.gpexGrpLog.TabStop = false;
            this.gpexGrpLog.Text = "Log";
            // 
            // gpexLinkExportLog
            // 
            this.gpexLinkExportLog.AutoSize = true;
            this.gpexLinkExportLog.Location = new System.Drawing.Point(77, 0);
            this.gpexLinkExportLog.Name = "gpexLinkExportLog";
            this.gpexLinkExportLog.Size = new System.Drawing.Size(59, 13);
            this.gpexLinkExportLog.TabIndex = 2;
            this.gpexLinkExportLog.TabStop = true;
            this.gpexLinkExportLog.Text = "exportieren";
            this.gpexLinkExportLog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gpexLinkExportLog_LinkClicked);
            // 
            // gpexLinkClearLog
            // 
            this.gpexLinkClearLog.AutoSize = true;
            this.gpexLinkClearLog.Location = new System.Drawing.Point(39, 0);
            this.gpexLinkClearLog.Name = "gpexLinkClearLog";
            this.gpexLinkClearLog.Size = new System.Drawing.Size(36, 13);
            this.gpexLinkClearLog.TabIndex = 1;
            this.gpexLinkClearLog.TabStop = true;
            this.gpexLinkClearLog.Text = "leeren";
            this.gpexLinkClearLog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gpexLinkClearLog_LinkClicked);
            // 
            // gpexTxtLogOutput
            // 
            this.gpexTxtLogOutput.BackColor = System.Drawing.SystemColors.Menu;
            this.gpexTxtLogOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gpexTxtLogOutput.ForeColor = System.Drawing.SystemColors.GrayText;
            this.gpexTxtLogOutput.Location = new System.Drawing.Point(6, 16);
            this.gpexTxtLogOutput.Multiline = true;
            this.gpexTxtLogOutput.Name = "gpexTxtLogOutput";
            this.gpexTxtLogOutput.ReadOnly = true;
            this.gpexTxtLogOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.gpexTxtLogOutput.Size = new System.Drawing.Size(824, 147);
            this.gpexTxtLogOutput.TabIndex = 0;
            // 
            // gpexGrpExtensionList
            // 
            this.gpexGrpExtensionList.Controls.Add(this.gpexGridExtensions);
            this.gpexGrpExtensionList.Location = new System.Drawing.Point(371, 12);
            this.gpexGrpExtensionList.Name = "gpexGrpExtensionList";
            this.gpexGrpExtensionList.Size = new System.Drawing.Size(640, 246);
            this.gpexGrpExtensionList.TabIndex = 6;
            this.gpexGrpExtensionList.TabStop = false;
            this.gpexGrpExtensionList.Text = "Benötigte Extensions";
            // 
            // gpexGridExtensions
            // 
            this.gpexGridExtensions.AllowUserToDeleteRows = false;
            this.gpexGridExtensions.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gpexGridExtensions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gpexGridExtensions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gpexGridExtensions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gpexGridExtensions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gpexGridExtensions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gpexGridExtensions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gpexColExtensionName,
            this.gpexColExtensionNative,
            this.gpexColExtensionPHPNetLink});
            this.gpexGridExtensions.EnableHeadersVisualStyles = false;
            this.gpexGridExtensions.Location = new System.Drawing.Point(7, 19);
            this.gpexGridExtensions.Name = "gpexGridExtensions";
            this.gpexGridExtensions.ReadOnly = true;
            this.gpexGridExtensions.Size = new System.Drawing.Size(627, 219);
            this.gpexGridExtensions.TabIndex = 0;
            // 
            // gpexLblCopyright
            // 
            this.gpexLblCopyright.AutoSize = true;
            this.gpexLblCopyright.ForeColor = System.Drawing.SystemColors.GrayText;
            this.gpexLblCopyright.Location = new System.Drawing.Point(626, 441);
            this.gpexLblCopyright.Name = "gpexLblCopyright";
            this.gpexLblCopyright.Size = new System.Drawing.Size(222, 13);
            this.gpexLblCopyright.TabIndex = 8;
            this.gpexLblCopyright.Text = "(c) 2015 symbla.org. Alle Rechte vorbehalten.\r\n";
            // 
            // gpexBtnRun
            // 
            this.gpexBtnRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gpexBtnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpexBtnRun.Location = new System.Drawing.Point(854, 381);
            this.gpexBtnRun.Name = "gpexBtnRun";
            this.gpexBtnRun.Size = new System.Drawing.Size(157, 46);
            this.gpexBtnRun.TabIndex = 10;
            this.gpexBtnRun.Text = "Auslesen";
            this.gpexBtnRun.UseVisualStyleBackColor = false;
            this.gpexBtnRun.Click += new System.EventHandler(this.gpexBtnRun_Click);
            // 
            // gpexBtnClearData
            // 
            this.gpexBtnClearData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpexBtnClearData.Location = new System.Drawing.Point(854, 349);
            this.gpexBtnClearData.Name = "gpexBtnClearData";
            this.gpexBtnClearData.Size = new System.Drawing.Size(157, 26);
            this.gpexBtnClearData.TabIndex = 10;
            this.gpexBtnClearData.Text = "Zurücksetzen";
            this.gpexBtnClearData.UseVisualStyleBackColor = true;
            this.gpexBtnClearData.Click += new System.EventHandler(this.gpexBtnClearData_Click);
            // 
            // gpexGrpExtensionData
            // 
            this.gpexGrpExtensionData.Controls.Add(this.gpexLinkExtensionOnline);
            this.gpexGrpExtensionData.Controls.Add(this.gpexLblExtensionLink);
            this.gpexGrpExtensionData.Controls.Add(this.gpexLblExtensionNativeData);
            this.gpexGrpExtensionData.Controls.Add(this.gpexLblExtensionName);
            this.gpexGrpExtensionData.Controls.Add(this.gpexLblExtensionNameData);
            this.gpexGrpExtensionData.Controls.Add(this.gpexLblExtensionNative);
            this.gpexGrpExtensionData.Location = new System.Drawing.Point(175, 95);
            this.gpexGrpExtensionData.Name = "gpexGrpExtensionData";
            this.gpexGrpExtensionData.Size = new System.Drawing.Size(190, 77);
            this.gpexGrpExtensionData.TabIndex = 11;
            this.gpexGrpExtensionData.TabStop = false;
            this.gpexGrpExtensionData.Text = "Extension Details";
            // 
            // gpexLinkExtensionOnline
            // 
            this.gpexLinkExtensionOnline.AutoSize = true;
            this.gpexLinkExtensionOnline.Location = new System.Drawing.Point(52, 54);
            this.gpexLinkExtensionOnline.Name = "gpexLinkExtensionOnline";
            this.gpexLinkExtensionOnline.Size = new System.Drawing.Size(130, 13);
            this.gpexLinkExtensionOnline.TabIndex = 5;
            this.gpexLinkExtensionOnline.TabStop = true;
            this.gpexLinkExtensionOnline.Tag = "http://php.net";
            this.gpexLinkExtensionOnline.Text = "php.net Extension Manual";
            this.gpexLinkExtensionOnline.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gpexLinkExtensionOnline_LinkClicked);
            // 
            // gpexLblExtensionLink
            // 
            this.gpexLblExtensionLink.AutoSize = true;
            this.gpexLblExtensionLink.Location = new System.Drawing.Point(6, 54);
            this.gpexLblExtensionLink.Name = "gpexLblExtensionLink";
            this.gpexLblExtensionLink.Size = new System.Drawing.Size(40, 13);
            this.gpexLblExtensionLink.TabIndex = 4;
            this.gpexLblExtensionLink.Text = "Online:";
            // 
            // gpexLblExtensionNativeData
            // 
            this.gpexLblExtensionNativeData.AutoSize = true;
            this.gpexLblExtensionNativeData.Location = new System.Drawing.Point(52, 36);
            this.gpexLblExtensionNativeData.Name = "gpexLblExtensionNativeData";
            this.gpexLblExtensionNativeData.Size = new System.Drawing.Size(10, 13);
            this.gpexLblExtensionNativeData.TabIndex = 3;
            this.gpexLblExtensionNativeData.Text = "-";
            // 
            // gpexLblExtensionName
            // 
            this.gpexLblExtensionName.AutoSize = true;
            this.gpexLblExtensionName.Location = new System.Drawing.Point(6, 18);
            this.gpexLblExtensionName.Name = "gpexLblExtensionName";
            this.gpexLblExtensionName.Size = new System.Drawing.Size(38, 13);
            this.gpexLblExtensionName.TabIndex = 0;
            this.gpexLblExtensionName.Text = "Name:";
            // 
            // gpexLblExtensionNameData
            // 
            this.gpexLblExtensionNameData.AutoSize = true;
            this.gpexLblExtensionNameData.Location = new System.Drawing.Point(52, 18);
            this.gpexLblExtensionNameData.Name = "gpexLblExtensionNameData";
            this.gpexLblExtensionNameData.Size = new System.Drawing.Size(10, 13);
            this.gpexLblExtensionNameData.TabIndex = 2;
            this.gpexLblExtensionNameData.Text = "-";
            // 
            // gpexLblExtensionNative
            // 
            this.gpexLblExtensionNative.AutoSize = true;
            this.gpexLblExtensionNative.Location = new System.Drawing.Point(6, 36);
            this.gpexLblExtensionNative.Name = "gpexLblExtensionNative";
            this.gpexLblExtensionNative.Size = new System.Drawing.Size(35, 13);
            this.gpexLblExtensionNative.TabIndex = 1;
            this.gpexLblExtensionNative.Text = "Nativ:";
            // 
            // gpexCheckReadRecursive
            // 
            this.gpexCheckReadRecursive.AutoSize = true;
            this.gpexCheckReadRecursive.Checked = true;
            this.gpexCheckReadRecursive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gpexCheckReadRecursive.Location = new System.Drawing.Point(6, 25);
            this.gpexCheckReadRecursive.Name = "gpexCheckReadRecursive";
            this.gpexCheckReadRecursive.Size = new System.Drawing.Size(120, 17);
            this.gpexCheckReadRecursive.TabIndex = 12;
            this.gpexCheckReadRecursive.Text = "rekursives Auslesen";
            this.gpexCheckReadRecursive.UseVisualStyleBackColor = true;
            // 
            // gpexCheckOnlyPHPFiles
            // 
            this.gpexCheckOnlyPHPFiles.AutoSize = true;
            this.gpexCheckOnlyPHPFiles.Checked = true;
            this.gpexCheckOnlyPHPFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gpexCheckOnlyPHPFiles.Location = new System.Drawing.Point(6, 55);
            this.gpexCheckOnlyPHPFiles.Name = "gpexCheckOnlyPHPFiles";
            this.gpexCheckOnlyPHPFiles.Size = new System.Drawing.Size(108, 17);
            this.gpexCheckOnlyPHPFiles.TabIndex = 13;
            this.gpexCheckOnlyPHPFiles.Text = "Nur PHP-Dateien";
            this.gpexCheckOnlyPHPFiles.UseVisualStyleBackColor = true;
            // 
            // gpexLblDescription
            // 
            this.gpexLblDescription.AutoSize = true;
            this.gpexLblDescription.ForeColor = System.Drawing.SystemColors.GrayText;
            this.gpexLblDescription.Location = new System.Drawing.Point(9, 441);
            this.gpexLblDescription.Name = "gpexLblDescription";
            this.gpexLblDescription.Size = new System.Drawing.Size(160, 13);
            this.gpexLblDescription.TabIndex = 14;
            this.gpexLblDescription.Text = "Get neccessary PHP Extensions";
            // 
            // gpexGrpSettings
            // 
            this.gpexGrpSettings.Controls.Add(this.gpexCheckRunInBackground);
            this.gpexGrpSettings.Controls.Add(this.gpexCheckReadRecursive);
            this.gpexGrpSettings.Location = new System.Drawing.Point(12, 178);
            this.gpexGrpSettings.Name = "gpexGrpSettings";
            this.gpexGrpSettings.Size = new System.Drawing.Size(157, 80);
            this.gpexGrpSettings.TabIndex = 15;
            this.gpexGrpSettings.TabStop = false;
            this.gpexGrpSettings.Text = "Einstellungen";
            // 
            // gpexCheckRunInBackground
            // 
            this.gpexCheckRunInBackground.AutoSize = true;
            this.gpexCheckRunInBackground.Location = new System.Drawing.Point(6, 48);
            this.gpexCheckRunInBackground.Name = "gpexCheckRunInBackground";
            this.gpexCheckRunInBackground.Size = new System.Drawing.Size(145, 17);
            this.gpexCheckRunInBackground.TabIndex = 14;
            this.gpexCheckRunInBackground.Text = "Im Hintergrund ausführen";
            this.gpexCheckRunInBackground.UseVisualStyleBackColor = true;
            // 
            // gpexCheckIgnoreMeta
            // 
            this.gpexCheckIgnoreMeta.AutoSize = true;
            this.gpexCheckIgnoreMeta.Checked = true;
            this.gpexCheckIgnoreMeta.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gpexCheckIgnoreMeta.Location = new System.Drawing.Point(6, 19);
            this.gpexCheckIgnoreMeta.Name = "gpexCheckIgnoreMeta";
            this.gpexCheckIgnoreMeta.Size = new System.Drawing.Size(156, 30);
            this.gpexCheckIgnoreMeta.TabIndex = 15;
            this.gpexCheckIgnoreMeta.Text = "Meta-Elemente ( bsp.: \'.git\' )\r\nignorieren";
            this.gpexCheckIgnoreMeta.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.gpexCheckIgnoreMeta.UseVisualStyleBackColor = true;
            // 
            // gpexTrayContext
            // 
            this.gpexTrayContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öffnenToolStripMenuItem,
            this.toolStripSeparator1,
            this.beendenToolStripMenuItem});
            this.gpexTrayContext.Name = "gpexTrayContext";
            this.gpexTrayContext.Size = new System.Drawing.Size(121, 54);
            // 
            // öffnenToolStripMenuItem
            // 
            this.öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            this.öffnenToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.öffnenToolStripMenuItem.Text = "Öffnen";
            this.öffnenToolStripMenuItem.Click += new System.EventHandler(this.öffnenToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(117, 6);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // gpexGrpFilter
            // 
            this.gpexGrpFilter.Controls.Add(this.gpexCheckIgnoreMeta);
            this.gpexGrpFilter.Controls.Add(this.gpexCheckOnlyPHPFiles);
            this.gpexGrpFilter.Location = new System.Drawing.Point(175, 178);
            this.gpexGrpFilter.Name = "gpexGrpFilter";
            this.gpexGrpFilter.Size = new System.Drawing.Size(190, 80);
            this.gpexGrpFilter.TabIndex = 16;
            this.gpexGrpFilter.TabStop = false;
            this.gpexGrpFilter.Text = "Filter";
            // 
            // gpexColExtensionName
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gpexColExtensionName.DefaultCellStyle = dataGridViewCellStyle2;
            this.gpexColExtensionName.Frozen = true;
            this.gpexColExtensionName.HeaderText = "Name";
            this.gpexColExtensionName.Name = "gpexColExtensionName";
            this.gpexColExtensionName.ReadOnly = true;
            this.gpexColExtensionName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gpexColExtensionName.Width = 170;
            // 
            // gpexColExtensionNative
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gpexColExtensionNative.DefaultCellStyle = dataGridViewCellStyle3;
            this.gpexColExtensionNative.Frozen = true;
            this.gpexColExtensionNative.HeaderText = "Native";
            this.gpexColExtensionNative.Name = "gpexColExtensionNative";
            this.gpexColExtensionNative.ReadOnly = true;
            this.gpexColExtensionNative.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gpexColExtensionNative.Width = 140;
            // 
            // gpexColExtensionPHPNetLink
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gpexColExtensionPHPNetLink.DefaultCellStyle = dataGridViewCellStyle4;
            this.gpexColExtensionPHPNetLink.Frozen = true;
            this.gpexColExtensionPHPNetLink.HeaderText = "Manual";
            this.gpexColExtensionPHPNetLink.Name = "gpexColExtensionPHPNetLink";
            this.gpexColExtensionPHPNetLink.ReadOnly = true;
            this.gpexColExtensionPHPNetLink.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gpexColExtensionPHPNetLink.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.gpexColExtensionPHPNetLink.Text = "[Link]";
            this.gpexColExtensionPHPNetLink.Width = 276;
            // 
            // gpexBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1023, 462);
            this.Controls.Add(this.gpexGrpFilter);
            this.Controls.Add(this.gpexBtnRun);
            this.Controls.Add(this.gpexBtnClearData);
            this.Controls.Add(this.gpexGrpSettings);
            this.Controls.Add(this.gpexLblDescription);
            this.Controls.Add(this.gpexGrpExtensionData);
            this.Controls.Add(this.gpexLblCopyright);
            this.Controls.Add(this.gpexGrpExtensionList);
            this.Controls.Add(this.gpexGrpLog);
            this.Controls.Add(this.gpexGrpProjectData);
            this.Controls.Add(this.gpexBtnBrowseComponentFile);
            this.Controls.Add(this.gpexBtnBrowsePHPPath);
            this.Controls.Add(this.gpexLblPHPPath);
            this.Controls.Add(this.gpexLblComponentFile);
            this.Controls.Add(this.gpexTxtPHPPath);
            this.Controls.Add(this.gpexTxtComponentPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "gpexBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "symbla GPEX";
            this.Load += new System.EventHandler(this.gpexBase_Load);
            this.gpexGrpProjectData.ResumeLayout(false);
            this.gpexGrpProjectData.PerformLayout();
            this.gpexGrpLog.ResumeLayout(false);
            this.gpexGrpLog.PerformLayout();
            this.gpexGrpExtensionList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gpexGridExtensions)).EndInit();
            this.gpexGrpExtensionData.ResumeLayout(false);
            this.gpexGrpExtensionData.PerformLayout();
            this.gpexGrpSettings.ResumeLayout(false);
            this.gpexGrpSettings.PerformLayout();
            this.gpexTrayContext.ResumeLayout(false);
            this.gpexGrpFilter.ResumeLayout(false);
            this.gpexGrpFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gpexLblComponentFile;
        private System.Windows.Forms.TextBox gpexTxtPHPPath;
        private System.Windows.Forms.Label gpexLblPHPPath;
        private System.Windows.Forms.Button gpexBtnBrowsePHPPath;
        private System.Windows.Forms.Button gpexBtnBrowseComponentFile;
        private System.Windows.Forms.TextBox gpexTxtComponentPath;
        private System.Windows.Forms.GroupBox gpexGrpProjectData;
        private System.Windows.Forms.GroupBox gpexGrpLog;
        private System.Windows.Forms.GroupBox gpexGrpExtensionList;
        private System.Windows.Forms.TextBox gpexTxtLogOutput;
        private System.Windows.Forms.Label gpexLblCopyright;
        private System.Windows.Forms.Button gpexBtnRun;
        private System.Windows.Forms.Button gpexBtnClearData;
        private System.Windows.Forms.Label gpexLblProjectDirsCounter;
        private System.Windows.Forms.Label gpexLblProjectFilesCounter;
        private System.Windows.Forms.Label gpexLblProjectDirs;
        private System.Windows.Forms.Label gpexLblProjectFiles;
        private System.Windows.Forms.GroupBox gpexGrpExtensionData;
        private System.Windows.Forms.Label gpexLblProjectSizeCounter;
        private System.Windows.Forms.Label gpexLblProjectSize;
        private System.Windows.Forms.Label gpexLblExtensionLink;
        private System.Windows.Forms.Label gpexLblExtensionName;
        private System.Windows.Forms.Label gpexLblExtensionNative;
        private System.Windows.Forms.Label gpexLblExtensionNativeData;
        private System.Windows.Forms.Label gpexLblExtensionNameData;
        private System.Windows.Forms.LinkLabel gpexLinkExtensionOnline;
        private System.Windows.Forms.LinkLabel gpexLinkClearLog;
        private System.Windows.Forms.LinkLabel gpexLinkExportLog;
        private System.Windows.Forms.CheckBox gpexCheckReadRecursive;
        private System.Windows.Forms.CheckBox gpexCheckOnlyPHPFiles;
        private System.Windows.Forms.Label gpexLblDescription;
        private System.Windows.Forms.GroupBox gpexGrpSettings;
        private System.Windows.Forms.CheckBox gpexCheckRunInBackground;
        private System.Windows.Forms.CheckBox gpexCheckIgnoreMeta;
        private System.Windows.Forms.ContextMenuStrip gpexTrayContext;
        private System.Windows.Forms.ToolStripMenuItem öffnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox gpexGrpFilter;
        private System.Windows.Forms.DataGridView gpexGridExtensions;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpexColExtensionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpexColExtensionNative;
        private System.Windows.Forms.DataGridViewLinkColumn gpexColExtensionPHPNetLink;

    }
}

