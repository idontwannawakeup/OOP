namespace _08_CreateCustomClassAttribute
{
    using Attributes;
    using Models.Weapons;
    using Models.Rarities;
    using Models.Gems;
    using Models.Clarities;
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            var weapons = new List<Weapon>();

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] tokens = input.Split(';');

                string command = tokens[0];
                switch (command)
                {
                    case "Create":
                        string[] weaponInfo = tokens[1].Split(' ');
                        weapons.Add(CreateWeapon(weaponInfo[0], weaponInfo[1], tokens[2]));
                        break;
                    case "Add":
                        string[] gemTypeInfo = tokens[3].Split(' ');
                        Gem gem = CreateGem(gemTypeInfo[0], gemTypeInfo[1]);
                        Weapon weaponToAddSocket = weapons.Find(item => item.Name == tokens[1]);
                        weaponToAddSocket?.AddGemInSocket(int.Parse(tokens[2]), gem);
                        break;
                    case "Remove":
                        Weapon weaponToRemoveFromSocket = weapons.Find(item => item.Name == tokens[1]);
                        weaponToRemoveFromSocket?.RemoveGemFromSocket(int.Parse(tokens[2]));
                        break;
                    case "Print":
                        Weapon weaponToPrint = weapons.Find(item => item.Name == tokens[1]);
                        weaponToPrint?.PrintInfo();
                        break;
                    default:
                        TryPrintInfo(command);
                        break;
                }
            }

            Console.ReadKey();
        }

        static void TryPrintInfo(string command)
        {
            try
            {
                string modelsNamespace = "_08_CreateCustomClassAttribute.Models";
                string weaponsNamespace = $"{modelsNamespace}.Weapons";
                Type weaponType = Type.GetType($"{weaponsNamespace}.Weapon");

                var attrs = weaponType.GetCustomAttributes(false);
                foreach (var attr in attrs)
                    if (attr is WeaponInfoAttribute)
                    {
                        var property = attr.GetType().GetProperty(command);
                        if (property == null)
                            throw new Exception();

                        Console.WriteLine($"{property.Name}: {property.GetValue(attr)}");
                    }
            }
            catch
            {
                Console.WriteLine("Invalid command!");
            }
        }

        static Weapon CreateWeapon(string weaponRarity, string weaponTypeName, string weaponName)
        {
            string modelsNamespace = "_08_CreateCustomClassAttribute.Models";
            string weaponsNamespace = $"{modelsNamespace}.Weapons";

            Type weaponType = Type.GetType($"{weaponsNamespace}.{weaponTypeName}");

            Rarity rarity = CreateRarity(weaponRarity);
            object[] weaponArgs = new object[] { weaponName, rarity };

            Weapon weapon = (Weapon)Activator.CreateInstance(weaponType, weaponArgs);
            return weapon;
        }

        static Rarity CreateRarity(string weaponRarity)
        {
            string modelsNamespace = "_08_CreateCustomClassAttribute.Models";
            string raritiesNamespace = $"{modelsNamespace}.Rarities";

            Type rarityType = Type.GetType($"{raritiesNamespace}.{weaponRarity}");
            Rarity rarity = (Rarity)Activator.CreateInstance(rarityType);

            return rarity;
        }

        static Gem CreateGem(string gemClarityTypeName, string gemTypeName)
        {
            string modelsNamespace = "_08_CreateCustomClassAttribute.Models";
            string gemsNamespace = $"{modelsNamespace}.Gems";

            Type gemType = Type.GetType($"{gemsNamespace}.{gemTypeName}");

            Clarity clarity = CreateClarity(gemClarityTypeName);
            object[] gemArgs = new object[] { clarity };

            Gem gem = (Gem)Activator.CreateInstance(gemType, gemArgs);
            return gem;
        }

        static Clarity CreateClarity(string clarityTypeName)
        {
            string modelsNamespace = "_08_CreateCustomClassAttribute.Models";
            string claritiesNamespace = $"{modelsNamespace}.Clarities";

            Type clarityType = Type.GetType($"{claritiesNamespace}.{clarityTypeName}");

            Clarity clarity = (Clarity)Activator.CreateInstance(clarityType);
            return clarity;
        }
    }
}
