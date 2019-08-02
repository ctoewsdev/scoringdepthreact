import React from "react";
import PropTypes from "prop-types";
import { Link } from "react-router-dom";

const RegionsList = ({ seasons }) => (
    <table className="table">
        <thead>
            <tr>
                <th>Season</th>
                <th>Region</th>
                <th>Name</th>
            </tr>
        </thead>
        <tbody>
            {seasons.map(season => {
                //var region = regions.find(region => region.RegionId === season.RegionId);
                return (
                    <tr key={season.SeasonId}>
                        <td>{season.seasonId}</td>
                        <td>{season.yearName}</td>
                        <td>
                            <Link to={"/league/" + season.SeasonId}>{season.regionName}</Link>
                        </td>  
                      
                    </tr>
                );
            })}
        </tbody>
    </table>
);

RegionsList.propTypes = {
    seasons: PropTypes.array.isRequired,
};




export default RegionsList;
