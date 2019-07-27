import * as types from "./actionTypes";
import * as countryApi from "../../serverapi/countryApi";

export function loadSuccess(countries) {
    return { type: types.LOAD_COUNTRIES_SUCCESS, countries };
}

// thunk
export function loadCountries() {
    return function (dispatch) {
        return countryApi
            .getCountries()
            .then(countries => {
                dispatch(loadSuccess(countries));
            })
            .catch(error => {
                throw error;
            });
    };
}
