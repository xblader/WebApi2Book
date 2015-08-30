using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi2Book.Web.Api.Models;

namespace WebApi2Book.MaintenanceProcessing
{
    public interface ICompleteTaskWorkflowProcessor
    {
        Task CompleteTask(long taskId);
    }
}