using System.IO;

namespace SvgExtractor
{
    public static class FileHelper
    {
        public static string ResourceTempFolder;

        public static void PreparingLoadingHtml()
        {
            ResourceTempFolder = GetTemporaryDirectory();
            if (!Directory.Exists(ResourceTempFolder))
            {
                Directory.CreateDirectory(ResourceTempFolder);
            }
            Properties.Resources.loading_frame.Save(ResourceTempFolder + "\\loading-frame.gif");
            File.WriteAllText(ResourceTempFolder + "\\Loading.html", Properties.Resources.Loading);
        }

        public static void DeleteTempFolder()
        {
            if (Directory.Exists(ResourceTempFolder))
            {
                var di = new DirectoryInfo(ResourceTempFolder);
                foreach (var file in di.GetFiles())
                {
                    file.Delete();
                }
                foreach (var dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }
                Directory.Delete(ResourceTempFolder);
            }
        }
        public static void CheckAndPreparingFolder()
        {
            if (!Directory.Exists(Form1.TempFolder))
            {
                Directory.CreateDirectory(Form1.TempFolder);
            }
            else
            {
                if (Directory.GetFiles(Form1.TempFolder).Length != 0)
                {
                    var folder = new DirectoryInfo(Form1.TempFolder);
                    foreach (var file in folder.GetFiles()) file.Delete();
                }
            }
        }
        private static string GetTemporaryDirectory()
        {
            string tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            Directory.CreateDirectory(tempDirectory);
            return tempDirectory;
        }


    }
}