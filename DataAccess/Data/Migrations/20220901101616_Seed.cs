using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Data.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("0020781f-b53e-4d1b-9727-9e16607c6438"), "Gorgeous Cotton Soap", 57m },
                    { new Guid("002f383c-4613-42fc-9549-ce410a2d71fb"), "Unbranded Concrete Sausages", 50m },
                    { new Guid("009fb850-0699-4264-921f-b22d19f20cb4"), "Tasty Soft Gloves", 51m },
                    { new Guid("01460f95-b945-4bb2-8e4e-70ef80f59f07"), "Rustic Frozen Computer", 53m },
                    { new Guid("016a7952-346c-4f8c-99d6-87753d0c636b"), "Incredible Granite Chips", 52m },
                    { new Guid("0190572c-ab09-4d39-a999-3cc556c2f7b7"), "Awesome Cotton Salad", 56m },
                    { new Guid("01b441ea-be2d-482d-ab21-05ea570dc15b"), "Sleek Frozen Pizza", 50m },
                    { new Guid("029937be-923a-4694-9ad3-321e4709bb73"), "Incredible Fresh Towels", 56m },
                    { new Guid("02b1cabf-4043-4ac7-b858-3887e0587613"), "Small Metal Chair", 54m },
                    { new Guid("0306ea4e-b54f-45d0-b880-d426fc0c8108"), "Incredible Metal Shoes", 49m },
                    { new Guid("031e072f-5a72-4752-ac43-333b9a222060"), "Handmade Cotton Bacon", 51m },
                    { new Guid("03af47f9-3fe2-4a9d-8e10-d1a6af387666"), "Rustic Steel Car", 55m },
                    { new Guid("03bc4021-7e14-4dad-88f5-35d5b8b87ad6"), "Handcrafted Steel Pizza", 49m },
                    { new Guid("044dd1b6-9db4-4006-b891-3bb3d9069785"), "Generic Frozen Bacon", 54m },
                    { new Guid("04a8f30a-dde6-4dbc-b808-c91f7a20dafd"), "Awesome Metal Gloves", 55m },
                    { new Guid("050850d2-025b-4a6d-b6b7-523cc1aef313"), "Ergonomic Steel Towels", 56m },
                    { new Guid("059a7df4-76b5-4f1f-a9af-978956d46f75"), "Generic Granite Chips", 57m },
                    { new Guid("05e00bf9-de4e-4023-9d35-612c07b6e372"), "Awesome Soft Bacon", 50m },
                    { new Guid("064ae937-544b-4191-9d8f-89c216c36a44"), "Small Concrete Chicken", 52m },
                    { new Guid("06e935a0-e333-4d9e-88de-acd1d326184f"), "Generic Rubber Salad", 53m },
                    { new Guid("06fcef3c-f6d0-447f-b9c9-bf04082175dd"), "Unbranded Plastic Ball", 52m },
                    { new Guid("076faa7b-e8b3-4c7e-8902-4861c7104532"), "Awesome Concrete Fish", 54m },
                    { new Guid("08167416-3445-43e0-b2d0-dc17e6bb59b8"), "Rustic Rubber Pizza", 50m },
                    { new Guid("0898b046-3505-468b-bea5-162d93b3fce7"), "Sleek Metal Shoes", 52m },
                    { new Guid("08e45c6b-780e-4abd-95dd-a0d0e798bdd6"), "Handcrafted Fresh Salad", 55m },
                    { new Guid("098f7806-cae0-419b-b914-c61652a617d3"), "Refined Cotton Cheese", 57m },
                    { new Guid("0aef3ba8-bc7d-4063-a092-f877dbce4206"), "Incredible Soft Computer", 51m },
                    { new Guid("0be426f3-b8be-43e8-b55b-b313c000c336"), "Gorgeous Frozen Car", 52m },
                    { new Guid("0c7c9df1-c321-4ddc-9099-5645994e5ead"), "Handcrafted Metal Keyboard", 49m },
                    { new Guid("0d448b05-0237-49e2-96c5-42f85d98cf1c"), "Refined Frozen Hat", 53m },
                    { new Guid("0d5404b1-2a1a-479a-a0df-32f1198c1254"), "Rustic Wooden Towels", 49m },
                    { new Guid("0d5bcc03-6f3a-4640-8c0e-4c6f5812f554"), "Generic Steel Cheese", 52m },
                    { new Guid("0ddb6973-0000-4336-9346-77f5760b5e3f"), "Rustic Rubber Table", 49m },
                    { new Guid("0e550331-3859-44ee-ab97-2f9f8a5faec9"), "Gorgeous Cotton Sausages", 52m },
                    { new Guid("0e913aed-4729-41de-bdcc-71e19921684d"), "Fantastic Plastic Shoes", 54m },
                    { new Guid("0ea547fa-3f23-4cda-ab9d-cf26a7c8a771"), "Unbranded Soft Tuna", 56m },
                    { new Guid("0ec34d14-c4c6-484d-aa70-d516d65c1565"), "Incredible Granite Shoes", 54m },
                    { new Guid("11594fd8-0a7a-4410-aff8-54220eaf4c5d"), "Generic Frozen Shoes", 55m },
                    { new Guid("11d4216c-94c5-4713-8831-f98974770ee8"), "Awesome Soft Shoes", 57m },
                    { new Guid("11ef0c55-abaf-4218-8ba8-653ab3355e82"), "Intelligent Cotton Tuna", 49m },
                    { new Guid("12096f59-f68f-46f6-a6a4-b4c2a445d851"), "Gorgeous Concrete Salad", 56m },
                    { new Guid("123de458-520c-44bc-9261-5a6d031e354c"), "Small Soft Tuna", 55m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("126800f8-0b64-4911-8fe2-844f111fc0f0"), "Unbranded Concrete Shoes", 54m },
                    { new Guid("127d89fa-98f9-47f1-9e80-3420e3fff463"), "Small Granite Mouse", 57m },
                    { new Guid("12d5ea38-5fe2-45e9-bdb8-f1310a14bd65"), "Ergonomic Wooden Cheese", 55m },
                    { new Guid("12fb19c0-8e0d-49a8-b8a3-702e811b9049"), "Intelligent Fresh Gloves", 55m },
                    { new Guid("13315d68-137d-4d1d-b894-9d21ffc4601a"), "Handmade Fresh Computer", 54m },
                    { new Guid("1348ffc3-4d66-4563-a1b2-bb8a1831cee0"), "Practical Metal Table", 50m },
                    { new Guid("1354620e-1550-4e35-bd47-75d5eea11fcf"), "Ergonomic Frozen Bike", 49m },
                    { new Guid("13d0cd2d-38b3-4f2f-a043-e66f133a986d"), "Handmade Plastic Ball", 57m },
                    { new Guid("1437cc5e-f450-4517-80f2-0748cdf756c4"), "Unbranded Soft Table", 55m },
                    { new Guid("17bf3079-004d-4c77-87ed-23945cfe051a"), "Intelligent Soft Bike", 49m },
                    { new Guid("18598187-e2c4-4050-afb0-1ceb05883a63"), "Sleek Cotton Ball", 51m },
                    { new Guid("18754842-5aaf-4d4a-8c8e-c31d1069af44"), "Rustic Granite Computer", 49m },
                    { new Guid("199cdecf-9838-4ed3-bdde-aee81212dd12"), "Refined Frozen Keyboard", 54m },
                    { new Guid("19a07e66-65bf-4143-a7a5-e8b7119755c4"), "Handcrafted Soft Bacon", 53m },
                    { new Guid("1a3b25e8-9f3c-4482-9f5f-111d9ad76661"), "Handcrafted Metal Salad", 49m },
                    { new Guid("1a578b45-1f53-4331-80c9-cc8230fae85f"), "Handcrafted Fresh Bike", 57m },
                    { new Guid("1a5a4d34-9f22-4032-844f-466b5bd45faa"), "Small Granite Soap", 50m },
                    { new Guid("1ac10726-692c-4fd9-b788-69e0b6e11314"), "Unbranded Rubber Computer", 50m },
                    { new Guid("1b139120-8834-4cf0-b689-f490a62965e9"), "Unbranded Granite Pants", 53m },
                    { new Guid("1c503980-84d1-444f-81a0-ff259c29304c"), "Ergonomic Plastic Bike", 51m },
                    { new Guid("1d063fc4-853f-43d1-bafb-9c4168719630"), "Gorgeous Frozen Sausages", 50m },
                    { new Guid("1d912c2e-7c26-4a6f-b7e6-f57a71ddb824"), "Rustic Steel Computer", 49m },
                    { new Guid("1d9cf73b-953e-45cc-858b-c6f99dc35956"), "Tasty Metal Fish", 55m },
                    { new Guid("1e93844e-d88a-4aeb-845d-ac98b7381d8a"), "Small Frozen Bike", 52m },
                    { new Guid("1ec16144-8209-496d-a5b8-ba501ed84351"), "Handcrafted Granite Chicken", 56m },
                    { new Guid("20497d4d-c2f0-44d1-8468-b49d81ff0246"), "Intelligent Frozen Shirt", 54m },
                    { new Guid("2095057e-2baa-49fb-85c0-92f6bbe987d1"), "Sleek Plastic Mouse", 50m },
                    { new Guid("20c99112-f26e-47b4-8cfc-33fc125ab840"), "Generic Granite Bacon", 51m },
                    { new Guid("22038067-da16-48bf-9487-33472bf6154a"), "Ergonomic Rubber Bike", 53m },
                    { new Guid("226f557b-4554-4db1-851f-487b2e559e96"), "Tasty Granite Tuna", 54m },
                    { new Guid("22de0a8c-bae5-4810-a64a-b20987bff866"), "Handmade Plastic Gloves", 49m },
                    { new Guid("22ee8203-624d-48d1-b2b3-97f68791a72e"), "Ergonomic Fresh Chicken", 53m },
                    { new Guid("2380914e-4692-4828-a8a1-aa0fe5e74b91"), "Generic Metal Chicken", 57m },
                    { new Guid("23c6f7da-58fe-4102-b550-0166ed5c056e"), "Fantastic Soft Car", 56m },
                    { new Guid("2472a7b3-f1bf-404e-8596-ed928902eea3"), "Tasty Rubber Shoes", 52m },
                    { new Guid("2539224e-0749-4d16-b010-7f51d86cdccc"), "Licensed Wooden Towels", 51m },
                    { new Guid("2678d658-45f1-4da7-a551-4f81bc3378d1"), "Unbranded Rubber Sausages", 49m },
                    { new Guid("27177182-4e32-4bee-b51a-b3c42bc23111"), "Unbranded Frozen Pants", 49m },
                    { new Guid("27efe18d-639e-43fa-94c8-518e3d3dd882"), "Sleek Plastic Soap", 55m },
                    { new Guid("2872cb6a-f6d0-451d-aaa0-ea5f071a5c84"), "Sleek Concrete Salad", 55m },
                    { new Guid("28aef3fd-92d8-42c0-abac-745e602377ed"), "Generic Rubber Mouse", 55m },
                    { new Guid("290af343-d294-4fd3-869e-919a86dceeb4"), "Handmade Plastic Sausages", 50m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("293ab4a1-7e87-427d-a9ff-77e0652a8db8"), "Tasty Plastic Bacon", 52m },
                    { new Guid("2957b695-dcaf-4882-92e3-8f3de9d128d8"), "Handmade Granite Ball", 56m },
                    { new Guid("29e29242-b491-4caa-a812-ea9017c37f39"), "Tasty Metal Bike", 49m },
                    { new Guid("2a81af19-23be-4e51-bf1b-0f4e10ea804b"), "Intelligent Cotton Hat", 52m },
                    { new Guid("2b19998d-f5da-4dde-bdfc-3185a59fe8e9"), "Handcrafted Frozen Pants", 52m },
                    { new Guid("2b1aab66-0b70-458e-b47f-4c7dd0eabdba"), "Licensed Frozen Chicken", 57m },
                    { new Guid("2c1a18f7-fcd8-41ba-bb97-11d61f94aa6a"), "Ergonomic Metal Tuna", 50m },
                    { new Guid("2cca4ab6-8866-4725-bb9d-ee71c6839189"), "Licensed Wooden Chair", 56m },
                    { new Guid("2ce9b873-1808-43a7-8e88-6a8c4bf265fe"), "Refined Frozen Bacon", 57m },
                    { new Guid("2d0f8237-db3f-4cb6-b1c8-11c46ffaed62"), "Ergonomic Concrete Towels", 49m },
                    { new Guid("2d6db41f-6022-41ad-8ad0-b9e70a8d34f4"), "Refined Concrete Shoes", 50m },
                    { new Guid("2e6a0ed5-64b5-4d82-9ae8-8a44e376cc84"), "Small Granite Computer", 51m },
                    { new Guid("2f220fa7-e836-48ac-9283-6df71878e0f1"), "Rustic Frozen Pants", 53m },
                    { new Guid("2f4cad24-bad5-413b-8115-935c345592a9"), "Small Rubber Bacon", 53m },
                    { new Guid("2f66f436-6082-4806-93b5-25608fb4b29d"), "Small Plastic Mouse", 49m },
                    { new Guid("2f725460-2cf3-4dfe-8e67-8373ecdbeeab"), "Ergonomic Plastic Car", 57m },
                    { new Guid("2f81f126-078e-4aa5-9a85-4e80bd255e04"), "Awesome Cotton Gloves", 56m },
                    { new Guid("3036fd27-ba3e-4d69-b1ce-2624fdf0b696"), "Gorgeous Granite Car", 49m },
                    { new Guid("30b876e0-b15c-4737-bcc4-e8979f94e870"), "Small Cotton Pants", 56m },
                    { new Guid("3167c290-c78b-4274-8539-8721bfedb2b6"), "Tasty Frozen Table", 57m },
                    { new Guid("31f63f70-88bf-4ca3-81eb-4358a1c859b6"), "Incredible Plastic Chicken", 54m },
                    { new Guid("323b2542-8b32-4120-86b3-2a2905837e8d"), "Licensed Cotton Car", 55m },
                    { new Guid("32eb71ac-57c2-488c-9566-677d5493982e"), "Licensed Rubber Ball", 49m },
                    { new Guid("34857150-7ce3-4dfe-bda6-84da47cdaf6e"), "Sleek Granite Computer", 51m },
                    { new Guid("34dfe649-3e92-4b15-b5fe-b9f999973c7b"), "Incredible Fresh Table", 56m },
                    { new Guid("34ebe627-57fc-41a0-a705-72510f449d07"), "Generic Granite Bacon", 54m },
                    { new Guid("350af6de-dbb9-44fd-b225-a7a78ac44c8b"), "Tasty Fresh Towels", 57m },
                    { new Guid("3579f928-ea2d-4d65-945a-cb009a83fbec"), "Refined Granite Cheese", 57m },
                    { new Guid("35e7d68f-d4d8-42dd-b746-2f44b50cae71"), "Licensed Granite Pants", 49m },
                    { new Guid("36557fb5-0a48-4feb-8dfe-699317abcef8"), "Handcrafted Plastic Bike", 54m },
                    { new Guid("3660271c-3f00-44a2-aec2-6eca7c380fb2"), "Handmade Granite Table", 57m },
                    { new Guid("36e4b0ed-3830-49b3-9441-f59f1f0aeccd"), "Handmade Fresh Shirt", 50m },
                    { new Guid("36ecc915-58bd-4a32-b353-9aa35515a242"), "Licensed Frozen Salad", 49m },
                    { new Guid("376b3b24-dad5-4fef-a042-07234f66a0fd"), "Practical Frozen Sausages", 56m },
                    { new Guid("3785fd87-a630-4358-b2e9-c283d80c0eac"), "Tasty Plastic Ball", 53m },
                    { new Guid("37a70484-d851-413e-9162-98e7ed824132"), "Licensed Rubber Table", 56m },
                    { new Guid("386d159f-0f4b-4a40-bd0b-539477a76efd"), "Licensed Metal Pizza", 53m },
                    { new Guid("38d707ed-5b6e-41af-9bda-37aaa9171b2b"), "Sleek Rubber Chicken", 54m },
                    { new Guid("39209857-5076-4c04-821e-4208b43fed68"), "Tasty Plastic Computer", 56m },
                    { new Guid("394a1f56-f85b-4b3c-b7f3-e5df94d9db1b"), "Awesome Fresh Salad", 53m },
                    { new Guid("3a6b81ac-a926-4dd4-90bf-82a81104c488"), "Small Rubber Computer", 53m },
                    { new Guid("3a7a52cc-73c7-49d7-ac61-d99620519479"), "Licensed Fresh Bike", 53m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("3a7f38b9-92b7-4e79-8bc8-e802f4fa5039"), "Awesome Plastic Sausages", 54m },
                    { new Guid("3aff43b1-bda5-4870-81f3-a12f90b7204f"), "Intelligent Steel Mouse", 50m },
                    { new Guid("3b71f71e-82c0-4054-bd3e-c127770ee7ea"), "Practical Steel Table", 52m },
                    { new Guid("3b746024-95c8-41ed-8e9f-8a4aca0260c1"), "Small Fresh Shirt", 55m },
                    { new Guid("3bc88a79-d99a-4dfb-bc49-c8032c31a5e4"), "Handcrafted Fresh Salad", 51m },
                    { new Guid("3e5833c4-493b-4d87-bbe5-275569c723a3"), "Practical Wooden Bacon", 50m },
                    { new Guid("3eaf1aa4-138a-4aba-80f1-9917772bb29c"), "Rustic Frozen Pizza", 55m },
                    { new Guid("3f1d3ef3-bc5f-4fc3-b0a0-8f918e07d6aa"), "Licensed Wooden Car", 52m },
                    { new Guid("4131d4f8-a616-4f1f-a656-a405d74eee96"), "Fantastic Wooden Hat", 57m },
                    { new Guid("4181651e-153e-4672-9aa0-a2a9379b979b"), "Refined Wooden Salad", 50m },
                    { new Guid("424f0d47-2a37-41c3-bdec-d1b0e6b30386"), "Ergonomic Soft Cheese", 52m },
                    { new Guid("42880685-00de-428e-8e56-56066e6ca91b"), "Generic Plastic Hat", 50m },
                    { new Guid("42b1e480-e533-4564-a5e4-4255f9c3bf62"), "Fantastic Metal Chips", 53m },
                    { new Guid("43089309-0f9e-462e-ad47-0caa3caca915"), "Incredible Fresh Soap", 49m },
                    { new Guid("43e5c99b-b2e6-49ef-a1d5-96f3d6bceeeb"), "Sleek Plastic Table", 49m },
                    { new Guid("44d5efeb-9660-49aa-b423-a0f0f1d90597"), "Gorgeous Cotton Towels", 51m },
                    { new Guid("451221b5-3810-41a5-ae74-d285880f288d"), "Licensed Wooden Bacon", 55m },
                    { new Guid("471eca15-1cb1-4792-b923-c34b2333de9f"), "Generic Concrete Cheese", 52m },
                    { new Guid("47399163-8c9e-4e28-bb7b-932185d6a2e4"), "Small Wooden Car", 56m },
                    { new Guid("473e8f3c-dd0f-4e2d-9733-2d92f1ebfe5e"), "Intelligent Concrete Table", 51m },
                    { new Guid("47c7b904-b21b-4586-8008-911695e389da"), "Tasty Granite Gloves", 49m },
                    { new Guid("482a0ce9-eb50-4a20-9880-c540a04bd5b7"), "Generic Rubber Ball", 55m },
                    { new Guid("484ed8df-d6f6-4eda-97dd-b6301d08d91d"), "Handcrafted Fresh Pants", 53m },
                    { new Guid("497feee4-fd48-46ef-ae2c-311e08aac145"), "Handmade Steel Soap", 54m },
                    { new Guid("49aeb048-8e71-4af4-b585-a342d98b4c0d"), "Gorgeous Rubber Towels", 49m },
                    { new Guid("4b495777-74a4-407f-a3e1-370f0ceabc02"), "Intelligent Frozen Bacon", 53m },
                    { new Guid("4b508211-1697-4f53-a6de-f82c6b17045b"), "Tasty Steel Keyboard", 52m },
                    { new Guid("4d8bef4a-ecee-41b0-9607-09561e92a4da"), "Small Plastic Shoes", 57m },
                    { new Guid("4ea72b89-0913-42f3-a204-33767394a377"), "Gorgeous Plastic Ball", 50m },
                    { new Guid("4f4cdf8a-b72d-4f00-9ca9-4cfaad929573"), "Rustic Frozen Sausages", 55m },
                    { new Guid("509904cf-faf6-4565-87c6-20ffdb58fe52"), "Tasty Granite Chips", 50m },
                    { new Guid("50b20d81-82c7-4234-b388-b08e266b651d"), "Gorgeous Cotton Tuna", 53m },
                    { new Guid("51908af1-93c7-44ed-9dc3-17dbe27007ea"), "Fantastic Steel Shirt", 56m },
                    { new Guid("51a3c7e5-498a-434a-a9bf-c2f468519fa0"), "Rustic Fresh Salad", 55m },
                    { new Guid("51c40ffc-0d53-4700-8fff-d4a6b66c8074"), "Intelligent Concrete Shoes", 49m },
                    { new Guid("51d0579f-051a-4ec9-873a-90c3d7fc5b82"), "Handcrafted Plastic Pants", 51m },
                    { new Guid("5297ddc6-318e-4517-a0e8-f1e21b7a30e5"), "Rustic Fresh Pizza", 55m },
                    { new Guid("52b71efb-d5de-4f96-aeaa-61e049fc0f7c"), "Fantastic Concrete Sausages", 54m },
                    { new Guid("53151470-6d0f-4fb8-923e-e4b33349c4a6"), "Fantastic Cotton Bike", 50m },
                    { new Guid("537ba2e2-4e8c-4c18-b690-6458f1fd2888"), "Handcrafted Granite Chicken", 53m },
                    { new Guid("5383a442-70f3-42eb-be86-fb34b3c71165"), "Licensed Plastic Mouse", 50m },
                    { new Guid("53944f4c-6a30-4d31-9022-8670093cb391"), "Awesome Soft Car", 54m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("54101940-afb4-42bc-b58e-4d5472166e66"), "Refined Concrete Chair", 53m },
                    { new Guid("544224be-ceb5-4e68-9d6a-d5664bab93a9"), "Tasty Soft Shoes", 50m },
                    { new Guid("54459e0a-7a49-4bc8-a12f-c63e7872f573"), "Intelligent Plastic Tuna", 52m },
                    { new Guid("5492296a-a686-4a30-8f24-00e8a3347f0a"), "Sleek Steel Shirt", 52m },
                    { new Guid("54f01df3-7e27-41d9-8499-a609c37e9b05"), "Small Granite Ball", 55m },
                    { new Guid("5519d399-7df8-4326-9eb7-72572ac3edad"), "Handcrafted Metal Keyboard", 51m },
                    { new Guid("5617304c-f5fc-4e4a-9b5e-af1bffda1a91"), "Unbranded Granite Pants", 53m },
                    { new Guid("561a4c4b-0030-4524-bae0-f40602bfea35"), "Refined Steel Computer", 54m },
                    { new Guid("56f06277-f6b5-4116-b36a-efa36fdda76b"), "Sleek Frozen Computer", 56m },
                    { new Guid("58ff520b-f23b-4d88-b5fe-d43e9a0e0eb4"), "Licensed Metal Bike", 49m },
                    { new Guid("5a118fbb-3254-4a5a-8ceb-f12996d1ea4d"), "Licensed Wooden Mouse", 49m },
                    { new Guid("5a172148-f91e-451d-8978-53ae325c7877"), "Generic Wooden Salad", 57m },
                    { new Guid("5adbc56d-7a64-4484-a417-0f45206c1420"), "Small Soft Chips", 56m },
                    { new Guid("5c2a8a58-dd21-4324-996c-4b3e9db62513"), "Tasty Wooden Cheese", 49m },
                    { new Guid("5d1c7888-b678-4aff-b3dd-18187b237503"), "Intelligent Steel Sausages", 50m },
                    { new Guid("5e240019-3a8c-4a7f-a0f3-6f9d23d339f4"), "Intelligent Fresh Shoes", 49m },
                    { new Guid("5ef14a0e-448d-4122-8ee2-60bf587b3988"), "Awesome Frozen Bacon", 52m },
                    { new Guid("5f2ea04a-aff9-4dca-b1ab-bdf2becc26d9"), "Practical Wooden Salad", 54m },
                    { new Guid("5f79c598-ac0a-4fc5-8bdf-cf9a23022ea9"), "Small Steel Mouse", 50m },
                    { new Guid("5fcb4bdf-bf4a-4681-836c-327c70dd4397"), "Rustic Granite Mouse", 52m },
                    { new Guid("60c94ee1-00e7-40b9-9600-5dd0cc64ec59"), "Handmade Metal Computer", 49m },
                    { new Guid("60d7a02e-ccf4-4701-bc8e-52d5125ecc6a"), "Awesome Rubber Pants", 52m },
                    { new Guid("60f7fd53-304b-4fe8-8e8e-857537ac7687"), "Licensed Cotton Pants", 57m },
                    { new Guid("60f86a4f-2730-4a7a-87a9-4e17e93f954f"), "Small Rubber Computer", 51m },
                    { new Guid("61c97d8f-b542-405d-954b-44da6f5e0be8"), "Generic Soft Mouse", 56m },
                    { new Guid("61cc6b34-3205-4c29-870a-20a073ef978e"), "Awesome Fresh Bike", 53m },
                    { new Guid("6225b289-6fc0-4e7f-aea6-1af7ef0549c2"), "Incredible Wooden Table", 57m },
                    { new Guid("62e58ec3-6875-436b-88bc-4bb2b727dbfb"), "Generic Fresh Chicken", 55m },
                    { new Guid("6357e80c-ea90-431b-b78e-2fdd8dde8980"), "Handcrafted Granite Fish", 49m },
                    { new Guid("63796282-dedb-4ea8-b1b4-33f5389d6b74"), "Refined Metal Chair", 52m },
                    { new Guid("645cd611-ab6a-4502-8ba0-b9569f650abb"), "Handmade Concrete Salad", 53m },
                    { new Guid("64a2d486-eb0c-45eb-8544-ccd274e08700"), "Intelligent Plastic Chicken", 56m },
                    { new Guid("64ba790c-055e-4b66-b11f-777648f39cf3"), "Licensed Cotton Hat", 49m },
                    { new Guid("64f4c5fe-8396-48d8-bdfe-8aafeb897cc9"), "Generic Fresh Pants", 54m },
                    { new Guid("65481b48-77ae-40b0-a052-9ef06984c4be"), "Practical Soft Cheese", 51m },
                    { new Guid("657149ca-51b9-4cbe-bf46-1209dfc461bb"), "Licensed Cotton Pizza", 52m },
                    { new Guid("65f3b7e1-85d6-4612-8617-0d2b84b03738"), "Rustic Cotton Fish", 54m },
                    { new Guid("6600d780-37a0-4b59-8b8a-bac6187bafe0"), "Incredible Plastic Keyboard", 55m },
                    { new Guid("6721b9cf-71db-4931-b7e2-af991c61bb04"), "Unbranded Rubber Cheese", 52m },
                    { new Guid("675dd608-4e3c-423a-af50-c991de0d3852"), "Gorgeous Metal Gloves", 54m },
                    { new Guid("67b8b0cf-6911-48e2-ac8d-d134bb1905c5"), "Handmade Frozen Ball", 54m },
                    { new Guid("6823ef2c-6f0b-415e-9874-7823ceedccd0"), "Practical Metal Soap", 54m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("68a0c05e-2ce2-49f5-81d5-19e6ed143179"), "Tasty Granite Computer", 52m },
                    { new Guid("68d6cbd3-9937-4018-91dd-e2624ab59259"), "Awesome Granite Chicken", 53m },
                    { new Guid("68f8a22b-d3ff-46ce-9a02-243b37dca838"), "Ergonomic Concrete Gloves", 50m },
                    { new Guid("690ca943-1141-4c24-8004-0f428629e049"), "Fantastic Wooden Chair", 51m },
                    { new Guid("69a09359-aff7-4407-808f-d3f4530af6fa"), "Refined Wooden Bike", 55m },
                    { new Guid("6a0d814f-b28e-45be-b80b-233f0d199c5f"), "Awesome Concrete Cheese", 53m },
                    { new Guid("6adc0ac0-7e4d-458a-ba02-9c4d73fe9922"), "Rustic Plastic Pizza", 51m },
                    { new Guid("6c06fcdc-7d64-4294-8220-685c8c14105b"), "Refined Fresh Soap", 51m },
                    { new Guid("6c7768b8-f94d-4773-ac22-18ffbef818e7"), "Fantastic Frozen Shoes", 52m },
                    { new Guid("6d25d25a-5394-4c6c-9d27-3812bab252da"), "Ergonomic Cotton Car", 49m },
                    { new Guid("6d8ce22c-2b09-4089-8a32-d30caea6a1d4"), "Unbranded Granite Computer", 56m },
                    { new Guid("6e0b75a2-ddd7-4b31-a8b0-1237eeaf8902"), "Rustic Fresh Bike", 54m },
                    { new Guid("6e4319b4-135c-422a-8369-a86c38b501b4"), "Small Granite Tuna", 50m },
                    { new Guid("6e709700-9ee3-4df8-a627-190d06c0820e"), "Handcrafted Steel Computer", 50m },
                    { new Guid("6ea20f22-0599-494a-9601-4abd54591711"), "Generic Fresh Chips", 50m },
                    { new Guid("703e492d-b954-45cc-9c8c-ef7e6841679b"), "Unbranded Concrete Tuna", 54m },
                    { new Guid("70404941-8d0e-452a-b968-07f982384b81"), "Handcrafted Steel Shirt", 50m },
                    { new Guid("70a74d1b-215a-4979-861c-452af293773a"), "Refined Soft Fish", 57m },
                    { new Guid("70b0378f-48d0-4e1c-bee7-674f11b8f878"), "Handmade Metal Ball", 57m },
                    { new Guid("711ace10-6c29-4a79-8af9-5b89700bdf96"), "Incredible Granite Towels", 52m },
                    { new Guid("71a77220-cc52-4ba0-976b-91d852cf24ce"), "Incredible Steel Salad", 57m },
                    { new Guid("72551552-9343-4ec0-9d28-7b3850030eaf"), "Generic Granite Keyboard", 53m },
                    { new Guid("72b1c161-1c5c-41ee-a83a-2d96c70cfc06"), "Practical Cotton Soap", 54m },
                    { new Guid("72e3e645-dbf6-4ae0-9f76-83f108567f3b"), "Ergonomic Cotton Chicken", 50m },
                    { new Guid("72fc47d8-bb80-4db8-8101-3f90a834f6f9"), "Licensed Frozen Mouse", 55m },
                    { new Guid("739ada7c-92af-4e0f-b483-f3fe14ce315e"), "Awesome Fresh Soap", 55m },
                    { new Guid("755e21fa-1005-49dd-be91-0ea7794d6830"), "Incredible Cotton Keyboard", 54m },
                    { new Guid("76e97616-1e4f-47b1-ab17-713a78b29511"), "Licensed Wooden Computer", 53m },
                    { new Guid("7757166c-432e-4170-9520-7282325f8461"), "Generic Cotton Car", 54m },
                    { new Guid("77e2de50-83bf-42a2-a482-f78b5b52ca5b"), "Unbranded Cotton Car", 51m },
                    { new Guid("783b4c9b-85be-48d7-8351-a596c19071d1"), "Ergonomic Frozen Ball", 50m },
                    { new Guid("78f34582-4a59-4582-89cb-c508c75e3958"), "Intelligent Frozen Bike", 50m },
                    { new Guid("79b6b4fe-8c16-4130-a5bf-2a620a918b1c"), "Handcrafted Steel Sausages", 51m },
                    { new Guid("7a1552de-0ab0-4d85-a05f-be110b9a4aba"), "Generic Rubber Fish", 57m },
                    { new Guid("7bb56e68-307d-41ed-b838-110d90ced411"), "Practical Rubber Soap", 56m },
                    { new Guid("7cb73ef5-0ab8-454c-b257-02769add8105"), "Gorgeous Steel Tuna", 49m },
                    { new Guid("7d4a093f-0bb4-48ca-962c-a603a1c19fee"), "Ergonomic Cotton Pizza", 50m },
                    { new Guid("7d6308fd-5315-4091-af29-0b949243cfe6"), "Rustic Concrete Chair", 49m },
                    { new Guid("7dc3fd23-8ded-4cc2-9c8d-bb05a18fbe0c"), "Small Frozen Bacon", 55m },
                    { new Guid("7dee21b2-761a-4cfd-8a74-9240de6106d9"), "Ergonomic Concrete Pizza", 54m },
                    { new Guid("7e599d1a-7de6-4ace-80da-7c788f6c1399"), "Fantastic Granite Pants", 50m },
                    { new Guid("7f4369d6-88b5-4a5a-8cb9-26901e3e42be"), "Generic Soft Tuna", 54m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("7fbfe976-c761-436b-b18b-84f4a0c44833"), "Tasty Metal Pizza", 50m },
                    { new Guid("800645fe-635d-4bb5-894b-0f790c948366"), "Unbranded Fresh Computer", 49m },
                    { new Guid("814e7d7d-6b27-45bb-b24d-7fdcfa2b8010"), "Gorgeous Steel Mouse", 54m },
                    { new Guid("81a8ef5f-d21d-49ec-9ffc-8a5a60955103"), "Unbranded Wooden Table", 51m },
                    { new Guid("821a828c-89e6-48c1-952a-b269712f4a80"), "Practical Plastic Tuna", 51m },
                    { new Guid("82cbd461-0807-462a-b913-99b8a7527d11"), "Awesome Fresh Towels", 54m },
                    { new Guid("82df3add-8831-47ab-b38e-ef0ac8857ab3"), "Incredible Rubber Salad", 50m },
                    { new Guid("839b4492-10b1-4e6a-9915-1850cf79eec4"), "Licensed Metal Shirt", 53m },
                    { new Guid("842582cb-065a-44c0-9ca1-76d4468c4cd4"), "Generic Wooden Pizza", 50m },
                    { new Guid("84651477-c645-4045-9840-07de6eded0fb"), "Ergonomic Rubber Shirt", 50m },
                    { new Guid("847f6056-b3a5-4148-9c8b-1cb7de305c7d"), "Licensed Granite Chips", 52m },
                    { new Guid("84c01664-4105-444e-a124-fc8b5bb03109"), "Refined Concrete Car", 50m },
                    { new Guid("8567dbaf-6bd1-43d4-bec1-bd55cd759362"), "Practical Steel Shirt", 52m },
                    { new Guid("857aa3c0-f8d7-40fc-a918-ddf2ba237794"), "Fantastic Frozen Car", 50m },
                    { new Guid("860cd92f-c6ca-44a0-a9d0-4bb489b41d34"), "Licensed Soft Pizza", 55m },
                    { new Guid("863dc5f7-1697-4bf4-9627-eb8e3ab14ed0"), "Handmade Wooden Tuna", 54m },
                    { new Guid("8687bf1e-1f8b-4fb6-b406-f1c95e4c7cbb"), "Fantastic Cotton Pants", 50m },
                    { new Guid("86928647-7a09-4acd-a9ff-f10f7d836036"), "Fantastic Plastic Mouse", 56m },
                    { new Guid("86fcf02b-e453-47d2-be43-fae0926da8be"), "Small Soft Chicken", 49m },
                    { new Guid("872849c1-d0a4-41d0-806e-6fa8b702e565"), "Generic Wooden Soap", 51m },
                    { new Guid("874bf8ab-ec5f-4bdc-8812-bb59ac22a9e8"), "Handmade Soft Bacon", 53m },
                    { new Guid("874e26c5-3f38-4a03-a1ea-10e62e420f98"), "Refined Frozen Sausages", 57m },
                    { new Guid("87b5396a-6746-4520-ba0f-b7a551476ef6"), "Handmade Steel Keyboard", 57m },
                    { new Guid("88235e43-5d31-4249-b292-a84dc5d35245"), "Intelligent Cotton Pants", 52m },
                    { new Guid("88a16f79-6088-48bd-a5e1-b0d18c42bfc3"), "Handcrafted Rubber Shoes", 54m },
                    { new Guid("8914f9ca-9959-4039-8006-287dc9b39619"), "Tasty Concrete Chips", 57m },
                    { new Guid("89a654a6-5b0e-4a75-8756-5559e84e21ce"), "Generic Fresh Soap", 53m },
                    { new Guid("89bc1793-cfd1-4acd-aab5-4ebcc6d11163"), "Generic Fresh Computer", 49m },
                    { new Guid("8aa79a02-3850-451f-9732-e18bcd15f2a6"), "Small Frozen Chips", 53m },
                    { new Guid("8adf2c90-6b21-4974-8229-68e16ff23a1d"), "Tasty Steel Chips", 57m },
                    { new Guid("8aefdf4d-c49b-4e37-8861-9c1666dd9c8e"), "Small Cotton Pizza", 52m },
                    { new Guid("8b525917-db38-4f4b-ba04-482fa105a571"), "Small Soft Ball", 53m },
                    { new Guid("8bc5d0aa-56a2-4279-a5ce-631eed7d1e58"), "Handcrafted Plastic Chair", 56m },
                    { new Guid("8c1f01a3-85f8-4098-90de-8d894309710c"), "Generic Soft Keyboard", 53m },
                    { new Guid("8cc96427-a17e-4443-98d4-625b2c16a8b9"), "Intelligent Wooden Computer", 49m },
                    { new Guid("8e1a20df-3e16-41bf-8f87-2c65ed6938bf"), "Unbranded Plastic Hat", 55m },
                    { new Guid("8e29c650-65e9-4409-aa9d-bc8cf8e85d2c"), "Unbranded Soft Chicken", 56m },
                    { new Guid("8e61f76f-d269-4859-a989-122b59a5aaf7"), "Intelligent Plastic Sausages", 55m },
                    { new Guid("8e6de47c-317d-4f39-b055-dc1eff7d2680"), "Gorgeous Fresh Fish", 56m },
                    { new Guid("8e8d00f6-c787-48f0-bcac-0670988815ac"), "Sleek Soft Keyboard", 55m },
                    { new Guid("8ff26872-66a6-48de-90b8-3653f29e6e4e"), "Tasty Metal Bike", 54m },
                    { new Guid("90354f46-a58c-4dbf-8cd5-f512df8e16c0"), "Gorgeous Granite Shirt", 49m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("9048b505-4dcc-4613-99be-fc28db50aeaa"), "Small Concrete Pants", 49m },
                    { new Guid("91510f32-de94-49e0-8fef-f1b3311f34ed"), "Sleek Granite Tuna", 56m },
                    { new Guid("917b6331-12c4-45c0-9928-cc494209e8e6"), "Unbranded Granite Chicken", 49m },
                    { new Guid("921d61c3-4a00-4e36-a3c3-c6da7a25b1dd"), "Handmade Frozen Soap", 53m },
                    { new Guid("927a0c9b-4abb-4805-8353-b876afd4c9ec"), "Practical Metal Sausages", 53m },
                    { new Guid("9283bc94-0644-4756-902d-f715e384ff57"), "Tasty Granite Pants", 51m },
                    { new Guid("92e99cdd-3de6-4701-8e7a-069997b7c4cc"), "Generic Metal Shoes", 51m },
                    { new Guid("9428779b-9d0d-4113-a4ae-af09c9bf34e1"), "Small Metal Chicken", 53m },
                    { new Guid("9484ca44-38d1-497a-b514-283916dd1ab3"), "Sleek Metal Mouse", 52m },
                    { new Guid("949ba657-8837-443f-bd4a-5654bbfe0cf2"), "Intelligent Fresh Towels", 55m },
                    { new Guid("9606fc25-e2c5-4ba8-b251-ffa21ed977c7"), "Intelligent Rubber Chair", 55m },
                    { new Guid("960f3095-0190-4933-9ad5-f3755f4ae491"), "Gorgeous Wooden Mouse", 49m },
                    { new Guid("9709c4d7-b199-47f6-897e-b0307cc53973"), "Incredible Rubber Chips", 57m },
                    { new Guid("975654ed-ebbe-43c9-9cd9-80666891ad8a"), "Tasty Rubber Keyboard", 50m },
                    { new Guid("9846e117-f6ec-488f-831d-080be659a1ee"), "Handcrafted Steel Shoes", 57m },
                    { new Guid("9857acb1-161d-45cf-b86f-c3f6d63e15d1"), "Generic Fresh Sausages", 53m },
                    { new Guid("987f2adf-dacb-4b62-b867-7e1f68bf3953"), "Unbranded Wooden Chicken", 57m },
                    { new Guid("9a18260a-837b-4d46-b493-e8e816f1928b"), "Fantastic Fresh Pizza", 51m },
                    { new Guid("9b358292-b2e8-4485-af0a-3f7c1b406bf7"), "Licensed Fresh Chips", 49m },
                    { new Guid("9bdb5036-a20e-42b6-88d9-fbaf7d7859cf"), "Awesome Cotton Mouse", 55m },
                    { new Guid("9c5d2efb-8525-4943-8b9b-b9574392af5a"), "Refined Concrete Chair", 54m },
                    { new Guid("9d194863-868e-4563-a703-783885908cbf"), "Awesome Fresh Chicken", 57m },
                    { new Guid("9d4250e0-7d0a-47ca-89c0-240fbbb65b5f"), "Intelligent Concrete Mouse", 56m },
                    { new Guid("9d58a037-809f-407d-8f22-cbe7dad70866"), "Awesome Frozen Tuna", 56m },
                    { new Guid("9d5c3935-5ff9-44ba-88dc-368963e30c96"), "Awesome Wooden Fish", 52m },
                    { new Guid("9d93cbc8-265c-40f3-a735-08b4045c8bfa"), "Sleek Cotton Computer", 49m },
                    { new Guid("9dd7c74e-c24f-4d0c-bd11-635cf29eb4e4"), "Practical Cotton Shirt", 56m },
                    { new Guid("9e67bea1-826e-4459-832c-64607f68f71e"), "Handmade Cotton Shoes", 54m },
                    { new Guid("9ea7657d-2626-4c88-a317-9c6cbc8ee8b7"), "Incredible Metal Fish", 50m },
                    { new Guid("9f2e927c-70c3-4de9-afb7-02f62aad3643"), "Tasty Wooden Car", 51m },
                    { new Guid("9f61af47-11cd-4c84-ae19-7853ba7b07fb"), "Handcrafted Frozen Table", 54m },
                    { new Guid("9fc27cf9-3496-449c-be49-ea28e9490e7b"), "Small Granite Salad", 53m },
                    { new Guid("a0672440-467a-48ef-af8c-d2e8c5f57e55"), "Incredible Wooden Shoes", 56m },
                    { new Guid("a1a737bb-565c-4136-beca-11d282c7cf4a"), "Incredible Granite Shirt", 51m },
                    { new Guid("a1c642be-46ea-493f-8c5b-f94aa7cd3abc"), "Handcrafted Cotton Gloves", 49m },
                    { new Guid("a2ee40dd-5f6b-482b-be0b-83ae8101c978"), "Small Plastic Chicken", 50m },
                    { new Guid("a2fca00f-cc27-4900-b711-acdd50c0b830"), "Practical Steel Computer", 57m },
                    { new Guid("a3809729-f68f-428b-8653-25ee8ee6870b"), "Handmade Metal Mouse", 54m },
                    { new Guid("a3fba45d-c13c-488f-b086-66eb594780f1"), "Practical Rubber Car", 55m },
                    { new Guid("a4632387-cce0-4bd7-a10f-53115a35f3b4"), "Licensed Plastic Shirt", 52m },
                    { new Guid("a4d3b7c4-85ed-4942-aa05-2a8016bfb624"), "Licensed Soft Bacon", 50m },
                    { new Guid("a52ec61e-329c-4724-b9b9-4c200593f8b0"), "Fantastic Fresh Towels", 50m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("a60afbfd-fc80-4470-8101-4624eda20c6a"), "Handcrafted Fresh Chicken", 53m },
                    { new Guid("a6e40f92-c7eb-414f-bf2b-b6f946b108fd"), "Unbranded Concrete Tuna", 57m },
                    { new Guid("a74aa544-9c93-4692-8019-4a596f2ee891"), "Ergonomic Frozen Hat", 53m },
                    { new Guid("a7dd02e0-ee4c-470e-b1fe-08836b6f9f7e"), "Awesome Cotton Towels", 50m },
                    { new Guid("aa3633fa-ee6c-4229-8e04-1d2ab3d99e49"), "Awesome Concrete Pizza", 56m },
                    { new Guid("aa707f39-f14f-4893-8a8e-5df77195fbbb"), "Small Plastic Pizza", 54m },
                    { new Guid("abc71b76-91ef-4e27-96be-09f30d0c20ba"), "Intelligent Metal Soap", 54m },
                    { new Guid("ad775596-8f3b-44eb-82b2-158cb38b0200"), "Handmade Steel Bacon", 57m },
                    { new Guid("af2e6f21-f268-43ac-9ed5-4c9e49d723b9"), "Awesome Granite Table", 49m },
                    { new Guid("afdaa389-cb13-42c2-9aad-6bf5f85c7b4c"), "Awesome Cotton Towels", 50m },
                    { new Guid("b0aaefc3-61eb-4c58-9a70-c0cca1bda4f8"), "Handmade Granite Tuna", 49m },
                    { new Guid("b0b1849f-1e45-49c3-a9f6-688483aad5a1"), "Gorgeous Steel Chicken", 55m },
                    { new Guid("b0dd70a3-f10c-4d98-ba0e-26cb6bee2765"), "Refined Cotton Salad", 55m },
                    { new Guid("b17b495d-10bf-4587-a1bf-0042d6af21af"), "Intelligent Cotton Cheese", 57m },
                    { new Guid("b23cfb10-60dc-4ea8-a773-a36c0823faec"), "Licensed Soft Bacon", 50m },
                    { new Guid("b306d69e-bfe0-4266-bdd3-25e2cbe216b5"), "Tasty Granite Chicken", 50m },
                    { new Guid("b3948c74-a4aa-4570-91d0-c857dc5b0e61"), "Incredible Concrete Tuna", 49m },
                    { new Guid("b4cd5f5a-a7cf-46c2-9a6d-d552df3016cc"), "Tasty Rubber Cheese", 54m },
                    { new Guid("b51b48f7-7307-479c-85c5-5fc12b9635b6"), "Intelligent Concrete Computer", 54m },
                    { new Guid("b52c6b10-09c0-4e1b-9ee0-faae0b78bd1f"), "Awesome Concrete Hat", 55m },
                    { new Guid("b6d0d86e-c944-4dc2-b338-da186355fc35"), "Gorgeous Frozen Keyboard", 52m },
                    { new Guid("b6d77806-fefc-4f37-92e4-97c0092811af"), "Sleek Cotton Bike", 50m },
                    { new Guid("b83fc760-4c05-4a63-831f-a7fb336c78ac"), "Awesome Wooden Hat", 55m },
                    { new Guid("b86ced3e-c40c-44cf-99dc-96d11f768653"), "Licensed Steel Car", 50m },
                    { new Guid("b8c9e237-92fb-4f65-922a-05c90c78894d"), "Handcrafted Concrete Bacon", 56m },
                    { new Guid("b96ba429-8209-4145-867e-be4a076d9cd3"), "Refined Wooden Mouse", 52m },
                    { new Guid("ba185299-ec9d-4300-b4ad-b298563bdcb9"), "Rustic Steel Salad", 50m },
                    { new Guid("ba189dd7-ac3c-4ead-9ac6-6761a7e7300d"), "Rustic Wooden Chair", 57m },
                    { new Guid("ba1d639f-8d71-4388-b58f-30ca7b5f1e66"), "Handcrafted Plastic Cheese", 54m },
                    { new Guid("ba2a7079-d219-47b6-8477-eb065eebd421"), "Generic Fresh Towels", 50m },
                    { new Guid("bc33db74-2cbd-40fc-a06a-7f02297e3fd2"), "Small Cotton Mouse", 55m },
                    { new Guid("bc499728-61da-400f-a9ff-c7649d29356e"), "Intelligent Fresh Car", 56m },
                    { new Guid("bc578718-855f-4c69-babf-860bc8d5c933"), "Rustic Soft Shoes", 54m },
                    { new Guid("bc72a968-d395-4035-ab02-0cabc7de9040"), "Unbranded Granite Bacon", 56m },
                    { new Guid("bccbf091-6cfa-460b-b58c-8680d159477b"), "Intelligent Steel Shoes", 55m },
                    { new Guid("bcdfc289-44c2-43a7-8507-8a333ab5032d"), "Fantastic Metal Shoes", 49m },
                    { new Guid("be96d1da-6d28-478e-8256-901202e003f2"), "Intelligent Frozen Sausages", 57m },
                    { new Guid("bee83221-7987-4de6-82c3-61d0f47f6f0d"), "Incredible Concrete Chicken", 54m },
                    { new Guid("befd94ac-c3c7-4c29-aa06-dd2ec87ea669"), "Practical Soft Fish", 49m },
                    { new Guid("c0168984-95eb-4b47-b3d2-11c7a3467675"), "Handcrafted Rubber Hat", 55m },
                    { new Guid("c0842b7b-a8d0-477e-9bd5-7414e9b94b7a"), "Gorgeous Concrete Ball", 50m },
                    { new Guid("c104ba02-fd26-4c18-b74d-d97c9a0f9008"), "Fantastic Metal Chair", 50m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("c1738630-1079-473c-b1b4-619f707f12f5"), "Handcrafted Plastic Fish", 57m },
                    { new Guid("c1c4972e-83c0-4055-89e7-c63d9b4aacb9"), "Refined Soft Hat", 52m },
                    { new Guid("c2020219-e750-4583-8fe9-6c2710e0e4b7"), "Refined Plastic Pants", 54m },
                    { new Guid("c23dfa22-567a-448f-8277-d9cc03c16845"), "Practical Steel Gloves", 49m },
                    { new Guid("c2620d90-0cd5-4697-ae28-928347ed4d9c"), "Generic Rubber Chips", 54m },
                    { new Guid("c2645582-07b9-4d57-9a64-d5911594ecd1"), "Refined Concrete Pizza", 56m },
                    { new Guid("c2c03071-bca3-4c11-bd9c-99a4eed43eb8"), "Incredible Cotton Table", 55m },
                    { new Guid("c35b14ba-1dbf-4d8f-8d3d-b6f3e2b1a8b9"), "Handmade Soft Chips", 55m },
                    { new Guid("c39e9753-a07d-4e1f-8a9f-d6a394826a26"), "Rustic Rubber Chips", 54m },
                    { new Guid("c40194e5-7aed-4b22-86df-31caf05a4f1e"), "Handcrafted Granite Pants", 54m },
                    { new Guid("c438abf1-4104-4d72-8304-d64d9c73e0c7"), "Ergonomic Frozen Keyboard", 55m },
                    { new Guid("c4814d43-8621-4fdf-9924-d8ccaddf3c87"), "Awesome Wooden Bacon", 56m },
                    { new Guid("c56204cc-7713-4bc8-89f9-043dfd5f9bba"), "Handcrafted Concrete Towels", 55m },
                    { new Guid("c5fb3cf3-2b62-4fa3-9a7d-85bfb944a6c5"), "Ergonomic Granite Soap", 51m },
                    { new Guid("c6b491fa-8c2e-4856-82a3-ea6e268b46d9"), "Gorgeous Concrete Car", 57m },
                    { new Guid("c812267e-e166-4cf8-99e5-9af7553c30a8"), "Handcrafted Concrete Car", 57m },
                    { new Guid("c8c181e2-08b4-4230-8626-bd98ba652ac1"), "Generic Soft Gloves", 52m },
                    { new Guid("c9741562-b3fe-4114-a0a7-1a0ac245e202"), "Tasty Wooden Chair", 54m },
                    { new Guid("cb0df304-1fa3-470a-b05f-e2edd7920e80"), "Practical Cotton Table", 55m },
                    { new Guid("cbef3c56-4052-416f-99bf-9ce1ed23eeb4"), "Small Steel Chips", 54m },
                    { new Guid("cbfbc2d7-34e0-4fd1-ba90-5b9ee816eb5f"), "Practical Fresh Ball", 57m },
                    { new Guid("cd7242c2-2f1c-40c7-9248-e668dc127d45"), "Ergonomic Wooden Chips", 50m },
                    { new Guid("cdb2a69e-c9d4-4db3-9508-107452832e4b"), "Incredible Concrete Table", 56m },
                    { new Guid("cdd54da3-eb0a-4e04-b05c-083b4e8eae31"), "Unbranded Granite Table", 55m },
                    { new Guid("ce0bcaa9-bc01-4ba0-bcb1-b8a2f27b3369"), "Generic Concrete Soap", 56m },
                    { new Guid("cf3bdfc0-cf12-48b8-8d60-f6d9f77bcae2"), "Awesome Metal Shirt", 53m },
                    { new Guid("cf62b8d1-c400-49ed-b309-7a0b6f42d3a3"), "Gorgeous Cotton Towels", 57m },
                    { new Guid("cfe7bbfe-8e8e-4e6f-965e-9c7134c15da2"), "Generic Concrete Fish", 50m },
                    { new Guid("d08a5fe7-4cad-4ae1-9195-fb8f7d88f59a"), "Tasty Frozen Keyboard", 56m },
                    { new Guid("d3151eca-6078-449b-92ef-63c365450eb7"), "Handcrafted Metal Towels", 56m },
                    { new Guid("d370580e-1d6e-4f7e-b436-6c43fa41c627"), "Sleek Concrete Bike", 50m },
                    { new Guid("d38ed64a-419e-4aae-86d5-615a3a0b86aa"), "Ergonomic Concrete Towels", 57m },
                    { new Guid("d3b9c558-433b-41de-bd2b-2d67895c0759"), "Incredible Plastic Sausages", 53m },
                    { new Guid("d3ec242c-3f43-4742-93c2-1cedb80f4328"), "Gorgeous Fresh Gloves", 49m },
                    { new Guid("d3ecb886-256a-4f2a-886c-01f46ed5a39f"), "Generic Plastic Pizza", 56m },
                    { new Guid("d406ba30-517e-4608-9253-f61c5c9d6c0e"), "Ergonomic Wooden Ball", 52m },
                    { new Guid("d4504d54-6313-4c90-86bd-36ace24b2b41"), "Refined Soft Towels", 54m },
                    { new Guid("d493e392-3386-4f97-82a9-35a23acde939"), "Intelligent Metal Car", 52m },
                    { new Guid("d619532e-d86b-494a-ae8f-163d7fdac0fb"), "Ergonomic Plastic Keyboard", 56m },
                    { new Guid("d6a6ef10-cead-4da4-b394-9267a5039a46"), "Tasty Concrete Computer", 51m },
                    { new Guid("d6fa6858-0690-42a3-87a7-7a4f6678398b"), "Tasty Steel Pants", 55m },
                    { new Guid("d6fa68fc-1e80-447d-b5a1-f6d16dfb14d8"), "Handmade Fresh Keyboard", 50m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("d78b98e7-26b8-4fb8-92b6-8216d642d8b3"), "Practical Metal Car", 54m },
                    { new Guid("d8296114-34dc-4a26-825f-9b8ca41e08fa"), "Intelligent Wooden Car", 55m },
                    { new Guid("d91629ee-b000-4c2f-b106-0a4eadd13da4"), "Awesome Steel Shoes", 56m },
                    { new Guid("dacc8a3d-850f-4c2d-aca6-437b8ce03f16"), "Generic Granite Bike", 50m },
                    { new Guid("dc1613cb-d868-419f-903e-7fa1120466c2"), "Unbranded Concrete Hat", 54m },
                    { new Guid("dda41ff9-09cc-46fa-a82a-133355e396cf"), "Gorgeous Granite Mouse", 51m },
                    { new Guid("ddf3cd63-be59-4b21-8f2d-faf899fe3766"), "Sleek Concrete Keyboard", 53m },
                    { new Guid("de255be3-f45c-4bea-8486-402178a5f1d1"), "Ergonomic Concrete Gloves", 50m },
                    { new Guid("de5179a6-564e-4d72-9084-0e09320bb55d"), "Refined Soft Table", 54m },
                    { new Guid("dede6d29-a84e-4f0d-887e-6fabc3336091"), "Incredible Cotton Soap", 50m },
                    { new Guid("def3dbd6-8e09-4f35-b663-27eb188b08c1"), "Handmade Granite Shoes", 54m },
                    { new Guid("df533875-5049-4b0f-9849-d29f2c62bd2d"), "Refined Plastic Gloves", 56m },
                    { new Guid("e1452ecb-4988-4813-8240-8e30f7a78b1e"), "Fantastic Soft Hat", 52m },
                    { new Guid("e14551e6-65c3-4bc0-9f1b-fb95cb51944b"), "Unbranded Rubber Bacon", 51m },
                    { new Guid("e183d4d5-3fed-46c4-899f-4ad9bcafc9c0"), "Gorgeous Concrete Bacon", 52m },
                    { new Guid("e1ae4d3a-758b-45bd-9c5a-e08cf6aeb6d4"), "Licensed Fresh Soap", 57m },
                    { new Guid("e1c88c1e-5998-4f10-9750-9ff52d7acff4"), "Handcrafted Concrete Sausages", 52m },
                    { new Guid("e1dadb60-6621-4ac0-9ce5-8f6b01376cba"), "Handcrafted Fresh Sausages", 52m },
                    { new Guid("e2839f24-2388-4f4e-92a1-6ccf179dfdf8"), "Small Wooden Table", 57m },
                    { new Guid("e393d8f9-484d-4c28-8d46-10b80dbf445c"), "Practical Plastic Table", 54m },
                    { new Guid("e492fd43-8c8e-452a-997b-d0e1346f5e19"), "Sleek Rubber Gloves", 53m },
                    { new Guid("e499d2a3-662e-47c9-abef-81d8ab1e68e9"), "Intelligent Rubber Chair", 49m },
                    { new Guid("e4cf3c91-d77c-4567-831d-ef2863dc693d"), "Gorgeous Frozen Mouse", 50m },
                    { new Guid("e546b9af-64b0-4df4-bcd3-0f7715926432"), "Handmade Wooden Table", 56m },
                    { new Guid("e60b3413-bcc4-43d5-aaf9-b2d6ee1caaa8"), "Practical Plastic Fish", 55m },
                    { new Guid("e660657d-a09b-42f7-b86b-36784fcaa2fa"), "Incredible Rubber Car", 51m },
                    { new Guid("e67a2a88-8308-4bf0-ad7e-4fc2a6d072a4"), "Rustic Metal Pants", 52m },
                    { new Guid("e7f8375b-d116-415e-a751-d445627b1ae8"), "Ergonomic Granite Mouse", 55m },
                    { new Guid("e8797a79-ed1a-487b-b80a-de8211db2340"), "Licensed Plastic Shoes", 56m },
                    { new Guid("e8b99dfe-0f2b-4cfa-bdcf-502e1a00c7a1"), "Unbranded Concrete Gloves", 53m },
                    { new Guid("e92f4032-33e9-47e4-bf3c-351d86a2951c"), "Generic Concrete Chair", 53m },
                    { new Guid("e94ab8b8-9f61-4ef4-a751-566470aca200"), "Generic Metal Bike", 49m },
                    { new Guid("e98ac0bb-4fb9-4d82-a0aa-7ebe92fea288"), "Rustic Wooden Salad", 57m },
                    { new Guid("e9ee6ae5-af97-4022-96d4-71cc1a34f9d9"), "Intelligent Rubber Fish", 49m },
                    { new Guid("eba69462-4537-4f23-bbf9-13b3a9edf6c9"), "Handmade Soft Chips", 56m },
                    { new Guid("ebf426b1-b663-4904-8c25-708bf7b21e80"), "Rustic Cotton Shirt", 50m },
                    { new Guid("ec22bb68-a40e-4489-b61e-b5d586cf2ed7"), "Generic Fresh Hat", 51m },
                    { new Guid("ec884bde-dcab-48d1-b70d-9035fa5a4567"), "Unbranded Granite Shoes", 57m },
                    { new Guid("ed37f1e7-6ad3-43a7-b0a5-4c07332da528"), "Sleek Plastic Towels", 54m },
                    { new Guid("edf62bb5-3f24-4c07-b181-dff0c0597e85"), "Handmade Steel Pants", 49m },
                    { new Guid("eebd387d-1b9f-469d-8401-0363317d81a2"), "Unbranded Cotton Sausages", 54m },
                    { new Guid("eec2a82c-4397-493b-aa16-9fc726dd29ef"), "Licensed Concrete Chair", 55m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("eedda879-e71e-48c6-8469-e6a7e8ea82d2"), "Ergonomic Frozen Chips", 57m },
                    { new Guid("ef910380-3472-4298-b0fa-ca8fa813892e"), "Awesome Cotton Bike", 49m },
                    { new Guid("efa5f4a0-016a-475f-9ec6-2b7509785bb9"), "Fantastic Plastic Bacon", 57m },
                    { new Guid("f0615dfa-38c4-4d17-913d-bb0f345eab33"), "Handmade Wooden Bike", 51m },
                    { new Guid("f0f40d95-76a3-476f-99ee-88df0538c381"), "Incredible Metal Shoes", 55m },
                    { new Guid("f14879dc-2c55-44a7-87cd-83380e16b4c4"), "Small Concrete Shoes", 56m },
                    { new Guid("f1ad78a1-9698-48c0-8b53-84147484e6a9"), "Tasty Cotton Shoes", 53m },
                    { new Guid("f1fe9048-3f37-4606-9c0d-a0c894a2c961"), "Refined Plastic Bike", 54m },
                    { new Guid("f262f894-47e0-4965-bc16-378b5fb166e3"), "Refined Concrete Soap", 52m },
                    { new Guid("f33d0d3d-4808-4eec-8701-46a0673cdd04"), "Licensed Metal Mouse", 53m },
                    { new Guid("f378869b-158d-4073-b78e-cc9b40b174db"), "Tasty Wooden Gloves", 52m },
                    { new Guid("f3b6920a-c00d-43fc-bcee-9f42792a4def"), "Intelligent Concrete Hat", 52m },
                    { new Guid("f41f3eee-4c05-4bd2-86df-c448e0214d54"), "Small Cotton Table", 52m },
                    { new Guid("f4c68c7a-c0bb-4dc3-8493-89aeb5577ee2"), "Licensed Concrete Chair", 50m },
                    { new Guid("f5535247-bac5-485f-9a46-4dbc9c359a4c"), "Handcrafted Fresh Bacon", 52m },
                    { new Guid("f567e94e-44df-4e38-a7f3-2cbe16c817f8"), "Rustic Cotton Soap", 57m },
                    { new Guid("f656320d-154d-4a6a-8dcc-4bf57214bf37"), "Small Fresh Keyboard", 52m },
                    { new Guid("f6632c58-41fb-48bf-9f0f-0f9525f70128"), "Tasty Fresh Chair", 56m },
                    { new Guid("f6aa63c5-1d98-4bfd-b0ac-1041c33e3b6b"), "Rustic Concrete Bacon", 56m },
                    { new Guid("f6d40b65-31c3-49b1-823b-0cf1263d04a9"), "Handcrafted Metal Computer", 55m },
                    { new Guid("f75b2482-5780-4ba5-a15d-e625ad47851d"), "Intelligent Metal Ball", 55m },
                    { new Guid("f7a7e0d9-dd9e-4c01-829b-c00f7409c3ae"), "Small Frozen Sausages", 49m },
                    { new Guid("f7c022cf-355f-4f47-ac18-1af4684617ee"), "Tasty Fresh Sausages", 50m },
                    { new Guid("f8e57136-cb54-447e-89a0-733d410274b1"), "Generic Plastic Towels", 49m },
                    { new Guid("f9e4f18e-5ac4-4520-bfb5-f1ccb63bbf94"), "Gorgeous Frozen Fish", 50m },
                    { new Guid("fa9dc1b6-fbad-4593-8db2-367a58c8f47b"), "Fantastic Concrete Table", 51m },
                    { new Guid("fb4d01b2-5d8d-4cbc-97a7-075f88d63189"), "Practical Plastic Ball", 51m },
                    { new Guid("fb6d61fb-893a-491c-94bd-9166ec315350"), "Sleek Metal Bike", 56m },
                    { new Guid("fc18c236-f70a-4fa8-93ce-aa91e7b04c23"), "Practical Concrete Pants", 56m },
                    { new Guid("fce6b2f4-0acd-4bd8-844b-caf4aa4c8cb1"), "Fantastic Wooden Bike", 51m },
                    { new Guid("fd3c408c-6218-43e8-b0d7-833830d94a1e"), "Ergonomic Steel Shirt", 52m },
                    { new Guid("fe375c70-4bdb-4a0e-b2be-f239fee9f248"), "Licensed Granite Chicken", 54m },
                    { new Guid("fe4224a9-d47f-49d3-b63e-f7a9e22fd144"), "Incredible Soft Sausages", 57m },
                    { new Guid("fe490b5d-fa4b-4184-a3b9-634d402eff48"), "Rustic Wooden Table", 52m },
                    { new Guid("fea80d5d-0435-4bcb-8581-f2cef0ba0bbb"), "Licensed Wooden Pizza", 53m },
                    { new Guid("fec38e22-31d0-4822-b05e-61210b5b9f45"), "Handmade Steel Pizza", 56m },
                    { new Guid("ffacd285-e2e6-4675-8f23-11cb20bc968b"), "Ergonomic Fresh Ball", 57m },
                    { new Guid("fff19c91-e5b0-4c9d-963f-33232d540829"), "Gorgeous Rubber Sausages", 55m }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { new Guid("00c542c6-5103-4b88-a5ad-a1c7085ecc83"), "Judd", "Balistreri", "4330515" },
                    { new Guid("012b15f4-8fdc-4560-a2c9-d681a82f0193"), "Freddy", "Breitenberg", "1398696" },
                    { new Guid("01302dc1-dc2a-428a-972b-2e577e969328"), "Ephraim", "Powlowski", "3512636" },
                    { new Guid("0168a5ef-08ea-48e5-a7b9-f61a0a721039"), "Earlene", "Hammes", "2283406" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { new Guid("0276138c-2bf3-4896-87d9-6dc15c4d4c59"), "Shania", "Lehner", "3946082" },
                    { new Guid("02d02ea9-0241-40b9-9125-3d5b5ecab94f"), "Abdul", "Hoppe", "0405612" },
                    { new Guid("03a44249-81ca-47f8-80d0-ef3eb496c6e1"), "Janiya", "Purdy", "4498275" },
                    { new Guid("03cfc178-4057-4320-97db-b04badbb2b47"), "Idell", "Gleason", "4916356" },
                    { new Guid("043672a4-e4f6-4867-8c45-915784f489c2"), "Aliza", "Cruickshank", "4031877" },
                    { new Guid("046035af-6812-4776-af3e-96f5f9eb69e5"), "Marielle", "Cartwright", "9822112" },
                    { new Guid("048410a1-0dee-4bd0-80e6-30f734c2899a"), "Keeley", "Lynch", "6332091" },
                    { new Guid("048f1b75-a3cc-4d9d-8d1c-9f09edb02ff8"), "Jacinto", "Fisher", "4272205" },
                    { new Guid("061cc683-7511-4b3f-ab41-48f28664042e"), "Horacio", "Cronin", "3681602" },
                    { new Guid("0621195d-4a7e-4570-a822-958906a196d5"), "Providenci", "Keeling", "6624538" },
                    { new Guid("064bc469-6646-4a69-9a79-ed3a2f2f63a0"), "Angelina", "Satterfield", "9428975" },
                    { new Guid("067c01d4-9e11-4ee5-8737-67243f6c35fd"), "Annetta", "Schultz", "0291535" },
                    { new Guid("07077eec-b39d-4218-8464-da0937be6459"), "Lexie", "Macejkovic", "7428860" },
                    { new Guid("07ca786a-be55-4ee8-96dd-9c3b9c8818c1"), "Maximo", "Shields", "0211257" },
                    { new Guid("080d526f-8fb2-4d50-83a6-146c6c2dc699"), "Destini", "Nolan", "7291137" },
                    { new Guid("08af178e-1865-49ff-ab7c-5095abe8e2cf"), "Krystel", "Ortiz", "5462496" },
                    { new Guid("08d4fb8f-dcac-48e2-8c00-827d81f18593"), "Gust", "Rath", "4083533" },
                    { new Guid("096256df-da4c-4fab-9682-2a74ceda573d"), "Katlynn", "Beier", "8732081" },
                    { new Guid("09828a42-0f87-4cdd-a2a0-ff48afca2d36"), "Magali", "Goyette", "9327654" },
                    { new Guid("0a3ee9be-b9f0-465c-b9cf-46974a2da0dd"), "Jed", "Mraz", "1363499" },
                    { new Guid("0ab2f248-ddc9-4e5a-aa6a-1a9d6c50aab9"), "Jaleel", "Okuneva", "5063767" },
                    { new Guid("0ac02e0c-b9ac-4926-8ce6-69163c88e7aa"), "Mallory", "Dooley", "9023398" },
                    { new Guid("0b0e7f66-7dc0-4d50-80d5-0eefcab918cb"), "Mireille", "Lakin", "0389334" },
                    { new Guid("0b2555f1-cf31-4706-a72f-7deb67d34c5f"), "Magnus", "Metz", "8950205" },
                    { new Guid("0b592e8e-0184-4dec-83b6-dde70709abf3"), "Verona", "Ratke", "8677661" },
                    { new Guid("0b6056fa-3bf0-46a3-adb4-db0c3812c19f"), "Keara", "Champlin", "9399942" },
                    { new Guid("0b8e143d-8288-4a3f-b074-1a7d17f66aa9"), "Jett", "Champlin", "3370757" },
                    { new Guid("0c26392d-30b7-42cc-8eb5-0780dfdc5b51"), "Jordyn", "Mayer", "5227819" },
                    { new Guid("0caa8135-c46f-4c5b-b19c-99288b58aa64"), "Dominic", "Zboncak", "3053622" },
                    { new Guid("0cbbe7fe-7739-45e4-b74a-9eef0c0d1c54"), "Adolph", "Douglas", "9077748" },
                    { new Guid("0dd7fa01-f5c4-4efa-9e90-7971a47bbb9c"), "Judson", "Yundt", "6405001" },
                    { new Guid("0df669f7-1e1a-45c3-b1db-49a8828d8dbd"), "Lonny", "Bednar", "7592007" },
                    { new Guid("0e3646b9-07f3-4807-84dd-5ce401ecc3a2"), "Javon", "Schaden", "6497256" },
                    { new Guid("0ed3ffd9-14d3-4edc-be40-799587855334"), "Ally", "Kassulke", "8466152" },
                    { new Guid("0f3b2512-e952-40e6-86cf-bb6943474337"), "Larissa", "Kuhn", "9724063" },
                    { new Guid("0f4860ff-7be5-4558-9a75-1e7d3f129d04"), "Micah", "Rohan", "6399330" },
                    { new Guid("0f49fdc5-9b74-42d7-a6ec-4a6696eda216"), "Karli", "Balistreri", "5412476" },
                    { new Guid("0f528f4d-1f92-4ea1-ba04-1888e59ae189"), "Raheem", "Harber", "9487691" },
                    { new Guid("0fe0776c-fe6e-4094-b57c-3ed704dc453e"), "Geovanny", "Anderson", "1421598" },
                    { new Guid("10576b9a-3bb0-4e53-b87a-10e1c92294f7"), "Rubie", "Schultz", "4075028" },
                    { new Guid("11b0768b-0017-4dff-b81c-d6a624cff0c8"), "Theodore", "Gleason", "5996132" },
                    { new Guid("11c50dc3-fb1a-40b7-b0d0-a53f191019fe"), "Colten", "Jenkins", "4846694" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { new Guid("11c96990-c470-4f15-a522-e34365574d87"), "Laney", "Predovic", "7192932" },
                    { new Guid("124e2454-62b8-4124-b988-6fa1495e5ee2"), "Mohamed", "Kemmer", "9072633" },
                    { new Guid("13133674-565e-412c-b73a-827066dd8db1"), "Jaiden", "Ondricka", "9670014" },
                    { new Guid("13b1ec91-35e9-4bab-8195-f1109550ffcb"), "Abdiel", "Conn", "9518993" },
                    { new Guid("13cc36ad-a529-431d-b772-c2848a22edc9"), "Brandt", "Kilback", "5489534" },
                    { new Guid("14409857-3513-4e48-a05b-17f6640b5d79"), "Hunter", "Murazik", "1056859" },
                    { new Guid("14fa6844-2d13-44b9-baae-7b4b7609e98f"), "Maximillia", "Senger", "0796763" },
                    { new Guid("15319334-a0c5-4c62-86d0-f1d53bff3489"), "Hassie", "Friesen", "5864540" },
                    { new Guid("161e98b2-542f-4007-ae60-f97413fcf414"), "Clint", "Rau", "6234606" },
                    { new Guid("16ceb7fd-0567-48e5-a113-f4eb2d03a95f"), "David", "Reichert", "8152767" },
                    { new Guid("17319665-eee5-4df9-98b4-0f54631eda80"), "Isabelle", "Schultz", "6242635" },
                    { new Guid("17ab93a7-571e-4d39-90fe-a28e27fd4dd9"), "Kim", "Moore", "3009396" },
                    { new Guid("19df6af6-edc9-41eb-9780-c9673a802646"), "Vernon", "Spinka", "0088115" },
                    { new Guid("1a337000-86fb-41ee-b1bb-d86055e93289"), "Winnifred", "Hettinger", "9604854" },
                    { new Guid("1a84014c-e088-41e0-89cb-02c32e527924"), "Talia", "Stracke", "2481140" },
                    { new Guid("1aea8ffd-2a29-49e6-b773-cccab31eafe3"), "Toni", "Anderson", "0199956" },
                    { new Guid("1b11aed1-7564-4fab-bec0-cc39d0673529"), "Aliya", "Bauch", "3331781" },
                    { new Guid("1b8de86a-b590-4320-a38a-ba3231cd764e"), "Myah", "Goyette", "7063542" },
                    { new Guid("1bfc02af-a0dd-458c-b40c-c4d612eab8dc"), "Tyrese", "Dickinson", "4245178" },
                    { new Guid("1c56a551-ca7b-4067-a326-e4e94dc2ed7a"), "Delbert", "Armstrong", "2136033" },
                    { new Guid("1c638e80-5f22-490a-b4bf-3213af682346"), "Newton", "Smith", "9435619" },
                    { new Guid("1d64c5da-74ad-4f88-b097-60b04454da81"), "Guiseppe", "Olson", "0607559" },
                    { new Guid("1e1b6578-f492-4dd3-8884-a6fc0fd5239f"), "Jettie", "Barton", "0988280" },
                    { new Guid("1e9d94ec-ebc8-498e-9dff-b8754b68b0fd"), "Gerhard", "Bernier", "2462651" },
                    { new Guid("1f4d765f-71a2-4ef4-b8f5-c08425884601"), "Marjolaine", "Hintz", "9325762" },
                    { new Guid("1f9ba06b-581b-470c-b47a-22354286257d"), "Anderson", "Orn", "1856741" },
                    { new Guid("21861fa1-c4c6-4356-9e41-5c6bf81404d1"), "Marlee", "Braun", "4704330" },
                    { new Guid("21da895f-bf7a-4d5a-93b7-6e6fed2f1b2c"), "Reynold", "White", "6376572" },
                    { new Guid("224171e1-1830-464d-a8fd-79f1500a5677"), "Dulce", "O'Hara", "4046852" },
                    { new Guid("22a44a7e-3984-4501-acb9-fb4566f3c7a2"), "Bertrand", "Conroy", "7633473" },
                    { new Guid("22ca813b-27c4-4049-abc4-a33109557412"), "Joaquin", "Bins", "0982929" },
                    { new Guid("2360aefc-d15f-4422-93ee-afdb0ae5347d"), "Charlene", "Will", "9818540" },
                    { new Guid("239a0e9a-d389-4f0e-8d53-b586d097319c"), "Rudolph", "Bode", "4709536" },
                    { new Guid("239cebd3-9967-434b-8d53-3867f492cd02"), "Destin", "Swaniawski", "0174458" },
                    { new Guid("23feb8af-3f7b-4a14-a10a-98cf431206f4"), "Adele", "Ryan", "1271233" },
                    { new Guid("24a31b98-245c-41c6-9acf-936c57032173"), "Toney", "Emard", "7985820" },
                    { new Guid("24c9a35c-2a01-49ce-9268-551ddcde0749"), "Marion", "Lynch", "7851850" },
                    { new Guid("24ec270a-ef07-4b57-a297-c34d65257c64"), "Hassan", "Lynch", "9958106" },
                    { new Guid("25609b04-0c2b-43f2-9783-826a59c477ea"), "Marlee", "Gerhold", "1601055" },
                    { new Guid("26151bca-5ad5-489f-988a-811df8b36739"), "Kelly", "Bode", "4130710" },
                    { new Guid("2681a6ec-df60-4571-9303-e3ed20c41162"), "Devan", "Tromp", "3575815" },
                    { new Guid("26f0cfea-8907-484f-9146-ed57d5b0caf3"), "Dagmar", "Conn", "8966993" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { new Guid("270ecddf-9907-42fc-bc9b-942d0cc12307"), "Tod", "Towne", "6822018" },
                    { new Guid("27305457-fab8-4739-a81e-85072c3ad7bc"), "Maye", "Conn", "9180787" },
                    { new Guid("27645926-9873-46dc-8e61-766f60eb1286"), "Kaleb", "Bergnaum", "8492048" },
                    { new Guid("279c804a-e982-43d6-ac4c-c0a8b09f6cf7"), "Guy", "Sanford", "4166889" },
                    { new Guid("27fcdc89-c1eb-4dd0-bf83-09635f277250"), "Aimee", "Nolan", "9776560" },
                    { new Guid("280ded32-b1e1-4bb2-94b3-9311728d75d4"), "Jamie", "Schoen", "5337420" },
                    { new Guid("28694b9f-334d-491c-9bbc-c2cf57d2de21"), "Cornell", "Cassin", "6223263" },
                    { new Guid("28a78bc0-9e79-4915-8e06-45c7f5a6d224"), "Gonzalo", "Rempel", "4657659" },
                    { new Guid("2935585e-51d1-4007-be4d-b917970f2100"), "Rupert", "Gorczany", "0701126" },
                    { new Guid("2ab2a6ac-6979-4484-b2a5-f637de264bec"), "Karson", "Koch", "1629891" },
                    { new Guid("2b08e143-0ea6-4e97-bc71-f9aa1c6dad78"), "Berenice", "Upton", "8703580" },
                    { new Guid("2ba43783-8d8f-4daf-887b-eb8231b62790"), "Leola", "Abernathy", "8660607" },
                    { new Guid("2bb458c1-b318-497a-a83c-16b271b6542b"), "Jorge", "Bashirian", "3243020" },
                    { new Guid("2bd769d5-4c31-4a7d-9cd4-3834cc0f4361"), "Bertrand", "Orn", "2737638" },
                    { new Guid("2bd8a20b-5e13-4419-aa97-ddb7e61426aa"), "Horacio", "Hudson", "4295860" },
                    { new Guid("2c3a7308-923e-4d08-97cd-c9a7484caf4d"), "Tyrique", "Schiller", "6620196" },
                    { new Guid("2ccdd34c-2480-42f9-a61a-3a6a102125c4"), "Adrienne", "Stracke", "1385604" },
                    { new Guid("2ce0809f-ad99-46ab-bf53-75db24355ce8"), "Theron", "Howell", "3771677" },
                    { new Guid("2dde15e1-3e0d-4757-abd9-4489ee2ee0e7"), "Dante", "Hamill", "4555557" },
                    { new Guid("2ebab0ca-259f-4e1a-a4b6-cee82119042e"), "Joy", "Murazik", "2095077" },
                    { new Guid("2ecb3cb1-f836-4bbf-bc4b-7124f2fc2f11"), "Elenor", "Runolfsson", "0480828" },
                    { new Guid("2f361cdc-32ae-4829-83cb-ef2a54323786"), "Ciara", "Funk", "4364723" },
                    { new Guid("30299db5-4efe-4c3f-ab8f-9f09dfdd5df1"), "Chelsie", "Beahan", "6929632" },
                    { new Guid("310e1e36-f647-43fb-8ce4-c209745cd7c7"), "Lucas", "Rutherford", "9384279" },
                    { new Guid("315df441-a3c9-490f-a3c0-1f32b7706489"), "Spencer", "Anderson", "6180428" },
                    { new Guid("31ace127-2593-4cb6-a16f-67cc9b80f42f"), "Dulce", "Schneider", "1365141" },
                    { new Guid("3256fdfd-5743-4dd4-a1a6-2c5bd6cc243d"), "Xavier", "Schaden", "8958313" },
                    { new Guid("325a9cfc-4ec9-493a-927a-482a59fca9ae"), "Amani", "Walter", "2640495" },
                    { new Guid("32818134-73ff-4388-825c-508f889916d1"), "Chasity", "Hermiston", "6857163" },
                    { new Guid("3289ef2a-9ee6-42c6-97af-413a06de42db"), "Shaun", "Davis", "8341248" },
                    { new Guid("3369702d-5c62-4807-b374-210c95dc39b9"), "Kitty", "Hickle", "7152576" },
                    { new Guid("33b72add-cf21-4276-bce4-63960b39a8cb"), "Bennie", "Wisoky", "4281867" },
                    { new Guid("33e05925-26de-4aa2-8994-329bde50ff3f"), "Gussie", "Carroll", "1420893" },
                    { new Guid("33e88d50-d359-4d5f-ba91-9071e3534bb0"), "Laurence", "Beatty", "1162766" },
                    { new Guid("34091a99-ee0e-41a7-a57a-8a9a869bb98e"), "Julianne", "Quigley", "2074073" },
                    { new Guid("34916f83-236e-49bb-94c9-cea28a98de51"), "Marcelina", "Huels", "5799288" },
                    { new Guid("35fa5712-3825-4e9f-95f9-7f08fad6bd94"), "Else", "Leuschke", "3859546" },
                    { new Guid("36709e0d-0925-4f2f-8fb7-90ebd20f6436"), "Orland", "Bergnaum", "1462073" },
                    { new Guid("36e89e82-1c3a-4416-af56-549a0e082ae9"), "Reggie", "Nicolas", "2108420" },
                    { new Guid("37276f2c-1c2a-4859-8854-901994ca2d76"), "Garth", "Stroman", "7525664" },
                    { new Guid("37580de0-b847-4c22-8d04-1b33c5221b1c"), "Kaya", "Stroman", "3292994" },
                    { new Guid("37606adb-e5e8-41eb-aeb7-519909614197"), "Clint", "Turcotte", "8600445" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { new Guid("37e4c027-05c0-40a6-a02a-618d6235ffbf"), "Micah", "Pfannerstill", "4267869" },
                    { new Guid("381e24e5-246d-4575-a700-f3d6efaf21e6"), "Charity", "Rodriguez", "8655154" },
                    { new Guid("38ed128d-b387-4de0-bb3a-94f7863bf3f7"), "Melba", "Kirlin", "8286042" },
                    { new Guid("3a7a5c52-fa80-4518-bd40-ac7d889f3b54"), "Easter", "Kunze", "5630656" },
                    { new Guid("3cbdbadd-5662-49ca-9892-867c09827f37"), "Hester", "Abshire", "8368835" },
                    { new Guid("3e22768c-6406-47fc-8a17-a0a7cbbed4dc"), "Elena", "Kassulke", "6765655" },
                    { new Guid("3f3c903e-3714-4166-a387-7f304e0a3c8b"), "Ashton", "Hand", "2933319" },
                    { new Guid("400283d5-80c4-4a14-99f9-39e868a7311e"), "Gerry", "Kulas", "9705887" },
                    { new Guid("40819dd9-0ca2-4a6e-a375-13500407490c"), "Merle", "Rice", "7342930" },
                    { new Guid("40e0ae9f-1a18-4154-8f4b-70b5878172c3"), "Ramona", "Greenfelder", "9587165" },
                    { new Guid("40efd470-424b-4350-8707-5d578781dd06"), "Lucienne", "Shanahan", "2996102" },
                    { new Guid("4141cc0a-6cf6-4bc0-a5bd-b34851aa0219"), "Guadalupe", "Oberbrunner", "8094652" },
                    { new Guid("4167327d-35e9-4a70-ab17-d0e2d12e942d"), "Lexi", "Abshire", "6660373" },
                    { new Guid("4216dbe0-7a16-4de5-b44a-d4658a03ef92"), "Ciara", "Will", "1888812" },
                    { new Guid("424a4b59-294f-47ed-82fd-21668b0ba1dc"), "Kennedy", "Cole", "3225155" },
                    { new Guid("4356f819-7b05-46c4-a1c9-1ad732249578"), "Maiya", "Kihn", "8308985" },
                    { new Guid("438435e4-c95f-4ce1-bdea-fa96c9f87cc3"), "Vergie", "Mante", "1886902" },
                    { new Guid("43e22ca0-5605-473a-8c99-a45163055822"), "Olaf", "Macejkovic", "1678002" },
                    { new Guid("4411b822-4766-4d93-83d3-2fbd4cbf3447"), "Mable", "Dooley", "3064069" },
                    { new Guid("44cffeea-fe48-4e1e-8495-7ba561d24a4d"), "Thora", "Lehner", "4335752" },
                    { new Guid("45a2ef44-f22d-4855-bfc6-4ee2f9f7957b"), "Rosalia", "Reilly", "6646723" },
                    { new Guid("4642c13c-57a3-42f3-9d71-10fb018688b8"), "Taurean", "Mitchell", "6789707" },
                    { new Guid("46f5e919-5c62-438d-9927-260692546c9b"), "Sherwood", "McLaughlin", "5898375" },
                    { new Guid("47421fcf-1cef-4ef2-8a6c-d812e1f602f0"), "Esta", "O'Kon", "1299579" },
                    { new Guid("47b1d45e-1512-46cc-b65a-ba5e3047ff07"), "Ivory", "Swift", "8274240" },
                    { new Guid("487e6d89-0701-4e0f-92f8-d2f49a300df5"), "Maria", "Beier", "9073387" },
                    { new Guid("48efe59a-cedc-4aa7-9613-381b9ebdaa77"), "Alyce", "Graham", "2464155" },
                    { new Guid("4a4cfe83-1c6f-43b6-8485-9b8d1ca67e2e"), "Noe", "Daniel", "4471505" },
                    { new Guid("4adbd9bc-fa68-4841-ad03-986240d45f0f"), "Marianna", "Cassin", "6550182" },
                    { new Guid("4b39b859-e0d9-4d87-b716-bbfc671ddd1a"), "Belle", "Heidenreich", "5835292" },
                    { new Guid("4c38286a-857d-49d6-98be-faa21aea0f62"), "Amelia", "Douglas", "4878208" },
                    { new Guid("4e1ac5d2-96da-4889-b546-ce326f34f240"), "Ciara", "Goldner", "7930669" },
                    { new Guid("4e932225-47d8-40ce-983a-14aecc162f57"), "Seth", "Collins", "1933943" },
                    { new Guid("4eb4192b-0a3d-4172-9e03-89f885ee593b"), "Abby", "Ruecker", "3619893" },
                    { new Guid("4f32fe31-594f-4011-a37f-27fd60782446"), "Judson", "O'Keefe", "5259779" },
                    { new Guid("4ffbf040-7025-4328-a8ed-8d7623b22242"), "Kathlyn", "Balistreri", "3108010" },
                    { new Guid("5121c241-2861-4959-9a3f-afc46964532c"), "Grady", "O'Kon", "0168379" },
                    { new Guid("512ff250-0f61-4dd3-ba61-7b958e57abcc"), "Paolo", "Hoeger", "7049001" },
                    { new Guid("5177704e-0991-4b36-be44-b85f7f668d22"), "Emile", "Gutkowski", "3901771" },
                    { new Guid("51cbd80d-c8a9-4b48-9453-14a242d50a1e"), "Khalid", "Kulas", "3061703" },
                    { new Guid("51fa8db9-d3af-4c88-a2da-cd1f9c8be74e"), "Bert", "Kihn", "1753245" },
                    { new Guid("520c7cad-8f02-40a1-9435-f7383f3c54a2"), "Tremaine", "Leuschke", "9896073" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { new Guid("5217998b-75f3-47f2-8933-62dc3850a087"), "Lauretta", "Hand", "3823109" },
                    { new Guid("53153af0-6c5f-4250-9fc1-1d2dae771d66"), "Marjolaine", "Koss", "5940307" },
                    { new Guid("5423f41a-931d-471b-8195-3923190ffa8e"), "Orion", "O'Kon", "9093846" },
                    { new Guid("54303fb1-448e-4d45-b03e-fb411cae7d79"), "Stacey", "Wiegand", "6560958" },
                    { new Guid("546813a7-cc39-48dc-a117-0ba86c9dd603"), "Hester", "Heathcote", "2978558" },
                    { new Guid("547343a6-8c28-4fe3-a9c5-82e127045e01"), "Imogene", "Thompson", "0685522" },
                    { new Guid("54d4694f-cda3-45f3-93a1-f3b874a50440"), "Olga", "Frami", "8802395" },
                    { new Guid("560e5175-fb95-4da9-a517-dc5c1a1e0b14"), "Mireya", "Howe", "2344154" },
                    { new Guid("56ca3e53-5de9-4616-bd7c-e2ea9f761594"), "Jade", "Weimann", "7252458" },
                    { new Guid("56dd5f94-c828-4539-a379-635fe6fbe426"), "Nelda", "Herzog", "9487085" },
                    { new Guid("5756b256-d33b-4d26-aa85-4fabe4cb3a65"), "Jesse", "Kiehn", "0703015" },
                    { new Guid("575f2607-46d8-4663-9475-a8ade8af764c"), "Vernon", "Harris", "8003764" },
                    { new Guid("57ac33f0-8833-4edf-a823-ff62125a6c36"), "Mustafa", "Runolfsdottir", "6159895" },
                    { new Guid("582aa4c7-f2c6-4b41-b2b9-9f9c8fcd2dc4"), "Josue", "Conroy", "7783516" },
                    { new Guid("594319fc-c342-4c23-a0e5-eb79e5e9b85c"), "Jaime", "Deckow", "5233965" },
                    { new Guid("59c3f8e4-189b-4831-a58e-140f028bb296"), "Bernita", "Reynolds", "3726541" },
                    { new Guid("5a056dca-033c-4201-ae4a-c0b9b59d6afd"), "Victoria", "Sauer", "2100490" },
                    { new Guid("5a31fe0a-1cd4-4773-9f72-59dbf812e63b"), "Aron", "Fisher", "5086726" },
                    { new Guid("5acc5c9e-8187-44e8-a9eb-255d1d791894"), "Jakob", "Veum", "7944526" },
                    { new Guid("5adf235a-ca24-4a5e-b020-a8f27601303b"), "Marlin", "Luettgen", "3548841" },
                    { new Guid("5b95ea0b-565c-4b81-938f-63886790a9c2"), "Donnell", "Connelly", "1597330" },
                    { new Guid("5c0c2ec7-1b62-4194-9d80-c190a31a9968"), "Dakota", "Nikolaus", "5283059" },
                    { new Guid("5c83883f-fad2-4805-aadc-6d2f79b7ee11"), "Brant", "Skiles", "9086697" },
                    { new Guid("5caffbe6-ffb0-4354-a5a0-71a19e0a3f43"), "Anastasia", "McClure", "1690347" },
                    { new Guid("5e0ea6cd-600c-49a7-906b-cf1300c03b4c"), "Kaylah", "Medhurst", "5531878" },
                    { new Guid("5ef45dcf-8d22-4396-8ef3-37716541bf1e"), "Mckenzie", "Satterfield", "3037090" },
                    { new Guid("5efd4809-86b4-4799-a95a-fb8d8741bcbc"), "Lupe", "Borer", "0755736" },
                    { new Guid("5f28454b-2865-4b85-bde0-7a5611ba866d"), "Chet", "Okuneva", "4511710" },
                    { new Guid("6000e91f-0171-46c5-813d-77e4bd308cad"), "Seth", "Gulgowski", "4970438" },
                    { new Guid("60a17cd2-0068-4a7a-ba21-c539fb2d8bb8"), "Roma", "Quigley", "2080295" },
                    { new Guid("60ad00c5-2e6c-4726-9ea7-0f5a99ab75bb"), "Wanda", "Nitzsche", "5398877" },
                    { new Guid("611e920d-ab3c-43de-9bce-af574d7b7ac1"), "Larry", "Brekke", "8270416" },
                    { new Guid("61830f27-8cbc-4e1c-894e-881227c41830"), "Lucie", "Yost", "8398402" },
                    { new Guid("61f8e206-4876-4b13-aa8e-ff6ddb20cbe9"), "Trinity", "Hauck", "6220526" },
                    { new Guid("624d489a-fe2a-4584-b243-6ce635ebeac8"), "Sydney", "Williamson", "2593554" },
                    { new Guid("6255786c-52cd-491a-8abb-285230889f18"), "Stacey", "Buckridge", "1507561" },
                    { new Guid("626210e2-6312-4a25-acff-91a4f45e91c0"), "Elton", "Jacobi", "2266109" },
                    { new Guid("628fe593-8138-47e2-b1c3-0b915eac2137"), "Joy", "Sporer", "3530294" },
                    { new Guid("62bc7d40-5022-4075-a52d-084686724f2a"), "Bernhard", "Becker", "5363277" },
                    { new Guid("64e6fc26-b655-48ab-9e7b-c397cf8c10f1"), "Joy", "Walter", "6149927" },
                    { new Guid("6647b167-fd5a-4b0e-9239-92c7ed907c0f"), "Jerrell", "Goyette", "4087740" },
                    { new Guid("66590172-df68-4333-9378-c368cc4d2a81"), "Nicolette", "Buckridge", "4222528" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { new Guid("68494d67-f340-427f-bb39-6abcbc12aa25"), "Lennie", "Wehner", "4275856" },
                    { new Guid("68f7ce8a-8aa2-4985-b77a-0227031c7d92"), "Uriah", "Veum", "3715306" },
                    { new Guid("695dea51-3b3e-4d77-b6f0-b90d9688866a"), "Patrick", "Morar", "3602377" },
                    { new Guid("69d4f607-c460-4536-8a8a-6c836dea239f"), "Lizeth", "Jaskolski", "8225119" },
                    { new Guid("69ec5027-57e0-4a29-852a-86022a5c9cf5"), "Gunner", "Mohr", "6244965" },
                    { new Guid("69fdd70d-3600-4925-a3a4-e106e0c07dd0"), "Ellsworth", "Lesch", "9343571" },
                    { new Guid("6a31cf26-30d1-464d-8d3c-a547a29d4122"), "Eliezer", "Carroll", "8055725" },
                    { new Guid("6ad107d8-dbb8-4082-a022-c925c419453d"), "Jeffry", "Oberbrunner", "8295236" },
                    { new Guid("6ba4f73a-00fe-47bb-9f62-f75fc48575ec"), "Donald", "Wiegand", "4863181" },
                    { new Guid("6ba93423-76bb-4395-bba9-28f0f52eaa74"), "Karen", "Feeney", "3692916" },
                    { new Guid("6ba9a6d3-c83a-4e39-988a-10de04cf4b13"), "Queen", "McClure", "2163270" },
                    { new Guid("6c303765-0787-467b-ae23-45d1f9a06a66"), "Marcel", "Hand", "5067480" },
                    { new Guid("6c62a6c1-8ca6-4be5-b2f3-17d2c87eda17"), "Edyth", "Schaden", "8594628" },
                    { new Guid("6ca40879-0f22-4426-a78f-9b437bc4943f"), "Hardy", "Pfannerstill", "3592962" },
                    { new Guid("6d5f052b-eda9-4dc9-8286-21a9faf6b0b2"), "Tressie", "Kling", "5702068" },
                    { new Guid("6e2b7609-6889-4972-8d58-3f2931431b60"), "Faye", "Swift", "0328748" },
                    { new Guid("6e6d5e14-f6f3-4147-a0aa-001f5b0c9e2d"), "Carmen", "Orn", "3044322" },
                    { new Guid("6ea50132-78cc-416d-ae6f-ce850a6f0ea1"), "Aniya", "Cole", "3579811" },
                    { new Guid("6fa6ab12-9707-43a6-8d03-fb8e93a265e0"), "Murray", "Dickinson", "0279122" },
                    { new Guid("71d5248f-c2b6-4267-8a1e-841ce5cbdc99"), "Shaniya", "Wehner", "5547193" },
                    { new Guid("7227f69d-62ae-4334-91bd-82960ec7c632"), "Alphonso", "Walker", "4615899" },
                    { new Guid("7343e910-a2b4-45de-acf1-acd0353c3038"), "Janiya", "Mohr", "4703028" },
                    { new Guid("73d90be3-3c63-4512-b67b-77e731a0ccb5"), "Donnell", "Keebler", "9995032" },
                    { new Guid("73f75984-6282-4227-a909-fc2ad37042a6"), "Trent", "Cormier", "0417031" },
                    { new Guid("74bdb3fb-b0da-4d33-b69d-3c46269876e0"), "Sidney", "Okuneva", "9376958" },
                    { new Guid("750b2161-5c82-4ea8-86ba-fe58bada2674"), "Jayne", "Nikolaus", "9797243" },
                    { new Guid("75483fee-ef85-4314-8b3e-39ae83304a9a"), "Ona", "Mueller", "0619317" },
                    { new Guid("7549cfb3-a7bf-4d2f-9301-c4e8597bc75d"), "Connie", "Swaniawski", "1269425" },
                    { new Guid("76e8098d-386f-4107-9f16-2888b3b9d930"), "Presley", "Parker", "4349662" },
                    { new Guid("770952fc-e3fe-475d-ab06-730f7d350d2f"), "Lysanne", "Gulgowski", "9651381" },
                    { new Guid("773edfdc-d001-46b4-a5cc-dfed84707368"), "Tommie", "Hoeger", "1366654" },
                    { new Guid("776cca4a-2f9d-48c2-9d60-1914176d394d"), "Lowell", "Mayer", "2978609" },
                    { new Guid("77d5add7-0fa4-4c4e-b562-367eb6c81b60"), "Gudrun", "Gleichner", "0408235" },
                    { new Guid("77f5f949-25e4-4fc6-abe1-58ad13d0f628"), "Janelle", "Hagenes", "2744182" },
                    { new Guid("78ada214-9bc8-4288-8757-bb09cda077ee"), "Cayla", "Schulist", "7439887" },
                    { new Guid("78cedd86-c186-4cb1-a62e-4060bf64abd4"), "Marlin", "Parker", "5219438" },
                    { new Guid("78e3f947-92d5-4cdb-a7c8-ccad90097471"), "Nannie", "Baumbach", "5228774" },
                    { new Guid("78fd9778-a249-4d53-ba3e-d753c3454e59"), "Alanis", "Rowe", "0103498" },
                    { new Guid("79261289-c0c6-4347-9988-ca0cd42b0d76"), "Buddy", "Crist", "8563291" },
                    { new Guid("794cbe13-c030-4f5e-b9c0-02f442d390d6"), "Loren", "Franecki", "0780409" },
                    { new Guid("796c6eb7-721c-4bfa-a2f0-99959639ce3b"), "Germaine", "Thiel", "1962790" },
                    { new Guid("798ebad5-68ef-4fa2-9d3f-68dd0beee7e9"), "Cydney", "Vandervort", "3843347" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { new Guid("79e7e48b-5ee2-4309-a334-6736018c72b3"), "Vickie", "Boyer", "4259733" },
                    { new Guid("7a0b563e-b69b-4e3b-8e6c-2a8061d605fa"), "Candice", "Medhurst", "7141138" },
                    { new Guid("7a1d9761-4380-4f8b-acfa-9848a07fadf3"), "Virginia", "Olson", "7731183" },
                    { new Guid("7a3f693c-5efe-412b-a560-83f7d0b3923b"), "Deborah", "Blanda", "9699632" },
                    { new Guid("7a8ff436-b460-4bdd-9a69-abcef5eb1926"), "Corrine", "Blanda", "1811667" },
                    { new Guid("7a94189c-b3e0-4ec7-ae39-94e590a86a92"), "Stan", "Hauck", "2263562" },
                    { new Guid("7aa2fb30-c104-4d2c-8e2c-c7913b315fad"), "Fausto", "Anderson", "3130972" },
                    { new Guid("7aa4fe43-4ca2-415d-95d7-3848750ee9d7"), "Aimee", "Barton", "8936159" },
                    { new Guid("7b1ee224-037e-4f56-bb56-7cfe20a257a4"), "Jonathon", "Hartmann", "1968840" },
                    { new Guid("7c198fc5-61f0-40c2-8401-75d91b9d788b"), "Bennie", "Dickens", "7691954" },
                    { new Guid("7d02ee28-6cfd-4a8b-8704-8d7e30ff6839"), "Kara", "Gusikowski", "0336993" },
                    { new Guid("7d580fd7-1190-4602-b0d0-c7301b8cf631"), "Scottie", "Abshire", "2200478" },
                    { new Guid("7dbc8dc2-3dae-4c00-ba75-fa59107867fc"), "Liliane", "Funk", "6321741" },
                    { new Guid("7dc8a8d5-780f-4735-8d44-bab69f3d541d"), "Alfreda", "King", "9436461" },
                    { new Guid("7df84580-c41d-44ee-a524-2a5693d5d25c"), "Daija", "Larkin", "3297863" },
                    { new Guid("7f1f3e30-3bf4-47a5-b8de-c663fcf28d3f"), "Ernestina", "Ankunding", "0603381" },
                    { new Guid("80173905-e2f1-4465-b00d-7cfe832dbada"), "Libbie", "Collier", "5241079" },
                    { new Guid("80515970-727e-4ac4-9cfa-d5be1ab905a8"), "Alene", "Leannon", "0010968" },
                    { new Guid("80e124cd-e76e-4ab1-b07d-f9086d430272"), "Rosario", "Gislason", "0515869" },
                    { new Guid("80e2ed4e-1929-447d-bf94-7dd04cf7e013"), "Imelda", "Daugherty", "1896996" },
                    { new Guid("817015a3-380f-4abd-9c03-bcfa6f6abc94"), "Jabari", "Von", "7963523" },
                    { new Guid("82054875-1487-4285-853a-baf6981c6e94"), "Shanon", "Collins", "9600284" },
                    { new Guid("82057363-59fa-44db-a16f-9242f94013e3"), "Janiya", "Wyman", "0940656" },
                    { new Guid("82072524-5a57-4b6e-9fd6-4bc8845bafc7"), "Rowland", "Nolan", "6885490" },
                    { new Guid("82fdf04b-b9a1-459d-856e-4f0fa117d309"), "Kacie", "Berge", "0204830" },
                    { new Guid("8347ec76-a6a0-4e66-a300-53bbc9162481"), "Amely", "Hodkiewicz", "4590190" },
                    { new Guid("84f16bdb-6474-4c14-b425-11cac1a565ed"), "Rebeca", "Harber", "7969714" },
                    { new Guid("8563b503-fa49-44d7-a420-40505932b615"), "Franz", "Hilll", "1044526" },
                    { new Guid("857494a9-46ab-49e9-8ee9-b7ed9d4dea1d"), "Bobby", "Balistreri", "9028027" },
                    { new Guid("859d5504-acfb-42f4-944a-1ff0961dfa4b"), "Milan", "Hauck", "6827586" },
                    { new Guid("8627c89d-8f75-48c8-93a1-8e994182a468"), "Casimir", "Williamson", "2376648" },
                    { new Guid("86287960-5440-4ad7-aacb-b301fcd5d399"), "Frida", "Pouros", "2074337" },
                    { new Guid("869d6342-d0d1-49f7-9a37-8f9844b41eda"), "Christina", "Schneider", "9127962" },
                    { new Guid("87149a1a-02e6-48af-9a18-fa3e00200bb9"), "Anika", "Bergstrom", "6468815" },
                    { new Guid("8720ef8d-fae5-4b67-8daa-4423de3df533"), "Ryan", "Monahan", "9777713" },
                    { new Guid("88ed3d09-93e1-4756-841a-17e090fcdb69"), "Stefanie", "Hoppe", "0930222" },
                    { new Guid("88efa80e-827a-42a6-8eef-30a77f58a925"), "Sabina", "O'Conner", "8278436" },
                    { new Guid("8972d367-079c-47c0-b869-c2ae9bb421e4"), "Cyrus", "Hahn", "4899735" },
                    { new Guid("8a0a8d04-c577-4c94-8dbb-0c6f023ddef2"), "Burnice", "Hudson", "3666123" },
                    { new Guid("8a868153-af70-4d8a-bc4d-f3f84c44bd62"), "Saul", "Runolfsdottir", "8076857" },
                    { new Guid("8a9f320c-089a-41aa-a3d3-1a55e045bf54"), "Iliana", "Lemke", "3320416" },
                    { new Guid("8afe9c41-088c-49ef-98b3-c91ea06c5559"), "Virginia", "McKenzie", "3781555" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { new Guid("8b9e22b8-0bf0-4e0f-9f30-c19bfb115a19"), "Harley", "Effertz", "3931200" },
                    { new Guid("8bd368cc-8d3d-49dc-afd5-8e17967f8469"), "Triston", "MacGyver", "1400592" },
                    { new Guid("8c580832-6410-4d5a-9209-a751967490a3"), "Hope", "Bode", "7454907" },
                    { new Guid("8d14db5d-ba62-4091-a8d8-0a438f714a2e"), "Danika", "Hoppe", "7529264" },
                    { new Guid("8d9b04b3-b890-4506-9097-1b0d0373be5a"), "Oliver", "Franecki", "5334449" },
                    { new Guid("8dfc0c1d-42b4-45a9-9007-42e48571f8fe"), "Jarod", "Rowe", "5469448" },
                    { new Guid("8f27ffe9-4cbc-4abb-ae1b-69f40b5abb21"), "Wanda", "Hand", "8985967" },
                    { new Guid("90eeeb9e-3e6e-45ea-a604-b2c4a4f120c7"), "Hubert", "Monahan", "3266631" },
                    { new Guid("912dc195-b21c-4084-a5ba-37eb0a89d1e5"), "Tevin", "Metz", "9081107" },
                    { new Guid("915a1175-d5a2-4afc-a399-939d8a9906d6"), "Garth", "Swift", "7009386" },
                    { new Guid("91f2dfd3-99b6-41a9-bf83-58b31b274ec9"), "Lilian", "Considine", "6730080" },
                    { new Guid("92f50799-6725-471b-8a28-b3fd8b4597fb"), "Asha", "Moore", "4920665" },
                    { new Guid("930ade73-635c-4623-bec6-11604ea6807e"), "Laurianne", "Gusikowski", "1802876" },
                    { new Guid("93603793-a1f5-4e4f-8529-3030f1933825"), "Elian", "Muller", "6774606" },
                    { new Guid("93fe14b7-366e-4d4f-aca0-01b7ff450bf3"), "Florian", "Zboncak", "1396988" },
                    { new Guid("9406aacc-4365-4c85-b3c2-fbc56bd4353e"), "Rosalee", "Brown", "5779648" },
                    { new Guid("94a9ee10-f86b-49af-982e-8b4cfe8b3d9a"), "Larry", "Harber", "5622444" },
                    { new Guid("94ffc259-6ddd-4f60-8f2a-53e0ef66e1d6"), "Mckenzie", "Orn", "3054828" },
                    { new Guid("959a46c6-1291-4f0b-86b8-6e43e83b00d7"), "Moses", "Bernhard", "6673169" },
                    { new Guid("96bd62c7-b5be-46ac-adeb-71c5b953c0c7"), "D'angelo", "Wolf", "3587796" },
                    { new Guid("96f6afbb-d927-4504-ac3f-9175ee2fb1a4"), "Rosa", "Keeling", "6632261" },
                    { new Guid("9761bd7c-0c33-4699-a195-123d0475e5c9"), "Ernestina", "Wisoky", "3302480" },
                    { new Guid("97702012-7129-4edd-8647-6e8382a06ecf"), "Terry", "Stark", "2987908" },
                    { new Guid("978adffe-8f36-422c-b4ee-14ce210f3425"), "April", "Senger", "2110132" },
                    { new Guid("97e09b26-a152-4d85-9c12-c3d35feeb2f3"), "Emerald", "Abshire", "4342854" },
                    { new Guid("98f3f127-8a99-4910-9135-b2a3c8fbea95"), "Grady", "Klein", "5850092" },
                    { new Guid("991d9b7c-9872-40b8-a8c0-6cc453ed73f3"), "Jensen", "Daniel", "5186567" },
                    { new Guid("9a565397-c380-4cc0-a73d-7a4d2d2fcd77"), "Lamont", "Jacobs", "7015963" },
                    { new Guid("9a7deed9-68f3-444b-a4dc-90368af3e152"), "Agustin", "Halvorson", "0465725" },
                    { new Guid("9cef72fb-6bcd-4da0-a22d-e785197876b2"), "Fatima", "Skiles", "2166471" },
                    { new Guid("9f9d9021-a245-4b0e-8096-f946f741950b"), "Guillermo", "Kling", "8034005" },
                    { new Guid("9fa4de80-6dda-49c1-9fdd-656d142e24fa"), "Dolly", "Lemke", "0008521" },
                    { new Guid("a189e998-c4c7-4581-a08b-2e7c692e8379"), "Gennaro", "Rippin", "9716047" },
                    { new Guid("a1de85ce-8736-43f6-b1a4-adaeeb547287"), "Ila", "Keeling", "1701416" },
                    { new Guid("a1e69163-90ac-427a-bf05-06bfe3d095ef"), "Glennie", "McClure", "6196442" },
                    { new Guid("a29a49f5-7d0f-47f6-a177-43b8a66369df"), "Hiram", "Ortiz", "6655561" },
                    { new Guid("a2fce8d0-7578-4998-ad76-a6e84741cc35"), "Luisa", "Spencer", "3588634" },
                    { new Guid("a3247dc7-f54b-4c43-82d0-94d497dfc13f"), "Garnet", "Jacobs", "0454839" },
                    { new Guid("a36eb3bb-f041-45e7-9a9b-52b7dc373e99"), "Dedric", "Bruen", "5240917" },
                    { new Guid("a50fc310-be58-4cc0-9d25-e8d01a7d3597"), "Iliana", "Johnston", "8851260" },
                    { new Guid("a52f9180-9cae-4181-a61c-37921a6079c8"), "Kailyn", "Gusikowski", "5290903" },
                    { new Guid("a54477d3-cc3f-4ef9-9be7-bbc1244dfc11"), "Glenda", "Donnelly", "9729559" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { new Guid("a6040bb0-4731-416e-a69d-37be395a80eb"), "Emile", "Johns", "7862886" },
                    { new Guid("a63cf530-853a-4f2a-bdd9-7b3283daaea5"), "Eliza", "Lehner", "5226059" },
                    { new Guid("a6bf8976-4c91-480b-8d0a-6f362578ac97"), "Breana", "Ryan", "7001682" },
                    { new Guid("a7a3264c-773f-4b86-9b6b-a8a241f949dd"), "Maegan", "Goyette", "3558639" },
                    { new Guid("a8d77b9a-5a3e-473d-9983-6073d3759bc5"), "Amy", "Brakus", "3133869" },
                    { new Guid("a90e2799-2963-4756-bd4b-0ad48f429ac5"), "Carmela", "Langosh", "0788845" },
                    { new Guid("a91df8a2-2d76-4ea9-9b83-580010e85389"), "Devan", "Kilback", "4444276" },
                    { new Guid("a9532690-b916-4d02-aed7-959843a383e9"), "Ilene", "Wintheiser", "3579687" },
                    { new Guid("aa0ad64c-2850-4a5f-924c-92ef5cbaa288"), "Jan", "Rowe", "5180099" },
                    { new Guid("acc9eada-482a-4301-98dc-46eb0ce4f005"), "Sarai", "Armstrong", "7944962" },
                    { new Guid("acceb5b0-5719-4452-9c76-41441aeb8584"), "Maci", "Hahn", "0504937" },
                    { new Guid("ad75f22f-6b6e-4b21-a0cb-3a76cdfb3834"), "Helga", "Bergstrom", "1063656" },
                    { new Guid("adfa20de-8e2c-4960-9d4c-0138fcbdcf2e"), "Emmie", "Zieme", "7126017" },
                    { new Guid("ae5e6752-463f-4417-8a40-efa5c2acc165"), "Mark", "Greenfelder", "5722383" },
                    { new Guid("b0533309-8ebe-4638-b5ab-aad67ebf869c"), "Roma", "Hane", "9008676" },
                    { new Guid("b09599d0-57a0-4564-9b0c-ce43007f21b9"), "Kiarra", "Hoppe", "8965757" },
                    { new Guid("b0977d5b-366f-4f87-9dbe-e1c9f7909835"), "Finn", "Ruecker", "7404884" },
                    { new Guid("b13735c2-689e-4b5f-ba8a-c86b15521f78"), "Quinton", "Kulas", "5472048" },
                    { new Guid("b14267d4-ba1c-48c2-a748-738a8dd657b3"), "Arielle", "Wiegand", "3557283" },
                    { new Guid("b15b0e6f-9209-4468-95a8-57fe50f5b333"), "Garrison", "Prohaska", "2160900" },
                    { new Guid("b1afc628-d4bb-4ab2-9fc9-e2614d4045c3"), "Madge", "Kirlin", "0143702" },
                    { new Guid("b2089c41-3fbe-4d5d-9d82-4c696d4bd7a7"), "Arnulfo", "Leannon", "0780864" },
                    { new Guid("b304990a-bf3a-49a9-95f7-3fe465781048"), "Ciara", "Altenwerth", "9737541" },
                    { new Guid("b31696da-7aaa-4940-bf34-a49c5c7466bc"), "Wilford", "Medhurst", "3266456" },
                    { new Guid("b317d4a5-7ada-4048-82b3-9c9d281424c7"), "Ambrose", "Schmidt", "0172598" },
                    { new Guid("b36098e1-99a9-47a1-a075-5bce1d58b630"), "Conor", "Johnson", "4018227" },
                    { new Guid("b3a84ddc-31da-43dd-8653-3fd366df9e81"), "Micah", "Kertzmann", "8178077" },
                    { new Guid("b52a8886-a60f-460d-810b-b354251df7b2"), "Lowell", "Koch", "9403759" },
                    { new Guid("b5b33e40-0c7b-4e9a-b18e-22de587ea633"), "Geoffrey", "Rau", "1020458" },
                    { new Guid("b5d10d6d-4de4-403e-b4f5-a7054cf215f4"), "Hosea", "Hand", "1192151" },
                    { new Guid("b64ecebf-c3cf-4f38-b1cc-946783de86d6"), "Alva", "Kunde", "8910486" },
                    { new Guid("b6ec58e8-7f3c-4dc2-b767-a204944804fa"), "Esteban", "Kulas", "1556605" },
                    { new Guid("b70a11ab-ab36-4a6c-bb5f-50a139b022ab"), "Camren", "Mayert", "7401456" },
                    { new Guid("b7dc9482-8a9c-41dd-a291-3fff13ee9365"), "Brielle", "Labadie", "1230405" },
                    { new Guid("b7e8eb2a-015e-40c0-b1ab-f95b5b09dcfa"), "Hollis", "Bernhard", "3391484" },
                    { new Guid("b8096541-0e6c-48d0-ad33-09d6030ddbe3"), "Myron", "Schaefer", "6423756" },
                    { new Guid("b95ab0ab-6cf5-4931-bb76-7910e5a2ea52"), "Lina", "Schuppe", "8554433" },
                    { new Guid("ba42f5f2-d7b5-48b4-bfea-fdf2d7649f2a"), "Eleazar", "Boyer", "5077782" },
                    { new Guid("ba566af1-0d06-4aba-a337-0662a240d6d4"), "Nona", "Hintz", "3516231" },
                    { new Guid("bab3545b-ed47-4a34-9960-f7c0c27c7133"), "Okey", "Luettgen", "4806581" },
                    { new Guid("baf82b35-e54f-4e9e-98a4-2b0e2b3f84ba"), "Cathy", "Bashirian", "7685475" },
                    { new Guid("bb58ed63-9f2f-4630-bf7d-f2992eda2402"), "Alvena", "Torp", "4001864" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { new Guid("bbcf7301-ea1f-4ded-b978-0c4c23e48014"), "Jamal", "Olson", "2221387" },
                    { new Guid("bca7f9bd-d19e-42e0-a498-7ea2d6e300ba"), "Wilma", "Friesen", "5443182" },
                    { new Guid("bdb52dd7-ec33-4a40-b9ad-8170d623cd33"), "Emerson", "Auer", "4940069" },
                    { new Guid("bef30e53-427a-4d85-b52a-daf8726354f0"), "Garett", "Zemlak", "6381961" },
                    { new Guid("bfdc28a5-ce3c-4bfd-a401-2e328159dcb9"), "Berniece", "Yost", "7159333" },
                    { new Guid("c08085af-c542-4e74-a7bb-bc33f8810c24"), "Ned", "Brekke", "8543524" },
                    { new Guid("c1326e03-ff13-4dbc-885a-2ecad11dd121"), "Kallie", "Stehr", "3981068" },
                    { new Guid("c17b1b40-385f-4b13-8a59-8023223e7490"), "Dillan", "Strosin", "4693901" },
                    { new Guid("c25cb24d-824c-4cab-af63-b823f28b2770"), "Tyra", "Pagac", "1518597" },
                    { new Guid("c2989889-eb8e-49f4-ba26-8b1b28737b17"), "Andy", "Zieme", "7511881" },
                    { new Guid("c2d1566d-41e8-4b35-be3e-1cbcc6b46ba8"), "Louie", "Hudson", "4153145" },
                    { new Guid("c40ec032-52ac-4339-9c08-30139b137395"), "Tate", "Cronin", "6577181" },
                    { new Guid("c49cc465-7e2f-4224-ae02-4f7cfc830efd"), "Lucious", "Homenick", "0225749" },
                    { new Guid("c4b60334-50be-49a4-8096-13dac5f6c833"), "Genevieve", "Kilback", "8960561" },
                    { new Guid("c5d06c5a-c561-4034-b942-939fa71d1016"), "Leila", "Turner", "9636473" },
                    { new Guid("c622bb5c-7770-4db5-ae86-187a9de403a6"), "Wilburn", "Reichel", "4866654" },
                    { new Guid("c68a2f4d-e696-4469-96cb-05f67e35baf5"), "Maria", "Pouros", "5246472" },
                    { new Guid("c784dc89-58e6-4785-8969-4856400f56ac"), "Kacie", "Bosco", "2742075" },
                    { new Guid("c7f6b3b8-5925-4f1b-a087-f07b190d4cf7"), "Carrie", "Fadel", "8400979" },
                    { new Guid("c8bcd758-d56d-4af2-8d6d-9244d9e00e4b"), "Davion", "Jones", "5882982" },
                    { new Guid("c9ab0657-1d13-45de-8303-65627d320eaa"), "Rebecca", "Heller", "6973809" },
                    { new Guid("cad3b226-c49c-4c18-acac-957da4a8da5a"), "Emmie", "Lehner", "9044215" },
                    { new Guid("cca29ecc-f27d-4cf2-bff6-12300e28f295"), "Nadia", "Bernhard", "0987368" },
                    { new Guid("ccd63b13-14ff-4eb6-b3e7-2fce0167e6dd"), "Christopher", "Legros", "2578230" },
                    { new Guid("ce477f52-3754-42d9-9211-c8d73797b205"), "Pietro", "Macejkovic", "8352771" },
                    { new Guid("ceaeaa31-c409-4671-9a6e-bdd3a8205cb1"), "Vincenzo", "Hudson", "3615647" },
                    { new Guid("cf25cb86-469e-4d76-95f3-8ce65a42ff6a"), "Ransom", "Cassin", "5581594" },
                    { new Guid("cfe68f3d-7736-4945-8b81-c41bf2321d2e"), "Fiona", "Moen", "7639301" },
                    { new Guid("d03475e1-b2f5-49ff-822f-6ba578573d95"), "Russ", "Smitham", "2589266" },
                    { new Guid("d07b5d3d-8485-44cf-919c-2328838983f9"), "Verna", "Kessler", "1207858" },
                    { new Guid("d0ce962e-01f0-42f3-aa18-94d1818f9829"), "Wilhelm", "Kreiger", "9702018" },
                    { new Guid("d1e270f9-4e18-4630-9eb9-e1f208398686"), "Landen", "Jacobson", "0627764" },
                    { new Guid("d2066d9c-eafb-4d37-8441-899c98772157"), "Kyleigh", "Cruickshank", "4759993" },
                    { new Guid("d2c4ce5a-9d27-4593-9e0f-7d6842f0e930"), "Abdul", "Kohler", "3862881" },
                    { new Guid("d2ecdc85-a658-4fde-8cfb-bcbc2d89545c"), "Cortney", "Corkery", "9519500" },
                    { new Guid("d32193f2-6eb3-4c0a-8ad7-4a1c0d0a3f96"), "Bert", "Huels", "2226704" },
                    { new Guid("d45b450a-0c6c-4975-88c4-ce2fe5ef95af"), "Lewis", "Krajcik", "3336027" },
                    { new Guid("d6cb008b-7714-44ca-ad3e-23b47cba6645"), "Yesenia", "Hilll", "5744886" },
                    { new Guid("d8020b65-bef1-4049-9921-cef79cbb5cdd"), "Eryn", "Carroll", "2814756" },
                    { new Guid("d8343ae4-ab2f-46c7-bb98-69ac7dc58aed"), "Rubie", "Moen", "5187544" },
                    { new Guid("d83fd3af-01b1-4e09-84b3-e2c25cef4476"), "Irwin", "Vandervort", "7211331" },
                    { new Guid("d868e8e4-1fb5-4757-aa2f-bc7e67cf5adc"), "Darron", "Heaney", "6701155" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { new Guid("d8e43b71-e0e0-467a-b858-fdde9f229cd6"), "Jolie", "Swift", "3828296" },
                    { new Guid("d95f5558-a372-49b0-bfe0-b5d24a034ef7"), "Zackary", "Feil", "9196215" },
                    { new Guid("d9caefbb-4405-489a-8158-f4f6f1ccef0c"), "Archibald", "Morar", "5477808" },
                    { new Guid("daeccf70-a7dc-49b3-89a7-6d40e34537f3"), "Jessie", "Leuschke", "0846189" },
                    { new Guid("db3cdd11-b75f-4b8b-af34-8181e865b2d8"), "Eden", "Hansen", "1355668" },
                    { new Guid("dbf362dc-7c85-4012-927e-1a86fb307e39"), "Kaylah", "Lesch", "3234790" },
                    { new Guid("dc1e2b7c-06cc-4428-b1aa-78006d639488"), "Rose", "Schiller", "2300163" },
                    { new Guid("dc6850da-464d-4c75-b16c-82087dc7b97a"), "Ariel", "Schulist", "1646926" },
                    { new Guid("dca865b9-6916-485c-a4ed-279e1750046f"), "Ashlee", "Grimes", "9365026" },
                    { new Guid("dd6c3ae8-5252-4a87-8cc6-a556a9d41b92"), "Bernadette", "Koss", "1852137" },
                    { new Guid("dd8d364e-ed07-44dc-9d7b-e348854a656a"), "Wade", "Dickens", "2196421" },
                    { new Guid("de91c537-925f-4973-b86e-a1d0165f081c"), "Erling", "Carroll", "2084430" },
                    { new Guid("deb83f23-2b32-4e55-9e58-7815346d9465"), "Zoey", "Trantow", "4308765" },
                    { new Guid("dec293a8-ddc1-434a-941e-0e55137d6e25"), "London", "Schroeder", "9093092" },
                    { new Guid("def562f5-16fa-4971-9891-30b8c5a848c3"), "Hailie", "Mosciski", "1956397" },
                    { new Guid("dfc4301d-1c42-4c0d-b034-6e7400c89e3b"), "Evie", "Witting", "0106266" },
                    { new Guid("e02e5fe2-084d-4bbe-b7dc-d8d588f6618e"), "Johanna", "Lesch", "3199419" },
                    { new Guid("e08f7343-b75e-476f-b0d0-3ccdf97b3d5b"), "Tod", "Marquardt", "3148695" },
                    { new Guid("e18e716c-7845-4b7d-8e90-604d987b0157"), "Eriberto", "Considine", "5723349" },
                    { new Guid("e24adac0-09a0-4c54-b957-c587d8a26d03"), "Antonia", "Runolfsson", "4110454" },
                    { new Guid("e28a17f7-c3cf-4fb2-9ad1-6a0a52af8e9d"), "Cassidy", "Kshlerin", "0046841" },
                    { new Guid("e2c63be9-4a75-4b1b-acbf-77c6893fc569"), "Howell", "Batz", "3929740" },
                    { new Guid("e499e88f-c288-445f-80ed-a42fe4dd49ac"), "Catalina", "Smitham", "5625618" },
                    { new Guid("e5f1e520-4c68-410a-8354-f17882317dbe"), "Felicita", "Waters", "9448550" },
                    { new Guid("e68ffcc4-4e79-4edc-923a-99f84f1beef5"), "Rylee", "Lesch", "2520156" },
                    { new Guid("e77747b4-9625-419a-abfa-36565c15162d"), "Ransom", "Grady", "0437392" },
                    { new Guid("e78d5a8f-4c1f-4d2b-bd0c-9e1f6edb31c9"), "Crystel", "Ebert", "7220644" },
                    { new Guid("e84a35bb-b268-4ea9-a53a-1333d4ac8c0b"), "Amy", "Bernhard", "1027252" },
                    { new Guid("e84d677d-44c5-4841-ac1a-855d222f5bf6"), "Mohammed", "Koss", "1873003" },
                    { new Guid("e8589512-e9d1-401c-9751-768c1b7c4746"), "Fausto", "Gislason", "6299170" },
                    { new Guid("e8fe5f0e-6f22-4c86-8154-fc6481ff02a4"), "Vickie", "Watsica", "5814342" },
                    { new Guid("e9772e94-927c-4b7a-a2d4-06ee76bf45ca"), "Ruby", "Kuhic", "2177574" },
                    { new Guid("e979e436-99c7-41d8-bdf2-230529f75a84"), "Clementine", "Zemlak", "4566817" },
                    { new Guid("ea1bcfbc-c897-43ef-b698-d39ef0c77450"), "Rylan", "Schulist", "2682755" },
                    { new Guid("eb7793dd-1214-4e51-9971-04f64262e0bc"), "Alyson", "Ratke", "3304016" },
                    { new Guid("ec613242-9a94-46ad-a3e5-eec24bbcff22"), "Patricia", "Schaden", "3958320" },
                    { new Guid("ec86b382-2eff-4365-b78d-b441145a9a77"), "Sigrid", "Armstrong", "8755729" },
                    { new Guid("ec8b2c67-f67d-4b60-a5db-3f30cb2bb7ad"), "Darian", "Monahan", "3168971" },
                    { new Guid("eca5f2ed-484c-4c2e-98a1-0c55a46e736b"), "Patsy", "Kerluke", "9411424" },
                    { new Guid("ed4adba4-880d-4c8f-ac0d-9cca6ebd8ace"), "Bulah", "Hodkiewicz", "1832772" },
                    { new Guid("ed87c183-2513-4b54-80b3-56c11ea85711"), "Keagan", "Stanton", "8185055" },
                    { new Guid("ed8864ae-8d7d-43f7-98aa-0ce4d42508cf"), "Abbey", "Kuhlman", "5359504" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { new Guid("eda9dfa1-d8b9-49eb-8c65-8ceaefd0a764"), "Vernie", "Marvin", "4070695" },
                    { new Guid("eddfac5d-6cae-4cde-a3c3-efee9473a39f"), "Kameron", "Kris", "1602313" },
                    { new Guid("ef8e3fe1-2087-497b-a5a4-8a5821fb0571"), "Keely", "Pacocha", "1151179" },
                    { new Guid("f070212d-ff43-4855-8098-bce4999bc75e"), "Eulalia", "Quitzon", "0278934" },
                    { new Guid("f107917f-7f32-4619-8cf9-ce7fd13da715"), "Amy", "Zemlak", "5316481" },
                    { new Guid("f1ee9516-3dab-469c-8876-f13cb75b5eba"), "Heloise", "Stiedemann", "9547573" },
                    { new Guid("f1f2f390-ef5e-4ebf-8de1-83d274f18f9c"), "Kendra", "Ankunding", "4196048" },
                    { new Guid("f28d4490-869c-49e1-ab1a-9cad86be3797"), "Addison", "Schmitt", "3886179" },
                    { new Guid("f362ab47-8093-43c4-a6d1-024849429d31"), "Freddie", "Bernier", "7429664" },
                    { new Guid("f3fe078d-2c6f-4415-8fb5-bb67d33eaa7c"), "Gail", "Quitzon", "8124751" },
                    { new Guid("f474cc8a-2788-42b1-aa3c-7c61321bb27b"), "Queenie", "Mohr", "4850442" },
                    { new Guid("f482a28a-ab02-4c67-ac8f-c492480277d9"), "Mauricio", "Kirlin", "8708420" },
                    { new Guid("f48926e3-d98d-43cc-b4d0-bde48ee1a53c"), "Marge", "Pfannerstill", "1665277" },
                    { new Guid("f49fdeb9-717d-4d9c-8a74-0c7b6bc1dfca"), "Nayeli", "Buckridge", "9218684" },
                    { new Guid("f4e03368-c30e-46e9-a2cb-8b413396330a"), "Grayce", "Larson", "3947090" },
                    { new Guid("f4e11711-89ce-4537-ba0f-c5cc9621bf1b"), "Ashtyn", "Champlin", "7472663" },
                    { new Guid("f5c88b2d-3dea-4ce2-b826-824566f41d99"), "Mireya", "Cartwright", "0346546" },
                    { new Guid("f722d01c-2efa-4d1a-bc46-5721aeeb437d"), "Damien", "Morissette", "7477177" },
                    { new Guid("f879de98-5057-4ba5-8059-91a59c7dc58b"), "Jordane", "Senger", "3718349" },
                    { new Guid("f9676000-6bc6-4bb5-91c0-90b5afb6a5d6"), "Camden", "Lubowitz", "1762217" },
                    { new Guid("f97505d4-1b35-45fa-b048-067ec13fd573"), "Rigoberto", "Russel", "5606342" },
                    { new Guid("f9ca5386-4612-4844-97a3-9bd1819f8ce8"), "Carley", "Runte", "1901417" },
                    { new Guid("fa42e9ca-49de-40ba-a1bb-1d54c80a2aef"), "Alysha", "Welch", "3030349" },
                    { new Guid("fa51f561-d2ef-45f5-9791-077592b770eb"), "Isabella", "Hickle", "0268686" },
                    { new Guid("fa8105b7-3f4a-4c80-97b0-908e5fddef2a"), "Hailey", "Bartoletti", "6188326" },
                    { new Guid("faa4200a-0da1-43e3-8be6-7299b39f0d7e"), "Destini", "Hills", "2395168" },
                    { new Guid("fb6aabed-ed68-4ad7-88fd-9c08ce9bd65a"), "Scotty", "Stroman", "9444199" },
                    { new Guid("fbacffec-e616-4182-9771-935b786124a9"), "Dolores", "O'Hara", "6898071" },
                    { new Guid("fbc0f04d-c1da-4844-9b70-f11172f609d8"), "Reese", "Morissette", "2875323" },
                    { new Guid("fc5e04a0-0161-478e-9548-4230d3dc9272"), "Emil", "Kilback", "0196989" },
                    { new Guid("fd0cf52b-b7b9-4de5-9a0e-72098dd0cc24"), "Durward", "Pouros", "8886599" },
                    { new Guid("fda61204-87ca-4bf3-932e-7ed1ff357cc5"), "Herminio", "Satterfield", "8435829" },
                    { new Guid("fe7368d9-7139-4188-987d-98ec9bda8824"), "Lawrence", "Emmerich", "7990683" },
                    { new Guid("fe8d4ef4-999a-4cca-8faa-252c88fa7cc6"), "Shaun", "Lang", "0936597" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[] { new Guid("0032e1a1-9827-483f-b5c4-690df498d00f"), "976 Mueller Terrace, Santaport, Mozambique", new DateTime(2019, 9, 22, 14, 1, 49, 231, DateTimeKind.Local).AddTicks(4314), 2, 106m, new Guid("0b592e8e-0184-4dec-83b6-dde70709abf3") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("0306cc70-7a2e-47f2-8b29-ae39c10469be"), "9028 Christiana Haven, Balistreriport, Peru", new DateTime(2021, 8, 4, 23, 44, 44, 309, DateTimeKind.Local).AddTicks(7345), 49m, new Guid("27fcdc89-c1eb-4dd0-bf83-09635f277250") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[] { new Guid("03608ed8-92e0-4bd5-aeca-5b9d6f7f6963"), "63831 Volkman Ranch, Lake Gaetano, Norway", new DateTime(2022, 3, 21, 21, 59, 15, 481, DateTimeKind.Local).AddTicks(2425), 2, 104m, new Guid("7549cfb3-a7bf-4d2f-9301-c4e8597bc75d") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("0364cb2a-d484-4ca4-bc7f-0269dff117a0"), "8093 Claudia Loaf, Bradyland, Brunei Darussalam", new DateTime(2020, 2, 27, 6, 39, 5, 673, DateTimeKind.Local).AddTicks(7185), 57m, new Guid("438435e4-c95f-4ce1-bdea-fa96c9f87cc3") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("0484f780-e79d-41ca-a684-1864df8f1be4"), "5836 Robel Roads, Dominicberg, Gambia", new DateTime(2020, 2, 20, 17, 35, 9, 767, DateTimeKind.Local).AddTicks(4025), 2, 57m, new Guid("b304990a-bf3a-49a9-95f7-3fe465781048") },
                    { new Guid("04869701-a774-49ea-85b1-b0106e5ae97d"), "57021 Gerhold Summit, Wilkinsonmouth, Sri Lanka", new DateTime(2022, 8, 14, 0, 47, 39, 294, DateTimeKind.Local).AddTicks(9778), 1, 50m, new Guid("daeccf70-a7dc-49b3-89a7-6d40e34537f3") },
                    { new Guid("0663a9e4-886d-4b3a-9fa1-57fcb91dc69c"), "66829 Frida Branch, Watersland, Gabon", new DateTime(2022, 7, 20, 7, 25, 57, 926, DateTimeKind.Local).AddTicks(7130), 2, 50m, new Guid("40e0ae9f-1a18-4154-8f4b-70b5878172c3") },
                    { new Guid("0853800f-5f9c-433f-839a-9f6ea6ae6864"), "40610 Anahi Turnpike, South Kiara, Kenya", new DateTime(2021, 6, 12, 21, 8, 20, 9, DateTimeKind.Local).AddTicks(7990), 2, 105m, new Guid("30299db5-4efe-4c3f-ab8f-9f09dfdd5df1") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("08e28f96-d1f4-4d94-ac44-c00d8a17b093"), "46330 Warren Well, Beattyborough, El Salvador", new DateTime(2020, 12, 2, 7, 54, 9, 397, DateTimeKind.Local).AddTicks(996), 104m, new Guid("e8fe5f0e-6f22-4c86-8154-fc6481ff02a4") },
                    { new Guid("09561552-a669-4e36-b06b-b24efc32e20c"), "3739 Turner Passage, West Dahlia, Sri Lanka", new DateTime(2022, 8, 11, 11, 14, 44, 374, DateTimeKind.Local).AddTicks(1430), 106m, new Guid("325a9cfc-4ec9-493a-927a-482a59fca9ae") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("096ccb7a-f57e-4c8a-95d7-acc897b4f3e3"), "7022 Kody Square, West Kaci, Suriname", new DateTime(2022, 3, 23, 23, 23, 32, 830, DateTimeKind.Local).AddTicks(5740), 2, 53m, new Guid("547343a6-8c28-4fe3-a9c5-82e127045e01") },
                    { new Guid("09d01aec-e84f-4a29-a2e0-48c22513edef"), "6468 Lilyan Canyon, East Henrymouth, Italy", new DateTime(2019, 11, 12, 0, 25, 30, 708, DateTimeKind.Local).AddTicks(2165), 3, 56m, new Guid("4ffbf040-7025-4328-a8ed-8d7623b22242") },
                    { new Guid("0a3c1630-08b4-4469-9409-a5b593b1ef04"), "9551 Rodolfo Mountains, Lake Delaneystad, Bahamas", new DateTime(2021, 8, 29, 13, 13, 44, 685, DateTimeKind.Local).AddTicks(9737), 1, 49m, new Guid("ea1bcfbc-c897-43ef-b698-d39ef0c77450") },
                    { new Guid("0ae95470-98b8-4beb-824e-60deeffacb0f"), "99170 Don Via, New Saigeshire, Marshall Islands", new DateTime(2020, 8, 18, 3, 37, 11, 785, DateTimeKind.Local).AddTicks(5466), 3, 56m, new Guid("773edfdc-d001-46b4-a5cc-dfed84707368") },
                    { new Guid("0be28c4d-53d2-4985-84ec-9ad0630f7507"), "4818 Macey Underpass, Alenemouth, Azerbaijan", new DateTime(2021, 2, 16, 21, 1, 23, 960, DateTimeKind.Local).AddTicks(8393), 3, 49m, new Guid("a52f9180-9cae-4181-a61c-37921a6079c8") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("0d1578ef-e30c-4027-a7c6-a64663c78109"), "5884 Yost Crescent, Queeniestad, Oman", new DateTime(2019, 12, 8, 22, 36, 49, 724, DateTimeKind.Local).AddTicks(1101), 105m, new Guid("a91df8a2-2d76-4ea9-9b83-580010e85389") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("0d230fc2-9bcc-4260-ba14-42fadd51b4a1"), "2597 Lavinia Station, Lake David, Chile", new DateTime(2020, 3, 13, 14, 29, 6, 7, DateTimeKind.Local).AddTicks(8365), 2, 151m, new Guid("97e09b26-a152-4d85-9c12-c3d35feeb2f3") },
                    { new Guid("0d73fc46-1f39-4c91-83b1-794aeaa7a6fb"), "83273 Wolff Ferry, Leuschkechester, Philippines", new DateTime(2019, 11, 27, 15, 36, 45, 223, DateTimeKind.Local).AddTicks(5181), 1, 109m, new Guid("5e0ea6cd-600c-49a7-906b-cf1300c03b4c") },
                    { new Guid("0e8fcd11-324e-48c5-a721-0525a8934331"), "8214 Grimes Fords, Watersview, Eritrea", new DateTime(2020, 9, 20, 17, 19, 14, 449, DateTimeKind.Local).AddTicks(3039), 3, 52m, new Guid("8627c89d-8f75-48c8-93a1-8e994182a468") },
                    { new Guid("0ef730c2-bb54-4594-9036-f1007cd3e939"), "048 Crystal Estates, Port Brionna, Democratic People's Republic of Korea", new DateTime(2022, 3, 6, 17, 18, 47, 447, DateTimeKind.Local).AddTicks(774), 1, 52m, new Guid("b3a84ddc-31da-43dd-8653-3fd366df9e81") },
                    { new Guid("0f6cb10a-e50d-4b8d-824f-54f8a7f38903"), "58223 Mertie Flat, O'Connellland, Christmas Island", new DateTime(2021, 3, 21, 7, 19, 3, 764, DateTimeKind.Local).AddTicks(6253), 1, 49m, new Guid("f107917f-7f32-4619-8cf9-ce7fd13da715") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("10dbba4a-c607-470e-86c4-af869b484108"), "133 Ledner Via, South Damian, Sudan", new DateTime(2019, 10, 25, 0, 49, 18, 175, DateTimeKind.Local).AddTicks(1609), 55m, new Guid("97702012-7129-4edd-8647-6e8382a06ecf") },
                    { new Guid("118b377b-d09d-4a59-a8f2-4e149d3a7cd6"), "636 Cordelia Centers, Kautzermouth, Morocco", new DateTime(2019, 10, 27, 18, 59, 33, 519, DateTimeKind.Local).AddTicks(9338), 53m, new Guid("13cc36ad-a529-431d-b772-c2848a22edc9") },
                    { new Guid("11b8e861-8ed9-467f-8f4f-c1efe7064030"), "2616 Bryce Club, Zboncakfurt, Mayotte", new DateTime(2020, 7, 29, 6, 27, 35, 617, DateTimeKind.Local).AddTicks(8939), 57m, new Guid("acc9eada-482a-4301-98dc-46eb0ce4f005") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("11d0a6f6-1c2d-43b8-9ff9-a9faac9c10f9"), "45907 Schaefer Gateway, Hudsonhaven, Albania", new DateTime(2021, 8, 25, 12, 36, 30, 833, DateTimeKind.Local).AddTicks(808), 3, 53m, new Guid("ef8e3fe1-2087-497b-a5a4-8a5821fb0571") },
                    { new Guid("13548f42-636a-47cc-9820-749718f9caa3"), "3427 Windler Groves, Towneport, Cameroon", new DateTime(2021, 9, 24, 21, 8, 1, 387, DateTimeKind.Local).AddTicks(649), 3, 55m, new Guid("c17b1b40-385f-4b13-8a59-8023223e7490") },
                    { new Guid("1483d2bf-00d0-410a-9434-18942ea4480c"), "798 Cremin Mission, East Tamara, Norfolk Island", new DateTime(2020, 5, 29, 23, 27, 29, 660, DateTimeKind.Local).AddTicks(5962), 3, 50m, new Guid("f070212d-ff43-4855-8098-bce4999bc75e") },
                    { new Guid("14901afe-ab99-491b-86f4-15d40fd9514f"), "37545 Deja Road, South Ronaldobury, South Georgia and the South Sandwich Islands", new DateTime(2020, 4, 4, 5, 1, 1, 334, DateTimeKind.Local).AddTicks(2061), 1, 49m, new Guid("faa4200a-0da1-43e3-8be6-7299b39f0d7e") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("150a58e7-a2c0-4ec2-8085-4a6ac97c8a42"), "6938 Leannon Loaf, Thompsonborough, Albania", new DateTime(2021, 12, 30, 3, 54, 42, 173, DateTimeKind.Local).AddTicks(8148), 52m, new Guid("47421fcf-1cef-4ef2-8a6c-d812e1f602f0") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("1537e3f6-7574-4582-b974-137981422be3"), "583 Cayla Flats, Theresebury, Hungary", new DateTime(2020, 4, 9, 9, 41, 55, 31, DateTimeKind.Local).AddTicks(8271), 1, 55m, new Guid("c9ab0657-1d13-45de-8303-65627d320eaa") },
                    { new Guid("15729ad3-1106-41ca-8347-867aa60b824a"), "3817 DuBuque Common, South Edwin, Libyan Arab Jamahiriya", new DateTime(2020, 9, 15, 0, 42, 26, 219, DateTimeKind.Local).AddTicks(4632), 1, 52m, new Guid("915a1175-d5a2-4afc-a399-939d8a9906d6") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("161466e9-4ca1-48a3-a9c1-bcc0433d28db"), "501 Witting Skyway, Parisianberg, Montserrat", new DateTime(2021, 8, 6, 9, 2, 25, 339, DateTimeKind.Local).AddTicks(2355), 102m, new Guid("76e8098d-386f-4107-9f16-2888b3b9d930") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[] { new Guid("16217467-f89c-4117-95ce-ee565e0687c8"), "320 Sasha Isle, Port Trinityberg, Equatorial Guinea", new DateTime(2021, 8, 29, 1, 40, 22, 46, DateTimeKind.Local).AddTicks(707), 1, 99m, new Guid("47421fcf-1cef-4ef2-8a6c-d812e1f602f0") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("16a6e6f7-51af-4f9a-b5df-fbc335656de5"), "37054 Ernest Trail, Gustown, Haiti", new DateTime(2021, 1, 19, 17, 15, 33, 730, DateTimeKind.Local).AddTicks(1862), 50m, new Guid("08d4fb8f-dcac-48e2-8c00-827d81f18593") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[] { new Guid("17200911-e538-4545-9b62-dd79bacfb277"), "49855 Juana Drive, Port Marielle, Libyan Arab Jamahiriya", new DateTime(2022, 8, 17, 22, 31, 15, 259, DateTimeKind.Local).AddTicks(6929), 2, 163m, new Guid("5ef45dcf-8d22-4396-8ef3-37716541bf1e") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("197b780d-8c88-4384-81c0-7d9e9079cd6c"), "35217 Rempel Loop, South Jerelfurt, Spain", new DateTime(2021, 4, 28, 1, 51, 6, 342, DateTimeKind.Local).AddTicks(5168), 52m, new Guid("b1afc628-d4bb-4ab2-9fc9-e2614d4045c3") },
                    { new Guid("1b097a10-6f1d-4f5f-9551-112033dd5206"), "43315 Bayer Turnpike, Port Claudine, Bouvet Island (Bouvetoya)", new DateTime(2019, 10, 18, 17, 0, 45, 747, DateTimeKind.Local).AddTicks(3974), 50m, new Guid("aa0ad64c-2850-4a5f-924c-92ef5cbaa288") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("1bcc31e4-616f-4042-913a-24e906cd6e68"), "4431 Bartoletti Spurs, Port Janieburgh, Madagascar", new DateTime(2020, 1, 25, 2, 43, 10, 886, DateTimeKind.Local).AddTicks(9977), 3, 105m, new Guid("a3247dc7-f54b-4c43-82d0-94d497dfc13f") },
                    { new Guid("1bea0342-3923-4b8a-aa68-7e1d9abf447f"), "606 Quigley Light, South Loma, Mozambique", new DateTime(2021, 9, 1, 4, 13, 20, 683, DateTimeKind.Local).AddTicks(3191), 1, 108m, new Guid("14fa6844-2d13-44b9-baae-7b4b7609e98f") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("1c2f3ed4-d733-46f7-bda7-9aae1defc693"), "3810 Pfeffer Forest, East Micaelamouth, South Georgia and the South Sandwich Islands", new DateTime(2021, 8, 8, 22, 25, 40, 25, DateTimeKind.Local).AddTicks(6297), 51m, new Guid("6255786c-52cd-491a-8abb-285230889f18") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("1d35677a-46f2-47ea-95f8-469ed98af1e7"), "0612 Wilderman Prairie, West Gerald, Costa Rica", new DateTime(2020, 12, 24, 19, 25, 19, 192, DateTimeKind.Local).AddTicks(2361), 3, 49m, new Guid("d8343ae4-ab2f-46c7-bb98-69ac7dc58aed") },
                    { new Guid("1ecaf207-574f-4d62-9698-b9604af71d63"), "0330 Braun Inlet, Wiegandberg, Ukraine", new DateTime(2019, 12, 25, 0, 12, 45, 159, DateTimeKind.Local).AddTicks(7938), 1, 57m, new Guid("22ca813b-27c4-4049-abc4-a33109557412") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("1f758b75-d01d-40a1-83fd-c9aaaec93a89"), "208 Hansen Junctions, Isabellebury, Sweden", new DateTime(2021, 10, 22, 5, 34, 7, 565, DateTimeKind.Local).AddTicks(7014), 54m, new Guid("869d6342-d0d1-49f7-9a37-8f9844b41eda") },
                    { new Guid("1fc8e9df-7f43-4ccb-8bec-ef023150bc6d"), "79433 Christop Spring, Jeramyburgh, Democratic People's Republic of Korea", new DateTime(2020, 10, 9, 10, 5, 42, 844, DateTimeKind.Local).AddTicks(7459), 52m, new Guid("b64ecebf-c3cf-4f38-b1cc-946783de86d6") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("20a58ba9-6c77-42ac-9748-7a1a08f68c4c"), "69715 Davis Rapid, Port Lucas, Congo", new DateTime(2020, 10, 11, 22, 22, 31, 471, DateTimeKind.Local).AddTicks(3265), 3, 56m, new Guid("eda9dfa1-d8b9-49eb-8c65-8ceaefd0a764") },
                    { new Guid("20d10716-eb27-4057-afd3-fdddeebc110b"), "690 Emil Street, Royburgh, Sweden", new DateTime(2021, 1, 15, 14, 7, 16, 965, DateTimeKind.Local).AddTicks(204), 2, 211m, new Guid("b14267d4-ba1c-48c2-a748-738a8dd657b3") },
                    { new Guid("21c2e9b3-898a-4ac2-93aa-db736420d18c"), "942 Fleta Dam, Hayesside, Lesotho", new DateTime(2021, 5, 13, 9, 21, 11, 313, DateTimeKind.Local).AddTicks(513), 3, 52m, new Guid("628fe593-8138-47e2-b1c3-0b915eac2137") },
                    { new Guid("261e9d8f-1605-4436-b886-115e3752c191"), "922 Kuvalis Ridge, Dustytown, Sri Lanka", new DateTime(2021, 8, 4, 23, 25, 19, 513, DateTimeKind.Local).AddTicks(9650), 2, 55m, new Guid("8347ec76-a6a0-4e66-a300-53bbc9162481") },
                    { new Guid("265e8e24-afd9-4c40-8fb6-95694a975946"), "200 Antwon Locks, Port Gerardoport, Benin", new DateTime(2022, 7, 5, 9, 25, 56, 448, DateTimeKind.Local).AddTicks(7851), 1, 108m, new Guid("53153af0-6c5f-4250-9fc1-1d2dae771d66") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("26606820-77ad-43ad-b170-ba0c54b23b57"), "3863 Catherine Well, Jameybury, Indonesia", new DateTime(2022, 8, 29, 19, 0, 15, 19, DateTimeKind.Local).AddTicks(7192), 51m, new Guid("c68a2f4d-e696-4469-96cb-05f67e35baf5") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("266addb0-2be7-4a19-aafd-442713397afa"), "263 Hauck Knolls, Julieburgh, Estonia", new DateTime(2020, 10, 14, 13, 14, 45, 107, DateTimeKind.Local).AddTicks(6992), 1, 99m, new Guid("e78d5a8f-4c1f-4d2b-bd0c-9e1f6edb31c9") },
                    { new Guid("26fa527f-fffe-401b-b979-a96aa4b10e31"), "638 Evelyn Villages, Lake Hannah, Iceland", new DateTime(2021, 4, 4, 15, 19, 45, 422, DateTimeKind.Local).AddTicks(481), 3, 54m, new Guid("381e24e5-246d-4575-a700-f3d6efaf21e6") },
                    { new Guid("27b04950-2bf5-4a82-933b-bc8f3560f77f"), "48713 Jaskolski Wall, Brendentown, Belgium", new DateTime(2021, 6, 4, 5, 21, 8, 628, DateTimeKind.Local).AddTicks(2893), 1, 53m, new Guid("ec8b2c67-f67d-4b60-a5db-3f30cb2bb7ad") },
                    { new Guid("27cbad4f-ad0f-4b61-930f-1567dc955e4a"), "44400 Dare Station, West Alverafort, Comoros", new DateTime(2021, 2, 8, 6, 7, 3, 472, DateTimeKind.Local).AddTicks(4341), 3, 56m, new Guid("e77747b4-9625-419a-abfa-36565c15162d") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("27cd07bc-0cd1-49e9-875c-dcde46ac0358"), "57788 Erika Lights, West Hailieburgh, Cook Islands", new DateTime(2022, 3, 11, 0, 43, 25, 365, DateTimeKind.Local).AddTicks(2496), 162m, new Guid("e68ffcc4-4e79-4edc-923a-99f84f1beef5") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[] { new Guid("28f2980e-608c-4c4b-bff1-14934b7c4896"), "52594 Kutch Union, East Mason, Northern Mariana Islands", new DateTime(2021, 3, 19, 13, 53, 29, 282, DateTimeKind.Local).AddTicks(8845), 1, 53m, new Guid("43e22ca0-5605-473a-8c99-a45163055822") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("291f2ee3-ad9a-4947-a795-0f70bd2a074e"), "9849 Okuneva Loop, Trantowburgh, Virgin Islands, U.S.", new DateTime(2021, 8, 18, 23, 1, 0, 885, DateTimeKind.Local).AddTicks(9940), 52m, new Guid("b13735c2-689e-4b5f-ba8a-c86b15521f78") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("2a853a0b-4e61-4d6e-9234-020c1efa63e0"), "7857 Marks Parks, Kshlerintown, Ukraine", new DateTime(2020, 2, 8, 5, 52, 56, 53, DateTimeKind.Local).AddTicks(2986), 3, 56m, new Guid("4adbd9bc-fa68-4841-ad03-986240d45f0f") },
                    { new Guid("2a9b3630-c805-4be0-9156-3c638f0a6ee5"), "3067 Aida Lock, South Toreyhaven, Saudi Arabia", new DateTime(2021, 12, 1, 22, 15, 15, 188, DateTimeKind.Local).AddTicks(939), 2, 56m, new Guid("773edfdc-d001-46b4-a5cc-dfed84707368") },
                    { new Guid("2b97a2d7-a4a2-407e-97dc-92041e835bfa"), "646 Howell Forks, Raoulside, Latvia", new DateTime(2020, 2, 20, 23, 7, 51, 143, DateTimeKind.Local).AddTicks(8483), 1, 106m, new Guid("8d14db5d-ba62-4091-a8d8-0a438f714a2e") },
                    { new Guid("2cba95d9-c50d-4131-a870-69561d6f75b3"), "6683 Shields Burgs, Yesseniamouth, Malawi", new DateTime(2020, 3, 8, 8, 33, 18, 531, DateTimeKind.Local).AddTicks(2886), 2, 56m, new Guid("0c26392d-30b7-42cc-8eb5-0780dfdc5b51") },
                    { new Guid("2e592dcc-f9d1-4bc7-8259-be0ed53562a6"), "96123 Ernser Ports, Port Pinkie, Marshall Islands", new DateTime(2021, 10, 13, 10, 12, 49, 971, DateTimeKind.Local).AddTicks(7775), 3, 98m, new Guid("9a7deed9-68f3-444b-a4dc-90368af3e152") },
                    { new Guid("2fe907e2-4282-45e0-9446-c775a81533f5"), "9684 Jerde Creek, Kaleytown, Bahrain", new DateTime(2021, 10, 23, 1, 56, 9, 550, DateTimeKind.Local).AddTicks(6012), 2, 103m, new Guid("eca5f2ed-484c-4c2e-98a1-0c55a46e736b") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("31755173-b0a8-4779-a178-213033d58cef"), "851 Edna Dale, Angusmouth, Croatia", new DateTime(2020, 7, 3, 21, 55, 9, 967, DateTimeKind.Local).AddTicks(6656), 49m, new Guid("eddfac5d-6cae-4cde-a3c3-efee9473a39f") },
                    { new Guid("329c1dd9-bc8b-4d8d-9d7d-060d81cf202d"), "57341 Kling Cliffs, South Alvah, Nepal", new DateTime(2020, 2, 1, 10, 6, 50, 208, DateTimeKind.Local).AddTicks(3895), 54m, new Guid("84f16bdb-6474-4c14-b425-11cac1a565ed") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("339b397d-9aa1-40e2-a9a6-f28b28d5e5ff"), "44845 Jaquan Spurs, Funkchester, Macao", new DateTime(2019, 10, 3, 12, 7, 11, 65, DateTimeKind.Local).AddTicks(9043), 3, 57m, new Guid("19df6af6-edc9-41eb-9780-c9673a802646") },
                    { new Guid("33fcbe5a-0161-477b-b72a-df742ccdf74c"), "64766 Gracie Village, D'Amoreville, Gambia", new DateTime(2021, 1, 4, 18, 14, 35, 13, DateTimeKind.Local).AddTicks(8211), 1, 107m, new Guid("3256fdfd-5743-4dd4-a1a6-2c5bd6cc243d") },
                    { new Guid("3490b4ed-5ce8-4a5c-a849-9f962fa57530"), "696 Ellis Track, South Jordon, Lebanon", new DateTime(2022, 4, 28, 8, 15, 3, 411, DateTimeKind.Local).AddTicks(1725), 3, 52m, new Guid("15319334-a0c5-4c62-86d0-f1d53bff3489") },
                    { new Guid("35c2cdd5-3819-4ba9-9763-ee7349cb03df"), "861 Muller Lane, Britneymouth, Zimbabwe", new DateTime(2022, 5, 15, 3, 12, 28, 409, DateTimeKind.Local).AddTicks(8986), 1, 56m, new Guid("2ebab0ca-259f-4e1a-a4b6-cee82119042e") },
                    { new Guid("3665cbb4-36f0-4413-93ff-98fa84cb8968"), "27871 Champlin Field, Concepciontown, Maldives", new DateTime(2021, 6, 10, 23, 43, 48, 606, DateTimeKind.Local).AddTicks(2005), 3, 108m, new Guid("4356f819-7b05-46c4-a1c9-1ad732249578") },
                    { new Guid("37502bf4-dd7b-4aeb-bcb9-136f166d54bb"), "7745 Brandon Crescent, West Sincerechester, Lithuania", new DateTime(2021, 4, 5, 13, 4, 56, 276, DateTimeKind.Local).AddTicks(9650), 1, 165m, new Guid("eddfac5d-6cae-4cde-a3c3-efee9473a39f") },
                    { new Guid("3c7fdf31-51af-40ba-9880-714f35a1a943"), "96679 Donnelly Grove, Jacobsfurt, Lesotho", new DateTime(2021, 3, 12, 23, 6, 59, 333, DateTimeKind.Local).AddTicks(1832), 2, 49m, new Guid("82fdf04b-b9a1-459d-856e-4f0fa117d309") },
                    { new Guid("3cddb538-a725-4d1b-be2c-1110fa2111d7"), "5976 Jany Courts, Lake Melodyville, Svalbard & Jan Mayen Islands", new DateTime(2021, 4, 8, 23, 57, 18, 490, DateTimeKind.Local).AddTicks(5037), 2, 55m, new Guid("90eeeb9e-3e6e-45ea-a604-b2c4a4f120c7") },
                    { new Guid("3d282e1e-b2ef-48c8-accf-9c67cee0e8df"), "0403 Sporer Bypass, Port Tabitha, Ukraine", new DateTime(2022, 3, 27, 1, 5, 28, 923, DateTimeKind.Local).AddTicks(100), 2, 108m, new Guid("97702012-7129-4edd-8647-6e8382a06ecf") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("3d550ea3-177e-445d-9997-6feb7bae5329"), "4755 Willis Heights, Vandervortton, Slovenia", new DateTime(2021, 7, 24, 2, 55, 40, 146, DateTimeKind.Local).AddTicks(3572), 56m, new Guid("9761bd7c-0c33-4699-a195-123d0475e5c9") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("3dfd9afc-edaa-4976-ad34-c4ea46248b9a"), "491 Maiya Fields, Leonorafurt, Afghanistan", new DateTime(2022, 1, 3, 17, 1, 59, 542, DateTimeKind.Local).AddTicks(3559), 1, 108m, new Guid("a9532690-b916-4d02-aed7-959843a383e9") },
                    { new Guid("3e5f38ca-4be5-4a20-94f8-e3eb4d6f8cba"), "926 Wunsch Shoals, Port Gardner, India", new DateTime(2021, 10, 30, 2, 20, 50, 896, DateTimeKind.Local).AddTicks(4644), 3, 57m, new Guid("77d5add7-0fa4-4c4e-b562-367eb6c81b60") },
                    { new Guid("3e8d0aad-e517-42e5-8eed-279c4b6bc37c"), "311 Rau Harbor, Mariellechester, Reunion", new DateTime(2021, 3, 28, 14, 28, 0, 719, DateTimeKind.Local).AddTicks(3939), 3, 102m, new Guid("d6cb008b-7714-44ca-ad3e-23b47cba6645") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("407b39e3-1297-4c6c-8deb-ea15cddbcd55"), "42499 MacGyver Creek, Arneview, Niger", new DateTime(2021, 1, 11, 2, 28, 47, 406, DateTimeKind.Local).AddTicks(677), 52m, new Guid("2c3a7308-923e-4d08-97cd-c9a7484caf4d") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("425cd297-01c7-4d34-bb83-3a266c4b1cc2"), "93404 Hettinger Streets, South Hannah, Serbia", new DateTime(2021, 9, 20, 18, 50, 12, 494, DateTimeKind.Local).AddTicks(1505), 3, 53m, new Guid("270ecddf-9907-42fc-bc9b-942d0cc12307") },
                    { new Guid("4453eb09-2a58-43b1-aca8-344a57bb465d"), "84764 Bartell Estate, Madisonville, Uganda", new DateTime(2020, 9, 1, 2, 11, 44, 216, DateTimeKind.Local).AddTicks(5033), 1, 56m, new Guid("fb6aabed-ed68-4ad7-88fd-9c08ce9bd65a") },
                    { new Guid("46ad4204-1ac4-46ad-8a85-a6186fc33341"), "7877 Darren Forge, East Emie, Iran", new DateTime(2019, 10, 15, 2, 34, 31, 328, DateTimeKind.Local).AddTicks(4197), 2, 156m, new Guid("01302dc1-dc2a-428a-972b-2e577e969328") },
                    { new Guid("470b5002-1e85-4a1d-95fd-6c95b3fd9264"), "5457 Emard Cape, West Kristopherborough, Gabon", new DateTime(2021, 2, 3, 3, 31, 9, 131, DateTimeKind.Local).AddTicks(8852), 2, 55m, new Guid("067c01d4-9e11-4ee5-8737-67243f6c35fd") },
                    { new Guid("47f75e7b-a7f7-4ce0-a2c2-e8e3c216fa40"), "817 Lindgren Shoal, Virginiemouth, Namibia", new DateTime(2021, 5, 28, 1, 47, 12, 43, DateTimeKind.Local).AddTicks(3302), 3, 52m, new Guid("69d4f607-c460-4536-8a8a-6c836dea239f") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("48235d43-9930-4c98-aecb-88efd3614e57"), "858 Landen Lodge, East Benniebury, Czech Republic", new DateTime(2022, 5, 8, 4, 30, 17, 799, DateTimeKind.Local).AddTicks(8705), 2, 50m, new Guid("11c50dc3-fb1a-40b7-b0d0-a53f191019fe") },
                    { new Guid("4ae01edd-d5b3-4a6c-8657-0842a7173333"), "4528 Elza Burgs, New Enosside, Brunei Darussalam", new DateTime(2020, 4, 6, 2, 53, 20, 698, DateTimeKind.Local).AddTicks(3615), 1, 107m, new Guid("796c6eb7-721c-4bfa-a2f0-99959639ce3b") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("4b59c546-4303-4fed-8c0a-03a619f8fde2"), "0962 Bergstrom Mountains, West Lilachester, Reunion", new DateTime(2021, 6, 23, 6, 31, 9, 581, DateTimeKind.Local).AddTicks(7117), 55m, new Guid("0caa8135-c46f-4c5b-b19c-99288b58aa64") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("4bab686f-b843-4c1f-8855-8f79e191b0ad"), "96588 Prohaska Pine, West Kadin, Solomon Islands", new DateTime(2020, 3, 17, 8, 8, 56, 988, DateTimeKind.Local).AddTicks(9773), 2, 49m, new Guid("5c83883f-fad2-4805-aadc-6d2f79b7ee11") },
                    { new Guid("4c6fcb42-e354-4b1a-b8e1-99311239fa29"), "507 Gerda Lights, East Lenora, Mozambique", new DateTime(2020, 9, 3, 7, 0, 41, 571, DateTimeKind.Local).AddTicks(8898), 2, 53m, new Guid("0b6056fa-3bf0-46a3-adb4-db0c3812c19f") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("4f726b8e-4e52-4f72-8ea3-41ea36c1b12e"), "567 Forest Neck, Port Troytown, Maldives", new DateTime(2020, 8, 8, 11, 54, 9, 575, DateTimeKind.Local).AddTicks(1814), 49m, new Guid("86287960-5440-4ad7-aacb-b301fcd5d399") },
                    { new Guid("5092e030-1d8d-4c6f-806a-818ae7dc1215"), "7726 Karlee Trail, Harleymouth, Tonga", new DateTime(2021, 2, 21, 23, 50, 48, 3, DateTimeKind.Local).AddTicks(9725), 50m, new Guid("e499e88f-c288-445f-80ed-a42fe4dd49ac") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("50bd7eec-c9d8-40ce-a8e4-ae4dd2376113"), "284 Geovany Port, South Samantha, Greece", new DateTime(2020, 11, 5, 0, 48, 54, 196, DateTimeKind.Local).AddTicks(2372), 2, 108m, new Guid("043672a4-e4f6-4867-8c45-915784f489c2") },
                    { new Guid("5201e150-83ca-48d8-b84a-a2940594f9bc"), "75920 Ova Stravenue, Gusside, Grenada", new DateTime(2019, 12, 15, 10, 12, 29, 124, DateTimeKind.Local).AddTicks(3841), 2, 207m, new Guid("b5b33e40-0c7b-4e9a-b18e-22de587ea633") },
                    { new Guid("547d3ac7-cc57-4085-8726-3818e89a00d2"), "92704 Uriel Crossing, South Major, Tonga", new DateTime(2021, 8, 6, 22, 56, 24, 734, DateTimeKind.Local).AddTicks(3037), 3, 53m, new Guid("0276138c-2bf3-4896-87d9-6dc15c4d4c59") },
                    { new Guid("548068e5-d9ba-4e10-b19c-ae566c16d563"), "5006 Little Villages, Port Eladiochester, Montenegro", new DateTime(2021, 1, 31, 14, 34, 35, 746, DateTimeKind.Local).AddTicks(5124), 2, 151m, new Guid("0a3ee9be-b9f0-465c-b9cf-46974a2da0dd") },
                    { new Guid("55ac52a6-fa08-419d-bd28-3de97af78f31"), "6284 Berge Lights, East Jabari, French Southern Territories", new DateTime(2020, 4, 20, 13, 10, 27, 204, DateTimeKind.Local).AddTicks(2447), 1, 101m, new Guid("a6040bb0-4731-416e-a69d-37be395a80eb") },
                    { new Guid("5626d64e-f20e-4fba-b9c4-4fd6c73b3012"), "7602 Jacobs Locks, Gerholdtown, Angola", new DateTime(2019, 10, 7, 7, 22, 6, 292, DateTimeKind.Local).AddTicks(2791), 1, 51m, new Guid("96bd62c7-b5be-46ac-adeb-71c5b953c0c7") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("567b1de9-4ea0-467f-9846-688e7a604562"), "313 Lesch Shores, Douglasshire, India", new DateTime(2019, 12, 9, 4, 12, 35, 319, DateTimeKind.Local).AddTicks(254), 56m, new Guid("239cebd3-9967-434b-8d53-3867f492cd02") },
                    { new Guid("56ce024e-2af2-4b34-bedb-ea30dd405c08"), "260 Hilpert Views, Port Chadhaven, Saint Martin", new DateTime(2021, 5, 17, 7, 56, 1, 988, DateTimeKind.Local).AddTicks(6776), 52m, new Guid("0f528f4d-1f92-4ea1-ba04-1888e59ae189") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("596f670a-752f-4bf8-ac93-224a15012fbb"), "71885 Koss Lakes, Reedview, Antarctica (the territory South of 60 deg S)", new DateTime(2021, 1, 4, 1, 48, 29, 255, DateTimeKind.Local).AddTicks(7126), 2, 265m, new Guid("88ed3d09-93e1-4756-841a-17e090fcdb69") },
                    { new Guid("597ae486-beae-4334-b730-fb40e58ef537"), "9893 Zaria Mountain, Wilsonshire, Ireland", new DateTime(2020, 12, 2, 10, 28, 51, 681, DateTimeKind.Local).AddTicks(3002), 3, 49m, new Guid("626210e2-6312-4a25-acff-91a4f45e91c0") },
                    { new Guid("5b0a124b-95fa-4ab6-b48c-a0a8c1a2ccef"), "79559 Newell Village, Tristianfurt, Montenegro", new DateTime(2021, 11, 3, 12, 47, 33, 954, DateTimeKind.Local).AddTicks(4439), 1, 56m, new Guid("25609b04-0c2b-43f2-9783-826a59c477ea") },
                    { new Guid("5c3bc75d-3342-4f19-b9d1-3253fbd1cec3"), "1692 Gutkowski Corner, East Archibald, Kiribati", new DateTime(2022, 8, 19, 22, 33, 46, 301, DateTimeKind.Local).AddTicks(9840), 3, 112m, new Guid("11c96990-c470-4f15-a522-e34365574d87") },
                    { new Guid("5e05146f-b1fa-4949-b0b6-f8363ff3bb9f"), "505 Legros Skyway, Narcisobury, Lao People's Democratic Republic", new DateTime(2019, 12, 2, 21, 28, 21, 219, DateTimeKind.Local).AddTicks(8139), 1, 53m, new Guid("60ad00c5-2e6c-4726-9ea7-0f5a99ab75bb") },
                    { new Guid("5e670ce7-7a0d-456c-81e1-1c1eb380bed0"), "7415 Dejuan Squares, New Genevieveside, Norway", new DateTime(2020, 8, 16, 2, 55, 54, 551, DateTimeKind.Local).AddTicks(7100), 3, 57m, new Guid("d2ecdc85-a658-4fde-8cfb-bcbc2d89545c") },
                    { new Guid("5eb24e1d-a6ef-47a3-a042-5cd191eca1a6"), "148 Predovic Shores, West Ima, Svalbard & Jan Mayen Islands", new DateTime(2022, 3, 7, 4, 8, 33, 844, DateTimeKind.Local).AddTicks(7231), 3, 107m, new Guid("ad75f22f-6b6e-4b21-a0cb-3a76cdfb3834") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("5ed64f54-9bcc-4673-8d69-eabdb07003d2"), "86424 Nitzsche Forge, Alexandrashire, Norway", new DateTime(2021, 12, 16, 6, 30, 18, 547, DateTimeKind.Local).AddTicks(750), 53m, new Guid("45a2ef44-f22d-4855-bfc6-4ee2f9f7957b") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("5f514b03-4905-4291-8281-0007fa287506"), "66235 Sawayn Bridge, West Trevion, Saint Pierre and Miquelon", new DateTime(2022, 5, 14, 18, 54, 23, 349, DateTimeKind.Local).AddTicks(8155), 1, 108m, new Guid("c8bcd758-d56d-4af2-8d6d-9244d9e00e4b") },
                    { new Guid("60a73766-96ef-44cb-8d3c-170fd976359a"), "552 Kuhn Glens, Murraybury, Sudan", new DateTime(2022, 6, 20, 20, 47, 31, 650, DateTimeKind.Local).AddTicks(6329), 3, 217m, new Guid("560e5175-fb95-4da9-a517-dc5c1a1e0b14") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("61315754-2ef8-40e8-b029-15b7da15b112"), "0930 Stamm Lake, North Adrianachester, Antarctica (the territory South of 60 deg S)", new DateTime(2021, 7, 16, 18, 14, 46, 10, DateTimeKind.Local).AddTicks(8799), 149m, new Guid("8c580832-6410-4d5a-9209-a751967490a3") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("621371f3-9f2e-46d9-b0b6-2b95942722b8"), "99046 Hauck Parks, Wellingtonmouth, Afghanistan", new DateTime(2020, 1, 17, 17, 44, 23, 728, DateTimeKind.Local).AddTicks(357), 3, 52m, new Guid("1a337000-86fb-41ee-b1bb-d86055e93289") },
                    { new Guid("63a4d70d-86a3-4dec-a6dd-3e4ceb463855"), "3978 Sage Center, Wymanmouth, Bouvet Island (Bouvetoya)", new DateTime(2020, 11, 9, 11, 17, 6, 383, DateTimeKind.Local).AddTicks(6332), 1, 54m, new Guid("53153af0-6c5f-4250-9fc1-1d2dae771d66") },
                    { new Guid("643f767e-a5a2-44a7-8502-dc8728556131"), "216 Howell Vista, Port Savanna, Guyana", new DateTime(2022, 5, 3, 7, 42, 29, 589, DateTimeKind.Local).AddTicks(7877), 1, 57m, new Guid("915a1175-d5a2-4afc-a399-939d8a9906d6") },
                    { new Guid("645bf33f-1d43-4e5c-bbd6-959663a4ddc6"), "592 Gleichner Tunnel, Lake Sisterburgh, Sudan", new DateTime(2020, 2, 18, 18, 31, 36, 255, DateTimeKind.Local).AddTicks(3185), 1, 54m, new Guid("15319334-a0c5-4c62-86d0-f1d53bff3489") },
                    { new Guid("65729050-a4ca-4fdb-9156-e08b2211f5d1"), "10402 Justina Forge, Elishaville, Micronesia", new DateTime(2021, 4, 19, 23, 37, 20, 288, DateTimeKind.Local).AddTicks(9515), 2, 50m, new Guid("94ffc259-6ddd-4f60-8f2a-53e0ef66e1d6") },
                    { new Guid("66c8f9c9-ac72-4a35-bde9-49eb54e698db"), "128 Sydnie Glens, New Damianport, French Southern Territories", new DateTime(2019, 9, 3, 4, 6, 2, 193, DateTimeKind.Local).AddTicks(2490), 2, 99m, new Guid("14409857-3513-4e48-a05b-17f6640b5d79") },
                    { new Guid("67944129-15e4-4349-b85a-0d08ee59130d"), "2197 Caterina Flats, Giovanistad, Andorra", new DateTime(2019, 9, 11, 9, 29, 21, 675, DateTimeKind.Local).AddTicks(216), 2, 57m, new Guid("064bc469-6646-4a69-9a79-ed3a2f2f63a0") },
                    { new Guid("67d91738-294e-4a2c-b686-088e3231c4bd"), "9591 Gottlieb Lake, Wehnerfurt, India", new DateTime(2020, 8, 16, 9, 26, 18, 125, DateTimeKind.Local).AddTicks(5261), 1, 214m, new Guid("97e09b26-a152-4d85-9c12-c3d35feeb2f3") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("680ab800-d5da-4f26-ad86-eafee1d7616a"), "8790 Cristopher Road, Thielhaven, Western Sahara", new DateTime(2021, 1, 2, 8, 55, 8, 948, DateTimeKind.Local).AddTicks(3700), 54m, new Guid("a3247dc7-f54b-4c43-82d0-94d497dfc13f") },
                    { new Guid("680fd838-497b-4b60-841e-1f22fa436dc3"), "25367 Grace Forge, Hellerhaven, Montserrat", new DateTime(2021, 11, 26, 22, 18, 43, 54, DateTimeKind.Local).AddTicks(3874), 49m, new Guid("56dd5f94-c828-4539-a379-635fe6fbe426") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("688049ad-5911-4dff-bd78-d74a6d3e371e"), "40154 Margarita Lane, Camdenshire, Dominica", new DateTime(2021, 6, 23, 15, 56, 3, 6, DateTimeKind.Local).AddTicks(7484), 1, 50m, new Guid("ec8b2c67-f67d-4b60-a5db-3f30cb2bb7ad") },
                    { new Guid("68a2d01f-d984-45b5-9125-9be9d111e247"), "267 Mayer Hill, Lake Stanford, Dominica", new DateTime(2019, 12, 13, 17, 45, 10, 588, DateTimeKind.Local).AddTicks(1307), 1, 107m, new Guid("6ba9a6d3-c83a-4e39-988a-10de04cf4b13") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("699bea92-fdf6-4f74-ad82-7aad77ca7a8f"), "096 Wisoky Route, Rowlandland, Austria", new DateTime(2022, 6, 27, 3, 37, 6, 525, DateTimeKind.Local).AddTicks(130), 108m, new Guid("fbacffec-e616-4182-9771-935b786124a9") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[] { new Guid("6a0f9516-df1c-4ea2-aaab-6c5c2ed1d21a"), "8255 Rowe Corner, New Elta, Paraguay", new DateTime(2022, 1, 31, 13, 0, 52, 173, DateTimeKind.Local).AddTicks(895), 3, 52m, new Guid("87149a1a-02e6-48af-9a18-fa3e00200bb9") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("6a265d01-8810-40e1-a8be-95a19432c845"), "5561 Shields Shoal, Lake Kaydenport, Jersey", new DateTime(2021, 11, 10, 21, 1, 13, 511, DateTimeKind.Local).AddTicks(1211), 105m, new Guid("560e5175-fb95-4da9-a517-dc5c1a1e0b14") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[] { new Guid("6ab5a5ac-75ec-40bb-b23e-79228a9dd12c"), "5834 Monahan Highway, Everetttown, Burundi", new DateTime(2020, 9, 24, 16, 17, 26, 47, DateTimeKind.Local).AddTicks(9536), 1, 107m, new Guid("f107917f-7f32-4619-8cf9-ce7fd13da715") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("6abbfcaa-13b7-4b69-a02a-573be067ddcb"), "705 Leffler Station, Makennahaven, French Guiana", new DateTime(2019, 12, 17, 13, 54, 5, 862, DateTimeKind.Local).AddTicks(6000), 3, 147m, new Guid("a54477d3-cc3f-4ef9-9be7-bbc1244dfc11") },
                    { new Guid("6bfa5f85-6a03-4bab-b5aa-d9075c7d380a"), "89866 Leon Common, Daughertystad, Ecuador", new DateTime(2020, 11, 22, 0, 14, 43, 593, DateTimeKind.Local).AddTicks(3744), 3, 54m, new Guid("d8020b65-bef1-4049-9921-cef79cbb5cdd") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("6d5e0934-577f-4fe2-bae2-91bfe93d7d1f"), "705 Carter Key, North Renestad, Antarctica (the territory South of 60 deg S)", new DateTime(2022, 8, 28, 10, 16, 41, 589, DateTimeKind.Local).AddTicks(3905), 49m, new Guid("3e22768c-6406-47fc-8a17-a0a7cbbed4dc") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("6e4810b9-a611-497b-9a99-c770d52df1de"), "2464 Burnice Isle, Bahringerville, Senegal", new DateTime(2020, 6, 24, 7, 10, 15, 185, DateTimeKind.Local).AddTicks(3616), 1, 114m, new Guid("28a78bc0-9e79-4915-8e06-45c7f5a6d224") },
                    { new Guid("6edcd7e3-e8b8-4e02-8a56-1c8b567faf30"), "7989 Schumm Coves, Annabellefurt, Faroe Islands", new DateTime(2020, 3, 30, 23, 38, 46, 129, DateTimeKind.Local).AddTicks(813), 1, 52m, new Guid("28a78bc0-9e79-4915-8e06-45c7f5a6d224") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("70022831-94be-4a7d-92f3-d658aaa0acc4"), "5114 Pansy Island, Rosaliafort, Fiji", new DateTime(2022, 5, 22, 20, 22, 7, 349, DateTimeKind.Local).AddTicks(3130), 160m, new Guid("6ad107d8-dbb8-4082-a022-c925c419453d") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("72685788-1888-4813-88f9-46aadc9d1b42"), "58924 Rau Villages, Marcelinachester, Bouvet Island (Bouvetoya)", new DateTime(2020, 3, 18, 13, 7, 43, 435, DateTimeKind.Local).AddTicks(6027), 3, 106m, new Guid("3f3c903e-3714-4166-a387-7f304e0a3c8b") },
                    { new Guid("7358ead3-2382-4554-a54f-ccb708392adb"), "27538 Schoen Roads, Shanaburgh, Denmark", new DateTime(2021, 3, 27, 3, 32, 3, 751, DateTimeKind.Local).AddTicks(6057), 3, 49m, new Guid("82072524-5a57-4b6e-9fd6-4bc8845bafc7") },
                    { new Guid("73aabdbc-7be9-4b6a-a164-81385af16fe9"), "229 Rohan Orchard, Port Jadynstad, Brunei Darussalam", new DateTime(2022, 6, 11, 8, 53, 39, 342, DateTimeKind.Local).AddTicks(755), 1, 101m, new Guid("c25cb24d-824c-4cab-af63-b823f28b2770") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("745d91b9-a5b8-44c4-b780-702cd5785366"), "80957 Adams Run, Port Gerald, Algeria", new DateTime(2020, 12, 2, 17, 57, 28, 577, DateTimeKind.Local).AddTicks(8071), 209m, new Guid("a7a3264c-773f-4b86-9b6b-a8a241f949dd") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[] { new Guid("75c1aba8-ecd8-4e98-b834-867580ae35a6"), "5490 Noel Parkways, Mohammadhaven, Mozambique", new DateTime(2022, 4, 14, 1, 4, 14, 796, DateTimeKind.Local).AddTicks(6479), 3, 55m, new Guid("d95f5558-a372-49b0-bfe0-b5d24a034ef7") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("7735af9e-da78-4d2b-8b72-b9a48048103f"), "027 Morissette Junctions, North Deon, Lao People's Democratic Republic", new DateTime(2020, 4, 4, 11, 2, 50, 316, DateTimeKind.Local).AddTicks(9195), 111m, new Guid("560e5175-fb95-4da9-a517-dc5c1a1e0b14") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("791274fb-be73-47cf-9780-8956ebe4c5ca"), "8500 Strosin Loop, Paucekport, Eritrea", new DateTime(2022, 7, 2, 0, 31, 42, 873, DateTimeKind.Local).AddTicks(4086), 2, 114m, new Guid("4167327d-35e9-4a70-ab17-d0e2d12e942d") },
                    { new Guid("798d97f3-d90a-42ce-994e-f34501704b49"), "30477 Koepp Village, New Everardo, Monaco", new DateTime(2020, 8, 15, 14, 39, 18, 170, DateTimeKind.Local).AddTicks(3455), 3, 50m, new Guid("8a0a8d04-c577-4c94-8dbb-0c6f023ddef2") },
                    { new Guid("7a13336e-1de9-4209-a2d7-6f2df9e7d595"), "5109 Kuhic Points, Bernhardport, San Marino", new DateTime(2022, 2, 25, 20, 45, 34, 108, DateTimeKind.Local).AddTicks(9270), 2, 49m, new Guid("0f3b2512-e952-40e6-86cf-bb6943474337") },
                    { new Guid("7a958c06-c942-488c-adc2-8e1da84f7bc9"), "0929 Jones Trail, Dooleyfurt, Syrian Arab Republic", new DateTime(2021, 5, 27, 19, 14, 26, 357, DateTimeKind.Local).AddTicks(6475), 2, 54m, new Guid("270ecddf-9907-42fc-bc9b-942d0cc12307") },
                    { new Guid("7a980748-bcca-40aa-8478-b5990333e049"), "80395 Okuneva Corner, Lake Julien, France", new DateTime(2021, 1, 23, 2, 19, 18, 849, DateTimeKind.Local).AddTicks(4152), 3, 51m, new Guid("770952fc-e3fe-475d-ab06-730f7d350d2f") },
                    { new Guid("7b8a33cb-0472-48b4-ad42-69201d8f2c18"), "468 Fay Walks, Lucasland, Reunion", new DateTime(2020, 11, 18, 12, 28, 32, 287, DateTimeKind.Local).AddTicks(8792), 2, 104m, new Guid("f97505d4-1b35-45fa-b048-067ec13fd573") },
                    { new Guid("7bab36fd-2a86-409c-971e-9187439b462c"), "4418 Violette Mission, Port Marley, Indonesia", new DateTime(2020, 11, 10, 19, 46, 13, 902, DateTimeKind.Local).AddTicks(9313), 2, 100m, new Guid("7dbc8dc2-3dae-4c00-ba75-fa59107867fc") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("7c07859b-9516-493d-be0e-9c88eebaed1e"), "54561 Nickolas Cove, South Brooklyn, Saint Vincent and the Grenadines", new DateTime(2022, 7, 22, 6, 8, 41, 346, DateTimeKind.Local).AddTicks(1006), 53m, new Guid("2bd769d5-4c31-4a7d-9cd4-3834cc0f4361") },
                    { new Guid("7ca7c879-5dc5-4ad2-b9d8-a74f2eaf3f5e"), "68553 Maggio Radial, West Carmelomouth, United Arab Emirates", new DateTime(2022, 6, 15, 19, 42, 30, 151, DateTimeKind.Local).AddTicks(2720), 108m, new Guid("f97505d4-1b35-45fa-b048-067ec13fd573") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("7d093f45-5998-4d26-8f72-ca6cdfc473fd"), "3456 Hans Fall, Evansview, New Zealand", new DateTime(2022, 2, 18, 17, 40, 29, 846, DateTimeKind.Local).AddTicks(3747), 2, 111m, new Guid("930ade73-635c-4623-bec6-11604ea6807e") },
                    { new Guid("7dbf3e2b-8bbb-4f83-84f8-19ffddf8ba7b"), "4803 Bart Turnpike, North Florian, Saint Helena", new DateTime(2021, 5, 30, 18, 9, 19, 887, DateTimeKind.Local).AddTicks(6941), 3, 104m, new Guid("15319334-a0c5-4c62-86d0-f1d53bff3489") },
                    { new Guid("7deabc92-1179-4b2b-b908-477f73cdaf11"), "7476 Lesch Cape, New Estebanbury, Cape Verde", new DateTime(2020, 11, 29, 5, 21, 5, 80, DateTimeKind.Local).AddTicks(9285), 3, 55m, new Guid("d07b5d3d-8485-44cf-919c-2328838983f9") },
                    { new Guid("7e09f425-5bf6-45af-95cd-0a55a61f1c40"), "14702 Hintz Ways, East Garrick, Guatemala", new DateTime(2022, 8, 30, 7, 38, 9, 112, DateTimeKind.Local).AddTicks(9852), 3, 50m, new Guid("b95ab0ab-6cf5-4931-bb76-7910e5a2ea52") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("7e510a3a-9ac9-4b82-a868-1fcbe3704a82"), "43785 Eduardo Unions, New Gabriel, Gambia", new DateTime(2021, 8, 4, 17, 15, 48, 396, DateTimeKind.Local).AddTicks(8936), 108m, new Guid("51fa8db9-d3af-4c88-a2da-cd1f9c8be74e") },
                    { new Guid("7e69f3d7-d018-41a8-ac78-4aa485febfa5"), "658 Emil Plains, Johnstonfort, Wallis and Futuna", new DateTime(2022, 3, 11, 3, 7, 8, 830, DateTimeKind.Local).AddTicks(5609), 50m, new Guid("08af178e-1865-49ff-ab7c-5095abe8e2cf") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("7e74cde7-3e0a-432a-b0f5-0a18f5ed9cd2"), "7109 Lucius Haven, Muellerbury, Germany", new DateTime(2020, 10, 31, 12, 55, 43, 367, DateTimeKind.Local).AddTicks(7013), 3, 105m, new Guid("45a2ef44-f22d-4855-bfc6-4ee2f9f7957b") },
                    { new Guid("7eddae9f-9286-495b-8c0f-debe878d07ea"), "160 Sigmund Skyway, East Carlishire, Belgium", new DateTime(2020, 2, 23, 22, 51, 25, 39, DateTimeKind.Local).AddTicks(9049), 3, 105m, new Guid("eca5f2ed-484c-4c2e-98a1-0c55a46e736b") },
                    { new Guid("7f5b1167-c427-41f9-91be-cc311cfafb62"), "17417 Sam Manor, Gerlachborough, Sri Lanka", new DateTime(2020, 2, 11, 5, 20, 50, 446, DateTimeKind.Local).AddTicks(6965), 3, 53m, new Guid("daeccf70-a7dc-49b3-89a7-6d40e34537f3") },
                    { new Guid("7f843a65-f36d-4982-be33-f8bdfe052b07"), "972 Stehr Grove, Erdmanshire, Christmas Island", new DateTime(2022, 6, 30, 21, 54, 39, 740, DateTimeKind.Local).AddTicks(6676), 2, 55m, new Guid("37e4c027-05c0-40a6-a02a-618d6235ffbf") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("80d2e4a5-545c-4ab1-a458-569d45ccc022"), "64993 Guillermo Courts, Mullermouth, Suriname", new DateTime(2022, 6, 14, 1, 4, 4, 846, DateTimeKind.Local).AddTicks(182), 105m, new Guid("280ded32-b1e1-4bb2-94b3-9311728d75d4") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("8181e5e6-67d7-46f2-8ce4-f6975e9cb204"), "3922 Christiansen Mission, Wilhelminefort, Iceland", new DateTime(2021, 9, 28, 6, 36, 17, 774, DateTimeKind.Local).AddTicks(3611), 3, 55m, new Guid("6c62a6c1-8ca6-4be5-b2f3-17d2c87eda17") },
                    { new Guid("8390bef3-a7b8-43fc-ac61-acd5a55ab3b6"), "005 Stewart Harbors, Estelleburgh, Slovenia", new DateTime(2019, 11, 20, 17, 27, 1, 719, DateTimeKind.Local).AddTicks(9065), 1, 54m, new Guid("5217998b-75f3-47f2-8933-62dc3850a087") },
                    { new Guid("84c72ab0-f971-422e-ab27-15b06843abb4"), "379 Edyth Island, West Loraberg, Malaysia", new DateTime(2022, 2, 4, 9, 20, 57, 634, DateTimeKind.Local).AddTicks(4869), 3, 52m, new Guid("fda61204-87ca-4bf3-932e-7ed1ff357cc5") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("84dc49c4-2088-461d-9714-46bca62bd32d"), "3145 June Loaf, North Sonia, Wallis and Futuna", new DateTime(2019, 11, 21, 19, 20, 1, 900, DateTimeKind.Local).AddTicks(358), 57m, new Guid("fa42e9ca-49de-40ba-a1bb-1d54c80a2aef") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("852b180a-6a85-49f9-9a4d-d82f3343bf1b"), "083 Teresa Village, Melvinafurt, Estonia", new DateTime(2021, 4, 5, 3, 28, 31, 167, DateTimeKind.Local).AddTicks(4411), 3, 100m, new Guid("1b11aed1-7564-4fab-bec0-cc39d0673529") },
                    { new Guid("85be8590-cfd8-4f63-8b9a-d874fe027b6b"), "180 Prosacco Road, South Devonte, Ukraine", new DateTime(2021, 5, 7, 14, 22, 12, 182, DateTimeKind.Local).AddTicks(4567), 3, 55m, new Guid("dfc4301d-1c42-4c0d-b034-6e7400c89e3b") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("86007e46-c7b6-4e30-9fc8-55903fe629ea"), "19931 Price Turnpike, Melyssastad, Benin", new DateTime(2021, 8, 30, 15, 23, 16, 863, DateTimeKind.Local).AddTicks(104), 218m, new Guid("23feb8af-3f7b-4a14-a10a-98cf431206f4") },
                    { new Guid("86ee9e2d-2d4f-4a96-8b46-2fd891d0d461"), "31008 Patrick Road, Lake Joyceview, Tonga", new DateTime(2020, 9, 14, 6, 58, 24, 234, DateTimeKind.Local).AddTicks(1176), 54m, new Guid("8627c89d-8f75-48c8-93a1-8e994182a468") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("877b7f69-7a1c-4d19-b612-83c0c9853845"), "65957 Rene Dam, Rosarioland, Lao People's Democratic Republic", new DateTime(2022, 1, 7, 6, 35, 6, 194, DateTimeKind.Local).AddTicks(6335), 3, 50m, new Guid("24a31b98-245c-41c6-9acf-936c57032173") },
                    { new Guid("87d4176a-3784-4ada-a12b-a4a0c179003c"), "83314 Clementina Trail, Brandthaven, Luxembourg", new DateTime(2022, 2, 1, 19, 46, 48, 690, DateTimeKind.Local).AddTicks(3873), 3, 49m, new Guid("d45b450a-0c6c-4975-88c4-ce2fe5ef95af") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("88f8318c-c6a3-410e-8201-9f373be10bd8"), "096 Lueilwitz Points, North Clay, Tonga", new DateTime(2022, 7, 25, 20, 28, 48, 994, DateTimeKind.Local).AddTicks(650), 1, 220m, new Guid("1b11aed1-7564-4fab-bec0-cc39d0673529") },
                    { new Guid("89141d58-b274-4293-89bc-43637fe34d65"), "52277 Lemke Spur, North Victor, Nauru", new DateTime(2020, 8, 5, 0, 4, 59, 359, DateTimeKind.Local).AddTicks(2394), 3, 162m, new Guid("e84a35bb-b268-4ea9-a53a-1333d4ac8c0b") },
                    { new Guid("8a429ee5-c3cb-42b8-a936-7ac1dadf652e"), "358 Jo Junctions, Eltonland, Chad", new DateTime(2021, 10, 17, 13, 37, 42, 427, DateTimeKind.Local).AddTicks(1115), 2, 51m, new Guid("2ce0809f-ad99-46ab-bf53-75db24355ce8") },
                    { new Guid("8c678b4b-0967-4a9f-a09c-f1335a301e40"), "710 Durgan Crest, East Precious, Mali", new DateTime(2020, 3, 17, 12, 8, 20, 164, DateTimeKind.Local).AddTicks(3832), 3, 49m, new Guid("546813a7-cc39-48dc-a117-0ba86c9dd603") },
                    { new Guid("8db051ca-1281-4eb7-8974-f141a53409d0"), "22790 Terry Creek, West Joshuahmouth, United Arab Emirates", new DateTime(2022, 8, 6, 11, 26, 53, 744, DateTimeKind.Local).AddTicks(7879), 2, 57m, new Guid("90eeeb9e-3e6e-45ea-a604-b2c4a4f120c7") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("8e0af860-1d6d-4d6e-9246-bd4b01ac7654"), "47781 Michelle Heights, Port Lincoln, Cook Islands", new DateTime(2019, 11, 4, 12, 21, 15, 698, DateTimeKind.Local).AddTicks(5491), 55m, new Guid("14fa6844-2d13-44b9-baae-7b4b7609e98f") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("8e3d541f-27ce-4531-8254-03133281e4c1"), "0933 Beier Drive, Naderstad, Antigua and Barbuda", new DateTime(2021, 3, 26, 4, 20, 21, 120, DateTimeKind.Local).AddTicks(2488), 2, 57m, new Guid("d9caefbb-4405-489a-8158-f4f6f1ccef0c") },
                    { new Guid("8fdf96c3-5a81-43e9-8f21-f5337bf36f31"), "01319 Green Parkways, New Eldredberg, Togo", new DateTime(2021, 11, 4, 1, 6, 31, 894, DateTimeKind.Local).AddTicks(8936), 3, 56m, new Guid("5a31fe0a-1cd4-4773-9f72-59dbf812e63b") },
                    { new Guid("90569cfc-0220-421d-add9-31d469ec7b4c"), "165 Cassie Squares, Emmettport, Pakistan", new DateTime(2020, 12, 12, 10, 48, 4, 173, DateTimeKind.Local).AddTicks(3983), 2, 161m, new Guid("859d5504-acfb-42f4-944a-1ff0961dfa4b") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("922da749-67d4-4af6-a59d-3eae43f26854"), "50979 O'Conner Lock, Marieburgh, Jordan", new DateTime(2020, 3, 28, 9, 16, 13, 28, DateTimeKind.Local).AddTicks(9773), 52m, new Guid("61830f27-8cbc-4e1c-894e-881227c41830") },
                    { new Guid("923da64f-5b9f-4b14-9729-621186788125"), "84653 Grimes Street, Borershire, Central African Republic", new DateTime(2020, 10, 19, 10, 19, 31, 439, DateTimeKind.Local).AddTicks(3983), 111m, new Guid("db3cdd11-b75f-4b8b-af34-8181e865b2d8") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("924e3956-1604-4620-af21-09e9598d4d69"), "58383 Rolfson Place, Lake Brock, Somalia", new DateTime(2021, 10, 29, 2, 0, 22, 126, DateTimeKind.Local).AddTicks(4854), 2, 49m, new Guid("27fcdc89-c1eb-4dd0-bf83-09635f277250") },
                    { new Guid("9256ea8b-8778-4b03-836c-ff6884728a66"), "0092 Nolan Gardens, Lake Lizzie, Uganda", new DateTime(2021, 7, 8, 2, 48, 29, 371, DateTimeKind.Local).AddTicks(8262), 1, 54m, new Guid("78ada214-9bc8-4288-8757-bb09cda077ee") },
                    { new Guid("92766157-8f58-4b56-b901-b1e198f62c34"), "25208 Waters Fields, Jeffreyberg, Kazakhstan", new DateTime(2021, 8, 4, 1, 13, 41, 210, DateTimeKind.Local).AddTicks(6616), 1, 55m, new Guid("bbcf7301-ea1f-4ded-b978-0c4c23e48014") },
                    { new Guid("97b78ce3-151c-43c0-a61a-32453c606d28"), "893 Barton Union, Port Delphine, Northern Mariana Islands", new DateTime(2022, 1, 24, 7, 47, 53, 846, DateTimeKind.Local).AddTicks(7975), 1, 267m, new Guid("8972d367-079c-47c0-b869-c2ae9bb421e4") },
                    { new Guid("9852ea3f-d53e-4f9e-b9e2-f865454b2a46"), "08427 Marks Flats, Malvinafurt, Cameroon", new DateTime(2021, 4, 4, 6, 44, 1, 227, DateTimeKind.Local).AddTicks(3037), 2, 102m, new Guid("4356f819-7b05-46c4-a1c9-1ad732249578") },
                    { new Guid("98ad25ae-4187-4054-b85a-e18f5e3b7f91"), "15980 Pearlie Street, Morriston, Dominican Republic", new DateTime(2021, 4, 17, 20, 29, 46, 941, DateTimeKind.Local).AddTicks(3329), 2, 52m, new Guid("f9676000-6bc6-4bb5-91c0-90b5afb6a5d6") },
                    { new Guid("9925f4b9-5431-4704-a6b7-bf4283c8a348"), "053 Polly Mill, Cartwrightmouth, Reunion", new DateTime(2019, 12, 28, 0, 20, 3, 403, DateTimeKind.Local).AddTicks(9425), 1, 54m, new Guid("d2c4ce5a-9d27-4593-9e0f-7d6842f0e930") },
                    { new Guid("99429c32-4613-4490-a153-288232efbdc1"), "46230 Wolff Parkways, Millermouth, Congo", new DateTime(2021, 10, 6, 5, 11, 32, 985, DateTimeKind.Local).AddTicks(9926), 2, 56m, new Guid("f9676000-6bc6-4bb5-91c0-90b5afb6a5d6") },
                    { new Guid("9957e0d1-96c3-4159-937d-f2e7df48b85b"), "437 Anais Oval, West Sister, Tunisia", new DateTime(2021, 6, 29, 1, 7, 21, 708, DateTimeKind.Local).AddTicks(8268), 1, 102m, new Guid("0b0e7f66-7dc0-4d50-80d5-0eefcab918cb") },
                    { new Guid("996dc268-b107-4c50-81ea-32deb7f5906f"), "336 Lang Rapids, North Kayliborough, Antigua and Barbuda", new DateTime(2020, 3, 22, 21, 43, 7, 205, DateTimeKind.Local).AddTicks(8871), 2, 56m, new Guid("cca29ecc-f27d-4cf2-bff6-12300e28f295") },
                    { new Guid("9a823b4b-2e5f-4f87-82cc-5be68367f3c3"), "297 Nettie Trafficway, Nannieside, Rwanda", new DateTime(2020, 6, 2, 22, 20, 31, 722, DateTimeKind.Local).AddTicks(213), 1, 49m, new Guid("b70a11ab-ab36-4a6c-bb5f-50a139b022ab") },
                    { new Guid("9a8fc26f-1b32-4ebf-92b1-c22a0ab209e5"), "694 Saige Radial, New Vanessafort, Mongolia", new DateTime(2021, 9, 9, 22, 36, 55, 185, DateTimeKind.Local).AddTicks(4033), 3, 53m, new Guid("46f5e919-5c62-438d-9927-260692546c9b") },
                    { new Guid("9acfa541-6e15-428a-b047-8f4f9fce12a6"), "2066 Jonathan Ways, East Benniechester, Seychelles", new DateTime(2021, 12, 2, 11, 35, 34, 520, DateTimeKind.Local).AddTicks(520), 1, 51m, new Guid("84f16bdb-6474-4c14-b425-11cac1a565ed") },
                    { new Guid("9ae63ca1-441c-466f-a060-bc23c447b029"), "76894 Armstrong Throughway, Veumtown, Madagascar", new DateTime(2021, 3, 1, 15, 22, 34, 230, DateTimeKind.Local).AddTicks(3917), 1, 49m, new Guid("7a0b563e-b69b-4e3b-8e6c-2a8061d605fa") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("9c8dbc92-8862-4fd3-8ec0-ef65e59516d6"), "5367 Berry Trafficway, Mercedesville, Senegal", new DateTime(2022, 3, 27, 2, 38, 19, 482, DateTimeKind.Local).AddTicks(1926), 104m, new Guid("776cca4a-2f9d-48c2-9d60-1914176d394d") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[] { new Guid("9e9150af-3704-4ffd-a01e-e8f098bbfb73"), "285 Rosetta Haven, Bayerside, Micronesia", new DateTime(2022, 6, 21, 15, 36, 32, 420, DateTimeKind.Local).AddTicks(1130), 3, 106m, new Guid("fbacffec-e616-4182-9771-935b786124a9") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("9eca63c4-8b05-422f-832c-5541ef3abbff"), "846 Sarina River, Britneychester, Maldives", new DateTime(2020, 12, 31, 1, 47, 19, 126, DateTimeKind.Local).AddTicks(6188), 207m, new Guid("ea1bcfbc-c897-43ef-b698-d39ef0c77450") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("9efee708-2a9c-433c-8019-48d1708cb372"), "585 Heloise Island, Botsfordville, Suriname", new DateTime(2020, 3, 31, 9, 10, 1, 822, DateTimeKind.Local).AddTicks(1401), 2, 109m, new Guid("794cbe13-c030-4f5e-b9c0-02f442d390d6") },
                    { new Guid("a011c27e-2147-456e-89e4-39100d331111"), "67937 Yvonne Canyon, West Emiliofort, French Southern Territories", new DateTime(2021, 6, 30, 15, 27, 16, 677, DateTimeKind.Local).AddTicks(5614), 3, 107m, new Guid("315df441-a3c9-490f-a3c0-1f32b7706489") },
                    { new Guid("a0c7fce9-e0a3-45d6-8731-0e80a906aa63"), "86824 Beer Forks, Marcosville, El Salvador", new DateTime(2022, 8, 25, 3, 38, 34, 729, DateTimeKind.Local).AddTicks(5595), 1, 106m, new Guid("624d489a-fe2a-4584-b243-6ce635ebeac8") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("a0dec400-b58a-4516-8c69-35b1dad41ccd"), "451 Davis Ridge, Watersside, Wallis and Futuna", new DateTime(2020, 2, 26, 22, 54, 33, 406, DateTimeKind.Local).AddTicks(1768), 100m, new Guid("575f2607-46d8-4663-9475-a8ade8af764c") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("a14806a5-f231-4389-8014-588910e49419"), "0312 Crona Highway, North Dayne, Faroe Islands", new DateTime(2020, 12, 19, 11, 28, 10, 250, DateTimeKind.Local).AddTicks(8850), 2, 50m, new Guid("dc1e2b7c-06cc-4428-b1aa-78006d639488") },
                    { new Guid("a1e99d63-2bea-45c7-b958-0ddc23317386"), "8256 Violette Landing, Toyfurt, Virgin Islands, British", new DateTime(2022, 3, 26, 15, 10, 32, 166, DateTimeKind.Local).AddTicks(481), 1, 152m, new Guid("d83fd3af-01b1-4e09-84b3-e2c25cef4476") },
                    { new Guid("a23af231-a0af-4904-840b-ef684c84d5a6"), "5655 Dietrich Mills, West Marty, Austria", new DateTime(2022, 4, 12, 13, 34, 29, 163, DateTimeKind.Local).AddTicks(5603), 2, 50m, new Guid("61830f27-8cbc-4e1c-894e-881227c41830") },
                    { new Guid("a25de077-8526-4130-8e71-c93c9a117ed2"), "029 Kennith Place, South Delphaton, Syrian Arab Republic", new DateTime(2021, 7, 14, 6, 7, 55, 100, DateTimeKind.Local).AddTicks(6054), 1, 106m, new Guid("a50fc310-be58-4cc0-9d25-e8d01a7d3597") },
                    { new Guid("a30ed4ab-fb35-446e-8f40-62d5778a5043"), "786 Rodriguez Lakes, Lake Henriette, Tunisia", new DateTime(2022, 8, 18, 0, 30, 57, 483, DateTimeKind.Local).AddTicks(2720), 2, 53m, new Guid("3e22768c-6406-47fc-8a17-a0a7cbbed4dc") },
                    { new Guid("a40fe25c-289e-4439-9d95-ea36ec9ee1e6"), "64063 Mathias Circle, Einoport, Vanuatu", new DateTime(2022, 6, 4, 3, 7, 33, 702, DateTimeKind.Local).AddTicks(68), 1, 220m, new Guid("b09599d0-57a0-4564-9b0c-ce43007f21b9") },
                    { new Guid("a42ed1e5-a476-4c02-b73b-086668891851"), "1965 Malvina Spur, Bartonland, Falkland Islands (Malvinas)", new DateTime(2020, 7, 20, 14, 17, 42, 152, DateTimeKind.Local).AddTicks(9510), 3, 114m, new Guid("a189e998-c4c7-4581-a08b-2e7c692e8379") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("a4ef26cc-1d87-4659-8478-4ef2e46be114"), "606 Myrtle Pike, West Aureliaside, Fiji", new DateTime(2021, 5, 30, 5, 13, 46, 465, DateTimeKind.Local).AddTicks(9212), 160m, new Guid("e9772e94-927c-4b7a-a2d4-06ee76bf45ca") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("a50375a0-97a7-4119-9b36-0e1febfc8ad6"), "08174 Denesik Oval, Port Norbert, Holy See (Vatican City State)", new DateTime(2022, 5, 13, 20, 32, 18, 578, DateTimeKind.Local).AddTicks(2127), 3, 57m, new Guid("f1f2f390-ef5e-4ebf-8de1-83d274f18f9c") },
                    { new Guid("a592461c-9601-4978-bff5-52247a780a06"), "996 Damon Junction, South Rylanville, Guadeloupe", new DateTime(2019, 12, 5, 18, 23, 51, 324, DateTimeKind.Local).AddTicks(3621), 3, 51m, new Guid("22ca813b-27c4-4049-abc4-a33109557412") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("a6b08e8c-f712-4f38-954b-0810baf8c64d"), "529 Gutmann Streets, Champlinside, Russian Federation", new DateTime(2021, 10, 3, 0, 24, 57, 539, DateTimeKind.Local).AddTicks(1566), 53m, new Guid("33e05925-26de-4aa2-8994-329bde50ff3f") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[] { new Guid("a8329365-2236-4bb3-9c5a-1d179ea17b6f"), "69170 Salvatore Terrace, West Lizzie, Colombia", new DateTime(2020, 1, 17, 0, 50, 16, 740, DateTimeKind.Local).AddTicks(6570), 3, 55m, new Guid("bbcf7301-ea1f-4ded-b978-0c4c23e48014") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("a955baaa-3a1d-42bf-bdee-70d571f40899"), "35446 Savannah Square, Wunschfort, Democratic People's Republic of Korea", new DateTime(2021, 1, 2, 23, 39, 53, 962, DateTimeKind.Local).AddTicks(3874), 106m, new Guid("16ceb7fd-0567-48e5-a113-f4eb2d03a95f") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("aa07f4e2-44eb-4e19-8fe8-088dc8b22363"), "726 Reta Spur, Kristown, Australia", new DateTime(2020, 2, 7, 2, 37, 54, 791, DateTimeKind.Local).AddTicks(1980), 2, 53m, new Guid("1a337000-86fb-41ee-b1bb-d86055e93289") },
                    { new Guid("ab0397b5-3691-424e-850f-9bc1954de8c1"), "518 Jaren Divide, South Lorenzo, Ethiopia", new DateTime(2020, 11, 16, 19, 49, 51, 36, DateTimeKind.Local).AddTicks(7033), 2, 54m, new Guid("fa42e9ca-49de-40ba-a1bb-1d54c80a2aef") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("abb20114-7d5c-4ddf-9ac4-70cbc8e9636c"), "9232 Mavis Turnpike, West Itzel, Cuba", new DateTime(2019, 10, 10, 2, 42, 52, 384, DateTimeKind.Local).AddTicks(3965), 54m, new Guid("56dd5f94-c828-4539-a379-635fe6fbe426") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("abb311f9-145a-4f02-9eab-5a45dd467410"), "35449 Collins Trail, Kaleytown, Iran", new DateTime(2022, 1, 29, 11, 22, 53, 190, DateTimeKind.Local).AddTicks(7509), 1, 53m, new Guid("4a4cfe83-1c6f-43b6-8485-9b8d1ca67e2e") },
                    { new Guid("ac4f1ffa-06b8-47b6-aa7d-1e29f4804d91"), "3797 Brenda Mews, Lake Marques, Gambia", new DateTime(2022, 5, 11, 17, 30, 41, 134, DateTimeKind.Local).AddTicks(1027), 1, 51m, new Guid("f49fdeb9-717d-4d9c-8a74-0c7b6bc1dfca") },
                    { new Guid("ace9b8e9-b48a-4c43-a892-e84f906081a7"), "9870 Chadd Squares, Ledashire, South Africa", new DateTime(2021, 8, 3, 4, 21, 57, 781, DateTimeKind.Local).AddTicks(2130), 3, 102m, new Guid("a7a3264c-773f-4b86-9b6b-a8a241f949dd") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("ae2556db-9361-49bf-8996-3b30ecbac2cc"), "436 Gisselle Fields, Nickville, American Samoa", new DateTime(2020, 3, 26, 23, 57, 39, 190, DateTimeKind.Local).AddTicks(4743), 56m, new Guid("d83fd3af-01b1-4e09-84b3-e2c25cef4476") },
                    { new Guid("af04a87b-ab84-4fa9-a120-6bec3b2b4272"), "482 Maynard Cliff, South Jeremymouth, Kyrgyz Republic", new DateTime(2021, 12, 7, 12, 30, 8, 478, DateTimeKind.Local).AddTicks(6722), 51m, new Guid("38ed128d-b387-4de0-bb3a-94f7863bf3f7") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("b096f8ff-2e4a-41c1-9c60-34e8ae214a8b"), "23187 Goyette Manors, McLaughlintown, Niger", new DateTime(2022, 6, 28, 1, 37, 58, 695, DateTimeKind.Local).AddTicks(4024), 3, 54m, new Guid("520c7cad-8f02-40a1-9435-f7383f3c54a2") },
                    { new Guid("b24415aa-ef20-472c-bf91-1beb553b8d5c"), "99015 Marie Point, Delfinaberg, Philippines", new DateTime(2022, 3, 14, 10, 35, 1, 836, DateTimeKind.Local).AddTicks(1668), 1, 57m, new Guid("b2089c41-3fbe-4d5d-9d82-4c696d4bd7a7") },
                    { new Guid("b2d90cd4-ad3d-40e7-adfb-443ce406c807"), "017 Torphy Villages, New Jeffrey, Barbados", new DateTime(2022, 4, 29, 21, 41, 26, 48, DateTimeKind.Local).AddTicks(7930), 1, 103m, new Guid("34916f83-236e-49bb-94c9-cea28a98de51") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("b54d14f8-8e96-4356-a1bd-92a5b17aa119"), "94785 Littel Road, Sawaynfort, Georgia", new DateTime(2020, 7, 29, 10, 57, 26, 500, DateTimeKind.Local).AddTicks(5840), 109m, new Guid("c68a2f4d-e696-4469-96cb-05f67e35baf5") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("b60ca5be-273f-4622-ac10-bed6b2617014"), "9107 Betty Oval, Ashleeshire, Qatar", new DateTime(2020, 1, 6, 5, 6, 7, 630, DateTimeKind.Local).AddTicks(1583), 3, 105m, new Guid("a91df8a2-2d76-4ea9-9b83-580010e85389") },
                    { new Guid("b6683482-ccf9-4ac6-99b5-be429ff17105"), "855 Kelsie Haven, West Kenneth, Vietnam", new DateTime(2021, 3, 30, 6, 53, 53, 255, DateTimeKind.Local).AddTicks(3025), 1, 50m, new Guid("798ebad5-68ef-4fa2-9d3f-68dd0beee7e9") },
                    { new Guid("b76cc054-0f3e-46b6-9432-be50d7224ee4"), "76262 Powlowski Mills, Port Dena, San Marino", new DateTime(2019, 10, 22, 21, 58, 39, 599, DateTimeKind.Local).AddTicks(607), 1, 50m, new Guid("82fdf04b-b9a1-459d-856e-4f0fa117d309") },
                    { new Guid("b779d7e4-5123-4d73-be2e-3c9e13b630eb"), "31641 Enoch Stream, South Sebastianchester, Costa Rica", new DateTime(2022, 4, 22, 8, 48, 21, 505, DateTimeKind.Local).AddTicks(3940), 3, 55m, new Guid("fb6aabed-ed68-4ad7-88fd-9c08ce9bd65a") },
                    { new Guid("b8e19fa4-b8cf-46bc-a64c-13af80aac89c"), "907 Berta Parks, Sarahfurt, Bermuda", new DateTime(2021, 2, 11, 6, 31, 40, 667, DateTimeKind.Local).AddTicks(2327), 3, 55m, new Guid("c17b1b40-385f-4b13-8a59-8023223e7490") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("b9094491-6627-4aee-b55a-a963c691e775"), "8445 Boehm Common, Francisberg, Kazakhstan", new DateTime(2020, 10, 27, 1, 1, 13, 684, DateTimeKind.Local).AddTicks(3437), 101m, new Guid("5756b256-d33b-4d26-aa85-4fabe4cb3a65") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("b947498f-afea-4f6e-805e-dc7c19476375"), "026 Kunde Ports, Loweborough, Macedonia", new DateTime(2020, 7, 16, 19, 11, 20, 445, DateTimeKind.Local).AddTicks(3944), 1, 55m, new Guid("0ab2f248-ddc9-4e5a-aa6a-1a9d6c50aab9") },
                    { new Guid("b951839d-1718-449a-8f4e-d3066a19bc35"), "4925 Noemi Forges, Kingberg, Sri Lanka", new DateTime(2020, 7, 3, 1, 26, 53, 341, DateTimeKind.Local).AddTicks(8401), 1, 157m, new Guid("deb83f23-2b32-4e55-9e58-7815346d9465") },
                    { new Guid("ba699059-b7a7-4f25-a6aa-493bfaa7d673"), "28646 Berge Island, Lake Vitamouth, Antigua and Barbuda", new DateTime(2021, 9, 14, 7, 3, 29, 580, DateTimeKind.Local).AddTicks(5607), 3, 56m, new Guid("0b592e8e-0184-4dec-83b6-dde70709abf3") },
                    { new Guid("bb8d4f5d-2d49-491c-b8a8-e7bb7074f57d"), "8072 Antonette Creek, East Rodville, Nicaragua", new DateTime(2020, 9, 5, 4, 59, 31, 507, DateTimeKind.Local).AddTicks(6580), 1, 51m, new Guid("b36098e1-99a9-47a1-a075-5bce1d58b630") },
                    { new Guid("bd2f9ebe-e236-486f-9d1a-c9c321c60ce9"), "26064 Bahringer Spring, Simonisborough, Equatorial Guinea", new DateTime(2020, 6, 27, 12, 5, 10, 588, DateTimeKind.Local).AddTicks(7207), 2, 54m, new Guid("7227f69d-62ae-4334-91bd-82960ec7c632") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("c0cd2eac-ef6a-4cba-b7cc-32a5c025e573"), "8903 Ullrich Overpass, Grimesborough, Greenland", new DateTime(2020, 9, 15, 23, 32, 24, 64, DateTimeKind.Local).AddTicks(7876), 49m, new Guid("34091a99-ee0e-41a7-a57a-8a9a869bb98e") },
                    { new Guid("c1c58d92-65ea-4425-aa98-3141e4ba6f67"), "242 Kreiger Road, Rickville, Costa Rica", new DateTime(2022, 7, 7, 20, 37, 4, 784, DateTimeKind.Local).AddTicks(6109), 49m, new Guid("560e5175-fb95-4da9-a517-dc5c1a1e0b14") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("c32de8a9-07dc-42f1-92a2-dfe7a57199c3"), "20806 Edwina Roads, Elliottville, Ecuador", new DateTime(2020, 1, 18, 19, 51, 55, 92, DateTimeKind.Local).AddTicks(2416), 3, 55m, new Guid("d45b450a-0c6c-4975-88c4-ce2fe5ef95af") },
                    { new Guid("c3daa4aa-5573-44cf-8366-2e6ce1274e20"), "6506 Johnson Walks, Robinberg, Cambodia", new DateTime(2021, 6, 25, 19, 0, 24, 749, DateTimeKind.Local).AddTicks(6654), 3, 55m, new Guid("b15b0e6f-9209-4468-95a8-57fe50f5b333") },
                    { new Guid("c4344593-9067-4fa8-9ca1-dbd75c646933"), "0590 Kraig Trail, South Tamiaside, Turks and Caicos Islands", new DateTime(2020, 1, 31, 15, 34, 34, 184, DateTimeKind.Local).AddTicks(146), 2, 50m, new Guid("e77747b4-9625-419a-abfa-36565c15162d") },
                    { new Guid("c4af0f09-df5a-46c3-a912-81be0cb82e22"), "8686 Reynolds Skyway, South Keyonhaven, Panama", new DateTime(2021, 10, 28, 6, 35, 53, 566, DateTimeKind.Local).AddTicks(707), 3, 54m, new Guid("94a9ee10-f86b-49af-982e-8b4cfe8b3d9a") },
                    { new Guid("c64d27e3-e62c-4e2a-8001-79a6447eb134"), "57112 Lonny Ferry, East Lethaville, Mauritius", new DateTime(2021, 5, 6, 16, 0, 1, 175, DateTimeKind.Local).AddTicks(5680), 2, 104m, new Guid("fa51f561-d2ef-45f5-9791-077592b770eb") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("c68d2ab8-e1c4-4d33-879f-8b0b09a95f71"), "20416 Demetrius Turnpike, Shanymouth, Palau", new DateTime(2022, 5, 4, 15, 43, 14, 863, DateTimeKind.Local).AddTicks(1397), 49m, new Guid("4f32fe31-594f-4011-a37f-27fd60782446") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("c6b28fb7-ffd5-47ac-8133-ab4f0e5dee9e"), "04191 Maureen Divide, East Ernestina, Benin", new DateTime(2020, 2, 12, 2, 0, 49, 604, DateTimeKind.Local).AddTicks(2619), 1, 49m, new Guid("5c0c2ec7-1b62-4194-9d80-c190a31a9968") },
                    { new Guid("c7b6d26f-e3a0-49a2-8619-124bd2d286d4"), "37150 Rice Square, Douglasfort, Maldives", new DateTime(2020, 3, 6, 3, 32, 42, 710, DateTimeKind.Local).AddTicks(8652), 3, 107m, new Guid("82054875-1487-4285-853a-baf6981c6e94") },
                    { new Guid("c8c05152-9dab-49ee-8892-a1f9e1ba95ad"), "90653 Sven Course, Westville, Cocos (Keeling) Islands", new DateTime(2019, 10, 26, 18, 50, 12, 234, DateTimeKind.Local).AddTicks(3301), 3, 164m, new Guid("78ada214-9bc8-4288-8757-bb09cda077ee") },
                    { new Guid("c95cfc86-a73b-41fb-9b0e-c28d6af1d92c"), "8139 Mueller Islands, South Ansley, Sri Lanka", new DateTime(2021, 9, 22, 16, 36, 26, 760, DateTimeKind.Local).AddTicks(1478), 3, 156m, new Guid("6fa6ab12-9707-43a6-8d03-fb8e93a265e0") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("c9e9c06c-3059-4246-97f6-60483e7c43cc"), "75552 Princess Keys, Lake Karli, Rwanda", new DateTime(2019, 11, 7, 20, 26, 14, 504, DateTimeKind.Local).AddTicks(1454), 57m, new Guid("b1afc628-d4bb-4ab2-9fc9-e2614d4045c3") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("cb5f9c61-4092-4028-b8d1-de359c47de5f"), "17160 Korbin Circle, New Jovanbury, Albania", new DateTime(2019, 9, 13, 11, 53, 14, 519, DateTimeKind.Local).AddTicks(6934), 2, 50m, new Guid("ed8864ae-8d7d-43f7-98aa-0ce4d42508cf") },
                    { new Guid("cc3760d8-7812-491a-9b00-ec2682e69366"), "273 Cristopher Row, Feliciafurt, Canada", new DateTime(2020, 5, 4, 4, 45, 24, 872, DateTimeKind.Local).AddTicks(9204), 1, 105m, new Guid("0b0e7f66-7dc0-4d50-80d5-0eefcab918cb") },
                    { new Guid("cce7033a-8afa-478f-9edb-aaaf50d9e07d"), "4260 Hartmann Place, North Leopoldochester, Maldives", new DateTime(2020, 1, 17, 10, 1, 12, 21, DateTimeKind.Local).AddTicks(6017), 2, 50m, new Guid("959a46c6-1291-4f0b-86b8-6e43e83b00d7") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[] { new Guid("cd8cb360-864b-4bbc-b9fd-741555e5e886"), "5599 Maci Curve, West Vilma, Zimbabwe", new DateTime(2020, 9, 16, 18, 20, 9, 287, DateTimeKind.Local).AddTicks(8965), 2, 155m, new Guid("90eeeb9e-3e6e-45ea-a604-b2c4a4f120c7") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("cdc742db-3e6f-4df0-8d6a-0fa30ec2edd8"), "9693 Sipes Crescent, East Mariam, Nauru", new DateTime(2022, 3, 1, 2, 56, 6, 483, DateTimeKind.Local).AddTicks(2617), 54m, new Guid("ec86b382-2eff-4365-b78d-b441145a9a77") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("ceaaaa40-85cb-40ab-a7d6-9b192cca71f5"), "06123 Jacobi Ford, Kubhaven, Japan", new DateTime(2019, 12, 22, 2, 9, 9, 258, DateTimeKind.Local).AddTicks(150), 3, 53m, new Guid("c5d06c5a-c561-4034-b942-939fa71d1016") },
                    { new Guid("d025213b-a4b4-460c-b220-c4b56fb69892"), "9984 Roman Points, Hauckville, China", new DateTime(2021, 8, 13, 15, 48, 48, 28, DateTimeKind.Local).AddTicks(6314), 3, 54m, new Guid("9761bd7c-0c33-4699-a195-123d0475e5c9") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("d0838780-7cbf-4a6e-968f-155e8b0da5f6"), "308 Talia Orchard, Wandatown, Senegal", new DateTime(2022, 1, 12, 22, 31, 34, 291, DateTimeKind.Local).AddTicks(6790), 54m, new Guid("4eb4192b-0a3d-4172-9e03-89f885ee593b") },
                    { new Guid("d1164aa1-5c4c-460e-8bfb-56c7ed2d45dd"), "914 Alessandro Radial, Goldnerbury, Norway", new DateTime(2020, 2, 14, 2, 41, 16, 135, DateTimeKind.Local).AddTicks(7803), 53m, new Guid("a52f9180-9cae-4181-a61c-37921a6079c8") },
                    { new Guid("d1625a5e-b0ca-4660-8d0b-4be9dc393790"), "1289 Carlotta Ports, South Mekhiside, Bouvet Island (Bouvetoya)", new DateTime(2021, 8, 6, 19, 23, 47, 642, DateTimeKind.Local).AddTicks(3640), 158m, new Guid("53153af0-6c5f-4250-9fc1-1d2dae771d66") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("d5656eec-6bf6-4583-a7c4-5803a98de97f"), "57644 Leuschke Field, Morissettehaven, Puerto Rico", new DateTime(2022, 3, 20, 13, 7, 40, 970, DateTimeKind.Local).AddTicks(8231), 3, 104m, new Guid("57ac33f0-8833-4edf-a823-ff62125a6c36") },
                    { new Guid("d5893ecd-bf79-450a-a0c4-a7ed0e54ccc7"), "8184 Jess Path, North Markville, Jordan", new DateTime(2022, 4, 20, 19, 44, 4, 725, DateTimeKind.Local).AddTicks(4857), 1, 52m, new Guid("4b39b859-e0d9-4d87-b716-bbfc671ddd1a") },
                    { new Guid("d5a4f5b4-0913-487d-a09c-eeeeb40ef3f9"), "4537 Walter Track, Luisaport, China", new DateTime(2022, 1, 1, 15, 54, 21, 874, DateTimeKind.Local).AddTicks(4768), 1, 53m, new Guid("e2c63be9-4a75-4b1b-acbf-77c6893fc569") },
                    { new Guid("d5c0e4e6-3b9e-4a4a-89f6-edf889d71305"), "4995 Juanita Circle, Quinnport, Uruguay", new DateTime(2020, 2, 4, 3, 37, 43, 629, DateTimeKind.Local).AddTicks(3483), 2, 51m, new Guid("dec293a8-ddc1-434a-941e-0e55137d6e25") },
                    { new Guid("d6c235ba-1c9d-43cf-a718-287d2184b83e"), "4649 Nova Mission, Port Jadyn, Senegal", new DateTime(2020, 5, 29, 5, 21, 3, 197, DateTimeKind.Local).AddTicks(1179), 1, 57m, new Guid("b8096541-0e6c-48d0-ad33-09d6030ddbe3") },
                    { new Guid("d74cce4c-e8b6-466b-aaa6-c275de924a87"), "301 Brandi Bridge, South Wymanborough, Croatia", new DateTime(2020, 9, 7, 17, 46, 35, 784, DateTimeKind.Local).AddTicks(3237), 3, 103m, new Guid("c2989889-eb8e-49f4-ba26-8b1b28737b17") },
                    { new Guid("d7cf3535-8be9-46b7-be94-9c76fe148ffa"), "541 Alison Inlet, Schambergerborough, Panama", new DateTime(2020, 12, 16, 19, 43, 26, 330, DateTimeKind.Local).AddTicks(7567), 3, 51m, new Guid("161e98b2-542f-4007-ae60-f97413fcf414") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("d8aa8d61-b7c4-468b-a933-aab40a8debf9"), "124 Brakus Canyon, East Naomiside, South Georgia and the South Sandwich Islands", new DateTime(2022, 1, 31, 1, 19, 40, 612, DateTimeKind.Local).AddTicks(1159), 103m, new Guid("ba42f5f2-d7b5-48b4-bfea-fdf2d7649f2a") },
                    { new Guid("d8de47ed-ff98-4997-b44b-ea515ac67bd0"), "67287 Shanahan Shores, Lake Darrick, Bermuda", new DateTime(2022, 4, 10, 10, 2, 42, 307, DateTimeKind.Local).AddTicks(2707), 107m, new Guid("ed8864ae-8d7d-43f7-98aa-0ce4d42508cf") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[] { new Guid("da23ac80-e6f8-4bdf-8e07-e271a78e5468"), "8971 Lisa Hills, Taureanmouth, Burkina Faso", new DateTime(2020, 2, 9, 12, 19, 18, 37, DateTimeKind.Local).AddTicks(9373), 1, 159m, new Guid("3f3c903e-3714-4166-a387-7f304e0a3c8b") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("da7ece2d-d6f2-4108-91b0-e00b0034b145"), "5178 Lawson Hills, North Kenyatta, Solomon Islands", new DateTime(2021, 12, 13, 22, 44, 23, 601, DateTimeKind.Local).AddTicks(5063), 107m, new Guid("fbc0f04d-c1da-4844-9b70-f11172f609d8") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("db312aa7-7579-42e9-b61d-74e7fe94774f"), "87307 Margarett Fall, New Ressieton, Taiwan", new DateTime(2020, 9, 12, 2, 16, 42, 356, DateTimeKind.Local).AddTicks(9517), 3, 53m, new Guid("ef8e3fe1-2087-497b-a5a4-8a5821fb0571") },
                    { new Guid("db5d1495-33a6-4820-bfc8-508c0a5b7e4c"), "643 Leffler Loaf, West Tracy, Saint Lucia", new DateTime(2022, 6, 16, 17, 29, 13, 44, DateTimeKind.Local).AddTicks(6815), 2, 165m, new Guid("27305457-fab8-4739-a81e-85072c3ad7bc") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("db65a7dc-cb84-4270-8c04-fad22813ca2a"), "8498 Donnell Summit, Murphyfurt, Western Sahara", new DateTime(2020, 5, 2, 4, 51, 18, 746, DateTimeKind.Local).AddTicks(1253), 52m, new Guid("53153af0-6c5f-4250-9fc1-1d2dae771d66") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("dc0b6ed1-3322-4cdc-93f6-9005b54fc3e9"), "821 Nash Shoals, Lorinestad, Guadeloupe", new DateTime(2019, 12, 5, 13, 6, 41, 254, DateTimeKind.Local).AddTicks(3231), 3, 50m, new Guid("e78d5a8f-4c1f-4d2b-bd0c-9e1f6edb31c9") },
                    { new Guid("dfed85ab-5fa6-4888-a994-599e55208d2e"), "71507 Brandon Loaf, Macitown, Niue", new DateTime(2022, 7, 29, 20, 31, 2, 517, DateTimeKind.Local).AddTicks(6208), 1, 102m, new Guid("750b2161-5c82-4ea8-86ba-fe58bada2674") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("e0ae3c7f-c421-41f4-8091-7d4d18a16683"), "28024 Oleta Parkways, DuBuquestad, Jamaica", new DateTime(2020, 7, 8, 9, 44, 24, 928, DateTimeKind.Local).AddTicks(2111), 50m, new Guid("310e1e36-f647-43fb-8ce4-c209745cd7c7") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[] { new Guid("e1d985b2-e42b-4c0d-9096-f477da44ddb1"), "0480 VonRueden Knolls, Westmouth, Estonia", new DateTime(2021, 5, 20, 22, 36, 9, 840, DateTimeKind.Local).AddTicks(3083), 2, 54m, new Guid("56dd5f94-c828-4539-a379-635fe6fbe426") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("e21e24d8-351d-4152-8fab-ec3b6dab6ebe"), "7046 Enola Fall, Nasirfurt, Tunisia", new DateTime(2021, 10, 8, 14, 54, 23, 916, DateTimeKind.Local).AddTicks(6957), 161m, new Guid("b31696da-7aaa-4940-bf34-a49c5c7466bc") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[] { new Guid("e23df0cd-f5bf-4dd6-81a1-0d145c4803f0"), "524 Chauncey Skyway, Port Branson, Fiji", new DateTime(2019, 12, 18, 4, 55, 38, 950, DateTimeKind.Local).AddTicks(332), 1, 49m, new Guid("10576b9a-3bb0-4e53-b87a-10e1c92294f7") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("e2a2186b-cb4d-4517-b9f4-55da286c17db"), "7042 Kreiger Knoll, East Josh, Russian Federation", new DateTime(2019, 10, 6, 17, 48, 44, 879, DateTimeKind.Local).AddTicks(9053), 100m, new Guid("bbcf7301-ea1f-4ded-b978-0c4c23e48014") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("e43bec70-46cd-45f4-a22c-d40ddb92a3b1"), "39073 Elliot Lights, Bennyberg, Uzbekistan", new DateTime(2022, 8, 11, 5, 43, 5, 696, DateTimeKind.Local).AddTicks(3964), 1, 102m, new Guid("8d14db5d-ba62-4091-a8d8-0a438f714a2e") },
                    { new Guid("e48e016a-ea57-4bb4-a792-2ad61083753d"), "482 Selmer Courts, Lake Alejandrinburgh, Bolivia", new DateTime(2022, 7, 2, 4, 47, 24, 496, DateTimeKind.Local).AddTicks(9286), 3, 101m, new Guid("e18e716c-7845-4b7d-8e90-604d987b0157") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("e5868b49-6ddb-405f-a808-483c2b9243a1"), "4651 Nicolette Plain, East Silas, Burkina Faso", new DateTime(2020, 12, 25, 8, 39, 38, 1, DateTimeKind.Local).AddTicks(2427), 155m, new Guid("2360aefc-d15f-4422-93ee-afdb0ae5347d") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("e5eab42b-e5c5-4151-ac49-0a2a34ffa105"), "126 Heidenreich Causeway, Leslyfurt, Bangladesh", new DateTime(2021, 8, 15, 4, 24, 30, 770, DateTimeKind.Local).AddTicks(1409), 1, 56m, new Guid("77f5f949-25e4-4fc6-abe1-58ad13d0f628") },
                    { new Guid("e65d6969-0881-4f49-b14a-d70d3dedabec"), "0017 Heller Prairie, Antoniettastad, Suriname", new DateTime(2022, 4, 1, 9, 52, 39, 613, DateTimeKind.Local).AddTicks(2867), 3, 105m, new Guid("acceb5b0-5719-4452-9c76-41441aeb8584") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("e68283a6-c380-45ce-8913-04ff741fb99d"), "521 Homenick Corners, Darionburgh, Anguilla", new DateTime(2019, 9, 26, 22, 15, 14, 360, DateTimeKind.Local).AddTicks(9176), 50m, new Guid("bfdc28a5-ce3c-4bfd-a401-2e328159dcb9") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[] { new Guid("e8145c6a-829d-430a-9ef6-87d2825d0b58"), "7622 D'Amore Lodge, Tianaburgh, India", new DateTime(2021, 2, 20, 8, 27, 28, 757, DateTimeKind.Local).AddTicks(5297), 2, 158m, new Guid("5f28454b-2865-4b85-bde0-7a5611ba866d") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("e8301a2a-b55d-4a1c-961b-d00359ab1f77"), "763 Keshaun Mill, South Juanaport, Uruguay", new DateTime(2021, 3, 19, 11, 23, 48, 826, DateTimeKind.Local).AddTicks(6062), 52m, new Guid("7227f69d-62ae-4334-91bd-82960ec7c632") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("e91f09d3-a378-4db9-8c71-f1e02486814d"), "8017 Tyrique Locks, East Wilhelmfort, United States Minor Outlying Islands", new DateTime(2022, 7, 9, 21, 39, 1, 513, DateTimeKind.Local).AddTicks(3326), 3, 103m, new Guid("0f528f4d-1f92-4ea1-ba04-1888e59ae189") },
                    { new Guid("e9906e7d-2d49-49dc-90b4-8fce60fad44f"), "571 Stracke Cliff, Franciscastad, Iceland", new DateTime(2022, 1, 1, 20, 32, 44, 41, DateTimeKind.Local).AddTicks(6308), 1, 57m, new Guid("80e2ed4e-1929-447d-bf94-7dd04cf7e013") },
                    { new Guid("e9f96bc2-1cf5-4eb7-b0b8-1d478ffcf572"), "3413 Eva Orchard, Keeblerhaven, Namibia", new DateTime(2019, 11, 5, 17, 44, 26, 387, DateTimeKind.Local).AddTicks(7552), 2, 160m, new Guid("0df669f7-1e1a-45c3-b1db-49a8828d8dbd") },
                    { new Guid("ea32e25f-0e5b-4e72-9d15-7a8b8f97a48e"), "166 Floy Village, East Elroy, France", new DateTime(2020, 8, 1, 7, 24, 14, 159, DateTimeKind.Local).AddTicks(1571), 3, 99m, new Guid("0ab2f248-ddc9-4e5a-aa6a-1a9d6c50aab9") },
                    { new Guid("ea956ff3-fd2c-42c9-98e2-234fda2b5617"), "0753 Roy Circles, Theofort, Zimbabwe", new DateTime(2019, 10, 6, 15, 8, 4, 437, DateTimeKind.Local).AddTicks(7123), 2, 54m, new Guid("270ecddf-9907-42fc-bc9b-942d0cc12307") },
                    { new Guid("ea9fc8dc-8429-4c93-8a4d-0f23cf6566ca"), "061 Weber Expressway, West Branditown, Iceland", new DateTime(2022, 3, 24, 8, 5, 54, 922, DateTimeKind.Local).AddTicks(6176), 1, 56m, new Guid("eda9dfa1-d8b9-49eb-8c65-8ceaefd0a764") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("eafbfe45-bd61-480e-b442-f50d3109a77d"), "92056 Wintheiser Circles, East Lamar, United States of America", new DateTime(2020, 2, 5, 22, 12, 4, 772, DateTimeKind.Local).AddTicks(4553), 54m, new Guid("d32193f2-6eb3-4c0a-8ad7-4a1c0d0a3f96") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[] { new Guid("eb8b48d1-1344-4c15-93d4-66c5f4cdb564"), "7668 Sanford Hill, North Kaleightown, United States of America", new DateTime(2021, 10, 16, 10, 30, 14, 691, DateTimeKind.Local).AddTicks(445), 1, 55m, new Guid("325a9cfc-4ec9-493a-927a-482a59fca9ae") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("ebec2f0f-2f0a-4f6b-b160-2b8c10608177"), "8363 Christophe Island, South Rahul, Sweden", new DateTime(2021, 8, 17, 18, 20, 21, 252, DateTimeKind.Local).AddTicks(8705), 50m, new Guid("13133674-565e-412c-b73a-827066dd8db1") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("ee56a0ed-0ebc-449f-adee-0d287f06b55e"), "3702 Spinka Brook, Langworthtown, Liechtenstein", new DateTime(2020, 1, 27, 3, 10, 31, 350, DateTimeKind.Local).AddTicks(4486), 3, 49m, new Guid("79e7e48b-5ee2-4309-a334-6736018c72b3") },
                    { new Guid("ef2ad63f-b840-4874-af38-d65e2e826dc9"), "13572 Bill Crescent, Lake Lauryn, Namibia", new DateTime(2020, 7, 25, 16, 47, 40, 775, DateTimeKind.Local).AddTicks(8666), 1, 53m, new Guid("c622bb5c-7770-4db5-ae86-187a9de403a6") },
                    { new Guid("efbf6bc9-d3c0-4781-b6c6-44db460c7062"), "294 Lincoln Pass, Port Devyntown, Micronesia", new DateTime(2020, 1, 11, 8, 12, 46, 822, DateTimeKind.Local).AddTicks(2739), 1, 110m, new Guid("2bd8a20b-5e13-4419-aa97-ddb7e61426aa") },
                    { new Guid("f019f651-9365-4ce1-9ad1-6de045d0ae71"), "674 Lesch Overpass, East Tristian, Lebanon", new DateTime(2022, 8, 31, 19, 15, 2, 406, DateTimeKind.Local).AddTicks(65), 1, 110m, new Guid("0f3b2512-e952-40e6-86cf-bb6943474337") },
                    { new Guid("f0861cec-b7ef-485a-881e-9ee657a4fa05"), "224 West Mountains, Port Santinochester, Ecuador", new DateTime(2020, 3, 9, 20, 29, 41, 797, DateTimeKind.Local).AddTicks(8874), 1, 50m, new Guid("9761bd7c-0c33-4699-a195-123d0475e5c9") },
                    { new Guid("f17810e0-360b-4ed0-85cb-9e50f44f1aa7"), "19438 Thaddeus Parkway, Lavernburgh, Senegal", new DateTime(2019, 12, 24, 22, 14, 55, 35, DateTimeKind.Local).AddTicks(6271), 2, 49m, new Guid("6ba93423-76bb-4395-bba9-28f0f52eaa74") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("f196b6a9-4547-4ba8-87e5-173d12997b6a"), "47477 Afton Port, Meaghanmouth, Turks and Caicos Islands", new DateTime(2020, 8, 21, 10, 50, 44, 889, DateTimeKind.Local).AddTicks(6185), 101m, new Guid("ae5e6752-463f-4417-8a40-efa5c2acc165") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("f1988402-7be2-4d2f-afc8-4e5dbcd568a4"), "1136 Donnelly Hill, Kayleeview, Vietnam", new DateTime(2021, 5, 7, 23, 19, 7, 336, DateTimeKind.Local).AddTicks(6831), 3, 161m, new Guid("2360aefc-d15f-4422-93ee-afdb0ae5347d") },
                    { new Guid("f2d3de7b-72a4-4be1-8012-9bf3a1d05384"), "4646 Koss Coves, Lake Jordi, Mongolia", new DateTime(2020, 6, 4, 3, 31, 53, 754, DateTimeKind.Local).AddTicks(7552), 3, 53m, new Guid("27645926-9873-46dc-8e61-766f60eb1286") },
                    { new Guid("f449f5ce-2f90-42c4-9ec0-31d80f676d72"), "43689 Althea Lock, Jeffview, Antarctica (the territory South of 60 deg S)", new DateTime(2022, 4, 2, 11, 48, 25, 620, DateTimeKind.Local).AddTicks(8036), 1, 53m, new Guid("40efd470-424b-4350-8707-5d578781dd06") },
                    { new Guid("f5f4f233-57bc-4297-a435-1c968452f829"), "412 Alvera Viaduct, Meaghanmouth, Kiribati", new DateTime(2020, 12, 4, 3, 39, 5, 637, DateTimeKind.Local).AddTicks(8583), 3, 52m, new Guid("bfdc28a5-ce3c-4bfd-a401-2e328159dcb9") },
                    { new Guid("f628248c-4c5e-4149-93cb-26173a744aab"), "034 Bergstrom Square, North Coby, Tokelau", new DateTime(2020, 10, 15, 5, 39, 44, 105, DateTimeKind.Local).AddTicks(6978), 3, 104m, new Guid("fe8d4ef4-999a-4cca-8faa-252c88fa7cc6") },
                    { new Guid("f62dcef6-cd8f-4d1b-a78d-2509f94c4534"), "556 Bednar Spur, East Marielle, Guadeloupe", new DateTime(2022, 3, 8, 5, 45, 11, 395, DateTimeKind.Local).AddTicks(3025), 2, 50m, new Guid("4356f819-7b05-46c4-a1c9-1ad732249578") },
                    { new Guid("f71a227d-4775-491e-8bfc-f031a8842c2e"), "528 Xander Underpass, West Elmerland, Norfolk Island", new DateTime(2020, 5, 6, 13, 25, 14, 963, DateTimeKind.Local).AddTicks(3266), 2, 52m, new Guid("69ec5027-57e0-4a29-852a-86022a5c9cf5") },
                    { new Guid("f7376de9-88e9-4802-8ce1-dc3a9693a46a"), "3685 Renner Landing, South Lorenzo, Antarctica (the territory South of 60 deg S)", new DateTime(2021, 11, 24, 6, 23, 46, 611, DateTimeKind.Local).AddTicks(9501), 3, 50m, new Guid("2ebab0ca-259f-4e1a-a4b6-cee82119042e") },
                    { new Guid("f87a4771-2228-40fe-930c-67b3f5aa1780"), "97814 Monahan Summit, Nienowburgh, Iraq", new DateTime(2020, 7, 15, 16, 55, 31, 535, DateTimeKind.Local).AddTicks(4390), 3, 49m, new Guid("4e932225-47d8-40ce-983a-14aecc162f57") },
                    { new Guid("f9814a05-6553-42a8-8931-a8e4b885f513"), "514 Quentin Stravenue, Hudsonmouth, Kyrgyz Republic", new DateTime(2020, 8, 18, 7, 34, 38, 609, DateTimeKind.Local).AddTicks(1922), 3, 52m, new Guid("8c580832-6410-4d5a-9209-a751967490a3") },
                    { new Guid("fa41146d-97cb-446d-9d4c-9105abf75e1e"), "99075 Nina Ports, Sharonborough, Mali", new DateTime(2021, 6, 8, 7, 53, 41, 641, DateTimeKind.Local).AddTicks(3666), 3, 51m, new Guid("53153af0-6c5f-4250-9fc1-1d2dae771d66") },
                    { new Guid("fa50e941-4137-401b-93af-8ea22b33ba0a"), "6314 Kris View, South Elsatown, Seychelles", new DateTime(2021, 12, 11, 4, 26, 54, 570, DateTimeKind.Local).AddTicks(6747), 2, 109m, new Guid("4b39b859-e0d9-4d87-b716-bbfc671ddd1a") },
                    { new Guid("fad432c1-4d46-4371-a34c-f370b3817627"), "3371 Manley Shore, Lake Rosinashire, Azerbaijan", new DateTime(2021, 1, 19, 3, 58, 15, 519, DateTimeKind.Local).AddTicks(4543), 3, 57m, new Guid("0b8e143d-8288-4a3f-b074-1a7d17f66aa9") },
                    { new Guid("fae66f35-9b6b-4a0a-ae2a-c38e9786e671"), "9616 Goldner Glens, Port Jasen, Saint Helena", new DateTime(2020, 3, 22, 9, 59, 9, 660, DateTimeKind.Local).AddTicks(8280), 3, 54m, new Guid("82072524-5a57-4b6e-9fd6-4bc8845bafc7") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("fc0889cc-881f-46f5-96b1-88f030351829"), "67052 Hessel Ranch, North Greggshire, Moldova", new DateTime(2021, 7, 28, 16, 15, 57, 932, DateTimeKind.Local).AddTicks(7357), 102m, new Guid("d868e8e4-1fb5-4757-aa2f-bc7e67cf5adc") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("fc3d27e6-e777-4e81-817e-3a5a8c30bf4d"), "7270 Bergstrom Mountain, North Jeromyside, Singapore", new DateTime(2022, 8, 7, 16, 59, 18, 123, DateTimeKind.Local).AddTicks(7157), 3, 50m, new Guid("0b592e8e-0184-4dec-83b6-dde70709abf3") },
                    { new Guid("fd204683-1678-4380-b0af-4986cd9f0ea1"), "06871 Enoch Cape, Legroston, Moldova", new DateTime(2020, 8, 7, 7, 26, 54, 134, DateTimeKind.Local).AddTicks(8353), 1, 52m, new Guid("37276f2c-1c2a-4859-8854-901994ca2d76") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("fda901d5-a3aa-459c-84be-677b40a61d7b"), "0222 Morar View, Daytonfort, Jersey", new DateTime(2022, 5, 11, 21, 22, 6, 449, DateTimeKind.Local).AddTicks(8535), 57m, new Guid("82072524-5a57-4b6e-9fd6-4bc8845bafc7") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("fddb2b2b-e12a-4ff8-85b7-a0def30c5d23"), "1669 Anais Springs, Russelfurt, Zimbabwe", new DateTime(2020, 7, 9, 3, 14, 45, 488, DateTimeKind.Local).AddTicks(7710), 1, 57m, new Guid("0a3ee9be-b9f0-465c-b9cf-46974a2da0dd") },
                    { new Guid("fed644ef-031a-454c-b4d5-f038767c027a"), "230 Jordon Lights, North Birdie, Nicaragua", new DateTime(2022, 5, 20, 19, 53, 12, 308, DateTimeKind.Local).AddTicks(6890), 2, 107m, new Guid("6255786c-52cd-491a-8abb-285230889f18") },
                    { new Guid("ff8e74cb-0313-490c-8ace-8b3c2c0dddf7"), "06386 DuBuque Parkway, Theofurt, Cook Islands", new DateTime(2021, 1, 2, 21, 10, 1, 115, DateTimeKind.Local).AddTicks(6901), 3, 56m, new Guid("eda9dfa1-d8b9-49eb-8c65-8ceaefd0a764") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("ff9b4afe-cbfc-46bc-9cf0-b6d013e11641"), "8178 Considine Crescent, West Zulaside, Moldova", new DateTime(2020, 2, 2, 14, 6, 29, 724, DateTimeKind.Local).AddTicks(8127), 50m, new Guid("773edfdc-d001-46b4-a5cc-dfed84707368") },
                    { new Guid("ffa94aa3-e381-4ba0-a286-fe757ad03608"), "713 Kasey Trafficway, Smithmouth, Kyrgyz Republic", new DateTime(2021, 10, 20, 13, 19, 22, 494, DateTimeKind.Local).AddTicks(498), 159m, new Guid("2bb458c1-b318-497a-a83c-16b271b6542b") }
                });

            migrationBuilder.InsertData(
                table: "OrdersAndProducts",
                columns: new[] { "Id", "OrderId", "ProductId" },
                values: new object[,]
                {
                    { new Guid("0056896c-7156-4443-8ae2-cba04cdb5a59"), new Guid("1bea0342-3923-4b8a-aa68-7e1d9abf447f"), new Guid("13d0cd2d-38b3-4f2f-a043-e66f133a986d") },
                    { new Guid("012135fe-8c3c-4c9a-bae4-bc2d29212526"), new Guid("97b78ce3-151c-43c0-a61a-32453c606d28"), new Guid("70b0378f-48d0-4e1c-bee7-674f11b8f878") },
                    { new Guid("013a1248-51e0-4542-b3e8-21fc1e8c723c"), new Guid("e48e016a-ea57-4bb4-a792-2ad61083753d"), new Guid("b86ced3e-c40c-44cf-99dc-96d11f768653") },
                    { new Guid("017d42bf-5de5-425e-9538-945109114dae"), new Guid("09561552-a669-4e36-b06b-b24efc32e20c"), new Guid("2472a7b3-f1bf-404e-8596-ed928902eea3") },
                    { new Guid("01c84211-4433-40dc-b3e4-f879a09ae619"), new Guid("0ae95470-98b8-4beb-824e-60deeffacb0f"), new Guid("8e6de47c-317d-4f39-b055-dc1eff7d2680") },
                    { new Guid("01e504fe-2664-4e86-aa0f-4b0e932b38d7"), new Guid("db5d1495-33a6-4820-bfc8-508c0a5b7e4c"), new Guid("12fb19c0-8e0d-49a8-b8a3-702e811b9049") },
                    { new Guid("01e7d22a-084e-4ba7-8dda-1d6932ae5a49"), new Guid("60a73766-96ef-44cb-8d3c-170fd976359a"), new Guid("84c01664-4105-444e-a124-fc8b5bb03109") },
                    { new Guid("0205bd4e-3eea-4265-9273-f8e03e2dd8f2"), new Guid("265e8e24-afd9-4c40-8fb6-95694a975946"), new Guid("9d194863-868e-4563-a703-783885908cbf") },
                    { new Guid("020ea85a-7fd9-4dfc-8a58-26e8581bedc0"), new Guid("a4ef26cc-1d87-4659-8478-4ef2e46be114"), new Guid("87b5396a-6746-4520-ba0f-b7a551476ef6") },
                    { new Guid("02d9a7b9-3f0d-4ab8-a4f5-a9fa66024ac6"), new Guid("d5893ecd-bf79-450a-a0c4-a7ed0e54ccc7"), new Guid("c8c181e2-08b4-4230-8626-bd98ba652ac1") },
                    { new Guid("048d81f5-6a0d-40b5-a5aa-d44b6bb32822"), new Guid("3c7fdf31-51af-40ba-9880-714f35a1a943"), new Guid("1354620e-1550-4e35-bd47-75d5eea11fcf") },
                    { new Guid("05334197-8821-484e-8228-992b39f8184e"), new Guid("fed644ef-031a-454c-b4d5-f038767c027a"), new Guid("0e550331-3859-44ee-ab97-2f9f8a5faec9") },
                    { new Guid("06352f36-a0e1-46cd-90c2-c584d189ec9f"), new Guid("73aabdbc-7be9-4b6a-a164-81385af16fe9"), new Guid("f7a7e0d9-dd9e-4c01-829b-c00f7409c3ae") },
                    { new Guid("065a119f-6c18-4b4c-8122-9c97071abed7"), new Guid("e8145c6a-829d-430a-9ef6-87d2825d0b58"), new Guid("842582cb-065a-44c0-9ca1-76d4468c4cd4") },
                    { new Guid("068c2bbe-f0de-4b29-adb4-d8957419a050"), new Guid("e65d6969-0881-4f49-b14a-d70d3dedabec"), new Guid("68d6cbd3-9937-4018-91dd-e2624ab59259") },
                    { new Guid("077fcda5-1b73-4e64-a39e-f13f64cd2d84"), new Guid("fad432c1-4d46-4371-a34c-f370b3817627"), new Guid("70b0378f-48d0-4e1c-bee7-674f11b8f878") },
                    { new Guid("091318c3-2747-4b9f-a8c3-802bd30c1da4"), new Guid("b60ca5be-273f-4622-ac10-bed6b2617014"), new Guid("cbef3c56-4052-416f-99bf-9ce1ed23eeb4") },
                    { new Guid("09204647-7ff3-4e4d-afb8-f27b3d57a58b"), new Guid("efbf6bc9-d3c0-4781-b6c6-44db460c7062"), new Guid("5adbc56d-7a64-4484-a417-0f45206c1420") },
                    { new Guid("0951366e-097f-4b9d-929c-98ac270d87a7"), new Guid("7deabc92-1179-4b2b-b908-477f73cdaf11"), new Guid("b0dd70a3-f10c-4d98-ba0e-26cb6bee2765") },
                    { new Guid("099fd733-2675-49f1-8b15-484653e0e1fb"), new Guid("97b78ce3-151c-43c0-a61a-32453c606d28"), new Guid("e7f8375b-d116-415e-a751-d445627b1ae8") },
                    { new Guid("09b40d51-c697-4225-a882-7a447fab7364"), new Guid("80d2e4a5-545c-4ab1-a458-569d45ccc022"), new Guid("a1a737bb-565c-4136-beca-11d282c7cf4a") },
                    { new Guid("09d45204-3d07-4f39-8914-eafd34b397a4"), new Guid("a30ed4ab-fb35-446e-8f40-62d5778a5043"), new Guid("76e97616-1e4f-47b1-ab17-713a78b29511") },
                    { new Guid("0a0768dc-06b9-428f-8466-8fb28a82117f"), new Guid("996dc268-b107-4c50-81ea-32deb7f5906f"), new Guid("fec38e22-31d0-4822-b05e-61210b5b9f45") },
                    { new Guid("0b4247d2-0442-473a-9585-a882e9f39d5f"), new Guid("470b5002-1e85-4a1d-95fd-6c95b3fd9264"), new Guid("1d9cf73b-953e-45cc-858b-c6f99dc35956") },
                    { new Guid("0bc13100-b35b-478d-86a9-c8f0aa03712b"), new Guid("9acfa541-6e15-428a-b047-8f4f9fce12a6"), new Guid("77e2de50-83bf-42a2-a482-f78b5b52ca5b") },
                    { new Guid("0bc611cd-f407-4f58-838a-de4a55776678"), new Guid("0d73fc46-1f39-4c91-83b1-794aeaa7a6fb"), new Guid("814e7d7d-6b27-45bb-b24d-7fdcfa2b8010") },
                    { new Guid("0be72de3-db6b-4bb9-80db-e670d4b15c83"), new Guid("1fc8e9df-7f43-4ccb-8bec-ef023150bc6d"), new Guid("63796282-dedb-4ea8-b1b4-33f5389d6b74") },
                    { new Guid("0c193530-d63c-47ae-b85b-bc26aea5b1cd"), new Guid("0d230fc2-9bcc-4260-ba14-42fadd51b4a1"), new Guid("f1ad78a1-9698-48c0-8b53-84147484e6a9") },
                    { new Guid("0c433290-daec-4ac3-8d26-f55c98eecabb"), new Guid("0306cc70-7a2e-47f2-8b29-ae39c10469be"), new Guid("89bc1793-cfd1-4acd-aab5-4ebcc6d11163") },
                    { new Guid("0cd14c78-aaf6-4bbf-aec3-a48bfac5ee81"), new Guid("ffa94aa3-e381-4ba0-a286-fe757ad03608"), new Guid("06fcef3c-f6d0-447f-b9c9-bf04082175dd") },
                    { new Guid("0d65ce13-fd4d-467c-8e57-c09a87edf1c8"), new Guid("bb8d4f5d-2d49-491c-b8a8-e7bb7074f57d"), new Guid("77e2de50-83bf-42a2-a482-f78b5b52ca5b") },
                    { new Guid("0e80805c-6bf5-4ddc-aa21-86f2dc071fd7"), new Guid("08e28f96-d1f4-4d94-ac44-c00d8a17b093"), new Guid("b23cfb10-60dc-4ea8-a773-a36c0823faec") },
                    { new Guid("0ed93d64-d7fe-4eb6-a33a-118bd82805ad"), new Guid("1537e3f6-7574-4582-b974-137981422be3"), new Guid("8e8d00f6-c787-48f0-bcac-0670988815ac") },
                    { new Guid("1146bd80-37dd-411b-9dd7-1ba3ff2d0d2a"), new Guid("c32de8a9-07dc-42f1-92a2-dfe7a57199c3"), new Guid("c0168984-95eb-4b47-b3d2-11c7a3467675") },
                    { new Guid("13110fbd-dd08-41fe-9ae1-f72e2933132e"), new Guid("9eca63c4-8b05-422f-832c-5541ef3abbff"), new Guid("7cb73ef5-0ab8-454c-b257-02769add8105") },
                    { new Guid("13c4fad3-66ec-4a16-bcb5-efc2091553bb"), new Guid("46ad4204-1ac4-46ad-8a85-a6186fc33341"), new Guid("1d063fc4-853f-43d1-bafb-9c4168719630") },
                    { new Guid("1425e047-953f-4342-9de2-d8c3c537528b"), new Guid("86007e46-c7b6-4e30-9fc8-55903fe629ea"), new Guid("1a578b45-1f53-4331-80c9-cc8230fae85f") },
                    { new Guid("142bb21d-2cc5-421b-8733-1f58f327bfc5"), new Guid("5c3bc75d-3342-4f19-b9d1-3253fbd1cec3"), new Guid("c0168984-95eb-4b47-b3d2-11c7a3467675") },
                    { new Guid("15cfe5f7-4b65-4587-b033-04999446685b"), new Guid("5b0a124b-95fa-4ab6-b48c-a0a8c1a2ccef"), new Guid("23c6f7da-58fe-4102-b550-0166ed5c056e") },
                    { new Guid("1618a0ad-19fd-4e43-bb1e-202fbd2a0d8e"), new Guid("eb8b48d1-1344-4c15-93d4-66c5f4cdb564"), new Guid("123de458-520c-44bc-9261-5a6d031e354c") },
                    { new Guid("166c2d89-b0f4-4a31-bd64-8d1c6ce042dc"), new Guid("2b97a2d7-a4a2-407e-97dc-92041e835bfa"), new Guid("5ef14a0e-448d-4122-8ee2-60bf587b3988") },
                    { new Guid("169e006a-4f83-4e33-8dbe-3c2105e12781"), new Guid("7e74cde7-3e0a-432a-b0f5-0a18f5ed9cd2"), new Guid("484ed8df-d6f6-4eda-97dd-b6301d08d91d") }
                });

            migrationBuilder.InsertData(
                table: "OrdersAndProducts",
                columns: new[] { "Id", "OrderId", "ProductId" },
                values: new object[,]
                {
                    { new Guid("16c5013c-5825-4697-a69a-aeffbe4ce514"), new Guid("8181e5e6-67d7-46f2-8ce4-f6975e9cb204"), new Guid("f75b2482-5780-4ba5-a15d-e625ad47851d") },
                    { new Guid("16d44589-0688-475c-b4f3-dff93c166bff"), new Guid("f196b6a9-4547-4ba8-87e5-173d12997b6a"), new Guid("4b508211-1697-4f53-a6de-f82c6b17045b") },
                    { new Guid("1722655c-f7b6-4271-bc29-7750b4f65b12"), new Guid("e21e24d8-351d-4152-8fab-ec3b6dab6ebe"), new Guid("06fcef3c-f6d0-447f-b9c9-bf04082175dd") },
                    { new Guid("174f7c2e-2bdb-413d-a912-f7d766bcc3ae"), new Guid("97b78ce3-151c-43c0-a61a-32453c606d28"), new Guid("0190572c-ab09-4d39-a999-3cc556c2f7b7") },
                    { new Guid("17862fb3-f5da-440e-8542-69a4c2612a02"), new Guid("a955baaa-3a1d-42bf-bdee-70d571f40899"), new Guid("72551552-9343-4ec0-9d28-7b3850030eaf") },
                    { new Guid("18e7116b-e360-477a-94d2-5f5ebe0059ff"), new Guid("fa50e941-4137-401b-93af-8ea22b33ba0a"), new Guid("874bf8ab-ec5f-4bdc-8812-bb59ac22a9e8") },
                    { new Guid("19953dd9-d05e-49c3-907c-018aea0c0bbd"), new Guid("70022831-94be-4a7d-92f3-d658aaa0acc4"), new Guid("2f220fa7-e836-48ac-9283-6df71878e0f1") },
                    { new Guid("1b34c2df-5556-4d81-bdc1-e826d6c71a93"), new Guid("85be8590-cfd8-4f63-8b9a-d874fe027b6b"), new Guid("1d9cf73b-953e-45cc-858b-c6f99dc35956") },
                    { new Guid("1b540d15-1c15-4990-92e0-3f1a5576492c"), new Guid("cb5f9c61-4092-4028-b8d1-de359c47de5f"), new Guid("b23cfb10-60dc-4ea8-a773-a36c0823faec") },
                    { new Guid("1b6db49d-86f3-446c-b88f-a81f7d148d46"), new Guid("548068e5-d9ba-4e10-b19c-ae566c16d563"), new Guid("47c7b904-b21b-4586-8008-911695e389da") },
                    { new Guid("1b878c94-3429-4fb7-b85b-7e663785061b"), new Guid("7d093f45-5998-4d26-8f72-ca6cdfc473fd"), new Guid("9f61af47-11cd-4c84-ae19-7853ba7b07fb") },
                    { new Guid("1c470166-2fc4-4a4b-b5c9-6c0457944b09"), new Guid("9c8dbc92-8862-4fd3-8ec0-ef65e59516d6"), new Guid("2a81af19-23be-4e51-bf1b-0f4e10ea804b") },
                    { new Guid("1c9ac30e-f91a-4484-9f74-de0e7b8576a7"), new Guid("6abbfcaa-13b7-4b69-a02a-573be067ddcb"), new Guid("af2e6f21-f268-43ac-9ed5-4c9e49d723b9") },
                    { new Guid("1cc27659-089b-4b9b-80a0-2c57c638d520"), new Guid("a40fe25c-289e-4439-9d95-ea36ec9ee1e6"), new Guid("6c7768b8-f94d-4773-ac22-18ffbef818e7") },
                    { new Guid("1cfea838-6eae-44a4-b031-09bd65f37986"), new Guid("03608ed8-92e0-4bd5-aeca-5b9d6f7f6963"), new Guid("3b746024-95c8-41ed-8e9f-8a4aca0260c1") },
                    { new Guid("1d486c1c-8f04-4f12-beb2-69ff9a9abc13"), new Guid("2e592dcc-f9d1-4bc7-8259-be0ed53562a6"), new Guid("af2e6f21-f268-43ac-9ed5-4c9e49d723b9") },
                    { new Guid("1d618d1f-f093-47af-8256-ae340a4cecf7"), new Guid("af04a87b-ab84-4fa9-a120-6bec3b2b4272"), new Guid("ec22bb68-a40e-4489-b61e-b5d586cf2ed7") },
                    { new Guid("1e0f89c9-d73c-41e7-8251-a8a639f7a148"), new Guid("e8145c6a-829d-430a-9ef6-87d2825d0b58"), new Guid("64f4c5fe-8396-48d8-bdfe-8aafeb897cc9") },
                    { new Guid("1e4c26b9-8248-41d4-a30f-818f63184e8d"), new Guid("dfed85ab-5fa6-4888-a994-599e55208d2e"), new Guid("394a1f56-f85b-4b3c-b7f3-e5df94d9db1b") },
                    { new Guid("1f13edc4-88d3-4600-b056-bafe1f12ec52"), new Guid("55ac52a6-fa08-419d-bd28-3de97af78f31"), new Guid("5492296a-a686-4a30-8f24-00e8a3347f0a") },
                    { new Guid("1f390d52-1b65-46a6-9499-74d95c096775"), new Guid("aa07f4e2-44eb-4e19-8fe8-088dc8b22363"), new Guid("61cc6b34-3205-4c29-870a-20a073ef978e") },
                    { new Guid("204dd2f9-84d7-4c1a-9a5c-ec93a51f1795"), new Guid("b60ca5be-273f-4622-ac10-bed6b2617014"), new Guid("a1a737bb-565c-4136-beca-11d282c7cf4a") },
                    { new Guid("20a44783-d0ee-4349-970e-6444c994cb48"), new Guid("e65d6969-0881-4f49-b14a-d70d3dedabec"), new Guid("8aefdf4d-c49b-4e37-8861-9c1666dd9c8e") },
                    { new Guid("20c26324-a527-4f19-b715-24fd8d3baad2"), new Guid("0e8fcd11-324e-48c5-a721-0525a8934331"), new Guid("2472a7b3-f1bf-404e-8596-ed928902eea3") },
                    { new Guid("216954e4-e88b-4377-a65e-d9d8f537a9a3"), new Guid("b951839d-1718-449a-8f4e-d3066a19bc35"), new Guid("b4cd5f5a-a7cf-46c2-9a6d-d552df3016cc") },
                    { new Guid("21b84915-ef30-40ec-aa3f-b6c88b897ca4"), new Guid("6ab5a5ac-75ec-40bb-b23e-79228a9dd12c"), new Guid("b17b495d-10bf-4587-a1bf-0042d6af21af") },
                    { new Guid("226194be-9ef1-4ee7-bea6-7eb37bc508e6"), new Guid("a42ed1e5-a476-4c02-b73b-086668891851"), new Guid("8adf2c90-6b21-4974-8229-68e16ff23a1d") },
                    { new Guid("22d3157e-f6cb-4932-8fb3-521bc98f2075"), new Guid("7eddae9f-9286-495b-8c0f-debe878d07ea"), new Guid("01460f95-b945-4bb2-8e4e-70ef80f59f07") },
                    { new Guid("2331181d-e45f-4714-915a-66f983e6ab46"), new Guid("f7376de9-88e9-4802-8ce1-dc3a9693a46a"), new Guid("1d063fc4-853f-43d1-bafb-9c4168719630") },
                    { new Guid("2446711d-bc78-4004-afab-9f3fe3a3a43e"), new Guid("3e5f38ca-4be5-4a20-94f8-e3eb4d6f8cba"), new Guid("2b1aab66-0b70-458e-b47f-4c7dd0eabdba") },
                    { new Guid("24785452-f088-47b3-bdf2-2118fb020db4"), new Guid("f196b6a9-4547-4ba8-87e5-173d12997b6a"), new Guid("7d6308fd-5315-4091-af29-0b949243cfe6") },
                    { new Guid("24a35dd6-8a1f-4c1a-bbdb-8f9473fc04a3"), new Guid("1bcc31e4-616f-4042-913a-24e906cd6e68"), new Guid("f262f894-47e0-4965-bc16-378b5fb166e3") },
                    { new Guid("25212dce-ba80-4fea-83f7-533ee8c2c238"), new Guid("645bf33f-1d43-4e5c-bbd6-959663a4ddc6"), new Guid("88a16f79-6088-48bd-a5e1-b0d18c42bfc3") },
                    { new Guid("2549fd47-4512-4875-87ab-eb2979935989"), new Guid("5201e150-83ca-48d8-b84a-a2940594f9bc"), new Guid("fb4d01b2-5d8d-4cbc-97a7-075f88d63189") },
                    { new Guid("25860aee-d785-4dfb-9fc1-3dd30a459146"), new Guid("c8c05152-9dab-49ee-8892-a1f9e1ba95ad"), new Guid("5fcb4bdf-bf4a-4681-836c-327c70dd4397") },
                    { new Guid("263d9f9e-64ef-47e2-979a-9b90a302512f"), new Guid("e21e24d8-351d-4152-8fab-ec3b6dab6ebe"), new Guid("63796282-dedb-4ea8-b1b4-33f5389d6b74") },
                    { new Guid("26418ee0-6445-4d21-a447-422ca6144e4c"), new Guid("798d97f3-d90a-42ce-994e-f34501704b49"), new Guid("a52ec61e-329c-4724-b9b9-4c200593f8b0") },
                    { new Guid("267b3275-1bf5-4389-9ab9-589ffd445b02"), new Guid("3d282e1e-b2ef-48c8-accf-9c67cee0e8df"), new Guid("064ae937-544b-4191-9d8f-89c216c36a44") },
                    { new Guid("27183b98-e7fb-4b73-872a-627555a97a9b"), new Guid("9957e0d1-96c3-4159-937d-f2e7df48b85b"), new Guid("9d5c3935-5ff9-44ba-88dc-368963e30c96") },
                    { new Guid("29595870-1295-4535-9b11-498668a6f967"), new Guid("b951839d-1718-449a-8f4e-d3066a19bc35"), new Guid("f7a7e0d9-dd9e-4c01-829b-c00f7409c3ae") },
                    { new Guid("29cd0a3b-f0b8-46ba-9880-88ed9effed5b"), new Guid("d0838780-7cbf-4a6e-968f-155e8b0da5f6"), new Guid("13315d68-137d-4d1d-b894-9d21ffc4601a") },
                    { new Guid("2a226c79-2ce8-4d87-bd9d-7fe4c3f52dd4"), new Guid("8c678b4b-0967-4a9f-a09c-f1335a301e40"), new Guid("0ddb6973-0000-4336-9346-77f5760b5e3f") }
                });

            migrationBuilder.InsertData(
                table: "OrdersAndProducts",
                columns: new[] { "Id", "OrderId", "ProductId" },
                values: new object[,]
                {
                    { new Guid("2a8f129d-1d99-4769-a85b-2dea9d27933f"), new Guid("11d0a6f6-1c2d-43b8-9ff9-a9faac9c10f9"), new Guid("06e935a0-e333-4d9e-88de-acd1d326184f") },
                    { new Guid("2ad16e62-8579-4f18-a3f1-f508278aa94a"), new Guid("852b180a-6a85-49f9-9a4d-d82f3343bf1b"), new Guid("2c1a18f7-fcd8-41ba-bb97-11d61f94aa6a") },
                    { new Guid("2b88b409-7373-4c4a-995a-ddddedd95c47"), new Guid("a0c7fce9-e0a3-45d6-8731-0e80a906aa63"), new Guid("f6d40b65-31c3-49b1-823b-0cf1263d04a9") },
                    { new Guid("2bdab5f8-22c1-4021-bbf8-dfd6d28256b3"), new Guid("9e9150af-3704-4ffd-a01e-e8f098bbfb73"), new Guid("64a2d486-eb0c-45eb-8544-ccd274e08700") },
                    { new Guid("2c1d69d6-19a5-4f98-9553-05c718c2b498"), new Guid("e43bec70-46cd-45f4-a22c-d40ddb92a3b1"), new Guid("e92f4032-33e9-47e4-bf3c-351d86a2951c") },
                    { new Guid("2c568821-ceb8-4eae-a40c-1a57510edc55"), new Guid("265e8e24-afd9-4c40-8fb6-95694a975946"), new Guid("0aef3ba8-bc7d-4063-a092-f877dbce4206") },
                    { new Guid("2c7fac99-7acd-401b-860f-76967eede654"), new Guid("407b39e3-1297-4c6c-8deb-ea15cddbcd55"), new Guid("88235e43-5d31-4249-b292-a84dc5d35245") },
                    { new Guid("2cdd05a8-103d-4a84-a1fd-f1c0c84a6ff3"), new Guid("03608ed8-92e0-4bd5-aeca-5b9d6f7f6963"), new Guid("60c94ee1-00e7-40b9-9600-5dd0cc64ec59") },
                    { new Guid("2d1680ad-67d3-453d-a431-db4f4d893cd4"), new Guid("e0ae3c7f-c421-41f4-8091-7d4d18a16683"), new Guid("72e3e645-dbf6-4ae0-9f76-83f108567f3b") },
                    { new Guid("2d300629-6599-4a19-9e09-11f008053a1b"), new Guid("86007e46-c7b6-4e30-9fc8-55903fe629ea"), new Guid("3660271c-3f00-44a2-aec2-6eca7c380fb2") },
                    { new Guid("2da1a758-e9f8-4a9c-be6f-4e8fbedc5912"), new Guid("9efee708-2a9c-433c-8019-48d1708cb372"), new Guid("8e8d00f6-c787-48f0-bcac-0670988815ac") },
                    { new Guid("2dbeeead-6ecf-4db9-b50a-e24e71b0e215"), new Guid("a50375a0-97a7-4119-9b36-0e1febfc8ad6"), new Guid("0020781f-b53e-4d1b-9727-9e16607c6438") },
                    { new Guid("2e6cb970-3afb-4e98-b30b-4ab762001dae"), new Guid("4453eb09-2a58-43b1-aca8-344a57bb465d"), new Guid("2cca4ab6-8866-4725-bb9d-ee71c6839189") },
                    { new Guid("2fafb644-40a5-4a58-a2b5-131d3c6314e1"), new Guid("a25de077-8526-4130-8e71-c93c9a117ed2"), new Guid("11ef0c55-abaf-4218-8ba8-653ab3355e82") },
                    { new Guid("2fe3a0ab-4d63-41de-958e-b20006f6a69c"), new Guid("84c72ab0-f971-422e-ab27-15b06843abb4"), new Guid("fd3c408c-6218-43e8-b0d7-833830d94a1e") },
                    { new Guid("3218c441-e93d-448e-b8db-98b3a0bdbc57"), new Guid("db5d1495-33a6-4820-bfc8-508c0a5b7e4c"), new Guid("50b20d81-82c7-4234-b388-b08e266b651d") },
                    { new Guid("3295ca38-785e-4899-8368-698983953a8b"), new Guid("b9094491-6627-4aee-b55a-a963c691e775"), new Guid("dede6d29-a84e-4f0d-887e-6fabc3336091") },
                    { new Guid("334e1670-7f43-4de9-8746-45ab942c85f3"), new Guid("56ce024e-2af2-4b34-bedb-ea30dd405c08"), new Guid("d493e392-3386-4f97-82a9-35a23acde939") },
                    { new Guid("34c2f3eb-8973-4a69-9236-9ff18663be1f"), new Guid("86007e46-c7b6-4e30-9fc8-55903fe629ea"), new Guid("675dd608-4e3c-423a-af50-c991de0d3852") },
                    { new Guid("35efa315-7d33-4ef8-887e-0eceb5b57acf"), new Guid("da23ac80-e6f8-4bdf-8e07-e271a78e5468"), new Guid("fea80d5d-0435-4bcb-8581-f2cef0ba0bbb") },
                    { new Guid("36f6b2a4-9e36-4ba2-befd-3e179d0b0c1d"), new Guid("f0861cec-b7ef-485a-881e-9ee657a4fa05"), new Guid("08167416-3445-43e0-b2d0-dc17e6bb59b8") },
                    { new Guid("37f8ac84-3fd7-4d84-b7c0-9246073e123b"), new Guid("3490b4ed-5ce8-4a5c-a849-9f962fa57530"), new Guid("471eca15-1cb1-4792-b923-c34b2333de9f") },
                    { new Guid("383739c6-1358-47dc-acaf-3cdeb02c7f4e"), new Guid("c8c05152-9dab-49ee-8892-a1f9e1ba95ad"), new Guid("f14879dc-2c55-44a7-87cd-83380e16b4c4") },
                    { new Guid("38894065-77b8-48f5-afc6-23f9ae079aec"), new Guid("261e9d8f-1605-4436-b886-115e3752c191"), new Guid("8e61f76f-d269-4859-a989-122b59a5aaf7") },
                    { new Guid("38a75a59-5251-441d-8024-6f30781d045a"), new Guid("2fe907e2-4282-45e0-9446-c775a81533f5"), new Guid("03bc4021-7e14-4dad-88f5-35d5b8b87ad6") },
                    { new Guid("38e7ce88-5ab9-438a-8c38-9073c27e7aa6"), new Guid("680fd838-497b-4b60-841e-1f22fa436dc3"), new Guid("18754842-5aaf-4d4a-8c8e-c31d1069af44") },
                    { new Guid("38f9e96f-6e82-4e56-a29b-9d4f4b18ecab"), new Guid("67d91738-294e-4a2c-b686-088e3231c4bd"), new Guid("1ec16144-8209-496d-a5b8-ba501ed84351") },
                    { new Guid("393437d9-436a-41cc-b197-7cee9c3819f9"), new Guid("d8aa8d61-b7c4-468b-a933-aab40a8debf9"), new Guid("e9ee6ae5-af97-4022-96d4-71cc1a34f9d9") },
                    { new Guid("3a058d26-8fb7-4de0-83a3-e25e25bf6a9d"), new Guid("27cd07bc-0cd1-49e9-875c-dcde46ac0358"), new Guid("d38ed64a-419e-4aae-86d5-615a3a0b86aa") },
                    { new Guid("3a40fa6f-9593-404b-a313-fb6171f925cd"), new Guid("4b59c546-4303-4fed-8c0a-03a619f8fde2"), new Guid("51a3c7e5-498a-434a-a9bf-c2f468519fa0") },
                    { new Guid("3aecba2d-57b6-4c5e-85bd-feb0ee5cfa4e"), new Guid("a25de077-8526-4130-8e71-c93c9a117ed2"), new Guid("e98ac0bb-4fb9-4d82-a0aa-7ebe92fea288") },
                    { new Guid("3afe82bb-3564-4e82-af89-948ec1777ea1"), new Guid("90569cfc-0220-421d-add9-31d469ec7b4c"), new Guid("645cd611-ab6a-4502-8ba0-b9569f650abb") },
                    { new Guid("3bc16ee3-0539-435a-b3c5-f3df709b543a"), new Guid("0364cb2a-d484-4ca4-bc7f-0269dff117a0"), new Guid("9709c4d7-b199-47f6-897e-b0307cc53973") },
                    { new Guid("3bd3acad-15e8-4d7a-8a14-3edc9132eb03"), new Guid("7c07859b-9516-493d-be0e-9c88eebaed1e"), new Guid("f33d0d3d-4808-4eec-8701-46a0673cdd04") },
                    { new Guid("3c671d3a-3740-4e5f-b537-bb07682a1739"), new Guid("cc3760d8-7812-491a-9b00-ec2682e69366"), new Guid("22de0a8c-bae5-4810-a64a-b20987bff866") },
                    { new Guid("3ca3053b-fef3-433b-a173-c0fefd62dcb1"), new Guid("7735af9e-da78-4d2b-8b72-b9a48048103f"), new Guid("cbfbc2d7-34e0-4fd1-ba90-5b9ee816eb5f") },
                    { new Guid("3cd88d91-5f3b-467d-9968-66bfe85dc3f2"), new Guid("c6b28fb7-ffd5-47ac-8133-ab4f0e5dee9e"), new Guid("2678d658-45f1-4da7-a551-4f81bc3378d1") },
                    { new Guid("3d73dd51-c7cc-4eec-be26-916b53b422a5"), new Guid("6a265d01-8810-40e1-a8be-95a19432c845"), new Guid("b83fc760-4c05-4a63-831f-a7fb336c78ac") },
                    { new Guid("3e0e0b53-dfda-46a2-ac30-6cf193190a93"), new Guid("b2d90cd4-ad3d-40e7-adfb-443ce406c807"), new Guid("f41f3eee-4c05-4bd2-86df-c448e0214d54") },
                    { new Guid("3e4a4a97-289c-436c-9621-5d69c29a9379"), new Guid("1483d2bf-00d0-410a-9434-18942ea4480c"), new Guid("2c1a18f7-fcd8-41ba-bb97-11d61f94aa6a") },
                    { new Guid("3eb6a9f5-eacb-4a7b-8548-9b7fe7ba8533"), new Guid("197b780d-8c88-4384-81c0-7d9e9079cd6c"), new Guid("5fcb4bdf-bf4a-4681-836c-327c70dd4397") },
                    { new Guid("3eee72a4-0bde-47ea-8d18-f46baa0615ef"), new Guid("86007e46-c7b6-4e30-9fc8-55903fe629ea"), new Guid("c0842b7b-a8d0-477e-9bd5-7414e9b94b7a") }
                });

            migrationBuilder.InsertData(
                table: "OrdersAndProducts",
                columns: new[] { "Id", "OrderId", "ProductId" },
                values: new object[,]
                {
                    { new Guid("3f945dfc-9727-4901-8c29-e395a52dc509"), new Guid("a011c27e-2147-456e-89e4-39100d331111"), new Guid("6e4319b4-135c-422a-8369-a86c38b501b4") },
                    { new Guid("4007af4c-1f57-4bbc-ab8b-b39eaa788e04"), new Guid("a8329365-2236-4bb3-9c5a-1d179ea17b6f"), new Guid("8e61f76f-d269-4859-a989-122b59a5aaf7") },
                    { new Guid("402add7c-1ae4-4a8c-85fd-92d42b2b1acf"), new Guid("9eca63c4-8b05-422f-832c-5541ef3abbff"), new Guid("68a0c05e-2ce2-49f5-81d5-19e6ed143179") },
                    { new Guid("40794663-ff58-4a72-b9d8-a744fd080787"), new Guid("266addb0-2be7-4a19-aafd-442713397afa"), new Guid("5e240019-3a8c-4a7f-a0f3-6f9d23d339f4") },
                    { new Guid("40965102-d694-4909-87f0-027b86c04b07"), new Guid("88f8318c-c6a3-410e-8201-9f373be10bd8"), new Guid("1ec16144-8209-496d-a5b8-ba501ed84351") },
                    { new Guid("4111dda7-df92-4dee-98ca-2ad9a67ee7f0"), new Guid("35c2cdd5-3819-4ba9-9763-ee7349cb03df"), new Guid("86928647-7a09-4acd-a9ff-f10f7d836036") },
                    { new Guid("41dbce6a-a4b5-457a-bdfd-af0bf5202949"), new Guid("291f2ee3-ad9a-4947-a795-0f70bd2a074e"), new Guid("5ef14a0e-448d-4122-8ee2-60bf587b3988") },
                    { new Guid("424ab566-eb76-49c7-ba90-17728e71cbfa"), new Guid("7735af9e-da78-4d2b-8b72-b9a48048103f"), new Guid("675dd608-4e3c-423a-af50-c991de0d3852") },
                    { new Guid("42b64b53-0fe8-4f37-81be-b918b9c300f4"), new Guid("e1d985b2-e42b-4c0d-9096-f477da44ddb1"), new Guid("53944f4c-6a30-4d31-9022-8670093cb391") },
                    { new Guid("42db25a2-53a9-4734-ab5d-4ffc567c4109"), new Guid("86ee9e2d-2d4f-4a96-8b46-2fd891d0d461"), new Guid("7dee21b2-761a-4cfd-8a74-9240de6106d9") },
                    { new Guid("42f9d339-c74d-4ef9-a51a-9b22449b77f8"), new Guid("72685788-1888-4813-88f9-46aadc9d1b42"), new Guid("3b71f71e-82c0-4054-bd3e-c127770ee7ea") },
                    { new Guid("44161169-e2c2-41b3-ae1e-5a16830b9e9d"), new Guid("c4344593-9067-4fa8-9ca1-dbd75c646933"), new Guid("857aa3c0-f8d7-40fc-a918-ddf2ba237794") },
                    { new Guid("448d8263-2194-4761-b9e5-d1162d5745da"), new Guid("a40fe25c-289e-4439-9d95-ea36ec9ee1e6"), new Guid("9846e117-f6ec-488f-831d-080be659a1ee") },
                    { new Guid("44b2e07d-e50f-4626-be2a-653005df939b"), new Guid("9852ea3f-d53e-4f9e-b9e2-f865454b2a46"), new Guid("f33d0d3d-4808-4eec-8701-46a0673cdd04") },
                    { new Guid("44db622d-0b67-4325-8c2e-bf1b7a98de76"), new Guid("fc0889cc-881f-46f5-96b1-88f030351829"), new Guid("cfe7bbfe-8e8e-4e6f-965e-9c7134c15da2") },
                    { new Guid("45367dac-6214-4d9b-bd81-2dacb38d8dfb"), new Guid("db312aa7-7579-42e9-b61d-74e7fe94774f"), new Guid("42b1e480-e533-4564-a5e4-4255f9c3bf62") },
                    { new Guid("460fb2b1-8f06-4de6-b3b8-7fef8f30cdf3"), new Guid("b9094491-6627-4aee-b55a-a963c691e775"), new Guid("473e8f3c-dd0f-4e2d-9733-2d92f1ebfe5e") },
                    { new Guid("47155fc7-6956-47bc-9d45-a3baa95911c3"), new Guid("d74cce4c-e8b6-466b-aaa6-c275de924a87"), new Guid("0898b046-3505-468b-bea5-162d93b3fce7") },
                    { new Guid("4732103c-62a9-4b04-a539-e321d19b20b3"), new Guid("5f514b03-4905-4291-8281-0007fa287506"), new Guid("7dee21b2-761a-4cfd-8a74-9240de6106d9") },
                    { new Guid("4a3ee49b-79ee-4bd5-a606-8777a089a5a2"), new Guid("2a9b3630-c805-4be0-9156-3c638f0a6ee5"), new Guid("a0672440-467a-48ef-af8c-d2e8c5f57e55") },
                    { new Guid("4a583628-fbd8-4e8b-8cb7-8df42b5188ef"), new Guid("8e0af860-1d6d-4d6e-9246-bd4b01ac7654"), new Guid("51a3c7e5-498a-434a-a9bf-c2f468519fa0") },
                    { new Guid("4a5bcb31-3f2a-4939-929e-c0bd32c824bb"), new Guid("ae2556db-9361-49bf-8996-3b30ecbac2cc"), new Guid("050850d2-025b-4a6d-b6b7-523cc1aef313") },
                    { new Guid("4ae175a3-4564-4627-be02-b868a5429c90"), new Guid("db65a7dc-cb84-4270-8c04-fad22813ca2a"), new Guid("e1452ecb-4988-4813-8240-8e30f7a78b1e") },
                    { new Guid("4c72125a-bfc9-4777-835a-2a9e1cd9924b"), new Guid("0d230fc2-9bcc-4260-ba14-42fadd51b4a1"), new Guid("0306ea4e-b54f-45d0-b880-d426fc0c8108") },
                    { new Guid("4df314e3-6931-4a72-907c-7623ec944a93"), new Guid("26606820-77ad-43ad-b170-ba0c54b23b57"), new Guid("9283bc94-0644-4756-902d-f715e384ff57") },
                    { new Guid("4dff1c54-cb97-4d89-9402-6807f55406e3"), new Guid("da7ece2d-d6f2-4108-91b0-e00b0034b145"), new Guid("9bdb5036-a20e-42b6-88d9-fbaf7d7859cf") },
                    { new Guid("4ea23e78-a083-4f6e-968c-4b1695d15a4b"), new Guid("5201e150-83ca-48d8-b84a-a2940594f9bc"), new Guid("c0842b7b-a8d0-477e-9bd5-7414e9b94b7a") },
                    { new Guid("4eba6035-8efe-423c-bef1-ed3f592af0a1"), new Guid("f17810e0-360b-4ed0-85cb-9e50f44f1aa7"), new Guid("edf62bb5-3f24-4c07-b181-dff0c0597e85") },
                    { new Guid("4ed9e7cc-272d-4252-a838-b394f9539c3e"), new Guid("6e4810b9-a611-497b-9a99-c770d52df1de"), new Guid("3579f928-ea2d-4d65-945a-cb009a83fbec") },
                    { new Guid("4fd65e70-fc41-4e40-8b2c-9f2a218d46a2"), new Guid("6abbfcaa-13b7-4b69-a02a-573be067ddcb"), new Guid("36ecc915-58bd-4a32-b353-9aa35515a242") },
                    { new Guid("51851509-189c-48a9-977f-69caeb63b733"), new Guid("3d282e1e-b2ef-48c8-accf-9c67cee0e8df"), new Guid("64a2d486-eb0c-45eb-8544-ccd274e08700") },
                    { new Guid("51e0a03a-c4ba-4161-8dcc-601a6c0f6e9b"), new Guid("a4ef26cc-1d87-4659-8478-4ef2e46be114"), new Guid("0d5404b1-2a1a-479a-a0df-32f1198c1254") },
                    { new Guid("524399f2-c7cb-4a9e-b37a-f4343541efea"), new Guid("04869701-a774-49ea-85b1-b0106e5ae97d"), new Guid("5f79c598-ac0a-4fc5-8bdf-cf9a23022ea9") },
                    { new Guid("52d9045f-e22d-4612-8370-37949887ef3b"), new Guid("d1164aa1-5c4c-460e-8bfb-56c7ed2d45dd"), new Guid("e492fd43-8c8e-452a-997b-d0e1346f5e19") },
                    { new Guid("5350d8c8-4dbe-44f5-b794-ef86c4e2e8c5"), new Guid("5e670ce7-7a0d-456c-81e1-1c1eb380bed0"), new Guid("be96d1da-6d28-478e-8256-901202e003f2") },
                    { new Guid("53775e30-f222-4100-8d1f-1f5942cb44a2"), new Guid("c64d27e3-e62c-4e2a-8001-79a6447eb134"), new Guid("d4504d54-6313-4c90-86bd-36ace24b2b41") },
                    { new Guid("54f2d4e6-ecba-4f39-af52-da5db8f4f00d"), new Guid("e8301a2a-b55d-4a1c-961b-d00359ab1f77"), new Guid("8aefdf4d-c49b-4e37-8861-9c1666dd9c8e") },
                    { new Guid("552346c2-213f-4caa-845d-e72b3ac28e83"), new Guid("63a4d70d-86a3-4dec-a6dd-3e4ceb463855"), new Guid("9e67bea1-826e-4459-832c-64607f68f71e") },
                    { new Guid("55267e66-6aa8-4bb2-a8a0-e912a0fbaba8"), new Guid("a1e99d63-2bea-45c7-b958-0ddc23317386"), new Guid("0aef3ba8-bc7d-4063-a092-f877dbce4206") },
                    { new Guid("557d010c-3ddd-4da2-8bef-fd75c51d6924"), new Guid("161466e9-4ca1-48a3-a9c1-bcc0433d28db"), new Guid("72551552-9343-4ec0-9d28-7b3850030eaf") },
                    { new Guid("55d383cf-4431-484b-9ff1-288d0df771dd"), new Guid("5eb24e1d-a6ef-47a3-a042-5cd191eca1a6"), new Guid("a74aa544-9c93-4692-8019-4a596f2ee891") },
                    { new Guid("56bbf648-5298-4fee-bb51-b26e2c656a47"), new Guid("7e69f3d7-d018-41a8-ac78-4aa485febfa5"), new Guid("5d1c7888-b678-4aff-b3dd-18187b237503") }
                });

            migrationBuilder.InsertData(
                table: "OrdersAndProducts",
                columns: new[] { "Id", "OrderId", "ProductId" },
                values: new object[,]
                {
                    { new Guid("5796f925-8cb7-48c8-804b-84b800c4466d"), new Guid("cd8cb360-864b-4bbc-b9fd-741555e5e886"), new Guid("a1a737bb-565c-4136-beca-11d282c7cf4a") },
                    { new Guid("583b58c8-eff4-4a7d-a9b1-d3c450debba2"), new Guid("ffa94aa3-e381-4ba0-a286-fe757ad03608"), new Guid("1b139120-8834-4cf0-b689-f490a62965e9") },
                    { new Guid("58c4b929-361f-47df-9656-1b24169c2a6c"), new Guid("7ca7c879-5dc5-4ad2-b9d8-a74f2eaf3f5e"), new Guid("5f2ea04a-aff9-4dca-b1ab-bdf2becc26d9") },
                    { new Guid("5a75a06c-9e96-46bd-837c-f0fbac07fbd7"), new Guid("4c6fcb42-e354-4b1a-b8e1-99311239fa29"), new Guid("f1ad78a1-9698-48c0-8b53-84147484e6a9") },
                    { new Guid("5a80fa5d-359b-4a91-9f8b-3522be37b4fa"), new Guid("e68283a6-c380-45ce-8913-04ff741fb99d"), new Guid("dede6d29-a84e-4f0d-887e-6fabc3336091") },
                    { new Guid("5abb52e7-c760-4e28-8722-ec7591f4c238"), new Guid("27cd07bc-0cd1-49e9-875c-dcde46ac0358"), new Guid("2f66f436-6082-4806-93b5-25608fb4b29d") },
                    { new Guid("5aeceb5e-0ecc-49df-8465-505ed630f6db"), new Guid("ea9fc8dc-8429-4c93-8a4d-0f23cf6566ca"), new Guid("cdb2a69e-c9d4-4db3-9508-107452832e4b") },
                    { new Guid("5b80e266-120d-4609-9c3c-c58dda651bab"), new Guid("89141d58-b274-4293-89bc-43637fe34d65"), new Guid("076faa7b-e8b3-4c7e-8902-4861c7104532") },
                    { new Guid("5bffd88b-887b-4058-91cf-3abfec4fca3c"), new Guid("8fdf96c3-5a81-43e9-8f21-f5337bf36f31"), new Guid("d3151eca-6078-449b-92ef-63c365450eb7") },
                    { new Guid("5ca07209-89a4-46bb-9b7e-119e395bab90"), new Guid("c3daa4aa-5573-44cf-8366-2e6ce1274e20"), new Guid("cdd54da3-eb0a-4e04-b05c-083b4e8eae31") },
                    { new Guid("5e90bbc8-4183-40f0-9a1d-5950b1083836"), new Guid("d8de47ed-ff98-4997-b44b-ea515ac67bd0"), new Guid("42b1e480-e533-4564-a5e4-4255f9c3bf62") },
                    { new Guid("5f935dac-4bda-45cc-a495-0170ce4d051f"), new Guid("f628248c-4c5e-4149-93cb-26173a744aab"), new Guid("3e5833c4-493b-4d87-bbe5-275569c723a3") },
                    { new Guid("6047f1b9-2453-4d50-be42-f514dad530a9"), new Guid("89141d58-b274-4293-89bc-43637fe34d65"), new Guid("c2c03071-bca3-4c11-bd9c-99a4eed43eb8") },
                    { new Guid("60e6d26e-2c49-41a6-a51c-d5f3aa57d91b"), new Guid("877b7f69-7a1c-4d19-b612-83c0c9853845"), new Guid("cfe7bbfe-8e8e-4e6f-965e-9c7134c15da2") },
                    { new Guid("618a68d8-102a-4c00-ba42-687df1be9e8c"), new Guid("67d91738-294e-4a2c-b686-088e3231c4bd"), new Guid("8687bf1e-1f8b-4fb6-b406-f1c95e4c7cbb") },
                    { new Guid("61e327ba-29a1-4141-826d-d2c1206a2080"), new Guid("567b1de9-4ea0-467f-9846-688e7a604562"), new Guid("d91629ee-b000-4c2f-b106-0a4eadd13da4") },
                    { new Guid("62360831-52c0-45a2-9d81-b58cd7d6ee95"), new Guid("ace9b8e9-b48a-4c43-a892-e84f906081a7"), new Guid("9f2e927c-70c3-4de9-afb7-02f62aad3643") },
                    { new Guid("62a1339f-c603-4ff6-a962-ad15628cc31b"), new Guid("b096f8ff-2e4a-41c1-9c60-34e8ae214a8b"), new Guid("0e913aed-4729-41de-bdcc-71e19921684d") },
                    { new Guid("632fffee-09a8-4e43-80cd-271d6ee11076"), new Guid("92766157-8f58-4b56-b901-b1e198f62c34"), new Guid("3eaf1aa4-138a-4aba-80f1-9917772bb29c") },
                    { new Guid("636d7762-0205-4109-94d9-0e9287b04c12"), new Guid("17200911-e538-4545-9b62-dd79bacfb277"), new Guid("5f2ea04a-aff9-4dca-b1ab-bdf2becc26d9") },
                    { new Guid("641b0f3e-6e48-4e6b-a76a-517b0a1f0725"), new Guid("f019f651-9365-4ce1-9ad1-6de045d0ae71"), new Guid("044dd1b6-9db4-4006-b891-3bb3d9069785") },
                    { new Guid("643fae43-1013-48d2-9569-9120f298e28c"), new Guid("096ccb7a-f57e-4c8a-95d7-acc897b4f3e3"), new Guid("537ba2e2-4e8c-4c18-b690-6458f1fd2888") },
                    { new Guid("6440a699-163c-4e7e-b51f-1a6c1eba33fc"), new Guid("6e4810b9-a611-497b-9a99-c770d52df1de"), new Guid("b17b495d-10bf-4587-a1bf-0042d6af21af") },
                    { new Guid("649a52f6-deb5-4323-9a7d-b47b19fa727c"), new Guid("b76cc054-0f3e-46b6-9432-be50d7224ee4"), new Guid("f9e4f18e-5ac4-4520-bfb5-f1ccb63bbf94") },
                    { new Guid("64d1c589-d9d9-48d7-b509-95002ec8e213"), new Guid("1bea0342-3923-4b8a-aa68-7e1d9abf447f"), new Guid("031e072f-5a72-4752-ac43-333b9a222060") },
                    { new Guid("65b9baa9-f73d-4ccd-a0b8-2a4cb1eafbc8"), new Guid("7f5b1167-c427-41f9-91be-cc311cfafb62"), new Guid("0d448b05-0237-49e2-96c5-42f85d98cf1c") },
                    { new Guid("65dbaf49-d8be-426e-8e2d-1849f25183ee"), new Guid("89141d58-b274-4293-89bc-43637fe34d65"), new Guid("76e97616-1e4f-47b1-ab17-713a78b29511") },
                    { new Guid("66259974-3f0d-440d-944f-bd9fc445ab68"), new Guid("fed644ef-031a-454c-b4d5-f038767c027a"), new Guid("9606fc25-e2c5-4ba8-b251-ffa21ed977c7") },
                    { new Guid("6631979b-530b-4a54-ac8b-a87226aa0a75"), new Guid("2cba95d9-c50d-4131-a870-69561d6f75b3"), new Guid("a0672440-467a-48ef-af8c-d2e8c5f57e55") },
                    { new Guid("676e2ea1-692b-456b-9bb3-ca729d6da322"), new Guid("8e3d541f-27ce-4531-8254-03133281e4c1"), new Guid("2f725460-2cf3-4dfe-8e67-8373ecdbeeab") },
                    { new Guid("6809daaa-3b8f-40a2-85dd-ca6078e78b5c"), new Guid("20a58ba9-6c77-42ac-9748-7a1a08f68c4c"), new Guid("86928647-7a09-4acd-a9ff-f10f7d836036") },
                    { new Guid("686fec3b-2292-4d19-88c1-0b94142f7ca4"), new Guid("66c8f9c9-ac72-4a35-bde9-49eb54e698db"), new Guid("a2ee40dd-5f6b-482b-be0b-83ae8101c978") },
                    { new Guid("687999ca-0a2e-4d60-899e-4b6a42dfe20c"), new Guid("7dbf3e2b-8bbb-4f83-84f8-19ffddf8ba7b"), new Guid("90354f46-a58c-4dbf-8cd5-f512df8e16c0") },
                    { new Guid("6901895b-1484-4370-9d84-7cc42fa0efe5"), new Guid("ba699059-b7a7-4f25-a6aa-493bfaa7d673"), new Guid("d619532e-d86b-494a-ae8f-163d7fdac0fb") },
                    { new Guid("69552924-4f51-4071-b38a-7fe4f5639f64"), new Guid("46ad4204-1ac4-46ad-8a85-a6186fc33341"), new Guid("544224be-ceb5-4e68-9d6a-d5664bab93a9") },
                    { new Guid("69bd99c7-cd5d-4989-946a-d9eb982cddc6"), new Guid("339b397d-9aa1-40e2-a9a6-f28b28d5e5ff"), new Guid("ba189dd7-ac3c-4ead-9ac6-6761a7e7300d") },
                    { new Guid("6a4d4371-cf19-419c-90ff-193fa2eeea92"), new Guid("ee56a0ed-0ebc-449f-adee-0d287f06b55e"), new Guid("a1c642be-46ea-493f-8c5b-f94aa7cd3abc") },
                    { new Guid("6a84fd3f-6eb3-4ccc-95de-12b7351e5807"), new Guid("68a2d01f-d984-45b5-9125-9be9d111e247"), new Guid("5297ddc6-318e-4517-a0e8-f1e21b7a30e5") },
                    { new Guid("6ad71e71-af4c-49c2-b7c7-74a3d42089a6"), new Guid("15729ad3-1106-41ca-8347-867aa60b824a"), new Guid("8aefdf4d-c49b-4e37-8861-9c1666dd9c8e") },
                    { new Guid("6aeafdf8-f9b2-49f0-8dfb-21c1a4daf707"), new Guid("10dbba4a-c607-470e-86c4-af869b484108"), new Guid("bc33db74-2cbd-40fc-a06a-7f02297e3fd2") },
                    { new Guid("6b14762a-d91b-4af6-9771-b55ab10f283f"), new Guid("26fa527f-fffe-401b-b979-a96aa4b10e31"), new Guid("675dd608-4e3c-423a-af50-c991de0d3852") },
                    { new Guid("6b87eb0f-8feb-46ae-ac86-d60fd5c9048e"), new Guid("7e510a3a-9ac9-4b82-a868-1fcbe3704a82"), new Guid("821a828c-89e6-48c1-952a-b269712f4a80") }
                });

            migrationBuilder.InsertData(
                table: "OrdersAndProducts",
                columns: new[] { "Id", "OrderId", "ProductId" },
                values: new object[,]
                {
                    { new Guid("6bf0b05b-a1f2-4612-8872-60d02f9c531c"), new Guid("4f726b8e-4e52-4f72-8ea3-41ea36c1b12e"), new Guid("2d0f8237-db3f-4cb6-b1c8-11c46ffaed62") },
                    { new Guid("6c1755aa-309c-4f3f-b529-b57146d00b3a"), new Guid("f1988402-7be2-4d2f-afc8-4e5dbcd568a4"), new Guid("ba185299-ec9d-4300-b4ad-b298563bdcb9") },
                    { new Guid("6ce7f980-b11e-4eda-bd6c-f972eb6fe8d9"), new Guid("a40fe25c-289e-4439-9d95-ea36ec9ee1e6"), new Guid("3660271c-3f00-44a2-aec2-6eca7c380fb2") },
                    { new Guid("6cf604f9-9ab3-4f39-b68d-af8ece8502e0"), new Guid("9efee708-2a9c-433c-8019-48d1708cb372"), new Guid("67b8b0cf-6911-48e2-ac8d-d134bb1905c5") },
                    { new Guid("6d64a920-99d0-479a-a91b-6fbf31b80ae5"), new Guid("fda901d5-a3aa-459c-84be-677b40a61d7b"), new Guid("e98ac0bb-4fb9-4d82-a0aa-7ebe92fea288") },
                    { new Guid("6d74e52f-c95a-4207-ae84-cc2794eaf277"), new Guid("16a6e6f7-51af-4f9a-b5df-fbc335656de5"), new Guid("05e00bf9-de4e-4023-9d35-612c07b6e372") },
                    { new Guid("6dbf05e0-38e9-483a-b8db-a29d86ae22b2"), new Guid("9a823b4b-2e5f-4f87-82cc-5be68367f3c3"), new Guid("60c94ee1-00e7-40b9-9600-5dd0cc64ec59") },
                    { new Guid("6dd7d764-f193-42ff-b427-1b03704b6c13"), new Guid("da7ece2d-d6f2-4108-91b0-e00b0034b145"), new Guid("68a0c05e-2ce2-49f5-81d5-19e6ed143179") },
                    { new Guid("6e7b218f-23c2-4dc0-9707-cd8f0b7e09ee"), new Guid("e2a2186b-cb4d-4517-b9f4-55da286c17db"), new Guid("2c1a18f7-fcd8-41ba-bb97-11d61f94aa6a") },
                    { new Guid("6eaf2743-d78e-4c10-90d3-169c92621c21"), new Guid("596f670a-752f-4bf8-ac93-224a15012fbb"), new Guid("e546b9af-64b0-4df4-bcd3-0f7715926432") },
                    { new Guid("6f411337-f44c-491e-ba11-4097ccad30c4"), new Guid("f2d3de7b-72a4-4be1-8012-9bf3a1d05384"), new Guid("8b525917-db38-4f4b-ba04-482fa105a571") },
                    { new Guid("6fc50034-f039-42c1-acc3-1a572f6509de"), new Guid("8db051ca-1281-4eb7-8974-f141a53409d0"), new Guid("c812267e-e166-4cf8-99e5-9af7553c30a8") },
                    { new Guid("70517a11-ea99-409d-9579-a9c78e204f1f"), new Guid("e5eab42b-e5c5-4151-ac49-0a2a34ffa105"), new Guid("cdb2a69e-c9d4-4db3-9508-107452832e4b") },
                    { new Guid("733315e5-0976-4f72-8f4b-38a5192ca8a8"), new Guid("9e9150af-3704-4ffd-a01e-e8f098bbfb73"), new Guid("2095057e-2baa-49fb-85c0-92f6bbe987d1") },
                    { new Guid("73ee8159-0d7e-45d1-a288-b32386fde99b"), new Guid("72685788-1888-4813-88f9-46aadc9d1b42"), new Guid("aa707f39-f14f-4893-8a8e-5df77195fbbb") },
                    { new Guid("74065790-ee3d-4724-b20c-2523b3316cbd"), new Guid("e43bec70-46cd-45f4-a22c-d40ddb92a3b1"), new Guid("b0aaefc3-61eb-4c58-9a70-c0cca1bda4f8") },
                    { new Guid("750b2f27-16ea-45fb-b409-b52c253547c5"), new Guid("791274fb-be73-47cf-9780-8956ebe4c5ca"), new Guid("874e26c5-3f38-4a03-a1ea-10e62e420f98") },
                    { new Guid("75e46ace-3a84-43fa-96d9-1a128d355f07"), new Guid("9eca63c4-8b05-422f-832c-5541ef3abbff"), new Guid("64ba790c-055e-4b66-b11f-777648f39cf3") },
                    { new Guid("764fd68d-3b89-41a0-af6f-ca97e6d19c34"), new Guid("fd204683-1678-4380-b0af-4986cd9f0ea1"), new Guid("b96ba429-8209-4145-867e-be4a076d9cd3") },
                    { new Guid("76ae3c16-55bf-47c8-9be7-36e56b1fe04c"), new Guid("3e8d0aad-e517-42e5-8eed-279c4b6bc37c"), new Guid("f656320d-154d-4a6a-8dcc-4bf57214bf37") },
                    { new Guid("782d3160-6a84-4c5b-8069-d5c3bb69987e"), new Guid("f5f4f233-57bc-4297-a435-1c968452f829"), new Guid("471eca15-1cb1-4792-b923-c34b2333de9f") },
                    { new Guid("782fb3cf-2c3b-4964-a27b-7fae46e1ef73"), new Guid("a14806a5-f231-4389-8014-588910e49419"), new Guid("dacc8a3d-850f-4c2d-aca6-437b8ce03f16") },
                    { new Guid("7adc0f9b-78aa-405b-a8ec-be1ac9f25706"), new Guid("70022831-94be-4a7d-92f3-d658aaa0acc4"), new Guid("42b1e480-e533-4564-a5e4-4255f9c3bf62") },
                    { new Guid("7b0ab8aa-6147-4daf-b0ce-da6ac60c0f47"), new Guid("0a3c1630-08b4-4469-9409-a5b593b1ef04"), new Guid("b3948c74-a4aa-4570-91d0-c857dc5b0e61") },
                    { new Guid("7b56de2c-d5ab-46cc-9969-0853148537fa"), new Guid("597ae486-beae-4334-b730-fb40e58ef537"), new Guid("e9ee6ae5-af97-4022-96d4-71cc1a34f9d9") },
                    { new Guid("7d78c14a-fc4f-48f4-9e8f-03378c7a5d64"), new Guid("5e05146f-b1fa-4949-b0b6-f8363ff3bb9f"), new Guid("a60afbfd-fc80-4470-8101-4624eda20c6a") },
                    { new Guid("7db9b067-eb73-499d-940a-26ef8ce31fd4"), new Guid("b779d7e4-5123-4d73-be2e-3c9e13b630eb"), new Guid("6600d780-37a0-4b59-8b8a-bac6187bafe0") },
                    { new Guid("7e614026-3360-4322-b842-4ce5f5f4ae1f"), new Guid("6a0f9516-df1c-4ea2-aaab-6c5c2ed1d21a"), new Guid("f656320d-154d-4a6a-8dcc-4bf57214bf37") },
                    { new Guid("7e874e3a-29e9-40a1-b6ce-e1d130f84c76"), new Guid("dc0b6ed1-3322-4cdc-93f6-9005b54fc3e9"), new Guid("2c1a18f7-fcd8-41ba-bb97-11d61f94aa6a") },
                    { new Guid("7f9b1a89-54a5-473b-b3c1-1f07147fcb02"), new Guid("e91f09d3-a378-4db9-8c71-f1e02486814d"), new Guid("e92f4032-33e9-47e4-bf3c-351d86a2951c") },
                    { new Guid("8013dbbc-09eb-4684-b4e5-98f06976ec62"), new Guid("47f75e7b-a7f7-4ce0-a2c2-e8e3c216fa40"), new Guid("63796282-dedb-4ea8-b1b4-33f5389d6b74") },
                    { new Guid("80260a8a-0429-45db-859b-32ae0395afa6"), new Guid("f019f651-9365-4ce1-9ad1-6de045d0ae71"), new Guid("30b876e0-b15c-4737-bcc4-e8979f94e870") },
                    { new Guid("8070541f-0e5b-47a5-8d96-46d2bb7fec62"), new Guid("2a853a0b-4e61-4d6e-9234-020c1efa63e0"), new Guid("029937be-923a-4694-9ad3-321e4709bb73") },
                    { new Guid("80b74926-5e21-4d2d-807a-100fa75f77a5"), new Guid("7eddae9f-9286-495b-8c0f-debe878d07ea"), new Guid("c8c181e2-08b4-4230-8626-bd98ba652ac1") },
                    { new Guid("80c40c40-a625-45a8-bae8-2547d5c60c04"), new Guid("745d91b9-a5b8-44c4-b780-702cd5785366"), new Guid("424f0d47-2a37-41c3-bdec-d1b0e6b30386") },
                    { new Guid("81086146-2022-436a-b5db-f891415ffe49"), new Guid("65729050-a4ca-4fdb-9156-e08b2211f5d1"), new Guid("5f79c598-ac0a-4fc5-8bdf-cf9a23022ea9") },
                    { new Guid("815208da-95b5-4459-a47c-fc3a11016c7d"), new Guid("745d91b9-a5b8-44c4-b780-702cd5785366"), new Guid("872849c1-d0a4-41d0-806e-6fa8b702e565") },
                    { new Guid("821ee7b1-048e-4184-8ba6-042784dfaf3c"), new Guid("e9f96bc2-1cf5-4eb7-b0b8-1d478ffcf572"), new Guid("029937be-923a-4694-9ad3-321e4709bb73") },
                    { new Guid("82323979-d62b-4900-8e0b-cb2cdd97250d"), new Guid("c95cfc86-a73b-41fb-9b0e-c28d6af1d92c"), new Guid("18754842-5aaf-4d4a-8c8e-c31d1069af44") },
                    { new Guid("824dfc4f-c0af-40ba-bede-3373ae6853a5"), new Guid("a4ef26cc-1d87-4659-8478-4ef2e46be114"), new Guid("02b1cabf-4043-4ac7-b858-3887e0587613") },
                    { new Guid("82e55944-fca8-4e2a-85a8-25a670afcde9"), new Guid("20d10716-eb27-4057-afd3-fdddeebc110b"), new Guid("eba69462-4537-4f23-bbf9-13b3a9edf6c9") },
                    { new Guid("83dbee4b-c86b-4c58-9025-5e3f8b26dfbb"), new Guid("ea956ff3-fd2c-42c9-98e2-234fda2b5617"), new Guid("02b1cabf-4043-4ac7-b858-3887e0587613") }
                });

            migrationBuilder.InsertData(
                table: "OrdersAndProducts",
                columns: new[] { "Id", "OrderId", "ProductId" },
                values: new object[,]
                {
                    { new Guid("843ea98d-df68-45e3-9837-5dab9ae8e1b2"), new Guid("98ad25ae-4187-4054-b85a-e18f5e3b7f91"), new Guid("f378869b-158d-4073-b78e-cc9b40b174db") },
                    { new Guid("84433d99-6310-4612-9b0a-e0aec6ea656d"), new Guid("67d91738-294e-4a2c-b686-088e3231c4bd"), new Guid("e546b9af-64b0-4df4-bcd3-0f7715926432") },
                    { new Guid("844e8b82-7cfe-4c44-a7f2-8bc631b364fa"), new Guid("60a73766-96ef-44cb-8d3c-170fd976359a"), new Guid("9e67bea1-826e-4459-832c-64607f68f71e") },
                    { new Guid("85060250-a927-4fca-9947-e920dc9e15d2"), new Guid("61315754-2ef8-40e8-b029-15b7da15b112"), new Guid("43089309-0f9e-462e-ad47-0caa3caca915") },
                    { new Guid("872f9bcd-e071-47f4-9db6-0a2f1e4941b9"), new Guid("5201e150-83ca-48d8-b84a-a2940594f9bc"), new Guid("2cca4ab6-8866-4725-bb9d-ee71c6839189") },
                    { new Guid("8774612a-70e6-4805-89ab-02a8834e6948"), new Guid("5eb24e1d-a6ef-47a3-a042-5cd191eca1a6"), new Guid("c9741562-b3fe-4114-a0a7-1a0ac245e202") },
                    { new Guid("87a2c996-27ba-42ba-9402-7a0f4f9df486"), new Guid("0ef730c2-bb54-4594-9036-f1007cd3e939"), new Guid("424f0d47-2a37-41c3-bdec-d1b0e6b30386") },
                    { new Guid("87eb1bd4-18c3-41b5-824a-1d4cbd83fee2"), new Guid("0d1578ef-e30c-4027-a7c6-a64663c78109"), new Guid("927a0c9b-4abb-4805-8353-b876afd4c9ec") },
                    { new Guid("8824a74a-1be4-4fee-9fb8-73525b557b7a"), new Guid("e23df0cd-f5bf-4dd6-81a1-0d145c4803f0"), new Guid("6357e80c-ea90-431b-b78e-2fdd8dde8980") },
                    { new Guid("883fdec8-69dc-49cd-939f-70dcc1e84e79"), new Guid("a0c7fce9-e0a3-45d6-8731-0e80a906aa63"), new Guid("c5fb3cf3-2b62-4fa3-9a7d-85bfb944a6c5") },
                    { new Guid("888b1cbb-ccfd-4c94-b051-58dffe3c74fb"), new Guid("f9814a05-6553-42a8-8931-a8e4b885f513"), new Guid("e1452ecb-4988-4813-8240-8e30f7a78b1e") },
                    { new Guid("88969432-8053-4f9a-a4c2-f711f088e8b0"), new Guid("923da64f-5b9f-4b14-9729-621186788125"), new Guid("044dd1b6-9db4-4006-b891-3bb3d9069785") },
                    { new Guid("88ba64b6-e811-497f-a08b-e3da9c0fe9d6"), new Guid("0032e1a1-9827-483f-b5c4-690df498d00f"), new Guid("12096f59-f68f-46f6-a6a4-b4c2a445d851") },
                    { new Guid("890891d7-1329-4a32-9be1-ad1acbd0b1a9"), new Guid("596f670a-752f-4bf8-ac93-224a15012fbb"), new Guid("fd3c408c-6218-43e8-b0d7-833830d94a1e") },
                    { new Guid("890abaf9-6d11-472f-a02a-ac3513a80a8c"), new Guid("37502bf4-dd7b-4aeb-bcb9-136f166d54bb"), new Guid("e60b3413-bcc4-43d5-aaf9-b2d6ee1caaa8") },
                    { new Guid("893f243a-d7e2-4d2e-a7f1-41d58db4488d"), new Guid("fc0889cc-881f-46f5-96b1-88f030351829"), new Guid("a4632387-cce0-4bd7-a10f-53115a35f3b4") },
                    { new Guid("89748b9e-2b90-4188-9eb6-beeeb430c9f0"), new Guid("e2a2186b-cb4d-4517-b9f4-55da286c17db"), new Guid("a4d3b7c4-85ed-4942-aa05-2a8016bfb624") },
                    { new Guid("8a9a2bc9-7a17-4746-8357-35699c71c8c4"), new Guid("2b97a2d7-a4a2-407e-97dc-92041e835bfa"), new Guid("38d707ed-5b6e-41af-9bda-37aaa9171b2b") },
                    { new Guid("8b089495-e023-492a-93c2-f92bf32d9963"), new Guid("3665cbb4-36f0-4413-93ff-98fa84cb8968"), new Guid("949ba657-8837-443f-bd4a-5654bbfe0cf2") },
                    { new Guid("8b7abeed-bf8c-43ce-8741-84ac89bc216b"), new Guid("33fcbe5a-0161-477b-b72a-df742ccdf74c"), new Guid("8e6de47c-317d-4f39-b055-dc1eff7d2680") },
                    { new Guid("8b7e3434-148a-47a1-b3e7-d150f9dea77a"), new Guid("7a958c06-c942-488c-adc2-8e1da84f7bc9"), new Guid("c2620d90-0cd5-4697-ae28-928347ed4d9c") },
                    { new Guid("8b8ba163-414a-42b5-b5ba-f3c8ed6c802a"), new Guid("68a2d01f-d984-45b5-9125-9be9d111e247"), new Guid("88235e43-5d31-4249-b292-a84dc5d35245") },
                    { new Guid("8ba71c8d-d388-4817-9a47-63ba5c7d4d49"), new Guid("27cbad4f-ad0f-4b61-930f-1567dc955e4a"), new Guid("2f81f126-078e-4aa5-9a85-4e80bd255e04") },
                    { new Guid("8c094eb9-bb38-42a7-bc3d-87c3cf47acc8"), new Guid("48235d43-9930-4c98-aecb-88efd3614e57"), new Guid("5383a442-70f3-42eb-be86-fb34b3c71165") },
                    { new Guid("8c44bb46-e098-43cf-8317-d46de4bc2956"), new Guid("6ab5a5ac-75ec-40bb-b23e-79228a9dd12c"), new Guid("6e709700-9ee3-4df8-a627-190d06c0820e") },
                    { new Guid("8ca5e18a-6820-49e1-a38b-ef1205f5e74e"), new Guid("db5d1495-33a6-4820-bfc8-508c0a5b7e4c"), new Guid("e98ac0bb-4fb9-4d82-a0aa-7ebe92fea288") },
                    { new Guid("8cabff50-57d7-4fe5-80a8-d92fcf74bc7d"), new Guid("cdc742db-3e6f-4df0-8d6a-0fa30ec2edd8"), new Guid("d4504d54-6313-4c90-86bd-36ace24b2b41") },
                    { new Guid("8e04dbab-48f4-4415-9289-785d7a37d75a"), new Guid("d7cf3535-8be9-46b7-be94-9c76fe148ffa"), new Guid("5519d399-7df8-4326-9eb7-72572ac3edad") },
                    { new Guid("8e9dfde7-ad87-4875-acde-a3594a9b4f26"), new Guid("66c8f9c9-ac72-4a35-bde9-49eb54e698db"), new Guid("0d5404b1-2a1a-479a-a0df-32f1198c1254") },
                    { new Guid("8f799ac1-6167-46ea-bb3b-580e209d6716"), new Guid("a1e99d63-2bea-45c7-b958-0ddc23317386"), new Guid("c23dfa22-567a-448f-8277-d9cc03c16845") },
                    { new Guid("9088d274-9e70-449a-8038-6fa3a5a9e6d0"), new Guid("4ae01edd-d5b3-4a6c-8657-0842a7173333"), new Guid("f5535247-bac5-485f-9a46-4dbc9c359a4c") },
                    { new Guid("914c41b5-29ce-48d9-9466-8ea5e84f686d"), new Guid("d5c0e4e6-3b9e-4a4a-89f6-edf889d71305"), new Guid("c5fb3cf3-2b62-4fa3-9a7d-85bfb944a6c5") },
                    { new Guid("91b50859-f549-4b5d-b33a-4c9c5a1e686d"), new Guid("5f514b03-4905-4291-8281-0007fa287506"), new Guid("044dd1b6-9db4-4006-b891-3bb3d9069785") },
                    { new Guid("91bbb2ff-04d6-4689-8b4c-7331cddaa191"), new Guid("ebec2f0f-2f0a-4f6b-b160-2b8c10608177"), new Guid("290af343-d294-4fd3-869e-919a86dceeb4") },
                    { new Guid("936e83bb-c45f-49d6-b4b7-761d47710287"), new Guid("2e592dcc-f9d1-4bc7-8259-be0ed53562a6"), new Guid("9d93cbc8-265c-40f3-a735-08b4045c8bfa") },
                    { new Guid("93e248d0-8f52-406d-9441-51798a951bf6"), new Guid("61315754-2ef8-40e8-b029-15b7da15b112"), new Guid("77e2de50-83bf-42a2-a482-f78b5b52ca5b") },
                    { new Guid("944c500a-30a3-4f28-a37f-4d0e1cd3bcfc"), new Guid("ac4f1ffa-06b8-47b6-aa7d-1e29f4804d91"), new Guid("60f86a4f-2730-4a7a-87a9-4e17e93f954f") },
                    { new Guid("94b5e816-5f0e-4526-b15c-02449aa1e506"), new Guid("5626d64e-f20e-4fba-b9c4-4fd6c73b3012"), new Guid("821a828c-89e6-48c1-952a-b269712f4a80") },
                    { new Guid("95bdb04a-fbd4-4ccc-87ff-ae8bb9dee1f6"), new Guid("9c8dbc92-8862-4fd3-8ec0-ef65e59516d6"), new Guid("6c7768b8-f94d-4773-ac22-18ffbef818e7") },
                    { new Guid("96053097-a037-4b13-912f-98840f27b95a"), new Guid("fa41146d-97cb-446d-9d4c-9105abf75e1e"), new Guid("65481b48-77ae-40b0-a052-9ef06984c4be") },
                    { new Guid("9818ba79-f76d-41fa-bdd6-8f63f65a500a"), new Guid("6a265d01-8810-40e1-a8be-95a19432c845"), new Guid("ba185299-ec9d-4300-b4ad-b298563bdcb9") },
                    { new Guid("98473ea3-a184-4d95-b720-9d0f10a16be4"), new Guid("e8145c6a-829d-430a-9ef6-87d2825d0b58"), new Guid("36557fb5-0a48-4feb-8dfe-699317abcef8") }
                });

            migrationBuilder.InsertData(
                table: "OrdersAndProducts",
                columns: new[] { "Id", "OrderId", "ProductId" },
                values: new object[,]
                {
                    { new Guid("987cdd6b-7ba6-4c16-b63f-bea162760703"), new Guid("e9906e7d-2d49-49dc-90b4-8fce60fad44f"), new Guid("2ce9b873-1808-43a7-8e88-6a8c4bf265fe") },
                    { new Guid("9b023ce9-9209-429f-b440-90c43628bfd9"), new Guid("09561552-a669-4e36-b06b-b24efc32e20c"), new Guid("6823ef2c-6f0b-415e-9874-7823ceedccd0") },
                    { new Guid("9b14a329-e557-44a3-8f14-1e29d4b06ad9"), new Guid("161466e9-4ca1-48a3-a9c1-bcc0433d28db"), new Guid("1354620e-1550-4e35-bd47-75d5eea11fcf") },
                    { new Guid("9b4db4b1-7e66-459d-bb93-d527e8d7a75d"), new Guid("cc3760d8-7812-491a-9b00-ec2682e69366"), new Guid("47399163-8c9e-4e28-bb7b-932185d6a2e4") },
                    { new Guid("9c6a8ba2-9e53-4622-8d31-57c70a781270"), new Guid("0d230fc2-9bcc-4260-ba14-42fadd51b4a1"), new Guid("58ff520b-f23b-4d88-b5fe-d43e9a0e0eb4") },
                    { new Guid("9cd97e16-67b8-40aa-a50e-e6157537c642"), new Guid("0d1578ef-e30c-4027-a7c6-a64663c78109"), new Guid("064ae937-544b-4191-9d8f-89c216c36a44") },
                    { new Guid("9ce1c000-39da-45cc-b839-3aca93755006"), new Guid("d5656eec-6bf6-4583-a7c4-5803a98de97f"), new Guid("199cdecf-9838-4ed3-bdde-aee81212dd12") },
                    { new Guid("9d5069c8-12a3-4434-85ce-72fd3737b423"), new Guid("1c2f3ed4-d733-46f7-bda7-9aae1defc693"), new Guid("6c06fcdc-7d64-4294-8220-685c8c14105b") },
                    { new Guid("9e465a5e-535c-4431-aca0-39c3ffeab894"), new Guid("88f8318c-c6a3-410e-8201-9f373be10bd8"), new Guid("cbef3c56-4052-416f-99bf-9ce1ed23eeb4") },
                    { new Guid("9f4e027d-bed8-4455-91fd-237fe1285d33"), new Guid("5c3bc75d-3342-4f19-b9d1-3253fbd1cec3"), new Guid("a6e40f92-c7eb-414f-bf2b-b6f946b108fd") },
                    { new Guid("9fe005b9-a88f-4b8a-8247-305749affdde"), new Guid("a955baaa-3a1d-42bf-bdee-70d571f40899"), new Guid("fea80d5d-0435-4bcb-8581-f2cef0ba0bbb") },
                    { new Guid("a17199b6-a8b2-47f0-8d10-8cc35c0f8059"), new Guid("b947498f-afea-4f6e-805e-dc7c19476375"), new Guid("2872cb6a-f6d0-451d-aaa0-ea5f071a5c84") },
                    { new Guid("a1765633-5853-477b-81b4-028ec7cbc4cf"), new Guid("4bab686f-b843-4c1f-8855-8f79e191b0ad"), new Guid("e499d2a3-662e-47c9-abef-81d8ab1e68e9") },
                    { new Guid("a1af4c08-00f3-4ee3-b8a6-d827bc302e33"), new Guid("1ecaf207-574f-4d62-9698-b9604af71d63"), new Guid("0020781f-b53e-4d1b-9727-9e16607c6438") },
                    { new Guid("a1b3522d-bfc9-46b9-8200-7c0361d79b87"), new Guid("7a13336e-1de9-4209-a2d7-6f2df9e7d595"), new Guid("a1c642be-46ea-493f-8c5b-f94aa7cd3abc") },
                    { new Guid("a32610cb-fbc6-4977-b19f-27d89a91c0ce"), new Guid("b951839d-1718-449a-8f4e-d3066a19bc35"), new Guid("ed37f1e7-6ad3-43a7-b0a5-4c07332da528") },
                    { new Guid("a3e65b61-25c4-4aa9-94fb-90ade04d7b4c"), new Guid("b24415aa-ef20-472c-bf91-1beb553b8d5c"), new Guid("70a74d1b-215a-4979-861c-452af293773a") },
                    { new Guid("a3fb19d6-125c-4753-a7b7-e524be403085"), new Guid("b6683482-ccf9-4ac6-99b5-be429ff17105"), new Guid("1ac10726-692c-4fd9-b788-69e0b6e11314") },
                    { new Guid("a41f76d6-cc8c-4b13-ab62-8bcbcf537b21"), new Guid("a42ed1e5-a476-4c02-b73b-086668891851"), new Guid("9846e117-f6ec-488f-831d-080be659a1ee") },
                    { new Guid("a4b9912b-9b95-4c2d-b08f-c08ac49826f0"), new Guid("699bea92-fdf6-4f74-ad82-7aad77ca7a8f"), new Guid("a74aa544-9c93-4692-8019-4a596f2ee891") },
                    { new Guid("a569a598-1c47-4b97-aab1-d4feee38d112"), new Guid("c8c05152-9dab-49ee-8892-a1f9e1ba95ad"), new Guid("fb6d61fb-893a-491c-94bd-9166ec315350") },
                    { new Guid("a57c649b-60e1-4091-9bc1-6022ef7f57dd"), new Guid("efbf6bc9-d3c0-4781-b6c6-44db460c7062"), new Guid("20497d4d-c2f0-44d1-8468-b49d81ff0246") },
                    { new Guid("a69ba202-eb5e-403f-9dc1-6fbc0e13c082"), new Guid("924e3956-1604-4620-af21-09e9598d4d69"), new Guid("29e29242-b491-4caa-a812-ea9017c37f39") },
                    { new Guid("a737ee06-fcf0-49ed-be9c-746b5eeadc1e"), new Guid("3dfd9afc-edaa-4976-ad34-c4ea46248b9a"), new Guid("2872cb6a-f6d0-451d-aaa0-ea5f071a5c84") },
                    { new Guid("a7acfdde-a5dd-4a55-9740-d0123f4e27c7"), new Guid("ef2ad63f-b840-4874-af38-d65e2e826dc9"), new Guid("386d159f-0f4b-4a40-bd0b-539477a76efd") },
                    { new Guid("a8262898-b69a-4233-8172-fc2cd1444aaf"), new Guid("d025213b-a4b4-460c-b220-c4b56fb69892"), new Guid("6e0b75a2-ddd7-4b31-a8b0-1237eeaf8902") },
                    { new Guid("a83937a7-cf9e-48e4-ae99-017e45f80da4"), new Guid("596f670a-752f-4bf8-ac93-224a15012fbb"), new Guid("47c7b904-b21b-4586-8008-911695e389da") },
                    { new Guid("a8b5d0f2-3b00-44e5-be36-41010072bf0b"), new Guid("60a73766-96ef-44cb-8d3c-170fd976359a"), new Guid("874e26c5-3f38-4a03-a1ea-10e62e420f98") },
                    { new Guid("a9411108-eb62-493f-bd76-5a4b2cbc6ac1"), new Guid("f1988402-7be2-4d2f-afc8-4e5dbcd568a4"), new Guid("350af6de-dbb9-44fd-b225-a7a78ac44c8b") },
                    { new Guid("a9575d5b-c402-4e21-aade-3e9bfcd8a4ee"), new Guid("cd8cb360-864b-4bbc-b9fd-741555e5e886"), new Guid("bee83221-7987-4de6-82c3-61d0f47f6f0d") },
                    { new Guid("a9d36a7c-c0f3-4492-bf73-bf72c6f79f38"), new Guid("699bea92-fdf6-4f74-ad82-7aad77ca7a8f"), new Guid("323b2542-8b32-4120-86b3-2a2905837e8d") },
                    { new Guid("a9f4b4b7-7049-406c-9103-843bfb6086fc"), new Guid("46ad4204-1ac4-46ad-8a85-a6186fc33341"), new Guid("d08a5fe7-4cad-4ae1-9195-fb8f7d88f59a") },
                    { new Guid("aa69b230-4964-461e-b1a8-f24efdbbd709"), new Guid("f628248c-4c5e-4149-93cb-26173a744aab"), new Guid("eebd387d-1b9f-469d-8401-0363317d81a2") },
                    { new Guid("aaf52b23-a91a-4137-a543-2b92dfb9e599"), new Guid("a23af231-a0af-4904-840b-ef684c84d5a6"), new Guid("1a5a4d34-9f22-4032-844f-466b5bd45faa") },
                    { new Guid("abc4f05c-4407-40e1-9c97-d0b8cfcac031"), new Guid("d1625a5e-b0ca-4660-8d0b-4be9dc393790"), new Guid("77e2de50-83bf-42a2-a482-f78b5b52ca5b") },
                    { new Guid("ada7df79-d424-4002-8322-a535f70f46ee"), new Guid("7f843a65-f36d-4982-be33-f8bdfe052b07"), new Guid("03af47f9-3fe2-4a9d-8e10-d1a6af387666") },
                    { new Guid("adbbba89-6012-4478-a3c0-1505e386e1f9"), new Guid("d6c235ba-1c9d-43cf-a718-287d2184b83e"), new Guid("1a578b45-1f53-4331-80c9-cc8230fae85f") },
                    { new Guid("aecbc86b-6d63-401a-9674-7915521164a5"), new Guid("e91f09d3-a378-4db9-8c71-f1e02486814d"), new Guid("afdaa389-cb13-42c2-9aad-6bf5f85c7b4c") },
                    { new Guid("aef6e569-2cb8-4c52-a037-2ae75600d324"), new Guid("a40fe25c-289e-4439-9d95-ea36ec9ee1e6"), new Guid("b51b48f7-7307-479c-85c5-5fc12b9635b6") },
                    { new Guid("af591840-30e7-47e4-822a-c3b79f0c41a4"), new Guid("e9f96bc2-1cf5-4eb7-b0b8-1d478ffcf572"), new Guid("872849c1-d0a4-41d0-806e-6fa8b702e565") },
                    { new Guid("afc26302-d5a5-47de-a969-e041d33bf02a"), new Guid("ff8e74cb-0313-490c-8ace-8b3c2c0dddf7"), new Guid("56f06277-f6b5-4116-b36a-efa36fdda76b") },
                    { new Guid("b0bdfbad-93ba-40ce-954a-7aad52df9cbe"), new Guid("a1e99d63-2bea-45c7-b958-0ddc23317386"), new Guid("e1dadb60-6621-4ac0-9ce5-8f6b01376cba") }
                });

            migrationBuilder.InsertData(
                table: "OrdersAndProducts",
                columns: new[] { "Id", "OrderId", "ProductId" },
                values: new object[,]
                {
                    { new Guid("b14f3476-37b4-4796-966a-5592359a902a"), new Guid("c9e9c06c-3059-4246-97f6-60483e7c43cc"), new Guid("a2fca00f-cc27-4900-b711-acdd50c0b830") },
                    { new Guid("b1a19b61-07dd-4667-891f-84e93ac95b17"), new Guid("425cd297-01c7-4d34-bb83-3a266c4b1cc2"), new Guid("537ba2e2-4e8c-4c18-b690-6458f1fd2888") },
                    { new Guid("b1d62abe-89a9-44e1-8cc2-18f9445948e9"), new Guid("c68d2ab8-e1c4-4d33-879f-8b0b09a95f71"), new Guid("43e5c99b-b2e6-49ef-a1d5-96f3d6bceeeb") },
                    { new Guid("b203c082-5f5e-488a-96c5-8ccb7e8f54dd"), new Guid("e5868b49-6ddb-405f-a808-483c2b9243a1"), new Guid("0aef3ba8-bc7d-4063-a092-f877dbce4206") },
                    { new Guid("b3667f09-cf79-4f49-b044-44c27dee9124"), new Guid("ace9b8e9-b48a-4c43-a892-e84f906081a7"), new Guid("34857150-7ce3-4dfe-bda6-84da47cdaf6e") },
                    { new Guid("b3a64542-2945-4f94-91e9-f8a4359b0ccd"), new Guid("4ae01edd-d5b3-4a6c-8657-0842a7173333"), new Guid("8e1a20df-3e16-41bf-8f87-2c65ed6938bf") },
                    { new Guid("b3bc2aab-a2e0-4695-8d98-3a6eaaae4d20"), new Guid("cd8cb360-864b-4bbc-b9fd-741555e5e886"), new Guid("7e599d1a-7de6-4ace-80da-7c788f6c1399") },
                    { new Guid("b45c3470-4312-40c4-bf14-74c3c396004d"), new Guid("7bab36fd-2a86-409c-971e-9187439b462c"), new Guid("e14551e6-65c3-4bc0-9f1b-fb95cb51944b") },
                    { new Guid("b47786ad-83de-498d-95ad-f2955054ea82"), new Guid("37502bf4-dd7b-4aeb-bcb9-136f166d54bb"), new Guid("3eaf1aa4-138a-4aba-80f1-9917772bb29c") },
                    { new Guid("b54278c9-2e53-494c-a28d-84241d55eaee"), new Guid("ff9b4afe-cbfc-46bc-9cf0-b6d013e11641"), new Guid("36e4b0ed-3830-49b3-9441-f59f1f0aeccd") },
                    { new Guid("b597122e-cc94-43f5-bf78-7dd7afc9657f"), new Guid("8a429ee5-c3cb-42b8-a936-7ac1dadf652e"), new Guid("031e072f-5a72-4752-ac43-333b9a222060") },
                    { new Guid("b67c05bc-c2c6-4789-84ff-380d309490ae"), new Guid("6edcd7e3-e8b8-4e02-8a56-1c8b567faf30"), new Guid("f5535247-bac5-485f-9a46-4dbc9c359a4c") },
                    { new Guid("b7989cf2-b866-466f-b7fc-8c69bb7f4a18"), new Guid("6bfa5f85-6a03-4bab-b5aa-d9075c7d380a"), new Guid("13315d68-137d-4d1d-b894-9d21ffc4601a") },
                    { new Guid("b80cd614-84c2-4c0a-898e-f0bb24e2a6f4"), new Guid("87d4176a-3784-4ada-a12b-a4a0c179003c"), new Guid("6d25d25a-5394-4c6c-9d27-3812bab252da") },
                    { new Guid("b86cca74-2f49-4c6f-b2d9-3885173b7bc4"), new Guid("f87a4771-2228-40fe-930c-67b3f5aa1780"), new Guid("11ef0c55-abaf-4218-8ba8-653ab3355e82") },
                    { new Guid("b8efb43e-cb50-43d2-a960-d54485731672"), new Guid("20d10716-eb27-4057-afd3-fdddeebc110b"), new Guid("d3ec242c-3f43-4742-93c2-1cedb80f4328") },
                    { new Guid("b9b18a0f-b990-4080-9c3c-f97ae78cea2e"), new Guid("70022831-94be-4a7d-92f3-d658aaa0acc4"), new Guid("8ff26872-66a6-48de-90b8-3653f29e6e4e") },
                    { new Guid("b9daba7b-42ff-4b22-80dd-fdd133faba89"), new Guid("c4af0f09-df5a-46c3-a912-81be0cb82e22"), new Guid("497feee4-fd48-46ef-ae2c-311e08aac145") },
                    { new Guid("b9e4482c-9312-44b8-8fab-8ea34fbda9ac"), new Guid("d5a4f5b4-0913-487d-a09c-eeeeb40ef3f9"), new Guid("394a1f56-f85b-4b3c-b7f3-e5df94d9db1b") },
                    { new Guid("ba4bdccb-130e-4fb4-8bf8-0fbfde238874"), new Guid("f1988402-7be2-4d2f-afc8-4e5dbcd568a4"), new Guid("0ec34d14-c4c6-484d-aa70-d516d65c1565") },
                    { new Guid("bac91cd3-c33c-43ee-858c-1a6739b4ba2d"), new Guid("50bd7eec-c9d8-40ce-a8e4-ae4dd2376113"), new Guid("2f4cad24-bad5-413b-8115-935c345592a9") },
                    { new Guid("baf5f5b6-271b-40ad-937e-44d14f18f38d"), new Guid("596f670a-752f-4bf8-ac93-224a15012fbb"), new Guid("eba69462-4537-4f23-bbf9-13b3a9edf6c9") },
                    { new Guid("bb337c00-3bf8-4bb9-8edd-e31038af62cf"), new Guid("28f2980e-608c-4c4b-bff1-14934b7c4896"), new Guid("1b139120-8834-4cf0-b689-f490a62965e9") },
                    { new Guid("bb50de58-03cf-4b49-99c7-f3bdebbc8c63"), new Guid("643f767e-a5a2-44a7-8502-dc8728556131"), new Guid("cbfbc2d7-34e0-4fd1-ba90-5b9ee816eb5f") },
                    { new Guid("bb748e89-e5fa-4834-af85-0876f9861a99"), new Guid("e48e016a-ea57-4bb4-a792-2ad61083753d"), new Guid("34857150-7ce3-4dfe-bda6-84da47cdaf6e") },
                    { new Guid("bb939cce-ac03-48a4-91fb-d2f7de8fdfda"), new Guid("7b8a33cb-0472-48b4-ad42-69201d8f2c18"), new Guid("424f0d47-2a37-41c3-bdec-d1b0e6b30386") },
                    { new Guid("bbcf7dd7-6127-4933-9987-d61145292d3d"), new Guid("73aabdbc-7be9-4b6a-a164-81385af16fe9"), new Guid("e1c88c1e-5998-4f10-9750-9ff52d7acff4") },
                    { new Guid("bc7beec2-b0bc-42c5-8e28-18409ebc1563"), new Guid("da23ac80-e6f8-4bdf-8e07-e271a78e5468"), new Guid("2f220fa7-e836-48ac-9283-6df71878e0f1") },
                    { new Guid("bc8e01ed-31b3-4d23-a8ae-31f9330f25bc"), new Guid("d8de47ed-ff98-4997-b44b-ea515ac67bd0"), new Guid("72b1c161-1c5c-41ee-a83a-2d96c70cfc06") },
                    { new Guid("bcab66d0-a907-40d5-94c7-1ca5072eb1e8"), new Guid("852b180a-6a85-49f9-9a4d-d82f3343bf1b"), new Guid("e4cf3c91-d77c-4567-831d-ef2863dc693d") },
                    { new Guid("bd06dfdf-482b-4b1e-9263-dd501ed1b155"), new Guid("99429c32-4613-4490-a153-288232efbdc1"), new Guid("0ea547fa-3f23-4cda-ab9d-cf26a7c8a771") },
                    { new Guid("be3a80ce-20bf-46a6-b9ab-ddedd6f4b1ed"), new Guid("80d2e4a5-545c-4ab1-a458-569d45ccc022"), new Guid("199cdecf-9838-4ed3-bdde-aee81212dd12") },
                    { new Guid("bed6f6be-d8c0-4bc3-bbb1-770fa24eb969"), new Guid("745d91b9-a5b8-44c4-b780-702cd5785366"), new Guid("e1c88c1e-5998-4f10-9750-9ff52d7acff4") },
                    { new Guid("bede4732-b248-4667-8060-6608d1cc53e1"), new Guid("f62dcef6-cd8f-4d1b-a78d-2509f94c4534"), new Guid("509904cf-faf6-4565-87c6-20ffdb58fe52") },
                    { new Guid("bf43cfdd-4833-43f6-b1c6-649934b95ad8"), new Guid("90569cfc-0220-421d-add9-31d469ec7b4c"), new Guid("f656320d-154d-4a6a-8dcc-4bf57214bf37") },
                    { new Guid("c0ad5283-80d0-4edf-bbf9-53cc11b71fd4"), new Guid("a0dec400-b58a-4516-8c69-35b1dad41ccd"), new Guid("0306ea4e-b54f-45d0-b880-d426fc0c8108") },
                    { new Guid("c0d51e7b-073e-40a9-8da9-00fbd1566779"), new Guid("88f8318c-c6a3-410e-8201-9f373be10bd8"), new Guid("bc33db74-2cbd-40fc-a06a-7f02297e3fd2") },
                    { new Guid("c12f51ee-f64b-4a48-9ac4-b9436448ebe9"), new Guid("e21e24d8-351d-4152-8fab-ec3b6dab6ebe"), new Guid("2380914e-4692-4828-a8a1-aa0fe5e74b91") },
                    { new Guid("c24b6165-353e-4e2c-b692-296a8cf48a45"), new Guid("1bcc31e4-616f-4042-913a-24e906cd6e68"), new Guid("f33d0d3d-4808-4eec-8701-46a0673cdd04") },
                    { new Guid("c29ab1fe-9194-4382-894b-075124af42f5"), new Guid("c95cfc86-a73b-41fb-9b0e-c28d6af1d92c"), new Guid("70a74d1b-215a-4979-861c-452af293773a") },
                    { new Guid("c3f4bdae-6327-4e51-8b60-5de8a471342f"), new Guid("0d73fc46-1f39-4c91-83b1-794aeaa7a6fb"), new Guid("3eaf1aa4-138a-4aba-80f1-9917772bb29c") },
                    { new Guid("c4026f7b-7a11-4a37-a6a4-eb70a4595dca"), new Guid("6d5e0934-577f-4fe2-bae2-91bfe93d7d1f"), new Guid("2d0f8237-db3f-4cb6-b1c8-11c46ffaed62") }
                });

            migrationBuilder.InsertData(
                table: "OrdersAndProducts",
                columns: new[] { "Id", "OrderId", "ProductId" },
                values: new object[,]
                {
                    { new Guid("c47ffc28-dae3-4a31-8ae0-c35dbc607a2a"), new Guid("f449f5ce-2f90-42c4-9ec0-31d80f676d72"), new Guid("3a6b81ac-a926-4dd4-90bf-82a81104c488") },
                    { new Guid("c4b7c320-dc2c-4b21-a706-16b582f98f4f"), new Guid("9256ea8b-8778-4b03-836c-ff6884728a66"), new Guid("199cdecf-9838-4ed3-bdde-aee81212dd12") },
                    { new Guid("c503397b-438d-410a-a553-007f25162f99"), new Guid("1b097a10-6f1d-4f5f-9551-112033dd5206"), new Guid("6e4319b4-135c-422a-8369-a86c38b501b4") },
                    { new Guid("c5330db6-2ad7-4833-8076-ee10a9dd77f6"), new Guid("b54d14f8-8e96-4356-a1bd-92a5b17aa119"), new Guid("044dd1b6-9db4-4006-b891-3bb3d9069785") },
                    { new Guid("c5b7c9f1-0abd-411c-ac1d-fb27c4f3716d"), new Guid("2fe907e2-4282-45e0-9446-c775a81533f5"), new Guid("b4cd5f5a-a7cf-46c2-9a6d-d552df3016cc") },
                    { new Guid("c5d770b4-e6b4-464f-ba89-8a50ab54a58c"), new Guid("67d91738-294e-4a2c-b686-088e3231c4bd"), new Guid("0d5bcc03-6f3a-4640-8c0e-4c6f5812f554") },
                    { new Guid("c636d67e-c85d-4410-b2f7-d90aea7d6519"), new Guid("548068e5-d9ba-4e10-b19c-ae566c16d563"), new Guid("e1452ecb-4988-4813-8240-8e30f7a78b1e") },
                    { new Guid("c6be4095-d3bd-4f0c-b058-3714249a4e21"), new Guid("548068e5-d9ba-4e10-b19c-ae566c16d563"), new Guid("5f79c598-ac0a-4fc5-8bdf-cf9a23022ea9") },
                    { new Guid("c7850fe1-7a57-4ace-830d-11f2ab7c94ef"), new Guid("b2d90cd4-ad3d-40e7-adfb-443ce406c807"), new Guid("009fb850-0699-4264-921f-b22d19f20cb4") },
                    { new Guid("c7dc461d-4dab-4c96-bdce-d938fa5b1bdb"), new Guid("20d10716-eb27-4057-afd3-fdddeebc110b"), new Guid("89bc1793-cfd1-4acd-aab5-4ebcc6d11163") },
                    { new Guid("c8e91da1-4098-45b8-aa57-14cd9db6c3c1"), new Guid("09d01aec-e84f-4a29-a2e0-48c22513edef"), new Guid("86928647-7a09-4acd-a9ff-f10f7d836036") },
                    { new Guid("c9ae5af9-8f93-4e98-b207-d36cc13f94c9"), new Guid("7d093f45-5998-4d26-8f72-ca6cdfc473fd"), new Guid("70b0378f-48d0-4e1c-bee7-674f11b8f878") },
                    { new Guid("ca246303-b514-4632-90c5-b2dd37e678dd"), new Guid("84dc49c4-2088-461d-9714-46bca62bd32d"), new Guid("4d8bef4a-ecee-41b0-9607-09561e92a4da") },
                    { new Guid("ca62a994-7536-4fbe-8d4b-8f2f99bb0f73"), new Guid("c7b6d26f-e3a0-49a2-8619-124bd2d286d4"), new Guid("50b20d81-82c7-4234-b388-b08e266b651d") },
                    { new Guid("ca68049c-9e1c-43dd-9276-ef54cfde3220"), new Guid("9ae63ca1-441c-466f-a060-bc23c447b029"), new Guid("35e7d68f-d4d8-42dd-b746-2f44b50cae71") },
                    { new Guid("cad0ea16-327b-498c-8a65-bda626e89d76"), new Guid("da23ac80-e6f8-4bdf-8e07-e271a78e5468"), new Guid("5617304c-f5fc-4e4a-9b5e-af1bffda1a91") },
                    { new Guid("cb6d23c8-8524-40f4-84c3-714ecf6b72db"), new Guid("abb20114-7d5c-4ddf-9ac4-70cbc8e9636c"), new Guid("9f61af47-11cd-4c84-ae19-7853ba7b07fb") },
                    { new Guid("cbf5bd7d-3aa3-4c83-9483-777b1f7be614"), new Guid("118b377b-d09d-4a59-a8f2-4e149d3a7cd6"), new Guid("6a0d814f-b28e-45be-b80b-233f0d199c5f") },
                    { new Guid("cca4c17b-1868-403d-93cc-346b885d6f65"), new Guid("547d3ac7-cc57-4085-8726-3818e89a00d2"), new Guid("61cc6b34-3205-4c29-870a-20a073ef978e") },
                    { new Guid("cd67eda8-66af-4730-9d66-b9f809666373"), new Guid("37502bf4-dd7b-4aeb-bcb9-136f166d54bb"), new Guid("54f01df3-7e27-41d9-8499-a609c37e9b05") },
                    { new Guid("cd920791-36ca-4d69-8f5c-a908232e2d80"), new Guid("75c1aba8-ecd8-4e98-b834-867580ae35a6"), new Guid("c35b14ba-1dbf-4d8f-8d3d-b6f3e2b1a8b9") },
                    { new Guid("cd94412b-d8e7-45b7-b752-7a052cc5b869"), new Guid("f71a227d-4775-491e-8bfc-f031a8842c2e"), new Guid("f378869b-158d-4073-b78e-cc9b40b174db") },
                    { new Guid("cdb0c4d5-bfd9-448e-8d9d-97894fd6999c"), new Guid("6abbfcaa-13b7-4b69-a02a-573be067ddcb"), new Guid("befd94ac-c3c7-4c29-aa06-dd2ec87ea669") },
                    { new Guid("ce645bcc-5932-439e-9862-ae767ae0837b"), new Guid("d74cce4c-e8b6-466b-aaa6-c275de924a87"), new Guid("81a8ef5f-d21d-49ec-9ffc-8a5a60955103") },
                    { new Guid("cec53ca0-5914-4062-8631-b5bc764b45d6"), new Guid("3cddb538-a725-4d1b-be2c-1110fa2111d7"), new Guid("11594fd8-0a7a-4410-aff8-54220eaf4c5d") },
                    { new Guid("cecdac39-465d-4443-be33-dfe52e4d7ca8"), new Guid("b8e19fa4-b8cf-46bc-a64c-13af80aac89c"), new Guid("8e61f76f-d269-4859-a989-122b59a5aaf7") },
                    { new Guid("cfaaf491-5167-42da-99d7-12946be544e9"), new Guid("31755173-b0a8-4779-a178-213033d58cef"), new Guid("800645fe-635d-4bb5-894b-0f790c948366") },
                    { new Guid("d0c85a16-63cd-4953-830a-be4dc35ed605"), new Guid("0be28c4d-53d2-4985-84ec-9ad0630f7507"), new Guid("90354f46-a58c-4dbf-8cd5-f512df8e16c0") },
                    { new Guid("d167bc63-b72e-4dd9-9a2a-0f84c375d2e4"), new Guid("923da64f-5b9f-4b14-9729-621186788125"), new Guid("fe4224a9-d47f-49d3-b63e-f7a9e22fd144") },
                    { new Guid("d38f1bfa-8c3e-431b-a5e2-dd1f24329b44"), new Guid("0853800f-5f9c-433f-839a-9f6ea6ae6864"), new Guid("ef910380-3472-4298-b0fa-ca8fa813892e") },
                    { new Guid("d3c227d1-ba87-45c1-91d3-6b5891658cb7"), new Guid("d5656eec-6bf6-4583-a7c4-5803a98de97f"), new Guid("2c1a18f7-fcd8-41ba-bb97-11d61f94aa6a") },
                    { new Guid("d471a59e-aa28-434e-8094-8ac5486acebc"), new Guid("17200911-e538-4545-9b62-dd79bacfb277"), new Guid("293ab4a1-7e87-427d-a9ff-77e0652a8db8") },
                    { new Guid("d48d2aa3-fc01-4f1a-8963-8b3b81950f79"), new Guid("e5868b49-6ddb-405f-a808-483c2b9243a1"), new Guid("2678d658-45f1-4da7-a551-4f81bc3378d1") },
                    { new Guid("d4bfdd39-9699-45cc-896e-e0ca4fbf75db"), new Guid("21c2e9b3-898a-4ac2-93aa-db736420d18c"), new Guid("f262f894-47e0-4965-bc16-378b5fb166e3") },
                    { new Guid("d4f7b9f1-c4d0-464d-a12f-c01a2abbf7fa"), new Guid("c1c58d92-65ea-4425-aa98-3141e4ba6f67"), new Guid("5c2a8a58-dd21-4324-996c-4b3e9db62513") },
                    { new Guid("d5027fab-ddf8-4b47-b475-32597628f51c"), new Guid("3dfd9afc-edaa-4976-ad34-c4ea46248b9a"), new Guid("921d61c3-4a00-4e36-a3c3-c6da7a25b1dd") },
                    { new Guid("d5d54dfa-9f7e-46ce-8903-e8f41d9061f3"), new Guid("0663a9e4-886d-4b3a-9fa1-57fcb91dc69c"), new Guid("1348ffc3-4d66-4563-a1b2-bb8a1831cee0") },
                    { new Guid("d5e91ef6-b451-4626-b40c-1f85e585a262"), new Guid("ea32e25f-0e5b-4e72-9d15-7a8b8f97a48e"), new Guid("1354620e-1550-4e35-bd47-75d5eea11fcf") },
                    { new Guid("d6826ee3-cb8a-43b8-a86e-27c0be7ccad8"), new Guid("c64d27e3-e62c-4e2a-8001-79a6447eb134"), new Guid("c104ba02-fd26-4c18-b74d-d97c9a0f9008") },
                    { new Guid("d75e9b2c-ad47-440c-be9f-5aacac967d97"), new Guid("e5868b49-6ddb-405f-a808-483c2b9243a1"), new Guid("123de458-520c-44bc-9261-5a6d031e354c") },
                    { new Guid("d824ef47-0f9e-41e4-bd9f-21c39d380e2b"), new Guid("11b8e861-8ed9-467f-8f4f-c1efe7064030"), new Guid("4131d4f8-a616-4f1f-a656-a405d74eee96") },
                    { new Guid("d8425c7f-2c1b-4a40-b8d4-6215492b9892"), new Guid("7e74cde7-3e0a-432a-b0f5-0a18f5ed9cd2"), new Guid("c8c181e2-08b4-4230-8626-bd98ba652ac1") }
                });

            migrationBuilder.InsertData(
                table: "OrdersAndProducts",
                columns: new[] { "Id", "OrderId", "ProductId" },
                values: new object[,]
                {
                    { new Guid("d8842b9c-5751-431a-b472-62334196b2d2"), new Guid("9925f4b9-5431-4704-a6b7-bf4283c8a348"), new Guid("c2020219-e750-4583-8fe9-6c2710e0e4b7") },
                    { new Guid("d8d6a83e-9a0a-49b2-81cb-a037dda594e1"), new Guid("dfed85ab-5fa6-4888-a994-599e55208d2e"), new Guid("bcdfc289-44c2-43a7-8507-8a333ab5032d") },
                    { new Guid("d9467c63-0bfe-48ce-adf9-626434c44695"), new Guid("5ed64f54-9bcc-4673-8d69-eabdb07003d2"), new Guid("839b4492-10b1-4e6a-9915-1850cf79eec4") },
                    { new Guid("d96116e9-7689-4ac2-bf27-c1de9e507036"), new Guid("7e510a3a-9ac9-4b82-a868-1fcbe3704a82"), new Guid("a2fca00f-cc27-4900-b711-acdd50c0b830") },
                    { new Guid("d99fe782-6e34-4d4f-9ffe-ea95ff61fdc6"), new Guid("3d550ea3-177e-445d-9997-6feb7bae5329"), new Guid("9d58a037-809f-407d-8f22-cbe7dad70866") },
                    { new Guid("d9bbdf0c-f5f2-482f-9ead-3ecab99e681b"), new Guid("16217467-f89c-4117-95ce-ee565e0687c8"), new Guid("27177182-4e32-4bee-b51a-b3c42bc23111") },
                    { new Guid("da41cd05-d2b2-4e37-b255-eddbf16b85eb"), new Guid("97b78ce3-151c-43c0-a61a-32453c606d28"), new Guid("36ecc915-58bd-4a32-b353-9aa35515a242") },
                    { new Guid("daa98ed5-5d32-4eac-9d47-e70649ebf43b"), new Guid("922da749-67d4-4af6-a59d-3eae43f26854"), new Guid("3f1d3ef3-bc5f-4fc3-b0a0-8f918e07d6aa") },
                    { new Guid("db5928fe-24d9-4b4b-8fda-5277233e76a1"), new Guid("27b04950-2bf5-4a82-933b-bc8f3560f77f"), new Guid("6a0d814f-b28e-45be-b80b-233f0d199c5f") },
                    { new Guid("dbe41c6a-4378-4f52-9f0e-87585b8fd873"), new Guid("abb311f9-145a-4f02-9eab-5a45dd467410"), new Guid("927a0c9b-4abb-4805-8353-b876afd4c9ec") },
                    { new Guid("dc476af7-ae8d-45f9-bab4-13a57cbc73a0"), new Guid("55ac52a6-fa08-419d-bd28-3de97af78f31"), new Guid("22de0a8c-bae5-4810-a64a-b20987bff866") },
                    { new Guid("dc4d98d7-4e85-47a6-8100-790516369d54"), new Guid("9eca63c4-8b05-422f-832c-5541ef3abbff"), new Guid("9709c4d7-b199-47f6-897e-b0307cc53973") },
                    { new Guid("dc8951a2-c58b-4b9e-b652-558ebf431d76"), new Guid("97b78ce3-151c-43c0-a61a-32453c606d28"), new Guid("4ea72b89-0913-42f3-a204-33767394a377") },
                    { new Guid("dcbabce2-46ec-448d-9049-3bf0bb00522e"), new Guid("20d10716-eb27-4057-afd3-fdddeebc110b"), new Guid("059a7df4-76b5-4f1f-a9af-978956d46f75") },
                    { new Guid("ddb81d21-c486-463d-9531-50eb88f85377"), new Guid("745d91b9-a5b8-44c4-b780-702cd5785366"), new Guid("52b71efb-d5de-4f96-aeaa-61e049fc0f7c") },
                    { new Guid("dde833c8-91e4-49e5-879e-75ac11e69cab"), new Guid("67944129-15e4-4349-b85a-0d08ee59130d"), new Guid("2b1aab66-0b70-458e-b47f-4c7dd0eabdba") },
                    { new Guid("de181600-e177-4d92-8b3b-b4878aba01a1"), new Guid("3e8d0aad-e517-42e5-8eed-279c4b6bc37c"), new Guid("c104ba02-fd26-4c18-b74d-d97c9a0f9008") },
                    { new Guid("de5cb890-4057-45f8-acb1-5bbf4084b8d4"), new Guid("e9f96bc2-1cf5-4eb7-b0b8-1d478ffcf572"), new Guid("e492fd43-8c8e-452a-997b-d0e1346f5e19") },
                    { new Guid("de93f95c-981b-4b23-b319-c426caca47c6"), new Guid("bd2f9ebe-e236-486f-9d1a-c9c321c60ce9"), new Guid("c40194e5-7aed-4b22-86df-31caf05a4f1e") },
                    { new Guid("decd0801-a583-4879-b026-a95a2b81780c"), new Guid("621371f3-9f2e-46d9-b0b6-2b95942722b8"), new Guid("e1452ecb-4988-4813-8240-8e30f7a78b1e") },
                    { new Guid("dee90178-0c94-473f-ac38-9fc8e6c5b394"), new Guid("0853800f-5f9c-433f-839a-9f6ea6ae6864"), new Guid("d08a5fe7-4cad-4ae1-9195-fb8f7d88f59a") },
                    { new Guid("dfeecd97-3614-44e1-9896-e098e5a3eb59"), new Guid("cce7033a-8afa-478f-9edb-aaaf50d9e07d"), new Guid("6e709700-9ee3-4df8-a627-190d06c0820e") },
                    { new Guid("e04301c4-913f-439f-97f8-33891161434e"), new Guid("150a58e7-a2c0-4ec2-8085-4a6ac97c8a42"), new Guid("4b508211-1697-4f53-a6de-f82c6b17045b") },
                    { new Guid("e06fce51-cc1a-4d10-a205-902b6c2499fa"), new Guid("fc3d27e6-e777-4e81-817e-3a5a8c30bf4d"), new Guid("6e709700-9ee3-4df8-a627-190d06c0820e") },
                    { new Guid("e129703d-6a10-440e-9fa5-d1e5e8ce741c"), new Guid("791274fb-be73-47cf-9780-8956ebe4c5ca"), new Guid("e98ac0bb-4fb9-4d82-a0aa-7ebe92fea288") },
                    { new Guid("e131f5ba-ecec-40d1-9f5f-286e94e223b8"), new Guid("ea32e25f-0e5b-4e72-9d15-7a8b8f97a48e"), new Guid("dacc8a3d-850f-4c2d-aca6-437b8ce03f16") },
                    { new Guid("e155ad69-cbd4-4fc3-8691-85c0d4b137c2"), new Guid("fddb2b2b-e12a-4ff8-85b7-a0def30c5d23"), new Guid("e1ae4d3a-758b-45bd-9c5a-e08cf6aeb6d4") },
                    { new Guid("e1d5ca7c-d72c-4454-a2ab-a48480e4933c"), new Guid("ab0397b5-3691-424e-850f-9bc1954de8c1"), new Guid("abc71b76-91ef-4e27-96be-09f30d0c20ba") },
                    { new Guid("e2163eb9-66eb-4efc-aae3-f142012436de"), new Guid("680ab800-d5da-4f26-ad86-eafee1d7616a"), new Guid("b51b48f7-7307-479c-85c5-5fc12b9635b6") },
                    { new Guid("e2698199-d2aa-4173-8edd-31935d7c687d"), new Guid("8390bef3-a7b8-43fc-ac61-acd5a55ab3b6"), new Guid("def3dbd6-8e09-4f35-b663-27eb188b08c1") },
                    { new Guid("e2734752-52a8-47b6-a189-d7d55aae5617"), new Guid("ffa94aa3-e381-4ba0-a286-fe757ad03608"), new Guid("675dd608-4e3c-423a-af50-c991de0d3852") },
                    { new Guid("e2ab3dd3-21b1-4d58-89e9-b77d0292476c"), new Guid("13548f42-636a-47cc-9820-749718f9caa3"), new Guid("69a09359-aff7-4407-808f-d3f4530af6fa") },
                    { new Guid("e2da8b2a-1f79-4c26-ac04-d2a4d25ccf18"), new Guid("ceaaaa40-85cb-40ab-a7d6-9b192cca71f5"), new Guid("42b1e480-e533-4564-a5e4-4255f9c3bf62") },
                    { new Guid("e30726a2-50c0-438d-9b68-d11b4512d939"), new Guid("a011c27e-2147-456e-89e4-39100d331111"), new Guid("fe4224a9-d47f-49d3-b63e-f7a9e22fd144") },
                    { new Guid("e315ad45-fcbb-4f8f-bb38-b02b83069260"), new Guid("c0cd2eac-ef6a-4cba-b7cc-32a5c025e573"), new Guid("18754842-5aaf-4d4a-8c8e-c31d1069af44") },
                    { new Guid("e376d3f4-6daf-4a73-894b-888b208b5b31"), new Guid("9a8fc26f-1b32-4ebf-92b1-c22a0ab209e5"), new Guid("f1ad78a1-9698-48c0-8b53-84147484e6a9") },
                    { new Guid("e3aa79de-d495-48f4-842b-9251c5db9283"), new Guid("266addb0-2be7-4a19-aafd-442713397afa"), new Guid("c0842b7b-a8d0-477e-9bd5-7414e9b94b7a") },
                    { new Guid("e4f6a8b3-d082-4617-ab2d-80e70b135a12"), new Guid("60a73766-96ef-44cb-8d3c-170fd976359a"), new Guid("64a2d486-eb0c-45eb-8544-ccd274e08700") },
                    { new Guid("e5a9f443-72f3-4e10-a495-016398e21436"), new Guid("a0dec400-b58a-4516-8c69-35b1dad41ccd"), new Guid("e660657d-a09b-42f7-b86b-36784fcaa2fa") },
                    { new Guid("e671f25d-4fb3-4ce8-991a-8f1a1d0c9af3"), new Guid("9852ea3f-d53e-4f9e-b9e2-f865454b2a46"), new Guid("917b6331-12c4-45c0-9928-cc494209e8e6") },
                    { new Guid("e77e5043-9db5-4bc0-b1f2-842ca9728733"), new Guid("90569cfc-0220-421d-add9-31d469ec7b4c"), new Guid("a0672440-467a-48ef-af8c-d2e8c5f57e55") },
                    { new Guid("e84093e5-3ef1-4677-b334-e2c2d41370a3"), new Guid("596f670a-752f-4bf8-ac93-224a15012fbb"), new Guid("e1452ecb-4988-4813-8240-8e30f7a78b1e") }
                });

            migrationBuilder.InsertData(
                table: "OrdersAndProducts",
                columns: new[] { "Id", "OrderId", "ProductId" },
                values: new object[,]
                {
                    { new Guid("e863c4bd-f54c-4d81-b1f4-1fd43bb527a7"), new Guid("7358ead3-2382-4554-a54f-ccb708392adb"), new Guid("60c94ee1-00e7-40b9-9600-5dd0cc64ec59") },
                    { new Guid("e8ddc25e-a92e-44b9-9873-c6e6ab9084f0"), new Guid("fae66f35-9b6b-4a0a-ae2a-c38e9786e671"), new Guid("53944f4c-6a30-4d31-9022-8670093cb391") },
                    { new Guid("e9dbdf60-384f-4963-8e41-9d3dec48ee49"), new Guid("08e28f96-d1f4-4d94-ac44-c00d8a17b093"), new Guid("c39e9753-a07d-4e1f-8a9f-d6a394826a26") },
                    { new Guid("ea470d4f-d996-4b96-8c4f-a94142631509"), new Guid("16217467-f89c-4117-95ce-ee565e0687c8"), new Guid("7e599d1a-7de6-4ace-80da-7c788f6c1399") },
                    { new Guid("eaf65423-3294-48ce-8e8f-2c6a47e72bc0"), new Guid("688049ad-5911-4dff-bd78-d74a6d3e371e"), new Guid("82df3add-8831-47ab-b38e-ef0ac8857ab3") },
                    { new Guid("eafbf38a-b9e9-4aeb-b6f9-0ae082f14683"), new Guid("eafbfe45-bd61-480e-b442-f50d3109a77d"), new Guid("675dd608-4e3c-423a-af50-c991de0d3852") },
                    { new Guid("eb8a387c-0c70-4140-a0ad-0158f63fd673"), new Guid("329c1dd9-bc8b-4d8d-9d7d-060d81cf202d"), new Guid("82cbd461-0807-462a-b913-99b8a7527d11") },
                    { new Guid("ec24c9ea-29a8-4242-9815-5112b2be00e7"), new Guid("27cd07bc-0cd1-49e9-875c-dcde46ac0358"), new Guid("61c97d8f-b542-405d-954b-44da6f5e0be8") },
                    { new Guid("ecdc5aad-ae43-4f82-9977-7e4fcf8c1fe4"), new Guid("61315754-2ef8-40e8-b029-15b7da15b112"), new Guid("9048b505-4dcc-4613-99be-fc28db50aeaa") },
                    { new Guid("ed1ddc79-fecd-4c29-ab36-691bd078d008"), new Guid("d8aa8d61-b7c4-468b-a933-aab40a8debf9"), new Guid("9c5d2efb-8525-4943-8b9b-b9574392af5a") },
                    { new Guid("ee7de4c5-ad58-4c29-a0c8-ff5aaedc6251"), new Guid("17200911-e538-4545-9b62-dd79bacfb277"), new Guid("2ce9b873-1808-43a7-8e88-6a8c4bf265fe") },
                    { new Guid("ee979395-f58a-4951-821d-17d0aef8326e"), new Guid("d1625a5e-b0ca-4660-8d0b-4be9dc393790"), new Guid("2539224e-0749-4d16-b010-7f51d86cdccc") },
                    { new Guid("efa1a489-64a0-4a0f-9047-bbd6d13e2a02"), new Guid("50bd7eec-c9d8-40ce-a8e4-ae4dd2376113"), new Guid("b52c6b10-09c0-4e1b-9ee0-faae0b78bd1f") },
                    { new Guid("efefc589-fd9e-421b-8030-a2071d2b8377"), new Guid("0484f780-e79d-41ca-a684-1864df8f1be4"), new Guid("350af6de-dbb9-44fd-b225-a7a78ac44c8b") },
                    { new Guid("f00641f0-720f-494c-84a0-aa5d4f2b33ce"), new Guid("1d35677a-46f2-47ea-95f8-469ed98af1e7"), new Guid("43089309-0f9e-462e-ad47-0caa3caca915") },
                    { new Guid("f26afd66-0822-45df-afef-b365db2525e7"), new Guid("7bab36fd-2a86-409c-971e-9187439b462c"), new Guid("0d5404b1-2a1a-479a-a0df-32f1198c1254") },
                    { new Guid("f2b12ff8-cda9-49ef-9265-1b54ec7afa7f"), new Guid("fa50e941-4137-401b-93af-8ea22b33ba0a"), new Guid("9d4250e0-7d0a-47ca-89c0-240fbbb65b5f") },
                    { new Guid("f39e77c7-e832-4d78-be50-b0efd8c9a0e8"), new Guid("88f8318c-c6a3-410e-8201-9f373be10bd8"), new Guid("7dc3fd23-8ded-4cc2-9c8d-bb05a18fbe0c") },
                    { new Guid("f3bb83c7-733c-4cfa-88f2-5304b4fd0eba"), new Guid("1f758b75-d01d-40a1-83fd-c9aaaec93a89"), new Guid("53944f4c-6a30-4d31-9022-8670093cb391") },
                    { new Guid("f3e43f80-8656-4814-aae3-8da54511d728"), new Guid("0032e1a1-9827-483f-b5c4-690df498d00f"), new Guid("783b4c9b-85be-48d7-8351-a596c19071d1") },
                    { new Guid("f3f7f5bf-9fc3-4eef-a468-89c307a7eb43"), new Guid("7ca7c879-5dc5-4ad2-b9d8-a74f2eaf3f5e"), new Guid("9c5d2efb-8525-4943-8b9b-b9574392af5a") },
                    { new Guid("f5d9839c-acce-4678-877e-e7b84950ac39"), new Guid("3665cbb4-36f0-4413-93ff-98fa84cb8968"), new Guid("54101940-afb4-42bc-b58e-4d5472166e66") },
                    { new Guid("f642774d-b10d-4ece-a50b-01dd7cbf3df4"), new Guid("5201e150-83ca-48d8-b84a-a2940594f9bc"), new Guid("5d1c7888-b678-4aff-b3dd-18187b237503") },
                    { new Guid("f6638712-dacd-4030-8448-1d52f8e1b9bf"), new Guid("d1625a5e-b0ca-4660-8d0b-4be9dc393790"), new Guid("8e29c650-65e9-4409-aa9d-bc8cf8e85d2c") },
                    { new Guid("f6f77836-d972-40ee-8a2c-c36897a1c168"), new Guid("a6b08e8c-f712-4f38-954b-0810baf8c64d"), new Guid("3a6b81ac-a926-4dd4-90bf-82a81104c488") },
                    { new Guid("f7f12893-dba0-4bdc-8ce6-1883716fd040"), new Guid("0f6cb10a-e50d-4b8d-824f-54f8a7f38903"), new Guid("3036fd27-ba3e-4d69-b1ce-2624fdf0b696") },
                    { new Guid("f902a4b5-55db-4604-9f36-351603b607dc"), new Guid("b54d14f8-8e96-4356-a1bd-92a5b17aa119"), new Guid("739ada7c-92af-4e0f-b483-f3fe14ce315e") },
                    { new Guid("fa50d67e-2456-4356-aa4c-e6dd4b523266"), new Guid("9957e0d1-96c3-4159-937d-f2e7df48b85b"), new Guid("84c01664-4105-444e-a124-fc8b5bb03109") },
                    { new Guid("fa6cf05a-43b6-4511-8713-a900905b2ced"), new Guid("7b8a33cb-0472-48b4-ad42-69201d8f2c18"), new Guid("657149ca-51b9-4cbe-bf46-1209dfc461bb") },
                    { new Guid("faf530aa-95a5-4914-9059-8118d9aac7b0"), new Guid("14901afe-ab99-491b-86f4-15d40fd9514f"), new Guid("6d25d25a-5394-4c6c-9d27-3812bab252da") },
                    { new Guid("fb5ad285-13a3-4128-9500-31fc9143d27d"), new Guid("7e09f425-5bf6-45af-95cd-0a55a61f1c40"), new Guid("783b4c9b-85be-48d7-8351-a596c19071d1") },
                    { new Guid("fc95a882-1736-4a91-a3e0-1b98e7b62286"), new Guid("a592461c-9601-4978-bff5-52247a780a06"), new Guid("821a828c-89e6-48c1-952a-b269712f4a80") },
                    { new Guid("fceb74bf-91ec-4fb5-8a9b-5b0fd2611d70"), new Guid("5092e030-1d8d-4c6f-806a-818ae7dc1215"), new Guid("ebf426b1-b663-4904-8c25-708bf7b21e80") },
                    { new Guid("fd6e7a2a-69bc-4449-89b0-89285ab9dfe7"), new Guid("c7b6d26f-e3a0-49a2-8619-124bd2d286d4"), new Guid("9e67bea1-826e-4459-832c-64607f68f71e") },
                    { new Guid("ff46fa2b-0421-4e45-940e-2c9d557c471e"), new Guid("7dbf3e2b-8bbb-4f83-84f8-19ffddf8ba7b"), new Guid("1437cc5e-f450-4517-80f2-0748cdf756c4") },
                    { new Guid("ff56fdc4-e604-4f36-9c95-ec3e8808febb"), new Guid("33fcbe5a-0161-477b-b72a-df742ccdf74c"), new Guid("9a18260a-837b-4d46-b493-e8e816f1928b") },
                    { new Guid("ff61d5fd-6c3f-47e3-8a17-4fe9d481024c"), new Guid("7a980748-bcca-40aa-8478-b5990333e049"), new Guid("65481b48-77ae-40b0-a052-9ef06984c4be") },
                    { new Guid("ff6c563e-6997-40e1-8d6e-b8096463b2d3"), new Guid("c95cfc86-a73b-41fb-9b0e-c28d6af1d92c"), new Guid("1348ffc3-4d66-4563-a1b2-bb8a1831cee0") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("0056896c-7156-4443-8ae2-cba04cdb5a59"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("012135fe-8c3c-4c9a-bae4-bc2d29212526"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("013a1248-51e0-4542-b3e8-21fc1e8c723c"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("017d42bf-5de5-425e-9538-945109114dae"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("01c84211-4433-40dc-b3e4-f879a09ae619"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("01e504fe-2664-4e86-aa0f-4b0e932b38d7"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("01e7d22a-084e-4ba7-8dda-1d6932ae5a49"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("0205bd4e-3eea-4265-9273-f8e03e2dd8f2"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("020ea85a-7fd9-4dfc-8a58-26e8581bedc0"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("02d9a7b9-3f0d-4ab8-a4f5-a9fa66024ac6"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("048d81f5-6a0d-40b5-a5aa-d44b6bb32822"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("05334197-8821-484e-8228-992b39f8184e"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("06352f36-a0e1-46cd-90c2-c584d189ec9f"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("065a119f-6c18-4b4c-8122-9c97071abed7"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("068c2bbe-f0de-4b29-adb4-d8957419a050"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("077fcda5-1b73-4e64-a39e-f13f64cd2d84"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("091318c3-2747-4b9f-a8c3-802bd30c1da4"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("09204647-7ff3-4e4d-afb8-f27b3d57a58b"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("0951366e-097f-4b9d-929c-98ac270d87a7"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("099fd733-2675-49f1-8b15-484653e0e1fb"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("09b40d51-c697-4225-a882-7a447fab7364"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("09d45204-3d07-4f39-8914-eafd34b397a4"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("0a0768dc-06b9-428f-8466-8fb28a82117f"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("0b4247d2-0442-473a-9585-a882e9f39d5f"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("0bc13100-b35b-478d-86a9-c8f0aa03712b"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("0bc611cd-f407-4f58-838a-de4a55776678"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("0be72de3-db6b-4bb9-80db-e670d4b15c83"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("0c193530-d63c-47ae-b85b-bc26aea5b1cd"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("0c433290-daec-4ac3-8d26-f55c98eecabb"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("0cd14c78-aaf6-4bbf-aec3-a48bfac5ee81"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("0d65ce13-fd4d-467c-8e57-c09a87edf1c8"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("0e80805c-6bf5-4ddc-aa21-86f2dc071fd7"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("0ed93d64-d7fe-4eb6-a33a-118bd82805ad"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("1146bd80-37dd-411b-9dd7-1ba3ff2d0d2a"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("13110fbd-dd08-41fe-9ae1-f72e2933132e"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("13c4fad3-66ec-4a16-bcb5-efc2091553bb"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("1425e047-953f-4342-9de2-d8c3c537528b"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("142bb21d-2cc5-421b-8733-1f58f327bfc5"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("15cfe5f7-4b65-4587-b033-04999446685b"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("1618a0ad-19fd-4e43-bb1e-202fbd2a0d8e"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("166c2d89-b0f4-4a31-bd64-8d1c6ce042dc"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("169e006a-4f83-4e33-8dbe-3c2105e12781"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("16c5013c-5825-4697-a69a-aeffbe4ce514"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("16d44589-0688-475c-b4f3-dff93c166bff"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("1722655c-f7b6-4271-bc29-7750b4f65b12"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("174f7c2e-2bdb-413d-a912-f7d766bcc3ae"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("17862fb3-f5da-440e-8542-69a4c2612a02"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("18e7116b-e360-477a-94d2-5f5ebe0059ff"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("19953dd9-d05e-49c3-907c-018aea0c0bbd"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("1b34c2df-5556-4d81-bdc1-e826d6c71a93"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("1b540d15-1c15-4990-92e0-3f1a5576492c"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("1b6db49d-86f3-446c-b88f-a81f7d148d46"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("1b878c94-3429-4fb7-b85b-7e663785061b"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("1c470166-2fc4-4a4b-b5c9-6c0457944b09"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("1c9ac30e-f91a-4484-9f74-de0e7b8576a7"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("1cc27659-089b-4b9b-80a0-2c57c638d520"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("1cfea838-6eae-44a4-b031-09bd65f37986"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("1d486c1c-8f04-4f12-beb2-69ff9a9abc13"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("1d618d1f-f093-47af-8256-ae340a4cecf7"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("1e0f89c9-d73c-41e7-8251-a8a639f7a148"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("1e4c26b9-8248-41d4-a30f-818f63184e8d"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("1f13edc4-88d3-4600-b056-bafe1f12ec52"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("1f390d52-1b65-46a6-9499-74d95c096775"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("204dd2f9-84d7-4c1a-9a5c-ec93a51f1795"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("20a44783-d0ee-4349-970e-6444c994cb48"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("20c26324-a527-4f19-b715-24fd8d3baad2"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("216954e4-e88b-4377-a65e-d9d8f537a9a3"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("21b84915-ef30-40ec-aa3f-b6c88b897ca4"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("226194be-9ef1-4ee7-bea6-7eb37bc508e6"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("22d3157e-f6cb-4932-8fb3-521bc98f2075"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("2331181d-e45f-4714-915a-66f983e6ab46"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("2446711d-bc78-4004-afab-9f3fe3a3a43e"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("24785452-f088-47b3-bdf2-2118fb020db4"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("24a35dd6-8a1f-4c1a-bbdb-8f9473fc04a3"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("25212dce-ba80-4fea-83f7-533ee8c2c238"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("2549fd47-4512-4875-87ab-eb2979935989"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("25860aee-d785-4dfb-9fc1-3dd30a459146"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("263d9f9e-64ef-47e2-979a-9b90a302512f"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("26418ee0-6445-4d21-a447-422ca6144e4c"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("267b3275-1bf5-4389-9ab9-589ffd445b02"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("27183b98-e7fb-4b73-872a-627555a97a9b"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("29595870-1295-4535-9b11-498668a6f967"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("29cd0a3b-f0b8-46ba-9880-88ed9effed5b"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("2a226c79-2ce8-4d87-bd9d-7fe4c3f52dd4"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("2a8f129d-1d99-4769-a85b-2dea9d27933f"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("2ad16e62-8579-4f18-a3f1-f508278aa94a"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("2b88b409-7373-4c4a-995a-ddddedd95c47"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("2bdab5f8-22c1-4021-bbf8-dfd6d28256b3"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("2c1d69d6-19a5-4f98-9553-05c718c2b498"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("2c568821-ceb8-4eae-a40c-1a57510edc55"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("2c7fac99-7acd-401b-860f-76967eede654"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("2cdd05a8-103d-4a84-a1fd-f1c0c84a6ff3"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("2d1680ad-67d3-453d-a431-db4f4d893cd4"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("2d300629-6599-4a19-9e09-11f008053a1b"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("2da1a758-e9f8-4a9c-be6f-4e8fbedc5912"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("2dbeeead-6ecf-4db9-b50a-e24e71b0e215"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("2e6cb970-3afb-4e98-b30b-4ab762001dae"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("2fafb644-40a5-4a58-a2b5-131d3c6314e1"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("2fe3a0ab-4d63-41de-958e-b20006f6a69c"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("3218c441-e93d-448e-b8db-98b3a0bdbc57"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("3295ca38-785e-4899-8368-698983953a8b"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("334e1670-7f43-4de9-8746-45ab942c85f3"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("34c2f3eb-8973-4a69-9236-9ff18663be1f"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("35efa315-7d33-4ef8-887e-0eceb5b57acf"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("36f6b2a4-9e36-4ba2-befd-3e179d0b0c1d"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("37f8ac84-3fd7-4d84-b7c0-9246073e123b"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("383739c6-1358-47dc-acaf-3cdeb02c7f4e"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("38894065-77b8-48f5-afc6-23f9ae079aec"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("38a75a59-5251-441d-8024-6f30781d045a"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("38e7ce88-5ab9-438a-8c38-9073c27e7aa6"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("38f9e96f-6e82-4e56-a29b-9d4f4b18ecab"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("393437d9-436a-41cc-b197-7cee9c3819f9"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("3a058d26-8fb7-4de0-83a3-e25e25bf6a9d"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("3a40fa6f-9593-404b-a313-fb6171f925cd"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("3aecba2d-57b6-4c5e-85bd-feb0ee5cfa4e"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("3afe82bb-3564-4e82-af89-948ec1777ea1"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("3bc16ee3-0539-435a-b3c5-f3df709b543a"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("3bd3acad-15e8-4d7a-8a14-3edc9132eb03"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("3c671d3a-3740-4e5f-b537-bb07682a1739"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("3ca3053b-fef3-433b-a173-c0fefd62dcb1"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("3cd88d91-5f3b-467d-9968-66bfe85dc3f2"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("3d73dd51-c7cc-4eec-be26-916b53b422a5"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("3e0e0b53-dfda-46a2-ac30-6cf193190a93"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("3e4a4a97-289c-436c-9621-5d69c29a9379"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("3eb6a9f5-eacb-4a7b-8548-9b7fe7ba8533"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("3eee72a4-0bde-47ea-8d18-f46baa0615ef"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("3f945dfc-9727-4901-8c29-e395a52dc509"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("4007af4c-1f57-4bbc-ab8b-b39eaa788e04"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("402add7c-1ae4-4a8c-85fd-92d42b2b1acf"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("40794663-ff58-4a72-b9d8-a744fd080787"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("40965102-d694-4909-87f0-027b86c04b07"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("4111dda7-df92-4dee-98ca-2ad9a67ee7f0"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("41dbce6a-a4b5-457a-bdfd-af0bf5202949"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("424ab566-eb76-49c7-ba90-17728e71cbfa"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("42b64b53-0fe8-4f37-81be-b918b9c300f4"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("42db25a2-53a9-4734-ab5d-4ffc567c4109"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("42f9d339-c74d-4ef9-a51a-9b22449b77f8"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("44161169-e2c2-41b3-ae1e-5a16830b9e9d"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("448d8263-2194-4761-b9e5-d1162d5745da"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("44b2e07d-e50f-4626-be2a-653005df939b"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("44db622d-0b67-4325-8c2e-bf1b7a98de76"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("45367dac-6214-4d9b-bd81-2dacb38d8dfb"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("460fb2b1-8f06-4de6-b3b8-7fef8f30cdf3"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("47155fc7-6956-47bc-9d45-a3baa95911c3"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("4732103c-62a9-4b04-a539-e321d19b20b3"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("4a3ee49b-79ee-4bd5-a606-8777a089a5a2"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("4a583628-fbd8-4e8b-8cb7-8df42b5188ef"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("4a5bcb31-3f2a-4939-929e-c0bd32c824bb"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("4ae175a3-4564-4627-be02-b868a5429c90"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("4c72125a-bfc9-4777-835a-2a9e1cd9924b"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("4df314e3-6931-4a72-907c-7623ec944a93"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("4dff1c54-cb97-4d89-9402-6807f55406e3"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("4ea23e78-a083-4f6e-968c-4b1695d15a4b"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("4eba6035-8efe-423c-bef1-ed3f592af0a1"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("4ed9e7cc-272d-4252-a838-b394f9539c3e"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("4fd65e70-fc41-4e40-8b2c-9f2a218d46a2"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("51851509-189c-48a9-977f-69caeb63b733"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("51e0a03a-c4ba-4161-8dcc-601a6c0f6e9b"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("524399f2-c7cb-4a9e-b37a-f4343541efea"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("52d9045f-e22d-4612-8370-37949887ef3b"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("5350d8c8-4dbe-44f5-b794-ef86c4e2e8c5"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("53775e30-f222-4100-8d1f-1f5942cb44a2"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("54f2d4e6-ecba-4f39-af52-da5db8f4f00d"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("552346c2-213f-4caa-845d-e72b3ac28e83"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("55267e66-6aa8-4bb2-a8a0-e912a0fbaba8"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("557d010c-3ddd-4da2-8bef-fd75c51d6924"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("55d383cf-4431-484b-9ff1-288d0df771dd"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("56bbf648-5298-4fee-bb51-b26e2c656a47"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("5796f925-8cb7-48c8-804b-84b800c4466d"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("583b58c8-eff4-4a7d-a9b1-d3c450debba2"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("58c4b929-361f-47df-9656-1b24169c2a6c"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("5a75a06c-9e96-46bd-837c-f0fbac07fbd7"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("5a80fa5d-359b-4a91-9f8b-3522be37b4fa"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("5abb52e7-c760-4e28-8722-ec7591f4c238"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("5aeceb5e-0ecc-49df-8465-505ed630f6db"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("5b80e266-120d-4609-9c3c-c58dda651bab"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("5bffd88b-887b-4058-91cf-3abfec4fca3c"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("5ca07209-89a4-46bb-9b7e-119e395bab90"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("5e90bbc8-4183-40f0-9a1d-5950b1083836"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("5f935dac-4bda-45cc-a495-0170ce4d051f"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("6047f1b9-2453-4d50-be42-f514dad530a9"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("60e6d26e-2c49-41a6-a51c-d5f3aa57d91b"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("618a68d8-102a-4c00-ba42-687df1be9e8c"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("61e327ba-29a1-4141-826d-d2c1206a2080"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("62360831-52c0-45a2-9d81-b58cd7d6ee95"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("62a1339f-c603-4ff6-a962-ad15628cc31b"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("632fffee-09a8-4e43-80cd-271d6ee11076"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("636d7762-0205-4109-94d9-0e9287b04c12"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("641b0f3e-6e48-4e6b-a76a-517b0a1f0725"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("643fae43-1013-48d2-9569-9120f298e28c"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("6440a699-163c-4e7e-b51f-1a6c1eba33fc"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("649a52f6-deb5-4323-9a7d-b47b19fa727c"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("64d1c589-d9d9-48d7-b509-95002ec8e213"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("65b9baa9-f73d-4ccd-a0b8-2a4cb1eafbc8"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("65dbaf49-d8be-426e-8e2d-1849f25183ee"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("66259974-3f0d-440d-944f-bd9fc445ab68"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("6631979b-530b-4a54-ac8b-a87226aa0a75"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("676e2ea1-692b-456b-9bb3-ca729d6da322"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("6809daaa-3b8f-40a2-85dd-ca6078e78b5c"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("686fec3b-2292-4d19-88c1-0b94142f7ca4"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("687999ca-0a2e-4d60-899e-4b6a42dfe20c"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("6901895b-1484-4370-9d84-7cc42fa0efe5"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("69552924-4f51-4071-b38a-7fe4f5639f64"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("69bd99c7-cd5d-4989-946a-d9eb982cddc6"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("6a4d4371-cf19-419c-90ff-193fa2eeea92"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("6a84fd3f-6eb3-4ccc-95de-12b7351e5807"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("6ad71e71-af4c-49c2-b7c7-74a3d42089a6"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("6aeafdf8-f9b2-49f0-8dfb-21c1a4daf707"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("6b14762a-d91b-4af6-9771-b55ab10f283f"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("6b87eb0f-8feb-46ae-ac86-d60fd5c9048e"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("6bf0b05b-a1f2-4612-8872-60d02f9c531c"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("6c1755aa-309c-4f3f-b529-b57146d00b3a"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("6ce7f980-b11e-4eda-bd6c-f972eb6fe8d9"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("6cf604f9-9ab3-4f39-b68d-af8ece8502e0"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("6d64a920-99d0-479a-a91b-6fbf31b80ae5"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("6d74e52f-c95a-4207-ae84-cc2794eaf277"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("6dbf05e0-38e9-483a-b8db-a29d86ae22b2"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("6dd7d764-f193-42ff-b427-1b03704b6c13"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("6e7b218f-23c2-4dc0-9707-cd8f0b7e09ee"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("6eaf2743-d78e-4c10-90d3-169c92621c21"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("6f411337-f44c-491e-ba11-4097ccad30c4"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("6fc50034-f039-42c1-acc3-1a572f6509de"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("70517a11-ea99-409d-9579-a9c78e204f1f"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("733315e5-0976-4f72-8f4b-38a5192ca8a8"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("73ee8159-0d7e-45d1-a288-b32386fde99b"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("74065790-ee3d-4724-b20c-2523b3316cbd"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("750b2f27-16ea-45fb-b409-b52c253547c5"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("75e46ace-3a84-43fa-96d9-1a128d355f07"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("764fd68d-3b89-41a0-af6f-ca97e6d19c34"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("76ae3c16-55bf-47c8-9be7-36e56b1fe04c"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("782d3160-6a84-4c5b-8069-d5c3bb69987e"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("782fb3cf-2c3b-4964-a27b-7fae46e1ef73"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("7adc0f9b-78aa-405b-a8ec-be1ac9f25706"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("7b0ab8aa-6147-4daf-b0ce-da6ac60c0f47"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("7b56de2c-d5ab-46cc-9969-0853148537fa"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("7d78c14a-fc4f-48f4-9e8f-03378c7a5d64"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("7db9b067-eb73-499d-940a-26ef8ce31fd4"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("7e614026-3360-4322-b842-4ce5f5f4ae1f"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("7e874e3a-29e9-40a1-b6ce-e1d130f84c76"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("7f9b1a89-54a5-473b-b3c1-1f07147fcb02"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("8013dbbc-09eb-4684-b4e5-98f06976ec62"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("80260a8a-0429-45db-859b-32ae0395afa6"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("8070541f-0e5b-47a5-8d96-46d2bb7fec62"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("80b74926-5e21-4d2d-807a-100fa75f77a5"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("80c40c40-a625-45a8-bae8-2547d5c60c04"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("81086146-2022-436a-b5db-f891415ffe49"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("815208da-95b5-4459-a47c-fc3a11016c7d"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("821ee7b1-048e-4184-8ba6-042784dfaf3c"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("82323979-d62b-4900-8e0b-cb2cdd97250d"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("824dfc4f-c0af-40ba-bede-3373ae6853a5"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("82e55944-fca8-4e2a-85a8-25a670afcde9"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("83dbee4b-c86b-4c58-9025-5e3f8b26dfbb"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("843ea98d-df68-45e3-9837-5dab9ae8e1b2"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("84433d99-6310-4612-9b0a-e0aec6ea656d"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("844e8b82-7cfe-4c44-a7f2-8bc631b364fa"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("85060250-a927-4fca-9947-e920dc9e15d2"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("872f9bcd-e071-47f4-9db6-0a2f1e4941b9"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("8774612a-70e6-4805-89ab-02a8834e6948"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("87a2c996-27ba-42ba-9402-7a0f4f9df486"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("87eb1bd4-18c3-41b5-824a-1d4cbd83fee2"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("8824a74a-1be4-4fee-9fb8-73525b557b7a"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("883fdec8-69dc-49cd-939f-70dcc1e84e79"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("888b1cbb-ccfd-4c94-b051-58dffe3c74fb"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("88969432-8053-4f9a-a4c2-f711f088e8b0"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("88ba64b6-e811-497f-a08b-e3da9c0fe9d6"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("890891d7-1329-4a32-9be1-ad1acbd0b1a9"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("890abaf9-6d11-472f-a02a-ac3513a80a8c"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("893f243a-d7e2-4d2e-a7f1-41d58db4488d"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("89748b9e-2b90-4188-9eb6-beeeb430c9f0"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("8a9a2bc9-7a17-4746-8357-35699c71c8c4"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("8b089495-e023-492a-93c2-f92bf32d9963"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("8b7abeed-bf8c-43ce-8741-84ac89bc216b"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("8b7e3434-148a-47a1-b3e7-d150f9dea77a"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("8b8ba163-414a-42b5-b5ba-f3c8ed6c802a"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("8ba71c8d-d388-4817-9a47-63ba5c7d4d49"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("8c094eb9-bb38-42a7-bc3d-87c3cf47acc8"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("8c44bb46-e098-43cf-8317-d46de4bc2956"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("8ca5e18a-6820-49e1-a38b-ef1205f5e74e"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("8cabff50-57d7-4fe5-80a8-d92fcf74bc7d"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("8e04dbab-48f4-4415-9289-785d7a37d75a"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("8e9dfde7-ad87-4875-acde-a3594a9b4f26"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("8f799ac1-6167-46ea-bb3b-580e209d6716"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("9088d274-9e70-449a-8038-6fa3a5a9e6d0"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("914c41b5-29ce-48d9-9466-8ea5e84f686d"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("91b50859-f549-4b5d-b33a-4c9c5a1e686d"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("91bbb2ff-04d6-4689-8b4c-7331cddaa191"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("936e83bb-c45f-49d6-b4b7-761d47710287"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("93e248d0-8f52-406d-9441-51798a951bf6"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("944c500a-30a3-4f28-a37f-4d0e1cd3bcfc"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("94b5e816-5f0e-4526-b15c-02449aa1e506"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("95bdb04a-fbd4-4ccc-87ff-ae8bb9dee1f6"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("96053097-a037-4b13-912f-98840f27b95a"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("9818ba79-f76d-41fa-bdd6-8f63f65a500a"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("98473ea3-a184-4d95-b720-9d0f10a16be4"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("987cdd6b-7ba6-4c16-b63f-bea162760703"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("9b023ce9-9209-429f-b440-90c43628bfd9"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("9b14a329-e557-44a3-8f14-1e29d4b06ad9"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("9b4db4b1-7e66-459d-bb93-d527e8d7a75d"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("9c6a8ba2-9e53-4622-8d31-57c70a781270"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("9cd97e16-67b8-40aa-a50e-e6157537c642"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("9ce1c000-39da-45cc-b839-3aca93755006"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("9d5069c8-12a3-4434-85ce-72fd3737b423"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("9e465a5e-535c-4431-aca0-39c3ffeab894"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("9f4e027d-bed8-4455-91fd-237fe1285d33"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("9fe005b9-a88f-4b8a-8247-305749affdde"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("a17199b6-a8b2-47f0-8d10-8cc35c0f8059"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("a1765633-5853-477b-81b4-028ec7cbc4cf"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("a1af4c08-00f3-4ee3-b8a6-d827bc302e33"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("a1b3522d-bfc9-46b9-8200-7c0361d79b87"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("a32610cb-fbc6-4977-b19f-27d89a91c0ce"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("a3e65b61-25c4-4aa9-94fb-90ade04d7b4c"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("a3fb19d6-125c-4753-a7b7-e524be403085"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("a41f76d6-cc8c-4b13-ab62-8bcbcf537b21"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("a4b9912b-9b95-4c2d-b08f-c08ac49826f0"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("a569a598-1c47-4b97-aab1-d4feee38d112"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("a57c649b-60e1-4091-9bc1-6022ef7f57dd"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("a69ba202-eb5e-403f-9dc1-6fbc0e13c082"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("a737ee06-fcf0-49ed-be9c-746b5eeadc1e"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("a7acfdde-a5dd-4a55-9740-d0123f4e27c7"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("a8262898-b69a-4233-8172-fc2cd1444aaf"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("a83937a7-cf9e-48e4-ae99-017e45f80da4"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("a8b5d0f2-3b00-44e5-be36-41010072bf0b"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("a9411108-eb62-493f-bd76-5a4b2cbc6ac1"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("a9575d5b-c402-4e21-aade-3e9bfcd8a4ee"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("a9d36a7c-c0f3-4492-bf73-bf72c6f79f38"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("a9f4b4b7-7049-406c-9103-843bfb6086fc"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("aa69b230-4964-461e-b1a8-f24efdbbd709"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("aaf52b23-a91a-4137-a543-2b92dfb9e599"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("abc4f05c-4407-40e1-9c97-d0b8cfcac031"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("ada7df79-d424-4002-8322-a535f70f46ee"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("adbbba89-6012-4478-a3c0-1505e386e1f9"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("aecbc86b-6d63-401a-9674-7915521164a5"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("aef6e569-2cb8-4c52-a037-2ae75600d324"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("af591840-30e7-47e4-822a-c3b79f0c41a4"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("afc26302-d5a5-47de-a969-e041d33bf02a"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("b0bdfbad-93ba-40ce-954a-7aad52df9cbe"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("b14f3476-37b4-4796-966a-5592359a902a"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("b1a19b61-07dd-4667-891f-84e93ac95b17"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("b1d62abe-89a9-44e1-8cc2-18f9445948e9"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("b203c082-5f5e-488a-96c5-8ccb7e8f54dd"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("b3667f09-cf79-4f49-b044-44c27dee9124"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("b3a64542-2945-4f94-91e9-f8a4359b0ccd"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("b3bc2aab-a2e0-4695-8d98-3a6eaaae4d20"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("b45c3470-4312-40c4-bf14-74c3c396004d"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("b47786ad-83de-498d-95ad-f2955054ea82"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("b54278c9-2e53-494c-a28d-84241d55eaee"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("b597122e-cc94-43f5-bf78-7dd7afc9657f"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("b67c05bc-c2c6-4789-84ff-380d309490ae"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("b7989cf2-b866-466f-b7fc-8c69bb7f4a18"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("b80cd614-84c2-4c0a-898e-f0bb24e2a6f4"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("b86cca74-2f49-4c6f-b2d9-3885173b7bc4"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("b8efb43e-cb50-43d2-a960-d54485731672"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("b9b18a0f-b990-4080-9c3c-f97ae78cea2e"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("b9daba7b-42ff-4b22-80dd-fdd133faba89"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("b9e4482c-9312-44b8-8fab-8ea34fbda9ac"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("ba4bdccb-130e-4fb4-8bf8-0fbfde238874"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("bac91cd3-c33c-43ee-858c-1a6739b4ba2d"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("baf5f5b6-271b-40ad-937e-44d14f18f38d"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("bb337c00-3bf8-4bb9-8edd-e31038af62cf"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("bb50de58-03cf-4b49-99c7-f3bdebbc8c63"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("bb748e89-e5fa-4834-af85-0876f9861a99"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("bb939cce-ac03-48a4-91fb-d2f7de8fdfda"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("bbcf7dd7-6127-4933-9987-d61145292d3d"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("bc7beec2-b0bc-42c5-8e28-18409ebc1563"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("bc8e01ed-31b3-4d23-a8ae-31f9330f25bc"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("bcab66d0-a907-40d5-94c7-1ca5072eb1e8"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("bd06dfdf-482b-4b1e-9263-dd501ed1b155"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("be3a80ce-20bf-46a6-b9ab-ddedd6f4b1ed"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("bed6f6be-d8c0-4bc3-bbb1-770fa24eb969"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("bede4732-b248-4667-8060-6608d1cc53e1"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("bf43cfdd-4833-43f6-b1c6-649934b95ad8"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("c0ad5283-80d0-4edf-bbf9-53cc11b71fd4"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("c0d51e7b-073e-40a9-8da9-00fbd1566779"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("c12f51ee-f64b-4a48-9ac4-b9436448ebe9"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("c24b6165-353e-4e2c-b692-296a8cf48a45"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("c29ab1fe-9194-4382-894b-075124af42f5"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("c3f4bdae-6327-4e51-8b60-5de8a471342f"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("c4026f7b-7a11-4a37-a6a4-eb70a4595dca"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("c47ffc28-dae3-4a31-8ae0-c35dbc607a2a"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("c4b7c320-dc2c-4b21-a706-16b582f98f4f"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("c503397b-438d-410a-a553-007f25162f99"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("c5330db6-2ad7-4833-8076-ee10a9dd77f6"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("c5b7c9f1-0abd-411c-ac1d-fb27c4f3716d"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("c5d770b4-e6b4-464f-ba89-8a50ab54a58c"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("c636d67e-c85d-4410-b2f7-d90aea7d6519"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("c6be4095-d3bd-4f0c-b058-3714249a4e21"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("c7850fe1-7a57-4ace-830d-11f2ab7c94ef"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("c7dc461d-4dab-4c96-bdce-d938fa5b1bdb"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("c8e91da1-4098-45b8-aa57-14cd9db6c3c1"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("c9ae5af9-8f93-4e98-b207-d36cc13f94c9"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("ca246303-b514-4632-90c5-b2dd37e678dd"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("ca62a994-7536-4fbe-8d4b-8f2f99bb0f73"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("ca68049c-9e1c-43dd-9276-ef54cfde3220"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("cad0ea16-327b-498c-8a65-bda626e89d76"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("cb6d23c8-8524-40f4-84c3-714ecf6b72db"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("cbf5bd7d-3aa3-4c83-9483-777b1f7be614"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("cca4c17b-1868-403d-93cc-346b885d6f65"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("cd67eda8-66af-4730-9d66-b9f809666373"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("cd920791-36ca-4d69-8f5c-a908232e2d80"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("cd94412b-d8e7-45b7-b752-7a052cc5b869"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("cdb0c4d5-bfd9-448e-8d9d-97894fd6999c"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("ce645bcc-5932-439e-9862-ae767ae0837b"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("cec53ca0-5914-4062-8631-b5bc764b45d6"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("cecdac39-465d-4443-be33-dfe52e4d7ca8"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("cfaaf491-5167-42da-99d7-12946be544e9"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("d0c85a16-63cd-4953-830a-be4dc35ed605"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("d167bc63-b72e-4dd9-9a2a-0f84c375d2e4"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("d38f1bfa-8c3e-431b-a5e2-dd1f24329b44"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("d3c227d1-ba87-45c1-91d3-6b5891658cb7"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("d471a59e-aa28-434e-8094-8ac5486acebc"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("d48d2aa3-fc01-4f1a-8963-8b3b81950f79"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("d4bfdd39-9699-45cc-896e-e0ca4fbf75db"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("d4f7b9f1-c4d0-464d-a12f-c01a2abbf7fa"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("d5027fab-ddf8-4b47-b475-32597628f51c"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("d5d54dfa-9f7e-46ce-8903-e8f41d9061f3"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("d5e91ef6-b451-4626-b40c-1f85e585a262"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("d6826ee3-cb8a-43b8-a86e-27c0be7ccad8"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("d75e9b2c-ad47-440c-be9f-5aacac967d97"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("d824ef47-0f9e-41e4-bd9f-21c39d380e2b"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("d8425c7f-2c1b-4a40-b8d4-6215492b9892"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("d8842b9c-5751-431a-b472-62334196b2d2"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("d8d6a83e-9a0a-49b2-81cb-a037dda594e1"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("d9467c63-0bfe-48ce-adf9-626434c44695"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("d96116e9-7689-4ac2-bf27-c1de9e507036"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("d99fe782-6e34-4d4f-9ffe-ea95ff61fdc6"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("d9bbdf0c-f5f2-482f-9ead-3ecab99e681b"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("da41cd05-d2b2-4e37-b255-eddbf16b85eb"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("daa98ed5-5d32-4eac-9d47-e70649ebf43b"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("db5928fe-24d9-4b4b-8fda-5277233e76a1"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("dbe41c6a-4378-4f52-9f0e-87585b8fd873"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("dc476af7-ae8d-45f9-bab4-13a57cbc73a0"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("dc4d98d7-4e85-47a6-8100-790516369d54"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("dc8951a2-c58b-4b9e-b652-558ebf431d76"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("dcbabce2-46ec-448d-9049-3bf0bb00522e"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("ddb81d21-c486-463d-9531-50eb88f85377"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("dde833c8-91e4-49e5-879e-75ac11e69cab"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("de181600-e177-4d92-8b3b-b4878aba01a1"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("de5cb890-4057-45f8-acb1-5bbf4084b8d4"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("de93f95c-981b-4b23-b319-c426caca47c6"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("decd0801-a583-4879-b026-a95a2b81780c"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("dee90178-0c94-473f-ac38-9fc8e6c5b394"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("dfeecd97-3614-44e1-9896-e098e5a3eb59"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("e04301c4-913f-439f-97f8-33891161434e"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("e06fce51-cc1a-4d10-a205-902b6c2499fa"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("e129703d-6a10-440e-9fa5-d1e5e8ce741c"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("e131f5ba-ecec-40d1-9f5f-286e94e223b8"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("e155ad69-cbd4-4fc3-8691-85c0d4b137c2"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("e1d5ca7c-d72c-4454-a2ab-a48480e4933c"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("e2163eb9-66eb-4efc-aae3-f142012436de"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("e2698199-d2aa-4173-8edd-31935d7c687d"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("e2734752-52a8-47b6-a189-d7d55aae5617"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("e2ab3dd3-21b1-4d58-89e9-b77d0292476c"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("e2da8b2a-1f79-4c26-ac04-d2a4d25ccf18"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("e30726a2-50c0-438d-9b68-d11b4512d939"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("e315ad45-fcbb-4f8f-bb38-b02b83069260"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("e376d3f4-6daf-4a73-894b-888b208b5b31"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("e3aa79de-d495-48f4-842b-9251c5db9283"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("e4f6a8b3-d082-4617-ab2d-80e70b135a12"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("e5a9f443-72f3-4e10-a495-016398e21436"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("e671f25d-4fb3-4ce8-991a-8f1a1d0c9af3"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("e77e5043-9db5-4bc0-b1f2-842ca9728733"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("e84093e5-3ef1-4677-b334-e2c2d41370a3"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("e863c4bd-f54c-4d81-b1f4-1fd43bb527a7"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("e8ddc25e-a92e-44b9-9873-c6e6ab9084f0"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("e9dbdf60-384f-4963-8e41-9d3dec48ee49"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("ea470d4f-d996-4b96-8c4f-a94142631509"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("eaf65423-3294-48ce-8e8f-2c6a47e72bc0"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("eafbf38a-b9e9-4aeb-b6f9-0ae082f14683"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("eb8a387c-0c70-4140-a0ad-0158f63fd673"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("ec24c9ea-29a8-4242-9815-5112b2be00e7"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("ecdc5aad-ae43-4f82-9977-7e4fcf8c1fe4"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("ed1ddc79-fecd-4c29-ab36-691bd078d008"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("ee7de4c5-ad58-4c29-a0c8-ff5aaedc6251"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("ee979395-f58a-4951-821d-17d0aef8326e"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("efa1a489-64a0-4a0f-9047-bbd6d13e2a02"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("efefc589-fd9e-421b-8030-a2071d2b8377"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("f00641f0-720f-494c-84a0-aa5d4f2b33ce"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("f26afd66-0822-45df-afef-b365db2525e7"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("f2b12ff8-cda9-49ef-9265-1b54ec7afa7f"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("f39e77c7-e832-4d78-be50-b0efd8c9a0e8"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("f3bb83c7-733c-4cfa-88f2-5304b4fd0eba"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("f3e43f80-8656-4814-aae3-8da54511d728"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("f3f7f5bf-9fc3-4eef-a468-89c307a7eb43"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("f5d9839c-acce-4678-877e-e7b84950ac39"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("f642774d-b10d-4ece-a50b-01dd7cbf3df4"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("f6638712-dacd-4030-8448-1d52f8e1b9bf"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("f6f77836-d972-40ee-8a2c-c36897a1c168"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("f7f12893-dba0-4bdc-8ce6-1883716fd040"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("f902a4b5-55db-4604-9f36-351603b607dc"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("fa50d67e-2456-4356-aa4c-e6dd4b523266"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("fa6cf05a-43b6-4511-8713-a900905b2ced"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("faf530aa-95a5-4914-9059-8118d9aac7b0"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("fb5ad285-13a3-4128-9500-31fc9143d27d"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("fc95a882-1736-4a91-a3e0-1b98e7b62286"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("fceb74bf-91ec-4fb5-8a9b-5b0fd2611d70"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("fd6e7a2a-69bc-4449-89b0-89285ab9dfe7"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("ff46fa2b-0421-4e45-940e-2c9d557c471e"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("ff56fdc4-e604-4f36-9c95-ec3e8808febb"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("ff61d5fd-6c3f-47e3-8a17-4fe9d481024c"));

            migrationBuilder.DeleteData(
                table: "OrdersAndProducts",
                keyColumn: "Id",
                keyValue: new Guid("ff6c563e-6997-40e1-8d6e-b8096463b2d3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("002f383c-4613-42fc-9549-ce410a2d71fb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("016a7952-346c-4f8c-99d6-87753d0c636b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("01b441ea-be2d-482d-ab21-05ea570dc15b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("04a8f30a-dde6-4dbc-b808-c91f7a20dafd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("08e45c6b-780e-4abd-95dd-a0d0e798bdd6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("098f7806-cae0-419b-b914-c61652a617d3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0be426f3-b8be-43e8-b55b-b313c000c336"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0c7c9df1-c321-4ddc-9099-5645994e5ead"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("11d4216c-94c5-4713-8831-f98974770ee8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("126800f8-0b64-4911-8fe2-844f111fc0f0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("127d89fa-98f9-47f1-9e80-3420e3fff463"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12d5ea38-5fe2-45e9-bdb8-f1310a14bd65"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("17bf3079-004d-4c77-87ed-23945cfe051a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("18598187-e2c4-4050-afb0-1ceb05883a63"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("19a07e66-65bf-4143-a7a5-e8b7119755c4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1a3b25e8-9f3c-4482-9f5f-111d9ad76661"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1c503980-84d1-444f-81a0-ff259c29304c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1d912c2e-7c26-4a6f-b7e6-f57a71ddb824"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1e93844e-d88a-4aeb-845d-ac98b7381d8a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("20c99112-f26e-47b4-8cfc-33fc125ab840"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("22038067-da16-48bf-9487-33472bf6154a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("226f557b-4554-4db1-851f-487b2e559e96"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("22ee8203-624d-48d1-b2b3-97f68791a72e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("27efe18d-639e-43fa-94c8-518e3d3dd882"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("28aef3fd-92d8-42c0-abac-745e602377ed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2957b695-dcaf-4882-92e3-8f3de9d128d8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2b19998d-f5da-4dde-bdfc-3185a59fe8e9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2d6db41f-6022-41ad-8ad0-b9e70a8d34f4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2e6a0ed5-64b5-4d82-9ae8-8a44e376cc84"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3167c290-c78b-4274-8539-8721bfedb2b6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("31f63f70-88bf-4ca3-81eb-4358a1c859b6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("32eb71ac-57c2-488c-9566-677d5493982e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("34dfe649-3e92-4b15-b5fe-b9f999973c7b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("34ebe627-57fc-41a0-a705-72510f449d07"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("376b3b24-dad5-4fef-a042-07234f66a0fd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3785fd87-a630-4358-b2e9-c283d80c0eac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("37a70484-d851-413e-9162-98e7ed824132"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("39209857-5076-4c04-821e-4208b43fed68"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3a7a52cc-73c7-49d7-ac61-d99620519479"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3a7f38b9-92b7-4e79-8bc8-e802f4fa5039"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3aff43b1-bda5-4870-81f3-a12f90b7204f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3bc88a79-d99a-4dfb-bc49-c8032c31a5e4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4181651e-153e-4672-9aa0-a2a9379b979b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("42880685-00de-428e-8e56-56066e6ca91b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("44d5efeb-9660-49aa-b423-a0f0f1d90597"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("451221b5-3810-41a5-ae74-d285880f288d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("482a0ce9-eb50-4a20-9880-c540a04bd5b7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("49aeb048-8e71-4af4-b585-a342d98b4c0d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4b495777-74a4-407f-a3e1-370f0ceabc02"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f4cdf8a-b72d-4f00-9ca9-4cfaad929573"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("51908af1-93c7-44ed-9dc3-17dbe27007ea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("51c40ffc-0d53-4700-8fff-d4a6b66c8074"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("51d0579f-051a-4ec9-873a-90c3d7fc5b82"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("53151470-6d0f-4fb8-923e-e4b33349c4a6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("54459e0a-7a49-4bc8-a12f-c63e7872f573"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("561a4c4b-0030-4524-bae0-f40602bfea35"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5a118fbb-3254-4a5a-8ceb-f12996d1ea4d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5a172148-f91e-451d-8978-53ae325c7877"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("60d7a02e-ccf4-4701-bc8e-52d5125ecc6a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("60f7fd53-304b-4fe8-8e8e-857537ac7687"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6225b289-6fc0-4e7f-aea6-1af7ef0549c2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("62e58ec3-6875-436b-88bc-4bb2b727dbfb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("65f3b7e1-85d6-4612-8617-0d2b84b03738"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6721b9cf-71db-4931-b7e2-af991c61bb04"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("68f8a22b-d3ff-46ce-9a02-243b37dca838"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("690ca943-1141-4c24-8004-0f428629e049"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6adc0ac0-7e4d-458a-ba02-9c4d73fe9922"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6d8ce22c-2b09-4089-8a32-d30caea6a1d4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6ea20f22-0599-494a-9601-4abd54591711"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("703e492d-b954-45cc-9c8c-ef7e6841679b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("70404941-8d0e-452a-b968-07f982384b81"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("711ace10-6c29-4a79-8af9-5b89700bdf96"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71a77220-cc52-4ba0-976b-91d852cf24ce"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("72fc47d8-bb80-4db8-8101-3f90a834f6f9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("755e21fa-1005-49dd-be91-0ea7794d6830"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7757166c-432e-4170-9520-7282325f8461"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("78f34582-4a59-4582-89cb-c508c75e3958"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("79b6b4fe-8c16-4130-a5bf-2a620a918b1c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7a1552de-0ab0-4d85-a05f-be110b9a4aba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7bb56e68-307d-41ed-b838-110d90ced411"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7d4a093f-0bb4-48ca-962c-a603a1c19fee"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7f4369d6-88b5-4a5a-8cb9-26901e3e42be"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7fbfe976-c761-436b-b18b-84f4a0c44833"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("84651477-c645-4045-9840-07de6eded0fb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("847f6056-b3a5-4148-9c8b-1cb7de305c7d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8567dbaf-6bd1-43d4-bec1-bd55cd759362"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("860cd92f-c6ca-44a0-a9d0-4bb489b41d34"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("863dc5f7-1697-4bf4-9627-eb8e3ab14ed0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("86fcf02b-e453-47d2-be43-fae0926da8be"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8914f9ca-9959-4039-8006-287dc9b39619"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("89a654a6-5b0e-4a75-8756-5559e84e21ce"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8aa79a02-3850-451f-9732-e18bcd15f2a6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8bc5d0aa-56a2-4279-a5ce-631eed7d1e58"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8c1f01a3-85f8-4098-90de-8d894309710c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8cc96427-a17e-4443-98d4-625b2c16a8b9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91510f32-de94-49e0-8fef-f1b3311f34ed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("92e99cdd-3de6-4701-8e7a-069997b7c4cc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9428779b-9d0d-4113-a4ae-af09c9bf34e1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9484ca44-38d1-497a-b514-283916dd1ab3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("960f3095-0190-4933-9ad5-f3755f4ae491"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("975654ed-ebbe-43c9-9cd9-80666891ad8a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9857acb1-161d-45cf-b86f-c3f6d63e15d1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("987f2adf-dacb-4b62-b867-7e1f68bf3953"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9b358292-b2e8-4485-af0a-3f7c1b406bf7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9dd7c74e-c24f-4d0c-bd11-635cf29eb4e4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9ea7657d-2626-4c88-a317-9c6cbc8ee8b7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9fc27cf9-3496-449c-be49-ea28e9490e7b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a3809729-f68f-428b-8653-25ee8ee6870b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a3fba45d-c13c-488f-b086-66eb594780f1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a7dd02e0-ee4c-470e-b1fe-08836b6f9f7e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aa3633fa-ee6c-4229-8e04-1d2ab3d99e49"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ad775596-8f3b-44eb-82b2-158cb38b0200"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b0b1849f-1e45-49c3-a9f6-688483aad5a1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b306d69e-bfe0-4266-bdd3-25e2cbe216b5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b6d0d86e-c944-4dc2-b338-da186355fc35"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b6d77806-fefc-4f37-92e4-97c0092811af"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8c9e237-92fb-4f65-922a-05c90c78894d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba1d639f-8d71-4388-b58f-30ca7b5f1e66"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba2a7079-d219-47b6-8477-eb065eebd421"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc499728-61da-400f-a9ff-c7649d29356e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc578718-855f-4c69-babf-860bc8d5c933"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc72a968-d395-4035-ab02-0cabc7de9040"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bccbf091-6cfa-460b-b58c-8680d159477b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c1738630-1079-473c-b1b4-619f707f12f5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c1c4972e-83c0-4055-89e7-c63d9b4aacb9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c2645582-07b9-4d57-9a64-d5911594ecd1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c438abf1-4104-4d72-8304-d64d9c73e0c7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c4814d43-8621-4fdf-9924-d8ccaddf3c87"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c56204cc-7713-4bc8-89f9-043dfd5f9bba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c6b491fa-8c2e-4856-82a3-ea6e268b46d9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cb0df304-1fa3-470a-b05f-e2edd7920e80"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cd7242c2-2f1c-40c7-9248-e668dc127d45"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ce0bcaa9-bc01-4ba0-bcb1-b8a2f27b3369"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cf3bdfc0-cf12-48b8-8d60-f6d9f77bcae2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cf62b8d1-c400-49ed-b309-7a0b6f42d3a3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d370580e-1d6e-4f7e-b436-6c43fa41c627"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d3b9c558-433b-41de-bd2b-2d67895c0759"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d3ecb886-256a-4f2a-886c-01f46ed5a39f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d406ba30-517e-4608-9253-f61c5c9d6c0e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6a6ef10-cead-4da4-b394-9267a5039a46"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6fa6858-0690-42a3-87a7-7a4f6678398b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6fa68fc-1e80-447d-b5a1-f6d16dfb14d8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d78b98e7-26b8-4fb8-92b6-8216d642d8b3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d8296114-34dc-4a26-825f-9b8ca41e08fa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dc1613cb-d868-419f-903e-7fa1120466c2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dda41ff9-09cc-46fa-a82a-133355e396cf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ddf3cd63-be59-4b21-8f2d-faf899fe3766"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("de255be3-f45c-4bea-8486-402178a5f1d1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("de5179a6-564e-4d72-9084-0e09320bb55d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("df533875-5049-4b0f-9849-d29f2c62bd2d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e183d4d5-3fed-46c4-899f-4ad9bcafc9c0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e2839f24-2388-4f4e-92a1-6ccf179dfdf8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e393d8f9-484d-4c28-8d46-10b80dbf445c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e67a2a88-8308-4bf0-ad7e-4fc2a6d072a4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e8797a79-ed1a-487b-b80a-de8211db2340"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e8b99dfe-0f2b-4cfa-bdcf-502e1a00c7a1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e94ab8b8-9f61-4ef4-a751-566470aca200"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ec884bde-dcab-48d1-b70d-9035fa5a4567"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eec2a82c-4397-493b-aa16-9fc726dd29ef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eedda879-e71e-48c6-8469-e6a7e8ea82d2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("efa5f4a0-016a-475f-9ec6-2b7509785bb9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f0615dfa-38c4-4d17-913d-bb0f345eab33"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f0f40d95-76a3-476f-99ee-88df0538c381"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f1fe9048-3f37-4606-9c0d-a0c894a2c961"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f3b6920a-c00d-43fc-bcee-9f42792a4def"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f4c68c7a-c0bb-4dc3-8493-89aeb5577ee2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f567e94e-44df-4e38-a7f3-2cbe16c817f8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f6632c58-41fb-48bf-9f0f-0f9525f70128"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f6aa63c5-1d98-4bfd-b0ac-1041c33e3b6b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f7c022cf-355f-4f47-ac18-1af4684617ee"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f8e57136-cb54-447e-89a0-733d410274b1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fa9dc1b6-fbad-4593-8db2-367a58c8f47b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fc18c236-f70a-4fa8-93ce-aa91e7b04c23"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fce6b2f4-0acd-4bd8-844b-caf4aa4c8cb1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fe375c70-4bdb-4a0e-b2be-f239fee9f248"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fe490b5d-fa4b-4184-a3b9-634d402eff48"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ffacd285-e2e6-4675-8f23-11cb20bc968b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fff19c91-e5b0-4c9d-963f-33232d540829"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00c542c6-5103-4b88-a5ad-a1c7085ecc83"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("012b15f4-8fdc-4560-a2c9-d681a82f0193"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0168a5ef-08ea-48e5-a7b9-f61a0a721039"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("02d02ea9-0241-40b9-9125-3d5b5ecab94f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("03a44249-81ca-47f8-80d0-ef3eb496c6e1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("03cfc178-4057-4320-97db-b04badbb2b47"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("046035af-6812-4776-af3e-96f5f9eb69e5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("048410a1-0dee-4bd0-80e6-30f734c2899a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("048f1b75-a3cc-4d9d-8d1c-9f09edb02ff8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("061cc683-7511-4b3f-ab41-48f28664042e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0621195d-4a7e-4570-a822-958906a196d5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("07077eec-b39d-4218-8464-da0937be6459"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("07ca786a-be55-4ee8-96dd-9c3b9c8818c1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("080d526f-8fb2-4d50-83a6-146c6c2dc699"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("096256df-da4c-4fab-9682-2a74ceda573d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("09828a42-0f87-4cdd-a2a0-ff48afca2d36"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0ac02e0c-b9ac-4926-8ce6-69163c88e7aa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0b2555f1-cf31-4706-a72f-7deb67d34c5f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0cbbe7fe-7739-45e4-b74a-9eef0c0d1c54"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0dd7fa01-f5c4-4efa-9e90-7971a47bbb9c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0e3646b9-07f3-4807-84dd-5ce401ecc3a2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0ed3ffd9-14d3-4edc-be40-799587855334"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0f4860ff-7be5-4558-9a75-1e7d3f129d04"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0f49fdc5-9b74-42d7-a6ec-4a6696eda216"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0fe0776c-fe6e-4094-b57c-3ed704dc453e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11b0768b-0017-4dff-b81c-d6a624cff0c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("124e2454-62b8-4124-b988-6fa1495e5ee2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13b1ec91-35e9-4bab-8195-f1109550ffcb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("17319665-eee5-4df9-98b4-0f54631eda80"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("17ab93a7-571e-4d39-90fe-a28e27fd4dd9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a84014c-e088-41e0-89cb-02c32e527924"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1aea8ffd-2a29-49e6-b773-cccab31eafe3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1b8de86a-b590-4320-a38a-ba3231cd764e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1bfc02af-a0dd-458c-b40c-c4d612eab8dc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c56a551-ca7b-4067-a326-e4e94dc2ed7a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c638e80-5f22-490a-b4bf-3213af682346"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1d64c5da-74ad-4f88-b097-60b04454da81"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e1b6578-f492-4dd3-8884-a6fc0fd5239f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e9d94ec-ebc8-498e-9dff-b8754b68b0fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1f4d765f-71a2-4ef4-b8f5-c08425884601"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1f9ba06b-581b-470c-b47a-22354286257d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("21861fa1-c4c6-4356-9e41-5c6bf81404d1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("21da895f-bf7a-4d5a-93b7-6e6fed2f1b2c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("224171e1-1830-464d-a8fd-79f1500a5677"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22a44a7e-3984-4501-acb9-fb4566f3c7a2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("239a0e9a-d389-4f0e-8d53-b586d097319c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("24c9a35c-2a01-49ce-9268-551ddcde0749"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("24ec270a-ef07-4b57-a297-c34d65257c64"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("26151bca-5ad5-489f-988a-811df8b36739"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2681a6ec-df60-4571-9303-e3ed20c41162"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("26f0cfea-8907-484f-9146-ed57d5b0caf3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("279c804a-e982-43d6-ac4c-c0a8b09f6cf7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("28694b9f-334d-491c-9bbc-c2cf57d2de21"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2935585e-51d1-4007-be4d-b917970f2100"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2ab2a6ac-6979-4484-b2a5-f637de264bec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2b08e143-0ea6-4e97-bc71-f9aa1c6dad78"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2ba43783-8d8f-4daf-887b-eb8231b62790"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2ccdd34c-2480-42f9-a61a-3a6a102125c4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2dde15e1-3e0d-4757-abd9-4489ee2ee0e7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2ecb3cb1-f836-4bbf-bc4b-7124f2fc2f11"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2f361cdc-32ae-4829-83cb-ef2a54323786"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("31ace127-2593-4cb6-a16f-67cc9b80f42f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("32818134-73ff-4388-825c-508f889916d1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3289ef2a-9ee6-42c6-97af-413a06de42db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3369702d-5c62-4807-b374-210c95dc39b9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33b72add-cf21-4276-bce4-63960b39a8cb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33e88d50-d359-4d5f-ba91-9071e3534bb0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("35fa5712-3825-4e9f-95f9-7f08fad6bd94"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("36709e0d-0925-4f2f-8fb7-90ebd20f6436"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("36e89e82-1c3a-4416-af56-549a0e082ae9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("37580de0-b847-4c22-8d04-1b33c5221b1c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("37606adb-e5e8-41eb-aeb7-519909614197"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3a7a5c52-fa80-4518-bd40-ac7d889f3b54"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3cbdbadd-5662-49ca-9892-867c09827f37"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("400283d5-80c4-4a14-99f9-39e868a7311e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40819dd9-0ca2-4a6e-a375-13500407490c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4141cc0a-6cf6-4bc0-a5bd-b34851aa0219"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4216dbe0-7a16-4de5-b44a-d4658a03ef92"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("424a4b59-294f-47ed-82fd-21668b0ba1dc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4411b822-4766-4d93-83d3-2fbd4cbf3447"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44cffeea-fe48-4e1e-8495-7ba561d24a4d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4642c13c-57a3-42f3-9d71-10fb018688b8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("47b1d45e-1512-46cc-b65a-ba5e3047ff07"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("487e6d89-0701-4e0f-92f8-d2f49a300df5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("48efe59a-cedc-4aa7-9613-381b9ebdaa77"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c38286a-857d-49d6-98be-faa21aea0f62"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4e1ac5d2-96da-4889-b546-ce326f34f240"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5121c241-2861-4959-9a3f-afc46964532c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("512ff250-0f61-4dd3-ba61-7b958e57abcc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5177704e-0991-4b36-be44-b85f7f668d22"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("51cbd80d-c8a9-4b48-9453-14a242d50a1e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5423f41a-931d-471b-8195-3923190ffa8e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("54303fb1-448e-4d45-b03e-fb411cae7d79"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("54d4694f-cda3-45f3-93a1-f3b874a50440"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("56ca3e53-5de9-4616-bd7c-e2ea9f761594"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("582aa4c7-f2c6-4b41-b2b9-9f9c8fcd2dc4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("594319fc-c342-4c23-a0e5-eb79e5e9b85c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("59c3f8e4-189b-4831-a58e-140f028bb296"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5a056dca-033c-4201-ae4a-c0b9b59d6afd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5acc5c9e-8187-44e8-a9eb-255d1d791894"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5adf235a-ca24-4a5e-b020-a8f27601303b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5b95ea0b-565c-4b81-938f-63886790a9c2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5caffbe6-ffb0-4354-a5a0-71a19e0a3f43"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5efd4809-86b4-4799-a95a-fb8d8741bcbc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6000e91f-0171-46c5-813d-77e4bd308cad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("60a17cd2-0068-4a7a-ba21-c539fb2d8bb8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("611e920d-ab3c-43de-9bce-af574d7b7ac1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("61f8e206-4876-4b13-aa8e-ff6ddb20cbe9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("62bc7d40-5022-4075-a52d-084686724f2a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("64e6fc26-b655-48ab-9e7b-c397cf8c10f1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6647b167-fd5a-4b0e-9239-92c7ed907c0f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66590172-df68-4333-9378-c368cc4d2a81"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68494d67-f340-427f-bb39-6abcbc12aa25"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68f7ce8a-8aa2-4985-b77a-0227031c7d92"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("695dea51-3b3e-4d77-b6f0-b90d9688866a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69fdd70d-3600-4925-a3a4-e106e0c07dd0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a31cf26-30d1-464d-8d3c-a547a29d4122"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6ba4f73a-00fe-47bb-9f62-f75fc48575ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6c303765-0787-467b-ae23-45d1f9a06a66"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6ca40879-0f22-4426-a78f-9b437bc4943f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6d5f052b-eda9-4dc9-8286-21a9faf6b0b2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6e2b7609-6889-4972-8d58-3f2931431b60"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6e6d5e14-f6f3-4147-a0aa-001f5b0c9e2d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6ea50132-78cc-416d-ae6f-ce850a6f0ea1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("71d5248f-c2b6-4267-8a1e-841ce5cbdc99"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7343e910-a2b4-45de-acf1-acd0353c3038"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("73d90be3-3c63-4512-b67b-77e731a0ccb5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("73f75984-6282-4227-a909-fc2ad37042a6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("74bdb3fb-b0da-4d33-b69d-3c46269876e0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("75483fee-ef85-4314-8b3e-39ae83304a9a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("78cedd86-c186-4cb1-a62e-4060bf64abd4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("78e3f947-92d5-4cdb-a7c8-ccad90097471"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("78fd9778-a249-4d53-ba3e-d753c3454e59"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("79261289-c0c6-4347-9988-ca0cd42b0d76"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7a1d9761-4380-4f8b-acfa-9848a07fadf3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7a3f693c-5efe-412b-a560-83f7d0b3923b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7a8ff436-b460-4bdd-9a69-abcef5eb1926"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7a94189c-b3e0-4ec7-ae39-94e590a86a92"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7aa2fb30-c104-4d2c-8e2c-c7913b315fad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7aa4fe43-4ca2-415d-95d7-3848750ee9d7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7b1ee224-037e-4f56-bb56-7cfe20a257a4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7c198fc5-61f0-40c2-8401-75d91b9d788b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7d02ee28-6cfd-4a8b-8704-8d7e30ff6839"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7d580fd7-1190-4602-b0d0-c7301b8cf631"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7dc8a8d5-780f-4735-8d44-bab69f3d541d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7df84580-c41d-44ee-a524-2a5693d5d25c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7f1f3e30-3bf4-47a5-b8de-c663fcf28d3f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("80173905-e2f1-4465-b00d-7cfe832dbada"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("80515970-727e-4ac4-9cfa-d5be1ab905a8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("80e124cd-e76e-4ab1-b07d-f9086d430272"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("817015a3-380f-4abd-9c03-bcfa6f6abc94"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("82057363-59fa-44db-a16f-9242f94013e3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8563b503-fa49-44d7-a420-40505932b615"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("857494a9-46ab-49e9-8ee9-b7ed9d4dea1d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8720ef8d-fae5-4b67-8daa-4423de3df533"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("88efa80e-827a-42a6-8eef-30a77f58a925"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8a868153-af70-4d8a-bc4d-f3f84c44bd62"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8a9f320c-089a-41aa-a3d3-1a55e045bf54"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8afe9c41-088c-49ef-98b3-c91ea06c5559"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8b9e22b8-0bf0-4e0f-9f30-c19bfb115a19"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8bd368cc-8d3d-49dc-afd5-8e17967f8469"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8d9b04b3-b890-4506-9097-1b0d0373be5a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8dfc0c1d-42b4-45a9-9007-42e48571f8fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f27ffe9-4cbc-4abb-ae1b-69f40b5abb21"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("912dc195-b21c-4084-a5ba-37eb0a89d1e5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("91f2dfd3-99b6-41a9-bf83-58b31b274ec9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("92f50799-6725-471b-8a28-b3fd8b4597fb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("93603793-a1f5-4e4f-8529-3030f1933825"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("93fe14b7-366e-4d4f-aca0-01b7ff450bf3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9406aacc-4365-4c85-b3c2-fbc56bd4353e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96f6afbb-d927-4504-ac3f-9175ee2fb1a4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("978adffe-8f36-422c-b4ee-14ce210f3425"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("98f3f127-8a99-4910-9135-b2a3c8fbea95"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("991d9b7c-9872-40b8-a8c0-6cc453ed73f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9a565397-c380-4cc0-a73d-7a4d2d2fcd77"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9cef72fb-6bcd-4da0-a22d-e785197876b2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9f9d9021-a245-4b0e-8096-f946f741950b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9fa4de80-6dda-49c1-9fdd-656d142e24fa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a1de85ce-8736-43f6-b1a4-adaeeb547287"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a1e69163-90ac-427a-bf05-06bfe3d095ef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a29a49f5-7d0f-47f6-a177-43b8a66369df"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a2fce8d0-7578-4998-ad76-a6e84741cc35"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a36eb3bb-f041-45e7-9a9b-52b7dc373e99"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a63cf530-853a-4f2a-bdd9-7b3283daaea5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6bf8976-4c91-480b-8d0a-6f362578ac97"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a8d77b9a-5a3e-473d-9983-6073d3759bc5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a90e2799-2963-4756-bd4b-0ad48f429ac5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("adfa20de-8e2c-4960-9d4c-0138fcbdcf2e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b0533309-8ebe-4638-b5ab-aad67ebf869c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b0977d5b-366f-4f87-9dbe-e1c9f7909835"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b317d4a5-7ada-4048-82b3-9c9d281424c7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b52a8886-a60f-460d-810b-b354251df7b2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b5d10d6d-4de4-403e-b4f5-a7054cf215f4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b6ec58e8-7f3c-4dc2-b767-a204944804fa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b7dc9482-8a9c-41dd-a291-3fff13ee9365"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b7e8eb2a-015e-40c0-b1ab-f95b5b09dcfa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ba566af1-0d06-4aba-a337-0662a240d6d4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bab3545b-ed47-4a34-9960-f7c0c27c7133"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("baf82b35-e54f-4e9e-98a4-2b0e2b3f84ba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bb58ed63-9f2f-4630-bf7d-f2992eda2402"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bca7f9bd-d19e-42e0-a498-7ea2d6e300ba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bdb52dd7-ec33-4a40-b9ad-8170d623cd33"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bef30e53-427a-4d85-b52a-daf8726354f0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c08085af-c542-4e74-a7bb-bc33f8810c24"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c1326e03-ff13-4dbc-885a-2ecad11dd121"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c2d1566d-41e8-4b35-be3e-1cbcc6b46ba8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c40ec032-52ac-4339-9c08-30139b137395"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c49cc465-7e2f-4224-ae02-4f7cfc830efd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4b60334-50be-49a4-8096-13dac5f6c833"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c784dc89-58e6-4785-8969-4856400f56ac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c7f6b3b8-5925-4f1b-a087-f07b190d4cf7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cad3b226-c49c-4c18-acac-957da4a8da5a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ccd63b13-14ff-4eb6-b3e7-2fce0167e6dd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ce477f52-3754-42d9-9211-c8d73797b205"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ceaeaa31-c409-4671-9a6e-bdd3a8205cb1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cf25cb86-469e-4d76-95f3-8ce65a42ff6a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cfe68f3d-7736-4945-8b81-c41bf2321d2e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d03475e1-b2f5-49ff-822f-6ba578573d95"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d0ce962e-01f0-42f3-aa18-94d1818f9829"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d1e270f9-4e18-4630-9eb9-e1f208398686"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d2066d9c-eafb-4d37-8441-899c98772157"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8e43b71-e0e0-467a-b858-fdde9f229cd6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dbf362dc-7c85-4012-927e-1a86fb307e39"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dc6850da-464d-4c75-b16c-82087dc7b97a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dca865b9-6916-485c-a4ed-279e1750046f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dd6c3ae8-5252-4a87-8cc6-a556a9d41b92"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dd8d364e-ed07-44dc-9d7b-e348854a656a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("de91c537-925f-4973-b86e-a1d0165f081c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("def562f5-16fa-4971-9891-30b8c5a848c3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e02e5fe2-084d-4bbe-b7dc-d8d588f6618e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e08f7343-b75e-476f-b0d0-3ccdf97b3d5b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e24adac0-09a0-4c54-b957-c587d8a26d03"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e28a17f7-c3cf-4fb2-9ad1-6a0a52af8e9d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e5f1e520-4c68-410a-8354-f17882317dbe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e84d677d-44c5-4841-ac1a-855d222f5bf6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e8589512-e9d1-401c-9751-768c1b7c4746"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e979e436-99c7-41d8-bdf2-230529f75a84"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eb7793dd-1214-4e51-9971-04f64262e0bc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ec613242-9a94-46ad-a3e5-eec24bbcff22"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ed4adba4-880d-4c8f-ac0d-9cca6ebd8ace"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ed87c183-2513-4b54-80b3-56c11ea85711"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f1ee9516-3dab-469c-8876-f13cb75b5eba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f28d4490-869c-49e1-ab1a-9cad86be3797"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f362ab47-8093-43c4-a6d1-024849429d31"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f3fe078d-2c6f-4415-8fb5-bb67d33eaa7c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f474cc8a-2788-42b1-aa3c-7c61321bb27b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f482a28a-ab02-4c67-ac8f-c492480277d9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f48926e3-d98d-43cc-b4d0-bde48ee1a53c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f4e03368-c30e-46e9-a2cb-8b413396330a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f4e11711-89ce-4537-ba0f-c5cc9621bf1b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f5c88b2d-3dea-4ce2-b826-824566f41d99"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f722d01c-2efa-4d1a-bc46-5721aeeb437d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f879de98-5057-4ba5-8059-91a59c7dc58b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f9ca5386-4612-4844-97a3-9bd1819f8ce8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa8105b7-3f4a-4c80-97b0-908e5fddef2a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc5e04a0-0161-478e-9548-4230d3dc9272"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fd0cf52b-b7b9-4de5-9a0e-72098dd0cc24"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fe7368d9-7139-4188-987d-98ec9bda8824"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0032e1a1-9827-483f-b5c4-690df498d00f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0306cc70-7a2e-47f2-8b29-ae39c10469be"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("03608ed8-92e0-4bd5-aeca-5b9d6f7f6963"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0364cb2a-d484-4ca4-bc7f-0269dff117a0"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0484f780-e79d-41ca-a684-1864df8f1be4"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("04869701-a774-49ea-85b1-b0106e5ae97d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0663a9e4-886d-4b3a-9fa1-57fcb91dc69c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0853800f-5f9c-433f-839a-9f6ea6ae6864"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("08e28f96-d1f4-4d94-ac44-c00d8a17b093"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("09561552-a669-4e36-b06b-b24efc32e20c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("096ccb7a-f57e-4c8a-95d7-acc897b4f3e3"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("09d01aec-e84f-4a29-a2e0-48c22513edef"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0a3c1630-08b4-4469-9409-a5b593b1ef04"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0ae95470-98b8-4beb-824e-60deeffacb0f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0be28c4d-53d2-4985-84ec-9ad0630f7507"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0d1578ef-e30c-4027-a7c6-a64663c78109"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0d230fc2-9bcc-4260-ba14-42fadd51b4a1"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0d73fc46-1f39-4c91-83b1-794aeaa7a6fb"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0e8fcd11-324e-48c5-a721-0525a8934331"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0ef730c2-bb54-4594-9036-f1007cd3e939"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0f6cb10a-e50d-4b8d-824f-54f8a7f38903"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("10dbba4a-c607-470e-86c4-af869b484108"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("118b377b-d09d-4a59-a8f2-4e149d3a7cd6"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("11b8e861-8ed9-467f-8f4f-c1efe7064030"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("11d0a6f6-1c2d-43b8-9ff9-a9faac9c10f9"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("13548f42-636a-47cc-9820-749718f9caa3"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("1483d2bf-00d0-410a-9434-18942ea4480c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("14901afe-ab99-491b-86f4-15d40fd9514f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("150a58e7-a2c0-4ec2-8085-4a6ac97c8a42"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("1537e3f6-7574-4582-b974-137981422be3"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("15729ad3-1106-41ca-8347-867aa60b824a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("161466e9-4ca1-48a3-a9c1-bcc0433d28db"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("16217467-f89c-4117-95ce-ee565e0687c8"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("16a6e6f7-51af-4f9a-b5df-fbc335656de5"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("17200911-e538-4545-9b62-dd79bacfb277"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("197b780d-8c88-4384-81c0-7d9e9079cd6c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("1b097a10-6f1d-4f5f-9551-112033dd5206"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("1bcc31e4-616f-4042-913a-24e906cd6e68"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("1bea0342-3923-4b8a-aa68-7e1d9abf447f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("1c2f3ed4-d733-46f7-bda7-9aae1defc693"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("1d35677a-46f2-47ea-95f8-469ed98af1e7"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("1ecaf207-574f-4d62-9698-b9604af71d63"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("1f758b75-d01d-40a1-83fd-c9aaaec93a89"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("1fc8e9df-7f43-4ccb-8bec-ef023150bc6d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("20a58ba9-6c77-42ac-9748-7a1a08f68c4c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("20d10716-eb27-4057-afd3-fdddeebc110b"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("21c2e9b3-898a-4ac2-93aa-db736420d18c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("261e9d8f-1605-4436-b886-115e3752c191"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("265e8e24-afd9-4c40-8fb6-95694a975946"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("26606820-77ad-43ad-b170-ba0c54b23b57"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("266addb0-2be7-4a19-aafd-442713397afa"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("26fa527f-fffe-401b-b979-a96aa4b10e31"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("27b04950-2bf5-4a82-933b-bc8f3560f77f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("27cbad4f-ad0f-4b61-930f-1567dc955e4a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("27cd07bc-0cd1-49e9-875c-dcde46ac0358"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("28f2980e-608c-4c4b-bff1-14934b7c4896"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("291f2ee3-ad9a-4947-a795-0f70bd2a074e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("2a853a0b-4e61-4d6e-9234-020c1efa63e0"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("2a9b3630-c805-4be0-9156-3c638f0a6ee5"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("2b97a2d7-a4a2-407e-97dc-92041e835bfa"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("2cba95d9-c50d-4131-a870-69561d6f75b3"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("2e592dcc-f9d1-4bc7-8259-be0ed53562a6"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("2fe907e2-4282-45e0-9446-c775a81533f5"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("31755173-b0a8-4779-a178-213033d58cef"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("329c1dd9-bc8b-4d8d-9d7d-060d81cf202d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("339b397d-9aa1-40e2-a9a6-f28b28d5e5ff"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("33fcbe5a-0161-477b-b72a-df742ccdf74c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("3490b4ed-5ce8-4a5c-a849-9f962fa57530"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("35c2cdd5-3819-4ba9-9763-ee7349cb03df"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("3665cbb4-36f0-4413-93ff-98fa84cb8968"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("37502bf4-dd7b-4aeb-bcb9-136f166d54bb"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("3c7fdf31-51af-40ba-9880-714f35a1a943"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("3cddb538-a725-4d1b-be2c-1110fa2111d7"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("3d282e1e-b2ef-48c8-accf-9c67cee0e8df"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("3d550ea3-177e-445d-9997-6feb7bae5329"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("3dfd9afc-edaa-4976-ad34-c4ea46248b9a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("3e5f38ca-4be5-4a20-94f8-e3eb4d6f8cba"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("3e8d0aad-e517-42e5-8eed-279c4b6bc37c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("407b39e3-1297-4c6c-8deb-ea15cddbcd55"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("425cd297-01c7-4d34-bb83-3a266c4b1cc2"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4453eb09-2a58-43b1-aca8-344a57bb465d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("46ad4204-1ac4-46ad-8a85-a6186fc33341"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("470b5002-1e85-4a1d-95fd-6c95b3fd9264"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("47f75e7b-a7f7-4ce0-a2c2-e8e3c216fa40"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("48235d43-9930-4c98-aecb-88efd3614e57"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4ae01edd-d5b3-4a6c-8657-0842a7173333"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4b59c546-4303-4fed-8c0a-03a619f8fde2"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4bab686f-b843-4c1f-8855-8f79e191b0ad"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4c6fcb42-e354-4b1a-b8e1-99311239fa29"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4f726b8e-4e52-4f72-8ea3-41ea36c1b12e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5092e030-1d8d-4c6f-806a-818ae7dc1215"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("50bd7eec-c9d8-40ce-a8e4-ae4dd2376113"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5201e150-83ca-48d8-b84a-a2940594f9bc"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("547d3ac7-cc57-4085-8726-3818e89a00d2"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("548068e5-d9ba-4e10-b19c-ae566c16d563"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("55ac52a6-fa08-419d-bd28-3de97af78f31"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5626d64e-f20e-4fba-b9c4-4fd6c73b3012"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("567b1de9-4ea0-467f-9846-688e7a604562"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("56ce024e-2af2-4b34-bedb-ea30dd405c08"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("596f670a-752f-4bf8-ac93-224a15012fbb"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("597ae486-beae-4334-b730-fb40e58ef537"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5b0a124b-95fa-4ab6-b48c-a0a8c1a2ccef"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5c3bc75d-3342-4f19-b9d1-3253fbd1cec3"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5e05146f-b1fa-4949-b0b6-f8363ff3bb9f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5e670ce7-7a0d-456c-81e1-1c1eb380bed0"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5eb24e1d-a6ef-47a3-a042-5cd191eca1a6"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5ed64f54-9bcc-4673-8d69-eabdb07003d2"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5f514b03-4905-4291-8281-0007fa287506"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("60a73766-96ef-44cb-8d3c-170fd976359a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("61315754-2ef8-40e8-b029-15b7da15b112"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("621371f3-9f2e-46d9-b0b6-2b95942722b8"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("63a4d70d-86a3-4dec-a6dd-3e4ceb463855"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("643f767e-a5a2-44a7-8502-dc8728556131"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("645bf33f-1d43-4e5c-bbd6-959663a4ddc6"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("65729050-a4ca-4fdb-9156-e08b2211f5d1"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("66c8f9c9-ac72-4a35-bde9-49eb54e698db"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("67944129-15e4-4349-b85a-0d08ee59130d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("67d91738-294e-4a2c-b686-088e3231c4bd"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("680ab800-d5da-4f26-ad86-eafee1d7616a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("680fd838-497b-4b60-841e-1f22fa436dc3"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("688049ad-5911-4dff-bd78-d74a6d3e371e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("68a2d01f-d984-45b5-9125-9be9d111e247"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("699bea92-fdf6-4f74-ad82-7aad77ca7a8f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6a0f9516-df1c-4ea2-aaab-6c5c2ed1d21a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6a265d01-8810-40e1-a8be-95a19432c845"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6ab5a5ac-75ec-40bb-b23e-79228a9dd12c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6abbfcaa-13b7-4b69-a02a-573be067ddcb"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6bfa5f85-6a03-4bab-b5aa-d9075c7d380a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6d5e0934-577f-4fe2-bae2-91bfe93d7d1f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6e4810b9-a611-497b-9a99-c770d52df1de"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6edcd7e3-e8b8-4e02-8a56-1c8b567faf30"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("70022831-94be-4a7d-92f3-d658aaa0acc4"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("72685788-1888-4813-88f9-46aadc9d1b42"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7358ead3-2382-4554-a54f-ccb708392adb"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("73aabdbc-7be9-4b6a-a164-81385af16fe9"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("745d91b9-a5b8-44c4-b780-702cd5785366"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("75c1aba8-ecd8-4e98-b834-867580ae35a6"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7735af9e-da78-4d2b-8b72-b9a48048103f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("791274fb-be73-47cf-9780-8956ebe4c5ca"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("798d97f3-d90a-42ce-994e-f34501704b49"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7a13336e-1de9-4209-a2d7-6f2df9e7d595"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7a958c06-c942-488c-adc2-8e1da84f7bc9"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7a980748-bcca-40aa-8478-b5990333e049"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7b8a33cb-0472-48b4-ad42-69201d8f2c18"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7bab36fd-2a86-409c-971e-9187439b462c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7c07859b-9516-493d-be0e-9c88eebaed1e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7ca7c879-5dc5-4ad2-b9d8-a74f2eaf3f5e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7d093f45-5998-4d26-8f72-ca6cdfc473fd"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7dbf3e2b-8bbb-4f83-84f8-19ffddf8ba7b"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7deabc92-1179-4b2b-b908-477f73cdaf11"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7e09f425-5bf6-45af-95cd-0a55a61f1c40"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7e510a3a-9ac9-4b82-a868-1fcbe3704a82"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7e69f3d7-d018-41a8-ac78-4aa485febfa5"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7e74cde7-3e0a-432a-b0f5-0a18f5ed9cd2"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7eddae9f-9286-495b-8c0f-debe878d07ea"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7f5b1167-c427-41f9-91be-cc311cfafb62"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7f843a65-f36d-4982-be33-f8bdfe052b07"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("80d2e4a5-545c-4ab1-a458-569d45ccc022"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8181e5e6-67d7-46f2-8ce4-f6975e9cb204"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8390bef3-a7b8-43fc-ac61-acd5a55ab3b6"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("84c72ab0-f971-422e-ab27-15b06843abb4"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("84dc49c4-2088-461d-9714-46bca62bd32d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("852b180a-6a85-49f9-9a4d-d82f3343bf1b"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("85be8590-cfd8-4f63-8b9a-d874fe027b6b"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("86007e46-c7b6-4e30-9fc8-55903fe629ea"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("86ee9e2d-2d4f-4a96-8b46-2fd891d0d461"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("877b7f69-7a1c-4d19-b612-83c0c9853845"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("87d4176a-3784-4ada-a12b-a4a0c179003c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("88f8318c-c6a3-410e-8201-9f373be10bd8"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("89141d58-b274-4293-89bc-43637fe34d65"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8a429ee5-c3cb-42b8-a936-7ac1dadf652e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8c678b4b-0967-4a9f-a09c-f1335a301e40"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8db051ca-1281-4eb7-8974-f141a53409d0"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8e0af860-1d6d-4d6e-9246-bd4b01ac7654"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8e3d541f-27ce-4531-8254-03133281e4c1"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8fdf96c3-5a81-43e9-8f21-f5337bf36f31"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("90569cfc-0220-421d-add9-31d469ec7b4c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("922da749-67d4-4af6-a59d-3eae43f26854"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("923da64f-5b9f-4b14-9729-621186788125"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("924e3956-1604-4620-af21-09e9598d4d69"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("9256ea8b-8778-4b03-836c-ff6884728a66"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("92766157-8f58-4b56-b901-b1e198f62c34"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("97b78ce3-151c-43c0-a61a-32453c606d28"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("9852ea3f-d53e-4f9e-b9e2-f865454b2a46"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("98ad25ae-4187-4054-b85a-e18f5e3b7f91"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("9925f4b9-5431-4704-a6b7-bf4283c8a348"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("99429c32-4613-4490-a153-288232efbdc1"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("9957e0d1-96c3-4159-937d-f2e7df48b85b"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("996dc268-b107-4c50-81ea-32deb7f5906f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("9a823b4b-2e5f-4f87-82cc-5be68367f3c3"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("9a8fc26f-1b32-4ebf-92b1-c22a0ab209e5"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("9acfa541-6e15-428a-b047-8f4f9fce12a6"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("9ae63ca1-441c-466f-a060-bc23c447b029"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("9c8dbc92-8862-4fd3-8ec0-ef65e59516d6"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("9e9150af-3704-4ffd-a01e-e8f098bbfb73"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("9eca63c4-8b05-422f-832c-5541ef3abbff"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("9efee708-2a9c-433c-8019-48d1708cb372"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a011c27e-2147-456e-89e4-39100d331111"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a0c7fce9-e0a3-45d6-8731-0e80a906aa63"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a0dec400-b58a-4516-8c69-35b1dad41ccd"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a14806a5-f231-4389-8014-588910e49419"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a1e99d63-2bea-45c7-b958-0ddc23317386"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a23af231-a0af-4904-840b-ef684c84d5a6"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a25de077-8526-4130-8e71-c93c9a117ed2"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a30ed4ab-fb35-446e-8f40-62d5778a5043"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a40fe25c-289e-4439-9d95-ea36ec9ee1e6"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a42ed1e5-a476-4c02-b73b-086668891851"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a4ef26cc-1d87-4659-8478-4ef2e46be114"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a50375a0-97a7-4119-9b36-0e1febfc8ad6"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a592461c-9601-4978-bff5-52247a780a06"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a6b08e8c-f712-4f38-954b-0810baf8c64d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a8329365-2236-4bb3-9c5a-1d179ea17b6f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a955baaa-3a1d-42bf-bdee-70d571f40899"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("aa07f4e2-44eb-4e19-8fe8-088dc8b22363"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ab0397b5-3691-424e-850f-9bc1954de8c1"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("abb20114-7d5c-4ddf-9ac4-70cbc8e9636c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("abb311f9-145a-4f02-9eab-5a45dd467410"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ac4f1ffa-06b8-47b6-aa7d-1e29f4804d91"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ace9b8e9-b48a-4c43-a892-e84f906081a7"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ae2556db-9361-49bf-8996-3b30ecbac2cc"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("af04a87b-ab84-4fa9-a120-6bec3b2b4272"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b096f8ff-2e4a-41c1-9c60-34e8ae214a8b"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b24415aa-ef20-472c-bf91-1beb553b8d5c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b2d90cd4-ad3d-40e7-adfb-443ce406c807"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b54d14f8-8e96-4356-a1bd-92a5b17aa119"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b60ca5be-273f-4622-ac10-bed6b2617014"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b6683482-ccf9-4ac6-99b5-be429ff17105"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b76cc054-0f3e-46b6-9432-be50d7224ee4"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b779d7e4-5123-4d73-be2e-3c9e13b630eb"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b8e19fa4-b8cf-46bc-a64c-13af80aac89c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b9094491-6627-4aee-b55a-a963c691e775"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b947498f-afea-4f6e-805e-dc7c19476375"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b951839d-1718-449a-8f4e-d3066a19bc35"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ba699059-b7a7-4f25-a6aa-493bfaa7d673"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("bb8d4f5d-2d49-491c-b8a8-e7bb7074f57d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("bd2f9ebe-e236-486f-9d1a-c9c321c60ce9"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c0cd2eac-ef6a-4cba-b7cc-32a5c025e573"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c1c58d92-65ea-4425-aa98-3141e4ba6f67"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c32de8a9-07dc-42f1-92a2-dfe7a57199c3"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c3daa4aa-5573-44cf-8366-2e6ce1274e20"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c4344593-9067-4fa8-9ca1-dbd75c646933"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c4af0f09-df5a-46c3-a912-81be0cb82e22"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c64d27e3-e62c-4e2a-8001-79a6447eb134"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c68d2ab8-e1c4-4d33-879f-8b0b09a95f71"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c6b28fb7-ffd5-47ac-8133-ab4f0e5dee9e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c7b6d26f-e3a0-49a2-8619-124bd2d286d4"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c8c05152-9dab-49ee-8892-a1f9e1ba95ad"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c95cfc86-a73b-41fb-9b0e-c28d6af1d92c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c9e9c06c-3059-4246-97f6-60483e7c43cc"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("cb5f9c61-4092-4028-b8d1-de359c47de5f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("cc3760d8-7812-491a-9b00-ec2682e69366"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("cce7033a-8afa-478f-9edb-aaaf50d9e07d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("cd8cb360-864b-4bbc-b9fd-741555e5e886"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("cdc742db-3e6f-4df0-8d6a-0fa30ec2edd8"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ceaaaa40-85cb-40ab-a7d6-9b192cca71f5"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d025213b-a4b4-460c-b220-c4b56fb69892"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d0838780-7cbf-4a6e-968f-155e8b0da5f6"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d1164aa1-5c4c-460e-8bfb-56c7ed2d45dd"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d1625a5e-b0ca-4660-8d0b-4be9dc393790"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d5656eec-6bf6-4583-a7c4-5803a98de97f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d5893ecd-bf79-450a-a0c4-a7ed0e54ccc7"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d5a4f5b4-0913-487d-a09c-eeeeb40ef3f9"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d5c0e4e6-3b9e-4a4a-89f6-edf889d71305"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d6c235ba-1c9d-43cf-a718-287d2184b83e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d74cce4c-e8b6-466b-aaa6-c275de924a87"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d7cf3535-8be9-46b7-be94-9c76fe148ffa"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d8aa8d61-b7c4-468b-a933-aab40a8debf9"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d8de47ed-ff98-4997-b44b-ea515ac67bd0"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("da23ac80-e6f8-4bdf-8e07-e271a78e5468"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("da7ece2d-d6f2-4108-91b0-e00b0034b145"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("db312aa7-7579-42e9-b61d-74e7fe94774f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("db5d1495-33a6-4820-bfc8-508c0a5b7e4c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("db65a7dc-cb84-4270-8c04-fad22813ca2a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("dc0b6ed1-3322-4cdc-93f6-9005b54fc3e9"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("dfed85ab-5fa6-4888-a994-599e55208d2e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e0ae3c7f-c421-41f4-8091-7d4d18a16683"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e1d985b2-e42b-4c0d-9096-f477da44ddb1"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e21e24d8-351d-4152-8fab-ec3b6dab6ebe"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e23df0cd-f5bf-4dd6-81a1-0d145c4803f0"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e2a2186b-cb4d-4517-b9f4-55da286c17db"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e43bec70-46cd-45f4-a22c-d40ddb92a3b1"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e48e016a-ea57-4bb4-a792-2ad61083753d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e5868b49-6ddb-405f-a808-483c2b9243a1"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e5eab42b-e5c5-4151-ac49-0a2a34ffa105"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e65d6969-0881-4f49-b14a-d70d3dedabec"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e68283a6-c380-45ce-8913-04ff741fb99d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e8145c6a-829d-430a-9ef6-87d2825d0b58"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e8301a2a-b55d-4a1c-961b-d00359ab1f77"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e91f09d3-a378-4db9-8c71-f1e02486814d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e9906e7d-2d49-49dc-90b4-8fce60fad44f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e9f96bc2-1cf5-4eb7-b0b8-1d478ffcf572"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ea32e25f-0e5b-4e72-9d15-7a8b8f97a48e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ea956ff3-fd2c-42c9-98e2-234fda2b5617"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ea9fc8dc-8429-4c93-8a4d-0f23cf6566ca"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("eafbfe45-bd61-480e-b442-f50d3109a77d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("eb8b48d1-1344-4c15-93d4-66c5f4cdb564"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ebec2f0f-2f0a-4f6b-b160-2b8c10608177"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ee56a0ed-0ebc-449f-adee-0d287f06b55e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ef2ad63f-b840-4874-af38-d65e2e826dc9"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("efbf6bc9-d3c0-4781-b6c6-44db460c7062"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f019f651-9365-4ce1-9ad1-6de045d0ae71"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f0861cec-b7ef-485a-881e-9ee657a4fa05"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f17810e0-360b-4ed0-85cb-9e50f44f1aa7"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f196b6a9-4547-4ba8-87e5-173d12997b6a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f1988402-7be2-4d2f-afc8-4e5dbcd568a4"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f2d3de7b-72a4-4be1-8012-9bf3a1d05384"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f449f5ce-2f90-42c4-9ec0-31d80f676d72"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f5f4f233-57bc-4297-a435-1c968452f829"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f628248c-4c5e-4149-93cb-26173a744aab"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f62dcef6-cd8f-4d1b-a78d-2509f94c4534"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f71a227d-4775-491e-8bfc-f031a8842c2e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f7376de9-88e9-4802-8ce1-dc3a9693a46a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f87a4771-2228-40fe-930c-67b3f5aa1780"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f9814a05-6553-42a8-8931-a8e4b885f513"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("fa41146d-97cb-446d-9d4c-9105abf75e1e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("fa50e941-4137-401b-93af-8ea22b33ba0a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("fad432c1-4d46-4371-a34c-f370b3817627"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("fae66f35-9b6b-4a0a-ae2a-c38e9786e671"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("fc0889cc-881f-46f5-96b1-88f030351829"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("fc3d27e6-e777-4e81-817e-3a5a8c30bf4d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("fd204683-1678-4380-b0af-4986cd9f0ea1"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("fda901d5-a3aa-459c-84be-677b40a61d7b"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("fddb2b2b-e12a-4ff8-85b7-a0def30c5d23"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("fed644ef-031a-454c-b4d5-f038767c027a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ff8e74cb-0313-490c-8ace-8b3c2c0dddf7"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ff9b4afe-cbfc-46bc-9cf0-b6d013e11641"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ffa94aa3-e381-4ba0-a286-fe757ad03608"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0020781f-b53e-4d1b-9727-9e16607c6438"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("009fb850-0699-4264-921f-b22d19f20cb4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("01460f95-b945-4bb2-8e4e-70ef80f59f07"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0190572c-ab09-4d39-a999-3cc556c2f7b7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("029937be-923a-4694-9ad3-321e4709bb73"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("02b1cabf-4043-4ac7-b858-3887e0587613"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0306ea4e-b54f-45d0-b880-d426fc0c8108"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("031e072f-5a72-4752-ac43-333b9a222060"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("03af47f9-3fe2-4a9d-8e10-d1a6af387666"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("03bc4021-7e14-4dad-88f5-35d5b8b87ad6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("044dd1b6-9db4-4006-b891-3bb3d9069785"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("050850d2-025b-4a6d-b6b7-523cc1aef313"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("059a7df4-76b5-4f1f-a9af-978956d46f75"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("05e00bf9-de4e-4023-9d35-612c07b6e372"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("064ae937-544b-4191-9d8f-89c216c36a44"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("06e935a0-e333-4d9e-88de-acd1d326184f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("06fcef3c-f6d0-447f-b9c9-bf04082175dd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("076faa7b-e8b3-4c7e-8902-4861c7104532"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("08167416-3445-43e0-b2d0-dc17e6bb59b8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0898b046-3505-468b-bea5-162d93b3fce7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0aef3ba8-bc7d-4063-a092-f877dbce4206"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0d448b05-0237-49e2-96c5-42f85d98cf1c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0d5404b1-2a1a-479a-a0df-32f1198c1254"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0d5bcc03-6f3a-4640-8c0e-4c6f5812f554"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ddb6973-0000-4336-9346-77f5760b5e3f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0e550331-3859-44ee-ab97-2f9f8a5faec9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0e913aed-4729-41de-bdcc-71e19921684d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ea547fa-3f23-4cda-ab9d-cf26a7c8a771"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ec34d14-c4c6-484d-aa70-d516d65c1565"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("11594fd8-0a7a-4410-aff8-54220eaf4c5d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("11ef0c55-abaf-4218-8ba8-653ab3355e82"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12096f59-f68f-46f6-a6a4-b4c2a445d851"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("123de458-520c-44bc-9261-5a6d031e354c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12fb19c0-8e0d-49a8-b8a3-702e811b9049"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("13315d68-137d-4d1d-b894-9d21ffc4601a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1348ffc3-4d66-4563-a1b2-bb8a1831cee0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1354620e-1550-4e35-bd47-75d5eea11fcf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("13d0cd2d-38b3-4f2f-a043-e66f133a986d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1437cc5e-f450-4517-80f2-0748cdf756c4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("18754842-5aaf-4d4a-8c8e-c31d1069af44"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("199cdecf-9838-4ed3-bdde-aee81212dd12"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1a578b45-1f53-4331-80c9-cc8230fae85f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1a5a4d34-9f22-4032-844f-466b5bd45faa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1ac10726-692c-4fd9-b788-69e0b6e11314"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1b139120-8834-4cf0-b689-f490a62965e9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1d063fc4-853f-43d1-bafb-9c4168719630"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1d9cf73b-953e-45cc-858b-c6f99dc35956"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1ec16144-8209-496d-a5b8-ba501ed84351"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("20497d4d-c2f0-44d1-8468-b49d81ff0246"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2095057e-2baa-49fb-85c0-92f6bbe987d1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("22de0a8c-bae5-4810-a64a-b20987bff866"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2380914e-4692-4828-a8a1-aa0fe5e74b91"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("23c6f7da-58fe-4102-b550-0166ed5c056e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2472a7b3-f1bf-404e-8596-ed928902eea3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2539224e-0749-4d16-b010-7f51d86cdccc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2678d658-45f1-4da7-a551-4f81bc3378d1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("27177182-4e32-4bee-b51a-b3c42bc23111"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2872cb6a-f6d0-451d-aaa0-ea5f071a5c84"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("290af343-d294-4fd3-869e-919a86dceeb4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("293ab4a1-7e87-427d-a9ff-77e0652a8db8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("29e29242-b491-4caa-a812-ea9017c37f39"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2a81af19-23be-4e51-bf1b-0f4e10ea804b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2b1aab66-0b70-458e-b47f-4c7dd0eabdba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2c1a18f7-fcd8-41ba-bb97-11d61f94aa6a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2cca4ab6-8866-4725-bb9d-ee71c6839189"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2ce9b873-1808-43a7-8e88-6a8c4bf265fe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2d0f8237-db3f-4cb6-b1c8-11c46ffaed62"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2f220fa7-e836-48ac-9283-6df71878e0f1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2f4cad24-bad5-413b-8115-935c345592a9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2f66f436-6082-4806-93b5-25608fb4b29d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2f725460-2cf3-4dfe-8e67-8373ecdbeeab"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2f81f126-078e-4aa5-9a85-4e80bd255e04"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3036fd27-ba3e-4d69-b1ce-2624fdf0b696"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("30b876e0-b15c-4737-bcc4-e8979f94e870"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("323b2542-8b32-4120-86b3-2a2905837e8d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("34857150-7ce3-4dfe-bda6-84da47cdaf6e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("350af6de-dbb9-44fd-b225-a7a78ac44c8b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3579f928-ea2d-4d65-945a-cb009a83fbec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("35e7d68f-d4d8-42dd-b746-2f44b50cae71"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("36557fb5-0a48-4feb-8dfe-699317abcef8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3660271c-3f00-44a2-aec2-6eca7c380fb2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("36e4b0ed-3830-49b3-9441-f59f1f0aeccd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("36ecc915-58bd-4a32-b353-9aa35515a242"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("386d159f-0f4b-4a40-bd0b-539477a76efd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("38d707ed-5b6e-41af-9bda-37aaa9171b2b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("394a1f56-f85b-4b3c-b7f3-e5df94d9db1b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3a6b81ac-a926-4dd4-90bf-82a81104c488"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3b71f71e-82c0-4054-bd3e-c127770ee7ea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3b746024-95c8-41ed-8e9f-8a4aca0260c1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3e5833c4-493b-4d87-bbe5-275569c723a3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3eaf1aa4-138a-4aba-80f1-9917772bb29c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3f1d3ef3-bc5f-4fc3-b0a0-8f918e07d6aa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4131d4f8-a616-4f1f-a656-a405d74eee96"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("424f0d47-2a37-41c3-bdec-d1b0e6b30386"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("42b1e480-e533-4564-a5e4-4255f9c3bf62"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("43089309-0f9e-462e-ad47-0caa3caca915"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("43e5c99b-b2e6-49ef-a1d5-96f3d6bceeeb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("471eca15-1cb1-4792-b923-c34b2333de9f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("47399163-8c9e-4e28-bb7b-932185d6a2e4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("473e8f3c-dd0f-4e2d-9733-2d92f1ebfe5e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("47c7b904-b21b-4586-8008-911695e389da"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("484ed8df-d6f6-4eda-97dd-b6301d08d91d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("497feee4-fd48-46ef-ae2c-311e08aac145"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4b508211-1697-4f53-a6de-f82c6b17045b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d8bef4a-ecee-41b0-9607-09561e92a4da"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4ea72b89-0913-42f3-a204-33767394a377"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("509904cf-faf6-4565-87c6-20ffdb58fe52"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("50b20d81-82c7-4234-b388-b08e266b651d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("51a3c7e5-498a-434a-a9bf-c2f468519fa0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5297ddc6-318e-4517-a0e8-f1e21b7a30e5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("52b71efb-d5de-4f96-aeaa-61e049fc0f7c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("537ba2e2-4e8c-4c18-b690-6458f1fd2888"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5383a442-70f3-42eb-be86-fb34b3c71165"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("53944f4c-6a30-4d31-9022-8670093cb391"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("54101940-afb4-42bc-b58e-4d5472166e66"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("544224be-ceb5-4e68-9d6a-d5664bab93a9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5492296a-a686-4a30-8f24-00e8a3347f0a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("54f01df3-7e27-41d9-8499-a609c37e9b05"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5519d399-7df8-4326-9eb7-72572ac3edad"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5617304c-f5fc-4e4a-9b5e-af1bffda1a91"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("56f06277-f6b5-4116-b36a-efa36fdda76b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("58ff520b-f23b-4d88-b5fe-d43e9a0e0eb4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5adbc56d-7a64-4484-a417-0f45206c1420"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5c2a8a58-dd21-4324-996c-4b3e9db62513"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5d1c7888-b678-4aff-b3dd-18187b237503"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5e240019-3a8c-4a7f-a0f3-6f9d23d339f4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5ef14a0e-448d-4122-8ee2-60bf587b3988"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5f2ea04a-aff9-4dca-b1ab-bdf2becc26d9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5f79c598-ac0a-4fc5-8bdf-cf9a23022ea9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5fcb4bdf-bf4a-4681-836c-327c70dd4397"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("60c94ee1-00e7-40b9-9600-5dd0cc64ec59"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("60f86a4f-2730-4a7a-87a9-4e17e93f954f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("61c97d8f-b542-405d-954b-44da6f5e0be8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("61cc6b34-3205-4c29-870a-20a073ef978e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6357e80c-ea90-431b-b78e-2fdd8dde8980"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("63796282-dedb-4ea8-b1b4-33f5389d6b74"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("645cd611-ab6a-4502-8ba0-b9569f650abb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("64a2d486-eb0c-45eb-8544-ccd274e08700"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("64ba790c-055e-4b66-b11f-777648f39cf3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("64f4c5fe-8396-48d8-bdfe-8aafeb897cc9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("65481b48-77ae-40b0-a052-9ef06984c4be"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("657149ca-51b9-4cbe-bf46-1209dfc461bb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6600d780-37a0-4b59-8b8a-bac6187bafe0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("675dd608-4e3c-423a-af50-c991de0d3852"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("67b8b0cf-6911-48e2-ac8d-d134bb1905c5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6823ef2c-6f0b-415e-9874-7823ceedccd0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("68a0c05e-2ce2-49f5-81d5-19e6ed143179"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("68d6cbd3-9937-4018-91dd-e2624ab59259"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("69a09359-aff7-4407-808f-d3f4530af6fa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6a0d814f-b28e-45be-b80b-233f0d199c5f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c06fcdc-7d64-4294-8220-685c8c14105b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c7768b8-f94d-4773-ac22-18ffbef818e7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6d25d25a-5394-4c6c-9d27-3812bab252da"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6e0b75a2-ddd7-4b31-a8b0-1237eeaf8902"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6e4319b4-135c-422a-8369-a86c38b501b4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6e709700-9ee3-4df8-a627-190d06c0820e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("70a74d1b-215a-4979-861c-452af293773a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("70b0378f-48d0-4e1c-bee7-674f11b8f878"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("72551552-9343-4ec0-9d28-7b3850030eaf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("72b1c161-1c5c-41ee-a83a-2d96c70cfc06"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("72e3e645-dbf6-4ae0-9f76-83f108567f3b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("739ada7c-92af-4e0f-b483-f3fe14ce315e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("76e97616-1e4f-47b1-ab17-713a78b29511"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("77e2de50-83bf-42a2-a482-f78b5b52ca5b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("783b4c9b-85be-48d7-8351-a596c19071d1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7cb73ef5-0ab8-454c-b257-02769add8105"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7d6308fd-5315-4091-af29-0b949243cfe6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7dc3fd23-8ded-4cc2-9c8d-bb05a18fbe0c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7dee21b2-761a-4cfd-8a74-9240de6106d9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e599d1a-7de6-4ace-80da-7c788f6c1399"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("800645fe-635d-4bb5-894b-0f790c948366"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("814e7d7d-6b27-45bb-b24d-7fdcfa2b8010"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("81a8ef5f-d21d-49ec-9ffc-8a5a60955103"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("821a828c-89e6-48c1-952a-b269712f4a80"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("82cbd461-0807-462a-b913-99b8a7527d11"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("82df3add-8831-47ab-b38e-ef0ac8857ab3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("839b4492-10b1-4e6a-9915-1850cf79eec4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("842582cb-065a-44c0-9ca1-76d4468c4cd4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("84c01664-4105-444e-a124-fc8b5bb03109"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("857aa3c0-f8d7-40fc-a918-ddf2ba237794"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8687bf1e-1f8b-4fb6-b406-f1c95e4c7cbb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("86928647-7a09-4acd-a9ff-f10f7d836036"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("872849c1-d0a4-41d0-806e-6fa8b702e565"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("874bf8ab-ec5f-4bdc-8812-bb59ac22a9e8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("874e26c5-3f38-4a03-a1ea-10e62e420f98"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("87b5396a-6746-4520-ba0f-b7a551476ef6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("88235e43-5d31-4249-b292-a84dc5d35245"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("88a16f79-6088-48bd-a5e1-b0d18c42bfc3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("89bc1793-cfd1-4acd-aab5-4ebcc6d11163"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8adf2c90-6b21-4974-8229-68e16ff23a1d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8aefdf4d-c49b-4e37-8861-9c1666dd9c8e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8b525917-db38-4f4b-ba04-482fa105a571"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8e1a20df-3e16-41bf-8f87-2c65ed6938bf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8e29c650-65e9-4409-aa9d-bc8cf8e85d2c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8e61f76f-d269-4859-a989-122b59a5aaf7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8e6de47c-317d-4f39-b055-dc1eff7d2680"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8e8d00f6-c787-48f0-bcac-0670988815ac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8ff26872-66a6-48de-90b8-3653f29e6e4e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("90354f46-a58c-4dbf-8cd5-f512df8e16c0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9048b505-4dcc-4613-99be-fc28db50aeaa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("917b6331-12c4-45c0-9928-cc494209e8e6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("921d61c3-4a00-4e36-a3c3-c6da7a25b1dd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("927a0c9b-4abb-4805-8353-b876afd4c9ec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9283bc94-0644-4756-902d-f715e384ff57"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("949ba657-8837-443f-bd4a-5654bbfe0cf2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9606fc25-e2c5-4ba8-b251-ffa21ed977c7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9709c4d7-b199-47f6-897e-b0307cc53973"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9846e117-f6ec-488f-831d-080be659a1ee"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a18260a-837b-4d46-b493-e8e816f1928b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9bdb5036-a20e-42b6-88d9-fbaf7d7859cf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9c5d2efb-8525-4943-8b9b-b9574392af5a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9d194863-868e-4563-a703-783885908cbf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9d4250e0-7d0a-47ca-89c0-240fbbb65b5f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9d58a037-809f-407d-8f22-cbe7dad70866"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9d5c3935-5ff9-44ba-88dc-368963e30c96"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9d93cbc8-265c-40f3-a735-08b4045c8bfa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9e67bea1-826e-4459-832c-64607f68f71e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9f2e927c-70c3-4de9-afb7-02f62aad3643"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9f61af47-11cd-4c84-ae19-7853ba7b07fb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0672440-467a-48ef-af8c-d2e8c5f57e55"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a1a737bb-565c-4136-beca-11d282c7cf4a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a1c642be-46ea-493f-8c5b-f94aa7cd3abc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a2ee40dd-5f6b-482b-be0b-83ae8101c978"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a2fca00f-cc27-4900-b711-acdd50c0b830"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a4632387-cce0-4bd7-a10f-53115a35f3b4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a4d3b7c4-85ed-4942-aa05-2a8016bfb624"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a52ec61e-329c-4724-b9b9-4c200593f8b0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a60afbfd-fc80-4470-8101-4624eda20c6a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a6e40f92-c7eb-414f-bf2b-b6f946b108fd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a74aa544-9c93-4692-8019-4a596f2ee891"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aa707f39-f14f-4893-8a8e-5df77195fbbb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("abc71b76-91ef-4e27-96be-09f30d0c20ba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("af2e6f21-f268-43ac-9ed5-4c9e49d723b9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("afdaa389-cb13-42c2-9aad-6bf5f85c7b4c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b0aaefc3-61eb-4c58-9a70-c0cca1bda4f8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b0dd70a3-f10c-4d98-ba0e-26cb6bee2765"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b17b495d-10bf-4587-a1bf-0042d6af21af"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b23cfb10-60dc-4ea8-a773-a36c0823faec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b3948c74-a4aa-4570-91d0-c857dc5b0e61"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b4cd5f5a-a7cf-46c2-9a6d-d552df3016cc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b51b48f7-7307-479c-85c5-5fc12b9635b6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b52c6b10-09c0-4e1b-9ee0-faae0b78bd1f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b83fc760-4c05-4a63-831f-a7fb336c78ac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b86ced3e-c40c-44cf-99dc-96d11f768653"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b96ba429-8209-4145-867e-be4a076d9cd3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba185299-ec9d-4300-b4ad-b298563bdcb9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba189dd7-ac3c-4ead-9ac6-6761a7e7300d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc33db74-2cbd-40fc-a06a-7f02297e3fd2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bcdfc289-44c2-43a7-8507-8a333ab5032d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("be96d1da-6d28-478e-8256-901202e003f2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bee83221-7987-4de6-82c3-61d0f47f6f0d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("befd94ac-c3c7-4c29-aa06-dd2ec87ea669"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0168984-95eb-4b47-b3d2-11c7a3467675"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0842b7b-a8d0-477e-9bd5-7414e9b94b7a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c104ba02-fd26-4c18-b74d-d97c9a0f9008"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c2020219-e750-4583-8fe9-6c2710e0e4b7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c23dfa22-567a-448f-8277-d9cc03c16845"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c2620d90-0cd5-4697-ae28-928347ed4d9c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c2c03071-bca3-4c11-bd9c-99a4eed43eb8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c35b14ba-1dbf-4d8f-8d3d-b6f3e2b1a8b9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c39e9753-a07d-4e1f-8a9f-d6a394826a26"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c40194e5-7aed-4b22-86df-31caf05a4f1e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c5fb3cf3-2b62-4fa3-9a7d-85bfb944a6c5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c812267e-e166-4cf8-99e5-9af7553c30a8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c8c181e2-08b4-4230-8626-bd98ba652ac1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c9741562-b3fe-4114-a0a7-1a0ac245e202"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cbef3c56-4052-416f-99bf-9ce1ed23eeb4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cbfbc2d7-34e0-4fd1-ba90-5b9ee816eb5f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cdb2a69e-c9d4-4db3-9508-107452832e4b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cdd54da3-eb0a-4e04-b05c-083b4e8eae31"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cfe7bbfe-8e8e-4e6f-965e-9c7134c15da2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d08a5fe7-4cad-4ae1-9195-fb8f7d88f59a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d3151eca-6078-449b-92ef-63c365450eb7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d38ed64a-419e-4aae-86d5-615a3a0b86aa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d3ec242c-3f43-4742-93c2-1cedb80f4328"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d4504d54-6313-4c90-86bd-36ace24b2b41"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d493e392-3386-4f97-82a9-35a23acde939"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d619532e-d86b-494a-ae8f-163d7fdac0fb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d91629ee-b000-4c2f-b106-0a4eadd13da4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dacc8a3d-850f-4c2d-aca6-437b8ce03f16"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dede6d29-a84e-4f0d-887e-6fabc3336091"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("def3dbd6-8e09-4f35-b663-27eb188b08c1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e1452ecb-4988-4813-8240-8e30f7a78b1e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e14551e6-65c3-4bc0-9f1b-fb95cb51944b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e1ae4d3a-758b-45bd-9c5a-e08cf6aeb6d4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e1c88c1e-5998-4f10-9750-9ff52d7acff4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e1dadb60-6621-4ac0-9ce5-8f6b01376cba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e492fd43-8c8e-452a-997b-d0e1346f5e19"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e499d2a3-662e-47c9-abef-81d8ab1e68e9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e4cf3c91-d77c-4567-831d-ef2863dc693d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e546b9af-64b0-4df4-bcd3-0f7715926432"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e60b3413-bcc4-43d5-aaf9-b2d6ee1caaa8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e660657d-a09b-42f7-b86b-36784fcaa2fa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e7f8375b-d116-415e-a751-d445627b1ae8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e92f4032-33e9-47e4-bf3c-351d86a2951c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e98ac0bb-4fb9-4d82-a0aa-7ebe92fea288"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e9ee6ae5-af97-4022-96d4-71cc1a34f9d9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eba69462-4537-4f23-bbf9-13b3a9edf6c9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ebf426b1-b663-4904-8c25-708bf7b21e80"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ec22bb68-a40e-4489-b61e-b5d586cf2ed7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ed37f1e7-6ad3-43a7-b0a5-4c07332da528"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("edf62bb5-3f24-4c07-b181-dff0c0597e85"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eebd387d-1b9f-469d-8401-0363317d81a2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ef910380-3472-4298-b0fa-ca8fa813892e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f14879dc-2c55-44a7-87cd-83380e16b4c4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f1ad78a1-9698-48c0-8b53-84147484e6a9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f262f894-47e0-4965-bc16-378b5fb166e3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f33d0d3d-4808-4eec-8701-46a0673cdd04"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f378869b-158d-4073-b78e-cc9b40b174db"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f41f3eee-4c05-4bd2-86df-c448e0214d54"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f5535247-bac5-485f-9a46-4dbc9c359a4c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f656320d-154d-4a6a-8dcc-4bf57214bf37"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f6d40b65-31c3-49b1-823b-0cf1263d04a9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f75b2482-5780-4ba5-a15d-e625ad47851d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f7a7e0d9-dd9e-4c01-829b-c00f7409c3ae"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f9e4f18e-5ac4-4520-bfb5-f1ccb63bbf94"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fb4d01b2-5d8d-4cbc-97a7-075f88d63189"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fb6d61fb-893a-491c-94bd-9166ec315350"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fd3c408c-6218-43e8-b0d7-833830d94a1e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fe4224a9-d47f-49d3-b63e-f7a9e22fd144"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fea80d5d-0435-4bcb-8581-f2cef0ba0bbb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fec38e22-31d0-4822-b05e-61210b5b9f45"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("01302dc1-dc2a-428a-972b-2e577e969328"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0276138c-2bf3-4896-87d9-6dc15c4d4c59"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("043672a4-e4f6-4867-8c45-915784f489c2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("064bc469-6646-4a69-9a79-ed3a2f2f63a0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("067c01d4-9e11-4ee5-8737-67243f6c35fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("08af178e-1865-49ff-ab7c-5095abe8e2cf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("08d4fb8f-dcac-48e2-8c00-827d81f18593"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0a3ee9be-b9f0-465c-b9cf-46974a2da0dd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0ab2f248-ddc9-4e5a-aa6a-1a9d6c50aab9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0b0e7f66-7dc0-4d50-80d5-0eefcab918cb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0b592e8e-0184-4dec-83b6-dde70709abf3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0b6056fa-3bf0-46a3-adb4-db0c3812c19f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0b8e143d-8288-4a3f-b074-1a7d17f66aa9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0c26392d-30b7-42cc-8eb5-0780dfdc5b51"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0caa8135-c46f-4c5b-b19c-99288b58aa64"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0df669f7-1e1a-45c3-b1db-49a8828d8dbd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0f3b2512-e952-40e6-86cf-bb6943474337"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0f528f4d-1f92-4ea1-ba04-1888e59ae189"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("10576b9a-3bb0-4e53-b87a-10e1c92294f7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11c50dc3-fb1a-40b7-b0d0-a53f191019fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11c96990-c470-4f15-a522-e34365574d87"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13133674-565e-412c-b73a-827066dd8db1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13cc36ad-a529-431d-b772-c2848a22edc9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("14409857-3513-4e48-a05b-17f6640b5d79"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("14fa6844-2d13-44b9-baae-7b4b7609e98f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("15319334-a0c5-4c62-86d0-f1d53bff3489"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("161e98b2-542f-4007-ae60-f97413fcf414"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("16ceb7fd-0567-48e5-a113-f4eb2d03a95f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("19df6af6-edc9-41eb-9780-c9673a802646"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a337000-86fb-41ee-b1bb-d86055e93289"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1b11aed1-7564-4fab-bec0-cc39d0673529"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22ca813b-27c4-4049-abc4-a33109557412"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2360aefc-d15f-4422-93ee-afdb0ae5347d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("239cebd3-9967-434b-8d53-3867f492cd02"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("23feb8af-3f7b-4a14-a10a-98cf431206f4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("24a31b98-245c-41c6-9acf-936c57032173"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("25609b04-0c2b-43f2-9783-826a59c477ea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("270ecddf-9907-42fc-bc9b-942d0cc12307"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("27305457-fab8-4739-a81e-85072c3ad7bc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("27645926-9873-46dc-8e61-766f60eb1286"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("27fcdc89-c1eb-4dd0-bf83-09635f277250"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("280ded32-b1e1-4bb2-94b3-9311728d75d4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("28a78bc0-9e79-4915-8e06-45c7f5a6d224"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2bb458c1-b318-497a-a83c-16b271b6542b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2bd769d5-4c31-4a7d-9cd4-3834cc0f4361"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2bd8a20b-5e13-4419-aa97-ddb7e61426aa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2c3a7308-923e-4d08-97cd-c9a7484caf4d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2ce0809f-ad99-46ab-bf53-75db24355ce8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2ebab0ca-259f-4e1a-a4b6-cee82119042e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("30299db5-4efe-4c3f-ab8f-9f09dfdd5df1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("310e1e36-f647-43fb-8ce4-c209745cd7c7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("315df441-a3c9-490f-a3c0-1f32b7706489"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3256fdfd-5743-4dd4-a1a6-2c5bd6cc243d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("325a9cfc-4ec9-493a-927a-482a59fca9ae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33e05925-26de-4aa2-8994-329bde50ff3f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("34091a99-ee0e-41a7-a57a-8a9a869bb98e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("34916f83-236e-49bb-94c9-cea28a98de51"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("37276f2c-1c2a-4859-8854-901994ca2d76"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("37e4c027-05c0-40a6-a02a-618d6235ffbf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("381e24e5-246d-4575-a700-f3d6efaf21e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("38ed128d-b387-4de0-bb3a-94f7863bf3f7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3e22768c-6406-47fc-8a17-a0a7cbbed4dc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3f3c903e-3714-4166-a387-7f304e0a3c8b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40e0ae9f-1a18-4154-8f4b-70b5878172c3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40efd470-424b-4350-8707-5d578781dd06"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4167327d-35e9-4a70-ab17-d0e2d12e942d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4356f819-7b05-46c4-a1c9-1ad732249578"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("438435e4-c95f-4ce1-bdea-fa96c9f87cc3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("43e22ca0-5605-473a-8c99-a45163055822"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("45a2ef44-f22d-4855-bfc6-4ee2f9f7957b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("46f5e919-5c62-438d-9927-260692546c9b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("47421fcf-1cef-4ef2-8a6c-d812e1f602f0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4a4cfe83-1c6f-43b6-8485-9b8d1ca67e2e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4adbd9bc-fa68-4841-ad03-986240d45f0f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4b39b859-e0d9-4d87-b716-bbfc671ddd1a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4e932225-47d8-40ce-983a-14aecc162f57"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4eb4192b-0a3d-4172-9e03-89f885ee593b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4f32fe31-594f-4011-a37f-27fd60782446"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4ffbf040-7025-4328-a8ed-8d7623b22242"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("51fa8db9-d3af-4c88-a2da-cd1f9c8be74e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("520c7cad-8f02-40a1-9435-f7383f3c54a2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5217998b-75f3-47f2-8933-62dc3850a087"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("53153af0-6c5f-4250-9fc1-1d2dae771d66"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("546813a7-cc39-48dc-a117-0ba86c9dd603"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("547343a6-8c28-4fe3-a9c5-82e127045e01"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("560e5175-fb95-4da9-a517-dc5c1a1e0b14"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("56dd5f94-c828-4539-a379-635fe6fbe426"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5756b256-d33b-4d26-aa85-4fabe4cb3a65"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("575f2607-46d8-4663-9475-a8ade8af764c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("57ac33f0-8833-4edf-a823-ff62125a6c36"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5a31fe0a-1cd4-4773-9f72-59dbf812e63b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5c0c2ec7-1b62-4194-9d80-c190a31a9968"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5c83883f-fad2-4805-aadc-6d2f79b7ee11"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5e0ea6cd-600c-49a7-906b-cf1300c03b4c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5ef45dcf-8d22-4396-8ef3-37716541bf1e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5f28454b-2865-4b85-bde0-7a5611ba866d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("60ad00c5-2e6c-4726-9ea7-0f5a99ab75bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("61830f27-8cbc-4e1c-894e-881227c41830"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("624d489a-fe2a-4584-b243-6ce635ebeac8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6255786c-52cd-491a-8abb-285230889f18"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("626210e2-6312-4a25-acff-91a4f45e91c0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("628fe593-8138-47e2-b1c3-0b915eac2137"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69d4f607-c460-4536-8a8a-6c836dea239f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69ec5027-57e0-4a29-852a-86022a5c9cf5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6ad107d8-dbb8-4082-a022-c925c419453d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6ba93423-76bb-4395-bba9-28f0f52eaa74"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6ba9a6d3-c83a-4e39-988a-10de04cf4b13"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6c62a6c1-8ca6-4be5-b2f3-17d2c87eda17"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6fa6ab12-9707-43a6-8d03-fb8e93a265e0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7227f69d-62ae-4334-91bd-82960ec7c632"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("750b2161-5c82-4ea8-86ba-fe58bada2674"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7549cfb3-a7bf-4d2f-9301-c4e8597bc75d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("76e8098d-386f-4107-9f16-2888b3b9d930"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("770952fc-e3fe-475d-ab06-730f7d350d2f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("773edfdc-d001-46b4-a5cc-dfed84707368"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("776cca4a-2f9d-48c2-9d60-1914176d394d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("77d5add7-0fa4-4c4e-b562-367eb6c81b60"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("77f5f949-25e4-4fc6-abe1-58ad13d0f628"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("78ada214-9bc8-4288-8757-bb09cda077ee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("794cbe13-c030-4f5e-b9c0-02f442d390d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("796c6eb7-721c-4bfa-a2f0-99959639ce3b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("798ebad5-68ef-4fa2-9d3f-68dd0beee7e9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("79e7e48b-5ee2-4309-a334-6736018c72b3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7a0b563e-b69b-4e3b-8e6c-2a8061d605fa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7dbc8dc2-3dae-4c00-ba75-fa59107867fc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("80e2ed4e-1929-447d-bf94-7dd04cf7e013"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("82054875-1487-4285-853a-baf6981c6e94"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("82072524-5a57-4b6e-9fd6-4bc8845bafc7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("82fdf04b-b9a1-459d-856e-4f0fa117d309"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8347ec76-a6a0-4e66-a300-53bbc9162481"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("84f16bdb-6474-4c14-b425-11cac1a565ed"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("859d5504-acfb-42f4-944a-1ff0961dfa4b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8627c89d-8f75-48c8-93a1-8e994182a468"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("86287960-5440-4ad7-aacb-b301fcd5d399"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("869d6342-d0d1-49f7-9a37-8f9844b41eda"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("87149a1a-02e6-48af-9a18-fa3e00200bb9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("88ed3d09-93e1-4756-841a-17e090fcdb69"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8972d367-079c-47c0-b869-c2ae9bb421e4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8a0a8d04-c577-4c94-8dbb-0c6f023ddef2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8c580832-6410-4d5a-9209-a751967490a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8d14db5d-ba62-4091-a8d8-0a438f714a2e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("90eeeb9e-3e6e-45ea-a604-b2c4a4f120c7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("915a1175-d5a2-4afc-a399-939d8a9906d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("930ade73-635c-4623-bec6-11604ea6807e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("94a9ee10-f86b-49af-982e-8b4cfe8b3d9a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("94ffc259-6ddd-4f60-8f2a-53e0ef66e1d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("959a46c6-1291-4f0b-86b8-6e43e83b00d7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96bd62c7-b5be-46ac-adeb-71c5b953c0c7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9761bd7c-0c33-4699-a195-123d0475e5c9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("97702012-7129-4edd-8647-6e8382a06ecf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("97e09b26-a152-4d85-9c12-c3d35feeb2f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9a7deed9-68f3-444b-a4dc-90368af3e152"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a189e998-c4c7-4581-a08b-2e7c692e8379"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a3247dc7-f54b-4c43-82d0-94d497dfc13f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a50fc310-be58-4cc0-9d25-e8d01a7d3597"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a52f9180-9cae-4181-a61c-37921a6079c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a54477d3-cc3f-4ef9-9be7-bbc1244dfc11"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6040bb0-4731-416e-a69d-37be395a80eb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a7a3264c-773f-4b86-9b6b-a8a241f949dd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a91df8a2-2d76-4ea9-9b83-580010e85389"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a9532690-b916-4d02-aed7-959843a383e9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aa0ad64c-2850-4a5f-924c-92ef5cbaa288"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("acc9eada-482a-4301-98dc-46eb0ce4f005"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("acceb5b0-5719-4452-9c76-41441aeb8584"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ad75f22f-6b6e-4b21-a0cb-3a76cdfb3834"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ae5e6752-463f-4417-8a40-efa5c2acc165"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b09599d0-57a0-4564-9b0c-ce43007f21b9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b13735c2-689e-4b5f-ba8a-c86b15521f78"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b14267d4-ba1c-48c2-a748-738a8dd657b3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b15b0e6f-9209-4468-95a8-57fe50f5b333"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b1afc628-d4bb-4ab2-9fc9-e2614d4045c3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b2089c41-3fbe-4d5d-9d82-4c696d4bd7a7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b304990a-bf3a-49a9-95f7-3fe465781048"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b31696da-7aaa-4940-bf34-a49c5c7466bc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b36098e1-99a9-47a1-a075-5bce1d58b630"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b3a84ddc-31da-43dd-8653-3fd366df9e81"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b5b33e40-0c7b-4e9a-b18e-22de587ea633"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b64ecebf-c3cf-4f38-b1cc-946783de86d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b70a11ab-ab36-4a6c-bb5f-50a139b022ab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b8096541-0e6c-48d0-ad33-09d6030ddbe3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b95ab0ab-6cf5-4931-bb76-7910e5a2ea52"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ba42f5f2-d7b5-48b4-bfea-fdf2d7649f2a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bbcf7301-ea1f-4ded-b978-0c4c23e48014"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bfdc28a5-ce3c-4bfd-a401-2e328159dcb9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c17b1b40-385f-4b13-8a59-8023223e7490"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c25cb24d-824c-4cab-af63-b823f28b2770"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c2989889-eb8e-49f4-ba26-8b1b28737b17"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c5d06c5a-c561-4034-b942-939fa71d1016"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c622bb5c-7770-4db5-ae86-187a9de403a6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c68a2f4d-e696-4469-96cb-05f67e35baf5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c8bcd758-d56d-4af2-8d6d-9244d9e00e4b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c9ab0657-1d13-45de-8303-65627d320eaa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cca29ecc-f27d-4cf2-bff6-12300e28f295"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d07b5d3d-8485-44cf-919c-2328838983f9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d2c4ce5a-9d27-4593-9e0f-7d6842f0e930"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d2ecdc85-a658-4fde-8cfb-bcbc2d89545c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d32193f2-6eb3-4c0a-8ad7-4a1c0d0a3f96"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d45b450a-0c6c-4975-88c4-ce2fe5ef95af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d6cb008b-7714-44ca-ad3e-23b47cba6645"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8020b65-bef1-4049-9921-cef79cbb5cdd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8343ae4-ab2f-46c7-bb98-69ac7dc58aed"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d83fd3af-01b1-4e09-84b3-e2c25cef4476"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d868e8e4-1fb5-4757-aa2f-bc7e67cf5adc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d95f5558-a372-49b0-bfe0-b5d24a034ef7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d9caefbb-4405-489a-8158-f4f6f1ccef0c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("daeccf70-a7dc-49b3-89a7-6d40e34537f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("db3cdd11-b75f-4b8b-af34-8181e865b2d8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dc1e2b7c-06cc-4428-b1aa-78006d639488"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("deb83f23-2b32-4e55-9e58-7815346d9465"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dec293a8-ddc1-434a-941e-0e55137d6e25"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dfc4301d-1c42-4c0d-b034-6e7400c89e3b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e18e716c-7845-4b7d-8e90-604d987b0157"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e2c63be9-4a75-4b1b-acbf-77c6893fc569"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e499e88f-c288-445f-80ed-a42fe4dd49ac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e68ffcc4-4e79-4edc-923a-99f84f1beef5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e77747b4-9625-419a-abfa-36565c15162d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e78d5a8f-4c1f-4d2b-bd0c-9e1f6edb31c9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e84a35bb-b268-4ea9-a53a-1333d4ac8c0b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e8fe5f0e-6f22-4c86-8154-fc6481ff02a4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e9772e94-927c-4b7a-a2d4-06ee76bf45ca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ea1bcfbc-c897-43ef-b698-d39ef0c77450"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ec86b382-2eff-4365-b78d-b441145a9a77"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ec8b2c67-f67d-4b60-a5db-3f30cb2bb7ad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eca5f2ed-484c-4c2e-98a1-0c55a46e736b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ed8864ae-8d7d-43f7-98aa-0ce4d42508cf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eda9dfa1-d8b9-49eb-8c65-8ceaefd0a764"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eddfac5d-6cae-4cde-a3c3-efee9473a39f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ef8e3fe1-2087-497b-a5a4-8a5821fb0571"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f070212d-ff43-4855-8098-bce4999bc75e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f107917f-7f32-4619-8cf9-ce7fd13da715"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f1f2f390-ef5e-4ebf-8de1-83d274f18f9c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f49fdeb9-717d-4d9c-8a74-0c7b6bc1dfca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f9676000-6bc6-4bb5-91c0-90b5afb6a5d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f97505d4-1b35-45fa-b048-067ec13fd573"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa42e9ca-49de-40ba-a1bb-1d54c80a2aef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa51f561-d2ef-45f5-9791-077592b770eb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("faa4200a-0da1-43e3-8be6-7299b39f0d7e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fb6aabed-ed68-4ad7-88fd-9c08ce9bd65a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fbacffec-e616-4182-9771-935b786124a9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fbc0f04d-c1da-4844-9b70-f11172f609d8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fda61204-87ca-4bf3-932e-7ed1ff357cc5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fe8d4ef4-999a-4cca-8faa-252c88fa7cc6"));
        }
    }
}
