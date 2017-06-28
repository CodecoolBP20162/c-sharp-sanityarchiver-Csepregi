using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace SanityArchiver
{
    public partial class Form1 : Form
    {
        public string currentDirectory;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            foreach (DriveInfo di in DriveInfo.GetDrives())
            {
                textPath.Items.Add(di);
            }
        }

                  

        private void textPath_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentDirectory = textPath.SelectedItem.ToString();
            path.Text = currentDirectory;
            treeView.Nodes.Clear();
            try
            {
                DriveInfo drive = (DriveInfo)textPath.SelectedItem;
                foreach (DirectoryInfo dirInfo in drive.RootDirectory.GetDirectories())
                {
           
                    TreeNode node = new TreeNode();
                    node.Text = dirInfo.Name;
                    node.ImageIndex = 1;
                    node.SelectedImageIndex = 1;
                    treeView.Nodes.Add(node);                
                }


                foreach (FileInfo file in drive.RootDirectory.GetFiles())
                {
                    if (file.Exists)
                    {
                        TreeNode node = new TreeNode();
                        node.Text = file.Name;
                        node.ImageIndex = 0;
                        node.SelectedImageIndex = 0;
                        treeView.Nodes.Add(node.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void treeView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            currentDirectory = currentDirectory +  treeView.SelectedNode.Text + "\\";
            path.Text = currentDirectory;
            try
            {
                DirectoryInfo drinfo = new DirectoryInfo(currentDirectory);
                treeView.Nodes.Clear();
                foreach (DirectoryInfo dr in drinfo.GetDirectories())
                {
                    Console.WriteLine(dr.Name);
                    TreeNode node = new TreeNode();
                    node.Text = dr.Name;
                    node.ImageIndex = 1;
                    node.SelectedImageIndex = 1;
                    treeView.Nodes.Add(node);
                }

                foreach (FileInfo file in drinfo.GetFiles())
                {
                    if (file.Exists)
                    {
                        TreeNode node = new TreeNode();
                        node.Text = file.Name;
                        node.ImageIndex = 0;
                        node.SelectedImageIndex = 0;
                        treeView.Nodes.Add(node);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //Console.WriteLine(e.Node.Text);
        }

        private void toolStripMenuItemCopy_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void toolStripMenuItemPaste_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemDelete_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo drinfo = new DirectoryInfo(textPath.Text);
            int index = 0;
            int occurance = 0;
            for (int i = currentDirectory.Length-1; i > 0; i--)
            {
                if(currentDirectory[i] == '\\')
                {
                    occurance++;
                }
                if(occurance == 2)
                {
                    index = i;
                    break;
                }
            }
            
            if(drinfo != null)
            {
                currentDirectory = currentDirectory.Substring(0, index + 1);
                path.Text = currentDirectory;

                try
                {
                    
                    treeView.Nodes.Clear();
                    foreach (DirectoryInfo dr in drinfo.GetDirectories())
                    {
                        Console.WriteLine(dr.Name);
                        TreeNode node = new TreeNode();
                        node.Text = dr.Name;
                        node.ImageIndex = 1;
                        node.SelectedImageIndex = 1;
                        treeView.Nodes.Add(node);
                    }

                    foreach (FileInfo file in drinfo.GetFiles())
                    {
                        if (file.Exists)
                        {
                            TreeNode node = new TreeNode();
                            node.Text = file.Name;
                            node.ImageIndex = 0;
                            node.SelectedImageIndex = 0;
                            treeView.Nodes.Add(node);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
        
    

