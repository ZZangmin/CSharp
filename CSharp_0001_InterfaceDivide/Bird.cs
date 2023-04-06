namespace InterfaceDivide_CSharp
{
    public abstract class Bird
    {
        int _Food;
        public int Food { get => _Food; }
        public Bird()
        {
            _Food = 30;
        }
        public void Restore(int food)
        {        
            _Food += food;
        }
        public void Consume(int food)
        {
            _Food -= food;
        }
    }
}
