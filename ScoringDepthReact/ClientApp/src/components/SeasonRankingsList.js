import React from "react";
import PropTypes from "prop-types";

const SeasonRankingsList = ({ seasonRankings }) => (
    <table className="table">
        <thead>
            <tr>
                <th>Period</th>
                <th>Team</th>
                <th>Ranking</th>
            </tr>
        </thead>
        <tbody>
            {seasonRankings.map(seasonRanking => {
                return (
                        <tr key={seasonRanking.seasonRankingId}>
                        <td>{seasonRanking.seasonRankingId}</td>
                            <td>{seasonRanking.periodName}</td>
                            <td>{seasonRanking.periodName}</td>                    
                        </tr>
                    );
                })}
        </tbody>
    </table>
);

//{
    //  seasonRanking.teamRankings.map(teamRanking => {
    //   return (
    //     <div>
    //            <td>{teamRanking.teamName}</td>
    //            <td>{teamRanking.sdIndex}</td>
    //        </div>
    //    );
    //})
//}

SeasonRankingsList.propTypes = {
    seasonRankings: PropTypes.array.isRequired,
};

export default SeasonRankingsList;