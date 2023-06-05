using OpenQA.Selenium.Remote;

namespace Level.Auto.Template.SetUp
{
    public interface ISetUpWebDriver
    {
        RemoteWebDriver GetSetUpWebDriver();

        void CloseWebDriver();

        void GoTo(string url);

        bool HasQuit(RemoteWebDriver webDriver);
    }
}
