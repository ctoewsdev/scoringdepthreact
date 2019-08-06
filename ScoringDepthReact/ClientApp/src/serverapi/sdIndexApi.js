import { handleResponse, handleError } from "./apiUtils";
const baseUrl = "api/sdIndex";

export function getSdIndices() {
  return fetch(baseUrl)
    .then(handleResponse)
    .catch(handleError);
}