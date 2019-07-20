import * as types from "../actions/actionTypes";

export default function leagueReducer(state = [], action) {
    switch (action.type) {
        case types.LOAD_LEAGUES_SUCCESS:
            return action.leagues;
        default:
            return state;
    }
}
