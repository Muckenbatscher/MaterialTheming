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
    /// Choosing a variant that is not implemented will fallback to <see cref="Spec2021"/> behavior.
    /// </summary>
    Spec2025,
    /// <summary>
    /// The spec version released in 2026.<br/>
    /// This spec version only implements the 'CMF' variant. <br/>
    /// Chosing variant Tonal Spot, Neutral, Expressive or Vibrant will result in a fallback to <see cref="Spec2025"/>.<br/>
    /// Choosing any other variant will fallback to <see cref="Spec2021"/> behavior.
    /// </summary>
    Spec2026
}
