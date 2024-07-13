namespace Brysageek.GeoEntify;

/// <summary>
/// Base Class Library for Wrapping GeoElements to Entities
/// </summary>
/// <param name="attributes"></param>
public abstract class GeoElementWrapper(ref IDictionary<string, object?> attributes)
{
    private readonly IDictionary<string, object?> _attributes = attributes;

    /// <summary>
    /// Map the attribute to the model property for use within property Getters
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="fieldName">The Field Name corresponding to the backing Attributed Field Name</param>
    /// <returns><see cref="T"/> of the available Esri Data Types</returns>
    public T ModelProperty<T>(string fieldName)
    {
        return (T)_attributes[fieldName]!;
    }

    /// <summary>
    /// Map the attribute to the model property for use within property Setters
    /// </summary>
    /// <typeparam name="T">The Type of Esri Data Type to map the Attributed Value to</typeparam>
    /// <param name="fieldName">The Field Name corresponding to the backing Attributed Field Name</param>
    /// <param name="value">the value that will be set</param>
    public void ModelProperty<T>(string fieldName, T? value)
    {
        _attributes[fieldName] = value;
    }
}
