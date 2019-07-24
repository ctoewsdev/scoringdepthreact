import { combineReducers } from "redux";
import feedback from "./feedbackReducer";
import leagues from "./leagueReducer";
import regions from "./regionReducer";
import seasons from "./seasonReducer";

const rootReducer = combineReducers({
    feedback,
    leagues,
    regions,
    seasons
});

export default rootReducer;
