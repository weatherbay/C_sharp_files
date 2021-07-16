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
        public SqlConnection MyConnection;

        //tobisql connection
        public SqlConnection tobisqlconnection;
        


        //connection parameters
        public string connectionstrings;

        //global command for initializing sql command

        public SqlCommand globalcommand;


        //sqladapter

        public SqlDataAdapter sqladapter;
        
        //sql string commands

        public String insertcommand;
        public String updatecommand;
        public String deletecommand;
        public String readcommand;
        public String readall;


        //data reader command
        public SqlDataReader dataReader;
         

        //connection mtd to be called

        public void Set_Connection_Parameter()
        {
            connectionstrings = @"Data Source=WIN-BEHF8SQE8DC;Database=C#Connect;Integrated Security=True;Connect Timeout=30";

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
            tobisqlconnection = new SqlConnection(connectionstrings);
           MyConnection.Open();
            //tobisqlconnection.Open();
            
            //show msgbox for connection in form


            //sqldatareader is used to read data from database in c#

            

            //read command by user id
            readcommand = "select id,username from registration where id =@id";
            readall = "select id,username from registration";
            //readcommand1 = "select id,username from registration where id =@id";
            globalcommand = new SqlCommand(readcommand, MyConnection);
            //globalcommand1 = new SqlCommand(readcommand1, tobisqlconnection);

            globalcommand.Parameters.Add("@id", System.Data.SqlDbType.VarChar, 10).Value = id;
            //globalcommand1.Parameters.Add("@id", System.Data.SqlDbType.VarChar, 10).Value = id;

            //call datareader in form

            dataReader = globalcommand.ExecuteReader();

            

            sqladapter = new SqlDataAdapter(readall, tobisqlconnection);

            


            
            
        }





        

    }
}
