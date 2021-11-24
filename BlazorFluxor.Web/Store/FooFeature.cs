using Fluxor;
using BlazorFluxor.Web.Store.State;

namespace BlazorFluxor.Web.Store
{
    public class FooFeature : Feature<FooState>
    {
        public override string GetName() => "Foos";

        protected override FooState GetInitialState() =>
            new FooState(false, null, null);
    }
}