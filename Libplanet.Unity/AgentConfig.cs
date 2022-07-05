using System.Text.Json;

namespace Libplanet.Unity
{
    /// <summary>
    /// An <see cref="Agent"/> configuration.
    /// </summary>
    public class AgentConfig
    {
        private static readonly JsonSerializerOptions _jsonSerializerOptions =
            new JsonSerializerOptions { WriteIndented = true };

        /// <summary>
        /// Determines whether an <see cref="Agent"/> preloads or not.
        /// </summary>
        public bool Preload { get; set; } = true;

        /// <summary>
        /// Determines whether an <see cref="Agent"/> mines or not.
        /// </summary>
        public bool Mine { get; set; } = true;

        /// <summary>
        /// Instantiate a <see cref="AgentConfig"/> instance from a json <see cref="string"/>.
        /// </summary>
        /// <param name="jsonString">The json <see cref="string"/> to parse.</param>
        /// <returns>The <see cref="AgentConfig"/> instance parsed from
        /// <paramref name="jsonString"/>.</returns>
        public static AgentConfig FromJson(string jsonString)
        {
            return JsonSerializer.Deserialize<AgentConfig>(jsonString, _jsonSerializerOptions);
        }

        /// <summary>
        /// Converts the instance into a json <see cref="string"/>.
        /// </summary>
        /// <returns>A json <see cref="string"/> representation of this <see cref="AgentConfig"/>.
        /// </returns>
        public string ToJson()
        {
            return JsonSerializer.Serialize<AgentConfig>(this, _jsonSerializerOptions);
        }
    }
}
