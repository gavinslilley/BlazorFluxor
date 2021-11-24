using BlazorFluxor.Models;
using System.Collections.Generic;

namespace BlazorFluxor.Web.Store.State
{
    public class BarState : RootState
    {
        public BarState(bool isLoading, string? currentErrorMessage, IEnumerable<BarDto>? bars)
            : base(isLoading, currentErrorMessage)
        {
            Bars = bars;
        }

        public IEnumerable<BarDto>? Bars { get; }

    }
}