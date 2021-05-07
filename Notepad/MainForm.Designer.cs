namespace Notepad
{
    partial class MainForm
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
            this.menuSB = new System.Windows.Forms.MenuStrip();
            this.fileMI = new System.Windows.Forms.ToolStripMenuItem();
            this.newMI = new System.Windows.Forms.ToolStripMenuItem();
            this.openMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveMI = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMI = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMI = new System.Windows.Forms.ToolStripMenuItem();
            this.editMI = new System.Windows.Forms.ToolStripMenuItem();
            this.cutMI = new System.Windows.Forms.ToolStripMenuItem();
            this.copyMI = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.selectMI = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMI = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMI = new System.Windows.Forms.ToolStripMenuItem();
            this.fontMI = new System.Windows.Forms.ToolStripMenuItem();
            this.fontColorMI = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.undoMI = new System.Windows.Forms.ToolStripMenuItem();
            this.redoMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.languageMI = new System.Windows.Forms.ToolStripMenuItem();
            this.languageCB = new System.Windows.Forms.ToolStripComboBox();
            this.aboutMI = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAuthorMI = new System.Windows.Forms.ToolStripMenuItem();
            this.contactMI = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuSB = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mainTS = new System.Windows.Forms.ToolStrip();
            this.newTS = new System.Windows.Forms.ToolStripButton();
            this.openTS = new System.Windows.Forms.ToolStripButton();
            this.saveTS = new System.Windows.Forms.ToolStripButton();
            this.saveAsTS = new System.Windows.Forms.ToolStripButton();
            this.toolTS = new System.Windows.Forms.ToolStrip();
            this.fontTS = new System.Windows.Forms.ToolStripButton();
            this.foreColorTS = new System.Windows.Forms.ToolStripButton();
            this.backColorTS = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.undoTS = new System.Windows.Forms.ToolStripButton();
            this.redoTS = new System.Windows.Forms.ToolStripButton();
            this.mainBox = new System.Windows.Forms.RichTextBox();
            this.mainStrip = new System.Windows.Forms.StatusStrip();
            this.wordsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.linesStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuSB.SuspendLayout();
            this.mainTS.SuspendLayout();
            this.toolTS.SuspendLayout();
            this.mainStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuSB
            // 
            this.menuSB.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMI,
            this.editMI,
            this.viewMI,
            this.toolsMI,
            this.languageMI,
            this.aboutMI});
            this.menuSB.Location = new System.Drawing.Point(0, 0);
            this.menuSB.Name = "menuSB";
            this.menuSB.Size = new System.Drawing.Size(800, 24);
            this.menuSB.TabIndex = 0;
            this.menuSB.Text = "Menu";
            // 
            // fileMI
            // 
            this.fileMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMI,
            this.openMI,
            this.toolStripSeparator1,
            this.saveMI,
            this.saveAsMI,
            this.exitMI});
            this.fileMI.Name = "fileMI";
            this.fileMI.Size = new System.Drawing.Size(37, 20);
            this.fileMI.Text = "File";
            // 
            // newMI
            // 
            this.newMI.Image = global::Notepad.Properties.Resources.New;
            this.newMI.Name = "newMI";
            this.newMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newMI.Size = new System.Drawing.Size(186, 22);
            this.newMI.Text = "&New";
            this.newMI.Click += new System.EventHandler(this.newMI_Click);
            // 
            // openMI
            // 
            this.openMI.Image = global::Notepad.Properties.Resources.Open;
            this.openMI.Name = "openMI";
            this.openMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openMI.Size = new System.Drawing.Size(186, 22);
            this.openMI.Text = "&Open";
            this.openMI.Click += new System.EventHandler(this.openMI_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // saveMI
            // 
            this.saveMI.Image = global::Notepad.Properties.Resources.Save;
            this.saveMI.Name = "saveMI";
            this.saveMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMI.Size = new System.Drawing.Size(186, 22);
            this.saveMI.Text = "&Save";
            this.saveMI.Click += new System.EventHandler(this.saveMI_Click);
            // 
            // saveAsMI
            // 
            this.saveAsMI.Image = global::Notepad.Properties.Resources.SaveAs;
            this.saveAsMI.Name = "saveAsMI";
            this.saveAsMI.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsMI.Size = new System.Drawing.Size(186, 22);
            this.saveAsMI.Text = "Save As";
            this.saveAsMI.Click += new System.EventHandler(this.saveAsMI_Click);
            // 
            // exitMI
            // 
            this.exitMI.Name = "exitMI";
            this.exitMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitMI.Size = new System.Drawing.Size(186, 22);
            this.exitMI.Text = "Exit";
            this.exitMI.Click += new System.EventHandler(this.exitMI_Click);
            // 
            // editMI
            // 
            this.editMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutMI,
            this.copyMI,
            this.pasteMI,
            this.toolStripSeparator5,
            this.selectMI});
            this.editMI.Name = "editMI";
            this.editMI.Size = new System.Drawing.Size(39, 20);
            this.editMI.Text = "Edit";
            // 
            // cutMI
            // 
            this.cutMI.Name = "cutMI";
            this.cutMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutMI.Size = new System.Drawing.Size(164, 22);
            this.cutMI.Text = "Cut";
            // 
            // copyMI
            // 
            this.copyMI.Name = "copyMI";
            this.copyMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyMI.Size = new System.Drawing.Size(164, 22);
            this.copyMI.Text = "&Copy";
            // 
            // pasteMI
            // 
            this.pasteMI.Name = "pasteMI";
            this.pasteMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.pasteMI.Size = new System.Drawing.Size(164, 22);
            this.pasteMI.Text = "&Paste";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(161, 6);
            // 
            // selectMI
            // 
            this.selectMI.Name = "selectMI";
            this.selectMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectMI.Size = new System.Drawing.Size(164, 22);
            this.selectMI.Text = "Select All";
            // 
            // viewMI
            // 
            this.viewMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMI,
            this.toolMI});
            this.viewMI.Name = "viewMI";
            this.viewMI.Size = new System.Drawing.Size(44, 20);
            this.viewMI.Text = "View";
            // 
            // mainMI
            // 
            this.mainMI.Checked = true;
            this.mainMI.CheckOnClick = true;
            this.mainMI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mainMI.Name = "mainMI";
            this.mainMI.Size = new System.Drawing.Size(135, 22);
            this.mainMI.Text = "Main Menu";
            this.mainMI.Click += new System.EventHandler(this.mainMI_Click);
            // 
            // toolMI
            // 
            this.toolMI.Checked = true;
            this.toolMI.CheckOnClick = true;
            this.toolMI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolMI.Name = "toolMI";
            this.toolMI.Size = new System.Drawing.Size(135, 22);
            this.toolMI.Text = "Tool Menu";
            this.toolMI.Click += new System.EventHandler(this.toolMI_Click);
            // 
            // toolsMI
            // 
            this.toolsMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontMI,
            this.fontColorMI,
            this.backgroundColorMI,
            this.toolStripSeparator4,
            this.undoMI,
            this.redoMI,
            this.toolStripSeparator3});
            this.toolsMI.Name = "toolsMI";
            this.toolsMI.Size = new System.Drawing.Size(46, 20);
            this.toolsMI.Text = "Tools";
            // 
            // fontMI
            // 
            this.fontMI.Image = global::Notepad.Properties.Resources.Font;
            this.fontMI.Name = "fontMI";
            this.fontMI.Size = new System.Drawing.Size(174, 22);
            this.fontMI.Text = "&Font";
            this.fontMI.Click += new System.EventHandler(this.fontMI_Click);
            // 
            // fontColorMI
            // 
            this.fontColorMI.Name = "fontColorMI";
            this.fontColorMI.Size = new System.Drawing.Size(174, 22);
            this.fontColorMI.Text = "Font Color";
            this.fontColorMI.Click += new System.EventHandler(this.fontColorMI_Click);
            // 
            // backgroundColorMI
            // 
            this.backgroundColorMI.Name = "backgroundColorMI";
            this.backgroundColorMI.Size = new System.Drawing.Size(174, 22);
            this.backgroundColorMI.Text = "Background Color";
            this.backgroundColorMI.Click += new System.EventHandler(this.backgroundColorMI_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(171, 6);
            // 
            // undoMI
            // 
            this.undoMI.Name = "undoMI";
            this.undoMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoMI.Size = new System.Drawing.Size(174, 22);
            this.undoMI.Text = "Undo";
            this.undoMI.Click += new System.EventHandler(this.undoMI_Click);
            // 
            // redoMI
            // 
            this.redoMI.Name = "redoMI";
            this.redoMI.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.redoMI.Size = new System.Drawing.Size(174, 22);
            this.redoMI.Text = "Redo";
            this.redoMI.Click += new System.EventHandler(this.redoMI_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(171, 6);
            // 
            // languageMI
            // 
            this.languageMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageCB});
            this.languageMI.Name = "languageMI";
            this.languageMI.Size = new System.Drawing.Size(71, 20);
            this.languageMI.Text = "Language";
            // 
            // languageCB
            // 
            this.languageCB.Name = "languageCB";
            this.languageCB.Size = new System.Drawing.Size(121, 23);
            this.languageCB.Text = "English";
            this.languageCB.SelectedIndexChanged += new System.EventHandler(this.languageCB_SelectedIndexChanged);
            // 
            // aboutMI
            // 
            this.aboutMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutAuthorMI,
            this.contactMI});
            this.aboutMI.Name = "aboutMI";
            this.aboutMI.Size = new System.Drawing.Size(52, 20);
            this.aboutMI.Text = "About";
            // 
            // aboutAuthorMI
            // 
            this.aboutAuthorMI.Name = "aboutAuthorMI";
            this.aboutAuthorMI.Size = new System.Drawing.Size(116, 22);
            this.aboutAuthorMI.Text = "About";
            this.aboutAuthorMI.Click += new System.EventHandler(this.aboutAuthorMI_Click);
            // 
            // contactMI
            // 
            this.contactMI.Name = "contactMI";
            this.contactMI.Size = new System.Drawing.Size(116, 22);
            this.contactMI.Text = "Contact";
            this.contactMI.Click += new System.EventHandler(this.contactMI_Click);
            // 
            // contextMenuSB
            // 
            this.contextMenuSB.Name = "contextMenuSB";
            this.contextMenuSB.Size = new System.Drawing.Size(61, 4);
            // 
            // mainTS
            // 
            this.mainTS.Dock = System.Windows.Forms.DockStyle.None;
            this.mainTS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTS,
            this.openTS,
            this.saveTS,
            this.saveAsTS});
            this.mainTS.Location = new System.Drawing.Point(0, 24);
            this.mainTS.Name = "mainTS";
            this.mainTS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainTS.Size = new System.Drawing.Size(104, 25);
            this.mainTS.TabIndex = 2;
            this.mainTS.Text = "Main";
            // 
            // newTS
            // 
            this.newTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newTS.Image = global::Notepad.Properties.Resources.New;
            this.newTS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newTS.Name = "newTS";
            this.newTS.Size = new System.Drawing.Size(23, 22);
            this.newTS.Text = "New";
            // 
            // openTS
            // 
            this.openTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openTS.Image = global::Notepad.Properties.Resources.Open;
            this.openTS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openTS.Name = "openTS";
            this.openTS.Size = new System.Drawing.Size(23, 22);
            this.openTS.Text = "Open";
            // 
            // saveTS
            // 
            this.saveTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveTS.Image = global::Notepad.Properties.Resources.Save;
            this.saveTS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveTS.Name = "saveTS";
            this.saveTS.Size = new System.Drawing.Size(23, 22);
            this.saveTS.Text = "Save";
            // 
            // saveAsTS
            // 
            this.saveAsTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveAsTS.Image = global::Notepad.Properties.Resources.SaveAs;
            this.saveAsTS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveAsTS.Name = "saveAsTS";
            this.saveAsTS.Size = new System.Drawing.Size(23, 22);
            this.saveAsTS.Text = "Save As";
            // 
            // toolTS
            // 
            this.toolTS.Dock = System.Windows.Forms.DockStyle.None;
            this.toolTS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontTS,
            this.foreColorTS,
            this.backColorTS,
            this.toolStripSeparator2,
            this.undoTS,
            this.redoTS});
            this.toolTS.Location = new System.Drawing.Point(113, 24);
            this.toolTS.Name = "toolTS";
            this.toolTS.Size = new System.Drawing.Size(133, 25);
            this.toolTS.TabIndex = 3;
            this.toolTS.Text = "Secondary";
            // 
            // fontTS
            // 
            this.fontTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fontTS.Image = global::Notepad.Properties.Resources.Font;
            this.fontTS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fontTS.Name = "fontTS";
            this.fontTS.Size = new System.Drawing.Size(23, 22);
            this.fontTS.Text = "Font";
            // 
            // foreColorTS
            // 
            this.foreColorTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.foreColorTS.Image = global::Notepad.Properties.Resources.ForeColor;
            this.foreColorTS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.foreColorTS.Name = "foreColorTS";
            this.foreColorTS.Size = new System.Drawing.Size(23, 22);
            this.foreColorTS.Text = "Font Color";
            // 
            // backColorTS
            // 
            this.backColorTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backColorTS.Image = global::Notepad.Properties.Resources.ColorBackground;
            this.backColorTS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backColorTS.Name = "backColorTS";
            this.backColorTS.Size = new System.Drawing.Size(23, 22);
            this.backColorTS.Text = "Background Color";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // undoTS
            // 
            this.undoTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.undoTS.Image = global::Notepad.Properties.Resources.Undo;
            this.undoTS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undoTS.Name = "undoTS";
            this.undoTS.Size = new System.Drawing.Size(23, 22);
            this.undoTS.Text = "Undo";
            // 
            // redoTS
            // 
            this.redoTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.redoTS.Image = global::Notepad.Properties.Resources.Redo;
            this.redoTS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redoTS.Name = "redoTS";
            this.redoTS.Size = new System.Drawing.Size(23, 22);
            this.redoTS.Text = "Redo";
            // 
            // mainBox
            // 
            this.mainBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainBox.Location = new System.Drawing.Point(0, 53);
            this.mainBox.Name = "mainBox";
            this.mainBox.Size = new System.Drawing.Size(800, 372);
            this.mainBox.TabIndex = 4;
            this.mainBox.Text = "";
            // 
            // mainStrip
            // 
            this.mainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordsStatus,
            this.linesStatus});
            this.mainStrip.Location = new System.Drawing.Point(0, 428);
            this.mainStrip.Name = "mainStrip";
            this.mainStrip.Size = new System.Drawing.Size(800, 22);
            this.mainStrip.TabIndex = 6;
            this.mainStrip.Text = "statusStrip1";
            // 
            // wordsStatus
            // 
            this.wordsStatus.Name = "wordsStatus";
            this.wordsStatus.Size = new System.Drawing.Size(44, 17);
            this.wordsStatus.Text = "Words:";
            // 
            // linesStatus
            // 
            this.linesStatus.Name = "linesStatus";
            this.linesStatus.Size = new System.Drawing.Size(37, 17);
            this.linesStatus.Text = "Lines:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainStrip);
            this.Controls.Add(this.mainBox);
            this.Controls.Add(this.toolTS);
            this.Controls.Add(this.mainTS);
            this.Controls.Add(this.menuSB);
            this.MainMenuStrip = this.menuSB;
            this.Name = "MainForm";
            this.Text = "Notepad";
            this.menuSB.ResumeLayout(false);
            this.menuSB.PerformLayout();
            this.mainTS.ResumeLayout(false);
            this.mainTS.PerformLayout();
            this.toolTS.ResumeLayout(false);
            this.toolTS.PerformLayout();
            this.mainStrip.ResumeLayout(false);
            this.mainStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuSB;
        private System.Windows.Forms.ContextMenuStrip contextMenuSB;
        private System.Windows.Forms.ToolStripMenuItem fileMI;
        private System.Windows.Forms.ToolStripMenuItem newMI;
        private System.Windows.Forms.ToolStripMenuItem openMI;
        private System.Windows.Forms.ToolStripMenuItem saveMI;
        private System.Windows.Forms.ToolStripMenuItem saveAsMI;
        private System.Windows.Forms.ToolStripMenuItem editMI;
        private System.Windows.Forms.ToolStripMenuItem copyMI;
        private System.Windows.Forms.ToolStripMenuItem pasteMI;
        private System.Windows.Forms.ToolStripMenuItem viewMI;
        private System.Windows.Forms.ToolStripMenuItem toolsMI;
        private System.Windows.Forms.ToolStrip mainTS;
        private System.Windows.Forms.ToolStripButton newTS;
        private System.Windows.Forms.ToolStripButton openTS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fontMI;
        private System.Windows.Forms.ToolStripButton saveTS;
        private System.Windows.Forms.ToolStripButton saveAsTS;
        private System.Windows.Forms.ToolStrip toolTS;
        private System.Windows.Forms.ToolStripButton fontTS;
        private System.Windows.Forms.ToolStripButton foreColorTS;
        private System.Windows.Forms.ToolStripMenuItem mainMI;
        private System.Windows.Forms.ToolStripMenuItem toolMI;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton undoTS;
        private System.Windows.Forms.ToolStripButton redoTS;
        private System.Windows.Forms.ToolStripMenuItem fontColorMI;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorMI;
        private System.Windows.Forms.ToolStripMenuItem undoMI;
        private System.Windows.Forms.ToolStripMenuItem redoMI;
        private System.Windows.Forms.ToolStripMenuItem aboutMI;
        private System.Windows.Forms.ToolStripMenuItem aboutAuthorMI;
        private System.Windows.Forms.ToolStripMenuItem contactMI;
        private System.Windows.Forms.RichTextBox mainBox;
        private System.Windows.Forms.StatusStrip mainStrip;
        private System.Windows.Forms.ToolStripStatusLabel wordsStatus;
        private System.Windows.Forms.ToolStripStatusLabel linesStatus;
        private System.Windows.Forms.ToolStripButton backColorTS;
        private System.Windows.Forms.ToolStripMenuItem exitMI;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem languageMI;
        private System.Windows.Forms.ToolStripComboBox languageCB;
        private System.Windows.Forms.ToolStripMenuItem cutMI;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem selectMI;
    }
}

