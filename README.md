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

## Usage

1.  Open a Revit project.
2.  Navigate to the **Add-Ins** tab and find the **AllViews** command.
3.  The **AllViews** dialog will open:
    *   **Title Block List:** Select the desired title block for the new sheet.
    *   **Views Tree:** Check the box next to each view you want to include on the new sheet.
    *   **Sheet Name:** Enter a name for the new sheet.
4.  Click **OK**.
5.  A new sheet will be created, containing all the selected views placed on it. You can then adjust the viewports as needed.

## Development

**Skill Level:** Medium

**Dependencies:**
*   .NET Framework (version depends on Revit target)
*   Revit API assemblies
