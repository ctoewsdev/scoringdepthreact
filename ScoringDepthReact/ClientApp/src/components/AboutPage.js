import React from "react";
import { connect } from 'react-redux';

function AboutPage () {
  
        return (
            <>
                <h2>About</h2>
                <p>Here I will describe the application.</p>{" "}
            </>
        );
    
}

export default connect()(AboutPage);
