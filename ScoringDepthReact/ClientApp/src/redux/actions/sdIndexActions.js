import * as types from "./actionTypes";
import * as sdIndexApi from "../../serverapi/sdIndexApi";

export function loadSuccess(sdIndices) {
    return { type: types.LOAD_SDINDICES_SUCCESS, sdIndices };
}

// thunk
export function loadSdIndices() {
    return function (dispatch) {
        return sdIndexApi
            .getSdIndices()
            .then(sdIndices => {
                dispatch(loadSuccess(sdIndices));
            })
            .catch(error => {
                throw error;
            });
    };
}