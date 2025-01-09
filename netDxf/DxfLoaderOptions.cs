namespace netDxf;

/// <summary>
/// Options for some permissive flags (workarounds).
/// </summary>
[Flags]
public enum DxfLoaderOptions : uint
{
    /// <summary>
    /// No options enabled.
    /// </summary>
    None = 0,

    /// <summary>
    /// All options enabled.
    /// </summary>
    All = ~0u,

    /// <summary>
    /// Loader with chunk value "standard" ( fallback as "0" ).
    /// Applies if code in range [330,369].
    /// </summary>
    ChunkValueStringStandardAsZero = 1 << 0,

    /// <summary>
    /// Loader with chunk value "" ( fallback as "0" ).
    /// Applies if code in range [330,369].
    /// </summary>
    ChunkValueEmptyStringAsZero = 2 << 0,    
    
}
