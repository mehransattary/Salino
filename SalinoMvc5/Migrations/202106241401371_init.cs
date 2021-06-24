namespace SalinoMvc5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Colors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        color = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ColorsProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ColorId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Colors", t => t.ColorId, cascadeDelete: true)
                .Index(t => t.ColorId);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        ParentId = c.Int(),
                        Name = c.String(nullable: false, maxLength: 20),
                        TextComment = c.String(nullable: false),
                        Createdate = c.String(),
                        IsShow = c.Boolean(nullable: false),
                        OkAnswer = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Comments", t => t.ParentId)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.ParentId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CodeKala = c.String(maxLength: 100),
                        GroupId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        Imgdetail = c.String(),
                        ImgdetailMob = c.String(),
                        ImgMain = c.String(),
                        ImgMainMob = c.String(),
                        Description = c.String(),
                        Seen = c.Int(nullable: false),
                        CreateDate = c.String(),
                        CreateTime = c.String(),
                        IsShow = c.Boolean(nullable: false),
                        ColorId = c.Int(),
                        CreateDateEnglish = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Colors", t => t.ColorId)
                .ForeignKey("dbo.GroupProducts", t => t.GroupId, cascadeDelete: true)
                .Index(t => t.GroupId)
                .Index(t => t.ColorId);
            
            CreateTable(
                "dbo.FarbicTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        tiltle = c.String(maxLength: 100),
                        PriceMain = c.Long(nullable: false),
                        IsShow = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GroupProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GroupTitle = c.String(nullable: false, maxLength: 50),
                        GroupNotShow = c.Boolean(nullable: false),
                        imagepath = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Monasebats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MonasebatTitle = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Entegadats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Parentid = c.Int(),
                        Name = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false),
                        TextComment = c.String(nullable: false),
                        Date = c.String(),
                        OkAnswer = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Entegadats", t => t.Parentid)
                .Index(t => t.Parentid);
            
            CreateTable(
                "dbo.FactorDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FactorMainId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        ProductName = c.String(),
                        FarbicTypeId = c.Int(nullable: false),
                        FarbicTypeName = c.String(),
                        DetailCount = c.Int(nullable: false),
                        DetailPrice = c.Int(nullable: false),
                        SumPrice = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FactorMains", t => t.FactorMainId, cascadeDelete: true)
                .Index(t => t.FactorMainId);
            
            CreateTable(
                "dbo.FactorMains",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleId = c.Int(nullable: false),
                        CodeGenerator = c.Long(nullable: false),
                        Paymentstatus = c.String(),
                        PaymentNumber = c.String(maxLength: 50),
                        FactorNumber = c.Long(nullable: false),
                        CardNumberMasked = c.String(),
                        RRN = c.String(),
                        PostNumber = c.String(maxLength: 150),
                        SaleReferenceId = c.String(maxLength: 50),
                        Amount = c.Int(nullable: false),
                        Discount = c.Int(nullable: false),
                        SumAllPrice = c.Int(nullable: false),
                        IsPay = c.Boolean(nullable: false),
                        UserId = c.Int(nullable: false),
                        Username = c.String(),
                        UserMobile = c.String(),
                        UserCodePosti = c.String(),
                        UserOstan = c.String(),
                        UserCity = c.String(),
                        AddressUser = c.String(),
                        DateCreate = c.String(),
                        Time = c.String(),
                        DateCreateDatetime = c.DateTime(nullable: false),
                        Year = c.Int(nullable: false),
                        Month = c.Int(nullable: false),
                        Day = c.Int(nullable: false),
                        Deliverytime = c.String(),
                        StatusAll = c.Int(nullable: false),
                        TypeSendPostId = c.Int(nullable: false),
                        TypeSendPostName = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.FarbicTypeProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FarbicTypeId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FarbicTypes", t => t.FarbicTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.FarbicTypeId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Galleries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        ImgPath = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.gifcardDates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 100),
                        Amount = c.Int(nullable: false),
                        NumberUse = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        CreateDateShamsi = c.String(),
                        ExpirationDate = c.DateTime(nullable: false),
                        ExpirationDateShamsi = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.giftcards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 100),
                        Amount = c.Int(nullable: false),
                        NumberUse = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ImageMains",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SliderTitle = c.String(maxLength: 100),
                        SliderIMG = c.String(),
                        SliderIMGMob = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ImageOffers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SliderTitle = c.String(maxLength: 100),
                        SliderIMG = c.String(),
                        SliderIMGMob = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ImageAdvers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Img1 = c.String(),
                        GroupIdTopRight = c.Int(nullable: false),
                        Img2 = c.String(),
                        GroupIdBottomRight = c.Int(nullable: false),
                        Img3 = c.String(),
                        GroupIdTopLeft = c.Int(nullable: false),
                        Img4 = c.String(),
                        GroupIdBottomLeft = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MajorShops",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MinSelectedProduct = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        FarbicId = c.Int(nullable: false),
                        PriceMajor = c.Int(nullable: false),
                        Createdate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FarbicTypes", t => t.FarbicId, cascadeDelete: true)
                .Index(t => t.FarbicId);
            
            CreateTable(
                "dbo.Mojavezs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ListKhadamat = c.String(),
                        Img1 = c.String(),
                        Img2 = c.String(),
                        Img3 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MonasebatProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MonasebatId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Monasebats", t => t.MonasebatId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.MonasebatId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.OfferFirstShops",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PriceDiscount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OfferNumberShops",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ToNumber = c.Int(nullable: false),
                        PriceDiscount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OfferPrices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Int(nullable: false),
                        AsNumber = c.Int(nullable: false),
                        Createdate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ostans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OstanCode = c.Int(nullable: false),
                        ostanname = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleId = c.Int(nullable: false),
                        UserName = c.String(maxLength: 50),
                        UserPassword = c.String(maxLength: 50),
                        cityname = c.String(),
                        ostanname = c.String(),
                        OstanId = c.Int(nullable: false),
                        PostalCode = c.String(maxLength: 50),
                        StreetAddress = c.String(),
                        Mobile = c.String(maxLength: 50),
                        IsActive = c.Boolean(nullable: false),
                        Createdate = c.String(),
                        CodeActivate = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ostans", t => t.OstanId, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId)
                .Index(t => t.OstanId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleName = c.String(nullable: false, maxLength: 20),
                        RoleTitle = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SendForMajors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameHaml = c.String(maxLength: 100),
                        PriceHaml = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SendPrices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AsNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Settings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DecAboutMe = c.String(nullable: false),
                        DecContactUs = c.String(nullable: false),
                        Questions = c.String(nullable: false),
                        Address = c.String(maxLength: 300),
                        Tell = c.String(maxLength: 50),
                        Mobile = c.String(maxLength: 50),
                        Email = c.String(maxLength: 50),
                        imageSrc = c.String(),
                        imageSrcMain = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Socials",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SocialName = c.String(nullable: false, maxLength: 100),
                        SocialIcon = c.String(),
                        SocialLink = c.String(maxLength: 200),
                        NotShow = c.Boolean(nullable: false),
                        SocialOrder = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        ParentId = c.Int(),
                        TitleTicket = c.String(nullable: false, maxLength: 50),
                        TextTicket = c.String(nullable: false),
                        Createdate = c.String(),
                        OkAnswer = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tickets", t => t.ParentId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.ParentId);
            
            CreateTable(
                "dbo.TypeSendPosts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameHaml = c.String(maxLength: 100),
                        PriceHaml = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FarbicTypeProducts1",
                c => new
                    {
                        FarbicType_Id = c.Int(nullable: false),
                        Product_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.FarbicType_Id, t.Product_Id })
                .ForeignKey("dbo.FarbicTypes", t => t.FarbicType_Id, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_Id, cascadeDelete: true)
                .Index(t => t.FarbicType_Id)
                .Index(t => t.Product_Id);
            
            CreateTable(
                "dbo.MonasebatProducts1",
                c => new
                    {
                        Monasebat_Id = c.Int(nullable: false),
                        Product_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Monasebat_Id, t.Product_Id })
                .ForeignKey("dbo.Monasebats", t => t.Monasebat_Id, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_Id, cascadeDelete: true)
                .Index(t => t.Monasebat_Id)
                .Index(t => t.Product_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "UserId", "dbo.Users");
            DropForeignKey("dbo.Tickets", "ParentId", "dbo.Tickets");
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.Users", "OstanId", "dbo.Ostans");
            DropForeignKey("dbo.FactorMains", "UserId", "dbo.Users");
            DropForeignKey("dbo.MonasebatProducts", "ProductId", "dbo.Products");
            DropForeignKey("dbo.MonasebatProducts", "MonasebatId", "dbo.Monasebats");
            DropForeignKey("dbo.MajorShops", "FarbicId", "dbo.FarbicTypes");
            DropForeignKey("dbo.Galleries", "ProductId", "dbo.Products");
            DropForeignKey("dbo.FarbicTypeProducts", "ProductId", "dbo.Products");
            DropForeignKey("dbo.FarbicTypeProducts", "FarbicTypeId", "dbo.FarbicTypes");
            DropForeignKey("dbo.FactorDetails", "FactorMainId", "dbo.FactorMains");
            DropForeignKey("dbo.Entegadats", "Parentid", "dbo.Entegadats");
            DropForeignKey("dbo.Comments", "ProductId", "dbo.Products");
            DropForeignKey("dbo.MonasebatProducts1", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.MonasebatProducts1", "Monasebat_Id", "dbo.Monasebats");
            DropForeignKey("dbo.Products", "GroupId", "dbo.GroupProducts");
            DropForeignKey("dbo.FarbicTypeProducts1", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.FarbicTypeProducts1", "FarbicType_Id", "dbo.FarbicTypes");
            DropForeignKey("dbo.Products", "ColorId", "dbo.Colors");
            DropForeignKey("dbo.Comments", "ParentId", "dbo.Comments");
            DropForeignKey("dbo.ColorsProducts", "ColorId", "dbo.Colors");
            DropIndex("dbo.MonasebatProducts1", new[] { "Product_Id" });
            DropIndex("dbo.MonasebatProducts1", new[] { "Monasebat_Id" });
            DropIndex("dbo.FarbicTypeProducts1", new[] { "Product_Id" });
            DropIndex("dbo.FarbicTypeProducts1", new[] { "FarbicType_Id" });
            DropIndex("dbo.Tickets", new[] { "ParentId" });
            DropIndex("dbo.Tickets", new[] { "UserId" });
            DropIndex("dbo.Users", new[] { "OstanId" });
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropIndex("dbo.MonasebatProducts", new[] { "ProductId" });
            DropIndex("dbo.MonasebatProducts", new[] { "MonasebatId" });
            DropIndex("dbo.MajorShops", new[] { "FarbicId" });
            DropIndex("dbo.Galleries", new[] { "ProductId" });
            DropIndex("dbo.FarbicTypeProducts", new[] { "ProductId" });
            DropIndex("dbo.FarbicTypeProducts", new[] { "FarbicTypeId" });
            DropIndex("dbo.FactorMains", new[] { "UserId" });
            DropIndex("dbo.FactorDetails", new[] { "FactorMainId" });
            DropIndex("dbo.Entegadats", new[] { "Parentid" });
            DropIndex("dbo.Products", new[] { "ColorId" });
            DropIndex("dbo.Products", new[] { "GroupId" });
            DropIndex("dbo.Comments", new[] { "ParentId" });
            DropIndex("dbo.Comments", new[] { "ProductId" });
            DropIndex("dbo.ColorsProducts", new[] { "ColorId" });
            DropTable("dbo.MonasebatProducts1");
            DropTable("dbo.FarbicTypeProducts1");
            DropTable("dbo.TypeSendPosts");
            DropTable("dbo.Tickets");
            DropTable("dbo.Socials");
            DropTable("dbo.Settings");
            DropTable("dbo.SendPrices");
            DropTable("dbo.SendForMajors");
            DropTable("dbo.Roles");
            DropTable("dbo.Users");
            DropTable("dbo.Ostans");
            DropTable("dbo.OfferPrices");
            DropTable("dbo.OfferNumberShops");
            DropTable("dbo.OfferFirstShops");
            DropTable("dbo.MonasebatProducts");
            DropTable("dbo.Mojavezs");
            DropTable("dbo.MajorShops");
            DropTable("dbo.ImageAdvers");
            DropTable("dbo.ImageOffers");
            DropTable("dbo.ImageMains");
            DropTable("dbo.giftcards");
            DropTable("dbo.gifcardDates");
            DropTable("dbo.Galleries");
            DropTable("dbo.FarbicTypeProducts");
            DropTable("dbo.FactorMains");
            DropTable("dbo.FactorDetails");
            DropTable("dbo.Entegadats");
            DropTable("dbo.Monasebats");
            DropTable("dbo.GroupProducts");
            DropTable("dbo.FarbicTypes");
            DropTable("dbo.Products");
            DropTable("dbo.Comments");
            DropTable("dbo.ColorsProducts");
            DropTable("dbo.Colors");
        }
    }
}
