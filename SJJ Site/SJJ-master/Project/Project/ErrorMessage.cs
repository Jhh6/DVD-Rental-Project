using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ErrorMessage
/// </summary>
/// 
namespace Project
{
    public class ErrorMessage
    {
        public static string message;
        public static bool printMe = false;
        public ErrorMessage()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public string returnMessage()
        {
            return message;
        }
    }
}