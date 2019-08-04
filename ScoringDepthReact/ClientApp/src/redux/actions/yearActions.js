import * as types from "./actionTypes";
import * as yearApi from "../../serverapi/yearApi";

export function loadSuccess(years) {
    return { type: types.LOAD_YEARS_SUCCESS, years };
}

// thunk
export function loadYears() {
    return function (dispatch) {
        return yearApi
            .getYears()
            .then(years => {
                dispatch(loadSuccess(years));
            })
            .catch(error => {
                throw error;
            });
    };
}