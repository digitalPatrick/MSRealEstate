namespace RealEstateService.Migrations
{
    using RealEstateService.DataObjects;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RealEstateService.Models.MobileServiceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RealEstateService.Models.MobileServiceContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            //for (int i = 1; i < 30; i++)
            //{
            //    Guid s = Guid.NewGuid();

            //    context.People.AddOrUpdate(p => p.UserName,
            //    new Person
            //    {
            //        Id = s.ToString(),
            //        FirstName = "leon",
            //        LastName = "Patrick",
            //        UserName = "digitalpatrick" + i.ToString(),
            //        AvatarUrl = "images/leoceo.jpg",
            //        Featured = true,
            //        BusinessAddress = new Address
            //        {
            //            Id = s.ToString(),
            //            Street1 = "10620 N 26th St",
            //            City = "Tampa",
            //            State = "FL",
            //            ZipCode = "33612"
            //        },
            //        Contact = new Contact
            //        {
            //            Id = s.ToString(),
            //            EmailAddress = "dp" + i.ToString() + "@outlook.com",
            //            BusinessPhone = "8763310078",
            //            CellPhone = "8133007898",
            //            FaxPhone = "8133007898"
            //        },
            //        Social = new Social
            //        {
            //            Id = s.ToString(),
            //            FaceBook = "dp" + i.ToString() + "@facebook.com",
            //            Instagram = "@digitalpatrick" + i.ToString(),
            //            Twitter = "@digitalpatrick" + i.ToString(),
            //            Micrsoft = "digitalpatrick" + i.ToString() + "@outlook.com",
            //            GooglePlus = "digitalpatrick" + i.ToString() + "@gmail.com",
            //            Yahoo = "digitalpatrick" + i.ToString() + "@yahoo.com",
            //        },
            //    });

            //};

            //for (int i = 1; i < 40; i++)
            //{
            //    Guid s = Guid.NewGuid();
            //    Guid f = Guid.NewGuid();
            //    Guid j = Guid.NewGuid();
            //    Guid k = Guid.NewGuid();
            //    Guid l = Guid.NewGuid();
            //    Guid m = Guid.NewGuid();

            //    context.Apartments.AddOrUpdate(new Apartment[] {
            //        new Apartment {
            //            Id = j.ToString(),
            //            NumOfRooms = i,
            //            Price = 300.60,
            //            Description = "House on the Suburbs, Looking over the Golden Acres. This house is just 5 miles from the nearest Mall",
            //            PersonId = "115d110e-6640-4a26-97df-bf1b50c41473",
            //            ApartmentAddress = new Address
            //                {
            //                    Id = j.ToString(),
            //                    Street1 = "10620 N 26th St",
            //                    City = "Tampa",
            //                    State = "FL",
            //                    ZipCode = "33612",
            //                    Longitude = -82.43074,
            //                    Latitude = 28.046325
            //                },
            //            Images = new Image[] 
            //                {
            //                    new Image { Id = Guid.NewGuid().ToString(), ApartmentId = j.ToString(), ImageUrl = "images/house1.jpg", ShortDescription = "Side of House", IsLeadImage = true },
            //                    new Image { Id = Guid.NewGuid().ToString(), ApartmentId = j.ToString(), ImageUrl = "images/house1.jpg", ShortDescription = "Front of House" },
            //                    new Image { Id = Guid.NewGuid().ToString(), ApartmentId = j.ToString(), ImageUrl = "images/house1.jpg", ShortDescription = "Back of House" },
            //                    new Image { Id = Guid.NewGuid().ToString(), ApartmentId = j.ToString(), ImageUrl = "images/house1.jpg", ShortDescription = "Attic of House" }
            //                }
            //            },
            //            new Apartment {
            //            Id = k.ToString(),
            //            NumOfRooms = i,
            //            Price = 300.60,
            //            Description = "Middle Class Home, Looking over the Golden Acres. This house is just 5 miles from the nearest Mall",
            //            PersonId = "19441d8f-f711-4fb6-807e-98097e9172f7",
            //            ApartmentAddress = new Address
            //                {
            //                    Id = k.ToString(),
            //                    Street1 = "10620 N 26th St",
            //                    City = "Tampa",
            //                    State = "FL",
            //                    ZipCode = "33612",
            //                    Longitude = -82.43074,
            //                    Latitude = 28.046325
            //                },
            //                 Images = new Image[]
            //                {
            //                    new Image { Id = Guid.NewGuid().ToString(), ApartmentId = k.ToString(), ImageUrl = "images/house1.jpg", ShortDescription = "Side of House" },
            //                    new Image { Id = Guid.NewGuid().ToString(), ApartmentId = k.ToString(), ImageUrl = "images/house1.jpg", ShortDescription = "Front of House", IsLeadImage = true},
            //                    new Image { Id = Guid.NewGuid().ToString(), ApartmentId = k.ToString(), ImageUrl = "images/house1.jpg", ShortDescription = "Back of House" },
            //                    new Image { Id = Guid.NewGuid().ToString(), ApartmentId = k.ToString(), ImageUrl = "images/house1.jpg", ShortDescription = "Attic of House" }
            //                }
            //            },
            //            new Apartment {
            //            Id = l.ToString(),
            //            NumOfRooms = i,
            //            Price = 300.60,
            //            Description = "Apartment Building, Looking over the Golden Acres. This house is just 5 miles from the nearest Mall",
            //            PersonId = "299a9f5e-a364-44d5-93a8-f2ac31e4cba4",
            //            ApartmentAddress = new Address
            //                {
            //                    Id = l.ToString(),
            //                    Street1 = "10620 N 26th St",
            //                    City = "Tampa",
            //                    State = "FL",
            //                    ZipCode = "33612",
            //                    Longitude = -82.43074,
            //                    Latitude = 28.046325
            //                },
            //                 Images = new Image[]
            //                {
            //                    new Image { Id = Guid.NewGuid().ToString(), ApartmentId = l.ToString(), ImageUrl = "images/house1.jpg", ShortDescription = "Front of House"},
            //                    new Image { Id = Guid.NewGuid().ToString(), ApartmentId = l.ToString(), ImageUrl = "images/house1.jpg", ShortDescription = "Back of House" },
            //                    new Image { Id = Guid.NewGuid().ToString(), ApartmentId = l.ToString(), ImageUrl = "images/house1.jpg", ShortDescription = "Attic of House" , IsLeadImage = true},
            //                    new Image { Id = Guid.NewGuid().ToString(), ApartmentId = l.ToString(), ImageUrl = "images/house1.jpg", ShortDescription = "Side of House" }
            //                }
            //            },
            //            new Apartment {
            //            Id = m.ToString(),
            //            NumOfRooms = i,
            //            Price = 300.60,
            //            Description = "Town House, Looking over the Golden Acres. This house is just 5 miles from the nearest Mall",
            //            PersonId = "320f62ed-43ac-4680-9847-f1b05ac38364",
            //            ApartmentAddress = new Address
            //                {
            //                    Id = m.ToString(),
            //                    Street1 = "10620 N 26th St",
            //                    City = "Tampa",
            //                    State = "FL",
            //                    ZipCode = "33612",
            //                    Longitude = -82.43074,
            //                    Latitude = 28.046325
            //                },
            //                 Images = new Image[]
            //                {
            //                    new Image { Id = Guid.NewGuid().ToString(), ApartmentId = m.ToString(), ImageUrl = "images/house1.jpg", ShortDescription = "Front of House"},
            //                    new Image { Id = Guid.NewGuid().ToString(), ApartmentId = m.ToString(), ImageUrl = "images/house1.jpg", ShortDescription = "Back of House" },
            //                    new Image { Id = Guid.NewGuid().ToString(), ApartmentId = m.ToString(), ImageUrl = "images/house1.jpg", ShortDescription = "Attic of House" },
            //                    new Image { Id = Guid.NewGuid().ToString(), ApartmentId = m.ToString(), ImageUrl = "images/house1.jpg", ShortDescription = "Side of House", IsLeadImage = true }
            //                }
            //            },
            //            new Apartment {
            //            Id = s.ToString(),
            //            NumOfRooms = i,
            //            Price = 300.60,
            //            Description = "Duplex, Looking over the Golden Acres. This house is just 5 miles from the nearest Mall",
            //            PersonId = "522a6d87-c166-444a-b5e9-6a1b890fa23f",
            //            ApartmentAddress = new Address
            //                {
            //                    Id = s.ToString(),
            //                    Street1 = "10620 N 26th St",
            //                    City = "Tampa",
            //                    State = "FL",
            //                    ZipCode = "33612",
            //                    Longitude = -82.43074,
            //                    Latitude = 28.046325
            //                },
            //                 Images = new Image[]
            //                {
            //                    new Image { Id = Guid.NewGuid().ToString(), ApartmentId = s.ToString(), ImageUrl = "images/house1.jpg", ShortDescription = "Front of House"},
            //                    new Image { Id = Guid.NewGuid().ToString(), ApartmentId = s.ToString(), ImageUrl = "images/house1.jpg", ShortDescription = "Back of House" },
            //                    new Image { Id = Guid.NewGuid().ToString(), ApartmentId = s.ToString(), ImageUrl = "images/house1.jpg", ShortDescription = "Attic of House" },
            //                    new Image { Id = Guid.NewGuid().ToString(), ApartmentId = s.ToString(), ImageUrl = "images/house1.jpg", ShortDescription = "Side of House", IsLeadImage = true }
            //                }
            //            },
            //        });
            //}
            
        }
    }
}
