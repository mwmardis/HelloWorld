using Microsoft.Extensions.Configuration;

namespace HelloWorldAPI
{
    public class HelloWorldService : IHelloWorldService
    {
        readonly IConfiguration configuration;

        public HelloWorldService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public string RetrieveHelloWorld()
        {
            return configuration.GetValue<string>("HelloWorld");
        }
    }
}
