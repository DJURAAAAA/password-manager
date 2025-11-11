using System.Data;
using System.Data.Common;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
namespace PassWordManager
{
    public partial class MainWindow : Form
    {
        public static string token, name , normalText = "";
        public MainWindow(string loggedToken, string userName)
        {
            if (loggedToken != "" && userName != "")
            {
                token = loggedToken;
                name = userName;
            }
            else
            {
                token = "";
                name = "";
            }

            InitializeComponent();
        }
        public MainWindow()
        {

            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"data source=DESKTOP-IHED08N\SQLEXPRESS;initial catalog=users;trusted_connection=true;TrustServerCertificate=True");
        SqlDataAdapter rd = null;
        void welcomeUser()
        {
            if (name != "")
            {
                userNameLBL.Text = $"Hello, {name} !";
            }
            else
            {
                userNameLBL.Text = "Hello, Guest !";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            welcomeUser();
        }

        private void log_inBTN_Click(object sender, EventArgs e)
        {
            createAccountFORM create = new createAccountFORM();
            create.ShowDialog();
        }

        private void addPasswordBTN_Click(object sender, EventArgs e)
        {
            if (token != "" && name != "")
            {
                addPass_WINDOW add = new addPass_WINDOW(token);
                add.ShowDialog();
            }
            else
            {
                MessageBox.Show("U must log in first !");
            }

        }

        private void log_outBTN_Click(object sender, EventArgs e)
        {
            token = "";
            name = "";
            welcomeUser();
            MessageBox.Show("Succesfully loged out !");
        }

        private void favoritesBTN_Click(object sender, EventArgs e)
        {
            if (token != "" && name != "")
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("GetUserApplications", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserToken", token);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            showPassVIEW.Items.Clear();


                            if (showPassVIEW.Columns.Count == 0)
                            {
                                showPassVIEW.View = View.Details;
                                showPassVIEW.Columns.Add("App Name", 150);
                                showPassVIEW.Columns.Add("App Password", 150);
                                showPassVIEW.Columns.Add("Gmail", 200);
                            }

                            while (reader.Read())
                            {
                                string appName = reader["appName"].ToString();
                                string appPassword = reader["appPassword"].ToString();
                                string gmail = reader["gmail"].ToString();

                                ListViewItem item = new ListViewItem(appName);
                                item.SubItems.Add(appPassword);
                                item.SubItems.Add(gmail);

                                showPassVIEW.Items.Add(item);
                            }
                        }
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("U must log in first !");
            }

        }

        private void showPassVIEW_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (showPassVIEW.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = showPassVIEW.SelectedItems[0];

                string appName = selectedItem.SubItems[0].Text;
                string appPassword = selectedItem.SubItems[1].Text;
                string gmail = selectedItem.SubItems[2].Text;
                normalText = appPassword;
                userGmailLBL.Text = gmail;
                userPassLBL.Tag = normalText;
                userPassLBL.Text = appPassword;
            }
        }

        private void showBTN_Click(object sender, EventArgs e)
        {

            string realPassword = userPassLBL.Tag.ToString();

            
            if (userPassLBL.Text.Contains("*"))
            {
                userPassLBL.Text = realPassword;
            }
            else
            {
                userPassLBL.Text = new string('*', realPassword.Length);
            }
        }
    }
}
