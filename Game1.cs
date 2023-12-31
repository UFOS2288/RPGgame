﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using RPGMapMaker;

namespace RPGgame
{
    public class Game1 : Game
    {
        public static Game1 Instance;
        public GraphicsDeviceManager graphics;
        public SpriteBatch spriteBatch;
        public List<GameObject> objects = new();

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            Instance = this;
        }

        protected override void Initialize()
        {
            for (int i = 0; i < objects.Count; i++)
            {
                objects[i].OnInit();
            }
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void Update(GameTime gameTime)
        {
            for (int i = 0; i < objects.Count; i++)
            {
                objects[i].OnUpdate(gameTime);
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            for (int i = 0; i < objects.Count; i++)
            {
                objects[i].OnDraw(gameTime);
            }

            base.Draw(gameTime);
        }



        public static void SpawnObject(ref GameObject newobj)
        {
            Instance.objects.Add(newobj);
        }
    }
}