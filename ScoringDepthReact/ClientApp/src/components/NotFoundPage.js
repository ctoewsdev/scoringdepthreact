import React from "react";
import { Link } from "react-router-dom";
import { connect } from "react-redux";

function NotFoundPage() {
    return (
        <div>
            <h2>Page Not Found</h2>
            <p>
                <Link to="/">Home </Link>
            </p>
        </div>
    );
}


export default connect()(NotFoundPage);
