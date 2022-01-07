using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowMyLocation
{
    public class GMapObject : GMapControl
    {
        public GMapObject()
        {
            Bearing = 0F;
            CanDragMap = true;
            Dock = System.Windows.Forms.DockStyle.Fill;
            EmptyTileColor = System.Drawing.Color.Navy;
            GrayScaleMode = false;
            HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            LevelsKeepInMemory = 5;
            Location = new System.Drawing.Point(3, 3);
            MarkersEnabled = true;
            MaxZoom = 100;
            MinZoom = 1;
            MouseWheelZoomEnabled = true;
            MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            Name = "gMapControl";
            NegativeMode = false;
            PolygonsEnabled = true;
            RetryLoadTile = 0;
            RoutesEnabled = true;
            ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            ShowTileGridLines = false;
            TabIndex = 0;
            Zoom = 12D;
            BorderStyle = System.Windows.Forms.BorderStyle.None;

            MapProvider = GMapProviders.GoogleMap;
            DragButton = MouseButtons.Left;
            ShowCenter = false;
        }

        public void ChangePosition(double lat, double lon)
        {
            var mapPosition = new GMap.NET.PointLatLng(lat, lon);
            Position = mapPosition;

            GMapMarker gMapMarker = new GMarkerGoogle(mapPosition, GMarkerGoogleType.blue_pushpin);
            GMapOverlay gMapOverlay = new GMapOverlay();
            gMapOverlay.Markers.Add(gMapMarker);
            Overlays.Add(gMapOverlay);
        }
    }
}
