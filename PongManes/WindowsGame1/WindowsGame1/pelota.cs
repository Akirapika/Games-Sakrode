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
    class pelota
    {
        Texture2D graf_pelota;
        Vector2 posicion;
        Vector2 velocidad = new Vector2();
        Rectangle rectPelota = new Rectangle();
        Rectangle fisicPelota = new Rectangle();
        public pelota(float posix,float posiy)
        {



            posicion = new Vector2(posix,posiy);
            velocidad.X = 4;
            velocidad.Y = 4;
            rectPelota = new Rectangle(17,0,15,15);
            fisicPelota = new Rectangle((int)posix, (int)posiy, 15, 15);
        }
        public Texture2D getTextura(){return graf_pelota;}
        public void setTextura(Texture2D t){ graf_pelota=t;}
        public Rectangle getRectangle(){return rectPelota;}
        public void setRectangle(Rectangle r) {rectPelota= r;}
        public Vector2 getPosicion() { return posicion; }
        public void setPosicion (Vector2 p) { posicion = p; }
        public Vector2 getVelocidad() { return velocidad; }
        public void setVelocidad(Vector2 v) { velocidad = v; }
        public void movePelota(Vector2 velocidad2) 
        {
            posicion = posicion + velocidad2;
            fisicPelota.X = (int)posicion.X;
            fisicPelota.Y = (int)posicion.Y;
        }
        public Rectangle getFisicPelota() { return fisicPelota; }
        
    }
}
