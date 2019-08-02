import React, { useEffect } from "react";
import { connect } from 'react-redux';
import * as yearActions from "../redux/actions/yearActions";
import * as seasonActions from "../redux/actions/seasonActions";
import * as regionActions from "../redux/actions/regionActions";
import * as countryActions from "../redux/actions/countryActions";
import { bindActionCreators } from "redux";
import PropTypes from "prop-types";
import RegionsList from './RegionsList';

class RegionsPage extends React.Component {

    //seasonName = {};
    //seasonRegionsList = [];
    //year = {};

    //constructor(props) {
    //    super(props)
    //    this.state = {
    //        seasonName: {},
    //        year: {},
    //        seasonRegionsList: []
    //    };

    //}

    //constructor() {
    //    super()
    //    this.state = {
    //        seasonsList: [],
    //        yearId: {}
    //    }
    //}


    componentDidMount() {
        const { years, seasons, regions, actions } = this.props;


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

        //if (countries.length === 0) {
        //    actions.loadCountries().catch(error => {
        //        alert("Loading countries failed" + error);
        //    });
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




    filterSeasons () {
       const allSeasons = this.state.seasons;
       const yearId = this.state.yearId;
        const filtered = allSeasons.filter(seasons => seasons.yearId === yearId) || null;
        
        this.setState({
            seasons: filtered
        })
    }

    render() {
        return (
            <>
                <h1 class="text-center">Season:  </h1>
                <h2 class="text-center">Please select a region</h2>
                <RegionsList seasons={this.props.seasons} onChange={this.filterSeasons}/>
            </>
        );
    }
}

RegionsPage.propTypes = {
    years: PropTypes.array.isRequired,
    regions: PropTypes.array.isRequired,
    seasons: PropTypes.array.isRequired,
    actions: PropTypes.object.isRequired
};


export function getSeasonsByYearId(seasons, yearId) {
    return seasons.filter(seasons => seasons.yearId === yearId) || null;
}


function mapStateToProps(state, ownProps) {

    const yearId = ownProps.match.params.yearId;
    console.log(yearId);


    const seasonList = getSeasonsByYearId(state.seasons, yearId);
    console.log(seasonList);

    //var year = getSeasonName(state.years, yearId);
    //setSeasonName(year.name);

    //const seasons = yearId && state.seasons.length > 0 ? getSeasonsByYearId(state.seasons, yearId) : null;
    //const seasonRegionsList = state.seasons.length > 0 && state.regions.length > 0 ? getSeasonRegionsList(state.regions, seasons, this.region, this.SeasonRegionsList) : null;

    return {
        seasons: state.years.length === 0 || state.regions.length === 0
            ? []
            : state.seasons.map(season => {
            return {
                ...season,
                yearName: state.years.find(y => y.yearId === season.yearId).name,
                regionName: state.regions.find(r => r.regionId === season.regionId).name
            };
        }),
        yearId: yearId,
        years: state.years,
        regions: state.regions
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

//const mapDispatchToProps = {
//    loadYears,
//    loadSeasons,
//    loadRegions
//};

export default connect(
    mapStateToProps,
    mapDispatchToProps
)(RegionsPage);


