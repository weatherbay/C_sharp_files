using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Creation1
{
    public class Database

    {
        //connection variable to the database
        public SqlConnection MyConnection, MyConnection1;

        
        


        //connection parameters
        public string connectionstrings;

        //global command for initializing sql command

        public SqlCommand globalcommand, globalcommand1;


        //sqladapter

        public SqlDataAdapter sqladapter1;
        
        //sql string commands

        public String insertcommand;
        public String updatecommand;
        public String deletecommand;
        public String readcommand;
        public String readall;


        //data reader command
        public SqlDataReader dataReader, dataReader1;
         

        //connection mtd to be called

        public void Set_Connection_Parameter()
        {
            connectionstrings = @"Data Source=WIN-BEHF8SQE8DC;Database=C#Connect;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=true";

        }


        //insert user data method
        public void InsertData(string username, string id)
        {

            insertcommand = "Insert into registration (username,id)" + "values(@username, @id)";

            //establish sql connection
            MyConnection = new SqlConnection(connectionstrings);
            MyConnection.Open();

            //sqladapter is the method to insert, delete, update data in c#
            SqlDataAdapter adapter = new SqlDataAdapter();


            //initiate sql command
            globalcommand = new SqlCommand(insertcommand, MyConnection);

            //call insert argumnets to parameters
            globalcommand.Parameters.Add("@username",System.Data.SqlDbType.VarChar,50).Value = username;
            globalcommand.Parameters.Add("@id", System.Data.SqlDbType.VarChar, 10).Value = id;

            adapter.InsertCommand = globalcommand;
            adapter.InsertCommand.ExecuteNonQuery();
            globalcommand.Dispose();
            MyConnection.Close();

        }



        //user read method
        public void ReadDatabaseInput(string id)
        {
            
            //establish sql connection to database
            MyConnection = new SqlConnection(connectionstrings);

           MyConnection.Open();
            
            
            

            

            //read command by user id
            readcommand = "select id,username from registration where id =@id";
            
            
            globalcommand = new SqlCommand(readcommand, MyConnection);
            

            globalcommand.Parameters.Add("@id", System.Data.SqlDbType.VarChar, 10).Value = id;
            

            //call datareader in form

            dataReader = globalcommand.ExecuteReader();
            globalcommand.Dispose();
            MyConnection.Close();
        }



        //user read method
        public void ReadDatabase()
        {

            //establish sql connection to database
            MyConnection1 = new SqlConnection(connectionstrings);
            MyConnection1.Open();
            


            //read all command
            readall = "select id,username from registration";

            //global command for read all
            globalcommand1 = new SqlCommand(readall, MyConnection1);
            
            //datareader for readall
            dataReader1 = globalcommand1.ExecuteReader();
            

            //sqladapter for readall command
            sqladapter1 = new SqlDataAdapter(readall, MyConnection1);
            globalcommand1.Dispose();
            //MyConnection1.Close();





        }



    }
}
