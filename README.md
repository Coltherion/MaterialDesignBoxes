# MaterialDesignBoxes

Material Message Box and Input Box for WPF.

[![Release](https://img.shields.io/github/release/Coltherion/MaterialDesignBoxes.svg)](https://github.com/Coltherion/MaterialDesignBoxes/releases/latest?style=for-the-badge)

![Nuget](https://img.shields.io/nuget/v/MaterialDesignBoxes)

![Nuget](https://img.shields.io/nuget/dt/MaterialDesignBoxes?label=nuget%20downloads)

## :sparkle: Main Features

The message box has the following custom features:

:white_check_mark: Material design message with predefined or custom colors 

:white_check_mark: Message box can contain checkbook

:white_check_mark: Custom names for buttons (1-3 buttons)

:white_check_mark: Option to copy message box text to clipboard 

:white_check_mark: Scrollable message box content

:white_check_mark: Input box uses classical text input or combobox input

:white_check_mark: Button for adding clipboard content into input box

## :sparkle: Installing

:arrow_forward: [Download from Nuget ⤵](https://www.nuget.org/packages/MaterialDesignBoxes/)

:arrow_forward: Install from Package manager Console

```sh
$ Install-Package MaterialDesignBoxes
```

Or, if using `dotnet`

```sh
$ dotnet add package MaterialDesignBoxes
```

## :sparkle: Usage (Screenshots)

> add reference to App.xaml

```xaml#
 <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <materialDesign:BundledTheme
                    BaseTheme="Light"
                    PrimaryColor="Red"
                    SecondaryColor="Lime" />
                <ResourceDictionary Source="pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Defaults.xaml" />
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>
```

> add using statement

```c#
using MaterialDesignBoxes;
```

> Using a default message box

```c#
MessageBox.Show($"This is a message.", "Custom Title", MessageBoxButton.OkOnly, MessageBoxIcon.Information, BoxesThemeColor.Blue, MessageBoxFocus.Button1);
or
MessageBox.Show($"This is a message.", "Custom Title", MessageBoxButton.OkOnly, MessageBoxIcon.Information, Color.FromRgb(128, 0, 128), MessageBoxFocus.Button1);
```

or if you need the result

```c#
var outcome = MessageBox.Show($"This is a message.", "Custom Title", MessageBoxButton.YesNo, MessageBoxIcon.Question, BoxesThemeColor.Red, MessageBoxFocus.Button1);
if (outcome.Result == MessageBoxResult.Yes);
```

![Default Message](https://raw.githubusercontent.com/Coltherion/MaterialDesignBoxes/master/Screenshots/DefaultMessageBox.png)

> Using a message box with checkbox

```c#
var result = MessageBox.Show($"This is a simple message.", "Custom Title", MessageBoxButton.YesNoCancel, MessageBoxIcon.Warning, BoxesThemeColor.Red, MessageBoxFocus.Button1, checkBox: "Custom Checkbox");
if (result.Checkbox == MessageBoxCheckbox.Checked);
```

![Message box with checkbox](https://raw.githubusercontent.com/Coltherion/MaterialDesignBoxes/master/Screenshots/CheckboxMessageBox.png)

> Using a message with custom buttons (1-3 custom bottons)

```c#
MessageBox.Show("This is a message.", "Title", button1: "Done");
MessageBox.Show("This is a message.", "Title", button1: "Apply", button2: "Exit");
var outcome = MessageBox.Show("This is a message.", "Title", button1: "Help", button2: "Submit", button3: "Quit", MessageBoxIcon.Default, BoxesThemeColor.Green);
if (outcome.Result == MessageBoxResult.Button1);
```

![Message box with custom buttons](https://raw.githubusercontent.com/Coltherion/MaterialDesignBoxes/master/Screenshots/CustomButtonsMessageBox.png)

> Using a text input box

```c#
string result = InputBox.Show("Please enter your name:", color: Color.FromRgb(200, 150, 150));
```

![Text input box](https://raw.githubusercontent.com/Coltherion/MaterialDesignBoxes/master/Screenshots/TextInputBox.png)

> Using combobox input box

```c#
string result = InputBox.Show("Please choose item:", new string[] { "Item1", "Item2", "Item3" });
```

![Combobox input box](https://raw.githubusercontent.com/Coltherion/MaterialDesignBoxes/master/Screenshots/ComboboxInputBox.png)

## :sparkle: Toolkits used

This library is built on top of the following toolkits:

- [Material Design In XAML Toolkit](https://github.com/ButchersBoy/MaterialDesignInXamlToolkit) - Comprehensive and easy to use Material Design theme and control library for the Windows desktop.
- [Material Design Colors](https://github.com/MahApps/MahApps.Metro) - ResourceDictionary instances containing standard Google Material Design swatches, for inclusion in a XAML application. 

## :sparkle: Contributing to this project

- You could always contact me through Email for any feature or issue. :star:

- You need [Visual Studio 2015 Community/Enterprise Edition](https://www.visualstudio.com/) (upwards) to build and test the solution.

---

## :sparkle: Licence

The MIT License (MIT)

Copyright (c) 2023, Coltherion

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
