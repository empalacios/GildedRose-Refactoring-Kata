namespace csharp.Decrease
{
    public class SulfurasProductDecrease : ProductDecrease
    {
        public const int SULFURAS_QUALITY = 80;
        public SulfurasProductDecrease(Item item):base(item)
        {
        }

        public override int ComputeDecrease()
        {
            return 0;
        }

        public override void UpdateQuality()
        {
            Item.Quality = SULFURAS_QUALITY;
        }

        public override void UpdateSellIn()
        {
        }
    }
}
