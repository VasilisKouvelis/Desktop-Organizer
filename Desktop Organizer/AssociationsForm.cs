using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Organizer
{
    public partial class AssociationsForm : Form
    {
        Form1 frm1;
        public AssociationsForm()
        {
            InitializeComponent();
        }

        public AssociationsForm(Form1 form)
        {
            InitializeComponent();
            frm1 = form;
        }

        private void AssociationsForm_Load(object sender, EventArgs e)
        {
            //this.Height = 655;
            this.Height = 650;
            loadListViewAccs();
        }

        private void loadListViewAccs()
        {
            accsView.Items.Clear();
            folderLV.Items.Clear();
            foreach (Association item in frm1.Org.GetAssociations())
            {
                ListViewItem lvi = new ListViewItem(item.getExtension());
                lvi.SubItems.Add(item.getDestinationPath());
                accsView.Items.Add(lvi);
            }
            foreach (Association item in frm1.Org.GetFolders())
            {
                ListViewItem lvi = new ListViewItem(item.getExtension());
                lvi.SubItems.Add(item.getDestinationPath());
                folderLV.Items.Add(lvi);
            }
        }

        private void saveAccs() //save to file.
        {
            StreamWriter sw = new StreamWriter(frm1.INI_PATH);
            string line;
            foreach (Association a in frm1.Org.GetAssociations())
            {
                line = a.getExtension() + "#" + a.getDestinationPath();
                sw.WriteLine(line);
            }
            sw.Close();

            sw = new StreamWriter(frm1.FOLDER_PATH);
            foreach (Association a in frm1.Org.GetFolders())
            {
                line = a.getExtension() + "#" + a.getDestinationPath();
                sw.WriteLine(line);
            }
            sw.Close();
        }

        private void addEditBtn_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                editPanel.Visible = !editPanel.Visible;
                addFilterBtn.Visible = editPanel.Visible;
                editFilterBtn.Visible = !editPanel.Visible;
            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                folderPanel.Visible = !folderPanel.Visible;
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                if (accsView.SelectedItems.Count <= 0)  //check gia null item apo LV
                {
                    MessageBox.Show("Select a filter first to remove!");
                    return;
                }
                //delete item here
                ListViewItem lvi = accsView.SelectedItems[0];
                string ext = lvi.Text;
                string path = lvi.SubItems[1].Text;

                if (MessageBox.Show("Are you sure you want to delete:\nExtension: " + ext + "\nPath: " + path, "Delete filter?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    frm1.Org.deleteAssociation(ext, path);
                    loadListViewAccs();
                }
            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                if (folderLV.SelectedItems.Count <= 0)
                {
                    MessageBox.Show("Select a folder first to remove!");
                    return;
                }
                ListViewItem lvi = folderLV.SelectedItems[0];
                string fld = lvi.Text;
                string path = lvi.SubItems[1].Text;
                if (MessageBox.Show("Are you sure you want to delete:\nFolder: " + fld + "\nPath: " + path, "Delete folder?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    frm1.Org.DeleteFolder(fld, path);
                    loadListViewAccs();
                }
            }
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            string path = fbd.SelectedPath;
            destpathTxt.Text = path;
        }

        private void closeEditPanelBtn_Click(object sender, EventArgs e)
        {
            editPanel.Visible = !editPanel.Visible;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            saveAccs();
            this.Close();
        }

        private void addAsc_Click(object sender, EventArgs e)
        {
            if (extensionTxt.Text == "" || destpathTxt.Text == "")
            {
                MessageBox.Show("Extension or path cannot be empty.");
                return;
            }
            if (!frm1.Org.addAssociation(extensionTxt.Text, destpathTxt.Text))
            {
                MessageBox.Show("You cannot add again the same Filter.");
                return;
            }

            loadListViewAccs();
            editPanel.Visible = !editPanel.Visible;
            extensionTxt.Clear();
            destpathTxt.Clear();
        }

        private void addFolder_Click(object sender, EventArgs e)
        {
            if (shortcutTxt.Text == "" || folderTxt.Text == "")
            {
                MessageBox.Show("Shortcut or folder cannot be empty.");
            }
            if (!frm1.Org.AddFolder(shortcutTxt.Text, folderTxt.Text))
            {
                MessageBox.Show("You cannot add again the same Filter.");
                return;
            }

            loadListViewAccs();
            folderPanel.Visible = !folderPanel.Visible;
            shortcutTxt.Clear();
            folderTxt.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderPanel.Visible = !folderPanel.Visible;
        }

        private void folderBrowerBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            string path = fbd.SelectedPath;
            folderTxt.Text = path;
        }

        private void folderLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(folderLV.SelectedItems.Count > 0))
                return;
            string shortcut = folderLV.SelectedItems[0].Text;
            Clipboard.SetText(shortcut);
        }
        ListViewItem lvi;
        private void editFilterBtn_Click(object sender, EventArgs e)
        {
            if (lvi != null)
            {
                Association toEdit = null;
                //lvi.Text
                // lvi.SubItems[1].Text 


                //accsView.SelectedItems[0].Text = extensionTxt.Text;
                //accsView.SelectedItems[0].SubItems[1].Text = destpathTxt.Text;
                toEdit = frm1.Org.findAssociation(lvi.Text, lvi.SubItems[1].Text);
                if (toEdit != null)
                {
                    toEdit.setExtension(extensionTxt.Text);
                    toEdit.setDestinationPath(destpathTxt.Text);
                }
                else
                {
                    //https://www.browserling.com/tools/text-to-hex ????
                    MessageBox.Show("Error at editing filter.\n Code: edit@filter ");
                }

                loadListViewAccs();
                editPanel.Visible = !editPanel.Visible;
                extensionTxt.Clear();
                destpathTxt.Clear();
            }
        }

        private void accsView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            editPanel.Visible = !editPanel.Visible;
            addFilterBtn.Visible = !editPanel.Visible;
            editFilterBtn.Visible = editPanel.Visible;
            lvi = null;
            if (accsView.SelectedItems.Count > 0)
            {
                lvi = accsView.SelectedItems[0];
                extensionTxt.Text = lvi.Text;
                destpathTxt.Text = lvi.SubItems[1].Text;
            }
        }
    }
}
