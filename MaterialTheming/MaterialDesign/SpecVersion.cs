namespace MaterialTheming;

/// <summary>
/// The known Material 3 spec versions.
/// </summary>
public enum SpecVersion
{
    /// <summary>
    /// The spec version released in 2021.
    /// </summary>
    Spec2021,
    /// <summary>
    /// The spec version released in 2025.<br/>
    /// This spec version only implements the variants: Tonal Spot, Neutral, Expressive and Vibrant.<br/>
    /// Choosing a variant that is not implemented will fallback to Spec2021 behavior.
    /// </summary>
    Spec2025
}
