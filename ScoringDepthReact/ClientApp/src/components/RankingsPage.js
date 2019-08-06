import React from "react";
import { connect } from 'react-redux';
import * as yearActions from "../redux/actions/yearActions";
import * as seasonActions from "../redux/actions/seasonActions";
import * as regionActions from "../redux/actions/regionActions";
import * as countryActions from "../redux/actions/countryActions";
import * as leagueActions from "../redux/actions/leagueActions";
import * as seasonLeagueActions from "../redux/actions/seasonLeagueActions";
import * as teamActions from "../redux/actions/teamActions";
import * as teamRankingActions from "../redux/actions/teamRankingActions";
import * as seasonRankingActions from "../redux/actions/seasonRankingActions";
import * as sdIndexActions from "../redux/actions/sdIndexActions";
import * as weekPeriodActions from "../redux/actions/weekPeriodActions";
import { bindActionCreators } from "redux";
import PropTypes from "prop-types";
import SeasonRankingsList from './SeasonRankingsList';
import { Link } from "react-router-dom";

class RankingsPage extends React.Component {

    componentDidMount() {
        const { years, seasons, regions, countries, leagues, seasonLeagues, teams, teamRankings, sdIndices, weekPeriods, seasonRankings, actions } = this.props;

        //  const { seasonLeagueId } = this.ownProps.match.params.seasonLeagueId;



        //if (seasonRankings.length === 0) {
        //    //if (Object.keys(seasonLeagueId).length > 0) {
        //    actions.loadSeasonRankings.catch(error => {
        //        alert("Loading seasonRankings failed" + error);
        //    });
        //    //}
        //}


        if (seasonRankings.length === 0) {
            actions.loadSeasonRankings().catch(error => {
                alert("Loading seasonRankings failed" + error);
            });
        
        }


        if (teamRankings.length === 0) {
            actions.loadTeamRankings().catch(error => {
                alert("Loading teamRankings failed" + error);
            });
           
        }

        if (teams.length === 0) {
            actions.loadTeams().catch(error => {
                alert("Loading teams failed" + error);
            });
        }

        if (sdIndices.length === 0) {
            actions.loadSdIndices().catch(error => {
                alert("Loading sdIndices failed" + error);
            });
        }

        if (weekPeriods.length === 0) {
            actions.loadWeekPeriods().catch(error => {
                alert("Loading weekPeriods failed" + error);
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
        console.log("teamRankingsloaded: " + this.props.teamRankings.length);
        console.log("seasonRankingsloaded: " + this.props.seasonRankings.length);
        return (
            <>
                <h1 class="text-center">League Rankings</h1>
                <h3 class="text-center">
                    <Link to={"/league/" + this.props.seasonId}>{"Go back to select a different league"}</Link>
                </h3>
                <SeasonRankingsList seasonRankings={this.props.seasonRankings} />
            </>
        );
    }
}

RankingsPage.propTypes = {
    teams: PropTypes.array.isRequired,
    teamRankings: PropTypes.array.isRequired,
    seasonRankings: PropTypes.array.isRequired,
    years: PropTypes.array.isRequired,
    regions: PropTypes.array.isRequired,
    seasons: PropTypes.array.isRequired,
    countries: PropTypes.array.isRequired,
    leagues: PropTypes.array.isRequired,
    seasonLeagues: PropTypes.array.isRequired,
    weekPeriods: PropTypes.array.isRequired,
    sdIndices: PropTypes.array.isRequired,
    actions: PropTypes.object.isRequired
};

export function getSeasonId(seasonLeagues, seasonLeagueId) {
    return seasonLeagues.find(s => s.seasonLeagueId == seasonLeagueId).seasonId;
}

function mapStateToProps(state, ownProps) {

    const seasonLeagueId = ownProps.match.params.seasonLeagueId;


    //create and ship seasonId for back navigation
    const seasonId = state.seasonLeagues.length > 0 ? getSeasonId(state.seasonLeagues, seasonLeagueId) : {};

   // var seasonRankingsList = state.seasonRankings.length > 0 ? getSeasonRankingsBySLId(seasonLeagueId) : [];
  

    return {
        seasonId,
      //  seasonRankings: state.seasonRankings,
       
       
        //seasonRankings: state.seasonRankings.length === 0 || state.weekPeriods.length === 0 
        //    ? []
        //    : state.seasonRankings.map(seasonRanking => {
        //        console.log(seasonRanking);
        //        return {
        //            ...seasonRanking,

                   
        //            periodName: state.weekPeriods.find(w => w.weekPeriodId === seasonRanking.weekPeriodId).name
        //        };
        //    }),
        teamRankings: state.teamRankings,
        teams: state.teams,
        weekPeriods: state.weekPeriods,
        sdIndices: state.sdIndices,
        years: state.years,
        leagues: state.leagues,
        seasonLeagues: state.seasonLeagues,
        seasons: state.seasons,
        regions: state.regions,
        countries: state.countries,

        seasonLeagueId,
        seasonRankings: state.seasonRankings.length === 0 || state.weekPeriods.length === 0 || state.teams.length === 0
            ? []
            : state.seasonRankings.map(seasonRanking => {
                return {
                    ...seasonRanking,
                    periodName: state.weekPeriods.find(w => w.weekPeriodId === state.seasonRanking.weekPeriodId).name,

                    teamRankings: seasonRanking.teamRankings(teamRanking => {
                        return {
                            ...teamRanking,
                            teamName: state.teams.find(t => t.teamId === teamRanking.teamId).name,
                            sdIndex: state.sdIndices.find(i => i.sdIndexId === teamRanking.sdIndexId).index

                        }
                    })
                };
            }),
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
            loadTeamRankings: bindActionCreators(teamRankingActions.loadTeamRankings, dispatch),
            loadSeasonRankings: bindActionCreators(seasonRankingActions.loadSeasonRankings, dispatch),
           // loadSeasonRanking: bindActionCreators(seasonRankingActions.loadSeasonRanking, dispatch),
            loadSdIndices: bindActionCreators(sdIndexActions.loadSdIndices, dispatch),
            loadWeekPeriods: bindActionCreators(weekPeriodActions.loadWeekPeriods, dispatch)
        }
    };
}

export default connect(
    mapStateToProps,
    mapDispatchToProps
)(RankingsPage);