import { handleResponse, handleError } from "./apiUtils";
const baseUrl = "api/seasonRanking";

export function getSeasonRankings() {
  return fetch(baseUrl)
    .then(handleResponse)
    .catch(handleError);
}

//export function getSeasonRanking(seasonLeagueId) {
//    return fetch(baseUrl + "/GetSeasonRanking/" + seasonLeagueId)
//        .then(handleResponse)
//        .catch(handleError);
//}