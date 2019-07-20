import React from "react";
import { connect } from 'react-redux';

function AboutPage () {
  
        return (
            <>
                <h2>Welcome</h2>
                <p>This is the home page.</p>{" "}
            </>
        );
    
}

export default connect()(AboutPage);
