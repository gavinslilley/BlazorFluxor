using BlazorFluxor.Models;
using Fluxor;
using System.Collections.Generic;

namespace BlazorFluxor.Store.State;
[ReducerMethod]
public class FooState : RootState
{
    public FooState(bool isLoading, string? currentErrorMessage, IEnumerable<FooDto>? foos)
        : base(isLoading, currentErrorMessage)
    {
        Foos = foos;
    }

    public IEnumerable<FooDto>? Foos { get; }

}
