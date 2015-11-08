using System;
using System.Drawing;

namespace ExtensionMethodLibrary.ValueTypes.ColorExtension
{
    public static class ExtensionColor
    {
        public static Color GrayTone(byte darkness)
        {
            return Color.FromArgb(255 - darkness, 255 - darkness, 255 - darkness);
        }

        /// <summary>
        /// Creates color with corrected brightness.
        /// </summary>
        /// <param name="color">Color to correct.</param>
        /// <param name="lightFactor">The brightness correction factor. Must be between 0 and 100</param>
        /// <returns>
        /// Corrected <see cref="Color"/> structure.
        /// </returns>
        public static Color Lighten(this Color color, double lightFactor)
        {
            if (lightFactor > 100 || lightFactor < 0)
            {
                throw new ArgumentOutOfRangeException("lightFactor");
            }

            var lightFactorFloat = lightFactor / 100.0;

            var red = LightenColorComponent(color.R, lightFactorFloat);
            var green = LightenColorComponent(color.G, lightFactorFloat);
            var blue = LightenColorComponent(color.B, lightFactorFloat);

            return Color.FromArgb(color.A, red, green, blue);
        }

        /// <summary>
        /// Creates color with corrected darkeness.
        /// </summary>
        /// <param name="color">Color to correct.</param>
        /// <param name="darkFactor">The carkeness correction factor. Must be between 0 and 100</param>
        /// <returns>
        /// Corrected <see cref="Color"/> structure.
        /// </returns>
        public static Color Darken(this Color color, double darkFactor)
        {
            if (darkFactor > 100 || darkFactor < 0)
            {
                throw new ArgumentOutOfRangeException("darkFactor");
            }

            var darkFactorFloat = darkFactor / 100.0;

            var red = DarkenColorComponent(color.R, darkFactorFloat);
            var green = DarkenColorComponent(color.G, darkFactorFloat);
            var blue = DarkenColorComponent(color.B, darkFactorFloat);

            return Color.FromArgb(color.A, red, green, blue);
        }

        /// <summary>
        /// Creates color with corrected brightness.
        /// </summary>
        /// <param name="color">Color to correct.</param>
        /// <param name="lightFactor">The brightness correction factor. Must be between 0 and 100</param>
        /// <returns>
        /// Corrected <see cref="Color"/> structure.
        /// </returns>
        public static Color Lighten(this Color color, int lightFactor)
        {
            if (lightFactor > 100 || lightFactor < 0)
            {
                throw new ArgumentOutOfRangeException("lightFactor");
            }

            var lightFactorFloat = lightFactor / 100.0;

            var red = LightenColorComponent(color.R, lightFactorFloat);
            var green = LightenColorComponent(color.G, lightFactorFloat);
            var blue = LightenColorComponent(color.B, lightFactorFloat);

            return Color.FromArgb(color.A, red, green, blue);
        }

        /// <summary>
        /// Creates color with corrected darkeness.
        /// </summary>
        /// <param name="color">Color to correct.</param>
        /// <param name="darkFactor">The carkeness correction factor. Must be between 0 and 100</param>
        /// <returns>
        /// Corrected <see cref="Color"/> structure.
        /// </returns>
        public static Color Darken(this Color color, int darkFactor)
        {
            if (darkFactor > 100 || darkFactor < 0)
            {
                throw new ArgumentOutOfRangeException("darkFactor");
            }

            var darkFactorFloat = darkFactor / 100.0;

            var red = DarkenColorComponent(color.R, darkFactorFloat);
            var green = DarkenColorComponent(color.G, darkFactorFloat);
            var blue = DarkenColorComponent(color.B, darkFactorFloat);

            return Color.FromArgb(color.A, red, green, blue);
        }

        private static byte LightenColorComponent(byte color, double factor)
        {
            return (byte)((byte)(~color) * factor + color);
        }

        private static byte DarkenColorComponent(byte color, double factor)
        {
            return (byte)(color - factor * color);
        }
    }
}