# Pierre's Sweet and Savory Treats

#### By **[Jordan]**

A web application designed to showcase Pierre's array of sweet and savory treats, featuring user authentication and a many-to-many relationship between Treats and Flavors.

## Technologies Used

- .NET 5.0
- ASP.NET Core MVC
- Entity Framework Core
- Identity for ASP.NET Core
- Bootstrap
- C#
- HTML
- CSS

## Description

Pierre's Sweet and Savory Treats is a dynamic web application that allows users to explore and manage a variety of treats and their associated flavors. The application implements user authentication, enabling logged-in users to have create, update, and delete functionalities while allowing all users to read content. It showcases a many-to-many relationship between Treats and Flavors, providing a rich and interactive experience.

## Setup/Installation Requirements

- Ensure .NET SDK and runtime are installed on your machine.
- Clone this repository to your local machine.
- Navigate to the application's directory in your terminal.

<details>
<summary>Set up the required database:</summary>

1. Create an `appsettings.json` file in the application's root directory with the following content (adjust the connection string as needed based on your SQL setup):

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=treatdb;uid=YOUR_USERNAME;pwd=YOUR_PASSWORD;"
  }
}

```

2. Replace YOUR_USERNAME and YOUR_PASSWORD with your SQL server's username and password.
</details>
<br>

- Run the command ```dotnet restore``` to install necessary packages.
- Run the command ```dotnet build``` to compile the application.
- Run ```dotnet run``` to start the server and application.
- Visit ```localhost:5000``` in your browser to access Pierre's Sweet and Savory Treats.

## User Stories

  - As a user, I can log in and log out of the application.
  - As a logged-in user, I can create, update, and delete treats and flavors.
  - As a user, I can view a list of all treats and flavors.
  - I can navigate to a treat or flavor to see all related flavors or treats.
  - I can view the many-to-many relationships between treats and flavors.

## Objectives

  - CRUD functionality implemented for at least one class.
  - Ability to view both sides of the many-many relationship.
  - User authentication with Identity for registration, login, and logout.
  - Create, Update, and Delete functionalities limited to authenticated users.
  - Secure handling of build files and sensitive information.

## Known Bugs

No known bugs at the moment.
Feedback and bug reports are always welcome.
License

Feel free to reach out if you have any concerns, feedback, or wish to make contributions to the code. mod.Jordan@icloud.com

Copyright (c) 2023 [Jordan]