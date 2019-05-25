using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace MockingBird.Core
{
    /// <summary>
    /// This class provides helper functions to handle installed templates
    /// </summary>
    public static class TemplateController
    {
        const string TEMPLATE_FILE_EXT = ".tpl";
        private readonly static string templatePath;

        static TemplateController()
        {
            templatePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), TEMPLATE_FOLDER_NAME);
        }
        /// <summary>
        /// Template folder name is static as of now
        /// </summary>
        private const string TEMPLATE_FOLDER_NAME = "templates";
        
        /// <summary>
        /// Provides absolute template folder path name
        /// </summary>
        /// <returns>Template folder path</returns>
        public static string GetTemplatePath(String templateName)
        {
            return Path.Combine(templatePath, templateName + TEMPLATE_FILE_EXT);
        }
        /// <summary>
        /// Provides array of all installed template names from template folder
        /// </summary>
        /// <returns>Array of installed templates</returns>
        public static string[] GetAllInstalledTemplateNames()
        {
            return Directory.GetFiles(templatePath).Where(f => Path.GetExtension(f) == TEMPLATE_FILE_EXT).Select(x => { return Path.GetFileNameWithoutExtension(x); }).ToArray();
            
        }
        /// <summary>
        /// Get template text from template file name supplied
        /// </summary>
        /// <param name="templateName">template name</param>
        /// <returns></returns>
        public static string GetTemplateText(string templateName)
        {
            return File.ReadAllText(GetTemplatePath(templateName));
        }

        /// <summary>
        /// Update supplied template file with new template text 
        /// </summary>
        /// <param name="templateName">Template name</param>
        /// <param name="templateText">Template text</param>
        public static void SaveTemplateText(string templateName, string templateText)
        {
            File.WriteAllText(GetTemplatePath(templateName), templateText);
        }
    }
}
