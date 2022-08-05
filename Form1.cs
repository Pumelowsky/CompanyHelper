using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BussinessChatter
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            checkCon();
        }

        private void loginUser(string username, string password)
        {
            string conStr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            using (SqlConnection con = new SqlConnection(conStr))
            {        
                SqlCommand cmd = new SqlCommand("SELECT id FROM users WHERE username = @user AND password = @pass", con);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);
                try
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if(dt.Rows.Count > 0)
                    {
                        int profileId = (int)dt.Rows[0][0];
                        this.Hide();
                        mainWindow form2 = new mainWindow(profileId);
                        form2.Closed += (s, args) => this.Close();
                        form2.Show();
                    }
                    else
                    {
                        statusText.Text = "Incorrect username or password";
                        statusText.BackColor = Color.FromArgb(255, 192, 57, 43);
                    }
                    con.Close();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void checkCon()
        {
            try
            {
                string conStr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
                using (SqlConnection con = new SqlConnection(conStr))
                { 
                    con.Open();
                    statusText.Text = "Connected to database";
                    statusText.BackColor = Color.FromArgb(255, 78, 236, 145);
                    con.Close();
                }
            }
            catch
            {
                statusText.Text = "Cannot connect to database";
                statusText.BackColor = Color.FromArgb(255, 192, 57, 43);
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            loginUser(loginText.Text, passwordText.Text);
            
        }
    }
}