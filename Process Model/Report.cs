using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Process_Model
{
    public partial class Report : DevExpress.XtraReports.UI.XtraReport
    {
        string colName;
        string sysName;
        public Report(string colName, string sysName)
        {
            this.colName = colName;
            this.sysName = sysName;
            InitializeComponent();
            

        }

    }
}
