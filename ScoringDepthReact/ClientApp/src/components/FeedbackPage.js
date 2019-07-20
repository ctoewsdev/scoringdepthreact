import React from "react";
import { connect } from "react-redux";
import * as feedbackActions from "../redux/actions/feedbackActions";
import PropTypes from "prop-types";
import { bindActionCreators } from "redux";

class FeedbackPage extends React.Component{
    state = {
        feedback: {
            title: ""
        }
    };

    handleChange = event => {
        //left clones existing state and right side overides state, which is then set.
        const feedback = { ...this.state.feedback, title: event.target.value };
        this.setState({ feedback });
    };

    handleSubmit = event => {
        event.preventDefault();
        this.props.actions.createFeedback(this.state.feedback);
    };

    render() {
        return (
            <form onSubmit={this.handleSubmit}>
                <h2>Feedback</h2>
                <h3>Please fill out all boxes and submit.</h3>
                <input
                    type="text"
                    onChange={this.handleChange}
                    value={this.state.feedback.title}
                />

                <input type="submit" value="Save" />
                {this.props.feedbacks.map(feedback => (
                        <div key={feedback.title}>{feedback.title}</div>
                ))}
            </form>
        );
    }
}

FeedbackPage.propTypes = {
    feedbacks: PropTypes.array.isRequired,
    actions: PropTypes.object.isRequired
};

function mapStateToProps(state) {
    return {
        feedbacks: state.feedbacks
    };
}

function mapDispatchToProps(dispatch) {
    return {
        actions: bindActionCreators(feedbackActions, dispatch)
    };
}

export default connect(
    mapStateToProps,
    mapDispatchToProps
)(FeedbackPage);

