using System;

namespace ODD_Demo.Controls
{
    internal class WebUIElement : Element, IWebUIElement, IDisposable
    {
        protected bool _isVisible = false;

        public string Text { get; set; }

        public override string Name => nameof(WebUIElement);

        /// <summary>
        /// Example of polymorphizm - Overloading (перевантаження методу).
        /// The method Click() has zero parameters.
        /// </summary>
        public override void Click()
        {
        }

        /// <summary>
        /// Example of polymorphizm - Overloading (перевантаження методу).
        /// The method Click() has one parameters.
        /// </summary>
        public void Click(bool moveMouse)
        {
            if (_isVisible && moveMouse)
            {
                MoveMouse();
            }

            Click();
        }

        /// <summary>
        /// Example of polymorphizm - Overloading (перевантаження методу).
        /// The method Click() has two parameters.
        /// </summary>
        public void Click(bool moveMouse, int count)
        {
            if (_isVisible && moveMouse)
            {
                MoveMouse();
            }

            for (int i = 0; i < count; i++)
            {
                Click();
            }
        }

        private void MoveMouse()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public override bool IsVisible()
        {
            return true;
        }
    }
}