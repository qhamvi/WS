using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WS.Application.TopicService.Dtos;
using WS.Data.EF;
using WS.Data.Entities;
using WS.Utilities.Exceptions;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace WS.Application.TopicService
{
    public class TopicService : ITopicService
    {
        //readonly chi doc chi gan mot lan
        private readonly WSDbContext _dbContext;
        private readonly IMapper _mapper;
        public TopicService(WSDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task Create(TopicCreateRequest request)
        {

            var topic = new Topic()
            {
                IdTopic = Guid.NewGuid().ToString(),
                NameTopic = request.NameTopic
            };    
            await _dbContext.Topics.AddAsync(topic);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(string topicId)
        {
            var existTopic = await _dbContext.Topics.FindAsync(topicId);
            if(existTopic is null)
            {
                throw new WSException($"Not Found");
            }
            _dbContext.Topics.Remove(existTopic);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<ListTopicResponse> GetAll(ListTopicRequest request)
        {
            //select
            var query = from topic in _dbContext.Topics select topic;
            //filter
            if(!string.IsNullOrEmpty(request.KeyWord))
            {
                query = query.Where(v => v.NameTopic.Contains(request.KeyWord));
            }
            //paging
            int totalRow = await query.CountAsync();
            if(request.Page ==0)
            {
                request.Page = 1;
            }
            if(request.PageSize == 0)
            {
                request.PageSize = 10;
            }            
            var data = query.Skip((request.Page - 1)* request.PageSize).Take(request.PageSize);
            //select and projection
            var pageResult = new ListTopicResponse()
            {
                Count = totalRow,
                Page = request.Page,
                PageSize = request.PageSize,
                Results = data.Select(topic => _mapper.Map<TopicViewModel>(topic)).ToList()
            };
            return pageResult;
        }

        public async Task Update(TopicUpdateRequest request)
        {
            
            var existTopic = await _dbContext.Topics.FindAsync(request.IdTopic);
            if(existTopic is null)
            {
                throw new WSException($"Not Found");
            }
            existTopic.NameTopic = request.NameTopic;
            _dbContext.Topics.Update(entity: existTopic);
            await _dbContext.SaveChangesAsync();
        }
    }
}
