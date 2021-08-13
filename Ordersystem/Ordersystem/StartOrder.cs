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
    public partial class StartOrder : Form
    {

        public StartOrder()
        {
            InitializeComponent();
        }

        string cnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Breakfast.mdf;Integrated Security=True;Connect Timeout=30";
        string orderName;
        string needMark;
        string iceCube;
        string drinkCup;
        string orderClass;
        string addMoney="";
        int price;
        int number;
        int subTotal;
        DataTable GetTable(string Sqlcmd)
        {
            SqlConnection cn = new SqlConnection(cnStr);
            SqlDataAdapter da = new SqlDataAdapter(Sqlcmd, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        private void StartOrder_Load(object sender, EventArgs e)
        {
            dataGridViewMenu.DataSource = GetTable("SELECT 品名,類別,單價 FROM 早餐菜單");
            dataGridViewMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            textBoxTotal.Text = "0";
        }

        private void dataGridViewMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewMenu.Rows[e.RowIndex].Cells[0].Value == null)
                return;
            NameBtn.Text = dataGridViewMenu.Rows[e.RowIndex].Cells[0].Value.ToString();
            orderClass = dataGridViewMenu.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxPrice.Text = dataGridViewMenu.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxMark.Text = "";
            radioBtnIce.Checked = false;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (NameBtn.Text !=null && NumUpDown.Value != 0)
            {
                IntegrateOrderList();
                dataGridViewOrder.Rows.Add(new Object[] { orderName, orderClass, needMark, price, number, addMoney, subTotal });
                dataGridViewOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                LableOrderList.Text += $"{orderName} {needMark} {price}*{number} {addMoney} ={subTotal} \r\n";
                calculateTotal();
            }
            radioBtnBig.Checked = false;
            radioBtnHot.Checked = false;
            radioBtnIce.Checked = false;
            radioBtnMiddle.Checked = false;
            radioBtnWarm.Checked = false;
            
        }
        private void calculateTotal()
        {
            int total=0;
            for (int i = 0; i < dataGridViewOrder.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridViewOrder.Rows[i];
                if (row.Cells[0].Value != null)
                    total += (int)row.Cells[6].Value;
            }
            textBoxTotal.Text = total.ToString();
        }
        private void IntegrateOrderList()
        {
            orderName = NameBtn.Text;
            price = int.Parse(textBoxPrice.Text);
            number = (int)NumUpDown.Value;
            subTotal = price * number;

            if(orderClass == "飲品")
            {
                iceCube = radioBtnIce.Checked ? "冰" : radioBtnWarm.Checked ? "溫" : "熱";
                drinkCup = radioBtnMiddle.Checked == true ? "升級中杯" : "升級大杯";
                if (drinkCup == "升級中杯")
                {
                    subTotal += 5*number;
                    addMoney = $"+{5 * number}";
                }
                else if (drinkCup == "升級大杯")
                {
                    subTotal += 10 * number;
                    addMoney = $"+{10 * number}";
                }
                    

                needMark = $"{iceCube} {drinkCup} {textBoxMark.Text}";
            }
            else
            {
                iceCube = "";
                drinkCup = "";
                needMark =textBoxMark.Text;
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (LableOrderList.Text != "")
            {
                MessageBox.Show("訂購成功", "恭喜");
                this.Close();
            }
            else
                MessageBox.Show("尚未點選餐點!", "提醒");
           
        }

    }
}
