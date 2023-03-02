﻿namespace FileRenamer
{
    public static class Renamer
    {
        public static void RenameFiles(RenameConfig methods, string[] fileNames)
        {
            int? number = methods.StartNumber;

            foreach (var fileName in fileNames)
            {
                var newName = string.Empty;
                var oldName = string.Empty;

                if (methods.UseNumbers)
                {
                    newName = number.ToString();
                    number++;
                }

                if (methods.UseExpression)
                {
                    newName += methods.Expression;
                }

                if (methods.UseOldName)
                {
                    oldName = Path.GetFileNameWithoutExtension(fileName);
                }

                var directoryPath = Path.GetDirectoryName(fileName);
                var extension = Path.GetExtension(fileName);
                newName = $"{directoryPath}\\{newName}{oldName}{extension}";

                try
                {
                    File.Move(fileName, newName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to rename file: {fileName} Error: {ex.Message}");
                }
            }
        }
    }
}
