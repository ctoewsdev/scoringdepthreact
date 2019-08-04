import * as types from "./actionTypes";
import * as seasonApi from "../../serverapi/seasonApi";

export function loadSuccess(seasons) {
    return { type: types.LOAD_SEASONS_SUCCESS, seasons };
}

// thunk
export function loadSeasons() {
    return function (dispatch) {
        return seasonApi
            .getSeasons()
            .then(seasons => {
                dispatch(loadSuccess(seasons));
            })
            .catch(error => {
                throw error;
            });
    };
}