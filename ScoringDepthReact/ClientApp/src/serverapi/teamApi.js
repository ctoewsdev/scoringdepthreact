import { handleResponse, handleError } from "./apiUtils";
const baseUrl = "api/team";

export function getTeams() {
  return fetch(baseUrl)
    .then(handleResponse)
    .catch(handleError);
}