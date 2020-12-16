using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MDIApplication.ClaudiaRivera.Utility
{
  /// <summary>
  /// Security class that authenticates user
  /// </summary>
  public class Authenticator
  {

    public static string usernameAut;
    public static string passwordAut;


    /// <summary>
    /// authenticates the username and password against data contained in an authorize.dat binary file. 
    /// </summary>
    /// <param name="username">Username input by the user</param>
    /// <param name="password">Password input by the user</param>
    /// <param name="count">Number of attemps</param>
    /// <returns>A string value indicating if the authentication was succcessful</returns>
    public static string Authenticate(string username, string password, int count)
    {
      //bool flag = false;
      string fileName = @"..\..\..\Resources\authorize.dat";
      string message = "";

      FileStream streamr = new FileStream(fileName, FileMode.Open);
      BinaryReader reader = new BinaryReader(streamr);
      try
      {
        do
        {
          usernameAut = reader.ReadString();
          passwordAut = reader.ReadString();
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


      if (usernameAut.Equals(username) && passwordAut.Equals(password))
      {
        //flag = true;
        message = "Successful";

      }
      else if (count < 4)
      {
        string date = DateTime.Now.ToString();
        string errorMessage = username + ", " + date.ToString() + ", Invalid username or password";
        Utility.ErrorLogger.Log(errorMessage);
        if (count == 3)
        {
          errorMessage = username + ", " + date.ToString() + ", Three attempts being made unsuccesfully";
          Utility.ErrorLogger.Log(errorMessage);
          // flag = false;
          message = "";
        }

      }

      return message;
    }
  }
}
