using HelpDeskServiceHelper.HelpDeskHttpClient.Interfaces;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;

namespace HelpDeskServiceHelper.HelpDeskHttpClient.Default.Implementations
{
    public class HelpDeskHttpClientDefault : IHelpDeskHttpClient
    {
        public async Task GetCITypeDetails(string nameCIType, CancellationToken cancellationToken = default)
        {
            /*
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://help.crocusgroup.ru");
            httpClient.DefaultRequestHeaders.Add("authtoken", "");
            //httpClient.DefaultRequestHeaders.Add("Content-Type", "application/x-www-form-urlencoded");
            
            var rm = new HttpRequestMessage(HttpMethod.Post, $"api/cmdb/ci/citype/{nameCIType}");
            //rm.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            //.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
            HttpContent content = new StringContent($"{{\n\t\"OPERATION_NAME\": \"GET\",\n\t\"format\": \"json\"\n}}", 
                Encoding.UTF8, "application/x-www-form-urlencoded");
            
            rm.Content = content;

            var res = await httpClient.SendAsync(rm, cancellationToken);

            var stringContent = await res.Content.ReadAsStringAsync();
            */

            /*
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://help.crocusgroup.ru");
            httpClient.DefaultRequestHeaders.Add("authtoken", "");
            //httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.manageengine.sdp.v3+json"));
            //httpClient.DefaultRequestHeaders.Add("Content-Type", "application/x-www-form-urlencoded");
            //httpClient.DefaultRequestHeaders.Add("X-ZCSRF-TOKEN", "");
            //var rm = new HttpRequestMessage(HttpMethod.Get, $"api/cmdb/ci/list/all?format=json&OPERATION_NAME=GET&PORTALID=1&TECHNICIAN_KEY=");
            var rm = new HttpRequestMessage(HttpMethod.Get, $"api/cmdb/citype/Printer?format=json&OPERATION_NAME=read&PORTALID=1&TECHNICIAN_KEY=");
            //rm.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            //.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
            //$"{{\n\t\"OPERATION_NAME\": \"read\",\n\t\"format\": \"json\"\n}}"
            HttpContent content = new StringContent("",
                Encoding.UTF8, "application/x-www-form-urlencoded");
            
            rm.Content = content;

            var res = await httpClient.SendAsync(rm, cancellationToken);

            var stringContent = await res.Content.ReadAsStringAsync();
            */
            /*
            string jsonReq = "{\r\n\t\"list_info\": {\r\n\t\t\"start_index\": 0,\r\n\t\t\"row_count\": 100,\r\n\t\t\"sort_field\": \"name\",\r\n\t\t\"search_criteria\": {\r\n\t\t\t\"field\": \"product_type\",\r\n\t\t\t\"condition\": \"is\",\r\n\t\t\t\"value\": {\r\n\t\t\t\t\"internal_name\":\"Printer\",\r\n\t\t\t\t\"name\":\"Printer\",\r\n\t\t\t\t\"id\":\"2\",\r\n\t\t\t\t\"type\": {\r\n\t\t\t\t\t\"name\":\"Asset\",\r\n\t\t\t\t\t\"id\":\"1\"\r\n\t\t\t\t}\r\n\t\t\t}\r\n\t\t},\r\n\t\t\"fields_required\": [\r\n\t\t\t\"id\",\r\n\t\t\t\"name\",\r\n\t\t\t\"product_type\",\r\n\t\t\t\"manufacturer\"\r\n\t\t]\r\n\t}\r\n}";
            string inUrlEncode = WebUtility.UrlEncode(jsonReq);

            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://help.crocusgroup.ru");
            httpClient.DefaultRequestHeaders.Add("authtoken", "");
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.manageengine.sdp.v3+json"));
            //httpClient.DefaultRequestHeaders.Add("Content-Type", "application/x-www-form-urlencoded");
            //httpClient.DefaultRequestHeaders.Add("X-ZCSRF-TOKEN", "");
            //var rm = new HttpRequestMessage(HttpMethod.Get, $"api/cmdb/ci/list/all?format=json&OPERATION_NAME=GET&PORTALID=1&TECHNICIAN_KEY=");
            var rm = new HttpRequestMessage(HttpMethod.Get, $"api/v3/products?input_data={inUrlEncode}");
            //rm.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            //.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
            //$"{{\n\t\"OPERATION_NAME\": \"read\",\n\t\"format\": \"json\"\n}}"
            HttpContent content = new StringContent("",
                Encoding.UTF8, "application/x-www-form-urlencoded");

            rm.Content = content;

            var res = await httpClient.SendAsync(rm, cancellationToken);

            var stringContent = await res.Content.ReadAsStringAsync();
            */

            /*
            //string jsonReq = "{\r\n\t\"list_info\": {\r\n\t\t\"start_index\": 0,\r\n\t\t\"row_count\": 100,\r\n\t\t\"sort_field\": \"name\",\r\n\t\t\"search_criteria\": {\r\n\t\t\t\"field\": \"product_type\",\r\n\t\t\t\"condition\": \"is\",\r\n\t\t\t\"value\": {\r\n\t\t\t\t\"internal_name\":\"Printer\",\r\n\t\t\t\t\"name\":\"Printer\",\r\n\t\t\t\t\"id\":\"2\",\r\n\t\t\t\t\"type\": {\r\n\t\t\t\t\t\"name\":\"Asset\",\r\n\t\t\t\t\t\"id\":\"1\"\r\n\t\t\t\t}\r\n\t\t\t}\r\n\t\t},\r\n\t\t\"fields_required\": [\r\n\t\t\t\"id\",\r\n\t\t\t\"name\",\r\n\t\t\t\"product_type\",\r\n\t\t\t\"manufacturer\"\r\n\t\t]\r\n\t}\r\n}";
            //string jsonReq = "{\r\n  \"product\": {\r\n    \"product_type\": {\r\n      \"name\": \"Printer\",\r\n      \"id\": \"2\"\r\n    },\r\n    \"name\": \"test-name_001\",\r\n    \"manufacturer\": \"test-manufacturer\",\r\n    \"description\": \"TestDescription_001\"\r\n  }\r\n}";
            string jsonReq = "{\r\n  \"product\": {\r\n    \"description\": \"TestDescription_Update_002\"\r\n  }\r\n}";

            string inUrlEncode = WebUtility.UrlEncode(jsonReq);

            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://help.crocusgroup.ru");
            httpClient.DefaultRequestHeaders.Add("authtoken", "");
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.manageengine.sdp.v3+json"));
            //var rm = new HttpRequestMessage(HttpMethod.Get, $"api/cmdb/ci/list/all?format=json&OPERATION_NAME=GET&PORTALID=1&TECHNICIAN_KEY=");
            var rm = new HttpRequestMessage(HttpMethod.Put, $"api/v3/products/13516");
            

            HttpContent content = new StringContent($"",
                Encoding.UTF8, "application/x-www-form-urlencoded");

            rm.Content = content;

            var res = await httpClient.SendAsync(rm, cancellationToken);

            var stringContent = await res.Content.ReadAsStringAsync();
            */

            /*
            string jsonReq = "{\r\n  \"product\": {\r\n    \"description\": \"TestDescription_Update_002\"\r\n  }\r\n}";

            string inUrlEncode = WebUtility.UrlEncode(jsonReq);

            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://help.crocusgroup.ru");
            httpClient.DefaultRequestHeaders.Add("authtoken", "");
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.manageengine.sdp.v3+json"));
            //var rm = new HttpRequestMessage(HttpMethod.Get, $"api/cmdb/ci/list/all?format=json&OPERATION_NAME=GET&PORTALID=1&TECHNICIAN_KEY=");
            var rm = new HttpRequestMessage(HttpMethod.Get, $"api/v3/levels/303?");//input_data={inUrlEncode}
            //products/13516

            HttpContent content = new StringContent($"input_data={inUrlEncode}",
                Encoding.UTF8, "application/x-www-form-urlencoded");

            rm.Content = content;

            var res = await httpClient.SendAsync(rm, cancellationToken);

            var stringContent = await res.Content.ReadAsStringAsync();
            */
            /*
            //string jsonReq = "{\r\n\t\"list_info\": {\r\n\t\t\"start_index\": 0,\r\n\t\t\"row_count\": 100,\r\n\t\t\"sort_field\": \"name\",\r\n\t\t\"search_criteria\": {\r\n\t\t\t\"field\": \"product_type\",\r\n\t\t\t\"condition\": \"is\",\r\n\t\t\t\"value\": {\r\n\t\t\t\t\"internal_name\":\"Printer\",\r\n\t\t\t\t\"name\":\"Printer\",\r\n\t\t\t\t\"id\":\"2\",\r\n\t\t\t\t\"type\": {\r\n\t\t\t\t\t\"name\":\"Asset\",\r\n\t\t\t\t\t\"id\":\"1\"\r\n\t\t\t\t}\r\n\t\t\t}\r\n\t\t},\r\n\t\t\"fields_required\": [\r\n\t\t\t\"id\",\r\n\t\t\t\"name\",\r\n\t\t\t\"product_type\",\r\n\t\t\t\"manufacturer\"\r\n\t\t]\r\n\t}\r\n}";
            //string inUrlEncode = WebUtility.UrlEncode(jsonReq);

            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://help.crocusgroup.ru");
            httpClient.DefaultRequestHeaders.Add("authtoken", "");
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.manageengine.sdp.v3+json"));
            //httpClient.DefaultRequestHeaders.Add("Content-Type", "application/x-www-form-urlencoded");
            //httpClient.DefaultRequestHeaders.Add("X-ZCSRF-TOKEN", "");
            //var rm = new HttpRequestMessage(HttpMethod.Get, $"api/cmdb/ci/list/all?format=json&OPERATION_NAME=GET&PORTALID=1&TECHNICIAN_KEY=");
            var rm = new HttpRequestMessage(HttpMethod.Post, $"sdapi/admin/category?format=json&OPERATION_NAME=GET_ALL&TECHNICIAN_KEY=");
            //rm.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            //.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
            //$"{{\n\t\"OPERATION_NAME\": \"read\",\n\t\"format\": \"json\"\n}}"
            HttpContent content = new StringContent("",
                Encoding.UTF8, "application/x-www-form-urlencoded");

            rm.Content = content;

            var res = await httpClient.SendAsync(rm, cancellationToken);

            var stringContent = await res.Content.ReadAsStringAsync();
            */
            /*
            string jsonReq = "{\r\n  \"product\": {\r\n    \"description\": \"TestDescription_Update_002\"\r\n  }\r\n}";

            string inUrlEncode = WebUtility.UrlEncode(jsonReq);

            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://help.crocusgroup.ru");
            httpClient.DefaultRequestHeaders.Add("authtoken", "");
            httpClient.DefaultRequestHeaders.Add("TECHNICIAN_KEY", "");
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.manageengine.sdp.v3+json"));
            var rm = new HttpRequestMessage(HttpMethod.Get, $"api/cmdb/ci/count/all?format=json&OPERATION_NAME=GET_ALL&TECHNICIAN_KEY=");
            //var rm = new HttpRequestMessage(HttpMethod.Get, $"api/v3/levels/303?");//input_data={inUrlEncode}//&PORTALID=1
            //products/13516

            HttpContent content = new StringContent($"",
                Encoding.UTF8, "application/x-www-form-urlencoded");

            rm.Content = content;

            var res = await httpClient.SendAsync(rm, cancellationToken);

            var stringContent = await res.Content.ReadAsStringAsync();
            */

            /*
            string jsonReq = "{\r\n\"product\": {\"name\":\"TestName_001\",  \r\n    \"manufacturer\": \"TestManuf_Update_002\"\r\n  }\r\n}";

            string inUrlEncode = WebUtility.UrlEncode(jsonReq);

            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://help.crocusgroup.ru");
            httpClient.DefaultRequestHeaders.Add("authtoken", "");
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.manageengine.sdp.v3+json"));
            //var rm = new HttpRequestMessage(HttpMethod.Get, $"api/cmdb/ci/list/all?format=json&OPERATION_NAME=GET&PORTALID=1&TECHNICIAN_KEY=");
            var rm = new HttpRequestMessage(HttpMethod.Patch, $"api/v3/products/13516");


            HttpContent content = new StringContent($"input_data={inUrlEncode}",
                Encoding.UTF8, "application/x-www-form-urlencoded");

            rm.Content = content;

            var res = await httpClient.SendAsync(rm, cancellationToken);

            var stringContent = await res.Content.ReadAsStringAsync();
            */


        }
    }
}
