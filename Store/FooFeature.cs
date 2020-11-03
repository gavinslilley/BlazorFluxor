using Fluxor;
using BlazorFluxor.Store.State;

namespace BlazorFluxor.Store
{
    public class FooFeature : Feature<FooState>
    {
        public override string GetName() => "Foos";

        protected override FooState GetInitialState() =>
            new FooState(false, null, null);
    }
}