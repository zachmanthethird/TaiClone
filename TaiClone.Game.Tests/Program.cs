using osu.Framework;
using osu.Framework.Platform;

namespace TaiClone.Game.Tests
{
    public static class Program
    {
        public static void Main()
        {
            using (GameHost host = Host.GetSuitableDesktopHost("visual-tests"))
            using (var game = new TaiCloneTestBrowser())
                host.Run(game);
        }
    }
}
