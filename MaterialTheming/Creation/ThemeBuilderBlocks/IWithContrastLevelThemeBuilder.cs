namespace MaterialTheming.Creation.ThemeBuilderBlocks;

public interface IWithContrastLevelThemeBuilder<TBuilder>
    where TBuilder : IBuildableThemeBuilder
{
    /// <summary>
    /// Specify the contrast level that is used to build the <see cref="Theme" />.
    /// </summary>
    /// <param name="contrastLevel">The contrast level to use.</param>
    /// <returns>The <typeparamref name="TBuilder"/> with the specified contrast level.</returns>
    TBuilder WithContrastLevel(ContrastLevel contrastLevel);
}

public interface IWithContrastLevelValueThemeBuilder<TBuilder>
    where TBuilder : IBuildableThemeBuilder
{
    /// <summary>
    /// Specify the contrast level value that is used to build the <see cref="Theme" />.
    /// </summary>
    /// <param name="contrastLevel">
    /// The contrast level value to use.<br/>
    /// A value ranging between <c>-1.0</c> and <c>1.0</c>.
    /// <para>
    /// <c>0.0</c> = Normal<br/>
    /// <c>0.5</c> = Medium<br/> 
    /// <c>1.0</c> = High<br/>
    /// </para>
    /// </param>
    /// <returns>The <typeparamref name="TBuilder"/> with the specified contrast level value.</returns>
    TBuilder WithContrastLevel(double contrastLevel);
}