using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Notepad
{    
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            languageCB.Items.Add("English");
            languageCB.Items.Add("ქართული");
            newTS.Click += (o, e) => newMI_Click(o, e);
            openTS.Click += (o, e) => openMI_Click(o, e);
            saveTS.Click += (o, e) => saveMI_Click(o, e);
            saveAsTS.Click += (o, e) => saveAsMI_Click(o, e);
            copyMI.Click += (o, e) => mainBox.Copy();
            cutMI.Click += (o, e) => mainBox.Cut();
            pasteMI.Click += (o, e) => mainBox.Paste();
            selectMI.Click += (o, e) => mainBox.SelectAll();
            fontTS.Click += (o, e) => fontMI_Click(o, e);
            foreColorTS.Click += (o, e) => fontColorMI_Click(o, e);
            backColorTS.Click += (o, e) => backgroundColorMI_Click(o, e);
            undoTS.Click += (o, e) => undoMI_Click(o, e);
            redoTS.Click += (o, e) => redoMI_Click(o, e);            
        }

        #region Menu -> File Methods  

        private void newMI_Click(object sender, EventArgs e)
        {
            var thread = new Thread(() => new MainForm().ShowDialog());
            thread.Start();
        }

        OpenFileDialog fileDialog = new OpenFileDialog();
        private void openMI_Click(object sender, EventArgs e)
        {

            fileDialog.Filter = "Text file|*.txt|Rich Text File|*.rtf|All files (*.*)|(*.*)";
            fileDialog.DefaultExt = ".txt";
            
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                mainBox.Text = File.ReadAllText(fileDialog.FileName);                
                saveDialog.FileName = fileDialog.FileName;                
            }
        }
        SaveFileDialog saveDialog = new SaveFileDialog();
        private void saveMI_Click(object sender, EventArgs e)
        {
            saveDialog.Filter = "Rich Text File|*.rtf|Text file|*.txt";
            saveDialog.DefaultExt = ".txt";
            saveDialog.Title = "Save a Text File";

            if (saveDialog.FileName != "")                
                File.WriteAllText(saveDialog.FileName, mainBox.Text);
            else
                saveAsMI_Click(this, e);
        }

        private void saveAsMI_Click(object sender, EventArgs e)
        {               
            saveDialog.Filter = "Text file|*.txt|Rich Text File|*.rtf";
            saveDialog.DefaultExt = ".txt";
            saveDialog.Title = "Save a Text File";
            if (fileDialog.FileName == "")
                saveDialog.FileName = "Untitled.txt";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveDialog.FileName, mainBox.Text);
            }
        }

        private void exitMI_Click(object sender, EventArgs e)
        {
            Close();
            //Application.Exit();            
        }


        #endregion

        #region Menu -> View Methods

        private void mainMI_Click(object sender, EventArgs e)
        {
            if (mainMI.Checked == false)
                mainTS.Visible = false;
            else
                mainTS.Visible = true;
        }

        private void toolMI_Click(object sender, EventArgs e)
        {
            if (toolMI.Checked == false)
                toolTS.Visible = false;
            else
                toolTS.Visible = true;
        }
        #endregion

        #region Menu -> Tools Methods

        private void fontMI_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();

            if (font.ShowDialog() == DialogResult.OK)
                mainBox.SelectionFont = font.Font;
        }

        private void fontColorMI_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
                mainBox.SelectionColor = color.Color;
        }

        private void backgroundColorMI_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
                mainBox.SelectionBackColor = color.Color;
        }

        private void undoMI_Click(object sender, EventArgs e)
        {
            if (mainBox.CanUndo)
                mainBox.Undo();
        }

        private void redoMI_Click(object sender, EventArgs e)
        {
            if (mainBox.CanRedo)
                mainBox.Redo();
        }

        #endregion

        #region Menu -> About Methods
        private void aboutAuthorMI_Click(object sender, EventArgs e)
        {
            var thread = new Thread(() => new aboutForm().ShowDialog());
            thread.Start();
        }

        private void contactMI_Click(object sender, EventArgs e)
        {
            var thread = new Thread(() => new contactForm().ShowDialog());
            thread.Start();
            //MessageBox.Show("Email: arch3r_temp@yahoo.com", "Contact us");
        }

        #endregion

        #region Menu -> Language Methods
        private void languageCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var chosenLanguage = languageCB.SelectedItem.ToString();
            Lang lang = Lang.EN;
            if (chosenLanguage == "English")
                lang = Lang.EN;
            else if (chosenLanguage == "ქართული")
                lang = Lang.GE;

            var locale = Language.Locale[lang];
            foreach (var item in locale)
            {
                var c = Controls.Find(item.Key, true);

                if (c.Length == 0)
                {
                    foreach (var cc in this.Controls)
                        if (cc is ToolStrip ts)
                        {
                            var c1 = menuSB.Items.Cast<ToolStripMenuItem>().FirstOrDefault(x => x.Name == item.Key);
                            if (c1 != null)
                                c1.Text = item.Value;
                        }
                }
            }
        }
        #endregion
    }
}