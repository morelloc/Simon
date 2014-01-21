using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;


namespace Simon
{
    public static class SoundManager
    {
        private static List<SoundEffect> simonSounds = new List<SoundEffect>();
        private static int simonSoundCount = 4;

        private static SoundEffect gameOver;

        private static Random rand = new Random();

        public static void Initialize(ContentManager content)
        {
            try
            {
                gameOver = content.Load<SoundEffect>(@"gameover");

                for (int x = 1; x <= simonSoundCount; x++)
                {
                    simonSounds.Add(
                        content.Load<SoundEffect>(@"simonSound" +
                            x.ToString()));
                }
            }
            catch
            {
                Debug.Write("SoundManager Initialization Failed");
            }
        }

        public static void PlaySimonSound(SimonColors scolor)
        {
            try
            {
                simonSounds[(int)scolor].Play();
            }
            catch
            {
                Debug.Write("PlayExplosion Failed");
            }
        }

        public static void PlayGameOver()
        {
            try
            {
                gameOver.Play();
            }
            catch
            {
                Debug.Write("PlayPlayerShot Failed");
            }
        }



    }
}
