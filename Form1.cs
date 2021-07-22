﻿using System;
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

        //register button

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            SubmitValidation();
        }

        
        private void SubmitValidation()

        {
            //output user validation error in label text
            this.ErrorLabel.Text = ValidationFunction();
        }

        //register user data fxn
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



        //readbutton

        private void ReadButton_Click(object sender, EventArgs e)
        {
            ReadDatabaseInput();
        }

        //hardcoded read method
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


        //hard coded insert method
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




        //form method
        private void Form_Validation_Load(object sender, EventArgs e)
        {
            //set datagrid visibility to false in form window
            this.dataGrid.Visible = false;
        }

        //updatebutton

        private void UpdateButton_Click(object sender, EventArgs e)
        {

            Updatemtd();
            
            //call the global variable class
            //Global_variables gv1 = new Global_variables();

            //call the global varibale method
            /*
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

            */


        }

        private void Updatemtd()
        {
            this.ErrorLabel.Text = UpdateFunction();
        }

        //user update function
        private string UpdateFunction()
        {
            //username entered by user
            string username = this.Username.Text;



            //user id
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


                if (id != string.Empty)

                    //insert to database
                    database.UpdateDatabaseInput(id,username);
                MessageBox.Show(username +", info updated");

            }



            else if (username == string.Empty || id == string.Empty)
                return "empty field";


            return null;
        }


        //deletebutton

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            /*
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

            */

            Deletefxn();
        }

        //delete user data by supplying id
        private void Deletefxn()
        {
            //user id
            string id = this.RegnoBox.Text;

            //calling the database class
            var database = new Database();



            database.Set_Connection_Parameter();

            //remove empty spaces

            id.Replace(" ", "");

            

            //checks for empty user input

            if (id != string.Empty)
            {

                    //delete from database
                    database.DeleteDatabaseInput(id);
                MessageBox.Show(id + ", info deleted");

            }



            else if (id == string.Empty)
                MessageBox.Show("empty id");


            
        }



        //viewbutton
        private void ViewUsers_Click(object sender, EventArgs e)
        {
            this.ErrorLabel.Text = ReadUsersData();

            
        }


        //load user data by supplying user id
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

               

                if (datareader.Read())
                {
                    Output = Output + datareader.GetValue(0) + "-" + datareader.GetValue(1) + "\n";
                    return Output;

                }

                else if (!(datareader.Read()))
                {
                    Output = "id, not found";
                    return Output;
                }
                
            }



            

            


            else if (id == string.Empty)
                return "no regno entered";


            return null;
            
        }


        //populatebutton
        private void PopulateButton_Click(object sender, EventArgs e)
        {
            Populatefxn();
        }


        //load user data from database by clicking on populate button
        private void Populatefxn()
        {
            //make the data grid visible on this buttonclick
            this.dataGrid.Visible = true;
            
            //declare variable for table rows and columns
            int dr_row_count = 0;
            int dr_column_count = 0;

            //calling the database class
            var database = new Database();

            //call connection strings method

            database.Set_Connection_Parameter();


            //call database method

            database.ReadDatabase();

            //call datareader

            var datareader = database.dataReader;

            //call sqladapter

            var sqladapter = database.sqladapter;


            //set connection for datasets


            _C_ConnectDataSet1 new1 = new _C_ConnectDataSet1();

            
            //define table to be called from database
            DataTable table = new1.Tables[0];

            //call adapter to fill table
            sqladapter.Fill(table);


            //count no of rows and column from database table selected
            int rowcount = table.Rows.Count;
            int columnscount = table.Columns.Count;


            int r = 0;
            int c = 0;

            //create an array of the table rows and columns

            string[,] a = new string[rowcount, columnscount];



            //specified the column count for data output to the datagrid

            dataGrid.ColumnCount = 2;

            dataGrid.Columns[0].Name = "id";
            dataGrid.Columns[1].Name = "username";
            

           
            while (datareader.Read())
            {
                dr_row_count++;
                dr_column_count = datareader.FieldCount;
              
            }


            //add rows and column to datagrid

            dataGrid.Rows.Add(dr_row_count);

            for (r = 0; r < dr_row_count; r++)
            {
                for (c = 0; c < dr_column_count; c++)
                {
                    a[r, c] = table.Rows[r][c].ToString();
                    dataGrid.Rows[r].Cells[c].Value = a[r, c];
                }


            }

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        //page2 button click
        private void Page2Button_Click(object sender, EventArgs e)
        {
            //create an instance of page2 form
            Page2 page2 = new Page2();
            page2.Show();

            this.Visible = false;
            this.Hide();


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

        //hardcoded sql commands
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
