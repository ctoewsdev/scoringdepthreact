const requestCountriesType = "REQUEST_COUNTRIES";
const receiveCountriesType = "RECEIVE_COUNTRIES";
const requestCountryType = "REQUEST_COUNTRY";
const receiveCountryType = "RECEIVE_COUNTRY";
const initialState = {
    countries: [], country: {}, isLoading: false
};

let allcountries = [];
let currentcountry = {};


export const actionCreators = {
    requestCountries: () => async (dispatch, getState) => {

        dispatch({ type: requestCountriesType });

        const url = `api/Countries`;
        const response = await fetch(url);
        const allcountries = await response.json();

        dispatch({ type: receiveCountriesType, allcountries });
    },  

    requestCountry: (id) => async (dispatch, getState) => {

        dispatch({ type: requestCountryType });

        const url = `api/Countries/GetCountry/${id}`;
        const response = await fetch(url);
        const country = await response.json();

        dispatch({ type: receiveCountriesType, country });
    }
};

export const reducer = (state, action) => {
    state = state || initialState;

    if (action.type === requestCountriesType) {
        return {
            ...state,
            isLoading: true
        };
    }

    if (action.type === receiveCountriesType) {
        return {
            ...state,
            countries: action.allcountries,
            isLoading: false
        };
    }

    if (action.type === requestCountryType) {
        return {
            ...state,
            isLoading: true
        };
    }

    if (action.type === receiveCountryType) {
        currentcountry = action.country
        return {
            ...state,
            country: currentcountry,
            country: currentcountry,

            isLoading: false
        };
    }

    return state;
};
