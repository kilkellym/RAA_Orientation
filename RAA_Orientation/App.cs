#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;

#endregion

namespace RAA_Orientation
{
    internal class App : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication a)
        {
            TaskDialog.Show("Test", "I got to the application add-in!");

            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication a)
        {
            TaskDialog.Show("Test", "Revit is shutting down!");
            return Result.Succeeded;
        }
    }
}
