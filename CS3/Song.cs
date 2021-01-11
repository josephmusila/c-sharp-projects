using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS3
{
    public class Song
    {
        public string title;
        public string artist;
        public int duration;
        public static int songCount=0;

        public Song(string aTitle,string aArtist, int aDuration)
        {
            title=aTitle;
            artist=aArtist;
            Duration=aDuration;
            songCount++;
        }
        public int getSongCount()
        {
            return songCount;
        }
        public int Duration
        {
            get{
                return duration;
            }
            set{
                if(value==200 || value==150 || value==300)
                {
                    duration=value;
                }
                else{
                    duration=600;
                }
            }

        }
    }
}