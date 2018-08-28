namespace Cibbi.SimpleInspectors
{
	using UnityEditor;


	/// <summary>
    /// Draws the property Stored inside this object
    /// </summary>
    /// <param name="materialEditor">Material editor to draw the property in</param>
	public abstract class StoredProperty  {
		public abstract void DrawProperty(MaterialEditor materialEditor);
	}

}