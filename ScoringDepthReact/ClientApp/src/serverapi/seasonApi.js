import { handleResponse, handleError } from "./apiUtils";
const baseUrl = "api/season";

export function getSeasons() {
  return fetch(baseUrl)
    .then(handleResponse)
    .catch(handleError);
}