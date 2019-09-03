﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PewChat.MessageHandlers;

namespace PewChat.Controllers
{
    public class MessagesController : Controller
    {
        private NotificationsMessageHandler _notificationsMessageHandler { get; set; }

        public MessagesController(NotificationsMessageHandler notificationsMessageHandler)
        {
            _notificationsMessageHandler = notificationsMessageHandler;
        }

        [HttpGet]
        public async Task SendMessage([FromQueryAttribute]string message)
        {
            await _notificationsMessageHandler.InvokeClientMethodToAllAsync("receiveMessage", message);
        }
    }
}