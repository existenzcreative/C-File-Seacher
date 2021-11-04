using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seacher
{
    public partial class Form1 : Form
    {
        private Searcher searcher; 


        public Form1()
        {
            InitializeComponent();
            this.searcher = new Searcher(null, null);
            this.searcher.OnFileFound += FileFound;
            bgWorker.DoWork += WorkInBackground;
            bgWorker.RunWorkerCompleted += WorkerCompleted;

        }

        private void FileFound(string path)
        {
            lbFileFound.BeginInvoke((Action)delegate ()
            {
                lbFileFound.Items.Add(path);
            }
            
            );

        }


        private void WorkInBackground(object sender, DoWorkEventArgs args)
        {
            searcher.Search();

        }    
        
        private void WorkerCompleted(object sender, RunWorkerCompletedEventArgs args)
        {
            MessageBox.Show("Done!");


        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.searcher.Term = tbTerm.Text;
            this.searcher.Dir = tbSearchDir.Text;
            bgWorker.RunWorkerAsync();
        }
    }
}
