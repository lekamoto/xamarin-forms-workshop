using System;
using System.Collections.Generic;
using System.Text;

namespace Xfw.Models
{
    public sealed class Item
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string PictureUrl { get; set; }

        public static Item Create(string title
            , string description
            , string pictureUrl)
        => new Item
        {
            Title = title,
            Description = description,
            PictureUrl = pictureUrl
        };
    }
}
