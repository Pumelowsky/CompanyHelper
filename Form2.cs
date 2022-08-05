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
    public partial class mainWindow : Form
    {
        private static int profID;

        public static int ProfID { get => profID; set => profID = value; }
        public User myUser = new User();
        public mainWindow(int profileId = 2)
        {
            ProfID = profileId;
            InitializeComponent();
        }

       

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void refreshItems() // to repair
        {
            List<Control> listControls = new List<Control>();

            foreach (Control control in listControls)
            {
                flowLayoutPanel2.Controls.Remove(control);
                control.Dispose();
            }
            
            showItems();
            flowLayoutPanel2.Refresh();
        }
        private void showItems()
        {
            string conStr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM tasks", con);
                try
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable items = new DataTable();
                    sda.Fill(items);
                    int rowCount = items.Rows.Count;
                    ListItem[] listItems = new ListItem[rowCount];
               
                    if (rowCount > 0)
                    {
                        for (int i = 0; i < listItems.Length; i++)
                        {
                            listItems[i] = new ListItem();
                            listItems[i].Title = items.Rows[i][1].ToString();
                            listItems[i].Id = (int)items.Rows[i][0];
                            listItems[i].UserId = myUser.AccountId;
                            if (items.Rows[i][2].ToString() == "0")
                                listItems[i].Assignees = "None";
                            else
                            {
                                SqlCommand cmd2 = new SqlCommand("SELECT username FROM users", con);
                                SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                                DataTable namesOfUsers = new DataTable();
                                sda2.Fill(namesOfUsers);
                                int[] splitArray = (int[])items.Rows[i][2].ToString().Split(',').Select(Int32.Parse).ToArray();
                                string strNames = "";
                                
                                for (int j = 0; j<splitArray.Length; j++)
                                {
                                    if (splitArray[j] != 0)
                                        strNames += namesOfUsers.Rows[splitArray[j]-1][0] + ", ";
                                    else
                                        strNames = "None";
                                }
                                listItems[i].Assignees = strNames;
                            }
                            listItems[i].Progress = (int)items.Rows[i][3];
                            listItems[i].Icon = items.Rows[i][4].ToString();
                            if (flowLayoutPanel2.Controls.Count < 0)
                               flowLayoutPanel2.Controls.Clear();
                            else
                               flowLayoutPanel2.Controls.Add(listItems[i]);
                        }
                    }
                    else
                    {
                        MessageBox.Show("ERROR!!!!");
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            
        }
        private void mainWindow_Load(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM users INNER JOIN roles on users.role = roles.id_role WHERE users.id = @ID", con);
                cmd.Parameters.AddWithValue("@ID", ProfID);
                try
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        
                        myUser.AccountId = (int)dt.Rows[0][0];
                        string username = dt.Rows[0][1].ToString();
                        myUser.UserName = username;
                        myUser.Role = (int)dt.Rows[0][4];
                        myUser.RoleName = dt.Rows[0][5].ToString();

                        string profColor = dt.Rows[0][6].ToString();
                        string[] splitArray = profColor.Split(',');

                        myUser.ProfileColor = splitArray;

                        idLabel.Text = "ID: " + myUser.AccountId;
                        nickLabel.Text = myUser.UserName;
                        roleLabel.Text = myUser.RoleName.ToString();

                        roleLabel.ForeColor = Color.FromArgb(Int32.Parse(myUser.ProfileColor[0]), Int32.Parse(myUser.ProfileColor[1]), Int32.Parse(myUser.ProfileColor[2]));
                        showItems();
                    }
                    else
                    {
                        MessageBox.Show("ERROR!!!!");
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void AddUserToTask(int taskId, int userId)
        {
            
            string conStr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("SELECT assignees FROM tasks WHERE task_id = @ID", con);
                cmd.Parameters.AddWithValue("@ID", taskId);
                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int[] splitArray = (int[])reader["assignees"].ToString().Split(',').Select(Int32.Parse).ToArray();
                        bool contains = splitArray.Contains(userId);
                        
                        
                        if (contains)
                            MessageBox.Show("User already in there");
                        else
                        {
                            
                            SqlCommand cmd2 = new SqlCommand("UPDATE tasks SET assignees = @ASSIGNEES WHERE task_id = @ID", con);
                            string as_string = reader["assignees"].ToString();
                            reader.Close();
                            if (splitArray.Contains(0))
                                as_string = userId.ToString();
                            else
                                as_string += ","+userId.ToString();

                            cmd2.Parameters.AddWithValue("@ASSIGNEES", as_string);
                            cmd2.Parameters.AddWithValue("@ID", taskId);
                            
                            cmd2.ExecuteNonQuery();
                            
                            
                        }
                        
                    }
                   
                    else
                    {
                        MessageBox.Show("ERROR!!!!");
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public class User
        {
            public int AccountId { get; set; }
            public string UserName { get; set; }
            public int Role { get; set; }
            public string RoleName { get; set; }
            public string[] ProfileColor { get; set; }
        }

    }
}
