import { combineReducers } from "redux";
import feedback from "./feedbackReducer";
import leagues from "./leagueReducer";
import regions from "./regionReducer";
import seasons from "./seasonReducer";
import seasonLeagues from "./seasonLeagueReducer";
import years from "./yearReducer";
import countries from "./countryReducer";
import seasonRankings from "./seasonRankingReducer";
import teams from "./teamReducer";
import teamRankings from "./teamRankingReducer";
import weekPeriods from "./weekPeriodReducer";
import sdIndices from "./sdIndexReducer";

const rootReducer = combineReducers({
    feedback,
    leagues,
    regions,
    seasons,
    years,
    seasonLeagues,
    countries,
    seasonRankings,
    teams,
    teamRankings,
    weekPeriods,
    sdIndices
});

export default rootReducer;
