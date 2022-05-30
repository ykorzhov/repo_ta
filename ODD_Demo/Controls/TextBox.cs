namespace ODD_Demo.Controls
{
    internal class TextBox : WebUIElement
    {
        public TextBox()
        {
            _isVisible = true;
        }

        public void Get()
        {
        }

        /// <summary>
        /// Example of polymorphizm - Overriding (перевизначення методу).
        /// </summary>
        public override bool IsVisible()
        {
            return _isVisible;
        }
    }
}