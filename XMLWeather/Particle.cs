using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    internal class Particle
    {
        public double x, y, vx, vy, grav, t;
        public int type;
        public int id;
        public double w;
        public Particle(double _x, double _y, double _vx, double _vy, double _grav, int _type)
        {
            x = _x;
            y = _y;
            vx = _vx;
            vy = _vy;
            grav = _grav;
            type = _type;
            t = 0;
            id = Form1.maxID;
            Form1.maxID++;
        }

        public void setWidth(double val)
        {
            w = val;
        }

        public void Move()
        {
            y += vy;
            x += vx;
            if (grav != 0)
            {
                vy += grav / 60;
            }
            t += 0.01;
        }
    }
}
