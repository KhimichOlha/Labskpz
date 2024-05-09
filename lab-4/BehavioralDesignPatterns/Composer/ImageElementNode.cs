using Composer.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composer
{
    public class ImageElementNode : LightNode
    {
        private string href;
        private IImageLoadingStrategy strategy;
        public ImageElementNode(string href, IImageLoadingStrategy strategy)
        {
            this.href = href;
            this.strategy = strategy;
        }

        public override string OuterHTML => $"<img src=\"{href}\" />";

        public override string InnerHTML => "";
        public byte[] ImageData()
        {
            return strategy.LoadImage(href);
        }
    }
}
