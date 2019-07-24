import * as types from "./actionTypes";
import * as leagueApi from "../../serverapi/leagueApi";

export function loadSuccess(leagues) {
    return { type: types.LOAD_LEAGUES_SUCCESS, leagues };
}

// thunk
export function loadLeagues() {
    return function (dispatch) {
        return leagueApi
            .getLeagues()
            .then(leagues => {
                dispatch(loadSuccess(leagues));
            })
            .catch(error => {
                throw error;
            });
    };
}
