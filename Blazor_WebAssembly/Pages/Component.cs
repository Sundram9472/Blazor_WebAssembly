﻿using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace Blazor_WebAssembly.Pages
{
    public class Component : ComponentBase
    {
        [Inject]
        HttpClient Http { get; set; }

        public string imageUrl { get; set; } = "data:image/jpeg;base64,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";
        public string productName { get; set; } = "Softprodigy System Solutions";
        public string productDescription { get; set; } = "MAKE YOUR BUSINESS A PART OF THE DIGITAL REVOLUTION WITH US!.";
        
        public WeatherForecast[]? forecasts;

        protected override async Task OnInitializedAsync()
        {
            forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
        }

        public class WeatherForecast
        {
            public DateTime Date { get; set; }

            public int TemperatureC { get; set; }

            public string? Summary { get; set; }

            public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        }
    }
}
