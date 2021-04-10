using System;
namespace small_shop.Data
{
    public class Cart : Product
    {
        private String Good;
        private int Amount;
        private int Sprice;
        private int Fprice;

        public Cart() { }

        public Cart(String good, int amount, int fprice)
        {
            this.Good = good;
            this.Amount = amount;
            this.Fprice = fprice;
        }
        public String Get_Good_Name()
        {
            return Good;
        }

        public int Get_Good_Amount()
        {
            return Amount;
        }

        public int Get_Good_Fprice()
        {
            return 0;
        }
    }
}
