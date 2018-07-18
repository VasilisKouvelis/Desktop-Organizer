using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Organizer
{
    public partial class Form1 : Form
    {
        Form asscForm;
        private string dESKTOP_PATH = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private string iNI_PATH = Application.StartupPath + "\\filters.ini";
        private string fOLDER_PATH = Application.StartupPath + "\\folders.ini";
        //private IniSettings sETTING_INI = new IniSettings("settings.ini");
        private Organizer org;
        private int SMALL_HEIGHT = 135;
        private int BIG_HEIGHT;



        internal Organizer Org { get => org; set => org = value; }
        public string INI_PATH { get => iNI_PATH; set => iNI_PATH = value; }
        public string DESKTOP_PATH { get => dESKTOP_PATH; set => dESKTOP_PATH = value; }
        public string FOLDER_PATH { get => fOLDER_PATH; set => fOLDER_PATH = value; }
        //internal IniSettings SETTING_INI { get => sETTING_INI; set => sETTING_INI = value; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = SMALL_HEIGHT;
            BIG_HEIGHT = 40 + pathPanel.Height;
            Org = new Organizer(DESKTOP_PATH);
            asscForm = new AssociationsForm(this);
            loadAccs();
            currentPathLbl.Text = Org.Path;
            countLbl.Text = "Files: " + Org.getFilesCount().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int counter = Org.organizeFiles();
            if (counter > 0)
            {
                MessageBox.Show("Moved " + counter + " items!");
                countLbl.Text = "Files: " + Org.getFilesCount().ToString();
            }
        }

        private void saveAccs()
        {
            StreamWriter sw = new StreamWriter(INI_PATH);
            string line;
            foreach (Association a in Org.GetAssociations())
            {
                line = a.getExtension() + "#" + a.getDestinationPath();
                sw.WriteLine(line);
            }
            sw.Close();

            sw = new StreamWriter(FOLDER_PATH);
            foreach (Association a in Org.GetFolders())
            {
                line = a.getExtension() + "#" + a.getDestinationPath();
                sw.WriteLine(line);
            }
            sw.Close();
        }

        // load associations from file to org.Associations<List>
        private void loadAccs()
        {
            if (!org.LoadAssociations(INI_PATH))
            {
                MessageBox.Show("Error at loading: '" + INI_PATH + "' file.");
            }
            if (!Org.LoadFolders(FOLDER_PATH))
            {
                MessageBox.Show("Error at loading: '" + FOLDER_PATH + "' file.");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            asscForm.ShowDialog();
        }

        private void changePathBtn_Click(object sender, EventArgs e)
        {
            this.Height = BIG_HEIGHT;
            pathPanel.Visible = !pathPanel.Visible;
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            string path = fbd.SelectedPath;
            pathTxt.Text = path;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Height = SMALL_HEIGHT;
            pathPanel.Visible = !pathPanel.Visible;
        }

        private void currentPathLbl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Process.Start(org.Path);
        }

        private void pathOKbtn_Click(object sender, EventArgs e)
        {
            if (pathTxt.Text.Equals(""))
            {
                MessageBox.Show("New path is empty. Select a folder first.");
                return;
            }
            Org = new Organizer(pathTxt.Text);
            this.Height = SMALL_HEIGHT;
            pathPanel.Visible = !pathPanel.Visible;
            loadAccs();
            currentPathLbl.Text = Org.Path;
            countLbl.Text = "Files: " + Org.getFilesCount().ToString();
        }

        private void setDesktopBtn_Click_1(object sender, EventArgs e)
        {
            pathTxt.Text = DESKTOP_PATH;
        }
    }
}
