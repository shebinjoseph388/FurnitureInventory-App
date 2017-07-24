namespace sampleprjct
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdadminexit = new System.Windows.Forms.Button();
            this.cmdadminlogin = new System.Windows.Forms.Button();
            this.txtadminusername = new System.Windows.Forms.TextBox();
            this.txtadminpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdempexit = new System.Windows.Forms.Button();
            this.cmdemplogin = new System.Windows.Forms.Button();
            this.txtemppassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtempusername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(420, 252);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(412, 218);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Admin";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdadminexit);
            this.groupBox1.Controls.Add(this.cmdadminlogin);
            this.groupBox1.Controls.Add(this.txtadminusername);
            this.groupBox1.Controls.Add(this.txtadminpassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cmdadminexit
            // 
            this.cmdadminexit.Image = ((System.Drawing.Image)(resources.GetObject("cmdadminexit.Image")));
            this.cmdadminexit.Location = new System.Drawing.Point(283, 147);
            this.cmdadminexit.Name = "cmdadminexit";
            this.cmdadminexit.Size = new System.Drawing.Size(101, 51);
            this.cmdadminexit.TabIndex = 6;
            this.cmdadminexit.Text = "&Cancel";
            this.cmdadminexit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdadminexit.UseVisualStyleBackColor = true;
            this.cmdadminexit.Click += new System.EventHandler(this.cmdadminexit_Click);
            // 
            // cmdadminlogin
            // 
            this.cmdadminlogin.Image = ((System.Drawing.Image)(resources.GetObject("cmdadminlogin.Image")));
            this.cmdadminlogin.Location = new System.Drawing.Point(174, 147);
            this.cmdadminlogin.Name = "cmdadminlogin";
            this.cmdadminlogin.Size = new System.Drawing.Size(103, 51);
            this.cmdadminlogin.TabIndex = 5;
            this.cmdadminlogin.Text = "&Login";
            this.cmdadminlogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdadminlogin.UseVisualStyleBackColor = true;
            this.cmdadminlogin.Click += new System.EventHandler(this.cmdadminlogin_Click);
            // 
            // txtadminusername
            // 
            this.txtadminusername.Location = new System.Drawing.Point(190, 58);
            this.txtadminusername.Name = "txtadminusername";
            this.txtadminusername.Size = new System.Drawing.Size(168, 28);
            this.txtadminusername.TabIndex = 4;
            // 
            // txtadminpassword
            // 
            this.txtadminpassword.Location = new System.Drawing.Point(190, 113);
            this.txtadminpassword.Name = "txtadminpassword";
            this.txtadminpassword.Size = new System.Drawing.Size(168, 28);
            this.txtadminpassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "PASSWORD";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(191, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "USERNAME:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(18, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 108);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(412, 218);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Employee";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdempexit);
            this.groupBox2.Controls.Add(this.cmdemplogin);
            this.groupBox2.Controls.Add(this.txtemppassword);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtempusername);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Location = new System.Drawing.Point(3, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 198);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // cmdempexit
            // 
            this.cmdempexit.Image = ((System.Drawing.Image)(resources.GetObject("cmdempexit.Image")));
            this.cmdempexit.Location = new System.Drawing.Point(269, 152);
            this.cmdempexit.Name = "cmdempexit";
            this.cmdempexit.Size = new System.Drawing.Size(94, 40);
            this.cmdempexit.TabIndex = 5;
            this.cmdempexit.Text = "&Cancel";
            this.cmdempexit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdempexit.UseVisualStyleBackColor = true;
            this.cmdempexit.Click += new System.EventHandler(this.cmdempexit_Click);
            // 
            // cmdemplogin
            // 
            this.cmdemplogin.Image = ((System.Drawing.Image)(resources.GetObject("cmdemplogin.Image")));
            this.cmdemplogin.Location = new System.Drawing.Point(175, 152);
            this.cmdemplogin.Name = "cmdemplogin";
            this.cmdemplogin.Size = new System.Drawing.Size(87, 40);
            this.cmdemplogin.TabIndex = 1;
            this.cmdemplogin.Text = "&Login";
            this.cmdemplogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdemplogin.UseVisualStyleBackColor = true;
            this.cmdemplogin.Click += new System.EventHandler(this.cmdemplogin_Click);
            // 
            // txtemppassword
            // 
            this.txtemppassword.Location = new System.Drawing.Point(175, 121);
            this.txtemppassword.Name = "txtemppassword";
            this.txtemppassword.Size = new System.Drawing.Size(181, 25);
            this.txtemppassword.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(171, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "PASSWORD";
            // 
            // txtempusername
            // 
            this.txtempusername.Location = new System.Drawing.Point(175, 61);
            this.txtempusername.Name = "txtempusername";
            this.txtempusername.Size = new System.Drawing.Size(181, 25);
            this.txtempusername.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "USERNAME";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(6, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 120);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 237);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        internal System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdadminexit;
        private System.Windows.Forms.Button cmdadminlogin;
        private System.Windows.Forms.TextBox txtadminusername;
        private System.Windows.Forms.TextBox txtadminpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdempexit;
        private System.Windows.Forms.Button cmdemplogin;
        private System.Windows.Forms.TextBox txtemppassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtempusername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}