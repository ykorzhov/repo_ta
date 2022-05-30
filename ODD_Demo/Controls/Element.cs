namespace ODD_Demo.Controls
{
    /// <summary>
    /// Abstract class is a class that containd at least one abstract member.
    /// We could not create an instance of abstract class.
    /// </summary>
    internal abstract class Element
    {
        public abstract string Name { get; }

        /// <summary>
        /// Abstract method is a method without implementation.
        /// Child class must implement abstract method from the parent class.
        /// </summary>
        public abstract bool IsVisible();

        public virtual void Click()
        {
            // some base logic - optional.
        }
    }
}