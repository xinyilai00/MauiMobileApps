using MauiMobileApps.View;

namespace MauiMobileApps
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }
        private void RegisterRoutes()
        {
            Routing.RegisterRoute(nameof(LayoutsPage), typeof(LayoutsPage));
            Routing.RegisterRoute(nameof(LayoutsStackPage), typeof(LayoutsStackPage));
            Routing.RegisterRoute(nameof(LayoutsVerticalPage), typeof(LayoutsVerticalPage));
            Routing.RegisterRoute(nameof(LayoutHorizontalPage), typeof(LayoutHorizontalPage));
            Routing.RegisterRoute(nameof(LayoutAbsolutePage), typeof(LayoutAbsolutePage));
            Routing.RegisterRoute(nameof(LayoutFlexPage), typeof(LayoutFlexPage));

            Routing.RegisterRoute(nameof(ImagesPage), typeof(ImagesPage));
            Routing.RegisterRoute(nameof(ImagesURIPage), typeof(ImagesURIPage));
            Routing.RegisterRoute(nameof(ImagesEmbeddedPage), typeof(ImagesEmbeddedPage));
            Routing.RegisterRoute(nameof(ImageActivityIndicatorPage), typeof(ImageActivityIndicatorPage));

            Routing.RegisterRoute(nameof(CollectionsPage), typeof(CollectionsPage));
            Routing.RegisterRoute(nameof(CollectionMMPage), typeof(CollectionMMPage));
            Routing.RegisterRoute(nameof(CollectionGOGwImagesPage), typeof(CollectionGOGwImagesPage));
            Routing.RegisterRoute(nameof(CollectionUpdateablePage), typeof(CollectionUpdateablePage));
            Routing.RegisterRoute(nameof(CollectionUpdateablewImagesPage), typeof(CollectionUpdateablewImagesPage));
            Routing.RegisterRoute(nameof(CollectionEditPage), typeof(CollectionEditPage));
            Routing.RegisterRoute(nameof(CollectionAddPage), typeof(CollectionAddPage));

            Routing.RegisterRoute(nameof(ControlsPage), typeof(ControlsPage));
            Routing.RegisterRoute(nameof(ControlSliderPage), typeof(ControlSliderPage));
            Routing.RegisterRoute(nameof(ControlSliderxamlPage), typeof(ControlSliderxamlPage));
            Routing.RegisterRoute(nameof(ControlSliderVMPage), typeof(ControlSliderVMPage));
            Routing.RegisterRoute(nameof(ControlStepperPage), typeof(ControlStepperPage));
            Routing.RegisterRoute(nameof(ControlSwitchVMPage), typeof(ControlSwitchVMPage));
        }
    }
}
