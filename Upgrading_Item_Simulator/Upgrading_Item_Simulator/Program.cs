// See https://aka.ms/new-console-template for more information
using Upgrading_Item_Simulator;

//Item cos = new Dagger();
//Resource dsa = new Diamond();
//cos.Upgrade(dsa);
//Console.WriteLine(cos.GetDescription());
//if(cos is Dagger dag)
//{
//    Console.WriteLine(dag.Damage);
//    Console.WriteLine(dag.Durability);
//}
//else
//{
//    Console.WriteLine("cos is not an IItem");
//}

//ItemDecorator decoratedItem = new IceDecorator(cos);
//if(decoratedItem is IceDecorator ice)
//{
//    Console.WriteLine(ice.Durability);
//    Console.WriteLine(ice.GetDescription());
//}
//else
//{
//    Console.WriteLine("decoratedItem is not an IceDecorator");
//}
//Console.WriteLine(decoratedItem.GetStats());


//List<Item> items = new List<Item>
//{
//    new Dagger(),
//    new Sword(),
//    new Bow(),
//    new Axe()
//};

//List<Resource> resources = new List<Resource>
//{
//    new Wood(),
//    new Iron(),
//    new Gold(),
//    new Diamond()
//};

//List<ItemDecorator> decoratedItems = new List<ItemDecorator>
//{
//    new FireDecorator(new Dagger()),
//    new PoisonDecorator(new Sword()),
//    new IceDecorator(new Bow()),
//    new FireDecorator(new Axe())
//};

//Console.WriteLine("Not Decorated items");
//foreach (Item item in items)
//{
   
//    foreach (Resource resource in resources)
//    {
//        item.Upgrade(resource);
//        Console.WriteLine(item.GetDescription());
//        Console.WriteLine(item.GetStats());
//        Console.WriteLine();
//    }

//}

//Console.WriteLine("Decorated Items");

//foreach(ItemDecorator item in decoratedItems)
//{
//    foreach (Resource resource in resources)
//    {
//        item.Upgrade(resource);
//        Console.WriteLine(item.GetDescription());
//        Console.WriteLine(item.GetStats());
//        Console.WriteLine();
//    }
//}

//Customer cus = new Customer("zbigniew");
//Order order = cus.CreateOrder();
//order.GetValues();


//RecipeFactory recipeFactory = new RecipeFactory();
//Recipe recip = recipeFactory.CreateRecipe(order);


//Console.WriteLine("Required materials for item:");
//foreach (var smth in recip.requiredMaterialsItem)
//{
//    Console.WriteLine(smth.Key.GetName() + " " + smth.Value);
//}
//Console.WriteLine();

//Console.WriteLine("Required materials for upgrade:");
//foreach (var smth in recip.requiredMaterialsUpgrade)
//{
//    Console.WriteLine(smth.Key.GetName() + " " + smth.Value);
//}
//Console.WriteLine();

//Console.WriteLine("Required materials for attribute:");
//foreach (var smth in recip.requiredMaterialsAttrib)
//{
//    Console.WriteLine(smth.Key.GetName() + " " + smth.Value);
//}
//Console.WriteLine();

//Console.WriteLine("Available resources in shop:");
//Shop shop = new Shop();
//shop.RestockResource();
//Dictionary<Resource, int> ShopResource = shop.AvailableResources;
//foreach (var smth in ShopResource)
//{
//    Console.WriteLine(smth.Key.GetName() + " " + smth.Value);
//}
//Console.WriteLine();

//Player player = new Player(100);
//Console.WriteLine("Your money: " + player.Money);
//foreach (var yeah in player.Resources)
//{
//    Console.WriteLine(yeah.Key.GetName() + " " + yeah.Value);
//}

//RecipeFactory recipeTest = new RecipeFactory();
//Recipe reciperecipe = recipeTest.CreateRecipe(ItemType.Dagger, UpgradeType.Wood, AttributeType.None);
//foreach (var smth in reciperecipe.requiredMaterialsItem)
//{
//    Console.WriteLine(smth.Key.GetName() + " " + smth.Value);
//}
//foreach (var smth in reciperecipe.requiredMaterialsUpgrade)
//{
//    Console.WriteLine(smth.Key.GetName() + " " + smth.Value);
//}
//foreach (var smth in reciperecipe.requiredMaterialsAttrib)
//{
//    Console.WriteLine(smth.Key.GetName() + " " + smth.Value);
//}
//player.BuyResource(shop);
//foreach (var yeah in player.Resources)
//{
//    Console.WriteLine(yeah.Key.GetName() + " " + yeah.Value);
//}

//    Item itemCrafted = player.CraftItem(ItemType.Dagger, UpgradeType.Wood, AttributeType.None);
//if (itemCrafted == null)
//{
//    Console.WriteLine("Item not crafted");
//}
//else
//{
//    Console.WriteLine(itemCrafted.GetDescription());
//    }
////Console.WriteLine(itemCrafted.GetDescription());
//foreach (var yeah in player.Resources)
//{
//    Console.WriteLine(yeah.Key.GetName() + " " + yeah.Value);
//}

GameEngine game = new GameEngine(new Shop(), new Player(500));
game.RunGame();