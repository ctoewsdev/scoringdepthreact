import * as types from "./actionTypes";
import * as seasonRankingApi from "../../serverapi/seasonRankingApi";

export function loadBySLIdSuccess(seasonRankings) {
    return { type: types.LOAD_SEASONRANKINGS_BYSEASONLEAGUE_SUCCESS, seasonRankings };
}

export function loadSuccess(seasonRankings) {
    return { type: types.LOAD_SEASONRANKINGS_SUCCESS, seasonRankings };
}

// thunk
export function loadSeasonRankings() {
    return function (dispatch) {
        return seasonRankingApi
            .getSeasonRankings()
            .then(seasonRankings => {
                dispatch(loadSuccess(seasonRankings));
            })
            .catch(error => {
                throw error;
            });
    };
}

//export function loadSeasonRanking(seasonLeagueId) {
//    return function (dispatch) {
//        return seasonRankingApi
//            .getSeasonRanking(seasonLeagueId)
//            .then(seasonRankings => {
//                dispatch(loadBySLIdSuccess(seasonRankings));
//            })
//            .catch(error => {
//                throw error;
//            });
//    };
//}