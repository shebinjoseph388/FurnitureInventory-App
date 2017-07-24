using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sampleprjct
{
    public partial class Form5 : Form
    {
        SqlCommand cmd = null;
        
        public Form5()
        {
            InitializeComponent();
        }

        private void cmdadminlogin_Click(object sender, EventArgs e)
        {
            if (Strings.Len(Strings.Trim(txtadminusername.Text)) == 0)
            {
                MessageBox.Show("Please enter username", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtadminusername.Focus();
                return;
            }
            if (Strings.Len(Strings.Trim(txtadminpassword.Text)) == 0)
            {
                MessageBox.Show("Please Enter Password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtadminpassword.Focus();
                return;
            }
            try
            {
                SqlConnection cn = new SqlConnection("");
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                cn.Open();
                SqlDataReader dr1 = null;
                SqlCommand com = new SqlCommand();
                com.CommandText = "select [login_name],[login_password] from Login where role_id = '1'";
                //username
                SqlParameter login_name = new SqlParameter("@login_name", SqlDbType.NVarChar, 25);
                login_name.Value = Strings.UCase(txtadminusername.Text.ToString());
                com.Parameters.Add(login_name);
                com.Connection = cn;
                dr1 = com.ExecuteReader();
               
                if (dr1.Read())
                {
                    if (Strings.UCase(dr1["login_password"].ToString()) == Strings.UCase(txtadminpassword.Text).ToString())
                    {
                        cn.Close();
                        Program.username = Strings.UCase(this.txtadminusername.Text.ToString());
                        Program.FrmState = "admin";

                        Form2 obj = new Form2();
                        this.Hide();
                        obj.Show();
                    }
                    else
                    {
                        MessageBox.Show("Password is Wrong", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cn.Close();
                        //linkLabel1.Visible = true;
                        //linkLabel1.Text = "Forget Password";
                        txtadminpassword.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("username is wrong", "input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cn.Close();
                    txtadminusername.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdadminexit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void cmdemplogin_Click(object sender, EventArgs e)
        {
            if (Strings.Len(Strings.Trim(txtempusername.Text)) == 0)
            {
                MessageBox.Show("Please Enter username", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtempusername.Focus();
                return;
            }
            if (Strings.Len(Strings.Trim(txtemppassword.Text)) == 0)
            {
                MessageBox.Show("Please Enter password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtemppassword.Focus();
                return;

            }
            try
            {
                SqlConnection cn = new SqlConnection("");
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                cn.Open();

                SqlDataReader dr1 = null;
                SqlCommand com = new SqlCommand();
                com.CommandText = "Select [username],[password] from Employee where username = @username";
                //username
                SqlParameter username = new SqlParameter("@username", SqlDbType.VarChar, 30);
                username.Value = Strings.UCase(txtempusername.Text.ToString());
                com.Parameters.Add(username);
                com.Connection = cn;
                dr1 = com.ExecuteReader();
                if (dr1.Read())
                {
                    if (Strings.UCase(dr1["Password"].ToString()) == Strings.UCase(txtemppassword.Text).ToString())
                    {
                        cn.Close();
                        Program.username = Strings.UCase(this.txtempusername.Text.ToString());
                        Program.FrmState = "Employee";
                        Form3 obj = new Form3();
                        this.Hide();
                        obj.Show();
                    }
                    else
                    {
                        MessageBox.Show("Password is wrong", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cn.Close();
                  //      linkLabel2.Visible = true;
                    //    linkLabel2.Text = "Forget Password";
                        txtemppassword.Focus();
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Username is Wrong", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cn.Close();
                    txtempusername.Focus();
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdempexit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
