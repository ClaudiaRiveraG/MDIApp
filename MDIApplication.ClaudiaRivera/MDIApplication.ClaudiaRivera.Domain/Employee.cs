using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace MDIApplication.ClaudiaRivera.Domain
{
    public class Employee
    {
    /// <summary>
    /// Fields
    /// </summary>
    private int _ID;
    private string _firstname;
    private string _lastname;
    private string _department;
    private string _phone;

    private const string _fileName = @"..\..\..\Resources\employees.dat";

    
    /// <summary>
    /// Constructors
    /// </summary>
    public Employee() { }

    public Employee(int id, string firstname, string lastname, string department, string phone)
    {
      this.ID = id;
      this.Firstname = firstname;
      this.Lastname = lastname;
      this.Department = department;
      this.Phone = phone;
    }

    /// <summary>
    /// Properties
    /// </summary>
    /// 
    public int ID { get => _ID; set => _ID = value; }
    public string Firstname { get => _firstname; set => _firstname = value; }
    public string Lastname { get => _lastname; set => _lastname = value; }
    public string Department { get => _department; set => _department = value; }
    public string Phone { get => _phone; set => _phone = value; }

    
    /// <summary>
    /// Add a new employee to the system
    /// </summary>
    /// <param name="firstname">user input</param>
    /// <param name="lastname">user input</param>
    /// <param name="department">userinput</param>
    /// <param name="phone"></param>
    /// <returns>A string containing a error message or succeful message</returns>
    public string Add(string firstname, string lastname, string department, string phone)
    {
      string message = "";
      String error;
      bool flag = false;
      string date = DateTime.Now.ToString();
      string username = Utility.Authenticator.usernameAut;
      string password = Utility.Authenticator.passwordAut;
      // Validate inputs before save a new employee
      try
      {
        // validate Firtsname is not empty

        if (Utility.Validator.isEmpty(firstname))
        {
          message = ("First Name must have a value");
          error = username + ", " + date + ", " + message;
          Utility.ErrorLogger.Log(error);
          flag = false;
        }
        //Validate last name is not empty
        if (Utility.Validator.isEmpty(lastname) && string.IsNullOrEmpty(message))
        {
          message = "Last Name must have a value";
          error = username + ", " + date + ", " + message;
          Utility.ErrorLogger.Log(error);
          flag = false;
        }

        //Validate department is not empty
        if (Utility.Validator.isEmpty(department) && string.IsNullOrEmpty(message))
        {
          message = "Department must have a value";
          error = username + ", " + date + ", " + message;
          Utility.ErrorLogger.Log(error);
          flag = false;
        }
        //Validate phone number is not empty

        if (Utility.Validator.isEmpty(phone) && string.IsNullOrEmpty(message))
        {
          message = "Phone number must have a value";
          error = username + ", " + date + ", " + message;
          Utility.ErrorLogger.Log(error);
          flag = false;
        }

        if (string.IsNullOrEmpty(message))
        {

          //first name, last name,  only take alphabet characters.
          //validate first Name 
          if (!Utility.Validator.IsAlpha(firstname))
          {
            message = "First Name only accept alphabets characters and First Letter uppercase";
            error = username + ", " + date + ", " + message;
            Utility.ErrorLogger.Log(error);
            flag = false;
            return message;
          }

          else
          {
            this.Firstname = firstname;
            flag = true;
          }
          //validate Last Name 
          if (!Utility.Validator.IsAlpha(lastname) && string.IsNullOrEmpty(message))
          {
            message = "Last Name only accept alphabets characters and First Letter uppercase";
            error = username + ", " + date + ", " + message;
            Utility.ErrorLogger.Log(error);
            flag = false;
            return message;
          }
          else
          {
            this.Lastname = lastname;
            flag = true;
          }

          //Validate phone with this format XXX-XXXX no area code
          if (!Utility.Validator.ValidPhone(phone) && string.IsNullOrEmpty(message))
          {
            message = "Format phone XXX-XXXX no area code please";
            error = username + ", " + date + ", " + message;
            Utility.ErrorLogger.Log(error);
            flag = false;
            return message;
          }
          else
          {
            this.Phone = phone;
            flag = true;
          }

        }

        if (flag)
        {

          this.ID = Utility.IDGenerator.NewID();
          this.Department = department;
          SaveRecord(this);
          message = "Successful";
        }

      }
      catch
      {
      }
      return message;


    }

    /// <summary>
    /// /Save the current employe to a binary file
    /// </summary>
    /// <param name="emp">Employee object </param>
    private void SaveRecord(Employee emp)
    {
      FileStream stream = new FileStream(_fileName, FileMode.Append, FileAccess.Write);
      BinaryWriter bwriter = new BinaryWriter(stream);
      try
      {
        bwriter.Write(emp.ID);
        bwriter.Write(emp.Firstname);
        bwriter.Write(emp.Lastname);
        bwriter.Write(emp.Department);
        bwriter.Write(emp.Phone);
      }

      catch (Exception e)
      {
        Console.WriteLine(e);
      }
      finally
      {
        bwriter.Close();
      }

    }

    /// <summary>
    /// Get all employees from the employees.dat file
    /// </summary>
    /// <returns>List od employees</returns>
    public static List<Employee> GetAll()
    {

      return GetRecords(_fileName);
    }


    /// <summary>
    /// Get  employees from the employees.dat file
    /// </summary>
    /// <param name="path">Path of the file</param>
    /// <returns>List of employees</returns>
    private static List<Employee> GetRecords(string path)
    {
      List<Employee> employees = new List<Employee>();
      Employee emp = null;

      try
      {
        FileStream streamr = new FileStream(path, FileMode.Open, FileAccess.Read);
        BinaryReader reader = new BinaryReader(streamr, Encoding.ASCII);
        try
        {
          do
          {
            emp = new Employee();
            emp.ID = reader.ReadInt32();
            emp.Firstname = reader.ReadString();
            emp.Lastname = reader.ReadString();
            emp.Department = reader.ReadString();
            emp.Phone = reader.ReadString();

            employees.Add(emp);
          }
          while (reader.PeekChar() != -1);

        }
        catch (Exception e)
        {
          Console.WriteLine(e);
        }
        finally
        {
          reader.Close();
        }

      }

      catch (IOException e)
      {
        Console.WriteLine(e);
      }

      return employees;
    }


  }
}
