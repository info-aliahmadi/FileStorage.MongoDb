# ASP.NET Core MongoDB File Storage

This is an ASP.NET Core project that demonstrates how to store files in MongoDB database. The project is built using .NET 7 and MongoDB.Driver NuGet package.

## Prerequisites
- .NET 7 SDK or later
- MongoDB database instance
## Getting Started
1. Clone the repository using `git clone https://github.com/info-aliahmadi/FileStorage.MongoDb.git`.
2. Change directory to the cloned repository using `cd your-repository`.
3. Open the `appsettings.json` file and replace the connection string with your MongoDB instance connection string.
4. Run the application using `dotnet run`.

## Usage

The application allows users to upload and download files. Uploaded files are stored in the MongoDB database as binary data. To upload a file, click the "Upload" button and select the file you want to upload. To download a file, click the "Download" button next to the file you want to download.

## License
This project is licensed under the MIT License. See the LICENSE file for more information.

[![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)

