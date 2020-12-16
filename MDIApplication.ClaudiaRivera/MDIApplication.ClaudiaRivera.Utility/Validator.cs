using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace MDIApplication.ClaudiaRivera.Utility
{
  /// <summary>
  /// Class that validate user entry using regular expressions.
  /// </summary>
  public class Validator
  {

    /// <summary>
    /// Function that ensures a string passed in contains alpha characters only with the first letter capitalized
    /// </summary>
    /// <param name="value">String that will be validate</param>
    /// <returns>Boolean value indicating success or not.</returns>
    public static bool IsAlpha(string value)
    {
      Regex namePattern = new Regex(@"^[A-Z][a-z]*$");
      bool isAlpha = namePattern.IsMatch(value) ? true : false;
      return isAlpha;
    }

    /// <summary>
    /// Function that ensures a string passed in contains the proper format for a telephone number(use xxx-xxxx format so no area code please).
    /// </summary>
    /// <param name="value">String that will be validate</param>
    /// <returns>>Boolean value indicating success or not.</returns>
    public static bool ValidPhone(string value)
    {
      Regex phonePattern = new Regex(@"[0-9]{3}-[0-9]{4}");
      bool isAlpha = phonePattern.IsMatch(value) ? true : false;
      return isAlpha;
    }


    /// <summary>
    /// function that ensures no empty strings
    /// </summary>
    /// <param name="value">String that will be validate</param>
    /// <returns>Boolean value indicating success or not.</returns>
    public static bool isEmpty(string value)
    {
      Regex emptyPattern = new Regex(@"^$");
      bool isAlpha = emptyPattern.IsMatch(value) ? true : false;
      return isAlpha;
    }
  }
}
