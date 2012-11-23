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
using System.Collections;

namespace WindowsGame1
{
    class pantalla
    {
        pelota pelota;
        raqueta raqueta1;
        raqueta raqueta2;
        private Hashtable tablaMovs= new Hashtable();
        // Desplazamiento de las paletas
        private int desplazamiento = 0;
        public pantalla()
        {
            desplazamiento=5;
            raqueta1 = new raqueta(14, 10);
            pelota = new pelota(GraphicsDeviceManager.DefaultBackBufferWidth / 2, GraphicsDeviceManager.DefaultBackBufferHeight / 2);
            raqueta2 = new raqueta(GraphicsDeviceManager.DefaultBackBufferWidth - 27, 20);
            // la tabla has alamacena un indice en nuestro caso una tecla, y devuelve un objeto que contiene un Int
            tablaMovs.Add(Keys.W,desplazamiento);
            tablaMovs.Add(Keys.Down, desplazamiento);
            tablaMovs.Add(Keys.Up, desplazamiento*(-1));
            tablaMovs.Add(Keys.S, desplazamiento*(-1));

        }
        public void RebotarPelota()
        {
            if (pelota.getFisicPelota().Intersects(raqueta1.getFisicRaqueta())
                || pelota.getFisicPelota().Intersects(raqueta2.getFisicRaqueta()))
            {
                pelota.setVelocidad(pelota.getVelocidad() * -1);
            }
            if (pelota.getPosicion().Y <= 4)
                pelota.setVelocidad(new Vector2(4, 4));
            if (pelota.getPosicion().Y >= (GraphicsDeviceManager.DefaultBackBufferHeight) + 105)
                pelota.setVelocidad(new Vector2(4, -4));
        }
        public void Initialize()
        {

        }
        public void LoadContent(ContentManager content)
        {
            pelota.setTextura(content.Load<Texture2D>("pong"));
            raqueta1.setTextura(pelota.getTextura());
            raqueta2.setTextura(pelota.getTextura());
        }
        public void UnloadContent()
        {
        }
        public void Update(KeyboardState estadoteclado)
        {
            try
            {

                // La tabla hash devuelve el objeto asociado al teclaro, este objeto es un entero para ello debemos
                // en primer lugar obtener el tostring el objeto y seguido pasamos esa cadena a entero
                raqueta2.moveY(int.Parse(tablaMovs[estadoteclado].ToString()));
                raqueta1.moveY(int.Parse(tablaMovs[estadoteclado].ToString()));
            }
            catch (Exception e)
            {
                e.ToString();
            }
             
            pelota.movePelota(pelota.getVelocidad());
            RebotarPelota();
        }
        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(pelota.getTextura(), pelota.getPosicion(), pelota.getRectangle(), Color.White);
            spritebatch.Draw(raqueta1.getTextura(), raqueta1.getPosicion(), raqueta1.getRectangle(), Color.Red);
            spritebatch.Draw(raqueta2.getTextura(), raqueta2.getPosicion(), raqueta2.getRectangle(), Color.Blue);

        }
    }
}
