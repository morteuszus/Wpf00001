using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Windows;
using System.ComponentModel;

namespace Wpf00001.Core
{
    public class APIClient
    {
        public static async Task Aaa()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://cfd2-195-238-168-6.eu.ngrok.io");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await client.GetAsync("api/issue");
            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
            {
                var issues = await response.Content.ReadFromJsonAsync<IEnumerable<IssueDto>>();

                foreach (var issue in issues)
                {
                    MessageBox.Show(issue.Title);
                }
            }
            else
            {
                MessageBox.Show("Error- cant connect to HttpClient");
            }
        }
    }
}
