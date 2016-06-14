using System;

namespace Reverse.Api.Services
{
    public interface IStringReverseService
    {
        string Reverse(string inputString);
    }

    public class StringReverseService : IStringReverseService
    {
        public string Reverse(string inputString)
        {
            throw new NotImplementedException();
        }
    }
}