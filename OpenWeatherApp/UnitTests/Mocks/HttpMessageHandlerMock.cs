﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTests.Mocks
{
    public class HttpMessageHandlerMock : HttpMessageHandler
    {
        public HttpMessageHandlerMock()
        {

        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if(request.Content.Headers.Contains(TestData.TestData.CORRECT_CITY_NAME))
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
