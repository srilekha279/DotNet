using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOConsoleApp
{
    public class MyData
    {
        public SqlConnection _Con = null;
        public SqlCommand _cmd = null;
        public SqlDataReader rd = null;
        public string _ConStr;

        public MyData(string str)
        {
            _ConStr = str;
        }
        public void GetCustomers(string cmdText)
        {
            _Con = new SqlConnection(_ConStr);
            _cmd = new SqlCommand(cmdText, _Con);
            try
            {
                if(_Con.State == ConnectionState.Closed)
                {
                    _Con.Open();
                    Console.WriteLine($"Connection properties:");
                    Console.WriteLine($"DB: {_Con.Database}");
                    Console.WriteLine($"Cmd TimeOut: {_Con.CommandTimeout}");
                    Console.WriteLine($"CS: {_Con.ConnectionString}");
                    Console.WriteLine($"State: {_Con.State}");
                    Console.WriteLine($"Server Version: {_Con.ServerVersion}");
                    Console.WriteLine($"Data Source: {_Con.DataSource}");

                    Console.WriteLine($"Command properties: ");
                    Console.WriteLine($"Command text: {_cmd.CommandText}");
                    Console.WriteLine($"Command type: {_cmd.CommandType}");
                    Console.WriteLine($"Connection: {_cmd.Connection}");

                    using(rd = _cmd.ExecuteReader())
                    {
                        Console.Write(rd.GetName(0) + " " + rd.GetName(1) + "\n");
                        while (rd.Read())
                        {
                            Console.Write(rd[0] + " " + rd[1] + "\n");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Caught an exception: " + ex.Message);
            }
            finally
            {
                if(_Con.State == ConnectionState.Open)
                    _Con.Close();
                Console.WriteLine("Finally block");
            }
        }

        public void MultipleSelects(string cmdText)
        {
            _Con = new SqlConnection(_ConStr);
            _cmd = new SqlCommand(cmdText, _Con);
            try
            {
                if (_Con.State == ConnectionState.Closed)
                {
                    _Con.Open();

                    using (rd = _cmd.ExecuteReader())
                    {
                        Console.Write(rd.GetName(0) + " " + rd.GetName(1) + " " + rd.GetName(2) + " " + rd.GetName(3) + "\n");
                        do
                        {
                            while (rd.Read())
                            {
                                Console.Write(rd[0] + " " + rd[1] + " " + rd[2] + " " + rd[3] +"\n");
                            }
                        } while (rd.NextResult());
                       
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught an exception: " + ex.Message);
            }
            finally
            {
                if (_Con.State == ConnectionState.Open)
                    _Con.Close();
                Console.WriteLine("Finally block");
            }
        }
        
    }
}
