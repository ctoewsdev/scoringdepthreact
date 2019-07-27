import { handleResponse, handleError } from "./apiUtils";
const baseUrl = "api/year";

export function getYears() {
    return fetch(baseUrl)
        .then(handleResponse)
        .catch(handleError);
}

