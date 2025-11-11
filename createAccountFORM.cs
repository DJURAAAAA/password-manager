using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
namespace PassWordManager
{
    public partial class createAccountFORM : Form
    {
        public createAccountFORM()
        {
            InitializeComponent();
        }
        public static Random rand = new Random();
        public static string nameLog, passLog, nameRegister, passRegister, passRegisterAGAIN = "";
        SqlConnection conn = new SqlConnection(@"data source=DESKTOP-IHED08N\SQLEXPRESS;initial catalog=users;trusted_connection=true;TrustServerCertificate=True");
        SqlDataAdapter rd = null;
        private void createAccountFORM_Load(object sender, EventArgs e)
        {

        }
        bool checkValidationLOG()
        {
            return nameLOG_TXT.Text != "" && passLOG_TXT.Text != "";
        }
        bool checkValidationREG()
        {
            return nameRegister_TXT.Text != "" && passRegister_TXT.Text != "" && passRegister_TXTagain.Text != "";
        }
        string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }
        private void finishLOG_BTN_Click(object sender, EventArgs e)
        {
            if (checkValidationLOG())
            {
                nameLog = nameLOG_TXT.Text;
                passLog = passLOG_TXT.Text;
                string hashedPass = HashPassword(passLog);

                conn.Open();
                SqlCommand cmd = new SqlCommand("existUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nameUser", nameLog);
                cmd.Parameters.AddWithValue("@pass", hashedPass);
                object result = cmd.ExecuteScalar();
                conn.Close();

                if (result != null)
                {
                    string token = result.ToString();
                    MessageBox.Show("User is logged in!");
                    MainWindow main = new MainWindow(token, nameLog);
                    main.ShowDialog();
                    nameLOG_TXT.Text = "";
                    passLOG_TXT.Text = "";
                }
                else
                {
                    MessageBox.Show("Invalid username or password!");
                }
            }
            else
            {
                MessageBox.Show("All placeholders must be filled!");
            }



        }

        private void finishRegister_BTN_Click(object sender, EventArgs e)
        {

            if (checkValidationREG())
            {
                nameRegister = nameRegister_TXT.Text;
                passRegister = passRegister_TXT.Text;
                passRegisterAGAIN = passRegister_TXTagain.Text;

                if (passRegister == passRegisterAGAIN)
                {
                    long randomToken = rand.NextInt64(1000000000, 9999999999);
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO userInformations(name, password, token) VALUES(@name, @pass, @randToken)", conn))
                    {
                        cmd.Parameters.AddWithValue("@name", nameRegister);
                        string hashedPass = HashPassword(passRegister);
                        cmd.Parameters.AddWithValue("@pass", hashedPass);
                        cmd.Parameters.AddWithValue("@randToken", randomToken.ToString());

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        passRegister_TXT.Text = "";
                        passRegister_TXTagain.Text = "";
                        nameRegister_TXT.Text = "";
                    }
                    MessageBox.Show("User registered successfully!");
                }
                else
                {
                    MessageBox.Show("Password must be same!");
                }
            }
            else
            {
                MessageBox.Show("All placeholders must be filled!");
            }


        }
    }
}
