using models.EmpEnt;
using MySql.Data.MySqlClient;

namespace Dal;
public class DBManager{
    public static string con=@"server=localhost;port=3306;user=root;password=root123;database=blah";
    public static List<Employee> GetAll(){
        List<Employee> AllEmployees=new List<Employee>();
       
        MySqlConnection connec=new MySqlConnection ();
        connec.ConnectionString=DBManager.con;
        try{connec.Open();
        MySqlCommand cmd=new MySqlCommand();
        cmd.Connection=connec;
        cmd.CommandText="Select * from Employees;";
        MySqlDataReader reader=cmd.ExecuteReader();
        while(reader.Read()){
            int eid=int.Parse(reader["id"].ToString());
            string? ename=reader["name"].ToString();
            Double sal=double.Parse(reader["sal"].ToString());
            Employee eadd=new Employee{
                Id=eid,
                Name=ename,
                Sal=sal
            };
              AllEmployees.Add(eadd);
             }
      
            
        }
          catch(Exception err){
Console.WriteLine(err);
        }finally{connec.Close(); }

        return AllEmployees;

    }
    public static Employee GetOne(int id){
       // List<Employee> AllEmployees=new List<Employee>();
       Employee eadd=new Employee();
        MySqlConnection connec=new MySqlConnection ();
        connec.ConnectionString=DBManager.con;
        try{connec.Open();
        MySqlCommand cmd=new MySqlCommand();
        cmd.Connection=connec;
        cmd.CommandText="Select * from Employees where id="+id+";";
        MySqlDataReader reader=cmd.ExecuteReader();
        while(reader.Read()){
            int eid=int.Parse(reader["id"].ToString());
            string? ename=reader["name"].ToString();
            Double sal=double.Parse(reader["sal"].ToString());
             eadd=new Employee{
                Id=eid,
                Name=ename,
                Sal=sal
            };
              
             }
      
            
        }
          catch(Exception err){
Console.WriteLine(err);
        }finally{connec.Close(); }

        return eadd;}
        
    public static void DeleteOne(int id){
       // List<Employee> AllEmployees=new List<Employee>();
       Employee eadd=new Employee();
        MySqlConnection connec=new MySqlConnection ();
        connec.ConnectionString=DBManager.con;
        try{connec.Open();
        MySqlCommand cmd=new MySqlCommand();
        cmd.Connection=connec;
        cmd.CommandText="Delete from Employees where id="+id+";";
        MySqlDataReader reader=cmd.ExecuteReader();
    
      
            
        }
          catch(Exception err){
Console.WriteLine(err);
        }finally{connec.Close(); }

        }
        
 public static void InsertOne(Employee emp){
       // List<Employee> AllEmployees=new List<Employee>();
       
        MySqlConnection connec=new MySqlConnection ();
        connec.ConnectionString=DBManager.con;
        try{connec.Open();
        MySqlCommand cmd=new MySqlCommand();
        cmd.Connection=connec;
        cmd.CommandText="insert into Employees values ("+emp.Id+",'"+emp.Name+"',"+emp.Sal+")";
      // cmd.CommandText="insert  into Employees values (3,'ram',4500)";
        MySqlDataReader reader=cmd.ExecuteReader();
    
      
            
        }
          catch(Exception err){
Console.WriteLine(err);
        }finally{connec.Close(); }

        }
        
    public static void UpdateOne(int id,Employee emp){
       // List<Employee> AllEmployees=new List<Employee>();
      // Employee eadd=new Employee();
        MySqlConnection connec=new MySqlConnection ();
        connec.ConnectionString=DBManager.con;
        try{connec.Open();
        MySqlCommand cmd=new MySqlCommand();
        cmd.Connection=connec;
        cmd.CommandText="update employees set id="+id +", name= '"+emp.Name +"', sal="+emp.Sal +" where id="+id+";";
        MySqlDataReader reader=cmd.ExecuteReader();
    
      
            
        }
          catch(Exception err){
Console.WriteLine(err);
        }finally{connec.Close(); }

        }
        
 
}