using static System.Math;

namespace SimpleClass
{
    /// <summary>
    /// В этом классе на примерах буду рассматривать, как 
    /// работает using staic ... с использованием Math
    /// </summary>
    public class StaticUsingClass
    {
        public static int МодульНаДва(int x = -4)
        {
            return Abs(x) * 2;
        }
    }
}
