import React from "react";
import { connect } from 'react-redux';
import * as yearActions from "../redux/actions/yearActions";
import * as seasonActions from "../redux/actions/seasonActions";
import * as regionActions from "../redux/actions/regionActions";
import * as countryActions from "../redux/actions/countryActions";
import * as leagueActions from "../redux/actions/leagueActions";
import * as seasonLeagueActions from "../redux/actions/seasonLeagueActions";
import { bindActionCreators } from "redux";
import PropTypes from "prop-types";
import LeaguesList from './LeaguesList';
import { Link } from "react-router-dom";

class LeaguesPage extends React.Component {

    componentDidMount() {
        const { years, seasons, regions, countries, leagues, seasonLeagues, actions } = this.props;

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
                <h1 class="text-center">Leagues</h1>
                <h2 class="text-center">Please select a league</h2>
                <h3 class="text-center">
                    <Link to={"/season/" + this.props.yearId}>{"Select a different region"}</Link>
                </h3>
                <LeaguesList seasonLeagues={this.props.seasonLeagues} />
            </>
        );
    }
}

LeaguesPage.propTypes = {
    years: PropTypes.array.isRequired,
    regions: PropTypes.array.isRequired,
    seasons: PropTypes.array.isRequired,
    countries: PropTypes.array.isRequired,
    leagues: PropTypes.array.isRequired,
    seasonLeagues: PropTypes.array.isRequired,
    actions: PropTypes.object.isRequired
};


export function getSeasonLeaguesBySeasonId(seasonLeagues, seasonId) {
    var seasonLeaguesList = seasonLeagues.filter(seasonLeague => seasonLeague.seasonId == seasonId);
    return seasonLeaguesList;
}

export function getYearId(seasons, seasonId) {
    return seasons.find(s => s.seasonId == seasonId).yearId;
}


function mapStateToProps(state, ownProps) {

    const seasonId = ownProps.match.params.seasonId;

    //create and ship yearId for back navigation
    const yearId = state.seasons.length > 0 ? getYearId(state.seasons, seasonId) : {};

    var seasonsLeaguesList = state.seasonLeagues.length > 0 ? getSeasonLeaguesBySeasonId(state.seasonLeagues, seasonId) : [];

    return {
        yearId,
        seasonLeagues: seasonsLeaguesList.length === 0 || state.years.length === 0 || state.seasons.length === 0 || state.countries.length === 0 || state.leagues.length === 0 || state.regions.length === 0
            ? []
            : seasonsLeaguesList.map(seasonLeague => {
                return {
                    ...seasonLeague,
                    yearName: state.years.find(y => y.yearId === state.seasons.find(s => s.seasonId === seasonLeague.seasonId).yearId).name,

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
        countries: state.countriesEastTitle
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
            loadLeagues: bindActionCreators(leagueActions.loadLeagues, dispatch)
        }
    };
}

export default connect(
    mapStateToProps,
    mapDispatchToProps
)(LeaguesPage);