import React from "react";
import PropTypes from "prop-types";
import TextInput from "./common/TextInput";
import SelectInput from "./common/SelectInput";


const FeedbackForm = ({
    feedback,
    onSubmit,
    onChange,
    submitting = false,
    errors = {}
}) => {

    return (
        <form onSubmit={onSubmit}>
            {errors.onSubmit && (
                <div className="alert alert-danger" role="alert">
                    {errors.onSubmit}
                </div>
            )}
            <TextInput
                name="firstName"
                label="FirstName"
                value={feedback.firstName}
                onChange={onChange}
                error={errors.firstName}
            />

            <TextInput
                name="lastName"
                label="LastName"
                value={feedback.lastName}
                onChange={onChange}
                error={errors.lastName}
            />

            {/*          <SelectInput
                name="role"
                label="Role"
                value={feedback.role}
                defaultOption="Select Role"
                options={roles}
                onChange={onChange}
                error={errors.role}
            />
*/}
            <TextInput
                name="email"
                label="Email"
                value={feedback.email}
                onChange={onChange}
                error={errors.email}
            />

            <TextInput
                name="message"
                label="Message"
                value={feedback.message}
                onChange={onChange}
                error={errors.message}
            />



            <label>
                ContactMe
            <input
                    name="contactMe"
                    type="checkbox"
                    value={feedback.contactMe}
                    onChange={onChange}
                    error={errors.contactMe}
                />
            </label>
            <div class="text-right">
         
                    <button type="reset" disabled={submitting} class="btn btn-secondary">
                        {"Reset"}
                </button>

                    <button type="submit" disabled={submitting} className="btn btn-primary">
                        {submitting ? "Submitting.." : "Submit"}
                    </button>
       
            </div>
        </form>
    );
};

FeedbackForm.propTypes = {
    feedback: PropTypes.object.isRequired,
    errors: PropTypes.object,
    onSubmit: PropTypes.func.isRequired,
    onChange: PropTypes.func.isRequired,
    submitting: PropTypes.bool
};

const roles = [
    { value: 'owner', text: 'Team Owner' },
    { value: 'headcoach-manager', text: 'Head Coach/Manager' },
    { value: 'coachingstaff', text: 'CoachingStaff' },
    { value: 'teamstaff', text: 'TeamStaff' },
    { value: 'player', text: 'Player' },
    { value: 'fan', text: 'Fan' }
];

export default FeedbackForm;
