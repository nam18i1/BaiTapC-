using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyNV
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FilldataGird();
        }
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter da;
        DataSet ds;
        public void ConnectDB()
        {
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-SFCSD63\SQLEXPRESS;Initial Catalog=QuanLyNV;Integrated Security=SSPI");
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void FilldataGird()
        {
            try
            {
                ConnectDB();
                da = new SqlDataAdapter("select * from NopBT ", conn);
                ds = new DataSet();
                da.Fill(ds);
                show.ItemsSource = ds.Tables[0].DefaultView;
                show.DisplayMemberPath = "CustomerID";
                show.SelectedValuePath = "ComparyName";
                conn.Close();
                da.Dispose();
                ds.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void TxbAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                ConnectDB();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Insert into NopBT values(@CustomerID,@ComparyName,@ContactName,@ContactTitle,@Address,@City,@Region,@PostaCode,@Country,@Phone,@Fax)";
                cmd.Parameters.Add("@CustomerID", SqlDbType.NVarChar).Value = txtid.Text;
                cmd.Parameters.Add("@ComparyName", SqlDbType.NVarChar).Value = txtCompary.Text;
                cmd.Parameters.Add("@ContactName", SqlDbType.NVarChar).Value = txtContactName.Text;
                cmd.Parameters.Add("@ContactTitle", SqlDbType.NVarChar).Value = txtContactTitle.Text;
                cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = txtAddress.Text;
                cmd.Parameters.Add("@City", SqlDbType.NVarChar).Value = txtCity.Text;
                cmd.Parameters.Add("@Region", SqlDbType.NVarChar).Value = txtRegion.Text;
                cmd.Parameters.Add("@PostaCode", SqlDbType.VarChar).Value = txtCode.Text;
                cmd.Parameters.Add("@Country", SqlDbType.NVarChar).Value = txtCountry.Text;
                cmd.Parameters.Add("@Phone", SqlDbType.VarChar).Value = txtPhone.Text;
                cmd.Parameters.Add("@Fax", SqlDbType.VarChar).Value = txtFax.Text;
                int n = cmd.ExecuteNonQuery();
                if (n > 0) MessageBox.Show("Success");
                else MessageBox.Show("Fail");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void TxbDelete_Click(object sender, RoutedEventArgs e)
        {
            ConnectDB();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Delete from NopBT where CustomerID = '" + txtid.Text + "'";
            int n = cmd.ExecuteNonQuery();
            if (n > 0) MessageBox.Show("Success");
            else MessageBox.Show("Fail");
        }

        private void Txbload_Click(object sender, RoutedEventArgs e)
        {
            ConnectDB();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            var load = new MainWindow();
            load.Show();
            this.Hide();
        }
    }
}

