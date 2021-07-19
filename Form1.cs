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

namespace Creation1
{
    public partial class Form_Validation : Form
    {
        public Form_Validation()
        {
            InitializeComponent();
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Regno_TextChanged(object sender, EventArgs e)
        {

        }

        //method to submit user input

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            SubmitValidation();
        }

        //output user validation error in input box
        private void SubmitValidation()

        {
            this.ErrorLabel.Text = ValidationFunction();
        }

        private string ValidationFunction()
        {
            string username = this.Username.Text;



            //generate user id
            string id = this.RegnoBox.Text;

            //calling the database class
            var database = new Database();

            database.Set_Connection_Parameter();
        
            //remove empty spaces

            username.Replace(" ", "");

            //no case sensitive
            username.ToLower();

            //checks for empty user input

            if (username != string.Empty)
            {
                for (int i = 0; i < username.Length; i++)
                {
                    if ("0123456789./*%+=-^@#!,><_`~;:}{[]()&$".Any(c => username[i] == c))

                        return "text only";

                }


                if(id != string.Empty)

                //insert to database
                database.InsertData(username,id);
                MessageBox.Show(username+","+id+",log to database");

            }



            else if (username == string.Empty || id ==string.Empty)
                return "empty field";


            return null;


        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            ReadDatabaseInput();
        }

        private void ReadDatabaseInput()
        {
            //call global variable class
            Global_variables gv1 = new Global_variables();

            //call global variable method
            gv1.Set_Global_Variables();

            //establish sql connection to database
            gv1.MyConnection1 = new SqlConnection(gv1.global_connection_string);
            gv1.MyConnection1.Open();
            MessageBox.Show("connection open");

            //sqldatareader is used to read data from database in c#

            SqlDataReader dataReader;
            string Output = "";
            gv1.global_command1 = new SqlCommand(gv1.sql_command1, gv1.MyConnection1);

            

            dataReader = gv1.global_command1.ExecuteReader();

            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + "-" + dataReader.GetValue(1) + "\n";
                
            }

            MessageBox.Show(Output);
            dataReader.Close();
            gv1.global_command1.Dispose();
            gv1.MyConnection1.Close();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            //call the global variable class
            Global_variables gv1 = new Global_variables();

            //call the global varibale method
            gv1.Set_Global_Variables();

            //establish sql connection
            gv1.MyConnection2 = new SqlConnection(gv1.global_connection_string);
            gv1.MyConnection2.Open();

            //sqladapter is the method to insert, delete, update data in c#
            SqlDataAdapter adapter = new SqlDataAdapter();
  
            gv1.global_command2 = new SqlCommand(gv1.sql_command2, gv1.MyConnection2);

            adapter.InsertCommand = new SqlCommand(gv1.sql_command2, gv1.MyConnection2);
            adapter.InsertCommand.ExecuteNonQuery();
            gv1.global_command2.Dispose();
            MessageBox.Show("field added");
            gv1.MyConnection2.Close();

        }

        private void Form_Validation_Load(object sender, EventArgs e)
        {
            this.dataGrid.Visible = false;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            //call the global variable class
            Global_variables gv1 = new Global_variables();

            //call the global varibale method
            gv1.Set_Global_Variables();

            //establish sql connection
            gv1.MyConnection3 = new SqlConnection(gv1.global_connection_string);
            gv1.MyConnection3.Open();

            //sqladapter is the method to insert, delete, update data in c#
            SqlDataAdapter adapter = new SqlDataAdapter();

            gv1.global_command3 = new SqlCommand(gv1.sql_command3, gv1.MyConnection3);

            adapter.UpdateCommand = new SqlCommand(gv1.sql_command3, gv1.MyConnection3);
            adapter.UpdateCommand.ExecuteNonQuery();
            gv1.global_command3.Dispose();
            MessageBox.Show("field updated");
            gv1.MyConnection3.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //call the global variable class
            Global_variables gv1 = new Global_variables();

            //call the global varibale method
            gv1.Set_Global_Variables();

            //establish sql connection
            gv1.MyConnection4 = new SqlConnection(gv1.global_connection_string);
            gv1.MyConnection4.Open();

            //sqladapter is the method to insert, delete, update data in c#
            SqlDataAdapter adapter = new SqlDataAdapter();

            gv1.global_command4 = new SqlCommand(gv1.sql_command4, gv1.MyConnection4);

            adapter.DeleteCommand = new SqlCommand(gv1.sql_command4, gv1.MyConnection4);
            adapter.DeleteCommand.ExecuteNonQuery();
            gv1.global_command4.Dispose();
            MessageBox.Show("field deleted");
            gv1.MyConnection4.Close();
        }



        //view users data on the database
        private void ViewUsers_Click(object sender, EventArgs e)
        {
            this.ErrorLabel.Text = ReadUsersData();

            
        }

        private string ReadUsersData()
            
        {
            
            string id = this.RegnoBox.Text;
            
            //remove empty spaces
            id.Replace(" ", "");

            //calling the database class
           var database = new Database();

            //call connection strings method

            database.Set_Connection_Parameter();
            
            if (id != string.Empty)

            {

                //call readdatabase input in database
                database.ReadDatabaseInput(id);
               var datareader = database.dataReader;

                string Output = "";

               

                while (datareader.Read())
                {
                    Output = Output + datareader.GetValue(0) + "-" + datareader.GetValue(1) + "\n";

                }


                return Output;
                
            }






            else if (id == string.Empty)
                return "no regno entered";


            return null;
            
        }



        private void PopulateButton_Click(object sender, EventArgs e)
        {
            Populatefxn();
        }

        private void Populatefxn()
        {
            this.dataGrid.Visible = true;
            int dr_row_count = 0;
            int dr_column_count = 0;

            //calling the database class
            var database = new Database();

            //call connection strings method

            database.Set_Connection_Parameter();


            //call method

            database.ReadDatabase();

            //call datareader

            var datareader1 = database.dataReader1;

            //call sqladapter

            var sqladapter1 = database.sqladapter1;


            //set connection for datasets


            _C_ConnectDataSet1 new1 = new _C_ConnectDataSet1();

            DataTable table = new1.Tables[0];

            //call adapter to fill table
            //sqladapter1.Fill(table);


            //define no of rows count
            int rowcount = table.Rows.Count;
            int columnscount = table.Columns.Count;


            int r = 0;
            int c = 0;

            string[,] a = new string[rowcount, columnscount];

            //outputing in data grid

            for (r = 0; r < dr_row_count; r++)
            {
                for (c = 0; c < dr_column_count; c++)
                {
                    a[r, c] = table.Rows[r][c].ToString();
                    dataGrid.Rows[r].Cells[c].Value = a[r, c];
                }


            }

            while (datareader1.Read())
            {
                dr_row_count++;
                dr_column_count = datareader1.FieldCount;
                dataGrid.ColumnCount = 2;
                dataGrid.Rows.Add(dr_row_count);

                dataGrid.Columns[0].Name = "id";
                dataGrid.Columns[1].Name = "username";
                
                
                
                


            }
        }
    }


    //define global variables class to configure input to database
    public class Global_variables
    {
        public SqlConnection MyConnection1;
        public SqlConnection MyConnection2;
        public SqlConnection MyConnection3;
        public SqlConnection MyConnection4;

        public SqlCommand global_command1;
        public SqlCommand global_command2;
        public SqlCommand global_command3;
        public SqlCommand global_command4;


        //create a public string connection variable
        public string global_connection_string;

        public string sql_command1;

        public string sql_command2;

        public string sql_command3;

        public string sql_command4;


        public void Set_Global_Variables()
        {
            global_connection_string = @"Data Source=WIN-BEHF8SQE8DC;Database=C#Connect;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=true";

            sql_command1 = "Select id,username from users where id=2";
            sql_command2 = "Insert into users (username,Id) values('" + "lam scoth" + "',3)";
            sql_command3 = "update users set  username='"+"yarn couf"+"' where id=2";
            sql_command4 = "delete users where id = 3";





        }
    }

}
