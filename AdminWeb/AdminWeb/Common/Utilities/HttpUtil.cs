using AdminWeb.Common.Enums;
using Newtonsoft.Json;
using System.Text;

namespace AdminWeb.Common.Utilities
{
    public static class HttpUtil
    {
        public static async Task<(TResult, int)> Get<TResult>(string url)
        {
            using (var httpClient = new HttpClient())
            {
                var httpResponse = await httpClient.GetAsync(url);

                int result = (int)ResponseCode.Error;

                var response = await httpResponse.Content.ReadFromJsonAsync<TResult>();

                if ((int)httpResponse.StatusCode == 200)
                {
                    if (httpResponse.Content != null)
                    {
                        try
                        {
                            var responseContent = await httpResponse.Content.ReadAsStringAsync();
                            var objResponseContent = JsonConvert.DeserializeObject<TResult>(responseContent);

                            if (objResponseContent != null)
                            {
                                response = objResponseContent;
                                result = (int)ResponseCode.Success;
                            }
                            else
                            {
                                result = (int)ResponseCode.Error;
                            }

                        }
                        catch (Exception) { }
                    }
                }

                return await Task.FromResult((response, result));
            }
        }

        public static async Task<(TResult, int)> PostJson<TResult>(string url, string postData)
        {
            using (var httpClient = new HttpClient())
            {
                var httpContent = new StringContent(postData, Encoding.UTF8, "application/json");
                var httpResponse = await httpClient.PostAsync(url, httpContent);

                int result = (int)ResponseCode.Error;
                var response = await httpResponse.Content.ReadFromJsonAsync<TResult>();

                if ((int)httpResponse.StatusCode == 200)
                {
                    if (httpResponse.Content != null)
                    {
                        try
                        {
                            var responseContent = await httpResponse.Content.ReadAsStringAsync();
                            var objResponseContent = JsonConvert.DeserializeObject<TResult>(responseContent);

                            if (objResponseContent != null)
                            {
                                response = objResponseContent;
                                result = (int)ResponseCode.Success;
                            }
                            else
                            {
                                result = (int)ResponseCode.Error;
                            }

                        }
                        catch (Exception) { }
                    }
                }

                return await Task.FromResult((response, result));
            }
        }

        public static async Task<T> DecomposeToken<T>(string token)
        {
            if (token == null || ("").Equals(token))
            {
                return default(T);
            }

            /***
             * Make string valid for FromBase64String
             * FromBase64String cannot accept '.' characters and only accepts stringth whose length is a multitude of 4
             * If the string doesn't have the correct length trailing padding '=' characters should be added.
             */
            int indexOfFirstPoint = token.IndexOf('.') + 1;
            string toDecode = token.Substring(indexOfFirstPoint, token.LastIndexOf('.') - indexOfFirstPoint);
            while (toDecode.Length % 4 != 0)
            {
                toDecode += '=';
            }

            //Decode the string
            string decodedString = Encoding.ASCII.GetString(Convert.FromBase64String(toDecode));
            return JsonConvert.DeserializeObject<T>(decodedString);
        }
    }
}
