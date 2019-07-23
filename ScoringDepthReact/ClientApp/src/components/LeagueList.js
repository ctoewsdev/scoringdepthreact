import React from "react";
import PropTypes from "prop-types";
import { Link } from "react-router-dom";

const LeagueList = ({ leagues }) => (
    <table className="table">
        <thead>
            <tr>
                <th>Logo</th>
                <th>League</th>
                <th>Name</th>
            </tr>
        </thead>
        <tbody>
            {leagues.map(league => {
                return (
                    <tr key={league.id}>
                        <td>{league.imageUrl}</td>
                        <td>
                            <Link to={"/league/" + league.code}>{league.code}</Link>
                        </td>                
                        <td>{league.name}</td>                  
                    </tr>
                );
            })}
        </tbody>
    </table>
);

LeagueList.propTypes = {
    leagues: PropTypes.array.isRequired,
};

export default LeagueList;
