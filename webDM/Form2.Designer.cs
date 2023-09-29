namespace webDM
{
    partial class Form2
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
            this.new_category = new System.Windows.Forms.Button();
            this.n_avg = new System.Windows.Forms.Label();
            this.average = new System.Windows.Forms.Label();
            this.Standarddeviation = new System.Windows.Forms.Label();
            this.n_div = new System.Windows.Forms.Label();
            this.l_key = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.class_name = new System.Windows.Forms.ListBox();
            this.findclass = new System.Windows.Forms.Button();
            this.calssname = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // new_category
            // 
            this.new_category.Location = new System.Drawing.Point(41, 296);
            this.new_category.Name = "new_category";
            this.new_category.Size = new System.Drawing.Size(100, 23);
            this.new_category.TabIndex = 0;
            this.new_category.Text = "add_document\r\n";
            this.new_category.UseVisualStyleBackColor = true;
            this.new_category.Click += new System.EventHandler(this.new_category_Click);
            // 
            // n_avg
            // 
            this.n_avg.AutoSize = true;
            this.n_avg.Location = new System.Drawing.Point(140, 24);
            this.n_avg.Name = "n_avg";
            this.n_avg.Size = new System.Drawing.Size(0, 13);
            this.n_avg.TabIndex = 1;
            // 
            // average
            // 
            this.average.AutoSize = true;
            this.average.Location = new System.Drawing.Point(38, 24);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(46, 13);
            this.average.TabIndex = 2;
            this.average.Text = "average";
            // 
            // Standarddeviation
            // 
            this.Standarddeviation.AutoSize = true;
            this.Standarddeviation.Location = new System.Drawing.Point(38, 67);
            this.Standarddeviation.Name = "Standarddeviation";
            this.Standarddeviation.Size = new System.Drawing.Size(96, 13);
            this.Standarddeviation.TabIndex = 3;
            this.Standarddeviation.Text = "Standard deviation";
            // 
            // n_div
            // 
            this.n_div.AutoSize = true;
            this.n_div.Location = new System.Drawing.Point(140, 67);
            this.n_div.Name = "n_div";
            this.n_div.Size = new System.Drawing.Size(0, 13);
            this.n_div.TabIndex = 4;
            // 
            // l_key
            // 
            this.l_key.AutoSize = true;
            this.l_key.Location = new System.Drawing.Point(303, 13);
            this.l_key.Name = "l_key";
            this.l_key.Size = new System.Drawing.Size(0, 13);
            this.l_key.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(41, 167);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(263, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(139, 446);
            this.listBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "select document calss";
            // 
            // class_name
            // 
            this.class_name.FormattingEnabled = true;
            this.class_name.Items.AddRange(new object[] {
            "phonemobile",
            "television",
            "tablet",
            "camera"});
            this.class_name.Location = new System.Drawing.Point(41, 224);
            this.class_name.Name = "class_name";
            this.class_name.Size = new System.Drawing.Size(109, 56);
            this.class_name.TabIndex = 14;
            // 
            // findclass
            // 
            this.findclass.Location = new System.Drawing.Point(41, 360);
            this.findclass.Name = "findclass";
            this.findclass.Size = new System.Drawing.Size(97, 23);
            this.findclass.TabIndex = 15;
            this.findclass.Text = "find calss";
            this.findclass.UseVisualStyleBackColor = true;
            this.findclass.Click += new System.EventHandler(this.findclass_Click);
            // 
            // calssname
            // 
            this.calssname.AutoSize = true;
            this.calssname.Location = new System.Drawing.Point(153, 370);
            this.calssname.Name = "calssname";
            this.calssname.Size = new System.Drawing.Size(0, 13);
            this.calssname.TabIndex = 16;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(102, 443);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 17;
            this.ok.Text = "ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 478);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.calssname);
            this.Controls.Add(this.findclass);
            this.Controls.Add(this.class_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.l_key);
            this.Controls.Add(this.n_div);
            this.Controls.Add(this.Standarddeviation);
            this.Controls.Add(this.average);
            this.Controls.Add(this.n_avg);
            this.Controls.Add(this.new_category);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button new_category;
        private System.Windows.Forms.Label n_avg;
        private System.Windows.Forms.Label average;
        private System.Windows.Forms.Label Standarddeviation;
        private System.Windows.Forms.Label n_div;
        private System.Windows.Forms.Label l_key;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox class_name;
        private System.Windows.Forms.Button findclass;
        private System.Windows.Forms.Label calssname;
        private System.Windows.Forms.Button ok;
    }
}