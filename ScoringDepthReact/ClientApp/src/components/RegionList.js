import React from "react";
import PropTypes from "prop-types";
import { Link } from "react-router-dom";

const RegionList = ({ regions }) => (
    <table className="table">
        <thead>
            <tr>
                <th>Flag</th>
                <th>Region</th>
                <th>Name</th>
            </tr>
        </thead>
        <tbody>
            {regions.map(region => {
                return (
                    <tr key={region.RegionId}>
                        <td>{region.imageUrl}</td>
                        <td>
                            <Link to={"/region/" + region.code}>{region.code}</Link>
                        </td>                
                        <td>{region.name}</td>                  
                    </tr>
                );
            })}
        </tbody>
    </table>
);

RegionList.propTypes = {
    regions: PropTypes.array.isRequired,
};

export default RegionList;
