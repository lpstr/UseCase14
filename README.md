## Description ##

This project demonstrates a simple yet efficient use of .NET Core's built-in localization capabilities. The application provides a localized user interface where dates, numbers, and certain measurement units (length, weight, and volume) are displayed according to the selected culture. Users can switch between English, French, Ukrainian, and Bulgarian cultures. The culture selection is stored in a cookie and used for subsequent requests. The localizations are based on resource files that are associated with the HomeController. This is an ideal example for developers who want to incorporate localization in their ASP.NET Core applications for enhancing the user experience in different geographic regions.

## Local run ##

To run a MVC .NET 6 project locally, you would need the following prerequisites:

.NET 6 SDK: You can download it from the official .NET download page: https://dotnet.microsoft.com/download

An Integrated Development Environment (IDE) like Visual Studio or Visual Studio Code. You can download them from here:

Visual Studio: https://visualstudio.microsoft.com/downloads/
Visual Studio Code: https://code.visualstudio.com/download
Once you have these installed, you can follow the steps below to run the project:

Using Visual Studio:

Open Visual Studio.

Click on "File" -> "Open" -> "Project/Solution".

Navigate to the .sln file of your MVC .NET 6 project, select it, and click on "Open".

Once the project is loaded, press F5 or click on the green "Start Debugging" button to run the project.

Using Visual Studio Code and Command Line:

Open Visual Studio Code.

Open the terminal (Ctrl+ ` or View -> Terminal).

Navigate to the project's directory by using the cd command.

Once you're in the project directory, type dotnet run to build and run your project.

In both cases, your default web browser should automatically open and navigate to the local address where your app is hosted (usually https://localhost:5001/ or http://localhost:5000/). If it doesn't, you can manually enter this address in your web browser.

Remember, each time you make changes to the code, you will need to stop the running application and start it again for changes to take effect.

## URL change ##

Change to English (en):
URL: https://yourapp.com/?culture=en
Description: By appending ?culture=en to the base URL of your application, you can switch the locale to English. This will change the language and cultural settings to English, providing a localized experience for English-speaking users.

Change to French (fr):
URL: https://yourapp.com/?culture=fr
Description: Similar to the first example, by appending ?culture=fr to the base URL of your application, you can switch the locale to French. This will update the language and cultural settings to French, allowing French-speaking users to interact with the application in their preferred language.

Please note that the culture parameter value should correspond to the specific culture codes supported by your application. The above examples demonstrate how to change the locale by modifying the URL, but you can also implement other mechanisms like dropdown menus or buttons to provide a user-friendly way to switch between different cultures.