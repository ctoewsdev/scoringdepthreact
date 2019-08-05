import { handleResponse, handleError } from "./apiUtils";
const baseUrl = "api/ranking";

export function getRankings() {
  return fetch(baseUrl)
    .then(handleResponse)
    .catch(handleError);
}