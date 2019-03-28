using System;
using System.Collections.Generic;

namespace VisualChallenge
{
    public class VisualChallengePageVM
    {
        public List<AudioSection> AudioSections { get; set; }

        public VisualChallengePageVM()
        {
            AudioSections = new List<AudioSection>
            {
                new AudioSection("Beats")
                {
                    new AudioItem
                    {
                        Name = "Elmore Heights",
                        Time = "0:03"
                    },
                    new AudioItem
                    {
                        Name = "Gosling",
                        Time = "0:05"
                    },
                    new AudioItem
                    {
                        Name = "In The Back Room",
                        Time = "0:02"
                    },
                    new AudioItem
                    {
                        Name = "OneEightFour",
                        Time = "0:05"
                    },
                    new AudioItem
                    {
                        Name = "Patched in",
                        Time = "0:05"
                    },
                    new AudioItem
                    {
                        Name = "Peacoat",
                        Time = "0:03"
                    },
                    new AudioItem
                    {
                        Name = "Pedalrider",
                        Time = "0:05"
                    },
                    new AudioItem
                    {
                        Name = "Remix",
                        Time = "0:01"
                    },
                    new AudioItem
                    {
                        Name = "Rodney Skopes",
                        Time = "0:06"
                    },
                    new AudioItem
                    {
                        Name = "Swapping Tubes",
                        Time = "0:06"
                    },
                    new AudioItem
                    {
                        Name = "Three Stories",
                        Time = "0:05"
                    },
                    new AudioItem
                    {
                        Name = "Vinyl Couch",
                        Time = "0:03"
                    },
                    new AudioItem
                    {
                        Name = "Walking Shoes",
                        Time = "0:06"
                    },
                    new AudioItem
                    {
                        Name = "West",
                        Time = "0:08"
                    },


                },
                new AudioSection("Calm")
                {
                    new AudioItem
                    {
                        Name = "A Little Powder",
                        Time="0:07"
                    },
                    new AudioItem
                    {
                        Name = "Balti",
                        Time = "0:11"
                    },
                    new AudioItem
                    {
                        Name = "Grey Grey Joe",
                        Time = "0:09"
                    },
                    new AudioItem
                    {
                        Name = "Mineral Still",
                        Time = "0:07"
                    },
                    new AudioItem
                    {
                        Name = "Morning Colorwheel",
                        Time = "0:08"
                    },
                    new AudioItem
                    {
                        Name = "Night Light",
                        Time = "0:05"
                    },
                    new AudioItem
                    {
                        Name = "Promesa",
                        Time = "0:14"
                    },
                    new AudioItem
                    {
                        Name = "Step in Step Out",
                        Time = "0:10"
                    },
                    new AudioItem
                    {
                        Name = "Stuffed Monster",
                        Time = "0:09"
                    },
                    new AudioItem
                    {
                        Name = "Sunset at Sandy Isle",
                        Time = "0:09"
                    },
                    new AudioItem
                    {
                        Name = "The Provisions",
                        Time = "0:12"
                    },
                    new AudioItem
                    {
                        Name = "The Trestle",
                        Time = "0:16"
                    }
                },
                new AudioSection("Cheerful")
                {

                    new AudioItem
                    {
                        Name = "Dirtbike Lovers",
                        Time = "0:05"
                    },
                    new AudioItem
                    {
                        Name = "Rue Severine",
                        Time = "0:04"
                    },

                }
            };
        }
    }

    public class AudioSection : List<AudioItem>
    {
        public string Name { get; set; }
        public List<AudioItem> Items => this;

        public AudioSection(string name)
        {
            Name = name;
        }
    }

    public class AudioItem
    {
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
