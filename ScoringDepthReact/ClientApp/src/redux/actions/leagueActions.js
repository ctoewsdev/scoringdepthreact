import * as types from "./actionTypes";
import * as leagueApi from "../../serverapi/leagueApi";

export function loadSuccess(leagues) {
    return { type: types.LOAD_LEAGUES_SUCCESS, leagues };
}

// thunk
export function loadLeagues() {
    //thunk injects 'dispatch'
    return function (dispatch) {
        return leagueApi
            .getLeagues()
            //promise returns 'leagues'
            .then(leagues => {
                dispatch(loadSuccess(leagues));
            })
            .catch(error => {
                throw error;
            });
    };
}
