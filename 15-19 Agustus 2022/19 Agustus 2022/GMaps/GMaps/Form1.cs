using System;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System.Windows.Forms;
using GMap.NET.WindowsForms.Markers;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;

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
            gMapControl1.Position = new PointLatLng(-6.934242, 107.623597);
            var pos = gMapControl1.Position;
            AddMarker(pos);
            _points.Add(pos);
            //gMapControl1.RefreshMap();
            gMapControl1.MinZoom = 7;
            gMapControl1.MaxZoom = 20;
            gMapControl1.Zoom = 15;
        }

        GMapOverlay markers = new GMapOverlay("markers");

        private void gMapControl1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                var point = gMapControl1.FromLocalToLatLng(e.X, e.Y);
                double lat = point.Lat;
                double lng = point.Lng;

                tboxLat.Text = lat + "";
                tboxLongt.Text = lng + "";

                if (_points.Count > 1)
                {
                    //RemoveOverlay and Point
                    RemoveOverlay();
                }
                //adding marker
                AddMarker(point);
                //adding point
                AddPoint(point);
                //adding line or polygon
                AddLine();
                TabelTembak();
            }
        }

        private void AddPoint(PointLatLng pointToAdd)
        {
            _points.Add(pointToAdd);
        }

        private void RemoveOverlay()
        {
            if (gMapControl1.Overlays.Count > 1)
            {
                gMapControl1.Overlays.RemoveAt(2);
                gMapControl1.Overlays.RemoveAt(1);
                _points.RemoveAt(1);
            }
        }

        private void AddLine()
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
            rounded = rounded * 1000;
            tboxDistance.Text = Convert.ToString(rounded);
            gMapControl1.RefreshMap();
        }

        private void AddMarker(PointLatLng markerToAdd, GMarkerGoogleType markerType = GMarkerGoogleType.red_dot)
        {
            var markers = new GMapOverlay("markers");
            var marker = new GMarkerGoogle(markerToAdd, markerType)
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

        private void TabelTembak()
        {
            double adistance = Convert.ToDouble(this.tboxDistance.Text);
            double f, rad, degrees;

            if (adistance <= 450)
            {
                f = adistance * 10 / Math.Pow(67, 2);
                if (f > 1)
                {
                    f = 1;
                }
                rad = Math.Asin(f);
                degrees = ((180 / Math.PI) * rad) / 2;
                tboxDegree.Text = Convert.ToString(degrees);
                tboxIsi.Text = "0";
            }
            else if (adistance <= 800)
            {
                f = adistance * 10 / Math.Pow(87, 2);
                if (f > 1)
                {
                    f = 1;
                }
                rad = Math.Asin(f);
                degrees = ((180 / Math.PI) * rad) / 2;
                tboxDegree.Text = Convert.ToString(degrees);
                tboxIsi.Text = "1";
            }
            else if (adistance <= 1350)
            {
                f = adistance * 10 / Math.Pow(113, 2);
                if (f > 1)
                {
                    f = 1;
                }
                rad = Math.Asin(f);
                degrees = ((180 / Math.PI) * rad) / 2;
                tboxDegree.Text = Convert.ToString(degrees);
                tboxIsi.Text = "2";
            }
            else if (adistance <= 2600)
            {
                f = adistance * 10 / Math.Pow(152, 2);
                if (f > 1)
                {
                    f = 1;
                }
                rad = Math.Asin(f);
                degrees = ((180 / Math.PI) * rad) / 2;
                tboxDegree.Text = Convert.ToString(degrees);
                tboxIsi.Text = "3";
            }
            else if (adistance <= 3700)
            {
                f = adistance * 10 / Math.Pow(170, 2);
                if (f > 1)
                {
                    f = 1;
                }
                rad = Math.Asin(f);
                degrees = ((180 / Math.PI) * rad) / 2;
                tboxDegree.Text = Convert.ToString(degrees);
                tboxIsi.Text = "4";
            }
            else if (adistance <= 4700)
            {
                f = adistance * 10 / Math.Pow(190, 2);
                if (f > 1)
                {
                    f = 1;
                }
                rad = Math.Asin(f);
                degrees = ((180 / Math.PI) * rad) / 2;
                tboxDegree.Text = Convert.ToString(degrees);
                tboxIsi.Text = "5";
            }
            else if (adistance <= 5600)
            {
                f = adistance * 10 / Math.Pow(196, 2);
                if (f > 1)
                {
                    f = 1;
                }
                rad = Math.Asin(f);
                degrees = ((180 / Math.PI) * rad) / 2;
                tboxDegree.Text = Convert.ToString(degrees);
                tboxIsi.Text = "6";
            }
            else if (adistance <= 6300)
            {
                f = adistance * 10 / Math.Pow(209, 2);
                if (f > 1)
                {
                    f = 1;
                }
                rad = Math.Asin(f);
                degrees = ((180 / Math.PI) * rad) / 2;
                tboxDegree.Text = Convert.ToString(degrees);
                tboxIsi.Text = "7";
            }
            else if (adistance <= 6500)
            {
                f = adistance * 10 / Math.Pow(255, 2);
                if (f > 1)
                {
                    f = 1;
                }
                rad = Math.Asin(f);
                degrees = ((180 / Math.PI) * rad) / 2;
                tboxDegree.Text = Convert.ToString(degrees);
                tboxIsi.Text = "8";
            }
            else
            {
                tboxDegree.Text = "Jarak Tidak Terjangkau";
                tboxIsi.Text = "Jarak Tidak Terjangkau";
            }
        }
    }
}