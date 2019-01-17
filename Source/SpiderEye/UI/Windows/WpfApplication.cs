﻿using SpiderEye.Configuration;

namespace SpiderEye.UI.Windows
{
    internal class WpfApplication : ApplicationBase
    {
        public override IWindow MainWindow
        {
            get { return window; }
        }

        private readonly System.Windows.Application application;
        private readonly WpfWindow window;
        private readonly IWpfWebview webview;

        public WpfApplication(AppConfiguration config)
            : base(config)
        {
            window = new WpfWindow(config.Window);

            application = new System.Windows.Application();
            application.MainWindow = window;
        }

        public override void Exit()
        {
            application.Shutdown();
        }

        protected override void RunMainLoop()
        {
            application.Run();
        }
    }
}
