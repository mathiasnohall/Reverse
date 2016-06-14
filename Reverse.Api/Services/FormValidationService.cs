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
            throw new NotImplementedException();
        }
    }
}