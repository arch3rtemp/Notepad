using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class aboutForm : Form
    {        
        public aboutForm()
        {
            InitializeComponent();
            Version ver = new Version(Application.ProductVersion);
            string about = $"Notepad {ver.Major}.{ver.Minor}a (x64)\n2020-06-31\nCopyright (c) 2020 Archil Asanishvili\nNotepad is free software";
            lblAbout.Text = about;
        }
    }
}
