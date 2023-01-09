using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WS.Data.Entities;

namespace WS.Data.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void DataSeed(this ModelBuilder modelBuilder)
        {
            //Has DATA
            List<Topic> listTopic = new List<Topic>()
            {
                new Topic { IdTopic = Guid.NewGuid().ToString(), NameTopic = "Tiên hiệp"},
                new Topic { IdTopic = Guid.NewGuid().ToString(), NameTopic = "Kiếm hiệp"},
            };
            modelBuilder.Entity<Topic>().HasData(
                listTopic
            );
            
        }
    }
}