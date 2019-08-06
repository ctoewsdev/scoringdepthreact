import * as types from "../actions/actionTypes";
import initialState from "./initialState";

export default function seasonRankingReducer(state = initialState.seasonRankings, action) {
    switch (action.type) {
        case types.LOAD_SEASONRANKINGS_SUCCESS:
            return action.seasonRankings;
        //case types.LOAD_SEASONRANKINGS_BYSEASONLEAGUE_SUCCESS:
        //    return action.seasonRankings;
        default:
            return state;
    }
}