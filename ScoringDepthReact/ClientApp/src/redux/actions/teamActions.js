import * as types from "./actionTypes";
import * as teamApi from "../../serverapi/teamApi";

export function loadSuccess(seasons) {
    return { type: types.LOAD_TEAMS_SUCCESS, teams };
}

// thunk
export function loadTeams() {
    return function (dispatch) {
        return teamApi
            .getTeams()
            .then(teams => {
                dispatch(loadSuccess(teams));
            })
            .catch(error => {
                throw error;
            });
    };
}