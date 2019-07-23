import React from "react";
import { connect } from "react-redux";
import * as feedbackActions from "../redux/actions/feedbackActions";
import PropTypes from "prop-types";
import { bindActionCreators } from "redux";

class FeedbackPage extends React.Component{
    state = {
        feedback: {
            firstName: ""
        }
    };

    handleChange = event => {
        //left clones existing state and right side overides state, which is then set.
        const feedback = { ...this.state.feedback, feedback: event.target.value };
        this.setState({ feedback });
    };

    handleSubmit = event => {
        event.preventDefault();
        this.props.actions.createFeedback(this.state.feedback);
    };

    //public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public string Role { get; set; }
    //    public string Email { get; set; }
    //    public string Message { get; set; }
    //    public bool ContactMe { get; set; }

    render() {
        return (
            <form onSubmit={this.handleSubmit}>
                <h2>Feedback</h2>
                <h3>Please fill out all boxes and submit.</h3>
                <input
                    type="text"
                    onChange={this.handleChange}
                    value={this.state.feedback.firstName}
                />
                <input
                    type="text"
                    onChange={this.handleChange}
                    value={this.state.feedback.lastName}
                />
                <input
                    type="text"
                    onChange={this.handleChange}
                    value={this.state.feedback.Role}
                />
                <input
                    type="text"
                    onChange={this.handleChange}
                    value={this.state.feedback.email}
                />
                <input
                    type="text"
                    onChange={this.handleChange}
                    value={this.state.feedback.message}
                />

                <input type="submit" value="Save" />
                
            </form>
        );
    }
}

FeedbackPage.propTypes = {
    feedback: PropTypes.array.isRequired,
    actions: PropTypes.object.isRequired
};

function mapStateToProps(state) {
    return {
        feedback: state.feedback
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

