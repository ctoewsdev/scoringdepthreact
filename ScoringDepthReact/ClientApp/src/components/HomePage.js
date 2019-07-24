import React from "react";
import { connect } from 'react-redux';
import * as seasonActions from "../redux/actions/seasonActions";
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
        const { seasons, actions } = this.props;

        if (seasons.length === 0) {
            actions.loadSeasons().catch(error => {
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
                <h2 class="text-center">Select a season</h2>
              
                <SeasonList seasons={this.props.seasons} />
            </>
        );
    }
}

HomePage.propTypes = {
    seasons: PropTypes.array.isRequired,
    actions: PropTypes.object.isRequired
};

function mapStateToProps(state) {
    return {
        seasons: state.seasons
    };
}

function mapDispatchToProps(dispatch) {
    return {
        actions: {
            loadSeasons: bindActionCreators(seasonActions.loadSeasons, dispatch),
        }
    };
}

export default connect(
    mapStateToProps,
    mapDispatchToProps
)(HomePage);


