import * as types from "../actions/actionTypes";

export default function regionReducer(state = [], action) {
    switch (action.type) {
        case types.LOAD_REGIONS_SUCCESS:
            return action.regions;
        default:
            return state;
    }
}
