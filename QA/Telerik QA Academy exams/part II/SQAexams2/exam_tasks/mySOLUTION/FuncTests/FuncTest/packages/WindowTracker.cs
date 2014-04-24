using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace DBServer.Selenium.Silvernium.ReferenceApplication
{
    public class WindowTracker
    {
        private static WindowTracker _instance;
        private readonly Stack<ChildWindow> _windows = new Stack<ChildWindow>();

        public static WindowTracker Instance()
        {
            return _instance ?? (_instance = new WindowTracker());
        }

        public void Track(ChildWindow window)
        {
            _windows.Push(window);
            window.Closed += WindowClosed;
        }

        public bool IsEmpty()
        {
            return _windows.Count == 0;
        }

        public ChildWindow CurrentWindow()
        {
            return _windows.Peek();
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        private void WindowClosed(object sender, EventArgs e)
        {
            if (_windows.Contains((ChildWindow) sender))
            {
                _windows.Pop();
            }
        }

    }
}

