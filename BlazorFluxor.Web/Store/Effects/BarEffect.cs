using Fluxor;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using BlazorFluxor.Models;
using BlazorFluxor.Web.Store.Actions.BarActions;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorFluxor.Web.Store.Effects
{
    public class BarEffect : Effect<LoadBarAction>
    {
        private readonly ILogger<BarEffect> _logger;
        private readonly HttpClient _httpClient;

        public BarEffect(ILogger<BarEffect> logger, HttpClient httpClient) =>
            (_logger, _httpClient) = (logger, httpClient);

        public override async Task HandleAsync(LoadBarAction action, IDispatcher dispatcher)
        {
            try
            {
                _logger.LogInformation("Loading Bars...");

                Random rnd = new Random();
                await Task.Delay(TimeSpan.FromMilliseconds(rnd.Next(300, 1000)));
                var BarResponse = await _httpClient.GetFromJsonAsync<IEnumerable<BarDto>>("sample-data/foobar.json");

                _logger.LogInformation("Bars loaded successfully!");
                dispatcher.Dispatch(new LoadBarSuccessAction(BarResponse));
            }
            catch (Exception e)
            {
                _logger.LogError($"Error loading bars, reason: {e.Message}");
                dispatcher.Dispatch(new LoadBarFailureAction(e.Message));
            }

        }
    }
}