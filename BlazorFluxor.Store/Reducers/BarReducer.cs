using Fluxor;
using BlazorFluxor.Web.Store.Actions.BarActions;
using BlazorFluxor.Store.State;

namespace BlazorFluxor.Web.Store.Reducers;
public static class BarReducer
{
    [ReducerMethod]
    public static BarState ReduceLoadBarAction(BarState state, LoadBarAction _) =>
        new BarState(true, null, state.Bars);

    [ReducerMethod]
    public static BarState ReduceLoadBarSuccessAction(BarState state, LoadBarSuccessAction action) =>
        new BarState(false, null, action.Bars);

    [ReducerMethod]
    public static BarState ReduceLoadBarFailureAction(BarState state, LoadBarFailureAction action) =>
        new BarState(false, action.ErrorMessage, state.Bars);
}
