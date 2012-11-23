using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace WindowsGame1
{
    class raqueta
    {
        public raqueta(int pos1, int pos2)
        {
            posicion = new Vector2(pos1, pos2);
            rectRaqueta = new Rectangle(0, 0, 16, 73);
            fisicRaqueta = new Rectangle(pos1,pos2,16,73);
        }
        Texture2D graf_raqueta;
        public Vector2 posicion;
        Vector2 velocidad;
        Rectangle rectRaqueta;
        Rectangle fisicRaqueta;
        public Texture2D getTextura(){return graf_raqueta;}
        public void setTextura(Texture2D t){graf_raqueta = t;}
        public Rectangle getRectangle(){return rectRaqueta; ;}
        public void setRectangle(Rectangle r){rectRaqueta = r;}
        public Vector2 getPosicion(){return posicion;}
        public void setPosicion(Vector2 v) { posicion=v; }
        public Vector2 getVelocidad() { return velocidad; }
        public void setVelocidad(Vector2 v) { velocidad = v; }
        public void moveY(int n)
        { 
            posicion.Y += n;
            fisicRaqueta.Y += n;
        }
        public float getY() { return posicion.Y; }
        public Rectangle getFisicRaqueta() { return fisicRaqueta; }
    }
}
