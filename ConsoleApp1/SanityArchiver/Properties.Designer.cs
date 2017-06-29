namespace SanityArchiver
{
    partial class ExploreProperties
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.pictureBoxImageIcon = new System.Windows.Forms.PictureBox();
            this.labelSeperator2 = new System.Windows.Forms.Label();
            this.labelSeperator = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelAllSize = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageGeneral);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(348, 272);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.textBoxPath);
            this.tabPageGeneral.Controls.Add(this.labelAllSize);
            this.tabPageGeneral.Controls.Add(this.labelSize);
            this.tabPageGeneral.Controls.Add(this.labelLocation);
            this.tabPageGeneral.Controls.Add(this.pictureBoxImageIcon);
            this.tabPageGeneral.Controls.Add(this.labelSeperator2);
            this.tabPageGeneral.Controls.Add(this.labelSeperator);
            this.tabPageGeneral.Controls.Add(this.textBoxFileName);
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneral.Size = new System.Drawing.Size(340, 246);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "General";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(8, 151);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(33, 13);
            this.labelSize.TabIndex = 7;
            this.labelSize.Text = "Size: ";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(8, 122);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(54, 13);
            this.labelLocation.TabIndex = 6;
            this.labelLocation.Text = "Location: ";
            // 
            // pictureBoxImageIcon
            // 
            this.pictureBoxImageIcon.Image = global::SanityArchiver.Properties.Resources.fileproperties;
            this.pictureBoxImageIcon.Location = new System.Drawing.Point(8, 15);
            this.pictureBoxImageIcon.Name = "pictureBoxImageIcon";
            this.pictureBoxImageIcon.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxImageIcon.TabIndex = 5;
            this.pictureBoxImageIcon.TabStop = false;
            // 
            // labelSeperator2
            // 
            this.labelSeperator2.AutoSize = true;
            this.labelSeperator2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelSeperator2.Location = new System.Drawing.Point(67, 168);
            this.labelSeperator2.Name = "labelSeperator2";
            this.labelSeperator2.Size = new System.Drawing.Size(151, 13);
            this.labelSeperator2.TabIndex = 2;
            this.labelSeperator2.Text = "________________________";
            // 
            // labelSeperator
            // 
            this.labelSeperator.AutoSize = true;
            this.labelSeperator.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelSeperator.Location = new System.Drawing.Point(67, 87);
            this.labelSeperator.Name = "labelSeperator";
            this.labelSeperator.Size = new System.Drawing.Size(151, 13);
            this.labelSeperator.TabIndex = 1;
            this.labelSeperator.Text = "________________________";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(133, 15);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(201, 20);
            this.textBoxFileName.TabIndex = 0;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(147, 278);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(246, 278);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelAllSize
            // 
            this.labelAllSize.AutoSize = true;
            this.labelAllSize.Location = new System.Drawing.Point(130, 151);
            this.labelAllSize.Name = "labelAllSize";
            this.labelAllSize.Size = new System.Drawing.Size(33, 13);
            this.labelAllSize.TabIndex = 8;
            this.labelAllSize.Text = "Size: ";
            // 
            // textBoxPath
            // 
            this.textBoxPath.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPath.Location = new System.Drawing.Point(70, 119);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.ReadOnly = true;
            this.textBoxPath.Size = new System.Drawing.Size(247, 13);
            this.textBoxPath.TabIndex = 9;
            this.textBoxPath.TabStop = false;
            // 
            // ExploreProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 313);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.tabControl);
            this.Name = "ExploreProperties";
            this.Text = "Properties";
            this.Load += new System.EventHandler(this.ExploreProperties_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.tabPageGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.Label labelSeperator2;
        private System.Windows.Forms.Label labelSeperator;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.PictureBox pictureBoxImageIcon;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label labelAllSize;
        private System.Windows.Forms.ToolTip toolTip;
    }
}