# Junior Developer Code Test
README

 Overview

This project fetches and displays a list of random users from the `randomuser.me` API. The application was enhanced with various features, including a refresh button, updated data models, improved API fetching, and a better user interface.

Steps to Implement

Step 1: Add Refresh Button

1. HTML Structure:
   - Added a refresh button within a `div` element with the class `refresh-button` to allow users to reload the page.
   - Included descriptive text below the button to instruct users to click the button to reload the page.

2. JavaScript:
   - Implemented a JavaScript event listener for the refresh button that reloads the page when clicked.

Step 2: Update `RequestedUsersModel`

1. Add Properties:
   - Updated the `RequestedUsersModel` class to include new properties: `Country`, `Latitude`, and `Longitude`.

 Step 3: Fetch Data from the API

1. Update API Service:
   - Modified the API service to fetch additional data (country, latitude, and longitude) from the `randomuser.me` API.
   - Ensured that the fetched data was mapped correctly to the updated `RequestedUsersModel`.

Step 4: Display Multiple Entries

1. Increase Number of Entries:
   - Configured the API request to fetch 5 user entries.
   - Updated the view to loop through and display all 5 user entries.

Step 5: Improve User Interface

1. Add Scrollbar:
   - Added a scrollable table to the view to accommodate displaying multiple user entries efficiently.
   - Positioned scrollbars at both the top and bottom of the table for easier navigation.

2. Search Functionality:
   - Implemented a search bar to filter users by their first name.
   - Enhanced the view to include the search input and button, enabling users to search and filter the displayed user list dynamically.

Step 6: Fetch Country Data from the API

1. API Data Mapping:
   - Ensured that the `country` field from the `randomuser.me` API was correctly fetched and displayed in the user list.

---

By following these steps, the application now includes a functional refresh button, displays multiple user entries with additional details (country, latitude, and longitude), and provides a better user experience with scrollable tables and search functionality.
