using Soap.Server.Interfaces;

namespace Soap.Server.Services
{
    public class SoapService : ISoapService
    {
        public string Sum(int a, int b)
        {
            return $"Sum of {a} and {b} is {a + b}";
        }
    }
}
