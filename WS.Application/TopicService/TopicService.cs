using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WS.Application.TopicService.Dtos;
using WS.Data.EF;
using WS.Data.Entities;

namespace WS.Application.TopicService
{
    public class TopicService : ITopicService
    {
        //readonly chi doc chi gan mot lan
        private readonly WSDbContext _dbContext;
        public TopicService(WSDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Create(TopicCreateRequest request)
        {

            var topic = new Topic()
            {
                NameTopic = request.NameTopic
            };    
            await _dbContext.Topics.AddAsync(topic);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<int> Delete(int topicId)
        {
            throw new NotImplementedException();
        }

        public async Task<ListTopicResponse> GetAll(ListTopicRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Update(TopicUpdateRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
