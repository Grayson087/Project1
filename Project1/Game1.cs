using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using static System.Net.Mime.MediaTypeNames;

namespace Project1
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D circletexture;
        Texture2D squaretexture;
        private SpriteFont titlefont;

        public SpriteFont SpriteFont { get; private set; }

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
           
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
            
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            circletexture = Content.Load<Texture2D>("circle");
            squaretexture = Content.Load<Texture2D>("square");
            titlefont = Content.Load<SpriteFont>("title");

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
            _spriteBatch.Begin();
            _spriteBatch.Draw(circletexture, new Rectangle(200, 200, 200, 200), Color.Yellow);
            _spriteBatch.Draw(circletexture, new Rectangle(200, 200, 50, 75), Color.Black);
            _spriteBatch.Draw(circletexture, new Rectangle(350, 200, 50, 75), Color.Black);
            _spriteBatch.Draw(squaretexture, new Rectangle(225, 350, 150, 25), Color.Black);
            _spriteBatch.DrawString(titlefont, "wazap", new Vector2(225, 350), Color.White);


            _spriteBatch.End();
        }
    }
}
