import React from "react";
import { connect } from 'react-redux';
import * as regionActions from "../redux/actions/regionActions";
import PropTypes from "prop-types";
import { bindActionCreators } from "redux";

class RegionsPage extends React.Component {

    componentDidMount() {
        this.props.actions.loadRegions().catch(error => {
            alert("Loading regions failed" + error);
        });
    }


    render() {
        return (
            <>
                <h2>Select a Region.</h2>
                {this.props.regions.map(region => (
                    <div key={region.code}>{region.code}</div>
                ))}
            </>
        );
    }
}

RegionsPage.propTypes = {
    regions: PropTypes.array.isRequired,
    actions: PropTypes.object.isRequired
};

function mapStateToProps(state) {
    return {
        regions: state.regions
    };
}

function mapDispatchToProps(dispatch) {
    return {
        actions: {
            loadRegions: bindActionCreators(regionActions.loadRegions, dispatch),
        }
    };
}

export default connect(
    mapStateToProps,
    mapDispatchToProps
)(RegionsPage);


