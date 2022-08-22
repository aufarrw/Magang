using System;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System.Windows.Forms;
using GMap.NET.WindowsForms.Markers;
using System.Collections.Generic;
using System.Drawing;

namespace GMaps01
{
    public partial class Form1 : Form
    {
        List<PointLatLng> _points;
        public Form1()
        {
            InitializeComponent();
            _points = new List<PointLatLng>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            gMapControl1.CacheLocation = @"cache";

            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.ShowCenter = false;
            gMapControl1.Position = new PointLatLng(-6.9175, 107.6191);
            gMapControl1.MinZoom = 10;
            gMapControl1.MaxZoom = 18;
            gMapControl1.Zoom = 13;
        }

        GMapOverlay markers = new GMapOverlay("markers");

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            double lat = Convert.ToDouble(tboxLat.Text);
            double lng = Convert.ToDouble(tboxLongt.Text);
            var point = new PointLatLng(lat, lng);
            LoadMap(point);
            AddMarker(point);
        }

        private void btnAddPoint_Click(object sender, EventArgs e)
        {
            _points.Add(new PointLatLng(Convert.ToDouble(tboxLat.Text), Convert.ToDouble(tboxLongt.Text)));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (gMapControl1.Overlays.Count > 0)
            {
                gMapControl1.Overlays.RemoveAt(0);
                _points.Clear();
                gMapControl1.Refresh();
            }
        }

        private void btnAddLine_Click(object sender, EventArgs e)
        {
            var polygon = new GMapPolygon(_points, "My Area")
            {
                Stroke = new Pen(Color.Blue, 2),
                Fill = new SolidBrush(Color.BurlyWood)
            };
            var polygons = new GMapOverlay("polygons");
            polygons.Polygons.Add(polygon);
            gMapControl1.Overlays.Add(polygons);
            double number = polygon.Distance;
            double rounded = Math.Round(number, 3);
            tboxDistance.Text = rounded + " Km";
            gMapControl1.RefreshMap();
        }

        private void gMapControl1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                var point = gMapControl1.FromLocalToLatLng(e.X, e.Y);
                double lat = point.Lat;
                double lng = point.Lng;

                tboxLat.Text = lat + "";
                tboxLongt.Text = lng + "";

                //load location
                LoadMap(point);

                //adding marker
                AddMarker(point);
                gMapControl1.RefreshMap();
            }
        }

        private void LoadMap(PointLatLng point)
        {
            gMapControl1.Position = point;
        }

        private void AddMarker(PointLatLng pointToAdd, GMarkerGoogleType markerType = GMarkerGoogleType.red_pushpin)
        {
            var markers = new GMapOverlay("markers");
            var marker = new GMarkerGoogle(pointToAdd, markerType)
            {
                ToolTipText = $"Latitude: {Math.Round(gMapControl1.Position.Lat, 3)} \nLongitude: {Math.Round(gMapControl1.Position.Lng, 3)}"
            };

            var toolTip = new GMapToolTip(marker)
            {
                Fill = new SolidBrush(Color.Wheat),
                Foreground = new SolidBrush(Color.Black),
                Offset = new Point(25, -25)
            };
            marker.ToolTip = toolTip;
            markers.Markers.Add(marker);
            gMapControl1.Overlays.Add(markers);
        }
    }
}