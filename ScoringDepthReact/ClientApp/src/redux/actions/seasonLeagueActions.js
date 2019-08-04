import * as types from "./actionTypes";
import * as seasonLeagueApi from "../../serverapi/seasonLeagueApi";

export function loadSuccess(seasonLeagues) {
    return { type: types.LOAD_SEASONLEAGUES_SUCCESS, seasonLeagues };
}

// thunk
export function loadSeasonLeagues() {
    return function (dispatch) {
        return seasonLeagueApi
            .getSeasonLeagues()
            .then(seasonLeagues => {
                dispatch(loadSuccess(seasonLeagues));
            })
            .catch(error => {
                throw error;
            });
    };
}