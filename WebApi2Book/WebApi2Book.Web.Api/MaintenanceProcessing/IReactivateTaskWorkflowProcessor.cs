﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApi2Book.Web.Api.Models;

namespace WebApi2Book.MaintenanceProcessing
{
    public interface IReactivateTaskWorkflowProcessor
    {
        Task ReactivateTask(long taskId);
    }
}
