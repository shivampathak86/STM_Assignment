//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using AventStack.ExtentReports.Configuration
//using AventStack.ExtentReports.Reporter;
//using System.IO;
//using AventStack.ExtentReports;

//namespace FrameworkLibrary.Utility
//{
//   public class ReportHelper
//    {
//        private string FolderPath = Directory.GetCurrentDirectory() + "\\" + DateTime.Now.ToString();
//        private ExtentReports m_extentReports;
//        public void ReportBuilder()
//        {
//            ExtenReportSetup();


//        }

//        private void ExtenReportSetup()
//        {
//            var hmtlReport = new ExtentHtmlReporter(FolderPath);
//            m_extentReports = new ExtentReports();
//            m_extentReports.AttachReporter(hmtlReport);

//        }

//        public 

//    }
//}
