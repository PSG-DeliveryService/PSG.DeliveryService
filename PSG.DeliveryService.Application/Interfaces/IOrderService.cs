﻿using PSG.DeliveryService.Application.Commands;
using PSG.DeliveryService.Application.Queries;
using PSG.DeliveryService.Application.Responses;
using ResultMonad;

namespace PSG.DeliveryService.Application.Interfaces;

public interface IOrderService
{
    public Task<Result<OrderResponse>> GetOrderByIdAsync(OrderQuery orderQuery);
    
    public Task<Result<CreateOrderCommand>> CreateOrderAsync(CreateOrderCommand createOrderCommand);
}