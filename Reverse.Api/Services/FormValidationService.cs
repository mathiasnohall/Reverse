using System;

namespace Reverse.Api.Services
{
    public interface IFormValidationService
    {
        string GetInputString(dynamic form);
    }

    public class FormValidationService : IFormValidationService
    {
        public string GetInputString(dynamic form)
        {
            var result = string.Empty;

            if (form == null)
                return result;

            if(!string.IsNullOrEmpty((string)form.inputString))
            {
                result = form.inputString;
            }

            return result;
        }
    }
}