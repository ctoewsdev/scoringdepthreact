const requestLeaguesType = "REQUEST_LEAGUES";
const receiveLeaguesType = "RECEIVE_LEAGUES";
const requestLeagueType = "REQUEST_LEAGUE";
const receiveLeagueType = "RECEIVE_LEAGUE";
const initialState = {
    leagues: [], league: {}, isLoading: false
};

let allleagues = [];
let currentleague = {};


export const actionCreators = {
    requestLeagues: () => async (dispatch, getState) => {

        dispatch({ type: requestLeaguesType });

        const url = `api/Leagues`;
        const response = await fetch(url);
        const allleagues = await response.json();

        dispatch({ type: receiveLeaguesType, allleagues });
    },

    requestLeague: (id) => async (dispatch, getState) => {

        dispatch({ type: requestLeagueType });

        const url = `api/Leagues/GetLeague/${id}`;
        const response = await fetch(url);
        const league = await response.json();

        dispatch({ type: receiveLeaguesType, league });
    }
};

export const reducer = (state, action) => {
    state = state || initialState;

    if (action.type === requestLeaguesType) {
        return {
            ...state,
            isLoading: true
        };
    }

    if (action.type === receiveLeaguesType) {
        return {
            ...state,
            leagues: action.allleagues,
            isLoading: false
        };
    }

    if (action.type === requestLeagueType) {
        return {
            ...state,
            isLoading: true
        };
    }

    if (action.type === receiveLeagueType) {
        currentleague = action.league
        return {
            ...state,
            league: currentleague,
            isLoading: false
        };
    }

    return state;
};
