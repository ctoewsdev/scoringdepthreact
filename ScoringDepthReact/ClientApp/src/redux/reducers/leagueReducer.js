import * as types from "../actions/actionTypes";
import initialState from "./initialState";

export default function leagueReducer(state = initialState.leagues, action) {
    switch (action.type) {
        case types.LOAD_LEAGUES_SUCCESS:
            return action.leagues;
        default:
            return state;
    }
}