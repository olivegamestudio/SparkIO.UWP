using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Xna.Framework;
using Utility;

namespace SparkIO;

/// <summary>
/// Defines a set of methods for working with the file system by using MonoGame calls.
/// </summary>
public class FileSystemMonoGame : IFileSystem
{
    readonly ILogger<FileSystemMonoGame> _logger;

    public FileSystemMonoGame(ILogger<FileSystemMonoGame> logger = null)
    {
        _logger = logger;
    }

    /// <inheritdoc />
    public Task<Stream> OpenStreamAsync(string filename)
    {
        filename = Guard.ThrowIfStringNullOrEmpty(filename);
        _logger?.LogInformation($"Opening stream: '{filename}'...");
        return Task.FromResult(TitleContainer.OpenStream(filename));
    }
}
