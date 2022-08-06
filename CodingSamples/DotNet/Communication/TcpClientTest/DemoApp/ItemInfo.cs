readonly record struct ItemInfo(double Price, int Stock)
{
    public static ItemInfo Parse(string info) //info="price=8000,stock=42"
    {
        string[] parts = info.Split(',');
        double price = double.Parse(parts[0].Substring(6));
        int stock = int.Parse(parts[1].Substring(6));
        return new ItemInfo(price, stock);
    }
}
