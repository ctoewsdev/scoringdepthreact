import { handleResponse, handleError } from "./apiUtils";
const baseUrl = "api/country";

export function getCountries() {
  return fetch(baseUrl)
    .then(handleResponse)
    .catch(handleError);
}