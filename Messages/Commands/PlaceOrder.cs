﻿using System;
using NServiceBus;

namespace Messages.Commands
{
    public class PlaceOrder : ICommand
    {
        public Guid OrderId { get; set; }
    }
}
