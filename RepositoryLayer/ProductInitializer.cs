using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Domain;




namespace Repository
{
    public class ProductInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            var products = new List<Product>
            {
            new Product{Menufacture="Siemens AG",Category="Electrical",Series = "AeroBreeze",SubCategory = "Fan",Model = "Fan1",Price = 100.0m,Description = "{\"power\": \"50W\", \"voltage\": \"220V\", \"fan speed\": \"1200 rpm\", \"height\": \"40 cm\", \"weight\": \"3 kg\"}",DateMenufactured=DateTime.Parse("2005-09-01")},
            new Product{Menufacture="General Electric",Category="Electrical",Series = "WindWhisper",SubCategory = "Fan",Model = "Fan2",Price = 150.0m,Description = "{\"power\": \"75W\", \"voltage\": \"110V\", \"fan speed\": \"1500 rpm\", \"height\": \"50 cm\", \"weight\": \"4.5 kg\"}",DateMenufactured=DateTime.Parse("2005-09-01")},
            new Product{Menufacture="Schneider Electric",Category="Electrical",Series = "CycloneX",SubCategory = "Fan",Model = "Fan3",Price = 135.0m,Description = "{\"power\": \"100W\", \"voltage\": \"240V\", \"fan speed\": \"1800 rpm\", \"height\": \"45 cm\", \"weight\": \"5 kg\"}",DateMenufactured=DateTime.Parse("2005-09-01")},
            new Product{Menufacture="ABB Ltd",Category="Electrical",Series = "temp",SubCategory="Fan",Model = "ZephyrLine",Price = 90.0m,Description = "{\"power\": \"60W\", \"voltage\": \"220V\", \"fan speed\": \"1400 rpm\", \"height\": \"42 cm\", \"weight\": \"3.5 kg\"}",DateMenufactured=DateTime.Parse("2005-09-01")},
            new Product{
    Menufacture="Siemens AG",
    Category="Electrical",
    Series = "LumiPlus",
    SubCategory = "Light Bulb",
    Model = "LP-1000",
    Price = 50.0m,
    Description = "{\"type\": \"LED Bulb\", \"wattage\": \"10W\", \"lumens\": \"800 lm\", \"color temperature\": \"3000K Warm White\", \"life span\": \"25000 hours\"}",
    DateMenufactured=DateTime.Parse("2019-04-12")
},

            new Product{
    Menufacture="General Electric (GE)",
    Category="Electrical",
    Series = "QuickCook",
    SubCategory = "Oven",
    Model = "QC-500",
    Price = 300.0m,
    Description = "{\"type\": \"Microwave Oven\", \"capacity\": \"1.5 cu ft\", \"power\": \"1000W\", \"features\": \"Convection, Grill\", \"color\": \"Stainless Steel\"}",
    DateMenufactured=DateTime.Parse("2020-08-25")
},
            new Product{
    Menufacture="PetSafe Solutions",
    Category="Pet",
    Series = "FeatherHome",
    SubCategory = "Bird Cage",
    Model = "FH-300",
    Price = 250.0m,
    Description = "{\"type\": \"Standard Bird Cage\", \"material\": \"Stainless Steel\", \"dimensions\": \"24x24x34 inches\", \"features\": \"Removable Tray, Water Dispenser, 2 Perches\", \"suitableFor\": \"Parakeets, Canaries, and other small birds\"}",
    DateMenufactured=DateTime.Parse("2022-05-15")
},
            new Product{
    Menufacture="AvianComfor",
    Category="Pet",
    Series = "SkyNest",
    SubCategory = "Bird Cage",
    Model = "SK-500",
    Price = 450.0m,
    Description = "{\"type\": \"Deluxe Bird Cage\", \"material\": \"Aluminum Alloy\", \"dimensions\": \"36x36x48 inches\", \"features\": \"4 Feeding Doors, UV Protected, Weatherproof, 3 Perches, Toy Hook\", \"suitableFor\": \"Cockatiels, Parrots\"}",
    DateMenufactured=DateTime.Parse("2023-01-20")
},
            new Product{
    Menufacture="PurrFoods Inc.",
    Category="Pet",
    Series="GourmetMeals",
    SubCategory="Cat Food",
    Model="GC-100",
    Price=35.0m,
    Description="{\"type\": \"Dry Cat Food\", \"flavor\": \"Salmon & Chicken\", \"weight\": \"5kg\", \"ingredients\": [\"Real Salmon\", \"Farm-Raised Chicken\", \"Brown Rice\", \"Sweet Potatoes\"], \"benefits\": [\"High Protein\", \"Omega 3 & 6\", \"No Artificial Preservatives\"]}",
    DateMenufactured=DateTime.Parse("2024-01-10")
},
            new Product{
    Menufacture="CanineDelights",
    Category="Pet",
    Series="HealthyPaws",
    SubCategory="Dog Food",
    Model="HP-200",
    Price=40.0m,
    Description="{\"type\": \"Wet Dog Food\", \"flavor\": \"Beef & Vegetables\", \"weight\": \"10kg\", \"ingredients\": [\"Grass-Fed Beef\", \"Carrots\", \"Peas\", \"Sweet Potatoes\"], \"benefits\": [\"Grain-Free\", \"Rich in Vitamins\", \"No Added Sugars\"]}",
    DateMenufactured=DateTime.Parse("2024-02-15")
},
            new Product{
    Menufacture="CulinaryArt",
    Category="Kitchen",
    Series="Chef's Choice",
    SubCategory="Pot",
    Model="CC-300",
    Price=80.0m,
    Description="{\"type\": \"Stainless Steel Pot\", \"capacity\": \"5 Liters\", \"features\": [\"Dishwasher Safe\", \"Oven Safe up to 500°F\", \"Induction Compatible\"], \"idealFor\": [\"Soups\", \"Stews\", \"Boiling Pasta\"]}",
    DateMenufactured=DateTime.Parse("2024-03-01")
},
            new Product{
    Menufacture="EcoKitchen",
    Category="Kitchen",
    Series="GreenCook",
    SubCategory="Pot",
    Model="GC-420",
    Price=95.0m,
    Description="{\"type\": \"Cast Iron Dutch Oven\", \"capacity\": \"4 Liters\", \"features\": [\"Pre-Seasoned\", \"Eco-Friendly Coating\", \"Dual-Function Lid\"], \"idealFor\": [\"Baking\", \"Braising\", \"Roasting\"]}",
    DateMenufactured=DateTime.Parse("2024-03-15")
},
            new Product{
    Menufacture="FrostTech",
    Category="Kitchen",
    Series="IceKing",
    SubCategory="Freezer",
    Model="IK-220",
    Price=600.0m,
    Description="{\"type\": \"Upright Freezer\", \"capacity\": \"200 Liters\", \"features\": [\"Frost-Free Technology\", \"Energy Efficient\", \"Digital Temperature Control\", \"Fast Freeze\"], \"idealFor\": [\"Households\", \"Small Businesses\"]}",
    DateMenufactured=DateTime.Parse("2024-03-25")
},
            new Product{
    Menufacture="ChillMaster",
    Category="Kitchen",
    Series="PolarVault",
    SubCategory="Freezer",
    Model="PV-550",
    Price=750.0m,
    Description="{\"type\": \"Chest Freezer\", \"capacity\": \"500 Liters\", \"features\": [\"Adjustable Temperature\", \"Energy Saving Mode\", \"Lockable Lid\", \"Interior Light\"], \"idealFor\": [\"Large Families\", \"Commercial Use\"]}",
    DateMenufactured=DateTime.Parse("2024-04-10")
},
            new Product{
    Menufacture="WoodCrafters",
    Category="Furniture",
    Series="Elegance",
    SubCategory="Table",
    Model="EC-101",
    Price=450.0m,
    Description="{\"type\": \"Coffee Table\", \"material\": \"Solid Oak\", \"dimensions\": \"48x24x18 inches\", \"features\": [\"Handcrafted\", \"Water-resistant Finish\", \"Lower Shelf for Storage\"], \"idealFor\": [\"Living Rooms\", \"Lounges\"]}",
    DateMenufactured=DateTime.Parse("2024-03-20")
},
            new Product{
    Menufacture="ModernLiving",
    Category="Furniture",
    Series="Urban",
    SubCategory="Table",
    Model="UR-209",
    Price=550.0m,
    Description="{\"type\": \"Dining Table\", \"material\": \"Tempered Glass & Steel\", \"dimensions\": \"60x36x30 inches\", \"features\": [\"Contemporary Design\", \"Seats up to 6\", \"Scratch-resistant Surface\"], \"idealFor\": [\"Dining Rooms\", \"Open Plan Spaces\"]}",
    DateMenufactured=DateTime.Parse("2024-04-05")
},
            new Product{
    Menufacture="SeatingMasters",
    Category="Furniture",
    Series="ComfortLine",
    SubCategory="Chair",
    Model="CL-320",
    Price=120.0m,
    Description="{\"type\": \"Ergonomic Office Chair\", \"material\": \"Mesh & Aluminum\", \"dimensions\": \"22x24x40 inches\", \"features\": [\"Adjustable Height\", \"Lumbar Support\", \"360-degree Swivel\", \"Breathable Fabric\"], \"idealFor\": [\"Home Offices\", \"Corporate Offices\"]}",
    DateMenufactured=DateTime.Parse("2024-03-10")
},
            new Product{
    Menufacture="VintageVibes",
    Category="Furniture",
    Series="Heritage",
    SubCategory="Chair",
    Model="HV-415",
    Price=200.0m,
    Description="{\"type\": \"Accent Chair\", \"material\": \"Velvet & Solid Wood\", \"dimensions\": \"25x22x30 inches\", \"features\": [\"Tufted Backrest\", \"Victorian Legs\", \"Rich Color Options\"], \"idealFor\": [\"Living Rooms\", \"Reading Nooks\"]}",
    DateMenufactured=DateTime.Parse("2024-04-01")
}

            };

            products.ForEach(p => context.Products.Add(p));
            context.SaveChanges();
            var users = new List<User>
            {
            new User{UserName="username1",Email = "username1@123.com",Password="passwordTest1"},
            new User{UserName="username2",Email = "username2@123.com",Password="passwordTest2"},
            new User{UserName="username3",Email = "username3@123.com",Password="passwordTest3"},

            };
            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();

        }
    }
}