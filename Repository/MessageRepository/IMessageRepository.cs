using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleBot.Entity;

namespace SimpleBot.Repository.MessageRepository
{
    interface IMessageRepository : IRepositoryBase<Message, string> 
    {
    }
}
