using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace MagicGradientsApp.Controls
{
    public partial class SnippetFrame : ContentView
    {
        public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title),
            typeof(string), typeof(SnippetFrame));

        public static readonly BindableProperty IsSnapshotProperty = BindableProperty.Create(nameof(IsSnapshot),
            typeof(bool), typeof(SnippetFrame));

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public bool IsSnapshot
        {
            get => (bool)GetValue(IsSnapshotProperty);
            set => SetValue(IsSnapshotProperty, value);
        }

        public SnippetFrame()
        {
            InitializeComponent();
        }

        protected override void OnApplyTemplate()
        {
            ExtendNameScope();
        }

        private void ExtendNameScope()
        {
            var nameScope = NameScope.GetNameScope(this);
            nameScope.RegisterName("BorderFrame", (Frame)GetTemplateChild("BorderFrame"));
            nameScope.RegisterName("TitleLabel", (Label)GetTemplateChild("TitleLabel"));
        }
    }
}