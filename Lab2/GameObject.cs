namespace Lab2_OOP_basics
{
    public abstract class GameObject
    {
        private static int _currentId = 0;
        private int _id;
        protected (int, int) _coords;

        protected GameObject((int,int) coords)
        {
            _id = _currentId++;
            _coords = coords;
        }
        public abstract string getName();
        public int getId()
        {
            return _id;
        }
        public int getX()
        {
            return _coords.Item1;
        }
        public int getY()
        {
            return _coords.Item2;
        }
    }
}
