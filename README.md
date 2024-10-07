# GDPR Compliant User Management Web Application

## Overview

This project is a web application built using .NET/C#, Angular, and MongoDB. It provides a basic User Management interface that allows users to create and view user records while considering GDPR compliance aspects.

## Table of Contents

- [Technologies Used](#technologies-used)
- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Data Structure](#data-structure)
- [CRUD Functionality](#crud-functionality)
- [Angular Front-End](#angular-front-end)
- [MongoDB Integration](#mongodb-integration)
- [GDPR Compliance](#gdpr-compliance)
- [Code Structure](#code-structure)
- [Contributing](#contributing)
- [License](#license)

## Technologies Used

- .NET 8
- C#
- Angular 18
- MongoDB
- Angular Material for UI
- NgRx for state management

## Features

- Create User
- Read User List
- Basic styling with Angular Material
- Compound indexing in MongoDB
- Basic GDPR compliance features

## Installation

1. **Clone the repository:**
   ```bash
   git clone https://github.com/sandip-TOT/demo_gdpr_web_api.git
   cd gdpr-compliant-app
   ```

2. **Set up the back-end:**
   - Navigate to the back-end project directory.
   - Install the necessary packages:
     ```bash
     dotnet restore
     ```
   - Configure your MongoDB connection string in `appsettings.json`:
     ```json
     "ConnectionStrings": {
       "MongoDb": "mongodb://localhost:27017"
     }
     ```
   - Run the application:
     ```bash
     dotnet run
     ```

3. **Set up the front-end:**
   - Navigate to the front-end project directory.
   - Install the necessary packages:
     ```bash
     npm install
     ```
   - Start the Angular application:
     ```bash
     ng serve
     ```

## Usage

- Access the web application at `http://localhost:4200`.
- Use the "Add User" button to open the dialog and fill in user details.
- View the list of users displayed in a table.

## Data Structure

The application uses a `User` entity with the following attributes:

```csharp
public class User
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime DateOfBirth { get; set; }
    public bool Consent { get; set; }
}
```

## CRUD Functionality

- **Create:** Users can be created through the form in the dialog.
- **Read:** Users can be viewed in a table format.

## Angular Front-End

The front-end is built using Angular 18 and includes:

- Angular Material for UI components.
- NgRx for state management, handling user data efficiently.
- A responsive design using Bootstrap.

## MongoDB Integration

- The application uses MongoDB for data storage.
- A compound index is created on the `Email` and `DateOfBirth` fields to optimize queries.

### Compound Index Example

```csharp
var indexKeys = Builders<User>.IndexKeys
    .Ascending(user => user.Email)
    .Descending(user => user.DateOfBirth);

_users.Indexes.CreateOne(new CreateIndexModel<User>(indexKeys));
```

## GDPR Compliance

- The application considers basic GDPR compliance by allowing users to provide consent through a checkbox.
- User data is handled securely, and sensitive information is protected.

## Code Structure

- **Back-End:** Contains controllers, repositories, and models.
- **Front-End:** Contains components, services, and store management (NgRx).

## Contributing

Contributions are welcome! Please create a new issue or submit a pull request for any enhancements or bug fixes.

## License

This project is licensed under the MIT License. See the LICENSE file for details.
```
