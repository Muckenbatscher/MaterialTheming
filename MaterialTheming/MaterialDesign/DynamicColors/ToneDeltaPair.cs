namespace MaterialTheming.MaterialDesign.DynamicColors;

internal class ToneDeltaPair
{
    /// <summary>
    /// The first role in a pair.
    /// </summary>
    public DynamicColor RoleA { get; }

    /// <summary>
    /// The second role in a pair.
    /// </summary>
    public DynamicColor RoleB { get; }

    /// <summary>
    /// Required difference between tones. Absolute value, negative values have undefined behavior.
    /// </summary>
    public double Delta { get; }

    /// <summary>
    /// The relative relation between tones of roleA and roleB.
    /// </summary>
    public TonePolarity Polarity { get; }

    /// <summary>
    /// Whether these two roles should stay on the same side of the "awkward zone" (T50-59). This is
    /// necessary for certain cases where one role has two backgrounds.
    /// </summary>
    public bool StayTogether { get; }

    /// <summary>
    /// How to fulfill the tone delta pair constraint.
    /// </summary>
    public ToneDeltaConstraint Constraint { get; }

    /// <summary>
    /// Documents a constraint in tone distance between two DynamicColors.
    /// </summary>
    /// <param name="roleA">The first role in a pair.</param>
    /// <param name="roleB">The second role in a pair.</param>
    /// <param name="delta">Required difference between tones. Absolute value, negative values have undefined behavior.</param>
    /// <param name="polarity">The relative relation between tones of roleA and roleB.</param>
    /// <param name="stayTogether">Whether these two roles should stay on the same side of the "awkward zone" (T50-59).</param>
    public ToneDeltaPair(
        DynamicColor roleA,
        DynamicColor roleB,
        double delta,
        TonePolarity polarity,
        bool stayTogether)
    {
        RoleA = roleA;
        RoleB = roleB;
        Delta = delta;
        Polarity = polarity;
        StayTogether = stayTogether;
        Constraint = ToneDeltaConstraint.Exact;
    }

    /// <summary>
    /// Documents a constraint in tone distance between two DynamicColors.
    /// </summary>
    /// <param name="roleA">The first role in a pair.</param>
    /// <param name="roleB">The second role in a pair.</param>
    /// <param name="delta">Required difference between tones. Absolute value, negative values have undefined behavior.</param>
    /// <param name="polarity">The relative relation between tones of roleA and roleB.</param>
    /// <param name="constraint">How to fulfill the tone delta pair constraint.</param>
    public ToneDeltaPair(
        DynamicColor roleA,
        DynamicColor roleB,
        double delta,
        TonePolarity polarity,
        ToneDeltaConstraint constraint)
    {
        RoleA = roleA;
        RoleB = roleB;
        Delta = delta;
        Polarity = polarity;
        StayTogether = true;
        Constraint = constraint;
    }
}
