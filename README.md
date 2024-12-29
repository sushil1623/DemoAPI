Refresh Token Demo in .NET Core
This project demonstrates how to implement refresh tokens in a .NET Core application. The implementation includes adding users, logging in, generating access tokens and refresh tokens, and refreshing access tokens using refresh tokens.

Prerequisites
.NET Core SDK

Visual Studio or Visual Studio Code

Basic knowledge of ASP.NET Core and JWT

Getting Started
Follow these instructions to get the project up and running.

1. Clone the Repository
Clone this repository to your local machine:

sh
git clone https://github.com/yourusername/RefreshTokenDemo.git
cd RefreshTokenDemo
2. Install Dependencies
Ensure you have the necessary packages installed:

sh
dotnet restore
3. Configuration
Update the appsettings.json file with your JWT settings:

json
{
  "JWTSettings": {
    "Key": "YourSecretKeyHere",
    "Issuer": "YourIssuer",
    "Audience": "YourAudience"
  }
}
4. Run the Application
Build and run the application:

sh
dotnet build
dotnet run
API Endpoints
Add User
Endpoint to add a new user.

POST /api/auth/adduser
Body: 
{
  "userId": "testuser",
  "password": "password",
  "emailId": "testuser@example.com"
}
Login
Endpoint to log in and generate access and refresh tokens.

POST /api/auth/login
Body: 
{
  "userId": "testuser",
  "password": "password"
}
Refresh Token
Endpoint to refresh access tokens using the refresh token.

POST /api/auth/refreshtoken
Body:
{
  "accessToken": "currentAccessToken",
  "refreshToken": "currentRefreshToken"
}
Add Product (Protected)
Endpoint to add products, requires valid JWT.

POST /api/auth/addproduct
Headers:
  Authorization: Bearer {accessToken}
Get Products (Protected)
Endpoint to get the list of products, requires valid JWT.

GET /api/auth/getproducts
Headers:
  Authorization: Bearer {accessToken}
Implementation Details
Authentication: Uses JWT for stateless authentication.

Refresh Tokens: Securely generates and stores refresh tokens for renewing access tokens.

Authorization: Protects endpoints using [Authorize] attribute.

License
This project is licensed under the MIT License - see the LICENSE file for details.

Acknowledgments
ASP.NET Core Documentation

JWT Authentication Documentation
