namespace Penguin.Extensions.Math.Extensions
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

    public static class FloatExtensions
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {
        /// <summary>
        /// Inclusive/Exclusive bounds check for an float
        /// </summary>
        /// <param name="x">The value to check</param>
        /// <param name="a">The lower inclusive bounds</param>
        /// <param name="b">The upper exclusive bounds</param>
        /// <returns>Whether or not the int falls between the values</returns>
        public static bool Between(this float x, float a, float b)
        {
            return x >= a && x < b;
        }
    }
}