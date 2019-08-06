import * as types from "../actions/actionTypes";
import initialState from "./initialState";

export default function sdIndexReducer(state = initialState.sdIndices, action) {
    switch (action.type) {
        case types.LOAD_SDINDICES_SUCCESS:
            return action.sdIndices;
        default:
            return state;
    }
}