import { handleResponse, handleError } from "./apiUtils";
const baseUrl = "api/teamranking";

export function getTeamRankings() {
  return fetch(baseUrl)
    .then(handleResponse)
    .catch(handleError);
}