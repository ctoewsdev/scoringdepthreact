import { combineReducers } from "redux";
import feedback from "./feedbackReducer";
import leagues from "./leagueReducer";
import regions from "./regionReducer";
import seasons from "./seasonReducer";
import seasonLeagues from "./seasonLeagueReducer";
import years from "./yearReducer";
import countries from "./countryReducer";
import seasonTeams from "./seasonTeamReducer";
import teams from "./teamReducer";
import teamRankings from "./teamRankingReducer";
import rankings from "./rankingReducer";

const rootReducer = combineReducers({
    feedback,
    leagues,
    regions,
    seasons,
    years,
    seasonLeagues,
    countries,
    seasonTeams,
    teams,
    teamRankings,
    rankings
});

export default rootReducer;
