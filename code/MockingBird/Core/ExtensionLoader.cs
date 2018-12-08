using Fiddler;
using MockingBird.UI;
using System.Drawing;
using System.Windows.Forms;
using System;

[assembly: RequiredVersion("4.6.20173.38786")]
namespace MockingBird.Core
{
    /// <summary>
    /// This class will load MockingBird 
    /// </summary>
    public sealed class ExtensionLoader : IFiddlerExtension, IDisposable
    {
        const string APPLICATION_NAME = "MockingBird";
        CodeView _codeView;

        public void OnLoad()
        {
            //Add icon to list
            FiddlerApplication.UI.tabsViews.ImageList.Images.Add(APPLICATION_NAME, new Bitmap(Properties.Resources.MockingBirdIcon));

            _codeView = new CodeView();
            //Add icon
            FiddlerApplication.UI.tabsViews.ImageList.Images.Add(APPLICATION_NAME, new Bitmap(Properties.Resources.MockingBirdIcon));
            var tab = new TabPage(APPLICATION_NAME);

            tab.Controls.Add(_codeView);

            FiddlerApplication.UI.tabsViews.TabPages.Add(tab);
            tab.ImageKey = APPLICATION_NAME;
            _codeView.Dock = DockStyle.Fill;

            FiddlerApplication.Log.LogString("MockingBird loaded");
        }

        public void OnBeforeUnload()
        {
            if (_codeView != null)
            {
                _codeView.Dispose();
            }
        }

        public void Dispose()
        {
            if(_codeView != null)
            {
                _codeView.Dispose();
            }
        }
    }
}
