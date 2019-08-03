import { combineReducers } from "redux";
import feedback from "./feedbackReducer";
import leagues from "./leagueReducer";
import regions from "./regionReducer";
import seasons from "./seasonReducer";
import seasonLeagues from "./seasonLeagueReducer";
import years from "./yearReducer";
import countries from "./countryReducer";

const rootReducer = combineReducers({
    feedback,
    leagues,
    regions,
    seasons,
    years,
    seasonLeagues,
    countries
});

export default rootReducer;
