﻿using NextToMe.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NextToMe.Services.ServiceInterfaces
{
    public interface IMessageService
    {
        public Task<MessageResponse> SendMessage(AddMessageRequest request);
        public Task<List<MessageResponse>> GetMessages(int skip, int take);
    }
}
