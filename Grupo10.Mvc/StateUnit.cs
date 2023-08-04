namespace Grupo10.Mvc
{
    public sealed class StateUnit<T>
    {
        private readonly List<ValueChangedHandler<T>> _valueChangedHigh = new List<ValueChangedHandler<T>>();
        private readonly List<ValueChangedHandler<T>> _valueChangedMedium = new List<ValueChangedHandler<T>>();
        private readonly List<ValueChangedHandler<T>> _valueChangedLow = new List<ValueChangedHandler<T>>();

        private T _value;
        public T Value {
            get => _value;
            set
            {
                _valueChangedHigh.ForEach(handler => handler(value, _value));
                _valueChangedMedium.ForEach(handler => handler(value, _value));
                _valueChangedLow.ForEach(handler => handler(value, _value));

                _value = value;
            } 
        }

        public StateUnit(T initialValue) {
            _value = initialValue;
        }

        public void OnChange(ValueChangedHandler<T> handler, ValueChangedHandlerPriority priority = ValueChangedHandlerPriority.Medium)
        {
            switch (priority)
            {
                case ValueChangedHandlerPriority.Medium:
                    _valueChangedMedium.Add(handler);
                    break;
                case ValueChangedHandlerPriority.High:
                    _valueChangedHigh.Add(handler);
                    break;
                case ValueChangedHandlerPriority.Low:
                    _valueChangedLow.Add(handler);
                    break;
                default:
                    break;
            }
        }

    }
}