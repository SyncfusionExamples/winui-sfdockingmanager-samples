using Microsoft.UI.Xaml.Controls;
using Syncfusion.UI.Xaml.Docking;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MVVM.ViewModel
{
    public class DockingViewModel
    {
        public ObservableCollection<DockPane> Panes { get; } = new ObservableCollection<DockPane>();

        public DockingViewModel()
        {
            Panes.Add(new DockPane()
            {
                Header = "Toolbox",
                DockDirection = Dock.Left,
                DockState = DockState.Docked,
                Content = new TextBlock() { Text = "Toolbox Content" }
            });

            Panes.Add(new DockPane()
            {
                Name="SolutionPane",
                Header = "Solution Explorer",
                DockDirection = Dock.Right,
                DockState = DockState.Docked,
                Content = new TextBlock() { Text = "Solution Content" }
            });

            Panes.Add(new DockPane()
            {
                Header = "GitHub",
                DockDirection = Dock.Bottom,
                DockState = DockState.Docked,
                TargetNameInDockedState = "SolutionPane",
                Content = new TextBlock() { Text = "GitHub Content" }
            });

            Panes.Add(new DockPane()
            {
                Header = "MainWindow.xaml",
                DockState = DockState.Document,
                Content = new TextBox() { AcceptsReturn = true }
            });
            Panes.Add(new DockPane()
            {
                Header = "MainWindow.xaml.cs",
                DockState = DockState.Document,
                Content = new TextBox() { AcceptsReturn = true }
            });

            Panes.Add(new DockPane()
            {
                Name="OutputPane",
                Header = "Output",
                DockState = DockState.Docked,
                DockDirection= Dock.Bottom,
                Content = new TextBox() { AcceptsReturn = true }
            });
            Panes.Add(new DockPane()
            {
                Header = "Immediate Window",
                DockState = DockState.Tabbed,
                DockDirection = Dock.Right,
                TargetNameInTabbedState= "OutputPane",
                Content = new TextBox() { AcceptsReturn = true }
            });
        }
    }
}
