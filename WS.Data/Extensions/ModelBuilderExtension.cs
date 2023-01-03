using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WS.Data.Entities;

namespace WS.Data.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void DataSeed(this ModelBuilder modelBuilder)
        {
            List<Topic> topicList = new List<Topic>()
            {
                new Topic() { IdTopic = Guid.NewGuid().ToString(), NameTopic = "Tien hiep" },
                new Topic() { IdTopic = Guid.NewGuid().ToString(), NameTopic = "Kiem hiep" },

            };
           
            List<Story> listStory = new List<Story>()
            {
                new Story {IdStory= Guid.NewGuid().ToString(), ImageFileName = "null.jpg", Author = "Tac gia",
                    Collector = "Nguoi suu tam" , IsAcept = true , IsComplete = false , CreateDate = DateTime.Now,
                ListTopicInStory = null, PublishDate = DateTime.Now, Summary = "Tom tat", TitleStory = "Tieu de truyen 3"},

                 new Story {IdStory= Guid.NewGuid().ToString(), ImageFileName = "null.jpg", Author = "Tac gia 2",
                    Collector = "Nguoi suu tam 2" , IsAcept = true , IsComplete = false , CreateDate = DateTime.Now,
                ListTopicInStory = null, PublishDate = DateTime.Now, Summary = "Tom tat 2", TitleStory = "Tieu de truyen 3"},

                  new Story {IdStory= Guid.NewGuid().ToString(), ImageFileName = "null.jpg", Author = "Tac gia 3",
                    Collector = "Nguoi suu tam 3" , IsAcept = true , IsComplete = false , CreateDate = DateTime.Now,
                ListTopicInStory = null, PublishDate = DateTime.Now, Summary = "Tom tat 3", TitleStory = "Tieu de truyen 3"},
            };
            
            List<Chapter> chapters= new List<Chapter>()
            {
                new Chapter(){IdChapter = Guid.NewGuid(), Collector = "Nguoi suu tam", CreateDate = DateTime.Now,
                Content = "Noi dung", IdStory = listStory[0].IdStory, TitleChap = "Tieu de chap 1"},

                new Chapter(){IdChapter = Guid.NewGuid(), Collector = "Nguoi suu tam", CreateDate = DateTime.Now,
                Content = "Noi dung", IdStory = listStory[0].IdStory, TitleChap = "Tieu de chap 2"},

                new Chapter(){IdChapter = Guid.NewGuid(), Collector = "Nguoi suu tam", CreateDate = DateTime.Now,
                Content = "Noi dung", IdStory = listStory[0].IdStory, TitleChap = "Tieu de chap 3"}
            };
            
            modelBuilder.Entity<Story>().HasData(
                listStory

                );
            modelBuilder.Entity<Topic>().HasData(
                topicList
            );
            modelBuilder.Entity<Chapter>().HasData(
                chapters
                );
        }
        
    }
}