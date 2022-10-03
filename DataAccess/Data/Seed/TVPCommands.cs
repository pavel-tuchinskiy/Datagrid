namespace DataAccess.Data.Seed
{
    public static class TVPCommands
    {
        public const string USERS_COMMAND = "ImportUsers";
        public const string PRODUCTS_COMMAND = "ImportProducts";
        public const string ORDERS_COMMAND = "ImportOrders";
        public const string ORDERPRODUCTS_COMMAND = "ImportOrderProducts";
    }

    public static class TVPTypes
    {
        public const string USERS_TYPE = "dbo.UserType";
        public const string PRODUCTS_TYPE = "dbo.ProductType";
        public const string ORDERS_TYPE = "dbo.OrderType";
        public const string ORDERPRODUCTS_TYPE = "dbo.OrderProductsType";
    }
}
