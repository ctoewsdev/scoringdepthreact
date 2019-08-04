import { handleResponse, handleError } from "./apiUtils";
const baseUrl = "api/league";

export function getLeagues() {
  return fetch(baseUrl)
    .then(handleResponse)
    .catch(handleError);
}