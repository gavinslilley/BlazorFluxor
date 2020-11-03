using Fluxor;
using Microsoft.Extensions.Logging;
using BlazorFluxor.Store.Actions.BarActions;
using BlazorFluxor.Store.Actions.FooActions;

namespace BlazorFluxor.Services
{
    public class StateFacade
    {
        private readonly ILogger<StateFacade> _logger;
        private readonly IDispatcher _dispatcher;

        public StateFacade(ILogger<StateFacade> logger, IDispatcher dispatcher) =>
            (_logger, _dispatcher) = (logger, dispatcher);

        public void LoadFoo()
        {
            _logger.LogInformation("Issuing action to load foo...");
            _dispatcher.Dispatch(new LoadFooAction());
        }
        public void LoadBar()
        {
            _logger.LogInformation("Issuing action to load bar...");
            _dispatcher.Dispatch(new LoadBarAction());
        }

    }
}