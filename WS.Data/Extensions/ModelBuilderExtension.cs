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

        public static void Seed(this ModelBuilder modelBuilder)
        {
            //DataSeeding
            modelBuilder.Entity<Topic>().HasData(
                new Topic() {
                    IdTopic = Guid.NewGuid().ToString(), 
                    NameTopic = "Tiên hiệp"
                },
                new Topic() {
                    IdTopic = Guid.NewGuid().ToString(), 
                    NameTopic = "Kiếm hiệp"
                },
                new Topic() {
                    IdTopic = Guid.NewGuid().ToString(), 
                    NameTopic = "Ngôn tình"
                });
            
            
        }
    }
}