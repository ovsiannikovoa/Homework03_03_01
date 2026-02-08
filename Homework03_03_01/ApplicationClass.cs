using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.Attributes;
using System.Windows.Media.Imaging;

namespace Homework03_03_01
{
    [Transaction(TransactionMode.Manual)]
    public class ApplicationClass : IExternalApplication
    {
        public Result OnShutdown(UIControlledApplication application)
        {
            application.CreateRibbonTab("ПИК-Привет");
            var panel = application.CreateRibbonPanel("ПИК-Привет","Общее");
            var button = new PushButtonData(
                "Hello",
                "Привет",
                "C:\\Users\\ovsiannikovoa\\Software Development Kit\\Samples\\AllViews\\CS\\bin\\Debug\\AllViews.dll",
                "Revit.SDK.Samples.AllViews.CS.Command"
                );


            BitmapImage bitmapImage = new BitmapImage(new Uri("C:\\Users\\ovsiannikovoa\\AppData\\Roaming\\Autodesk\\Revit\\Addins\\2019\\Homework03_03_01\\img\\AcotecPanelsLayout32.png", UriKind.Absolute));
            button.LargeImage=bitmapImage;
            panel.AddItem(button);
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            return Result.Succeeded;
        }
    }
}
