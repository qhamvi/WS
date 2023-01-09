using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WS.Application.TopicService.Dtos;

namespace WS.Application.TopicService
{
    public interface ITopicService
    {
        Task Create(TopicCreateRequest request);
        Task Update(TopicUpdateRequest request);
        Task Delete(int topicId);
        Task<ListTopicResponse> GetAll(ListTopicRequest request);
    }
}
