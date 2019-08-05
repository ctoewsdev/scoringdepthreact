import { handleResponse, handleError } from "./apiUtils";
const baseUrl = "api/seasonteam";

export function getSeasonTeams() {
  return fetch(baseUrl)
    .then(handleResponse)
    .catch(handleError);
}