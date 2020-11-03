using Fluxor;
using BlazorFluxor.Store.State;

namespace BlazorFluxor.Store
{
    public class BarFeature : Feature<BarState>
    {
        public override string GetName() => "Bars";

        protected override BarState GetInitialState() =>
            new BarState(false, null, null);
    }
}