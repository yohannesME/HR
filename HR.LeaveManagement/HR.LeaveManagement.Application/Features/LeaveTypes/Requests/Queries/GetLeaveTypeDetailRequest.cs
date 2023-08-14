﻿using System.Collections.Generic;
using HR.LeaveManagement.Application.DTOs;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Requests.Queries
{
    public class GetLeaveTypeDetailRequest : IRequest<LeaveTypeDto>, IRequest<List<LeaveTypeDto>>
    {
        public int Id { get; set; }
    }
}