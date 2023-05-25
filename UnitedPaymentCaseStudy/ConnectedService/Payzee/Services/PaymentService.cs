using System.Text;
using System.Text.Json;
using UnitedPaymentCaseStudy.ConnectedService.Payzee.Interface;
using UnitedPaymentCaseStudy.Data.Entity;

namespace UnitedPaymentCaseStudy.ConnectedService.Payzee.Services
{
    public class Payment : IPayment
    {
        string url = "https://ppgpayment-test.birlesikodeme.com:20000/api/ppg/Payment/NoneSecurePayment";

        async Task<dynamic> IPayment.Payment(PaymentRequestDto payRequest, string token)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri(url);

                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

                    var jsonData = JsonSerializer.Serialize(payRequest);

                    var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                    var result = await client.PostAsync(url, content);
                    string resultContent = await result.Content.ReadAsStringAsync();

                    dynamic response = JsonSerializer.Deserialize<dynamic>(resultContent);

                    return response;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
    }
}

