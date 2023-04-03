using DDD.Domain.Exceptions;

namespace DDD.Domain.Helpers
{
    public static class Guard
    {
        public static void IsNull(object o, string message)
        {
            if (o is null)
            {
                throw new InputException(message);
            }
        }

        public static float IsFloat(string text, string message)
        {
            if (!float.TryParse(text, out float floatValue))
            {
                throw new InputException(message);
            }
            return floatValue;
        }
    }
}
