﻿using Avalonia.Animation;

namespace Avalonia.ExtendedToolkit.Extensions
{
    public class KeyFrameExt: KeyFrame
    {
        public string Name
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }

        public static readonly StyledProperty<string> NameProperty =
            AvaloniaProperty.Register<KeyFrameExt, string>(nameof(Name));
    }
}