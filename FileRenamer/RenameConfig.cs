namespace FileRenamer
{
    public class RenameConfig
    {
        public bool UseNumbers { get; set; }
        public bool UseExpression { get; set; }
        public bool UseOldName { get; set; }
        public int? StartNumber { get; set; }
        public string? Expression { get; set; }
    }
}
