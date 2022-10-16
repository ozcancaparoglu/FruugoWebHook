using Microsoft.Extensions.Configuration;
using Product.Application.Helpers;
using System.Text;

namespace Product.Application.Features.Products.Commons
{
    public abstract class AuthorizationBaseHandler
    {
        public readonly RestClientHelper _restClientHelper;
        public readonly string _username;
        public readonly string _password;
        public readonly string _baseUrl;
        public readonly Dictionary<string, string> _headers;
        public readonly FruugoBaseCommand _fruugoBase;

        public AuthorizationBaseHandler(IConfiguration configuration)
        {
            _restClientHelper = new RestClientHelper();
            _username = configuration["FruugoSettings:Username"];
            _password = configuration["FruugoSettings:Password"];
            _baseUrl = configuration["FruugoSettings:BaseUrl"];
            string encoded = System.Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(_username + ":" + _password));
            _headers = new Dictionary<string, string>
            {
                {"Authorization", $"Basic {encoded}"}
            };
            _fruugoBase = new FruugoBaseCommand
            {
                CorrelationId = configuration["FruugoSettings:CorrelationId"],
                MerchantId = int.Parse(configuration["FruugoSettings:MerchantId"])
            };
        }
    }
}
