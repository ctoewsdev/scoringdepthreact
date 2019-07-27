import * as types from "../actions/actionTypes";
import initialState from "./initialState";

export default function yearReducer(state = initialState.years, action) {
    switch (action.type) {
        case types.LOAD_YEARS_SUCCESS:
            return action.years;
        default:
            return state;
    }
}
