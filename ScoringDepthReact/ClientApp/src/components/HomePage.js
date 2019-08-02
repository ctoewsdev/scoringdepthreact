import React from "react";
import { connect } from 'react-redux';
import * as yearActions from "../redux/actions/yearActions";
import PropTypes from "prop-types";
import { bindActionCreators } from "redux";
import YearsList from './YearsList';

class HomePage extends React.Component {

    componentDidMount() {

        const { years, actions } = this.props;

        if (years.length === 0) {
            actions.loadYears().catch(error => {
                alert("Loading years failed" + error);
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

                <YearsList years={this.props.years} />
            </>
        );
    }
}

HomePage.propTypes = {
    years: PropTypes.array.isRequired,
    actions: PropTypes.object.isRequired
};

function mapStateToProps(state) {
    return {
        years: state.years
    };
}

function mapDispatchToProps(dispatch) {
    return {
        actions: {
            loadYears: bindActionCreators(yearActions.loadYears, dispatch)
        }
    };
}

export default connect(
    mapStateToProps,
    mapDispatchToProps
)(HomePage);