using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Threading.Tasks;

namespace RDPClientApplication
{
    public partial class HardwareDetails : Form
    {
        HardwareInfo info = new HardwareInfo();
        public HardwareDetails()
        {
            InitializeComponent();
        }

        private async void HardwareDetails_Load(object sender, EventArgs e)
        {
            //save hardware details
            HidingControls();
            bool success = await Task.Factory.StartNew(() => ReadDetails());
            if (success)
            {
                lblLoading.Visible = false;
                txtprocessId.Text = info.processorid;
                txtHDDSerialNo.Text = info.hddSerialNo;
                txtPhsicalMemory.Text = info.physicalMemory;
                txtBoardMaker.Text = info.boardMaker;
                txtBiosMaker.Text = info.biosMaker;
                txtCPUSpeed.Text = info.cpuSpeed;
                txtCPUMaker.Text = info.cpuMaker;
                txtRamMemory.Text = info.ramMemory;
                txtDesktopName.Text = info.desktopName;
                txtMacId.Text = info.macId;
                ShowControls();
            }

        }

        private bool ReadDetails()
        {
            info.processorid = HardwareInfo.GetProcessorId();
            info.hddSerialNo = HardwareInfo.GetHDDSerialNo();
            info.physicalMemory = HardwareInfo.GetPhysicalMemory();
            info.boardMaker = HardwareInfo.GetBoardMaker();
            info.biosMaker = HardwareInfo.GetBIOSmaker();
            info.cpuSpeed = HardwareInfo.GetCpuSpeedInGHz().ToString();
            info.cpuMaker = HardwareInfo.GetCPUManufacturer();
            info.macId = HardwareInfo.GetMACAddress();
            info.lastTimeUpdated = DateTime.Now.ToString();
            info.ramMemory = HardwareInfo.RamDetails();
            info.desktopName = System.Environment.MachineName;

            return DatabaseConnection.InsertHardwareDetails(info);
        }

        private void HidingControls()
        {
            desktopname.Visible = false;
            processoridlabel.Visible = false;
            ramlabel.Visible = false;
            physicalmemorylabel.Visible = false;
            macid.Visible = false;
            hddlabel.Visible = false;
            baordmakerlabel.Visible = false;
            biosmakerlabel.Visible = false;
            cpumakerlabel.Visible = false;
            cpuspeedlabel.Visible = false;

            txtDesktopName.Visible = false;
            txtprocessId.Visible = false;
            txtRamMemory.Visible = false;
            txtPhsicalMemory.Visible = false;
            txtMacId.Visible = false;
            txtHDDSerialNo.Visible = false;
            txtBoardMaker.Visible = false;
            txtBiosMaker.Visible = false;
            txtCPUMaker.Visible = false;
            txtCPUSpeed.Visible = false;
        }

        private void ShowControls()
        {
            desktopname.Visible = true;
            processoridlabel.Visible = true;
            ramlabel.Visible = true;
            physicalmemorylabel.Visible = true;
            macid.Visible = true;
            hddlabel.Visible = true;
            baordmakerlabel.Visible = true;
            biosmakerlabel.Visible = true;
            cpumakerlabel.Visible = true;
            cpuspeedlabel.Visible = true;

            txtDesktopName.Visible = true;
            txtprocessId.Visible = true;
            txtRamMemory.Visible = true;
            txtPhsicalMemory.Visible = true;
            txtMacId.Visible = true;
            txtHDDSerialNo.Visible = true;
            txtBoardMaker.Visible = true;
            txtBiosMaker.Visible = true;
            txtCPUMaker.Visible = true;
            txtCPUSpeed.Visible = true;
        }
    }
}
