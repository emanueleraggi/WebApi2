namespace WebApi2.Models
{
    // Comment: long? with exclamation mark are used for Google Drive. Without it it will give errors
    public class GoogleDriveFiles
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public long? Size { get; set; }

        public long? Version { get; set; }

        public DateTime? CreatedTime { get; set; }
    }
}