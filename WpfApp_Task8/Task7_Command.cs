using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp_Task8
{
    class Task7_Command
    {
        public static RoutedUICommand Exit { get; set; }
        static Task7_Command()
        {
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.T, ModifierKeys.Control, "Ctrl+T"));
            Exit = new RoutedUICommand("Выход", "Exit", typeof(Task7_Command), inputs);

        }
    }
}
