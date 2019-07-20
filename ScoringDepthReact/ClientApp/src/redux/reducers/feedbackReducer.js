import * as types from "../actions/actionTypes";

export default function feedbackReducer(state = [], action) {
  switch (action.type) {
      case types.CREATE_FEEDBACK:
          //I dont need to use an array here because I am just submitting one object
      return [...state, { ...action.feedback }];
    default:
      return state;
  }
}
