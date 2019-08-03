import { handleResponse, handleError } from "./apiUtils";
const baseUrl = "api/seasonLeague";

export function getSeasonLeagues() {
  return fetch(baseUrl)
    .then(handleResponse)
    .catch(handleError);
}

