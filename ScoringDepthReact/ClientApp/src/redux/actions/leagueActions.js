import * as types from "./actionTypes";
import * as leagueApi from "../../serverapi/leagueApi";

export function loadLeagueSuccess(leagues) {
    return { type: types.LOAD_LEAGUES_SUCCESS, leagues };
}

// thunk
export function loadLeagues() {
    return function (dispatch) {
        return leagueApi
            .getLeagues()
            .then(leagues => {
                dispatch(loadLeagueSuccess(leagues));
            })
            .catch(error => {
                throw error;
            });
    };
}
