using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ADOConsoleApp.Models;
using System.Data.Common;
using System.Security.Cryptography;

namespace ADOConsoleApp.Services
{
    internal class BykeStoresDAL
    {
        public SqlConnection Conn = null;
        public SqlCommand Cmd = null;
        public SqlDataReader Rd = null;
        public string ConnStr;
        public Staff stf;

        public BykeStoresDAL(string str)
        {
            ConnStr = str;
        }

        public void GetInput()
        {
            stf = new Staff();
            Console.WriteLine("Enter staff details:");
            //Console.Write("Enter Staff Id: ");
            //stf.Staff_id = int.Parse(Console.ReadLine());
            Console.Write("Enter First Name: ");
            stf.First_name = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            stf.Last_name = Console.ReadLine();
            Console.Write("Enter Email: ");
            stf.Email = Console.ReadLine();
            Console.Write("Enter Phone: ");
            stf.Phone = Console.ReadLine();
            Console.Write("Enter Active: ");
            stf.Active = int.Parse(Console.ReadLine());
            Console.Write("Enter Store Id: ");
            stf.Store_id = int.Parse(Console.ReadLine());
            Console.Write("Enter Manager ID: ");
            stf.Manager_id = int.Parse(Console.ReadLine());
        }
        public int InsertData()
        {
            int recordsAffected = 0;
            if (stf == null)
            {
                GetInput();
                try
                {
                    Conn = new SqlConnection(ConnStr);
                    if (Conn.State == ConnectionState.Closed)
                    {
                        Conn.Open();
                        Console.WriteLine("Inserting data...");
                        string cmdText = "Insert into sales.staffs(first_name, last_name, email, phone, active, store_id, manager_id) values(@first_name, @last_name, @email, @phone, @active, @store_id, @manager_id)";
                        using (Cmd = new SqlCommand(cmdText, Conn))
                        {
                            Cmd.CommandType = CommandType.Text;
                            Cmd.Parameters.AddWithValue("@first_name", stf.First_name);
                            Cmd.Parameters.AddWithValue("@last_name", stf.Last_name);
                            Cmd.Parameters.AddWithValue("@email", stf.Email);
                            Cmd.Parameters.AddWithValue("@phone", stf.Phone);
                            Cmd.Parameters.AddWithValue("@active", stf.Active);
                            Cmd.Parameters.AddWithValue("@store_id", stf.Store_id);
                            Cmd.Parameters.AddWithValue("@manager_id", stf.Manager_id);
                            recordsAffected = Cmd.ExecuteNonQuery();

                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Caught an exception: " + ex.Message);
                }
                finally
                {
                    stf = null;
                }
            }
            if(recordsAffected > 0)
            {
                Console.WriteLine("Successfully inserted " + recordsAffected + " records.");
            }
            return recordsAffected;
        }

        public int UpdateData()
        {
            int recordsAffected = 0;
            
                try
                {
                    Conn = new SqlConnection(ConnStr);
                    if (Conn.State == ConnectionState.Closed)
                    {
                        Conn.Open();
                        Console.WriteLine("Updating data...");
                        Console.WriteLine("Enter new mobile no");
                        string phone = Console.ReadLine();
                        string cmdText = "update sales.staffs set phone = " + phone + "where first_name = 'Sriii'";
                        using (Cmd = new SqlCommand(cmdText, Conn))
                        {
                            recordsAffected = Cmd.ExecuteNonQuery();

                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Caught an exception: " + ex.Message);
                }
                finally
                {
                    stf = null;
                }
            if (recordsAffected == 0)
                Console.WriteLine("No record updated");
            if (recordsAffected > 0)
            {
                Console.WriteLine("Successfully updated " + recordsAffected + " records.");
            }
            return recordsAffected;
        }
        public int DeleteData()
        {
            int recordsAffected = 0;

            try
            {
                Conn = new SqlConnection(ConnStr);
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                    Console.WriteLine("Deleting data...");
                    string phone = Console.ReadLine();
                    string cmdText = "delete from sales.staffs where first_name = 'Sri'";
                    using (Cmd = new SqlCommand(cmdText, Conn))
                    {
                        recordsAffected = Cmd.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught an exception: " + ex.Message);
            }
            finally
            {
                stf = null;
            }
            if (recordsAffected == 0)
                Console.WriteLine("No record deleted");
            if (recordsAffected > 0)
            {
                Console.WriteLine("Successfully deleted " + recordsAffected + " records.");
            }
            return recordsAffected;
        }
        //retrieving data into DataSet Object
        public void UseDataFill()
        {
            Conn = new SqlConnection(ConnStr);
            int i = 0;
            DataSet StaffDS = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter();
            try
            {
                if(Conn.State == ConnectionState.Closed)
                {
                    String QueryStr = @"select staff_id, first_name, last_name, email, phone, active, store_id, manager_id from sales.staffs";
                    using(Cmd = new SqlCommand(QueryStr, Conn))
                    {
                        Cmd.CommandTimeout = 60;
                        sda.SelectCommand = Cmd;
                        Conn.Open();
                        sda.Fill(StaffDS, "staffsDT");
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (Conn.State == ConnectionState.Open)
                    Conn.Close();
                Console.WriteLine("Finally block");
            }

            try
            {
                if(StaffDS != null)
                {
                    DataTable StaffsDataTable = StaffDS.Tables["staffsDT"];
                    IEnumerable<DataRow> query = from stf in StaffsDataTable.AsEnumerable() where stf.Field<Int32>("staff_id") > 2 select stf;
                    Console.WriteLine("Staff Ids");
                    foreach(DataRow dr in query)
                    {
                        Console.WriteLine($"{dr.Field<Int32>("staff_id")}");
                    }

                    Console.WriteLine("Without Linq");
                    foreach (DataColumn col in StaffDS.Tables[0].Columns)
                        Console.Write(col.ColumnName + "\t");

                    Console.WriteLine("\n");
                    foreach(DataRow row in StaffDS.Tables["staffsDT"].Rows)
                    {
                        Console.Write(row["staff_id"] + "\t\t");
                        Console.Write(row["first_name"] + "\t\t");
                        Console.Write(row["last_name"] + "\t\t");
                        Console.Write(row["email"] + "\t\t");
                        Console.Write(row["phone"] + "\t\t");
                        Console.Write(row["active"] + "\t\t");
                        Console.Write(row["store_id"] + "\t\t");
                        Console.Write(row["manager_id"] + "\t\t");
                        Console.WriteLine();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void UpdateDS()
        {
            DataSet StaffDS = new DataSet();
            SqlConnection Conn = new SqlConnection(ConnStr);
            SqlDataAdapter sda = new SqlDataAdapter();
            try
            {
                if (Conn.State == ConnectionState.Closed)
                {
                    
                    String QueryStr = @"select staff_id, first_name, last_name, email, phone, active, store_id, manager_id from sales.staffs";
                    using (Cmd = new SqlCommand(QueryStr, Conn))
                    {
                        Cmd.CommandTimeout = 60;
                        sda.SelectCommand = Cmd;
                        Conn.Open();
                        sda.Fill(StaffDS, "staffsDT");
                        Console.WriteLine("Filled");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            string staff_email;
            //update specific records
            foreach(DataRow dr in StaffDS.Tables["staffsDT"].Rows)
            {
                if (dr["email"].ToString().Length == 0)
                {
                    Console.WriteLine($"Enter the email for {dr["first_name"]} {dr["last_name"]}");
                    dr["email"] = Console.ReadLine();
                }
            }

            if (StaffDS.HasChanges())
            {

                try
                {
                    SqlDataAdapter adap = new SqlDataAdapter();
                    DataSet tempDS;
                   
                    string updateCmd = @"update sales.staffs set email = @staff_email where staff_id = @SID";
                    adap.UpdateCommand = new SqlCommand(updateCmd, Conn);
                    Conn = new SqlConnection(ConnStr);
                    Conn.Open();
                    tempDS = StaffDS.GetChanges(DataRowState.Modified | DataRowState.Added);
                    adap.UpdateCommand.Parameters.Add("@staff_email", SqlDbType.NVarChar, 30, "email");
                    SqlParameter sparam = adap.UpdateCommand.Parameters.Add("@SID", SqlDbType.Int);
                    sparam.SourceColumn = "staff_id";
                    sparam.SourceVersion = DataRowVersion.Original;
                    int result = adap.Update(tempDS, "staffsDT");
                    Console.WriteLine(result + " records updated");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    if (Conn.State == ConnectionState.Open)
                        Conn.Close();

                }
                
            }


            
        }
        public void InsertIntoDS(DataSet StaffDS)
        {
            SqlConnection Conn = new SqlConnection(ConnStr);
            if (StaffDS == null)
            {
                Console.WriteLine("DataSet is null.");
            }
            if (!StaffDS.Tables.Contains("staffsDT"))
            {
                Console.WriteLine("Table 'staffsDT' was not found in the DataSet.");
            }

            
            try
            {
                //UpdateData all records
                DataRow drow = StaffDS.Tables["staffsDT"].NewRow();
                Console.WriteLine("Enter data for new staff: ");
                Console.Write("Enter First Name: ");
                drow["first_name"] = Console.ReadLine();
                Console.Write("Enter Last Name: ");
                drow["last_name"] = Console.ReadLine();
                Console.Write("Enter Email: ");
                drow["email"] = Console.ReadLine();
                Console.Write("Enter Phone: ");
                drow["phone"] = Console.ReadLine();
                Console.Write("Enter Active: ");
                drow["active"] = int.Parse(Console.ReadLine());
                Console.Write("Enter Store Id: ");
                drow["store_id"] = int.Parse(Console.ReadLine());
                Console.Write("Enter Manager ID: ");
                drow["manager_id"] = int.Parse(Console.ReadLine());

                StaffDS.Tables["staffsDT"].Rows.Add(drow);
                if (StaffDS.HasChanges())
                {

                    try
                    {
                        SqlDataAdapter adap = new SqlDataAdapter();
                        DataSet tempDS;

                        string InsertDR = @"insert into sales.staffs(first_name, last_name, phone, email, active, store_id, manager_id) values(@sfn, @sln, @sphn, @semail, @sactive, @sstoreid, @smanagerid)";
                        adap.InsertCommand = new SqlCommand(InsertDR, Conn);
                        Conn = new SqlConnection(ConnStr);
                        if(Conn.State == ConnectionState.Closed)
                        Conn.Open();
                        tempDS = StaffDS.GetChanges(DataRowState.Added);
                        adap.InsertCommand.Parameters.Add("@sfn", SqlDbType.NVarChar, 50, "first_name");
                        adap.InsertCommand.Parameters.Add("@sln", SqlDbType.NVarChar, 50, "last_name");
                        adap.InsertCommand.Parameters.Add("@sphn", SqlDbType.NVarChar, 30, "phone");
                        adap.InsertCommand.Parameters.Add("@semail", SqlDbType.NVarChar, 30, "email");
                        adap.InsertCommand.Parameters.Add("@sactive", SqlDbType.Int ,25, "active");
                        adap.InsertCommand.Parameters.Add("@sstoreid", SqlDbType.Int, 30, "store_id");
                        adap.InsertCommand.Parameters.Add("@smanagerid", SqlDbType.Int, 30, "manager_id");
                        SqlParameter sparam = adap.InsertCommand.Parameters.Add("@SID", SqlDbType.Int);
                        sparam.SourceColumn = "staff_id";
                        sparam.SourceVersion = DataRowVersion.Original;
                        int result = adap.Update(tempDS, "staffsDT");
                        Console.WriteLine(result + " records updated");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                    finally
                    {
                        if (Conn.State == ConnectionState.Open)
                            Conn.Close();

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                if (Conn.State == ConnectionState.Open)
                    Conn.Close();
            }
        }
    }
}
