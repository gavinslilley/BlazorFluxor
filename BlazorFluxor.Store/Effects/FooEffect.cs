using Fluxor;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using BlazorFluxor.Models;
using BlazorFluxor.Web.Store.Actions.FooActions;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorFluxor.Web.Store.Effects
{
    public class FooEffect
    {
        private readonly ILogger<FooEffect> _logger;
        private readonly HttpClient _httpClient;

        public FooEffect(ILogger<FooEffect> logger, HttpClient httpClient) =>
            (_logger, _httpClient) = (logger, httpClient);

        [EffectMethod]
        public async Task HandleAsync(LoadFooAction action, IDispatcher dispatcher)
        {
            try
            {
                _logger.LogInformation("Loading foos...");

                Random rnd = new Random();
                await Task.Delay(TimeSpan.FromMilliseconds(rnd.Next(300, 1000)));
                var fooResponse = await _httpClient.GetFromJsonAsync<IEnumerable<FooDto>>("sample-data/foobar.json");

                _logger.LogInformation("Foos loaded successfully!");
                dispatcher.Dispatch(new LoadFooSuccessAction(fooResponse));
            }
            catch (Exception e)
            {
                _logger.LogError($"Error loading foos, reason: {e.Message}");
                dispatcher.Dispatch(new LoadFooFailureAction(e.Message));
            }

        }
    }
}