namespace SalinoMvc5.Migrations
{
    using Salino.DataLayer;
    using Salino.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web.Security;

    internal sealed class Configuration : DbMigrationsConfiguration<Salino.DataLayer.SalinoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "SalinoMvc5.Models.Context.SalinoContext";
            AutomaticMigrationDataLossAllowed = true;

        }

        protected override void Seed(Salino.DataLayer.SalinoContext context)
        {
            string Hash = FormsAuthentication.HashPasswordForStoringInConfigFile("09146143251", "MD5");
            SalinoContext db = new SalinoContext();

            //_______________________________________________________
            //مرحله اول
            if (db.roles.Count() == 0)
            {
                #region Roles

                Role role = new Role()
                {

                    RoleName = "Admin1",
                    RoleTitle = "مدیرکل",
                };
                db.roles.Add(role);
                db.SaveChanges();
                Role role1 = new Role()
                {

                    RoleName = "Admin2",
                    RoleTitle = "مدیرفاکتور",
                };
                db.roles.Add(role1);
                db.SaveChanges();
                Role role2 = new Role()
                {

                    RoleName = "User1",
                    RoleTitle = "کاربرعادی",
                };
                db.roles.Add(role2);
                db.SaveChanges();
                Role role3 = new Role()
                {

                    RoleName = "User2",
                    RoleTitle = "کاربرعمده",
                };
                db.roles.Add(role3);
                db.SaveChanges();
                Role role4 = new Role()
                {

                    RoleName = "User3",
                    RoleTitle = "کاربرنماینده",
                };
                db.roles.Add(role4);
                db.SaveChanges();

                #endregion
            }

            //_______________________________________________________
            //مرحله دوم
            if (db.Ostans.Count() == 0)
            {
                #region Ostans

                List<Ostan> ostans = new List<Ostan>()
                    {
                        new Ostan()
                        {
                            Id = 1,
                            OstanCode = 1,
                            ostanname = "تهران"
                        },
                        new Ostan()
                        {
                            Id = 2,
                            OstanCode = 2,
                            ostanname = "گیلان"
                        },
                        new Ostan()
                        {
                            Id = 3,
                            OstanCode = 3,
                            ostanname = "آذربایجان شرقی"
                        },
                        new Ostan()
                        {
                            Id = 4,
                            OstanCode = 4,
                            ostanname = "خوزستان"
                        },
                        new Ostan()
                        {
                            Id = 5,
                            OstanCode = 5,
                            ostanname = "فارس"
                        },
                        new Ostan()
                        {
                            Id = 6,
                            OstanCode = 6,
                            ostanname = "اصفهان"
                        },
                        new Ostan()
                        {
                            Id = 7,
                            OstanCode = 7,
                            ostanname = "خراسان رضوی"
                        },
                        new Ostan()
                        {
                            Id = 8,
                            OstanCode = 8,
                            ostanname = "قزوین"
                        },
                        new Ostan()
                        {
                            Id = 9,
                            OstanCode = 9,
                            ostanname = "سمنان"
                        },

                        new Ostan()
                        {
                            Id = 10,
                            OstanCode = 10,
                            ostanname = "قم"
                        },

                        new Ostan()
                        {
                            Id = 11,
                            OstanCode = 11,
                            ostanname = "مرکزی"
                        },

                        new Ostan()
                        {
                            Id = 12,
                            OstanCode = 12,
                            ostanname = "زنجان"
                        },

                        new Ostan()
                        {
                            Id = 13,
                            OstanCode = 13,
                            ostanname = "مازندران"
                        },

                        new Ostan()
                        {
                            Id = 14,
                            OstanCode = 14,
                            ostanname = "گلستان"
                        },

                        new Ostan()
                        {
                            Id = 15,
                            OstanCode = 15,
                            ostanname = "اردبیل"
                        },


                        new Ostan()
                        {
                            Id = 16,
                            OstanCode = 16,
                            ostanname = "آذربایجان غربی"
                        },

                        new Ostan()
                        {
                            Id = 17,
                            OstanCode = 17,
                            ostanname = "همدان"
                        },

                        new Ostan()
                        {
                            Id = 18,
                            OstanCode = 18,
                            ostanname = "کردستان"
                        },

                        new Ostan()
                        {
                            Id = 19,
                            OstanCode = 19,
                            ostanname = "کرمانشاه"
                        },
                        new Ostan()
                        {
                            Id = 20,
                            OstanCode = 20,
                            ostanname = "لرستان"
                        },
                        new Ostan()
                        {
                            Id = 21,
                            OstanCode = 21,
                            ostanname = "بوشهر"
                        },
                        new Ostan()
                        {
                            Id = 22,
                            OstanCode = 22,
                            ostanname = "کرمان"
                        },
                        new Ostan()
                        {
                            Id = 23,
                            OstanCode = 23,
                            ostanname = "هرمزگان"
                        },
                        new Ostan()
                        {
                            Id = 24,
                            OstanCode = 24,
                            ostanname = "چهارمحال و بختیاری"
                        },
                        new Ostan()
                        {
                            Id = 25,
                            OstanCode = 25,
                            ostanname = "یزد"
                        },
                        new Ostan()
                        {
                            Id = 26,
                            OstanCode = 26,
                            ostanname = "سیستان و بلوچستان"
                        },
                        new Ostan()
                        {
                            Id = 27,
                            OstanCode = 27,
                            ostanname = "ایلام"
                        },
                        new Ostan()
                        {
                            Id = 28,
                            OstanCode = 28,
                            ostanname = "کهگلویه و بویراحمد"
                        },

                        new Ostan()
                        {
                            Id = 29,
                            OstanCode = 29,
                            ostanname = "خراسان شمالی"
                        },

                        new Ostan()
                        {
                            Id = 30,
                            OstanCode = 30,
                            ostanname = "خراسان جنوبی"
                        },
                        new Ostan()
                        {
                            Id = 31,
                            OstanCode = 31,
                            ostanname = "البرز"
                        },


                    };
                foreach (var item in ostans)
                {
                    db.Ostans.Add(item);
                    db.SaveChanges();
                }



                #endregion
            }
            //_______________________________________________________
            //مرحله سوم
            if (db.users.Count() == 0)
            {
                #region User

                User user = new User()
                {
                    Id = 1,
                    ostanname = "azari",
                    OstanId = 1,
                    IsActive = true,
                    RoleId = 1,
                    UserPassword = Hash,
                    CodeActivate = "1234",
                    UserName = "salino",
                    cityname = "تبریز",
                    PostalCode = "515666666",
                    StreetAddress = "tabriz-valiasr",
                    Mobile = "09146143251",

                };
                db.users.Add(user);
                db.SaveChanges();

                #endregion
            }
            //________________________________________________________
            //مرحله چهارم

            if (db.OfferPrices.Count() == 0)
            {
                #region Offerprice
                OfferPrice offer = new OfferPrice()
                {
                    Price = 0,
                    AsNumber = 0,
                    Createdate = Convert.ToDateTime("2020-01-20 13:14:11.977")
                };
                db.OfferPrices.Add(offer);
                db.SaveChanges();

                #endregion
            }
            if (db.OfferFirstShops.Count() == 0)
            {
                #region OfferFirstShops
                OfferFirstShop offer = new OfferFirstShop()
                {
                    PriceDiscount = 0

                };
                db.OfferFirstShops.Add(offer);
                db.SaveChanges();

                #endregion
            }
            if (db.OfferNumberShops.Count() == 0)
            {
                #region OfferNumberShops
                OfferNumberShop offer = new OfferNumberShop()
                {
                    PriceDiscount = 0,
                    ToNumber = 0

                };
                db.OfferNumberShops.Add(offer);
                db.SaveChanges();

                #endregion
            }
            if (db.SendPrices.Count() == 0)
            {
                #region SendPrices
                SendPrice send = new SendPrice()
                {
                    AsNumber = 0

                };
                db.SendPrices.Add(send);
                db.SaveChanges();

                #endregion
            }
            if (db.TypeSendPosts.Count() == 0)
            {
                #region TypeSendPosts
                TypeSendPost send = new TypeSendPost()
                {
                    Id = 1,
                    PriceHaml = "0",
                    NameHaml = "0"

                };
                db.TypeSendPosts.Add(send);
                db.SaveChanges();

                #endregion
            }
            if (db.SendForMajors.Count() == 0)
            {
                #region TypeSendPosts
                SendForMajor send = new SendForMajor()
                {
                    PriceHaml = "0",
                    NameHaml = "0"

                };
                db.SendForMajors.Add(send);
                db.SaveChanges();

                #endregion
            }
            if (db.FarbicTypes.Count() == 0)
            {
                #region TypeSendPosts
                FarbicType send = new FarbicType()
                {
                    IsShow = true,
                    PriceMain = 1,
                    tiltle = "نخی"

                };
                db.FarbicTypes.Add(send);
                db.SaveChanges();

                #endregion
            }



        }
    }
}
