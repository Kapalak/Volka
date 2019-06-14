using System;

namespace VolkaApp.Utils
{
    public class DeferedAction
    {
        public DeferedAction(Action action = null)
        {
            Action = action;
        }

        public Action Action { get; set; }

        public void Invoke()
        {
            Action?.Invoke();
            Action = null;
        }
    }

    public class DeferedAction<T>
    {
        public DeferedAction(Action<T> action = null)
        {
            Action = action;
        }

        public Action<T> Action { get; set; }

        public void Invoke(T param)
        {
            Action?.Invoke(param);
            Action = null;
        }
    }
}
