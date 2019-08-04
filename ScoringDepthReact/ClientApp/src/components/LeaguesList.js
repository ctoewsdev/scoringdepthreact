import React from "react";
import PropTypes from "prop-types";
import { Link } from "react-router-dom";

const LeaguesList = ({ seasonLeagues }) => (
    <table className="table">
        <thead>
            <tr>
                <th>Year</th>
                <th>Country</th>
                <th>Region</th>
                <th>League</th>
                <th>Name</th>
            </tr>
        </thead>
        <tbody>
            {seasonLeagues.sort((a, b) => (a.leagueName > b.leagueName) ? 1 : -1).map(seasonLeagues => {
                //var region = regions.find(region => region.RegionId === season.RegionId);
                return (
                    <tr key={seasonLeagues.seasonLeagueId}>
                        <td>{seasonLeagues.yearName}</td>
                        <td>{seasonLeagues.countryName}</td>
                        <td>{seasonLeagues.regionName}</td>
                        <td>{seasonLeagues.leagueCode}</td>
                        <td>
                            <Link to={"/ranking/" + seasonLeagues.seasonLeagueId}>{seasonLeagues.leagueName}</Link>
                        </td>
                    </tr>
                );
            })}
        </tbody>
    </table>
);

LeaguesList.propTypes = {
    seasonLeagues: PropTypes.array.isRequired,
};

export default LeaguesList;