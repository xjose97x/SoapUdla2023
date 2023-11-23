// See https://aka.ms/new-console-template for more information
using WebServiceReference;

Console.WriteLine("Hello, World!");

ISoapService soapServiceChannel = new SoapServiceClient(SoapServiceClient.EndpointConfiguration.BasicHttpBinding_ISoapService_soap);
var sumResponse = await soapServiceChannel.SumAsync(new SumRequest()
{
    Body = new SumRequestBody(2, 8)
});
Console.WriteLine(sumResponse.Body.SumResult);
