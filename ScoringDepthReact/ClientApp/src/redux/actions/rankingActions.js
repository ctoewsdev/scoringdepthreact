import * as types from "./actionTypes";
import * as rankingApi from "../../serverapi/rankingApi";

export function loadSuccess(rankings) {
    return { type: types.LOAD_RANKINGS_SUCCESS, rankings };
}

// thunk
export function loadRankings() {
    return function (dispatch) {
        return rankingApi
            .getRankings()
            .then(rankings => {
                dispatch(loadSuccess(rankings));
            })
            .catch(error => {
                throw error;
            });
    };
}