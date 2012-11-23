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
    class pantalla
    {
        pelota pelota;
        raqueta raqueta1;
        raqueta raqueta2;
        public pantalla()
        {
            raqueta1 = new raqueta(14, 10);
            pelota = new pelota(GraphicsDeviceManager.DefaultBackBufferWidth / 2, GraphicsDeviceManager.DefaultBackBufferHeight / 2);
            raqueta2 = new raqueta(GraphicsDeviceManager.DefaultBackBufferWidth - 27, 20);
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
            if (estadoteclado.IsKeyDown(Keys.Down) && raqueta2.getY()<=(GraphicsDeviceManager.DefaultBackBufferHeight + 40))
                raqueta2.moveY(5);
            if (estadoteclado.IsKeyDown(Keys.Up) && raqueta2.getY()>=4)
                raqueta2.moveY(-5);
            if (estadoteclado.IsKeyDown(Keys.S))
                raqueta1.moveY(5);
            if (estadoteclado.IsKeyDown(Keys.W))
                raqueta1.moveY(-5);
            pelota.movePelota(pelota.getVelocidad());
            if (pelota.getFisicPelota().Intersects(raqueta1.getFisicRaqueta()) 
                || pelota.getFisicPelota().Intersects(raqueta2.getFisicRaqueta()))
            {
                pelota.setVelocidad(pelota.getVelocidad()*-1);
            }
        }
        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(pelota.getTextura(), pelota.getPosicion(), pelota.getRectangle(), Color.White);
            spritebatch.Draw(raqueta1.getTextura(), raqueta1.getPosicion(), raqueta1.getRectangle(), Color.Red);
            spritebatch.Draw(raqueta2.getTextura(), raqueta2.getPosicion(), raqueta2.getRectangle(), Color.Blue);

        }
    }
}
