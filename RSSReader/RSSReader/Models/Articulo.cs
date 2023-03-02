namespace RSSReaderApi.Models
{
    public class Articulo
    {
        public Guid ArticuloId { get; set; }
        public string? Titular { get; set; }
        public string? Subtitulo { get; set; }
        public string? Cuerpo { get; set; }
    }
}
