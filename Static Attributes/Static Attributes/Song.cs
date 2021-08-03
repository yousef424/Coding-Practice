using System;
using System.Collections.Generic;
using System.Text;

namespace Static_Attributes
{
    class Song
    {

        public string name;
        public string singer;
        public int num;
        public static int songCount = 0;


        public Song(string aName, string aSinger, int aNum)
        {
            name = aName;
            singer = aSinger;
            num = aNum;
            songCount++;

        }

        public int getSongCount()
        {
            return songCount;
        }
    }
}
