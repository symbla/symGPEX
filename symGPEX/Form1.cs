using System;
using System.IO;
using System.Xml;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;

namespace symGPEX
{
    public partial class gpexBase : Form
    {
        public gpexBase()
        {
            InitializeComponent();
        }

        public void gpexBase_Load(object sender, EventArgs e)
        {
            gpexTxtComponentPath.Text = @".\components\gpexComponentList.xml";

            // Tray Icon + Kontext
            NotifyIcon gpexBgRunIcon = new NotifyIcon();
            gpexBgRunIcon.Icon = new Icon(@".\ico\gpexTrayIcon.ico");
            gpexBgRunIcon.Visible = true;
            gpexBgRunIcon.ContextMenuStrip = gpexTrayContext;
        }

        private void gpexBtnBrowseComponentFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog gpexLoadPHPPathFileDialog = new OpenFileDialog();
            gpexLoadPHPPathFileDialog.Title = "symGPEX: Komponenten-Datei öffnen";
            gpexLoadPHPPathFileDialog.Filter = "XML files (*.xml) | *.xml";
            if (gpexLoadPHPPathFileDialog.ShowDialog() == DialogResult.OK)
            {
                gpexTxtComponentPath.Text = gpexLoadPHPPathFileDialog.FileName;
            }
        }

        private void gpexBtnBrowsePHPPath_Click(object sender, EventArgs e)
        {
            string gpexLoadPHPPathString = string.Empty;

            FolderBrowserDialog gpexBrowsePHPPath = new FolderBrowserDialog();
            if (gpexBrowsePHPPath.ShowDialog() == DialogResult.OK)
            {
                gpexLoadPHPPathString = gpexBrowsePHPPath.SelectedPath;

                // Schreibe Projektpfad in gpexTxtPHPPath
                gpexTxtPHPPath.Text = gpexLoadPHPPathString;
            }
        }

        private void gpexBtnRun_Click(object sender, EventArgs e)
        {
            // Log (start)
            log("Starte Auslesen...");

            // Lese Projektverzeichnis aus
            gpexFxReadProjectDir(gpexTxtPHPPath.Text, true);
        }

        private void gpexFxReadProjectFile(string gpexPrFile)
        {
            log("Prüfe Datei \"" + gpexPrFile + "\"");

            string gpexTmpComponentName;
            string gpexTmpComponentKeywords;
            string gpexTmpComponentNative;
            string gpexTmpComponentPHPNetLink;
            string[] gpexTmpComponentKeywordsSplitted;
            Array[] gpexFoundComponents;
            string gpexTmpFileContent = File.ReadAllText(gpexPrFile);

            // Lese XML-Komponenten in Arrays
            StreamReader lgXmlFileStream = new StreamReader(gpexTxtComponentPath.Text);
            string gpexComponentFileContent = lgXmlFileStream.ReadToEnd();

            using (XmlReader gpexComponentReader = XmlReader.Create(new StringReader(gpexComponentFileContent)))
            {
                while (gpexComponentReader.ReadToFollowing("component"))
                {
                    // Hole Komponent Name
                    gpexComponentReader.ReadToFollowing("name");
                    gpexTmpComponentName = gpexComponentReader.ReadElementContentAsString();

                    // Hole Komponent Schlagwörter
                    gpexComponentReader.ReadToFollowing("keywords");
                    gpexTmpComponentKeywords = gpexComponentReader.ReadElementContentAsString();

                    // Hole Komponent Manual
                    gpexComponentReader.ReadToFollowing("phpnetlink");
                    gpexTmpComponentPHPNetLink = gpexComponentReader.ReadElementContentAsString();

                    // Hole Komponent Native-Information
                    gpexComponentReader.ReadToFollowing("native");
                    gpexTmpComponentNative = gpexComponentReader.ReadElementContentAsString();

                    // Write Data into Table Item
                    gpexTmpComponentKeywordsSplitted = gpexTmpComponentKeywords.Split(',');

                    for (int z = 0; z < gpexTmpComponentKeywordsSplitted.Length; z++)
                    {
                        if (gpexTmpFileContent.Contains(gpexTmpComponentKeywordsSplitted[z]))
                        {
                            gpexGridExtensions.Rows.Add(gpexTmpComponentName, gpexTmpComponentNative, gpexTmpComponentPHPNetLink);
                            log("\"" + gpexTmpComponentName + "\" (" + gpexTmpComponentKeywordsSplitted[z] +") gefunden");
                            break;
                        }
                    }
                }
            }
            lgXmlFileStream.Close();
        }

        private long gpexFxGetProjectFileSize(string gpexPrFile)
        {
            // Prüfe Dateigröße
            FileInfo gpexTmpFileInfo = new FileInfo(gpexPrFile);
            return gpexTmpFileInfo.Length;
        }

        private void gpexFxReadProjectDir(string gpexPrDir, bool gpexResetReadData)
        {
            // Prüfe Einstellungen "Im Hintergrund ausführen"
            if (gpexCheckRunInBackground.Checked == true)
            {
                this.Hide();
                gpexShowNotification("Auslesen abgeschlossen");
            }

            if (!Directory.Exists(gpexPrDir))
            {
                if (gpexPrDir == "") gpexPrDir = "leer";
                log("Projektverzeichnis existiert nicht. (" + gpexPrDir + ")");
            }
            else
            {
                // Log
                log("Öffne Ordner \"" + gpexPrDir + "\"");

                // Ordner und Dateien auslesen
                string[] gpexProjectDataDirs = Directory.GetDirectories(gpexPrDir);
                string[] gpexProjectDataFiles = Directory.GetFiles(gpexPrDir);

                // Prüfen ob neuer Run (ReadData = 0)
                if (gpexResetReadData == true)
                {
                    gpexLblProjectDirsCounter.Text = "0";
                    gpexLblProjectFilesCounter.Text = "0";
                }

                // Temporäre Variablen initialisieren
                int gpexTmpProjectDirsCounter;
                int gpexTmpProjectFilesCounter;

                // OrdnerLabelCounter, FileLabelCounter, PrSizeLabelCounter in Int convertieren
                int.TryParse(gpexLblProjectDirsCounter.Text, out gpexTmpProjectDirsCounter);
                int.TryParse(gpexLblProjectFilesCounter.Text, out gpexTmpProjectFilesCounter);

                // Gefundene Ordner und Dateien addieren
                gpexTmpProjectDirsCounter = gpexTmpProjectDirsCounter + gpexProjectDataDirs.Length;

                // Ordneranzahl in Label schreiben
                gpexLblProjectDirsCounter.Text = gpexTmpProjectDirsCounter.ToString();

                // Dateien prüfen
                for (int x = 0; x < gpexProjectDataFiles.Length; x++)
                {
                    if ((gpexCheckOnlyPHPFiles.Checked == true && gpexProjectDataFiles[x].Contains(".php")) || gpexCheckOnlyPHPFiles.Checked == false)
                    {
                        gpexFxReadProjectFile(gpexProjectDataFiles[x]);
                        gpexTmpProjectFilesCounter++;
                    }
                }

                // Temporäre Werte in Labels schreiben
                gpexLblProjectFilesCounter.Text = gpexTmpProjectFilesCounter.ToString();

                // Verzeichnis Rekursion
                if (gpexCheckReadRecursive.Checked == true)
                {
                    for (int y = 0; y < gpexProjectDataDirs.Length; y++)
                    {
                        gpexFxReadProjectDir(gpexProjectDataDirs[y], false);
                    }
                }
            }
        }

        private void gpexBtnClearData_Click(object sender, EventArgs e)
        {
            // Leere alle variablen Felder
            gpexTxtPHPPath.Clear();
            gpexLblProjectFilesCounter.Text = "-";
            gpexLblProjectDirsCounter.Text = "-";
            gpexLblProjectSizeCounter.Text = "-";
            gpexCheckReadRecursive.Checked = true;
            gpexGridExtensions.Rows.Clear();

            // Log
            log("Leere Variablen...");
        }

        private void gpexLinkExtensionOnline_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(gpexLinkExtensionOnline.Tag.ToString());

            // Log
            log("Öffne Link \"" + gpexLinkExtensionOnline.Tag.ToString() + "\"");
        }

        private void log(string logText)
        {
            DateTime gpexLogTimeStamp = DateTime.Now;
            string gpexLogOutputString = "<" + gpexLogTimeStamp + "> " + logText;
            gpexTxtLogOutput.AppendText(gpexLogOutputString + Environment.NewLine);
        }

        private void gpexLinkClearLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            gpexTxtLogOutput.Clear();
        }

        private void gpexLinkExportLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DateTime gpexLogTimeStamp = DateTime.Now;
            SaveFileDialog gpexSFDExportLog = new SaveFileDialog();
            gpexSFDExportLog.Filter = "LOG-Datei|*.log";
            gpexSFDExportLog.Title = "symGPEX: LOG-Datei exportieren";
            gpexSFDExportLog.FileName = "gpexLog_" + gpexLogTimeStamp.Kind + "-" + gpexLogTimeStamp.Day + "-" + gpexLogTimeStamp.Month + "-" + gpexLogTimeStamp.Year;
            gpexSFDExportLog.ShowDialog();

            if (gpexSFDExportLog.FileName != "")
            {
                // Log
                log("Log wird exportiert (" + gpexSFDExportLog.FileName + ")...");
                System.IO.File.WriteAllText(gpexSFDExportLog.FileName, gpexTxtLogOutput.Text);
            }
        }

        private void öffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gpexShowNotification(string gpexNotificationText)
        {
            NotifyIcon gpexBgRunNote = new NotifyIcon();
            gpexBgRunNote.BalloonTipTitle = "GPEX: Info";
            gpexBgRunNote.BalloonTipText = gpexNotificationText;
            gpexBgRunNote.BalloonTipIcon = ToolTipIcon.Info;
            gpexBgRunNote.ShowBalloonTip(30000);
        }
    }
}