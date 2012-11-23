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
    class mundo
    {
        pantalla pantalla1 = new pantalla();

        public void Initialize()
        {
            pantalla1.Initialize();
        }
        public void LoadContent(ContentManager content)
        {
            pantalla1.LoadContent(content);
        }
        public void UnloadContent()
        {
        }
        public void Update(KeyboardState estadoteclado)
        {
            pantalla1.Update(estadoteclado);
        }
        public void Draw(SpriteBatch spritebatch)
        {
            pantalla1.Draw(spritebatch);
        }
    }
}
