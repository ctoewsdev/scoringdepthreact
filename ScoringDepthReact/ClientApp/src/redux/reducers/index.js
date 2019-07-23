import { combineReducers } from "redux";
import feedback from "./feedbackReducer";
import leagues from "./leagueReducer";
import regions from "./regionReducer";

const rootReducer = combineReducers({
    feedback,
    leagues,
    regions
});

export default rootReducer;
