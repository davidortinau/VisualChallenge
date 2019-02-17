using System;
using System.Collections.Generic;

namespace VisualChallenge
{
    public class VisualChallengeViewModel
    {
        public EventModel Event { get; set; }

        public VisualChallengeViewModel()
        {
            Initialize();
        }

        private void Initialize()
        {
            Event = new EventModel
            {
                Title = "Super Uber Event",
                Date = new DateTime(2019, 3, 28, 17, 00, 00),
                Country = "Poland",
                City = "Warsaw",
                Place = "Filharmonia Narodowa",
                Image = "image",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras consectetur et ante sed accumsan. Aliquam cursus suscipit tellus vitae fringilla. Aliquam elementum congue aliquet. Morbi fringilla quam eros, nec molestie ex dapibus et. Vivamus ultrices purus vel quam interdum mattis. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Mauris vitae ipsum vel ex elementum mattis ut id erat. Nunc cursus quam vitae urna dignissim, nec faucibus urna lacinia. Suspendisse volutpat interdum ligula, sit amet semper quam maximus quis. Duis id sapien massa. Morbi quis volutpat tellus. Phasellus id justo posuere, dignissim dui ac, scelerisque mauris.\n\nIn eget ex id quam pellentesque consequat a vitae lacus. Donec in congue tortor. Sed ultricies fermentum risus, non rhoncus nisl euismod id. Pellentesque eu tortor a nibh imperdiet auctor eget sed magna. Fusce nec orci nec quam suscipit posuere luctus eu tortor. Mauris convallis enim lacus, sit amet auctor justo molestie vitae. Aenean rhoncus congue aliquam. Aliquam pulvinar in libero id suscipit. Phasellus justo ex, porta nec enim non, finibus dictum lectus."
            };
        }
    }

    public class BaseModel
    {
        public string Title { get; internal set; }
    }

    public class EventModel : BaseModel
    {
        public DateTime Date { get; internal set; }
        public string Country { get; internal set; }
        public string City { get; internal set; }
        public string Place { get; internal set; }
        public string Image { get; internal set; }
        public string Description { get; internal set; }
        public string Location => string.Concat(City, ",", Country);
    }
}
