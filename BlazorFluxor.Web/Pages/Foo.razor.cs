
using BlazorFluxor.Store.State;
using BlazorFluxor.Web.Services;
using Fluxor;
using Microsoft.AspNetCore.Components;

namespace BlazorFluxor.Web.Pages
{
    public partial class Foo
    {
        [Inject] private IState<FooState> FooState { get; set; }
        [Inject] private StateFacade Facade { get; set; }

        protected override void OnInitialized()
        {
            if (FooState.Value.Foos is null)
            {
                Facade.LoadFoo();
            }

            base.OnInitialized();
        }
    }

}

