﻿using System.Collections.Generic;
using Playnite.SDK.Data;
using SixLabors.ImageSharp.Formats.Png;

namespace MetadataImageOptimizer.Settings
{
    public class MetadataImageOptimizerSettings : ObservableObject
    {
        private bool alwaysOptimizeOnSave;
        private ImageTypeSettings background;
        private ImageTypeSettings cover;
        private ImageTypeSettings icon;
        private QualitySettings quality;

        public MetadataImageOptimizerSettings()
        {
            SetDefaults();
        }

        [DontSerialize] public List<string> AvailableImageFormats { get; } = new List<string> { "bmp", "jpg", "png" };

        public bool AlwaysOptimizeOnSave { get => alwaysOptimizeOnSave; set => SetValue(ref alwaysOptimizeOnSave, value); }
        public ImageTypeSettings Background { get => background; set => SetValue(ref background, value); }
        public ImageTypeSettings Cover { get => cover; set => SetValue(ref cover, value); }
        public ImageTypeSettings Icon { get => icon; set => SetValue(ref icon, value); }
        public QualitySettings Quality { get => quality; set => SetValue(ref quality, value); }

        private void SetDefaults()
        {
            background = new ImageTypeSettings
            {
                Format = "jpg"
                , MaxHeight = 1080
                , MaxWidth = 1920
                , Optimize = false
            };

            cover = new ImageTypeSettings
            {
                Format = "jpg"
                , MaxHeight = 900
                , MaxWidth = 600
                , Optimize = false
            };

            icon = new ImageTypeSettings
            {
                Format = "png"
                , MaxHeight = 256
                , MaxWidth = 256
                , Optimize = false
            };

            quality = new QualitySettings { JpgQuality = 90, PngCompressionLevel = PngCompressionLevel.Level6 };
        }
    }
}
