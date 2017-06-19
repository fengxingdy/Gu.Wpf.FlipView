namespace Gu.Wpf.FlipView.Gestures
{
    using System;
    using System.Windows;

    public class EventPattern
    {
        public EventPattern(Action<UIElement> add, Action<UIElement> remove)
        {
            this.Add = add;
            this.Remove = remove;
        }

        public Action<UIElement> Add { get; }

        public Action<UIElement> Remove { get; }
    }
}