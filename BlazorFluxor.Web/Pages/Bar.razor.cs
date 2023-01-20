
using BlazorFluxor.Store.State;
using BlazorFluxor.Web.Services;
using Fluxor;
using Microsoft.AspNetCore.Components;

namespace BlazorFluxor.Web.Pages
{
    public partial class Bar
    {
        [Inject] private IState<BarState> BarState { get; set; }
        [Inject] private StateFacade Facade { get; set; }

        protected override void OnInitialized()
        {
            if (BarState.Value.Bars is null)
            {
                Facade.LoadBar();
            }

            base.OnInitialized();
        }
    }

}

