import { combineReducers } from "redux";
import feedbacks from "./feedbackReducer";
import leagues from "./leagueReducer";

const rootReducer = combineReducers({
    feedbacks,
    leagues
});

export default rootReducer;
