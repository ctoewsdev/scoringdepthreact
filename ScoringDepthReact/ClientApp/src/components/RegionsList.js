import React from "react";
import PropTypes from "prop-types";
import { Link } from "react-router-dom";

const RegionsList = ({ seasons }) => (
    <table className="table">
        <thead>
            <tr>
                <th>Year</th>
                <th>Country</th>
                <th>Region</th>
                <th>Season</th>
            </tr>
        </thead>
        <tbody>
            {seasons.sort((a, b) => ((a.countryName > b.countryName) || (a.regionCode > b.regionCode))  ? 1 : -1).map(season => {
                //var region = regions.find(region => region.RegionId === season.RegionId);
                return (
                    <tr key={season.seasonId}>
                        <td>{season.yearName}</td>
                        <td>{season.countryName}</td>
                        <td>{season.regionCode}</td>
                        <td>
                            <Link to={"/league/" + season.seasonId}>{season.yearName + " " + season.regionName}</Link>
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
