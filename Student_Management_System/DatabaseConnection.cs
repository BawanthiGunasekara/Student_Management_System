using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    class DatabaseConnection
    {
        //defining and initializing the connection string
        public SqlConnection connection;
        public string connectionString = @"Data Source=NGHQ-IT-028\MSSQLSERVER2012;Initial Catalog=Student_Database;User ID=sa;Password=";

        public string Student_Name { get; private set; }
        public string Student_No { get; private set; }

        private void Initialize()
        {

        }


        // !!! ________SEARCH FUNCTION_________ !!!!
        public DataTable LoadDegreeProgramDetails()
        {
            DataTable dt = new DataTable();
            //sql connection object
            using (connection = new SqlConnection(connectionString))
            {
                //retrieve the SQL Server instance version
                string query = @" SELECT d.Degree_Type  AS Degree_Type,
	                                       d.Num_Of_Years AS Num_Of_Years,
	                                       s.Specialization_Name AS Specialization_Name,
	                                       s.Fee AS Fee,
	                                       m.Module_Name AS Module_Name,
	                                       Credits AS Credits
	                                       FROM Degree d INNER JOIN Specialization s
				                                    on d.Degree_Name = s.Degree_Name
					                                     INNER JOIN Modules m
				                                    on s.Specialization_Name = m.Specialization_Name";

                //define the SqlCommand object
                SqlCommand cmd = new SqlCommand(query, connection);


                //Set the SqlDataAdapter object
                SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

                //define dataset
                DataSet ds = new DataSet();

                //fill dataset with query results
                dAdapter.Fill(ds);

                //set the DataGridView control's data source/data table
                dt = ds.Tables[0];

                //close connection
                connection.Close();
            }

            return dt;
        }


        //___STUDENT INFO TABLE___
        //view statement
        public DataTable ViewStudentDetails()
        {
            DataTable dt = new DataTable();
            //sql connection object
            using (connection = new SqlConnection(connectionString))
            {

                //retrieve the SQL Server instance version
                string query = @"SELECT Student_No AS Student_ID,
                                      First_Name AS FirstName,
                                      Last_Name AS LastName,
                                      NIC AS NIC,
                                      Address AS Address,    
                                      DOB AS Date_Of_Birth,
                                      Contact AS Contact,
                                      Nationality AS Nationality,
                                      Degree AS Degree,
                                      Specialization_Name AS Specialization,
                                      Yr as Year,
                                      Semester AS Semester,
                                      Registered_Date AS Registered_Date
                                      FROM Student_Info;";

                //define the SqlCommand object
                SqlCommand cmd = new SqlCommand(query, connection);


                //Set the SqlDataAdapter object
                SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

                //define dataset
                DataSet ds = new DataSet();

                //fill dataset with query results
                dAdapter.Fill(ds);

                //set the DataGridView control's data source/data table
                dt = ds.Tables[0];

                //close connection
                connection.Close();
            }
            return dt;
        }

        /*        //Update statement
                internal void UpdateStudentDetails(string student, string text1, string text2, string text3, DateTime dateTime, string text4)
                {
                    DataTable dt = new DataTable();
                    string query = "UPDATE Student_Info SET First_Name='" + text1 + "', Last_Name='" + text2 + "', NIC='" + text3 + "', DOB='" + dateTime + "', Address='" + text4 + "' WHERE Student_No='" + student + "'";

                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.ExecuteNonQuery();
                    connection.Close();
                }*/

        //Insert statement
        public void InsertStudentDetails(string FirstName, string LastName, string NIC, DateTime DOB, string Address, string Contact, string Nationality, string Degree, string Specialization, string Year, string Semester, string Registered_Date, string Username, string Password)

        {
            //sql query for Insert statement
            string query = "insert into Student_Info(First_Name, Last_Name, NIC, DOB, Address, Contact, Nationality, Degree, Specialization_Name, Yr, Semester, Registered_Date, UsrName, Psword) values('" + FirstName + "', '" + LastName + "', '" + NIC + "', '" + DOB + "', '" + Address + "', '" + Contact + "', '" + Nationality + "', '" + Degree + "', '" + Specialization + "', '" + Year + "', '" + Semester + "', '" + Registered_Date + "', '" + Username + "', '" + Password + "')";
            connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.ExecuteNonQuery();
            connection.Close();

        }

        //Load details statement
        internal void LoadDetails()
        {
            throw new NotImplementedException();
        }

        //Delete statement for Student Info
        /*public void DeleteStudentDetails(string student)
        {
            string query = "DELETE FROM Student_Info WHERE WHERE Student_No='" + student + "'";
            connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.ExecuteNonQuery();
            connection.Close();
        }
*/


        //___SPECIALIZATION TABLE___ 
        //Insert statement for Specialization Table
        public void InsertSpecializationDetails(string Degree, string Specialization_Name, string Fee)
        {
            //sql query for Insert statement
            string query = "insert into Specialization(Degree_Name, Specialization_Name, Fee) values('" + Degree + "', '" + Specialization_Name + "','" + Fee + "')";
            connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.ExecuteNonQuery();
            connection.Close();
        }


        //___DEGREE TABLE___ 
        //Insert statement for Degree Table
        public void InsertDegreeDetails(string Degree_Type, string Degree_Name, string Num_Of_Years)
        {
            //sql query for Insert statement
            string query = "insert into Degree(Degree_Type, Degree_Name, Num_Of_Years) values('" + Degree_Type + "', '" + Degree_Name + "', '" + Num_Of_Years + "')";
            connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.ExecuteNonQuery();
            connection.Close();
        }

        //view statement for Degree Programs
        public DataTable ViewDegreePrograms()
        {
            DataTable dt = new DataTable();

            //sql connection object
            using (connection = new SqlConnection(connectionString))
            {

                //retrieve the SQL Server instance version
                string query = @"SELECT d.Degree_Type  AS Degree_Type ,
                                        d.Degree_Name AS Degree_Name,
                                        d.Num_Of_Years AS Num_Of_Years,
                                        s.Specialization_Name AS Specialization_Name,    
                                        s.Fee AS Fee
                                        FROM Degree d INNER JOIN Specialization s
				                                on d.Degree_Name = s.Degree_Name;";

                //define the SqlCommand object
                SqlCommand cmd = new SqlCommand(query, connection);


                //Set the SqlDataAdapter object
                SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

                //define dataset
                DataSet ds = new DataSet();

                //fill dataset with query results
                dAdapter.Fill(ds);

                //set the DataGridView control's data source/data table
                dt = ds.Tables[0];

                //close connection
                connection.Close();
            }
            return dt;
        }


        //view statementfor degree table
        /*        public DataTable RetrieveDegreePogramDetails(string Degree_Name)
                {
                    DataTable dt = new DataTable();

                    //sql connection object
                    using (connection = new SqlConnection(connectionString))
                    {

                        //retrieve the SQL Server instance version
                        string query = @"SELECT * ON table WHERE tagoridorwhatever = textboxname.text";

                        //define the SqlCommand object
                        SqlCommand cmd = new SqlCommand(query, connection);


                        //Set the SqlDataAdapter object
                        SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

                        //define dataset
                        DataSet ds = new DataSet();

                        //fill dataset with query results
                        dAdapter.Fill(ds);

                        //set the DataGridView control's data source/data table
                        dt = ds.Tables[0];

                        //close connection
                        connection.Close();
                    }
                    return dt;
                }*/


        /*        //Insert statement
                public void InsertModuleMarks(string Student_No, )

                {
                    //sql query for Insert statement
                    string query = "insert into Student_Marks(Student_No, Last_Name, NIC, DOB, Address, Contact, Nationality, Degree, Specialization, Yr) values('" + FirstName + "', '" + LastName + "', '" + NIC + "', '" + DOB + "', '" + Address + "', '" + Contact + "', '" + Nationality + "', '" + Degree + "', '" + Specialization + "', '" + Year + "')";
                    connection = new SqlConnection(connectionString);
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.ExecuteNonQuery();
                    connection.Close();

                }*/


        //___MODULES TABLE___  
        //Insert statement for Modules Table
        public void InsertModules(string Degree_Name, string Specialization_Name, string Module_Name, string Module_Code, string Credits, string Yr, string Semester)

        {
            //sql query for Insert statement
            string query = "insert into Modules(Degree_Name, Specialization_Name, Module_Name, Module_Code, Credits, Yr, Semester) values( '" + Degree_Name + "','" + Specialization_Name + "','" + Module_Name + "', '" + Module_Code + "','" + Credits + "', '" + Yr + "', '" + Semester + "')";
            connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.ExecuteNonQuery();
            connection.Close();

        }

        //view statement for Modules Table
        public DataTable ViewModuleDetails()
        {
            DataTable dt = new DataTable();

            //sql connection object
            using (connection = new SqlConnection(connectionString))
            {

                //retrieve the SQL Server instance version
                string query = @"SELECT Degree_Name AS Degree_Name,
                                        Specialization_Name AS Specialization_Name,    
                                        Module_Code AS Module_Code,
                                        Module_Name AS Module_Name,
                                        Yr AS Year,
                                        Semester AS Semester,
                                        Credits AS Credits
                                        FROM Modules;";

                //define the SqlCommand object
                SqlCommand cmd = new SqlCommand(query, connection);


                //Set the SqlDataAdapter object
                SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

                //define dataset
                DataSet ds = new DataSet();

                //fill dataset with query results
                dAdapter.Fill(ds);

                //set the DataGridView control's data source/data table
                dt = ds.Tables[0];

                //close connection
                connection.Close();
            }
            return dt;
        }

        //view statement for Modules Table
        public DataTable ViewModuleMarksOfEachStudent(string Student_No)
        {
            DataTable dt = new DataTable();

            //sql connection object
            using (connection = new SqlConnection(connectionString))
            {

                //retrieve the SQL Server instance version
                string query = @"SELECT i.Student_No,
	                                    m.Module_Code,
	                                    m.Module_Name,
	                                    m.Credits,
	                                    r.Marks
                                FROM Modules m INNER JOIN Specialization s
		                                    on m.Specialization_Name = s.Specialization_Name
			                                   INNER JOIN Student_Info i
		                                    on s.Specialization_Name = i.Specialization_Name
			                                    INNER JOIN Student_Marks r
		                                    on m.Module_Name = r.Module_Name
                               WHERE (m.Yr LIKE 1 AND m.Semester LIKE 2) AND (s.Specialization_Name LIKE 'Information Technology' AND i.Student_No LIKE 2)";


                //define the SqlCommand object
                SqlCommand cmd = new SqlCommand(query, connection);


                //Set the SqlDataAdapter object
                SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

                //define dataset
                DataSet ds = new DataSet();

                //fill dataset with query results
                dAdapter.Fill(ds);

                //set the DataGridView control's data source/data table
                dt = ds.Tables[0];

                //close connection
                connection.Close();
            }
            return dt;
        }


        //___LECTURER TABLE___ 
        //Insert statement for degree table
        public void AddNewLecturer(string Lecturer_fName, string Lecturer_lName, string Degree_Type, string Degree_Name)
        {
            //sql query for insert statement 
            string query = "Insert into Lecturer(Lecturer_FName, Lecturer_LName, Degree_Type, Degree_Name) values('" + Lecturer_fName + "','" + Lecturer_lName + "', '" + Degree_Type + "','" + Degree_Name + "')";
            connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.ExecuteNonQuery();
            connection.Close();

        }


        //___STUDENT MARKS TABLE___
        ////Insert statement for student marks table
        public void AddStudentMarks(string Student_No, string Module_Code, string Marks)
        {
            //sql query for insert statement
            string query = "insert into Student_Marks(Student_No,Module_Code,Marks) values('" + Student_No + "', '" + Module_Code + "', '" + Marks + "')";
            connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.ExecuteNonQuery();
            connection.Close();
        }


        //___CONTACT FORM___ 
        //insert table for the inquiries table
        public void AddContactDetails(string name, string email, string mobile, string message)
        {
            //sql query for insert statement
            string query = "insert into Inquiries(Name,Email,Mobile,Msg) values('" + name + "', '" + email + "', '" + mobile + "', '" + message + "')";
            connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.ExecuteNonQuery();
            connection.Close();
        }




    }
}
