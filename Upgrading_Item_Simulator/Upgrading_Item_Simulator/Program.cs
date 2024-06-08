// See https://aka.ms/new-console-template for more information
using Upgrading_Item_Simulator;

Item cos = new Dagger();
Resource dsa = new Diamond();
cos.Upgrade(dsa);
Console.WriteLine(cos.GetDescription());
if(cos is Dagger dag)
{
    Console.WriteLine(dag.Damage);
    Console.WriteLine(dag.Durability);
}
else
{
    Console.WriteLine("cos is not an IItem");
}

ItemDecorator decoratedItem = new IceDecorator(cos);
if(decoratedItem is IceDecorator ice)
{
    Console.WriteLine(ice.Durability);
    Console.WriteLine(ice.GetDescription());
}
else
{
    Console.WriteLine("decoratedItem is not an IceDecorator");
}
Console.WriteLine(decoratedItem.GetStats());


List<Item> items = new List<Item>
{
    new Dagger(),
    new Sword(),
    new Bow(),
    new Axe()
};

List<Resource> resources = new List<Resource>
{
    new Wood(),
    new Iron(),
    new Gold(),
    new Diamond()
};

List<ItemDecorator> decoratedItems = new List<ItemDecorator>
{
    new FireDecorator(new Dagger()),
    new PoisonDecorator(new Sword()),
    new IceDecorator(new Bow()),
    new FireDecorator(new Axe())
};

Console.WriteLine("Not Decorated items");
foreach (Item item in items)
{
   
    foreach (Resource resource in resources)
    {
        item.Upgrade(resource);
        Console.WriteLine(item.GetDescription());
        Console.WriteLine(item.GetStats());
        Console.WriteLine();
    }

}

Console.WriteLine("Decorated Items");

foreach(ItemDecorator item in decoratedItems)
{
    foreach (Resource resource in resources)
    {
        item.Upgrade(resource);
        Console.WriteLine(item.GetDescription());
        Console.WriteLine(item.GetStats());
        Console.WriteLine();
    }
}

Customer cus = new Customer("zbigniew");
//cus.CreateOrder();
Order order = cus.CreateOrder();
order.GetValues();


RecipeFactory recipeFactory = new RecipeFactory();
Recipe recip = recipeFactory.CreateRecipe(order);


Console.WriteLine("Required materials for item:");
foreach (var smth in recip.requiredMaterialsItem)
{
    Console.WriteLine(smth.Key.GetName() + " " + smth.Value);
}
Console.WriteLine();

Console.WriteLine("Required materials for upgrade:");
foreach (var smth in recip.requiredMaterialsUpgrade)
{
    Console.WriteLine(smth.Key.GetName() + " " + smth.Value);
}
Console.WriteLine();

Console.WriteLine("Required materials for attribute:");
foreach (var smth in recip.requiredMaterialsAttrib)
{
    Console.WriteLine(smth.Key.GetName() + " " + smth.Value);
}
Console.WriteLine();

Console.WriteLine("Available resources in shop:");
Shop shop = new Shop();
shop.RestockResource();
Dictionary<Resource, int> ShopResource = shop.AvailableResources;
foreach (var smth in ShopResource)
{
    Console.WriteLine(smth.Key.GetName() + " " + smth.Value);
}
Console.WriteLine();

//for(int i =0;i<5; i++   )
//{
//    shop.RestockResource();
//    Console.WriteLine("Restocked resources:");
//    foreach (var smth in ShopResource)
//    {
//        Console.WriteLine(smth.Key.GetName() + " " + smth.Value);
//    }
//    Console.WriteLine();
//}

//Player player = new Player(100);
//foreach(var yeah in player.Resources)
//{
//    Console.WriteLine(yeah.Key.GetName() + " " + yeah.Value);
//}
//player.BuyResource(shop);
//foreach (var yeah in player.Resources)
//{
//    Console.WriteLine(yeah.Key.GetName() + " " + yeah.Value);
//}


Dictionary<Resource, int> SelledItems = new Dictionary<Resource, int>
            {
                { new Wood(),0 },
                { new Iron(),0 },
                { new Gold(),0 },
                { new Diamond(),0 }
            };

string resourceName = "Wood";
int quantity = 5;
foreach (Resource siab in SelledItems.Keys.ToList())
{
    Console.WriteLine(siab.GetName());
    if(siab.GetName() == resourceName)
    {
        Console.WriteLine("jestem w ifie");
        foreach (Resource sada in ShopResource.Keys)
        {
            if(sada.GetName() == resourceName)
            {
                ShopResource[sada] -= quantity;
            }
        }
        //ShopResource[siab] -= quantity;
        SelledItems[siab] += quantity;
    }
    else
    {
        Console.WriteLine("nie jestem w ifie");
    }
}
foreach(var dsakld in ShopResource)
{
    Console.WriteLine(dsakld.Key.GetName() + " " + dsakld.Value);
}
foreach (var smth in SelledItems)
{
    Console.WriteLine(smth.Key.GetName() + " " + smth.Value);
}



//foreach (Resource dsa in SelledItems.Keys)
//{
//    if (dsa.GetName() == resourceName)
//    {
//        if (AvailableResources[dsa] >= quantity)
//        {
//            AvailableResources[dsa] -= quantity;
//            SelledItems[dsa] += quantity;
//            return new Dictionary<Resource, int> { { dsa, quantity } };
//        }
//        else
//        {
//            Console.WriteLine("Not enough resources");
//            return null;
//        }
//    }
//}