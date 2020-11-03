using BlazorFluxor.Models;
using System.Collections.Generic;
using BlazorFluxor.Store.Shared.Actions;

namespace BlazorFluxor.Store.Actions.BarActions
{
    public class LoadBarAction
    {
    }
    public class LoadBarSuccessAction
    {
        public LoadBarSuccessAction(IEnumerable<BarDto> bars) =>
            Bars = bars;

        public IEnumerable<BarDto> Bars { get; }
    }

    public class LoadBarFailureAction : FailureAction
    {
        public LoadBarFailureAction(string errorMessage)
            : base(errorMessage)
        {
        }
    }
}