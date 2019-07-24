import React, { useEffect } from "react";
import { connect } from 'react-redux';
import { loadRegions } from "../redux/actions/regionActions";
import PropTypes from "prop-types";
import RegionList from './RegionList';

function RegionsPage({ seasons, regions, loadRegions, ...props }) {
   

    useEffect(() => {
    

        if (regions.length === 0) {
            loadRegions().catch(error => {
                alert("Loading regions failed" + error);
            });
        }
    }, []);

    return (
        <>
            <h1 class="text-center">Season:  </h1>
            <h2 class="text-center">Please select a region</h2>
            <RegionList regions={regions} />
        </>
    );
}

RegionsPage.propTypes = {
    regions: PropTypes.array.isRequired,
    actions: PropTypes.object.isRequired
};

function mapStateToProps(state, ownProps) {
    const seasonYear = ownProps.match.params.name;
    return {
        regions: state.regions,
        season: ownProps.match.params.name
    };
}

const mapDispatchToProps = {
    loadRegions
};

export default connect(
    mapStateToProps,
    mapDispatchToProps
)(RegionsPage);


