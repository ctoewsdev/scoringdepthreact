import * as types from "./actionTypes";
import * as seasonApi from "../../serverapi/seasonApi";

export function loadSuccessSeasons(seasons) {
    return { type: types.LOAD_SEASONS_SUCCESS, seasons };
}

// thunk
export function loadSeasons() {
    return function (dispatch) {
        return seasonApi
            .getSeasons()
            .then(seasons => {
                dispatch(loadSuccessSeasons(seasons));
            })
            .catch(error => {
                throw error;
            });
    };
}
