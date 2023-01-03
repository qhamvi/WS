using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WS.Application.TopicService.Dtos;

namespace WS.Application.TopicService
{
    public interface ITopicService
    {
        Task<int> Create(TopicCreateRequest request);
        Task<int> Update(TopicUpdateRequest request);
        Task<int> Delete(int topicId);
        Task<ListTopicResponse> GetAll(ListTopicRequest request);
    }
}
