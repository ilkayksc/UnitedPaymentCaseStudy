using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;
using UnitedPaymentCaseStudy.ConnectedService.Payzee.Interface;
using UnitedPaymentCaseStudy.Data.Entity;

namespace UnitedPaymentCaseStudy.ConnectedService.Payzee.Services
{
    public class LoginService : ILoginService
    {
        public async Task<string> PayzeeToken()
        {
            var url = "https://ppgsecurity-test.birlesikodeme.com:55002/api/ppg/Securities/authenticationMerchant";

            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri(url);

                    LoginRequestDto loginRequest = new LoginRequestDto();
                    var jsonData = JsonConvert.SerializeObject(loginRequest);

                    var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                    var result = await client.PostAsync(url, content);
                    string resultContent = await result.Content.ReadAsStringAsync();

                    dynamic token = JsonConvert.DeserializeObject(resultContent);
                   
                    if (token["statusCode"] != "200")
                        throw new Exception($"Login Error: {token.responseMessage}");

                    return token["result"]["token"]; ;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
    }
}

