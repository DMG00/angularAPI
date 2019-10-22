namespace NinjaDomain.DataModel.Migrations
{
    using global::NinjaDomain.Classes;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NinjaDomain.DataModel.NinjaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NinjaDomain.DataModel.NinjaContext context)
        {
            context.Clans.AddOrUpdate(new Clan[]
            {// Clan List
                // Clan 1
                new Clan
                {// Clan member
                    Id=1,
                    ClanName = "Pauls Clan",
                    Ninjas = new List<Ninja>
                    {// Ninja List
                        new Ninja{ // Ninja 1
                            Id=1,
                            Name="Ninja Paul",
                            DateOfBirth=DateTime.Parse("12/02/2006"),
                            EquipmentOwned = new List<NinjaEquipment>
                                { // EquipmentOwned List
                                new NinjaEquipment
                                    {// EquipmentOwned 1
                                    Id =1, Name = "Sweet thing",
                                    Type= EquipmentType.Weapon,
                                    },
                                new NinjaEquipment
                                    {// EquipmentOwned 2
                                    Id =2, Name = "Comona XL",
                                    Type= EquipmentType.Outwear,
                                    },
                                } // End EquipmentOwned List
                        },// End Ninja 
                        new Ninja{ // Ninja 2
                            Id=2,
                            Name="Ninja Fred",
                            DateOfBirth=DateTime.Parse("02/02/2000"),
                            EquipmentOwned = new List<NinjaEquipment>
                                { // EquipmentOwned List
                                new NinjaEquipment
                                    {// EquipmentOwned 1
                                    Id =3, Name = "Comona XS",
                                    Type= EquipmentType.Outwear,
                                    },
                                } // End EquipmentOwned List
                        },// End Ninja 
                    },// End Ninja List
                }, // End Clan 
                // Clan 2
                 new Clan
                {// Clan member
                     Id=2,
                     ClanName="Ninja Girls Clan",
                    Ninjas = new List<Ninja>
                    {// Ninja List
                        new Ninja{ // Ninja 3
                            Id=3,
                            Name="Ninja Martha",
                            DateOfBirth=DateTime.Parse("12/02/1900"),
                            EquipmentOwned = new List<NinjaEquipment>
                                { // EquipmentOwned List
                                new NinjaEquipment
                                    {// EquipmentOwned 1
                                    Id =4, Name = "Sour Grapes",
                                    Type= EquipmentType.Weapon,
                                    },
                                } // End EquipmentOwned List
                        },// End Ninja 
                        new Ninja{ // Ninja 4
                            Id=4,
                            Name="Ninja Mary",
                            DateOfBirth=DateTime.Parse("10/02/1990"),
                            EquipmentOwned = new List<NinjaEquipment>
                                { // EquipmentOwned List
                                new NinjaEquipment
                                    {// EquipmentOwned 1
                                    Id =5, Name = "Fishing Net",
                                    Type= EquipmentType.Tool,
                                    },
                                } // End EquipmentOwned List
                        },// End Ninja 
                    },// End Ninja List
                }, // End Clan 
                
            }// End Clan List
            ); ;
        }
    }
}
