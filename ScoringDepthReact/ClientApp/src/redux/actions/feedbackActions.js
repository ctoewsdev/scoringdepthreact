import * as types from "./actionTypes";
import * as feedbackApi from "../../serverapi/feedbackApi";

export function createSuccess(feedback) {
    return { type: types.CREATE_FEEDBACK_SUCCESS, feedback };
}

export function createFeedback(feedback) {

    return function (dispatch, getState) {
        return feedbackApi
            .createFeedback(feedback)
            .then(createdFeedback => {
                dispatch(createSuccess(createdFeedback));
            })
            .catch(error => {
                throw error;
            });
    };
}