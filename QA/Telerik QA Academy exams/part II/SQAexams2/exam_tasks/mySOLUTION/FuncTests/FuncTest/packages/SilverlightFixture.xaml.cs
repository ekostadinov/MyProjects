using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Browser;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace DBServer.Selenium.Silvernium.ReferenceApplication
{
    [ScriptableType]
    public partial class SilverlightFixture
    {
        public SilverlightFixture()
        {
            InitializeComponent();
            HtmlPage.RegisterScriptableObject("SilverlightFixture", this);
        }

        public string GetValue(string path)
        {
            var control = FindControl(path);
            return GetValue(control);
        }

        public string GetValue(string gridPath, string rowIndex, string path)
        {
            var control = FindControl(gridPath, rowIndex, path);
            return GetValue(control);
        }

        private string GetValue(DependencyObject control)
        {
            if (control is AutoCompleteBox)
            {
                return ((AutoCompleteBox)control).Text;
            }
            if (control is TextBox)
            {
                return ((TextBox)control).Text;
            }
            if (control is TextBlock)
            {
                return ((TextBlock)control).Text;
            }
            if (control is CheckBox)
            {
                return ((CheckBox)control).IsChecked.ToString();
            }
            if (control is RadioButton)
            {
                return ((RadioButton) control).IsChecked.ToString();
            }
            if (control is ComboBox)
            {
                return GetValue(control as ComboBox);
            }
            throw new SilverlightFixtureException("Unsupported control type: " + control.GetType());
        }

        private string GetValue(ComboBox comboBox)
        {
            var displayMemberPath = comboBox.DisplayMemberPath;

            var item = comboBox.SelectedItem;
            var comboBoxItem = item as ComboBoxItem;

            if (item == null)
            {
                return null;
            }
            if (!string.IsNullOrEmpty(displayMemberPath))
            {
                return (string)item.GetType().GetProperty(displayMemberPath).GetValue(item, null);
            }
            if (comboBoxItem != null && comboBoxItem.Content.GetType() == typeof(string))
            {
                return (string) comboBoxItem.Content;
            }
            if (item is DependencyObject)
            {
                return GetStringsFromPropertiesOfItselfAndChildren(item as DependencyObject, "");
            }
            throw new SilverlightFixtureException("Could not retrieve combo box value");
        }

        public void SetValue(string path, string value)
        {
            var component = FindControl(path);
            SetValue(component, value);
        }

        public void SetValue(string gridPath, string rowIndex, string path, string value)
        {
            var component = FindControl(gridPath, rowIndex, path);
            SetValue(component, value);
        }

        private void SetValue(DependencyObject component, string value)
        {
            if (component is AutoCompleteBox)
            {
                ((AutoCompleteBox)component).Text = value;
            }
            else if (component is TextBox)
            {
                ((TextBox)component).Text = value;
            }
            else if (component is CheckBox)
            {
                ((CheckBox)component).IsChecked = Boolean.Parse(value);
            }
            else if (component is RadioButton)
            {
                ((RadioButton)component).IsChecked = Boolean.Parse(value);
            }
            else if (component is ComboBox)
            {
                SetValue(component as ComboBox, value);
            }
        }

        private void SetValue(ComboBox comboBox, string value)
        {
            var displayMemberPath = comboBox.DisplayMemberPath;
            for (var i = 0; i < comboBox.Items.Count; i++)
            {
                var item = comboBox.Items.ElementAt(i);
                var comboBoxItem = item as ComboBoxItem;

                if (item == null)
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        comboBox.SelectedItem = item;
                        return;
                    }
                    continue;
                }

                if (!string.IsNullOrEmpty(displayMemberPath))
                {
                    var displayValue = (string)item.GetType().GetProperty(displayMemberPath).GetValue(item, null);
                    if (value == displayValue)
                    {
                        comboBox.SelectedItem = item;
                        return;
                    }
                }
                else if (comboBoxItem != null && comboBoxItem.Content.GetType() == typeof(string) && ((string)comboBoxItem.Content) == value)
                {
                    comboBox.SelectedItem = item;
                    return;
                }
                else if (item is DependencyObject && HasStringInSomePropertyOfItselfOrChildren(item as DependencyObject, value))
                {
                    comboBox.SelectedItem = item;
                    return;                  
                }

                //if (item.ContentTemplate != null && item.ContentTemplate.GetVisualChildren())
                //{
                //}
            }

            throw new SilverlightFixtureException("Value not found: " + value);
        }

        private bool HasStringInSomePropertyOfItselfOrChildren(DependencyObject node, string value)
        {
            foreach (var property in node.GetType().GetProperties())
            {
                if (property.CanRead && property.GetValue(node, null) as string == value)
                {
                    return true;
                }
            }
            foreach (var child in node.GetVisualChildren())
            {
                if (HasStringInSomePropertyOfItselfOrChildren(child, value))
                {
                    return true;
                }
            }
            return false;
        }

        private string GetStringsFromPropertiesOfItselfAndChildren(DependencyObject node, string currentStrings)
        {
            foreach (var property in node.GetType().GetProperties())
            {
                if (property.CanRead)
                {
                    currentStrings += "|" + property.GetValue(node, null);
                }
            }
            foreach (var child in node.GetVisualChildren())
            {
                currentStrings = GetStringsFromPropertiesOfItselfAndChildren(child, currentStrings);
            }
            return currentStrings;
        }

        public new string IsEnabled(string path)
        {
            var control = FindControl(path);
            return IsEnabled(control).ToString();
        }

        public new string IsEnabled(string gridPath, string rowIndex, string path)
        {
            var control = FindControl(gridPath, rowIndex, path);
            return IsEnabled(control).ToString();
        }

        private new bool IsEnabled(DependencyObject control)
        {
            if (control is TextBox)
            {
                return (!((TextBox) control).IsReadOnly);
            }
            if (control is ComboBox)
            {
                return (((ComboBox)control).IsEnabled);
            }
            if (control is Button)
            {
                return (((Button) control).IsEnabled);
            }
            throw new SilverlightFixtureException("Unsupported component type: " + control.GetType());
        }

        public void Click(string path)
        {
            var button = (Button)FindControl(path);
            Click(button);
        }

        public void Click(string gridPath, string rowIndex, string path)
        {
            var button = (Button)FindControl(gridPath, rowIndex, path);
            Click(button);
        }

        private void Click(Button button)
        {
            var peer = new ButtonAutomationPeer(button);
            var ip = (IInvokeProvider)peer;
            ip.Invoke();
        }

        public string GetProperty(string path, string propertyName)
        {
            var control = FindControl(path);
            return GetProperty(control, propertyName).ToString();
        }

        public string GetProperty(string gridPath, string rowIndex, string path, string propertyName)
        {
            var control = FindControl(gridPath, rowIndex, path);
            return GetProperty(control, propertyName).ToString();
        }

        private object GetProperty(DependencyObject control, string propertyName)
        {
            return control.GetType().GetProperty(propertyName).GetValue(control, null);
        }

        public string IsCellPresent(string path, string value)
        {
            var dataGrid = (DataGrid)FindControl(path);
            return IsCellPresent(dataGrid, value).ToString();
        }

        private bool IsCellPresent(DataGrid dataGrid, string value)
        {
            if (dataGrid.ItemsSource != null)
            {
                foreach (var row in dataGrid.ItemsSource)
                {
                    foreach (var column in dataGrid.Columns)
                    {
                        var renderer = column.GetCellContent(row);
                        if (renderer == null || renderer.GetType() != typeof(TextBlock)) continue;
                        var tb = (TextBlock)renderer;
                        if (value == tb.Text)
                            return true;
                    }
                }
            }
            return false;
        }

        public string RowContaining(string path, string value)
        {
            var dataGrid = (DataGrid)FindControl(path);
            if (dataGrid.ItemsSource != null)
            {
                var i = 0;
                foreach (var row in dataGrid.ItemsSource)
                {
                    foreach (var column in dataGrid.Columns)
                    {
                        var renderer = column.GetCellContent(row);
                        if (renderer == null || renderer.GetType() != typeof (TextBlock)) continue;
                        var tb = (TextBlock)renderer;
                        if (value == tb.Text)
                            return i.ToString();
                    }
                    i++;
                }
            }
            return "";
        }

        public string RowCount(string path)
        {
            var dataGrid = (DataGrid)FindControl(path);
            return dataGrid.ItemsSource != null ? dataGrid.ItemsSource.Cast<object>().Count().ToString() : "0";
        }

        public void SelectRowByIndex(string path, string index)
        {
            var dataGrid = (DataGrid)FindControl(path);
            dataGrid.SelectedIndex = int.Parse(index);
        }

        public string GoToPageContaining(string gridPath, string pagerPath, string value)
        {
            var grid = (DataGrid)FindControl(gridPath);
            var pager = (DataPager)FindControl(pagerPath);

            if (IsCellPresent(grid, value))
            {
                return pager.PageIndex.ToString();
            }

            for (var i = 0; i < pager.PageCount; i++)
            {
                pager.PageIndex = i;
                if (IsCellPresent(grid, value))
                {
                    return pager.PageIndex.ToString();
                }
            }

            return "";
        }

        public DependencyObject FindControl(string path)
        {
            var currentNode = WindowTracker.Instance().IsEmpty() ? this : (DependencyObject)WindowTracker.Instance().CurrentWindow();
            foreach (var partialPath in path.Split('.'))
            {
                currentNode = FindControl(partialPath, currentNode);
                if (currentNode == null)
                {
                    return null;
                }
            }
            return currentNode;
        }

        public DependencyObject FindControl(string gridPath, string rowIndex, string path)
        {
            var dataGrid = (DataGrid)FindControl(gridPath);
            var dataGridRow = FindDataGridRowByIndex(dataGrid, int.Parse(rowIndex));
            return FindControl(path, dataGridRow);
        }

        private DependencyObject FindControl(string path, DependencyObject currentParent)
        {
            var currChildren = currentParent.GetVisualChildren();
            foreach (var item in currChildren)
            {
                if (item.GetValue(NameProperty).ToString().Equals(path))
                    return item;

                var childItem = FindControl(path, item);
                if (childItem != null)
                    return childItem;
            }

            return null;
        }

        private DataGridRow FindDataGridRowByIndex(DataGrid dataGrid, int index)
        {
            return (DataGridRow)FindChildrenByType(dataGrid, typeof(DataGridRow))[index];
        }

        private List<DependencyObject> FindChildrenByType(DependencyObject parent, Type type)
        {
            var children = new List<DependencyObject>();
            FindChildrenByType(parent, type, children);
            return children;
        }

        private void FindChildrenByType(DependencyObject parent, Type type, ICollection<DependencyObject> children)
        {
            if (parent.GetType() == type)
            {
                children.Add(parent);
            }
            foreach (var child in parent.GetVisualChildren())
            {
                FindChildrenByType(child, type, children);
            }
        }

        public string Describe(string path)
        {
            return Describe(FindControl(path), "");
        }

        private string Describe(DependencyObject node, string identation)
        {
            var description = identation == string.Empty ? "" : identation.Substring(0, identation.Length - 1) + "-";
            description += node;
            description += !string.IsNullOrEmpty(node.GetValue(NameProperty).ToString()) 
                ? " - " + node.GetValue(NameProperty) : "";
            if (node.GetType() == typeof(TextBlock))
            {
                description += " - " + ((TextBlock)node).Text;
            }
            description += "\n";
            foreach (var child in node.GetVisualChildren())
            {
                description += Describe(child, identation + "| ");
            }
            return description;
        }
    }

    internal class SilverlightFixtureException : Exception
    {
        public SilverlightFixtureException(string message) 
            : base(message) { }
    }

}
