# winui-sfdockingmanager-samples

# Overview

This repository contains sample applications that demonstrate the capabilities of the Syncfusion **SfDockingManager** control for WinUI. The samples showcase common docking scenarios including docked panes, floating windows, tabbed groups, auto-hide panels, and document layouts.

These examples can be used as a reference for integrating and customizing SfDockingManager in real-world WinUI applications.

# XAML

The following snippet shows the basic setup of an SfDockingManager with docked panes:

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
            Header="Error List" DockState="Tabbed" TargetNameInTabbedState="OutputPane"
            >
        <TextBlock Text="Error List Content" Margin="10"/>
    </docking:DockPane>

</docking:SfDockingManager>

```
# Use Cases

The SfDockingManager control is suitable for applications that require customizable and efficient workspace management.

Common use cases include:

-Integrated Development Environments (IDEs)
-Code editors and debugging tools
-Design and modeling software
-CAD and engineering applications
-Database management tools
-Enterprise management systems
-Monitoring and analytics dashboards
-Document-centric applications
-Financial and trading platforms

# Key Features

-Dock panes to any side of the application.
-Create tabbed groups of related panes.
-Float panes into independent windows.
-Auto-hide panes to maximize workspace area.
-Support multiple document interfaces.
-Rearrange panes through drag-and-drop operations.
-Visual docking hints for intuitive placement.
-Persist and restore custom layouts.
-Support complex workspace configurations.

# Conclusion

The SfDockingManager for WinUI provides a powerful docking framework for building modern desktop applications with Visual Studio-like experiences. This repository demonstrates common docking scenarios and serves as a reference for developers looking to implement flexible, customizable, and productive workspace layouts in WinUI applications.

