import React from "react";
import { connect } from "react-redux";
import * as leagueActions from "../redux/actions/leagueActions";
import PropTypes from "prop-types";
import { bindActionCreators } from "redux";
import LeagueList from './LeagueList';

class LeaguesPage extends React.Component {

    componentDidMount() {
        const { leagues, actions } = this.props;

        if (leagues.length === 0) {
            actions.loadLeagues().catch(error => {
                alert("Loading leagues failed" + error);
            });
        }
    }

    render() {
        return (
            <>
                <h2>Leagues</h2>
                <h3>Please select a league.</h3>
                <LeagueList leagues={this.props.leagues} />
            </>
        );
    }
}

LeaguesPage.propTypes = {
    leagues: PropTypes.array.isRequired,
    actions: PropTypes.object.isRequired
};

function mapStateToProps(state) {
    return {
        leagues: state.leagues
    };
}

function mapDispatchToProps(dispatch) {
    return {
        actions: {
            loadLeagues: bindActionCreators(leagueActions.loadLeagues, dispatch),
        }
    };
}

export default connect(
    mapStateToProps,
    mapDispatchToProps
)(LeaguesPage);

