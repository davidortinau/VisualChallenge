using System;
using System.Collections.ObjectModel;
using VisualChallenge.Model;

namespace VisualChallenge
{
    public class VisualChallengePageViewModel
    {
        public ObservableCollection<Habit> Featured { get; set; }
        public ObservableCollection<Habit> NightMeditations { get; set; }
        
        public ObservableCollection<Habit> Anxiety { get; set; }
        public VisualChallengePageViewModel()
        {
            Featured = new ObservableCollection<Habit>
            {
                new Habit { Title = "Seeing The Good In Others", Time = "10 mins", Photo = Photo1},
                new Habit { Title = "Forgiveness", Time = "5 mins", Photo = Photo2},
                new Habit { Title = "Embracing Life Transitions", Time = "5 mins" , Photo = Photo3},
                new Habit { Title = "One Minute Breaks", Time = "1 mins", Photo = Photo1},
                new Habit { Title = "Mindful Parenting", Time = "5 mins", Photo = Photo2},
                new Habit { Title = "Money Worries", Time = "5 mins", Photo = Photo3},
                new Habit { Title = "Overthinking", Time = "5 mins", Photo = Photo1},
                new Habit { Title = "Manifest Your Dreams", Time = "10 mins", Photo = Photo2},
                new Habit { Title = "Unlock Your Full Potential", Time = "5 mins", Photo = Photo2},
                new Habit { Title = "Work Anxiety", Time = "5 mins", Photo = Photo3}
            };
            
            NightMeditations = new ObservableCollection<Habit>
            {
                new Habit { Title = "Seeing The Good In Others", Time = "10 mins", Photo = Photo1},
                new Habit { Title = "Forgiveness", Time = "5 mins", Photo = Photo2},
                new Habit { Title = "Embracing Life Transitions", Time = "5 mins" , Photo = Photo3},
                new Habit { Title = "One Minute Breaks", Time = "1 mins", Photo = Photo1},
                new Habit { Title = "Mindful Parenting", Time = "5 mins", Photo = Photo2},
                new Habit { Title = "Money Worries", Time = "5 mins", Photo = Photo3},
                new Habit { Title = "Overthinking", Time = "5 mins", Photo = Photo1},
                new Habit { Title = "Manifest Your Dreams", Time = "10 mins", Photo = Photo2},
                new Habit { Title = "Unlock Your Full Potential", Time = "5 mins", Photo = Photo2},
                new Habit { Title = "Work Anxiety", Time = "5 mins", Photo = Photo3}
            };
            
            Anxiety = new ObservableCollection<Habit>
            {
                new Habit { Title = "Seeing The Good In Others", Time = "10 mins", Photo = Photo1},
                new Habit { Title = "Forgiveness", Time = "5 mins", Photo = Photo2},
                new Habit { Title = "Embracing Life Transitions", Time = "5 mins" , Photo = Photo3},
                new Habit { Title = "One Minute Breaks", Time = "1 mins", Photo = Photo1},
                new Habit { Title = "Mindful Parenting", Time = "5 mins", Photo = Photo2},
                new Habit { Title = "Money Worries", Time = "5 mins", Photo = Photo3},
                new Habit { Title = "Overthinking", Time = "5 mins", Photo = Photo1},
                new Habit { Title = "Manifest Your Dreams", Time = "10 mins", Photo = Photo2},
                new Habit { Title = "Unlock Your Full Potential", Time = "5 mins", Photo = Photo2},
                new Habit { Title = "Work Anxiety", Time = "5 mins", Photo = Photo3}
            };
            
        }

        private const string Photo1 = "https://www.freeaudiolibrary.com/img/cms/jetty-1373173_640.jpg";
        private const string Photo2 = "https://www.freeaudiolibrary.com/img/leoblog/b/lg-b-musica%20sin%20copyright.png";
        private const string Photo3 = "https://www.bensound.com/bensound-img/relaxing.jpg";
    }
}
