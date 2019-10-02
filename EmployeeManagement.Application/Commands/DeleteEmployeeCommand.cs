﻿using EmployeeManagement.Application.Messages;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Application.Commands
{
    public class DeleteEmployeeCommand : IRequest<DeleteEmployeeCommandResponse>
    {
        public Guid EmployeeId { get; set; }
    }
}