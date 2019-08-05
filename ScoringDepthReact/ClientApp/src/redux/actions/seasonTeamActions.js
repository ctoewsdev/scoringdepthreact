import * as types from "./actionTypes";
import * as seasonTeamApi from "../../serverapi/seasonTeamApi";

export function loadSuccess(seasonTeams) {
    return { type: types.LOAD_SEASONTEAMS_SUCCESS, seasonTeams };
}

// thunk
export function loadSeasonTeams() {
    return function (dispatch) {
        return seasonTeamApi
            .getSeasonTeams()
            .then(seasonTeams => {
                dispatch(loadSuccess(seasonTeams));
            })
            .catch(error => {
                throw error;
            });
    };
}