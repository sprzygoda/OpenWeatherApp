using Newtonsoft.Json;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTests.Mocks
{
    public class HttpMessageHandlerMock : HttpMessageHandler
    {
        protected override Task<HttpResponseMessage>SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if(request.Headers.Contains(TestData.TestData.CORRECT_CITY_NAME))
            return Task.FromResult(new HttpResponseMessage()
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Content  = new StringContent(JsonConvert.SerializeObject(TestData.TestData.CorrectClientResponse))
            });
            else
            {
                return Task.FromResult(new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest));
            }
        }
    }
}
