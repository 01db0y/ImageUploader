﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FancyImageUploader.Models
{
    public class ImagesModel
    {
        public ImagesModel()
        {
            Images = new List<string>();
        }

        public List<string> Images { get; set; }
    }
}