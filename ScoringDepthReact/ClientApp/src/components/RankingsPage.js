import React from "react";
import { connect } from 'react-redux';
import * as yearActions from "../redux/actions/yearActions";
import * as seasonActions from "../redux/actions/seasonActions";
import * as regionActions from "../redux/actions/regionActions";
import * as countryActions from "../redux/actions/countryActions";
import * as leagueActions from "../redux/actions/leagueActions";
import * as seasonLeagueActions from "../redux/actions/seasonLeagueActions";
import * as teamActions from "../redux/actions/teamActions";
import * as seasonTeamActions from "../redux/actions/seasonTeamActions";
import * as teamRankingActions from "../redux/actions/teamRankingActions";
import * as rankingActions from "../redux/actions/rankingActions";
import { bindActionCreators } from "redux";
import PropTypes from "prop-types";
import SeasonTeamList from './SeasonTeamList';
import { Link } from "react-router-dom";

class RankingsPage extends React.Component {

    componentDidMount() {
        const { years, seasons, regions, countries, leagues, seasonLeagues, teams, seasonTeams, TeamRankings, rankings, actions } = this.props;

        if (teams.length === 0) {
            actions.loadTeams().catch(error => {
                alert("Loading teams failed" + error);
            });
        }

        if (seasonTeams.length === 0) {
            actions.loadSeasonTeams().catch(error => {
                alert("Loading seasonTeams failed" + error);
            });
        }

        if (TeamRankings.length === 0) {
            actions.loadTeamRankings().catch(error => {
                alert("Loading teamRankings failed" + error);
            });
        }

        if (rankings.length === 0) {
            actions.loadRankings().catch(error => {
                alert("Loading rankings failed" + error);
            });
        }

        if (leagues.length === 0) {
            actions.loadLeagues().catch(error => {
                alert("Loading leagues failed" + error);
            });
        }

        if (seasonLeagues.length === 0) {
            actions.loadSeasonLeagues().catch(error => {
                alert("Loading seasonLeagues failed" + error);
            });
        }

        if (years.length === 0) {
            actions.loadYears().catch(error => {
                alert("Loading years failed" + error);
            });
        }

        if (seasons.length === 0) {
            actions.loadSeasons().catch(error => {
                alert("Loading seasons failed" + error);
            });
        }


        if (regions.length === 0) {
            actions.loadRegions().catch(error => {
                alert("Loading regions failed" + error);
            });
        }

        if (countries.length === 0) {
            actions.loadCountries().catch(error => {
                alert("Loading countries failed" + error);
            });
        }
    }

    render() {
        return (
            <>
                <h1 class="text-center">League Rankings</h1>
                <h3 class="text-center">
                    <Link to={"/league/" + this.props.seasonId}>{"Go back to select a different league"}</Link>
                </h3>
                <SeasonTeamsList seasonTeams{this.props.seasonTeams} />
            </>
        );
    }
}

RankingsPage.propTypes = {
    teams: PropTypes.array.isRequired,
    rankings: PropTypes.array.isRequired,
    seasonTeams: PropTypes.array.isRequired,
    teamRankings: PropTypes.array.isRequired,
    years: PropTypes.array.isRequired,
    regions: PropTypes.array.isRequired,
    seasons: PropTypes.array.isRequired,
    countries: PropTypes.array.isRequired,
    leagues: PropTypes.array.isRequired,
    seasonLeagues: PropTypes.array.isRequired,
    actions: PropTypes.object.isRequired
};


export function getSeasonTeamsBySeasonLeagueId(seasonTeams, seasonLeagueId) {
    var seasonTeamsList = seasonTeams.filter(seasonTeam => seasonTeam.seasonLeagueId == seasonLeagueId);
    return seasonTeamsList;
}

export function getSeasonId(seasonLeagues, seasonLeagueId) {
    return seasonLeagues.find(s => s.seasonLeagueId == seasonLeagueId).seasonId;
}


function mapStateToProps(state, ownProps) {

    const seasonLeagueId = ownProps.match.params.seasonLeagueId;

    //create and ship seasonId for back navigation
    const seasonId = state.seasonLeagues.length > 0 ? getSeasonId(state.seasonLeagues, seasonLeagueId) : {};

    //get list of teams for only the selected seasonLeague
    var seasonTeamsList = state.seasonTeams.length > 0 ? getSeasonTeamsBySeasonLeagueId(state.seasonTeams, seasonLeagueId) : [];

    return {
        seasonId,

        seasonTeams: seasonsLeaguesList.length === 0 || state.years.length === 0 || state.seasons.length === 0 || state.countries.length === 0 || state.leagues.length === 0 || state.regions.length === 0
            ? []
            : seasonTeamsList.map(seasonTeam => {
                return {
                    ...seasonTeam,
                    //yearName: state.years.find(y => y.yearId === state.seasons.find(s => s.seasonId === seasonLeague.seasonId).yearId).name,
                    teamName: state.teams.find(t => t.teamId === seasonTeam.teamId).name,
                    period: 

                    regionName: state.regions.find(r => r.regionId === state.seasons.find(s => s.seasonId === seasonLeague.seasonId).regionId).name,
                    leagueCode: state.leagues.find(l => l.leagueId === seasonLeague.leagueId).code,
                    leagueName: state.leagues.find(l => l.leagueId === seasonLeague.leagueId).name,
                    countryName: state.countries.find(c => c.countryId === state.regions.find(r => r.regionId === state.seasons.find(s => s.seasonId === seasonLeague.seasonId).regionId).countryId).name,
                };
            }),

        years: state.years,
        regions: state.regions,
        leagues: state.leagues,
        seasons: state.seasons,
        countries: state.countries
    };
}

function mapDispatchToProps(dispatch) {
    return {
        //injects actions into this page component
        actions: {
            loadYears: bindActionCreators(yearActions.loadYears, dispatch),
            loadSeasons: bindActionCreators(seasonActions.loadSeasons, dispatch),
            loadCountries: bindActionCreators(countryActions.loadCountries, dispatch),
            loadRegions: bindActionCreators(regionActions.loadRegions, dispatch),
            loadSeasonLeagues: bindActionCreators(seasonLeagueActions.loadSeasonLeagues, dispatch),
            loadLeagues: bindActionCreators(leagueActions.loadLeagues, dispatch),
            loadTeams: bindActionCreators(teamActions.loadTeams, dispatch),
            loadSeasonTeams: bindActionCreators(seasonTeamActions.loadSeasonTeams, dispatch),
            loadTeamRankings: bindActionCreators(teamRankingActions.loadTeamRankings, dispatch),
            loadRankings: bindActionCreators(rankingActions.loadRankings, dispatch)
        }
    };
}

export default connect(
    mapStateToProps,
    mapDispatchToProps
)(RankingsPage);