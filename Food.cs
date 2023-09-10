namespace Demos2
{
    public record Food(string name, int temp, bool isGood)
    {
        public bool isFoodHot => temp > 10;
    }
}
