import * as types from "./actionTypes";
import * as weekPeriodApi from "../../serverapi/weekPeriodApi";

export function loadSuccess(weekPeriods) {
    return { type: types.LOAD_WEEKPERIODS_SUCCESS, weekPeriods };
}

// thunk
export function loadWeekPeriods() {
    return function (dispatch) {
        return weekPeriodApi
            .getWeekPeriods()
            .then(weekPeriods => {
                dispatch(loadSuccess(weekPeriods));
            })
            .catch(error => {
                throw error;
            });
    };
}