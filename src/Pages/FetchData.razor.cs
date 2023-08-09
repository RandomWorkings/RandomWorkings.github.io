using System.Net.Http.Json;

namespace RandomWorkings.github.io.Pages;

partial class FetchData
{
    private PathwayVideos[]? _videos;

    protected override async Task OnInitializedAsync()
    {
        _videos = await Http.GetFromJsonAsync<PathwayVideos[]>( "sample-data/videoCount.json" );
    }

    public class PathwayVideos
    {
        public string? Pathway { get; set; }

        public int VideoCount { get; set; }

        public Uri? Link { get; set; }
    }
}
