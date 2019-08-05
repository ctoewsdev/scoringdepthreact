import * as types from "./actionTypes";
import * as teamRankingApi from "../../serverapi/teamRankingApi";

export function loadSuccess(teamRankings) {
    return { type: types.LOAD_TEAMRANKINGS_SUCCESS, teamRankings };
}

// thunk
export function loadTeamRankings() {
    return function (dispatch) {
        return teamRankingApi
            .getTeamRankings()
            .then(teamRankings => {
                dispatch(loadSuccess(teamRankings));
            })
            .catch(error => {
                throw error;
            });
    };
}