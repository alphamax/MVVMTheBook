using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Templating
{
    public class Plane
    {
        public Plane(string name, float x, float y)
        {
            Name = name;
            X = x;
            Y = y;
        }
        public string Name { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
    }
}
