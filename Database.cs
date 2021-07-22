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

        
        


        //connection parameters
        public string connectionstrings;

        //global command for initializing sql command

        public SqlCommand globalcommand;


        //sqladapter

        public SqlDataAdapter sqladapter;
        
        //sql string commands

        public String insertcommand;
        public String updatecommand;
        private String deletecommand;
        public String readcommand;
        public String readall;


        //data reader command
        public SqlDataReader dataReader;
         

        //connection mtd to be called

        public void Set_Connection_Parameter()
        {
            connectionstrings = @"Data Source=WIN-BEHF8SQE8DC;Database=C#Connect;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=true";

        }


        //insert user data method by clicking on register button
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



        //read user data based on user regno by clicking on view button
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
            
        }



        //read all user data in the database by click on populate button
        public void ReadDatabase()
        {

            //establish sql connection to database
            MyConnection = new SqlConnection(connectionstrings);
            MyConnection.Open();
            


            //read all command
            readall = "select id,username from registration";

            //global command for read all
            globalcommand = new SqlCommand(readall, MyConnection);
            
            //datareader for readall
            dataReader = globalcommand.ExecuteReader();
            

            //sqladapter for readall command
            sqladapter = new SqlDataAdapter(readall, MyConnection);
            globalcommand.Dispose();
            

        }


        //update user data based on user regno by clicking on update button
        public void UpdateDatabaseInput(string id, string username)
        {

            //establish sql connection to database
            MyConnection = new SqlConnection(connectionstrings);

            MyConnection.Open();


            //sqladapter is the method to insert, delete, update data in c#
            SqlDataAdapter adapter = new SqlDataAdapter();

            //read command by user id
            updatecommand = "update registration set username=@username where id =@id";

            

            globalcommand = new SqlCommand(updatecommand, MyConnection);


            globalcommand.Parameters.Add("@id", System.Data.SqlDbType.VarChar, 10).Value = id;
            globalcommand.Parameters.Add("@username", System.Data.SqlDbType.VarChar, 150).Value = username;


            //call datareader in form
            adapter.UpdateCommand = globalcommand;
            adapter.UpdateCommand.ExecuteNonQuery();
            globalcommand.Dispose();
            MyConnection.Close();
        }


        //delete user data based on user regno by clicking on delete button
        public void DeleteDatabaseInput(string id)
        {

            //establish sql connection to database
            MyConnection = new SqlConnection(connectionstrings);

            MyConnection.Open();


            //sqladapter is the method to insert, delete, update data in c#
            SqlDataAdapter adapter = new SqlDataAdapter();

            //read command by user id
            deletecommand = "delete registration where id =@id";

            

            globalcommand = new SqlCommand(deletecommand, MyConnection);


            globalcommand.Parameters.Add("@id", System.Data.SqlDbType.VarChar, 10).Value = id;
            

            //call datareader in form
            adapter.DeleteCommand = globalcommand;
            adapter.DeleteCommand.ExecuteNonQuery();
            globalcommand.Dispose();
            MyConnection.Close();
        }



    }
}
