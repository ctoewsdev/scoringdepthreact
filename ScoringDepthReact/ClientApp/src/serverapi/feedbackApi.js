import { handleResponse, handleError } from "./apiUtils";
const baseUrl = "api/feedback";

export function createFeedback(feedback) {
    return fetch(baseUrl, {
        method: "POST",
        headers: { "content-type": "application/json" },
        body: JSON.stringify(feedback)
    })
        .then(handleResponse)
        .catch(handleError);
}