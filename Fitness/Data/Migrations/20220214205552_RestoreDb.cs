using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fitness.Data.Migrations
{
    public partial class RestoreDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BlogEntities",
                columns: new[] { "Id", "BlogImages", "BlogName", "BlogTags", "BlogText", "BlogTitlesId", "CommentsId", "CreaterName", "DateCreate" },
                values: new object[] { 1, "img/blog-single-1.jpg;img/blog-single-2.jpg;img/blog-single-3.jpg;img/blog-single-4.jpg", "A Closer Look At Our Front Porch Items From Lowe’s", 0, "<p>I know how terrible it can be for you at nights and even when you wake up. The burning back pain you experience can be a terrible problem. I know that because of this burning pain, you hardly get all the sleep you need at nights. You are not alone… and thankfully there are workable solutions that you can use to not only prevent future causes, but also solve the present back pain you are experiencing. Experts have agreed that the kind of mattress you sleep on plays a very important role in back pains suffered by most people. There are some mattresses that do you a lot of harm when you sleep on them. And the fact that you spend many hours EVERYDAY on such mattresses will only mean one thing!</p><p>You are only spending more time hurting your back…without your knowledge. To solve this problem you should check the kind of mattress you are sleeping on. By simply changing the mattress for a better type, like a memory foam mattress, you can help to completely eliminate the problem of back-pain from your life.</p>", null, null, "Phil Martinez", new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "BlogTitle",
                columns: new[] { "Id", "IdBlog", "Text", "Title" },
                values: new object[] { 1, 1, "You may feel like you will never possess enough commitment power to quit smoking cigarettes. However, trying to stop smoking is just like all things else in the world. It takes practice. Very few individuals stop for good on the principal try. Each time you try to stop, it will get a little easier, especially if you are knowledgeable of some of the best ways to quit smoking.These days, there are a variety of goods on the market that can assist you to stop smoking cigarettes. There are laser smoking restraint treatments, acupuncture cessation smoking methods, and even a smoking cessation shot. You can also see your physician to obtain a stop smoking antidepressant.", "Use Your Reset Button To Change Your Vibration" });

            migrationBuilder.InsertData(
                table: "BlogTitle",
                columns: new[] { "Id", "IdBlog", "Text", "Title" },
                values: new object[] { 2, 1, "Whether you enjoy city breaks or extended holidays in the sun, you can always improve your travel experiences by staying in a small, charming hotel, where the atmosphere is welcoming and friendly and the service is fabulous. There are hundreds of hotels that are self-styled “boutique” places to stay, but not all of them fall into the traditional definition of boutique, which includes.", "Use Your Reset Button To Change Your Vibration" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BlogEntities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BlogTitle",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BlogTitle",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
