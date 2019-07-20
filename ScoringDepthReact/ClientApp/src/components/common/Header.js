import React from "react";
import { NavLink } from "react-router-dom";

function Header() {
    const activeStyle = { color: "orange" };

    return (
        <nav>
            <NavLink activeStyle={activeStyle} exact to="/">
                Home
        </NavLink>
            {" | "}
            <NavLink activeStyle={activeStyle} to="/countries">
                Countries
        </NavLink>
            {" | "}
            <NavLink activeStyle={activeStyle} to="/league">
                Leagues
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
