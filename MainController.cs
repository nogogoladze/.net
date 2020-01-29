using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;  

    public class MainController 
    {
          public void saveAs(){
            
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=DESKTOP-O6I8OB4;Initial Catalog=javaMs;User=nogo;Password=2222";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand sqlCommand;
            SqlDataReader sqlDataReader;
            String sql;
            int count = 0;

            sql = "Select * from dbo.users";
            sqlCommand = new SqlCommand (sql, cnn);
            sqlDataReader = sqlCommand.ExecuteReader();
            List<User> list = new List<User>{};
            while(sqlDataReader.Read()){
                User user = new User();
                user.id = (sqlDataReader.GetInt32(0));
                user.firstName = (sqlDataReader.GetString(1));
                user.lastName = (sqlDataReader.GetString(2));
                user.password = (sqlDataReader.GetString(3));
                user.mail = (sqlDataReader.GetString(4));

                list.Add(user);

                count++;


            }
                for (int i = 0; i < count; i++)
                {
                    FileStream f = new FileStream("C:\\Users\\user\\Desktop\\C#\\test.csv", FileMode.Create);  
                    StreamWriter s = new StreamWriter(f);
                    for (int j = 0; j < count; j++){
                        s.WriteLine(list[j]); 
                    }   
                    s.Close();  
                    f.Close();  
                    Console.WriteLine("File created successfully...");  
                }
                Console.WriteLine("sicsess!");
                cnn.Close();
            }
            
          }