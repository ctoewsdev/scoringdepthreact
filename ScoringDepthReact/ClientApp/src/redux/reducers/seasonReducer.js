import * as types from "../actions/actionTypes";
import initialState from "./initialState";

export default function seasonReducer(state = initialState.seasons, action) {
    switch (action.type) {
        case types.LOAD_SEASONS_SUCCESS:
            return action.seasons;
        default:
            return state;
    }
}
