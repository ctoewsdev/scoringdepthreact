import React, { useEffect, useState } from "react";
import { connect } from "react-redux";
import { createFeedback } from "../redux/actions/feedbackActions";
import PropTypes from "prop-types";
import FeedbackForm from "./FeedbackForm";


function FeedbackPage({ createFeedback, history, ...props }) {
    const [feedback, setFeedback] = useState({ ...props.feedback });
    const [errors, setErrors] = useState({});

    useEffect(() => {

        setFeedback({ ...props.feedback });

    }, [props.feedback]);

    function handleChange(event) {
        const { name, value } = event.target;
        setFeedback(prevFeedback => ({
            ...prevFeedback,
            [name]: value
        }));
    }

    function handleSubmit(event) {
        event.preventDefault();
        createFeedback(feedback).then(() => {
            history.push("/");
        });
    }

    return (
        <>
            <h1 class="text-center">We Welcome Your Feedback</h1>
            <h2 class="text-center">Please fill out all fields</h2>

            <FeedbackForm feedback={feedback} errors={errors} onChange={handleChange} onSubmit={handleSubmit} />
        </>
    );
}


FeedbackPage.propTypes = {
    // regions: PropTypes.array.isRequired,
    feedback: PropTypes.object.isRequired,
    createFeedback: PropTypes.func.isRequired,
    history: PropTypes.func.isRequired
};

function mapStateToProps(state) {
    const feedback = newFeedback;
    return {
        feedback
    };
}

const mapDispatchToProps = {
    createFeedback
};

const newFeedback = {
    firstName: "",
    lastName: "",
    email: "",
    message: "",
    role: "",
    contactMe: false
};


export default connect(
    mapStateToProps,
    mapDispatchToProps
)(FeedbackPage);

