import React from "react";
import { connect } from "react-redux";
import * as leagueActions from "../redux/actions/leagueActions";
import PropTypes from "prop-types";
import { bindActionCreators } from "redux";

class LeaguesPage extends React.Component {

    componentDidMount() {
        this.props.actions.loadLeagues().catch(error => {
            alert("Loading courses failed" + error);
        });
    }


    render() {
        return (
            <>
                <h2>Leagues</h2>
                <h3>Please select a league.</h3>
                {this.props.leagues.map(league => (
                    <div key={league.code}>{league.code}</div>
                ))}
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

