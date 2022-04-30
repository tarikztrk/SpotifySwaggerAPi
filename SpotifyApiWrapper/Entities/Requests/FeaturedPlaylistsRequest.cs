﻿namespace SpotifyApiWrapper.Entities.Requests
{
    public class FeaturedPlaylistsRequest
    {
        public string? Country { get; set; }
        public string? Locale { get; set; }
        public string? Timestamp { get; set; }
        public string? Limit { get; set; }
        public string? Offset { get; set; }
    }
}
