using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanityArchiver
{
    public partial class ExploreProperties : Form
    {
        private string location = "";
        private string size = "";
        private string fileOrDirectoryName = "";



        public ExploreProperties(string _fileOrDirectoryName, string _location, string _size)
        {
            InitializeComponent();
            location = _location;
            size = _size;
            fileOrDirectoryName = _fileOrDirectoryName;
        }

        private void ExploreProperties_Load(object sender, EventArgs e)
        {
            this.Text = fileOrDirectoryName + " Properties";
            textBoxFileName.Text = fileOrDirectoryName;
            textBoxPath.Text = location;
            toolTip.SetToolTip(textBoxPath, location);
            labelAllSize.Text = size;
        }


        private void buttonOk_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

        
    }
}
