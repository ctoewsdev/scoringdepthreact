import React from "react";
import PropTypes from "prop-types";
import { Link } from "react-router-dom";

const YearsList = ({ years }) => (
    <table className="table">
        <thead>
            <tr>
                <th>Start</th>
                <th>Season</th>
            </tr>
        </thead>
        <tbody>
            {years.map(year => {
                return (
                    <tr key={year.yearId}>
                        <td>{year.yearStart}</td>
                        <td>
                            <Link to={"/season/" + year.yearId}>{year.name}</Link>
                        </td>                
                    </tr>
                );
            })}
        </tbody>
    </table>
);

YearsList.propTypes = {
    years: PropTypes.array.isRequired,
};

export default YearsList;
