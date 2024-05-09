using System.Net;

namespace Composer.Strategy
{
    public class NetworkImageLoadingStrategy : IImageLoadingStrategy
    {

        public byte[] LoadImage(string path)
        {
            using(var client = new WebClient())
            {
                return client.DownloadData(path);
            }
        }
    }
}
