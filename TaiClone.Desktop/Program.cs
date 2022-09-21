using osu.Framework.Platform;
using osu.Framework;
using TaiClone.Game;

namespace TaiClone.Desktop
{
    public static class Program
    {
        public static void Main()
        {
            using (GameHost host = Host.GetSuitableDesktopHost(@"TaiClone"))
            using (osu.Framework.Game game = new TaiCloneGame())
                host.Run(game);
        }
    }
}
