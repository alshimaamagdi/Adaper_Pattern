using Adaper_Pattern.Adapter;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using toutorial.usedClasses;

namespace toutorial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpPost("CaculateValueAdaptor")]
        public async Task <IActionResult> CaculateValue(Employee emp)
        {
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = "https://localhost:7204/api/PayrollCalculator/CaculateValue";
                var NewShapeFromClass = new EmployeeAdapter(emp);
                string jsonContent = JsonSerializer.Serialize(NewShapeFromClass);
                // Prepare data to send in the request body
                var postData = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                // Send POST request
                HttpResponseMessage response = await client.PostAsync(apiUrl, postData);

                // Check if the request was successful
                if (response.IsSuccessStatusCode)
                {
                    // Read and process the response
                    string result = await response.Content.ReadAsStringAsync();
                    return Ok(result);

                }
                else
                {
                    return Ok(response.StatusCode);

                    // Handle error
                }
            }

            return Ok();
        }
    }
}
