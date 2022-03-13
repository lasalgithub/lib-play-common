namespace Play.Common.Settings
{
    public class MongoDbSettings
    {
        public string Host { get; init; }

        public string Port { get; init; }

        private string connectionString;
        public string ConnectionString
        {
            get
            {
                return !string.IsNullOrWhiteSpace(connectionString) ?
                  connectionString : $"mongodb://{Host}:{Port}";
            }
            set { connectionString = value; }
        }

    }
}