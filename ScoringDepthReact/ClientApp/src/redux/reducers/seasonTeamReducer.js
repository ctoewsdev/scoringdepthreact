import * as types from "../actions/actionTypes";
import initialState from "./initialState";

export default function seasonTeamReducer(state = initialState.seasonTeams, action) {
    switch (action.type) {
        case types.LOAD_SEASONTEAMS_SUCCESS:
            return action.seasonTeams;
        default:
            return state;
    }
}