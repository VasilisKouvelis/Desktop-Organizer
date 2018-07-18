using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_Organizer
{
    class Association
    {
        private string extension;
        private string destinationPath;

        public Association(string extension, string destinationPath)
        {
            this.extension = extension ?? throw new ArgumentNullException(nameof(extension));
            this.destinationPath = destinationPath ?? throw new ArgumentNullException(nameof(destinationPath));
        }


        public string getExtension()
        {
            return this.extension;
        }

        public void setExtension(String ext)
        {
            this.extension = ext;
        }


        public string getDestinationPath()
        {
            return this.destinationPath;
        }

        public void setDestinationPath(String path)
        {
            this.destinationPath = path;
        }

        public override bool Equals(object obj)
        {
            // to obj pou koitame
            // this auto to item
            // ara sugkrinoume to to this<>obj
            Association association = obj as Association;
            String[] thisExts = this.extension.Split(';');
            String[] objExts = association.extension.Split(';');
            if (thisExts.Length > 1 || objExts.Length > 1)
            {
                foreach (String te in thisExts)
                {
                    foreach (String oe in objExts)
                    {
                        if (te.ToLower().Equals(oe.ToLower()))
                        {
                            return true;
                        }
                    }
                }
            }
            else
            {
                if (association.extension == this.extension)
                    return true;
            }

            return association != null &&
                   extension == association.extension &&
                   destinationPath == association.destinationPath;
        }

        public override int GetHashCode()
        {
            var hashCode = 1255432130;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(extension);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(destinationPath);
            return hashCode;
        }


    }
}
