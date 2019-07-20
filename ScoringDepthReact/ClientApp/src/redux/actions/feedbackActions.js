import * as types from "./actionTypes";

export function createFeedback(feedback) {
    return { type: types.CREATE_FEEDBACK, feedback };
}
