using ADOConsoleApp.Services;
using Microsoft.Extensions.Configuration;
using ADOConsoleApp.Models;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Xml.Linq;
namespace ADOConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            IConfiguration config = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                                    .Build();

            string connectionstring = config.GetConnectionString("BikeCon");

            MyData md = new MyData(connectionstring);
            //md.GetCustomers("select * from sales.customers where city = 'New York'");
            //md.GetCustomers("" + "select first_name, last_name, phone, email from sales.staffs;" + "select first_name, last_name, phone, email from sales.customers;");
            //md.MultipleSelects("" + "select first_name, last_name, phone, email from sales.staffs where first_name like 'F%';" + "select first_name, last_name,  email from sales.customers where first_name like 'F%';");

            BykeStoresDAL bks = new BykeStoresDAL(connectionstring);
            //bks.InsertData();
            //bks.UpdateData();
            //bks.DeleteData();
            //bks.UseDataFill();
            //bks.UpdateDS();
            var staffDS = new DataSet();
            using (var conn = new SqlConnection(connectionstring))
            using (var da = new SqlDataAdapter(
                @"select staff_id, first_name, last_name, email, phone, active, store_id, manager_id 
                  from sales.staffs", conn))
            {
                conn.Open();
                da.Fill(staffDS, "staffsDT"); // table name must match what InsertIntoDS expects
            }

            // Pass the DataSet to your method
            bks.InsertIntoDS(staffDS);
        }
    }
}
