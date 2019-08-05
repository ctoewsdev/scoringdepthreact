import * as types from "../actions/actionTypes";
import initialState from "./initialState";

export default function teamRankingReducer(state = initialState.teamRankings, action) {
    switch (action.type) {
        case types.LOAD_TEAMRANKINGS_SUCCESS:
            return action.teamRankings;
        default:
            return state;
    }
}