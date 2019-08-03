import React from "react";
import { connect } from 'react-redux';
import * as yearActions from "../redux/actions/yearActions";
import * as seasonActions from "../redux/actions/seasonActions";
import * as regionActions from "../redux/actions/regionActions";
import * as countryActions from "../redux/actions/countryActions";
import { bindActionCreators } from "redux";
import PropTypes from "prop-types";
import RegionsList from './RegionsList';
import { Link } from "react-router-dom";

class RegionsPage extends React.Component {

    componentDidMount() {
        const { years, seasons, regions, countries, actions } = this.props;


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

        //if (seasons.length === 0) {
        //    actions.loadSeasonsByYear().catch(error => {
        //        alert("Loading seasons by year failed" + error);
        //    });
        //}


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


        //if (seasonsList.length === 0) {
        //    seasonsList = [];
        //}


    }

    //setSeasonName(name) {
    //this.setSeasonName(seasonName);
    //  this.setState({ seasonName: name })
    // this.setState({ [state.seasonName]: state.year.name });
    //}

    //setYearId(yearId) {
    //this.setSeasonName(seasonName);
    // this.setState({ yearId: yearId })
    // this.setState({ [state.seasonName]: state.year.name });
    // }


    render() {
        return (
            <>
                <h1 class="text-center">Regions</h1>
                <h2 class="text-center">Please select a region</h2>
                <h3 class="text-center">
                    <Link to={"/"}>{"Select a different year"}</Link>
                </h3>
                <RegionsList seasons={this.props.seasons} />
            </>
        );
    }
}

RegionsPage.propTypes = {
    years: PropTypes.array.isRequired,
    regions: PropTypes.array.isRequired,
    seasons: PropTypes.array.isRequired,
    countries: PropTypes.array.isRequired,
    actions: PropTypes.object.isRequired
};


export function getSeasonsByYear(seasons, yearId) {
    var sList = seasons.filter(season => season.yearId == yearId);


    return sList;
}


function mapStateToProps(state, ownProps) {

    const yearId = ownProps.match.params.yearId;

    var seasonsList = state.seasons.length > 0 ? getSeasonsByYear(state.seasons, yearId) : [];



    //state.seasons.filter(season => season.yearId === yearId);
    //console.log('seasonsList array is: ', seasonsList);

    //var year = getSeasonName(state.years, yearId);
    //setSeasonName(year.name);

    return {
        yearId: yearId,
        countries: state.countries,
        seasons: seasonsList.length === 0 || state.years.length === 0 || state.regions.length === 0
            ? []
            : seasonsList.map(season => {
                return {
                    ...season,
                    yearName: state.years.find(y => y.yearId === season.yearId).name,
                    regionName: state.regions.find(r => r.regionId === season.regionId).name,
                    regionCode: state.regions.find(r => r.regionId === season.regionId).code,
                    countryName: state.countries.find(c => c.countryId === state.regions.find(r => r.regionId === season.regionId).countryId).name,

                };
            }),

        years: state.years,
        regions: state.regions,
    };
}

function mapDispatchToProps(dispatch) {
    return {
        //injects actions into this page component
        actions: {
            loadYears: bindActionCreators(yearActions.loadYears, dispatch),
            loadSeasons: bindActionCreators(seasonActions.loadSeasons, dispatch),
            loadCountries: bindActionCreators(countryActions.loadCountries, dispatch),
            loadRegions: bindActionCreators(regionActions.loadRegions, dispatch)
        }
    };
}

export default connect(
    mapStateToProps,
    mapDispatchToProps
)(RegionsPage);