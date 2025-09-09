

 How to Compile and Run

 Prerequisites
- Visual Studio 2022 or later
- .NET 8 SDK

 Build and Run in Visual Studio

1. Open the solution in Visual Studio.
2. Set the startup project to `CityAssist`.
3. Press `F5` or click **Run**.
4. The app will open in your default browser.

You should land on the CityAssist **Main Menu**, from which you can report issues.

 
 - Usage Instructions

1. Click "Report Issue" from the main menu.
2. Fill out the form:
   - Enter the location and description
   - Select a category
   - (Optional) Upload an image or document
   - (Optional) Enable "Notify Me" to opt-in for updates
3. Submit the report.
4. Your report will appear immediately in the right-hand panel with its submission time and status badge.


##  Dependencies

- `Microsoft.Extensions.DependencyInjection.Abstractions`  
  (Used to support simple `ReportService` dependency injection)


