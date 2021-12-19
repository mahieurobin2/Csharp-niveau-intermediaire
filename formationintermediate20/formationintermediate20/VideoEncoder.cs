using System;
using System.Collections.Generic;

namespace formationintermediate20
{
    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> _notificationChannels;

        internal void RegisterNotificationChannel()
        {
            throw new NotImplementedException();
        }

        public VideoEncoder()
        {
            _notificationChannels = new List<INotificationChannel>();
        }

        public void Encode (Video video)
        {
            foreach (var channel in _notificationChannels)
                channel.Send(new Message());
        }

        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }
    }
}
