using Fluxor;
using BlazorFluxor.Web.Store.Actions.FooActions;
using BlazorFluxor.Store.State;

namespace BlazorFluxor.Web.Store.Reducers;
public static class FooReducer
{
    [ReducerMethod]
    public static FooState ReduceLoadFooAction(FooState state, LoadFooAction _) =>
        new FooState(true, null, state.Foos);

    [ReducerMethod]
    public static FooState ReduceLoadFooSuccessAction(FooState state, LoadFooSuccessAction action) =>
        new FooState(false, null, action.Foos);

    [ReducerMethod]
    public static FooState ReduceLoadFooFailureAction(FooState state, LoadFooFailureAction action) =>
        new FooState(false, action.ErrorMessage, state.Foos);
}
