# Homework03_03_01
# AllViews Revit Plugin

A Revit external command that generates a new sheet containing all selected views from the project.

## Overview

This plugin allows users to quickly create a new sheet populated with multiple selected views. It provides a graphical interface to browse available views, select a title block, and specify a sheet name.

## Features

*   **View Selection:** Browse and select multiple views from a tree view of all placeable views in the project.
*   **Title Block Selection:** Choose from a list of all available title block families in the project.
*   **Custom Sheet Naming:** Specify a custom name for the new sheet.
*   **Automated Placement:** Automatically generates a new sheet and places all selected views onto it.

## Compatibility

* **Revit Version:** 2011 and later (First released for v9.0)
* **Platform:** All (supports both Revit Architecture, Structure, MEP, etc.)
* **Language:** C#

## Installation

1.  Compile the project in Visual Studio to generate a `.dll` file.
2.  **For Revit 2011-2015:** Use the `.addin` manifest file.
    *   Create a `.addin` file (e.g., `AllViews.addin`) in the Revit add-ins folder (`%APPDATA%\Autodesk\Revit\Addins\[Version]`).
    *   Add the following content, adjusting the path to your compiled `.dll`:

    ```xml
    <?xml version="1.0" encoding="utf-8" standalone="no"?>
    <RevitAddIns>
      <AddIn Type="Command">
        <Text>AllViews</Text>
        <Description>Creates a sheet with selected views.</Description>
        <FullClassName>AllViews.Command</FullClassName>
        <Assembly>Full\Path\To\Your\AllViews.dll</Assembly>
        <VendorId>YOUR_VENDOR</VendorId>
        <VendorDescription>Your Company Name</VendorDescription>
      </AddIn>
    </RevitAddIns>
    ```

3.  **For Revit 2016+:** The `.addin` file method still works, or you can package the add-in for easier distribution.

## Usage

1.  Open a Revit project.
2.  Navigate to the **Add-Ins** tab and find the **AllViews** command.
3.  The **AllViews** dialog will open:
    *   **Title Block List:** Select the desired title block for the new sheet.
    *   **Views Tree:** Check the box next to each view you want to include on the new sheet.
    *   **Sheet Name:** Enter a name for the new sheet.
4.  Click **OK**.
5.  A new sheet will be created, containing all the selected views placed on it. You can then adjust the viewports as needed.

## Project Structure

*   **AllViews.cs**
    *   `Command` class: Implements `IExternalCommand` and serves as the entry point for the external command.
    *   `ViewsMgr` class: Core logic for retrieving views, creating a new sheet, and placing the selected views.
*   **AllViewsForm.cs**
    *   `AllViewsForm` class: The main dialog window (WPF/WinForms) containing:
        *   Tree view for selecting placeable views.
        *   List of available title blocks.
        *   Text box for entering the sheet name.

## Key API Demonstrations

This sample demonstrates the use of several important Revit API features:

*   Retrieving all placeable views from the document (`Autodesk.Revit.DB.FilteredElementCollector`).
*   Working with `ViewSet` collections.
*   Creating a new sheet using `Document.Create.NewViewSheet`.
*   Placing views on a sheet via `Viewport.Create`.

## Development

**Skill Level:** Medium

**Dependencies:**
*   .NET Framework (version depends on Revit target)
*   Revit API assemblies

## License

This sample code is provided "as-is" for learning and demonstration purposes. Please refer to the original source or accompanying license file for specific terms.

## Contributing

This is a sample project. Forks and improvements are welcome via pull requests.
