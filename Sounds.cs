using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Connect4_Final_Ptoject
{
    // Sounds (it was funn!!)
    internal class Sounds
    {
        string BgmSoundPath = @"./sounds/bgm.wav";
        string IntroPath = @"./sounds/intro.wav";
        string MatchSoundPath = @"./sounds/match.wav";

        public void PlayBgm()
        {
            SoundPlayer player = new SoundPlayer(BgmSoundPath);
            player.Play();
        }
        public void StopBgm()
        {
            SoundPlayer soundPlayer = new SoundPlayer(BgmSoundPath);
            soundPlayer.Stop();
        }
        public void PlayIntro()
        {
            SoundPlayer playPlayer = new SoundPlayer(IntroPath);
            playPlayer.Play();
        }
        
        public void PlayMatch() 
        {
            SoundPlayer matchPlayer = new SoundPlayer(MatchSoundPath);
            matchPlayer.Play();
        }

        public void StopMatch()
        {
            SoundPlayer playPlayer = new SoundPlayer(MatchSoundPath);
            playPlayer.Stop();
        }

    }
}
