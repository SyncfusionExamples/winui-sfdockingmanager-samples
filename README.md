# winui-sfdockingmanager-samples

# Overview

This repository contains sample applications that demonstrate the capabilities of the Syncfusion **SfDockingManager** control for WinUI. The samples showcase common docking scenarios including docked panes, floating windows, tabbed groups, auto-hide panels, and document layouts.

These examples can be used as a reference for integrating and customizing SfDockingManager in real-world WinUI applications.

# Samples

This repository includes the following sample applications:

- **GettingStarted** (`Samples/GettingStarted`) - Demonstrates essential docking capabilities including docked panes (Left, Right, Bottom), tabbed pane groups, document interfaces, and auto-hidden panes.
- **DockAbility** (`Samples/DockAbility`) - Demonstrates how to configure dockability options (`DockAbility`, `AllowAutoHide`, `AllowFloat`) on individual `DockPane` elements across all available docking options: **Left**, **Right**, **Top**, **Bottom**, **Document**, and **Tabbed**.

# XAML

### Basic Docking with Auto-Hide Panes

The following snippet shows an SfDockingManager setup featuring docked, document, tabbed, and auto-hide panes:

```xml
<docking:SfDockingManager x:Name="dockingmanager">

    <!-- Left Docked -->
    <docking:DockPane x:Name="ToolBoxPane"
            Header="Toolbox"
            DockDirection="Left"
            DockState="Docked">
        <TextBlock Text="Toolbox Content" Margin="10"/>
    </docking:DockPane>

    <!-- Right Docked -->
    <docking:DockPane x:Name="SolutionExplorerPane"
            Header="Solution Explorer"
            DockDirection="Right"
            DockState="Docked">
        <TextBlock Text="Solution Explorer Content" Margin="10"/>
    </docking:DockPane>

    <!-- Bottom Docked -->
    <docking:DockPane x:Name="OutputPane"
            Header="Output"
            DockDirection="Bottom"
            DockState="Docked">
        <TextBlock Text="Build Output Window" Margin="10"/>
    </docking:DockPane>

    <!-- Document Window -->
    <docking:DockPane x:Name="Document1"
            Header="MainWindow.xaml"
            DockState="Document">
        <TextBox AcceptsReturn="True"
        Text="Main document editor..."
        Margin="5"/>
    </docking:DockPane>

    <!-- Another Document Window -->
    <docking:DockPane x:Name="Document2"
            Header="App.xaml"
            DockState="Document">
        <TextBox AcceptsReturn="True"
        Text="Another document..."
        Margin="5"/>
    </docking:DockPane>

    <!-- Tabbed with Output -->
    <docking:DockPane x:Name="ErrorListPane"
            Header="Error List" DockState="Tabbed" TargetNameInTabbedState="OutputPane">
        <TextBlock Text="Error List Content" Margin="10"/>
    </docking:DockPane>

    <!-- Auto-Hide Panes -->
    <docking:DockPane x:Name="PropertiesPane"
            Header="Properties"
            DockDirection="Right"
            DockState="AutoHidden">
        <TextBlock Text="Properties Content" Margin="10"/>
    </docking:DockPane>

    <docking:DockPane x:Name="FindResultsPane"
            Header="Find Results"
            DockDirection="Bottom"
            DockState="AutoHidden">
        <TextBlock Text="Find Results Content" Margin="10"/>
    </docking:DockPane>

    <docking:DockPane x:Name="BookmarksPane"
            Header="Bookmarks"
            DockDirection="Left"
            DockState="AutoHidden">
        <TextBlock Text="Bookmarks Content" Margin="10"/>
    </docking:DockPane>

</docking:SfDockingManager>
```

### DockAbility and Pane Capabilities

The following snippet shows how to configure `DockAbility`, `AllowAutoHide`, and `AllowFloat` directly on individual `DockPane` elements across all docking positions:

```xml
<docking:SfDockingManager x:Name="dockingManager">

    <!-- DockAbility restricted to Top edge -->
    <docking:DockPane x:Name="TopPane"
                      Header="Top Docked"
                      DockDirection="Top"
                      DockState="Docked"
                      DockAbility="Top"
                      AllowAutoHide="True"
                      AllowFloat="True"/>

    <!-- DockAbility restricted to Left edge -->
    <docking:DockPane x:Name="LeftPane"
                      Header="Left Docked"
                      DockDirection="Left"
                      DockState="Docked"
                      DockAbility="Left"
                      AllowAutoHide="True"
                      AllowFloat="True"/>

    <!-- DockAbility restricted to Right edge -->
    <docking:DockPane x:Name="RightPane"
                      Header="Right Docked"
                      DockDirection="Right"
                      DockState="Docked"
                      DockAbility="Right"
                      AllowAutoHide="True"
                      AllowFloat="True"/>

    <!-- DockAbility restricted to Bottom edge -->
    <docking:DockPane x:Name="BottomPane"
                      Header="Bottom Docked"
                      DockDirection="Bottom"
                      DockState="Docked"
                      DockAbility="Bottom"
                      AllowAutoHide="True"
                      AllowFloat="True"/>

    <!-- Document Pane: restricted to Document state, auto-hide disabled -->
    <docking:DockPane x:Name="DocumentPane"
                      Header="Document"
                      DockState="Document"
                      DockAbility="Document"
                      AllowAutoHide="False"
                      AllowFloat="True"/>

    <!-- Tabbed Pane: grouped with BottomPane -->
    <docking:DockPane x:Name="TabbedPane"
                      Header="Tabbed"
                      DockState="Tabbed"
                      TargetNameInTabbedState="BottomPane"
                      DockAbility="Tabbed"
                      AllowAutoHide="True"
                      AllowFloat="True"/>

</docking:SfDockingManager>
```

#### DockAbility Options
Each `DockPane` supports the `DockAbility` property with the following options:
- `All` - Can dock to any position, float, or enter document/tabbed states.
- `Left` - Can only dock to the left side.
- `Right` - Can only dock to the right side.
- `Top` - Can only dock to the top side.
- `Bottom` - Can only dock to the bottom side.
- `Document` - Can only dock into the document area.
- `Tabbed` - Can only form tabbed groups with other panes.
- `None` - Prevents docking to any side, keeping the pane locked in its current state.

# Use Cases

The SfDockingManager control is suitable for applications that require customizable and efficient workspace management.

Common use cases include:

- Integrated Development Environments (IDEs)
- Code editors and debugging tools
- Design and modeling software
- CAD and engineering applications
- Database management tools
- Enterprise management systems
- Monitoring and analytics dashboards
- Document-centric applications
- Financial and trading platforms

# Key Features

- Dock panes to any side of the application (Left, Right, Top, Bottom).
- Create tabbed groups of related panes.
- Float panes into independent windows.
- Auto-hide panes to maximize workspace area.
- Configure per-pane dockability and restrictions via `DockAbility` (`Left`, `Right`, `Top`, `Bottom`, `Document`, `Tabbed`, `None`, `All`).
- Control floating capability per pane via `DockPane.AllowFloat`.
- Control auto-hide capability per pane via `DockPane.AllowAutoHide`.
- Support multiple document interfaces.
- Rearrange panes through drag-and-drop operations.
- Visual docking hints for intuitive placement.
- Persist and restore custom layouts.
- Support complex workspace configurations.

# Conclusion

The SfDockingManager for WinUI provides a powerful docking framework for building modern desktop applications with Visual Studio-like experiences. This repository demonstrates common docking scenarios and serves as a reference for developers looking to implement flexible, customizable, and productive workspace layouts in WinUI applications.
