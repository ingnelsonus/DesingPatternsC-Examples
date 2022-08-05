using memento.Example1_Persona;

namespace Example1_Persona
{
    public class CareTaker
    {
        private List<Memento> _mementoList = new List<Memento>();

        public void Add(Memento m)
        {
            _mementoList.Add(m);
        }

        public Memento GetMemento(int Index)
        {
            return _mementoList[Index];
        }

    }
}
