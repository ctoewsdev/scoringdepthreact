import * as types from "../actions/actionTypes";
import initialState from "./initialState";

export default function rankingReducer(state = initialState.rankings, action) {
    switch (action.type) {
        case types.LOAD_RANKINGS_SUCCESS:
            return action.rankings;
        default:
            return state;
    }
}