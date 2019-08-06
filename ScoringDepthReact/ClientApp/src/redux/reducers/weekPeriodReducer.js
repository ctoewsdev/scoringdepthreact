import * as types from "../actions/actionTypes";
import initialState from "./initialState";

export default function yearReducer(state = initialState.weekPeriods, action) {
    switch (action.type) {
        case types.LOAD_WEEKPERIODS_SUCCESS:
            return action.weekPeriods;
        default:
            return state;
    }
}