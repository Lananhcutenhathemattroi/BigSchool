using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using System.Threading; // For Thread.CurrentThread.CurrentCulture
using System.Globalization; // for lots of globalization types
using System.ComponentModel.DataAnnotations;
namespace ThucHanhBuoi2.ViewModels
{
    public class ValidTime : ValidationAttribute
    {
        public override bool  IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                "HH.mm",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None,
                out dateTime);
            return isValid;
        }
    }
}