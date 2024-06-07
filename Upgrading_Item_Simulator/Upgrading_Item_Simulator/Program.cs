// See https://aka.ms/new-console-template for more information
using Upgrading_Item_Simulator;

Item cos = new Dagger();
Resource res = new Diamond();
cos.Upgrade(res);
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
