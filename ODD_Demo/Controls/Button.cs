namespace ODD_Demo.Controls
{
    /// <summary>
    /// Inheritance could be from one class only(!), but from many interfaces.
    /// </summary>
    internal class Button : WebUIElement
    {
        // Bad practice!!!! Don't use new for unheritance, it's very confusing.
        public new string Text { get; set; }
    }
}