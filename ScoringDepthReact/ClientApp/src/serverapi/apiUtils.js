export async function handleResponse(response) {
  if (response.ok) return response.json();
  if (response.status === 400) {
    // Server-side validation error
    const error = await response.text();
    throw new Error(error);
  }
  throw new Error("Network response was not ok.");
}

// Add error logging service.
export function handleError(error) {
  // eslint-disable-next-line ?
  console.error("API call failed. " + error);
  throw error;
}
