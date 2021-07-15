using Salino.Models;
//using SalinoMvc5.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Salino.DataLayer
{
    public class SalinoContext:DbContext
    {
    
        static SalinoContext()
        {
            //Database.SetInitializer(new CreateDatabaseIfNotExists<SalinoContext>());
       // Database.SetInitializer(new MigrateDatabaseToLatestVersion<SalinoContext, SalinoMvc5.Migrations.Configuration>());
        }
        //_________________________________________________________________________________
        #region Users
        public DbSet<User> users { get; set; }
        public DbSet<Role> roles { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<Entegadat> Entegadats { get; set; }
        public DbSet<Mojavez> Mojavezs { get; set; }
        #endregion

        #region Products
        public DbSet<Product> Products { get; set; }
        public DbSet<ColorsProduct> ColorsProducts { get; set; }
        public DbSet<GroupProduct> groupProducts { get; set; }
        public DbSet<FarbicTypeProducts> FarbicTypeProducts { get; set; }
        public DbSet<FarbicType> FarbicTypes { get; set; }
        public DbSet<MonasebatProducts> MonasebatProducts { get; set; }
        public DbSet<Monasebat> Monasebats { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        #endregion

        #region Factors
        public DbSet<TypeSendPost> TypeSendPosts { get; set; }
        public DbSet<FactorMain> FactorMains { get; set; }
        public DbSet<FactorDetail> FactorDetails { get; set; }

        #endregion

        #region Others
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Ostan> Ostans { get; set; }
        #endregion
      
        #region Images
        public DbSet<ImageMain> ImageMains { get; set; }
        public DbSet<ImageOffer> ImageOffers { get; set; }
        public DbSet<ImageAdver> imgadvr { get; set; }
        #endregion
       
        #region Offers
        public DbSet<SendPrice> SendPrices { get; set; }
        public DbSet<giftcard> giftcards { get; set; }
        public DbSet<gifcardDate> gifcardDates { get; set; }
        public DbSet<OfferPrice> OfferPrices { get; set; }
        public DbSet<MajorShop> MajorShops { get; set; }
        public DbSet<SendForMajor> SendForMajors { get; set; }
        public DbSet<OfferFirstShop> OfferFirstShops { get; set; }
        public DbSet<OfferNumberShop> OfferNumberShops { get; set; }

        #endregion

    

    }
}