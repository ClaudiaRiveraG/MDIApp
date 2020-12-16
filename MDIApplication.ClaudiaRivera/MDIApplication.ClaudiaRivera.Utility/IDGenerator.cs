using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDIApplication.ClaudiaRivera.Utility
{
  /// <summary>
  /// ID Generating class has afunction that creates and returns a 6 digit radom number
  /// </summary>
  public class IDGenerator
  {

    /// <summary>
    /// The function returns a number that is randomly generated using the Random class.
    /// </summary>
    /// <returns>A 6 digit randomm number</returns>
    public static int NewID()
    {
      Random r = new Random();
      int sixDigitNumber = r.Next(100000, 999999);

      return sixDigitNumber;
    }

  }
}
