using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PieExplodeMode = DevExpress.XtraCharts.PieExplodeMode;
using DevExpress.XtraScheduler;
using static DevExpress.XtraPrinting.Native.ExportOptionsPropertiesNames;

namespace DevChinook
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Customer> customers = DAL.CustomerDAL.search();

            bdsCustomer.DataSource = customers;

        }
    }
}
