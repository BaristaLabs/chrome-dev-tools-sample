namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Location in the source code.
    /// </summary>
    public sealed class Location
    {
        /// <summary>
        /// Script identifier as reported in the &lt;code&gt;Debugger.scriptParsed&lt;/code&gt;.
        ///</summary>
        [JsonProperty("scriptId")]
        public string ScriptId
        {
            get;
            set;
        }
        /// <summary>
        /// Line number in the script (0-based).
        ///</summary>
        [JsonProperty("lineNumber")]
        public long LineNumber
        {
            get;
            set;
        }
        /// <summary>
        /// Column number in the script (0-based).
        ///</summary>
        [JsonProperty("columnNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? ColumnNumber
        {
            get;
            set;
        }
    }
}