## Response to Interview Question About ASP.NET Web Programming Class:

1. **MVC Design Pattern Usage**: This was my first experience with the Model-View-Controller (MVC) design pattern in web development. I learned how to separate an application into three interconnected components, enhancing modularity and allowing for more efficient development and maintenance.

2. **Visual Studio Proficiency**: I gained proficiency in using Visual Studio, exploring its wide range of tools for web development. This included understanding the integrated development environment (IDE) features, debugging tools, and how to effectively utilize them for ASP.NET Core MVC projects.

3. **Understanding Separation of Concerns**: I learned about the importance and benefits of separating concerns in web programming. This approach streamlines the development process, making the codebase more manageable, maintainable, and scalable.

## Features to Improve Application for Users:

1. **Movie Trailer Integration**: Implementing a feature to add trailers to the product table. Users can watch trailers on the movie details page, enhancing user engagement and providing more information about the movies.

2. **User Registration and Login**: Developing a system that allows users to register and log in to the website. This feature will personalize user experience and enable secure access to additional functionalities.

3. **Movie Rental/Streaming Option**: Introducing a feature for users to rent or stream movies directly from the site, thereby adding a crucial functionality to the movie platform.

4. **Admin Image Upload Capability**: Creating an option for admins to upload images or movie covers, which will help in keeping the movie details page visually appealing and informative.

5. **Consistent Formatting**: Ensuring a consistent format across the website, including uniform headers, to provide a cohesive and professional user experience.

## Feature Implementation:

* **Movie Trailer**: Added a Trailer URL to the Application

  * **Description**: Implemented a feature to add movie trailers to the database, enabling users to watch trailers on the movie details page. This enhancement involved several key steps:

    * **Updating the `Models/ProductModel.cs` File**: Added a new string property called `TrailerURL` to the `ProductModel` class. This modification allows the application to store and retrieve the URL of movie trailers.

    * **Database Migration**: Performed a database migration to incorporate the new `TrailerURL` field in the `ProductModel` file. This step ensures that the trailer URLs are properly stored and managed within the application's database.

    * **Adding an iFrame on the Movie `ProductModel/Details.cshtml` Page**: Updated the movie details page to include an iFrame that displays the movie trailer. This allows users to view the trailer directly on the page, enhancing the user experience by providing a convenient and interactive way to explore movie content.

## Style Updates in Application:

1. **List View Transformation**: Changed the product list and contact list views from a table format to a card format, improving visual appeal and readability.

  * Updated files: 
  
    `Views/ContactModel/Index.cshtml`
    `Views/ProductModel/Index.cshtml`

2. **Details View Enhancement**: Modified the product and contact details views for better clarity. Integrated an iframe for displaying movie trailers, adding interactive content.

  * Updated files: 
  
    `Views/ContactModel/Details.cshtml`
    `Views/ProductModel/Details.cshtml`

3. **Form Positioning**: Centered the 'create new contact' and 'product' forms on the screen, enhancing visibility and user experience.

  * Updated files: 
  
    `Views/ContactModel/create.cshtml`
    `Views/ProductModel/create.cshtml`

4. **Layout Update with Flexbox**: Implemented flexbox in the layout.cshtml file to make the footer sticky at the bottom of the viewport, ensuring a consistent layout regardless of page content length.

  * Updated files: 
  
    `/Shared/_Layout_.cshtml`

5. **Dark Mode Consistency with Bootstrap 5**: Utilized Bootstrap 5's dark mode feature by adding data-bs-theme="dark" attribute to the `<html>` tag. This method ensures that the entire application adopts a dark theme, providing a modern, eye-friendly user interface consistent with user preferences for dark mode.

  * Updated files: 
  
    `/Shared/_Layout_.cshtml`