using osu.Framework.Testing;

namespace TaiClone.Game.Tests.Visual
{
    public class TaiCloneTestScene : TestScene
    {
        protected override ITestSceneTestRunner CreateRunner() => new TaiCloneTestSceneTestRunner();

        private class TaiCloneTestSceneTestRunner : TaiCloneGameBase, ITestSceneTestRunner
        {
            private TestSceneTestRunner.TestRunner runner;

            protected override void LoadAsyncComplete()
            {
                base.LoadAsyncComplete();
                Add(runner = new TestSceneTestRunner.TestRunner());
            }

            public void RunTestBlocking(TestScene test) => runner.RunTestBlocking(test);
        }
    }
}
