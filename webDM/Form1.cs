using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Diagnostics;

namespace webDM
{
    public partial class Form1 : Form
        
    {
       // string path = " ";
       public  string[] text;
      // public string[] key;
        public int x=0;
    //   List<string> d = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Browse_Click(object sender, EventArgs e)
        {


          /*  for (int i = 0; i <= textBox1.Text.Length;i++ )
                textBox1.te
                if (path.CompareTo(" ") == 0)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
                    path = saveFileDialog1.FileName;
                }
            
             File.WriteAllText(path,textBox1.Text);



             //text = (System.IO.File.ReadAllText(saveFileDialog1.FileName).Split(' '));

          /*  char[] ch = { '\n', '\r' };

            for (int i = 0; i <text.Length; i++)
               text[i] = text[i].Trim(ch);
          */

            openFileDialog1.ShowDialog();
            MessageBox.Show(openFileDialog1.FileName);
           

            text = (System.IO.File.ReadAllText(openFileDialog1.FileName).Split(' '));
           
            x = Text.Length;
            char[] ch = { '\n', '\r' };
            x = this.text.Length;
            for (int i = 0; i < text.Length; i++)
                text[i] = text[i].Trim(ch);
           
           Form2 f2 = new Form2(this);
            f2.Show();


        }

        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           // // Specify that the link was visited.
            //this.linkLabel1.LinkVisited = true;

            // Navigate to a URL.
            //System.Diagnostics.Process.Start("http://www.webconfs.com/keyword-density-checker.php"); 
          //  Application.StartupPath + "\\ehsan.html"
          System.Diagnostics.Process.Start(Application.StartupPath + "\\link.html");
        
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            Process pr = new Process();
            pr.StartInfo.FileName = "notepad";
            pr.Start();
            
        }

     /*   private void button1_Click_1(object sender, EventArgs e)
        {
           // text[1] = "---";

               int i = 1, sum = 0;
                      //  sum += int.Parse(text[i]);
               int l = text.Length;
           
                        for ( i = 1; i<=l; i = i + 3)
                            sum += int.Parse(text[i]);
                        textBox1.Text = sum.ToString();
                       
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           // Form2 f2 = new Form2(this);
            //f2.Show();  
        }
    }
}
