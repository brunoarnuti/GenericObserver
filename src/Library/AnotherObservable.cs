namespace Observer
{
    //Clase meramente de ejemplo
    public class AnotherObservable : IObservable<AnotherType>
    {
        public void Subscribe(IObserver<AnotherType> observer)
        {
            //logic
        }

        public void Unsubscribe(IObserver<AnotherType> observer)
        {
            //logic
        }

        public void Notify()
        {
            //logic
        }

    }
}