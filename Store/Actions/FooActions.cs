using BlazorFluxor.Models;
using System.Collections.Generic;
using BlazorFluxor.Store.Shared.Actions;

namespace BlazorFluxor.Store.Actions.FooActions
{
    public class LoadFooAction
    {
    }
    public class LoadFooSuccessAction
    {
        public LoadFooSuccessAction(IEnumerable<FooDto> foos) =>
            Foos = foos;

        public IEnumerable<FooDto> Foos { get; }
    }

    public class LoadFooFailureAction : FailureAction
    {
        public LoadFooFailureAction(string errorMessage)
            : base(errorMessage)
        {
        }
    }
}