using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassWordManager
{
    public partial class addPass_WINDOW : Form
    {
        public addPass_WINDOW()
        {
            InitializeComponent();
        }
        public addPass_WINDOW(string userTOKEN)
        {
            token = userTOKEN;
            InitializeComponent();
        }
        public static string selectedApp, userGmail, passwordApp , token = "";
        SqlConnection conn = new SqlConnection(@"data source=DESKTOP-IHED08N\SQLEXPRESS;initial catalog=users;trusted_connection=true;TrustServerCertificate=True");
        private void addPass_WINDOW_Load(object sender, EventArgs e)
        {

        }
        bool checkValidation()
        {
            return userGmailTXT.Text != "" && passTXT.Text != "" && selectedApp != "";
        }
        void add_aplication()
        {
            if (checkValidation() && token != "")
            {
                userGmail = userGmailTXT.Text;
                passwordApp = passTXT.Text;
                conn.Open();

                
                using (SqlCommand cmd = new SqlCommand(@"
    INSERT INTO applications (gmail, appName, appPassword) 
    VALUES (@gmail, @name, @pass);
    SELECT SCOPE_IDENTITY();", conn))
                {
                    cmd.Parameters.AddWithValue("@gmail", userGmail);
                    cmd.Parameters.AddWithValue("@name", selectedApp);
                    cmd.Parameters.AddWithValue("@pass", passwordApp);

                    int newAppID = Convert.ToInt32(cmd.ExecuteScalar()); 
                    MessageBox.Show("App added successfully!");

                    
                    using (SqlCommand cmd2 = new SqlCommand(
                        "INSERT INTO userApplications (userToken, applicationId) VALUES (@token, @id)", conn))
                    {
                        cmd2.Parameters.AddWithValue("@token", token);
                        cmd2.Parameters.AddWithValue("@id", newAppID);
                        cmd2.ExecuteNonQuery(); 
                    }
                }

                conn.Close();
                
            }
            else
            {
                MessageBox.Show("All placeholders must be filled !");
            }
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedApp = comboApp.SelectedItem.ToString();
        }
        string shufflePassword(string s)
        {
            return new string(s.ToCharArray().OrderBy(x => Guid.NewGuid()).ToArray());
        }
        private void autoGenerateBTN_Click(object sender, EventArgs e)
        {
            string randText = "qwertyuiop[]\asdfghjkl;'zxcvbnm,.1234567890-=";
            if (passwordApp != randText)
            {
                passwordApp = shufflePassword(randText).Substring(0, 9);
            }
            
            
        }

        private void addPassBTN_Click(object sender, EventArgs e)
        {
            add_aplication();
        }
    }
}
