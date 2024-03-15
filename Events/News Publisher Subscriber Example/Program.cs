using System;

namespace News_Publisher_Subscriber_Example
{
    public class NewsArticle
    {
        public string Title { get; }
        public string Content { get; }

        public NewsArticle(string title, string content)
        {
            this.Title = title;
            this.Content = content;
        }
    }

    public class NewsPublisher
    {
        public event EventHandler<NewsArticle> NewNewsPublisher;

        public void PublishNews(string title, string content)
        {
            var article = new NewsArticle(title, content);

            OnNewNewsPublisher(article);
        }

        protected virtual void OnNewNewsPublisher(NewsArticle article)
        {
            NewNewsPublisher?.Invoke(this, article);
        }

    }

    public class NewsSubscriber
    {
        public string Name { get; }

        public NewsSubscriber(string name)
        {
            this.Name = name;
        }

        public void Subscribe(NewsPublisher publisher)
        {
            publisher.NewNewsPublisher += HandleNewNews;
        }

        public void UnSubscribe(NewsPublisher publisher)
        {
            publisher.NewNewsPublisher -= HandleNewNews;
        }

        private void HandleNewNews(object sender, NewsArticle article)
        {
            Console.WriteLine($"{Name} received a new news article:");
            Console.WriteLine($"Title: {article.Title}");
            Console.WriteLine($"Content: {article.Content}");
            Console.WriteLine();
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            NewsPublisher publisher = new NewsPublisher();
            NewsSubscriber subscriber1 = new NewsSubscriber("Subscriber 1");


            subscriber1.Subscribe(publisher);

            NewsSubscriber subscriber2 = new NewsSubscriber("Subscriber 2");
            subscriber2.Subscribe(publisher);

            publisher.PublishNews("Breaking News", "A significant event just happened!");

            publisher.PublishNews("Tech Update", "New gadgets are hitting the market.");

            // Unsubscribe a subscriber (e.g., subscriber1)
            subscriber1.UnSubscribe(publisher);

            publisher.PublishNews("Weather Forecast", "Expect sunny weather for the weekend.");

            // Unsubscribe another subscriber (e.g., subscriber2)
            subscriber2.UnSubscribe(publisher);

            publisher.PublishNews("Final Edition", "Last news update for today.");

            Console.ReadLine();
        }
    }
}
