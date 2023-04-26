using System;
using System.Threading;

namespace Events_and_Delegates
{
    public class SubscribedEventArgs : EventArgs
    {
        public SubscribedChannels Channel { get; set; }
        public string Message { get; set; }
    }

    public class SubscribedChannels
    {
        public string channelsSubscribed = "Kann111";
    }

    public class ChannelSubscribe
    {
        public event EventHandler<SubscribedEventArgs> Subscribed;

        public void SubscribeToChannel(SubscribedChannels channelsSubscribed)
        {
            Console.WriteLine("Waiting for Subscribe button to be clicked...");
            Thread.Sleep(3000);

            OnSubscribed(new SubscribedEventArgs
            {
                Channel = channelsSubscribed,
                Message = $"You subscribed to {channelsSubscribed.channelsSubscribed}"
            });
        }

        protected virtual void OnSubscribed(SubscribedEventArgs e)
        {
            Subscribed?.Invoke(this, e);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ChannelSubscribe subscribe = new ChannelSubscribe();
            Subscribers subscribers = new Subscribers();

            subscribe.Subscribed += subscribers.Subscribed;
            subscribe.SubscribeToChannel(new SubscribedChannels { channelsSubscribed = "Kann111" });

            Console.ReadLine();
        }
    }

    public class Subscribers
    {
        public void Subscribed(object source, SubscribedEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
