import React from "react";
import { NavLink } from "react-router-dom";

function Header() {
    const activeStyle = { color: "#F15B2A" };

    return (
        <nav>
            <NavLink activeStyle={activeStyle} exact to="/">
                Home
        </NavLink>
            {" | "}
            <NavLink activeStyle={activeStyle} to="/regions">
                Regions
        </NavLink>
            {" | "}
            <NavLink activeStyle={activeStyle} to="/about">
                About
        </NavLink>
            {" | "}
            <NavLink activeStyle={activeStyle} to="/feedback">
                Feedback
        </NavLink>
        </nav>
    );
}

export default Header;
