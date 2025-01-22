namespace UrlShortnerAPI.Models
{
    public class ShortenedUrl
    {
        public Guid Id { get; set; }
        public string OriginalUrl { get; set; } = string.Empty;
        public string ShortUrl { get; set; } = string.Empty;
        public string ShortenedUrlCode { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
    }
}
