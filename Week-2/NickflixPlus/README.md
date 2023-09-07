# Summary

![home page screenshot](./wwwroot/images/screenshots/screenshot1.png)

## **1\. Views/Home/Index.cshtml**

#### Purpose:

- Serves as home page for the Movie App.

#### Key Features:

- Hero section with branding, slogans, and call to action.
- Two content sections with headings, text, images, and buttons.
- Uses Razor syntax like `@ViewData["Title"]`.

#### Details: 

- Sets page `Title` from `ViewData`.
- Hero has logo, headings, and sign up buttons.
- Sections have responsive image and text layouts. 
- Buttons route to account creation, login, and movie browsing (not yet functional).

#### Interactions:

- Displays when routed to home URL path.
- Inherits `_Layout.cshtml` as layout.
- Links to movie management and browse pages.
- Renders content on the home page.

## **2\. Views/Shared/_Layout.cshtml**

#### Purpose:  

- Acts as the layout template for Razor views in the Movie App.

#### Key Features:

- Defines overall HTML document structure.
- Includes `head` with meta info, title, and stylesheets. 
- Updated Bootstrap with new CDN links. 
- Contains `header` and `nav` for site-wide navigation.
- Renders happen in the `main` content area and from many different views.
- Has `footer` section with copyright text.
- References Bootstrap, custom CSS, and eventually jQuery and JavaScript.

#### Details:

- `@RenderBody()` renders content from views into `main`.
- `ViewData["Title"]` sets dynamic page titles.
- Navigation links route to Home, Movies controller.
- Bootstrap navbar responsive on mobile.
- JavaScript files enable Bootstrap components. 

#### Interactions:

- Shared layout for all Razor views like `Index.cshtml`.
- Links to `custom.css` stylesheet for styling.
- Includes jQuery, Bootstrap JS for interactivity.
- Content pages fill `main` section.

## **3\. wwwroot/css/custom.css**

#### Purpose: 

- Provides custom styling for the NickFlix+ web application.

#### Key Features:

- Sets styles for main HTML elements like `html`, `body`, and `nav`.
- Defines hero section styling including gradient background and image.
- Styles dark table and row elements with dark background colors.

#### Details:

- Sets `overflow` on `html` to `auto` to allow scrolling.
- Sets `body` text color to white and background to black. 
- Makes `nav` links white with no text decoration.
- Hero section has radial gradient, background image, radius, and other stylings.
- `.dark-table` and related elements have dark gray background colors.
- Text shadows added for contrast against dark backgrounds.

#### Interactions:

- Imported in `_Layout.cshtml` to style pages across the application.
- Works with custom classes like `.hero-section` and `.dark-table` to style specific elements.
- Relies on HTML structure and classes for styling.