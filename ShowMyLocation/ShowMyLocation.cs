using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ShowMyLocation
{
    public partial class ShowMyLocation : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        GMapObject gMapObject = new GMapObject();

        public ShowMyLocation()
        {
            InitializeComponent();
        }

        private void ShowMyLocation_Load(object sender, EventArgs e)
        {
            GetIPAddressLocation();
            tableLayoutPanel.Controls.Add(gMapObject, 1, 0);
        }

        private void GetIPAddressLocation(string ipAddress = null)
        {
            RestAPI restAPI = new RestAPI();
            var results = restAPI.GetResult(ipAddress);

            lblIPAddress.Text = results.query;
            lblCountry.Text = results.country;
            lblRegion.Text = results.region;
            lblCity.Text = results.city;

            gMapObject.ChangePosition(results.lat, results.lon);
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGetIPLocation_Click(object sender, EventArgs e)
        {
            GetIPAddressLocation(txtNewIPAddress.Text);
        }
    }
}
