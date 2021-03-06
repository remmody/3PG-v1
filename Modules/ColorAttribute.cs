﻿using Discord;
using System;

namespace Bot3PG.Modules
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public sealed class ColorAttribute : Attribute
    {
        public Color Color { get; private set; }
        public byte R => Color.R;
        public byte G => Color.G;
        public byte B => Color.B;

        public ColorAttribute(byte r, byte g, byte b) => Color = new Color(r, g, b);
        public ColorAttribute(uint hexColor) => Color = new Color(hexColor);
    }
}