import React from "react";
import { connect } from 'react-redux';
import * as seasonActions from "../redux/actions/seasonActions";
import * as yearActions from "../redux/actions/yearActions";
import * as regionActions from "../redux/actions/regionActions";
import * as countryActions from "../redux/actions/countryActions";
import PropTypes from "prop-types";
import { bindActionCreators } from "redux";
import SeasonList from './SeasonList';

class HomePage extends React.Component {

    //componentDidMount() {
    //    this.props.actions.loadRegions().catch(error => {
    //        alert("Loading regions failed" + error);
    //    });
    //}

    componentDidMount() {
        const { seasons, years, regions, countries, actions } = this.props;

        if (seasons.length === 0) {
            actions.loadSeasons().catch(error => {
                alert("Loading seasons failed" + error);
            });
        }

        if (years.length === 0) {
            actions.loadYears().catch(error => {
                alert("Loading years failed" + error);
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
                <div className="jumbotron">
                <h1>Welcome to Scoring Depth</h1>
                <p>Cutting edge team rankings based on scoring depth excellence.</p>
                </div>
                <h2 className="text-center">Select a season</h2>
              
                <SeasonList seasons={this.props.seasons} />
            </>
        );
    }
}

HomePage.propTypes = {
    seasons: PropTypes.array.isRequired,
    years: PropTypes.array.isRequired,
    regions: PropTypes.array.isRequired,
    countries: PropTypes.array.isRequired,
    actions: PropTypes.object.isRequired
};

function mapStateToProps(state) {
    return {
        seasons: state.seasons,
        years: state.years,
        regions: state.regions,
        countries: state.countries
    };
}

function mapDispatchToProps(dispatch) {
    return {
        actions: {
            loadSeasons: bindActionCreators(seasonActions.loadSeasons, dispatch),
            loadRegions: bindActionCreators(regionActions.loadRegions, dispatch),
            loadYears: bindActionCreators(yearActions.loadYears, dispatch),
            loadCountries: bindActionCreators(countryActions.loadCountries, dispatch),
        }
    };
}

export default connect(
    mapStateToProps,
    mapDispatchToProps
)(HomePage);


