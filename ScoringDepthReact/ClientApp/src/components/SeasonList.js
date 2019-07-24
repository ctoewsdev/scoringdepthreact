import React from "react";
import PropTypes from "prop-types";
import { Link } from "react-router-dom";

const SeasonList = ({ seasons }) => (
    <table className="table">
        <thead>
            <tr>
                <th>Start</th>
                <th>Season</th>
            </tr>
        </thead>
        <tbody>
            {seasons.map(season => {
                return (
                    <tr key={season.seasonId}>
                        <td>{season.yearStart}</td>
                        <td>
                            <Link to={"/season/" + season.name}>{season.name}</Link>
                        </td>                
                    </tr>
                );
            })}
        </tbody>
    </table>
);

SeasonList.propTypes = {
    seasons: PropTypes.array.isRequired,
};

export default SeasonList;
