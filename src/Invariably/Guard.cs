using System;

namespace Invariably
{
    public static class Guard
    {
        public static void For(Func<bool> condition)
        {
            if (!condition())
            {
                throw new NotImplementedException();
            }
        }

        public static void Against(Func<bool> condition)
        {
            if (condition())
            {
                throw new NotImplementedException();
            }
        }
    }
}