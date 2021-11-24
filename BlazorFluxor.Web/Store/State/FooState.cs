using BlazorFluxor.Models;
using System.Collections.Generic;

namespace BlazorFluxor.Web.Store.State
{
    public class FooState : RootState
    {
        public FooState(bool isLoading, string? currentErrorMessage, IEnumerable<FooDto>? foos)
            : base(isLoading, currentErrorMessage)
        {
            Foos = foos;
        }

        public IEnumerable<FooDto>? Foos { get; }

    }
}