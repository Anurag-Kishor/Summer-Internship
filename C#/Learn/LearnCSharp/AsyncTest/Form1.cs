using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private int CountCharacters()
        {
            int count = 0;

            using (StreamReader sr = new StreamReader(@"D:\Anu\DAIICT\OOPS\Internship\C#\Learn\LearnCSharp\Data.txt"))
            {
                string content = sr.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);
            }
            return count;
        }
        private async void btnCountFile(object sender, EventArgs e)
        {

            Task<int> t = new Task<int>(CountCharacters);
            t.Start();

            lblCount.Text = "Processing File. Please Wait...";
            int count = await t;
            lblCount.Text = count.ToString() + " characters in file.";
          
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
