import * as types from "./actionTypes";
import * as regionApi from "../../serverapi/regionApi";

export function loadSuccess(regions) {
    return { type: types.LOAD_REGIONS_SUCCESS, regions };
}

// thunk
export function loadRegions() {
    return function (dispatch) {
        return regionApi
            .getRegions()
            .then(regions => {
                dispatch(loadSuccess(regions));
            })
            .catch(error => {
                throw error;
            });
    };
}

export function loadRegionsByYear() {
    return function (dispatch) {
        return regionApi
            .getRegions()
            .then(regions => {
                dispatch(loadSuccess(regions));
            })
            .catch(error => {
                throw error;
            });
    };
}
