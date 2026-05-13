using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfDay3Exercise06;

public static class EnterKeyBehavior
{
    public static readonly DependencyProperty MoveFocusOnEnterProperty =
        DependencyProperty.RegisterAttached(
            "MoveFocusOnEnter",
            typeof(bool),
            typeof(EnterKeyBehavior),
            new PropertyMetadata(false, OnMoveFocusOnEnterChanged));

    public static bool GetMoveFocusOnEnter(DependencyObject obj)
    {
        return (bool)obj.GetValue(MoveFocusOnEnterProperty);
    }

    public static void SetMoveFocusOnEnter(DependencyObject obj, bool value)
    {
        obj.SetValue(MoveFocusOnEnterProperty, value);
    }

    private static void OnMoveFocusOnEnterChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is not TextBox textBox) return;

        if ((bool)e.NewValue)
        {
            textBox.KeyDown += TextBox_KeyDown;
        }
        else
        {
            textBox.KeyDown -= TextBox_KeyDown;
        }
    }

    private static void TextBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.Key != Key.Enter) return;
        var request = new TraversalRequest(FocusNavigationDirection.Next);
        ((UIElement)sender).MoveFocus(request);
        e.Handled = true;
    }
}
