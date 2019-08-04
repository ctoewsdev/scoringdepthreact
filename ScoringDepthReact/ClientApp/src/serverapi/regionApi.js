import { handleResponse, handleError } from "./apiUtils";
const baseUrl = "api/region";

export function getRegions() {
  return fetch(baseUrl)
    .then(handleResponse)
    .catch(handleError);
}