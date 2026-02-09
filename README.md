# MaterialTheming
[![NuGet](https://img.shields.io/nuget/v/MaterialTheming?logo=nuget)](https://www.nuget.org/packages/MaterialTheming/)
[![GitHub Actions Workflow Status](https://img.shields.io/github/actions/workflow/status/Muckenbatscher/MaterialTheming/official_commit_verify.yml?event=schedule&label=up-to-date)](https://github.com/Muckenbatscher/MaterialTheming/actions/workflows/official_commit_verify.yml)


**MaterialTheming** is a .NET library that implements the [Google Material 3 (Material You)](https://m3.material.io/styles/color/system/overview) color system. 
It allows developers to generate color schemes and dynamic themes.

It is independent of the frontend platform you are building your app on.
Whether you are building with Blazor, Maui, WPF, WinForms or Avalonia, this library provides the tools to calculate color schemes to style your app with.

This library is a faithful recreation of the [official Java implementation](https://github.com/material-foundation/material-color-utilities/tree/main/java) of the Material 3 color system.
It provides an additional Fluent API to build your custom theme.

## Features

* **Material 3 Compliance**: Full implementation of the Material Design 3 color algorithms. Including the proprietary HCT color space.
* **Verified Accuracy**: Output results tested against the official Google Java implementation.
* **Dynamic Color**: Generate complete schemes from a single source color.
* **High Accessibility**: Uses color math and color theory to ensure accessible contrast ratios and accurate tonal shifts.
* **Fluent API Builder**: An intuitive, readable syntax for constructing and customizing themes.

## Installation

The library is distributed as a [NuGet package](https://www.nuget.org/packages/MaterialTheming).

Add it to your project via the dotnet CLI:

```bash
dotnet add package MaterialTheming
```
Or search for **MaterialTheming** in the Visual Studio NuGet Package Manager.

## Getting Started
The core of the library is generating a `ThemeColors` object based on a source color input. 
This object has accessible properties for the color roles defined in Material 3.
You can do this via the Fluent API `ThemeBuilder`.


```csharp
// Generate the colors from a single source color
var themeColors = ThemeBuilder
    .CreateFromSourceColor("#6750A4")
    .Build();

// Access the generated colors
var surface = themeColors.Surface;
var onSurface = themeColors.OnSurface;
var primary = themeColors.Primary;
var onPrimary = themeColors.OnPrimary;
```

## Fluent API Theme Builder
The library features a Fluent API `ThemeBuilder` that makes creating themes simple and readable. 
This is the recommended way to use the library.

You can customize the generation process by chaining methods to define the various parameters to make the built theme fit your requirements.

### 1. Basic Theme from Source Color
Generate a standard theme based on a single source color.

```csharp
var myThemeColors = ThemeBuilder
    .CreateFromSourceColor("#006495") // Your source color
    .Build();
```

### 2. Customizing the Scheme
You can control various aspects of the generated theme.
These include all the options that the official Material 3 color implementation provides:
- Source color
- Dark or light mode
- Contrast level
- Variant
- Platform
- Spec version

```csharp
var customThemeColors = ThemeBuilder
    .CreateFromSourceColor("#D32F2F")
    .WithMode(ThemeMode.Dark)               // Use a dark mode
    .WithContrastLevel(ContrastLevel.High)  // Use a high contrast of foregound to background roles
    .WithVariant(Variant.Expressive)        // Use the 'Expressive' variant to generate the palettes
    .WithPlatform(Platform.Phone)           // Use phone as platform (also suited for desktop)
    .WithSpecVersion(SpecVersion.Spec2025)  // Use the Spec Version released in 2025
    .Build();
```

### 3. Building from Material Theme Builder JSON

If you already created a material theme at the official [Material Theme Builder](https://material-foundation.github.io/material-theme-builder/) you can export it as a JSON file there.
This JSON file can also be used in the `ThemeBuilder` to extract the contained `ThemeColors`.

```csharp
var themeBuilderJsonThemeColors = ThemeBuilder
    .CreateFromJsonContent(myJsonContent)    // Provide a string that contains the exported JSON content
    .WithMode(ThemeMode.Dark)                // Build the contained dark theme
    .WithContrastLevel(ContrastLevel.Normal) // Build the contained normal contrast level
    .Build();
```

## Correctness & Compliance

This library is not just an approximation of Material Design. 
It is a full re-implementation tested against the source of truth.
The official [Material 3 Java implementation](https://github.com/material-foundation/material-color-utilities/tree/main/java) by Google.

The output results are verified to be **fully compliant with said implementation**. 
The test suite covers an exhaustive matrix of theme creation parameters:

* **Source Colors:** A selection of 8 source colors with different hues.
* **Theme Modes:** Light and Dark.
* **Contrast Levels:** Normal, Medium, and High contrast level.
* **Variants:** All 9 variants defined in the Material 3 color system.
* **Spec Versions:** Both specification versions. 2021 and 2025.

All test expectations were [programmatically generated directly from the official Java library results](https://github.com/Muckenbatscher/material-color-utilities-testcases-generation), 
ensuring that the colors you generate in .NET are identical to those generated by the official implementation.
