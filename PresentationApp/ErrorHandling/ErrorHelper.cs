using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresentationApp.ErrorHandling
{
    public static class ErrorHelper
    {
        public static IList<string> GetErrors(this ModelStateDictionary modelState)
        {
            IList<string> errors = new List<string>();

            foreach (ModelState ms in modelState.Values)
            {
                foreach (ModelError modelError in ms.Errors)
                {
                    errors.Add(modelError.ErrorMessage);
                }
            }

            return errors;
        }
    }
}