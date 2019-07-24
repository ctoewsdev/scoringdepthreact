import * as types from "../actions/actionTypes";
import initialState from "./initialState";

export default function feedbackReducer(state = initialState.feedback, action) {
  switch (action.type) {
      case types.CREATE_FEEDBACK_SUCCESS:
          //I dont need to use an array here because I am just submitting one object
      return [...state, { ...action.feedback }];
    default:
      return state;
  }
}
