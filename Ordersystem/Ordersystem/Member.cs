using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ordersystem
{
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();
        }

        String cnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Breakfast.mdf;Integrated Security=True;Connect Timeout=30";

        private void Member_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(cnStr);
            SqlDataAdapter da = new SqlDataAdapter("SELECT*From 會員資料", cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            textBoxName.Text = textBoxPhone.Text = textBoxPassword.Text = "";
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxName.Text != "" && textBoxPhone.Text != "" && textBoxPassword.Text != "")
                {
                    SqlConnection cn = new SqlConnection(cnStr);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "INSERT INTO 會員資料(客戶名稱,電話,密碼)VALUES(@People,@PhoneNum,@Password)";
                    cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@People", SqlDbType.NVarChar)).Value = textBoxName.Text;
                    cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@PhoneNum", SqlDbType.NVarChar)).Value = textBoxPhone.Text;
                    cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Password", SqlDbType.NVarChar)).Value = textBoxPassword.Text;

                    cmd.Connection = cn;
                    cmd.ExecuteNonQuery();
                    Member_Load(sender, e);

                    MessageBox.Show("註冊成功", "恭喜");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("有欄位資料尚未填寫", "提醒");
                }
                    

            }
            catch(Exception ex)
            {
                MessageBox.Show("新增失敗");
            }
            

        }
    }
}
