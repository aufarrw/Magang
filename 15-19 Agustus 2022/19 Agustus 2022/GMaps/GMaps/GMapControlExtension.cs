using GMap.NET.WindowsForms;

namespace GMaps01
{
    public static class GMapControlExtension
    {
        public static void RefreshMap(this GMapControl gMapControl1)
        {
            gMapControl1.Zoom--;
            gMapControl1.Zoom++;
        }
    }
}
