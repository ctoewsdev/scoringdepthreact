import { combineReducers } from "redux";
import feedbacks from "./feedbackReducer";
import leagues from "./leagueReducer";
import regions from "./regionReducer";

const rootReducer = combineReducers({
    feedbacks,
    leagues,
    regions
});

export default rootReducer;
