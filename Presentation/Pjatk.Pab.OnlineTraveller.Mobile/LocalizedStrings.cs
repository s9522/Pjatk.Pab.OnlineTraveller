using Pjatk.Pab.OnlineTraveller.Mobile.Resources;

namespace Pjatk.Pab.OnlineTraveller.Mobile
{
    /// <summary>
    /// Provides access to string resources.
    /// </summary>
    public class LocalizedStrings
    {
        private static AppResources _localizedResources = new AppResources();

        public AppResources LocalizedResources { get { return _localizedResources; } }
    }
}