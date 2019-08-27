using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle_testing_station
{
    public partial class Form1 : Form
    {
        private TestingStation _testingStation;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayTestingStationDetails();
            DisplayCarServices();
        }

        void DisplayTestingStationDetails()
        {
            _testingStation = new TestingStation("1/20 Te West Road, Albany", "026 475 21823", "VTNZ Testing Station");
            lblHeader.Text = _testingStation.GetStationDetails();
        }

        void DisplayCarServices()
        {
            listService.Items.Insert(0, "WoF inspection:\t\t 50.00");
            listService.Items.Insert(1, "Modified vehicle check-up:\t 200.00");
            listService.Items.Insert(2, "Pre-purchase inspection:\t 150.00");
            listService.Items.Insert(3, "Certificate of Fitness:\t 210.00");
        }

        void UpdateTotalCount()
        {
            lblCount.Text = TestingStation.TotalNumberOfServices().ToString();
        }
        void UpdateTotalCost()
        {
            lblTotalPrice.Text = TestingStation.GetTotalPrice().ToString();
        }

        void UpdateDetailsList(IService obj)
        {
            lblDetails.Text = lblDetails.Text + "\n" + obj.GetServiceName() + ": " + obj.GetServicePrice().ToString();
        }

        private void RequestBtn_Click(object sender, EventArgs e)
        {
            if (listService.SelectedIndex == -1)
            {
                MessageBox.Show("Select a services");
            }
            else
            {
                if (listService.SelectedIndex == 0)
                {
                    _testingStation.AddService(new ServiceWrap("WoF inspection", 50.00M));
                    TestingStation.AddToTotal(_testingStation.TopOfServicesList().GetServicePrice());
                    UpdateDetailsList(_testingStation.TopOfServicesList());
                }
                if (listService.SelectedIndex == 1)
                {
                    _testingStation.AddService(new ServiceWrap("Modified vehicle check-up:", 200.00M));
                    TestingStation.AddToTotal(_testingStation.TopOfServicesList().GetServicePrice());
                    UpdateDetailsList(_testingStation.TopOfServicesList());
                }
                if (listService.SelectedIndex == 2)
                {
                    _testingStation.AddService(new ServiceWrap("Pre-purchase inspection", 150.00M));
                    TestingStation.AddToTotal(_testingStation.TopOfServicesList().GetServicePrice());
                    UpdateDetailsList(_testingStation.TopOfServicesList());
                }
                if (listService.SelectedIndex == 3)
                {
                    _testingStation.AddService(new ServiceWrap("Certificate of Fitness", 210.00M));
                    TestingStation.AddToTotal(_testingStation.TopOfServicesList().GetServicePrice());
                    UpdateDetailsList(_testingStation.TopOfServicesList());
                }
                UpdateTotalCount();
                UpdateTotalCost();
            }
        }        
    }
}