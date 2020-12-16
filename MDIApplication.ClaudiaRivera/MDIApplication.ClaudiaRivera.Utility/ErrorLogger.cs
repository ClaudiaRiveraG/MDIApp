using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MDIApplication.ClaudiaRivera.Utility
{
  public class ErrorLogger
  {
    private const string _path = @"..\..\..\Resources\ErrorLog.CSV";

    /// <summary>
    /// Errors are written out to a csv file
    /// </summary>
    /// <param name="value">A string containing the error: username, date, error message are included</param>
    public static void Log(string value)
    {
      StreamWriter writer = new StreamWriter(_path, true);
      try
      {
        writer.WriteLine(value);
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
      finally
      {
        writer.Close();
      }

    }

    /// <summary>
    /// Show all errors on a new line and properly aligned
    /// </summary>
    /// <returns>List of string containing all errors information properly aligned</returns>
    public static List<string> DisplayErrors()
    {
      string[] contents = null;
      List<string> lines = new List<string>();
      try
      {
        contents = File.ReadAllLines(_path);
        for (int i = 0; i < contents.Length; i++)
        {
          string line = contents[i].Replace(",", "\t");
          lines.Add(line);

        }
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }


      return lines;
    }


  }
}
