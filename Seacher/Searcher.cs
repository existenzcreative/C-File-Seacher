using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seacher
{

    delegate void FileFound(string path);
    class Searcher
    {
        private string term;
        private string dir;
        public event FileFound OnFileFound;

        public Searcher(string dir, string term)
        {
            this.dir = dir;
            this.term = term;

        }

        private void Scan(string dir)
        {
            string[] files = Directory.GetFiles(dir);
            string[] dirs = Directory.GetDirectories(dir);

            List<string> allfiles = new List<string>();
            allfiles.AddRange(files);
            allfiles.AddRange(dirs);

            foreach (string s in allfiles)
            {
                string _s = s.ToLower();
                string _term = this.term.ToLower();

                if (Directory.Exists(s) && s != "." && s != "..")
                {
                    Scan(s);
                    continue;
                }

                if (_s.Contains(_term))
                {
                    OnFileFound(_s);
                }

            }
        }

        public void Search()
        {
            Scan(this.dir);
        }


        public string Term
        { 
            set { term = value; }
            get { return this.term; }        
        
        }

        public string Dir
        {
            set { dir = value; }
            get { return this.dir; }

        }


    }
}
