using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using System.ComponentModel.DataAnnotations;
using ThucHanhBuoi2.ViewModels;
{
    public class FutureDate : ValidationAttribute
    {
        public override bool  IsValid( object value)
        {
#pragma warning disable CS0168 // Variable is declared but never used
        DateTime dateTime;
#pragma warning restore CS0168 // Variable is declared but never used
        var isValid = DateTime.TryParseExact(Convert.ToString(value))
        }
    }
}