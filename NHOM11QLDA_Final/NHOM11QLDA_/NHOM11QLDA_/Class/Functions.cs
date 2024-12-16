using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NHOM11QLDA_.Class
{
    internal class Functions
    {
        public static SqlConnection Conn;
        public static string connString;
        public static void Connect()
        {
            connString = "Data Source=PHI-HUNG;Initial Catalog=QLDAProject;Integrated Security=True;Encrypt=False";
            Conn = new SqlConnection();
            Conn.ConnectionString = connString;
            Conn.Open();
        }
        public static void Disconnect()
        {
            if(Conn.State==ConnectionState.Open)
            {
                Conn.Close();
                Conn.Dispose();
                Conn = null;
            }
        }
        public static void Navigate(Form currentForm, Form targetForm)
        {
            if (currentForm.GetType().Name == "Trangchu")
            {
                targetForm.Show();
            }
            else
            {
                targetForm.Show();
                currentForm.Close();
            }
        }
        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(sql,Functions.Conn);
            DataTable table=new DataTable();
            Mydata.Fill(table);
            return table;
        }

        public static string GetFieldValue(string sql)
        {
            string ma = "";
            SqlCommand cmd=new SqlCommand(sql, Functions.Conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ma = reader.GetValue(0).ToString();
            }
            reader.Close();
            return ma;
        }

        public static bool Checkey(string sql)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, Functions.Conn);
            DataTable table=new DataTable();
            Mydata.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public static void FillCombo(string sql, ComboBox cbo, string tt)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, Functions.Conn);
            DataTable table=new DataTable();
            Mydata.Fill(table);
            cbo.DataSource= table;
            cbo.DisplayMember = tt;
        }

        public static void RunSql(string sql)
        {
            SqlCommand cmd= new SqlCommand();
            cmd.Connection = Functions.Conn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }

        public static string ConvertToDatetime(string d)
        {
            string[] parts = d.Split('/');
            string dt = String.Format("{0}/{1}/{2}", parts[2], parts[1], parts[0]);
            return dt;
        }

        public static string ConvertToTime(string t)
        {
            try
            {
                // Kiểm tra và chuyển đổi định dạng hh:mm:ss thành datetime
                DateTime time;
                if (DateTime.TryParseExact(t, "HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out time))
                {
                    // Lấy ngày hiện tại và kết hợp với giờ từ form
                    DateTime datetime = DateTime.Today.Add(time.TimeOfDay);
                    return datetime.ToString("yyyy-MM-dd HH:mm:ss"); // Trả về định dạng phù hợp với CSDL
                }
                else
                {
                    throw new FormatException("Định dạng giờ không hợp lệ. Vui lòng nhập theo định dạng hh:mm:ss.");
                }
            }
            catch (Exception ex)
            {
                throw new FormatException("Lỗi khi chuyển đổi giờ: " + ex.Message);
            }
        }
    }
}
