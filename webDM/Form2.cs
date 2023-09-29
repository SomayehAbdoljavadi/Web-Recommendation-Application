using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace webDM
    
{
    public partial class Form2 : Form
    {
        Form1 f1;
    
        public Form2(Form1 f)

        {
            InitializeComponent();
            f1 = f;
            

        }

        private void Form2_Load(object sender, EventArgs e)

        {


           
            
            int x = f1.text.Length/3;
            double sum=0;
            double avg = 0, div = 0;
            double p=2;
            double max=0,min=0;
            
            for (int i = 1; i <=f1.text.Length; i+=3)
                sum +=double.Parse(f1.text[i]);

            avg = (sum / x);
            n_avg.Text=avg.ToString();
            
            sum = 0;
            for (int i = 1; i <= f1.text.Length; i+=3)
                sum +=Math.Pow(((double.Parse(f1.text[i]))-avg),p);
                    
            div = Math.Sqrt(sum / x-1);
            n_div.Text = div.ToString();

            max=avg+div;
            min=avg-div;
            textBox1.Text += "min    "+min.ToString(); 
            textBox2.Text+="max   "+ max.ToString();
    
            for(int i=1;i<=f1.text.Length;i+=3)
                if ((double.Parse(f1.text[i]))<avg)
                {
                     f1.text[i-1]="null";

                     f1.text[i] = "null";

                     f1.text[i + 1] = "null";
                    
                
                }
            
            for (int i = 0; i <f1.text.Length; i++)
            {
                if (f1.text[i] != "null")
                        listBox1.Items.Add(f1.text[i]);
                
             
                
            }
            new_category.Enabled = false;
           
        }

        private void new_category_Click(object sender, EventArgs e)
        {
            string classname = class_name.SelectedItem.ToString();
            //textBox3.Text = classname;

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=web_DM;Integrated Security=True;");
            con.Open();
            SqlDataReader sdr; 
            SqlCommand comi = new SqlCommand();
            SqlCommand coms = new SqlCommand();
    

            comi.Connection = con;
            coms.Connection = con;

            int wordid;
//---------------add new document------------------table doc (id & class)-------------------------------------------
           // textBox3.Text = " insert into test3 (class) values('" + class_name.SelectedItem.ToString() + "');select @@identity as id";
            comi.CommandText = " insert into test3 (class) values('" + class_name.SelectedItem.ToString() + "');select @@identity as docid ";
             sdr = null;
    
            sdr = comi.ExecuteReader();
            sdr.Read();
            int docid = int.Parse(sdr[0].ToString());

            sdr.Close();
    
            
            
    

//---------------add new document------------------table word (id , word) & table word_doc(word_i,doc_id,count)-------------------------------------------
            
                        for (int i = 0; i <f1.text.Length; i+=3)
                        {
                            if (f1.text[i] != "null")
                            {
                                coms.CommandText = " select count(*) from test1 where word= '" + f1.text[i] + "'";
                                sdr = null; 
                                sdr = coms.ExecuteReader();
                                sdr.Read();
                               /* if ((sdr[1].ToString()))
                                {
                                    int wordid = int.Parse(sdr[1].ToString());
                                }*/
                               if (int.Parse(sdr[0].ToString()) == 0)
                                    {
                                        sdr.Close();

                                        comi.CommandText = " insert into test1 (word) values('" + f1.text[i] + "');select @@identity as wordid";
                                            sdr = null;
                                            sdr = comi.ExecuteReader();
                                            sdr.Read();
                                             wordid = int.Parse(sdr[0].ToString());
            
                                           sdr.Close();

                                       comi.CommandText = " insert into test2 (word_id,doc_id,count) values("+wordid+","+docid+","+f1.text[i+1] + ") ";
                                           comi.ExecuteNonQuery();
            
                                    }
                                else
                                
                                    if (int.Parse(sdr[0].ToString()) > 0)
                                    {
                                        sdr.Close();
                                        coms.CommandText = " select id from test1 where word= '" + f1.text[i] + "'";
                                        sdr = null;
                                        sdr = coms.ExecuteReader();
                                        sdr.Read();
                                        wordid = int.Parse(sdr[0].ToString());
                                        sdr.Close();

                                        comi.CommandText = " insert into test2 (word_id,doc_id,count) values(" + wordid + "," + docid + "," + f1.text[i + 1] + ") ";
                                        comi.ExecuteNonQuery();
                                    
                                    }
                                sdr.Close();

                                   
                            }
                            sdr.Close();
                        }
           sdr.Close();
            con.Close();
            this.Close();
            //f1.Show();

        }

        private void findclass_Click(object sender, EventArgs e)
        {
        
            
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=web_DM;Integrated Security=True;");
            con.Open();
            SqlDataReader sdr;
            SqlCommand comi = new SqlCommand();
            SqlCommand coms = new SqlCommand();


            comi.Connection = con;
            coms.Connection = con;

            
            coms.CommandText = " select count(*) from test1 ";
            sdr = null;
            sdr = coms.ExecuteReader();
            sdr.Read();
            int wordcount = int.Parse(sdr[0].ToString());
          int w=wordcount+1;
            sdr.Close();

            coms.CommandText = " select count(*) from test3 ";
            sdr = null;
            sdr = coms.ExecuteReader();
            sdr.Read();
            int doccount = int.Parse(sdr[0].ToString());
           int d=doccount+1;
            sdr.Close();
            //int i=1;
            //int j=1;
            int [,] count=new int[d,w];
            for (int i = 1; i <= doccount; i++)
                for (int j = 1; j <= wordcount; j++)
                {
                    coms.CommandText = "select test2.count   from test1 left join test2 on test1.id=test2.word_id where test2.doc_id=" + i + "and word_id=" + j;

                    sdr = null;
                    sdr = coms.ExecuteReader();
                    sdr.Read();
                    if (sdr.HasRows)
                    {
                        int counter = int.Parse(sdr[0].ToString());
                        sdr.Close();
                        count[i,j] = counter;
                    }
                    else
                    {
                        count[i, j] = 0;
                        sdr.Close();
                    }
                }
            /*for (int i = 1; i <= doccount; i++)
            {
             
                for (int j = 1; j <= wordcount; j++)
                    textBox3.Text += count[i, j] + "||";
                textBox3.Text += "-----------";
            }*/
                int wordid;
//------------------------finde new doc word----------------------------------------------------------
                int [] find=new int [w];
              //  int n_wordcount=0;
                for (int k = 0; k < f1.text.Length; k += 3)
                {
                    if (f1.text[k] != "null")
                    {
                        coms.CommandText = " select count(*) from test1 where word= '" + f1.text[k] + "'";
                        sdr = null;
                        sdr = coms.ExecuteReader();
                        sdr.Read();
                
                       if (int.Parse(sdr[0].ToString()) > 0)
                            {
                                sdr.Close();
                                coms.CommandText = " select id from test1 where word= '" + f1.text[k] + "'";
                                sdr = null;
                                sdr = coms.ExecuteReader();
                                sdr.Read();
                                wordid = int.Parse(sdr[0].ToString());
                                sdr.Close();

                           find[wordid]=int.Parse(f1.text[k+1]);
                            }
                       
                       sdr.Close();
                     }
                
                   sdr.Close();
                  }    
            sdr.Close();
           
//------------------------calcute distanse----------------------------------------------------------
            double[,] distance = new double[d,2];
            double dc = 0;
            double sum = 0,avg=0;
            for (int i = 1; i <= doccount; i++)
            {
                for (int j = 1; j <= wordcount; j++)

                    dc += Math.Sqrt(Math.Pow((find[j] - count[i, j]), 2));

                distance[i, 0] = i;
                distance[i, 1] = dc;
                sum += dc;
                dc = 0;

            }
//------------------------------------- sort distance--------------------------------------------------
            avg = sum / w;

            double docid=0,docdis=0;

            for (int i = 1; i <doccount; i++)
                for (int j = 1; j <doccount ; j++)
                  if (distance[j,1]>distance[j+1,1])
                           {
                               docid = distance[j, 0];
                               docdis = distance[j,1];
                               
                               distance[j, 0] = distance[j+1, 0];
                               distance[j, 1] = distance[j+1, 1];
                               
                               distance[j+1, 0]=docid;
                               distance[j+1, 1]=docdis;
                          }
//------------------------------------- fine class--------------------------------------------------
            int c =0,m=0,tv=0,t=0,max=0;
            string camera = "camera", phonemobile = "phonemobile", tablet = "tablet", television = "television",str;
        
                
            for (int i = 1; i <= 5; i++)
            {


        
                coms.CommandText = " select class from test3 where id="+distance[i,0];
                sdr = null;
                sdr = coms.ExecuteReader();
                sdr.Read();
                string clas= (sdr[0].ToString()).Trim();
              
                sdr.Close();
                if (clas.CompareTo(camera) == 0)
                    c++;
                else
                    if (clas.CompareTo(phonemobile) == 0)
                        m++;
                    else
                        if (clas.CompareTo(tablet) == 0)
                            t++;
                        else
                            if (clas.CompareTo(television) == 0)
                                tv++;
            
            }

            if(c>max)
               {
                max=c;
                calssname.Text = camera;
               }
            if (m > max)
            {
                max = m;
                calssname.Text = phonemobile;
            }
            if (t > max)
            {
                max = t;
                calssname.Text = tablet;
            }
            if (tv > max)
            {
                max = tv;
                calssname.Text = television;
            }
            sdr.Close();
            con.Close();

        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        
      }
}
