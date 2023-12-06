using System.Data;
using System.Data.SqlClient;

namespace SQLConnectionExample
{
    public class Program
    {
        static void Main()
        {
            Program.Connection();
        }

        static void Connection()
        {
            string cs = "Data Source=localhost;Initial Catalog=TestDB;Persist Security Info=True;User ID=sa;Password=P@ssw0rd!;";

            SqlConnection con = null;
            try
            {
                using (con = new SqlConnection(cs))
                {
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        Console.WriteLine("Connection has been established.\n");

                        string queryPrcdr = "SpGetEpmloyees";
                        SqlCommand cmdPrcdr = new SqlCommand(queryPrcdr, con);
                        cmdPrcdr.CommandType = CommandType.StoredProcedure;
                        SqlDataReader prcdr = cmdPrcdr.ExecuteReader();

                        while (prcdr.Read())
                        {
                            Console.WriteLine("Id= " + prcdr[0] + "||Name= " + prcdr[1].ToString().Trim() +
                             "||Gender= " + prcdr[2].ToString().Trim() + "||Age= " + prcdr[3].ToString().Trim() +
                                "||Salary= " + prcdr[4].ToString().Trim() + "||City= " + prcdr[5].ToString().Trim() + "\n");
                        }

                        /*
                            Console.Write("Employee Id: ");
                            int id = int.Parse(Console.ReadLine());
                            Console.Write("Employee Name: ");
                            string name = Console.ReadLine();
                            Console.Write("Employee Gender: ");
                            string gender = Console.ReadLine();
                            Console.Write("Employee Age: ");
                            string age = Console.ReadLine();
                            Console.Write("Employee Salary: ");
                            string salary = Console.ReadLine();
                            Console.Write("Employee City: ");
                            string city = Console.ReadLine();

                            string query2 = $"insert into Employee values(@id,@name,@gender,@age,@salary,@city)";

                            SqlCommand cmd2 = new SqlCommand(query2, con);
                            cmd2.Parameters.AddWithValue("@id", id);
                            cmd2.Parameters.AddWithValue("@name", name);
                            cmd2.Parameters.AddWithValue("@gender", gender);
                            cmd2.Parameters.AddWithValue("@age", age);
                            cmd2.Parameters.AddWithValue("@salary", salary);
                            cmd2.Parameters.AddWithValue("@city", city);


                            cmd2.ExecuteNonQuery();
                        */

                        /*
                        string query = "select * from Employee";
                        SqlCommand cmd = new SqlCommand(query, con);
                        SqlDataReader dr = cmd.ExecuteReader();


                        while (dr.Read())
                        {
                            Console.WriteLine("Id= " + dr[0] + "||Name= " + dr[1].ToString().Trim() +
                             "||Gender= " + dr[2].ToString().Trim() + "||Age= " + dr[3].ToString().Trim() +
                                "||Salary= " + dr[4].ToString().Trim() + "||City= " + dr[5].ToString().Trim() + "\n");
                        }
                        */

                        //while (dr.Read())
                        //{
                        //    Console.WriteLine("Id= " + dr["id"] + "||Name= " + dr["name"].ToString().Trim() +
                        //     "||Gender= " + dr["Gender"].ToString().Trim() + "||Age= " + dr["Age"].ToString().Trim() +
                        //        "||Salary= " + dr["Salary"].ToString().Trim() + "||City= " + dr["City"].ToString().Trim() + "\n");
                        //}

                        //query = "select max(Salary) from Employee";
                        //cmd = new SqlCommand(query, con);
                        //string a = (string)cmd.ExecuteScalar();
                        //Console.WriteLine(a);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection Error.");
                Console.WriteLine(ex.Message);
            }
            finally { con.Close(); }

            /*
              SqlConnection con = new SqlConnection(cs);
              try
              {
                  con.Open();
                  if (con.State == ConnectionState.Open)
                  {
                      Console.WriteLine("Connection has been established.");
                  }
              }
              catch (Exception ex)
              {
                  Console.WriteLine("Connection Error.");
                  Console.WriteLine(ex.Message);
              }
              finally { con.Close(); }
             */

        }
    }
}