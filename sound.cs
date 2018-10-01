using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace russian
{
    class sound
    {

        public void click_sound()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\shiv\Desktop\sounds\lets-go.wav");
            player.Play();

        }
        public void play_back_sound()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\\Users\shiv\Desktop\sounds\galga.wav");
            player.Play();

        }
        public void load_sound()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\shiv\Desktop\sounds\load.wav");
            player.Play();
        }
        public void spin_sound()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\shiv\Desktop\sounds\spin.wav");
            player.Play();
        }
        
        public void shoot()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\shiv\Desktop\sounds\shot.wav");
            player.Play();
        }
        public void miss()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\shiv\Desktop\sounds\Gun+Empty.wav");
        }


    }
}
    
