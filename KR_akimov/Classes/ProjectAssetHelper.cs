using System;
using System.IO;

namespace KR_akimov
{
    internal static class ProjectAssetHelper
    {
        public static string FindFile(params string[] relativeSegments)
        {
            DirectoryInfo currentDirectory = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);

            while (currentDirectory != null)
            {
                string candidatePath = currentDirectory.FullName;

                foreach (string segment in relativeSegments)
                {
                    candidatePath = Path.Combine(candidatePath, segment);
                }

                if (File.Exists(candidatePath))
                {
                    return candidatePath;
                }

                currentDirectory = currentDirectory.Parent;
            }

            return string.Empty;
        }
    }
}
