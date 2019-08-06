import { handleResponse, handleError } from "./apiUtils";
const baseUrl = "api/weekPeriod";

export function getWeekPeriods() {
    return fetch(baseUrl)
        .then(handleResponse)
        .catch(handleError);
}