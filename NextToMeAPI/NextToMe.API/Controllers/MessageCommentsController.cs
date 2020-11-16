﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NextToMe.Common.DTOs;
using NextToMe.Common.Models;
using NextToMe.Services.ServiceInterfaces;
using System.Threading.Tasks;

namespace NextToMe.API.Controllers
{
    [ApiController]
    [Authorize(Roles = Roles.User)]
    [Route("api/message/comments")]
    public class MessageCommentsController
    {
        private readonly IMessageCommentService _messageCommentService;

        public MessageCommentsController(IMessageCommentService messageCommentService)
        {
            _messageCommentService = messageCommentService;
        }

        [HttpPost]
        [Route("send")]
        public async Task<MessageCommentResponse> SendComment(AddMessageCommentRequest request)
        {
            return await _messageCommentService.SendComment(request);
        }
    }
}