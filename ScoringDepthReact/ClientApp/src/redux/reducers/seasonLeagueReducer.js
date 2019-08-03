import * as types from "../actions/actionTypes";
import initialState from "./initialState";

export default function seasonLeagueReducer(state = initialState.seasonLeagues, action) {
    switch (action.type) {
        case types.LOAD_SEASONLEAGUES_SUCCESS:
            return action.seasonLeagues;
        default:
            return state;
    }
}
