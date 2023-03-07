using BlazorFluxor.Models;
using Fluxor;
using System.Collections.Generic;

namespace BlazorFluxor.Store.State;
[ReducerMethod]
public class BarState : RootState
{
    public BarState(bool isLoading, string? currentErrorMessage, IEnumerable<BarDto>? bars)
        : base(isLoading, currentErrorMessage)
    {
        Bars = bars;
    }

    public IEnumerable<BarDto>? Bars { get; }

}
