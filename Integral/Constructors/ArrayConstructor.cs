namespace Integral.Constructors
{
    public static class ArrayConstructor
    {
        public static Element[][] Create<Element>(int x, int y)
        {
            Element[][] array = new Element[x][];
            for (int i = 0; i < x; i++)
            {
                array[i] = new Element[y];
            }

            return array;
        }
    }
}