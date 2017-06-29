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
using System.Collections.Specialized;

namespace SanityArchiver
{
    public partial class Form1 : Form
    {
        public string currentDirectory;
        public string sourcePath;
        public string file;

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

        public void rootDirectory(DirectoryInfo drinfo)
        {

            treeView.Nodes.Clear();
            try
            {

                foreach (DirectoryInfo dirInfo in drinfo.GetDirectories())
                {

                    TreeNode node = new TreeNode();
                    node.Text = dirInfo.Name;
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
                        treeView.Nodes.Add(node.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void textPath_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentDirectory = textPath.SelectedItem.ToString();
            path.Text = currentDirectory;
            treeView.Nodes.Clear();


            DriveInfo drive = (DriveInfo)textPath.SelectedItem;
            rootDirectory(drive.RootDirectory);



        }
        private void treeView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            currentDirectory = currentDirectory + treeView.SelectedNode.Text + "\\";
            path.Text = currentDirectory;

            DirectoryInfo drinfo = new DirectoryInfo(currentDirectory);
            rootDirectory(drinfo);






        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //Console.WriteLine(e.Node.Text);
        }

        private void toolStripMenuItemCopy_Click(object sender, EventArgs e)
        {
            sourcePath = currentDirectory;
            file = treeView.SelectedNode.Text;

            //try
            //{
            //    if (treeView.SelectedNode != null)
            //    {
            //        DirectoryInfo drinfo = new DirectoryInfo(sourcePath);
            //        DirectoryInfo[] directories = drinfo.GetDirectories();

            //        foreach (FileInfo file in drinfo.GetFiles())
            //        {
            //            if (file.Exists && file.Name == treeView.SelectedNode.Text)
            //            {
            //                StringCollection filePath = new StringCollection();
            //                filePath.Add(file.FullName);
            //                Clipboard.SetFileDropList(filePath);
            //            }
            //        }
            //        if (drinfo.GetDirectories().Length > 0)
            //        {
            //            foreach (DirectoryInfo directory in directories)
            //            {
            //                if (directory.Name == treeView.SelectedNode.Text)
            //                {
            //                    StringCollection folderPath = new StringCollection();
            //                    folderPath.Add(directory.FullName);
            //                    Clipboard.SetFileDropList(folderPath);
            //                }
            //                foreach (FileInfo file in directory.GetFiles())
            //                {
            //                    if (file.Exists && file.Name == treeView.SelectedNode.Text)
            //                    {
            //                        StringCollection filePath = new StringCollection();
            //                        filePath.Add(directory.FullName);
            //                        Clipboard.SetFileDropList(filePath);
            //                    }
            //                }
            //            }

            //        }

                //}
           // }



            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }


        private void toolStripMenuItemPaste_Click(object sender, EventArgs e)
        {
            //    if (treeView.SelectedNode != null)
            //    {
            //        bool copy = false;
            //        try
            //        {
            //            DirectoryInfo drinfo = new DirectoryInfo(currentDirectory);
            //            DirectoryInfo[] directories = drinfo.GetDirectories();
            //            if(directories.Length > 0)
            //            {
            //                foreach (DirectoryInfo directory in directories)
            //                {
            //                    if (directory.Name == treeView.SelectedNode.Text && Clipboard.ContainsFileDropList())
            //                    {
            //                        foreach (string file in Clipboard.GetFileDropList())
            //                        {
            //                            string targetDir = drinfo.FullName + @"\" + directory.Name;
            //                            File.Copy(Path.Combine(file.Replace(Path.GetFileName(file), ""), Path.GetFileName(file)), Path.Combine(targetDir, Path.GetFileName(file)), true);
            //                        }
            //                        copy = true;
            //                    }
            //                }
            //            }
            //            if(copy)
            //            {
            //                foreach(string file in Clipboard.GetFileDropList())
            //                {
            //                    TreeNode node = treeView.Nodes[0].Nodes[treeView.SelectedNode.Index].Nodes.Add(Path.GetFileName(file));
            //                    node.ImageIndex = node.SelectedImageIndex = 1;
            //                }
            //                copy = false;
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            copy = false;
            //            MessageBox.Show(ex.Message);

            //    }
            //    }
            //}

            string sourceFile = sourcePath + file;
            string targetDirectory = currentDirectory + file;
            System.IO.File.Copy(sourceFile, targetDirectory, true);
            DirectoryInfo drinfo = new DirectoryInfo(currentDirectory);
            rootDirectory(drinfo);
        }



        private void toolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode != null)
            {
                bool deleted = false;
                try
                {
                    DirectoryInfo drinfo = new DirectoryInfo(currentDirectory);
                    DirectoryInfo[] directories = drinfo.GetDirectories();
                    foreach (FileInfo file in drinfo.GetFiles())
                    {
                        if (file.Exists && file.Name == treeView.SelectedNode.Text)
                        {
                            file.Delete();
                            deleted = true;
                        }
                    }
                    if (directories.Length > 0)
                    {
                        foreach (DirectoryInfo directory in directories)
                        {
                            foreach (FileInfo file in drinfo.GetFiles())
                            {
                                if (file.Exists && file.Name == treeView.SelectedNode.Text)
                                {
                                    file.Delete();
                                    deleted = true;
                                }
                            }
                            if (treeView.SelectedNode.Text == directory.Name)
                            {
                                foreach (FileInfo file in directory.GetFiles())
                                {
                                    if (file.Exists)
                                        file.Delete();
                                }
                                directory.Delete();
                                deleted = true;
                            }
                        }
                    }
                
                if (deleted)
                    treeView.SelectedNode.Remove();
            }
                catch (Exception ex)
                {
                    deleted = false;
                    MessageBox.Show(ex.Message);
                }
            }
           
        }
        private void toolStripMenuItemProperties_Click(object sender, EventArgs e)
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
                rootDirectory(drinfo);
            }

        }

        
    }
}
        
    

