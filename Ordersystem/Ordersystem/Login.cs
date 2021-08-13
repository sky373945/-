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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        int index = 0;
        DataTable dt;
        DataSet ds;
        String curPeople;

        private void Login_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Breakfast.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter da = new SqlDataAdapter("SELECT 客戶名稱,電話,密碼 FROM 會員資料", cn);
            ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            textBoxPassword.PasswordChar = '*';
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(textBoxPhone.Text != "" && textBoxPassword.Text != "")
            {
                try
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (textBoxPhone.Text == dt.Rows[i]["電話"].ToString() && textBoxPassword.Text == dt.Rows[i]["密碼"].ToString())
                        {
                            curPeople = dt.Rows[i]["客戶名稱"].ToString();
                            StartOrder startOrder = new StartOrder();
                            startOrder.Show();
                            index = 0;
                            MessageBox.Show("顧客"+curPeople + "歡迎","登入成功");
                        }
                        else
                            index++;
                    }
                    if (index >= dt.Rows.Count)
                    {
                        MessageBox.Show("資料尚未註冊","提醒");
                    }

                }
                catch
                {
                    MessageBox.Show("資料錯誤","警告");
                }
            }
            else
                MessageBox.Show("資料輸入不能為空!","注意");
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            Member member = new Member();
            member.Show();
        }

    }
}
