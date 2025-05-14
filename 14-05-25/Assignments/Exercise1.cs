using System;
namespace musicplayerapp
{
    interface imusicplayer
    {
        void play(string song);
        void stop();
        void pause();
    }

    class spotifyplayer : imusicplayer
    {
        public void play(string song)
        {
            Console.WriteLine($"playing {song} on spotify");
        }
        public void pause()
        {
            Console.WriteLine($"spotify playback paused");
        }
           
        public void stop()
        {
            Console.WriteLine($"spotify playback stopped");
        }
    }
    class Applemusicplayer : imusicplayer
    {
        public void play(string song)
        {
            Console.WriteLine($"playing {song} on applemusic");
        }
        public void pause()
        {
            Console.WriteLine($"Applemusic playback paused");
        }

        public void stop()
        {
            Console.WriteLine($"Applemusic playback stopped");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            imusicplayer spotify = new spotifyplayer();
            Applemusicplayer applemusicplayer = new Applemusicplayer();

            spotify.play("Despacito");
            spotify.pause();
            spotify.stop();

            Console.WriteLine();

            applemusicplayer.play("Despacito");
            applemusicplayer.pause();
            applemusicplayer.stop();

        }
    }

}