using System.ServiceModel;

namespace Soap.Server.Interfaces;

[ServiceContract]
public interface ISoapService
{
  [OperationContract]
  string Sum(int a, int b);
}
