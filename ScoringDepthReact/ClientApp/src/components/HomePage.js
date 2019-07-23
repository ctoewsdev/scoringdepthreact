import React from "react";
import { connect } from 'react-redux';
import * as regionActions from "../redux/actions/regionActions";
import PropTypes from "prop-types";
import { bindActionCreators } from "redux";

class HomePage extends React.Component {

    //componentDidMount() {
    //    this.props.actions.loadRegions().catch(error => {
    //        alert("Loading regions failed" + error);
    //    });
    //}

    componentDidMount() {
        const { regions, actions } = this.props;

        if (regions.length === 0) {
            actions.loadRegions().catch(error => {
                alert("Loading courses failed" + error);
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
                <h2>Select a Region.</h2>
                {this.props.regions.map(region => (
                    <div key={region.code}>{region.code}</div>
                ))}
            </>
        );
    }
}

HomePage.propTypes = {
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
)(HomePage);


