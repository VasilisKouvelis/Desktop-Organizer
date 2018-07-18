using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Organizer
{
    class Organizer
    {
        private string path;
        private List<Association> assc = new List<Association>();   //assc list gia ta exts/paths
        private List<Association> folders = new List<Association>();

        public string Path { get => path; set => path = value; }

        public Organizer(string path)
        {
            this.Path = path ?? throw new ArgumentNullException(nameof(path));  //not null path
        }

        public Boolean AddFolder(string extension, string path)
        {
            Association a = new Association(extension, path);
            if (!this.folders.Contains(a))
            {
                this.folders.Add(a);
                return true;
            }
            return false; ;
        }
        public List<Association> GetFolders()
        {
            return this.folders;
        }

        public Boolean DeleteFolder(Association a)
        {
            this.folders.Remove(a);
            return true;
        }

        public Boolean DeleteFolder(String folder, string path)
        {
            Association a = new Association(folder, path);
            DeleteFolder(a);
            return true;
        }


        public Boolean addAssociation(string extension, string path)
        {
            Association a = new Association(extension, path);
            if (!this.assc.Contains(a))
            { //8a xreiastw override sto equals class tou Association a.equals(b) => DONE!
                this.assc.Add(a);
                return true;
            }
            return false;
        }

        public string[] getAccs()
        {
            string[] ret = new string[this.assc.Count];
            int i = 0;
            foreach (Association a in this.assc)
            {
                ret[i++] = a.getExtension() + "#" + a.getDestinationPath();
            }
            return ret;
        }

        public List<Association> GetAssociations()
        {
            return this.assc;
        }

        public Boolean deleteAssociation(Association a)
        {
            this.assc.Remove(a);
            return true;
        }

        public Boolean deleteAssociation(string ext, string path)
        {
            Association a = new Association(ext, path);
            deleteAssociation(a);
            return true;
        }

        public int organizeFiles()
        {
            IniSettings settings = new IniSettings("settings.ini");
            bool rename = settings.Read("auto_rename", "Rename").ToLower().Equals("true") ? true : false;
            int counter = 0;
            string movepath, source, destination;
            // leave folders untouched gia arxi
            DirectoryInfo d = new DirectoryInfo(Path);
            FileInfo[] Files = d.GetFiles();
            foreach (FileInfo file in Files)
            {
                if (file.Name.ToLower().Equals("desktop.ini"))
                    continue;
                string ext = file.Extension.ToString();
                if ((movepath = getMovePath(ext)) != null)
                {
                    //move to arxeio ekei.
                    source = file.FullName;
                    destination = movepath + "\\" + file.Name;
                    if (File.Exists(destination))
                    {
                        String[] name = file.Name.Split('.');
                        // MessageBox.Show("File already exists: " + file.Name, "Desktop Organizer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // continue;
                        String msg = "Save (" + file.Name + ") as (" + name[0] + "_1." + name[1] + ") ?";
                        if (rename)
                        {
                            destination = movepath + "\\" + name[0] + "_1." + name[1];
                        }
                        else
                        {
                            DialogResult dlgres = MessageBox.Show("File already exists.\n" + msg, "Desktop Organizer", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                            if (dlgres == DialogResult.Yes)
                                destination = movepath + "\\" + name[0] + "_1." + name[1];
                            else continue;
                        }

                    }
                    try
                    {
                        File.Move(source, destination);
                    }
                    catch (Exception) { }

                    counter++;
                }
            }
            return counter;
        }

        public int getFilesCount()
        {
            DirectoryInfo d = new DirectoryInfo(Path);
            FileInfo[] Files = d.GetFiles();
            return Files.Length;
        }


        private string getMovePath(string ext)
        {
            string ret = null;
            foreach (Association a in this.assc)
            {
                String[] extensions = a.getExtension().Split(';');
                foreach (String ex in extensions)
                {
                    if (ex.ToLower().Equals(ext.ToLower()))
                        ret = a.getDestinationPath();
                }
            }
            if (ret != null)
            {
                foreach (Association f in this.folders)
                {
                    if (ret.Contains(f.getExtension()))
                        ret = ret.Replace(f.getExtension(), f.getDestinationPath());
                }
            }
            return ret;
        }

        public Boolean LoadAssociations(string file)
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader(file);
                line = sr.ReadLine();
                while (line != null)
                {
                    string[] newline = line.Split('#');
                    this.addAssociation(newline[0], newline[1]);
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                return true;
            }
            catch (Exception)
            {
                //something is wrong
                return false;
            }
        }
        public Boolean LoadFolders(string file)
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader(file);
                line = sr.ReadLine();
                while (line != null)
                {
                    string[] newline = line.Split('#');
                    this.AddFolder(newline[0], newline[1]);
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Association findAssociation(String ext, String path)
        {
            Association temp = new Association(ext, path);
            foreach (Association filter in this.assc)
                if (filter.Equals(temp))
                    return filter;

            return null;
        }

        public override bool Equals(object obj)
        {
            var organizer = obj as Organizer;
            return organizer != null &&
                   path == organizer.path &&
                   EqualityComparer<List<Association>>.Default.Equals(assc, organizer.assc) &&
                   Path == organizer.Path;
        }

        public override int GetHashCode()
        {
            var hashCode = 2083266655;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(path);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Association>>.Default.GetHashCode(assc);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Path);
            return hashCode;
        }
    }
}
