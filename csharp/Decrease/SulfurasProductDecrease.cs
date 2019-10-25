namespace csharp.Decrease
{
    public class SulfurasProductDecrease : ProductDecrease
    {
        public SulfurasProductDecrease(Item item):base(item)
        {
        }

        public override int ComputeDecrease()
        {
            return 0;
        }

        public override void UpdateSellIn()
        {
        }
    }
}
