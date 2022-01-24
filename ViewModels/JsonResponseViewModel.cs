using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebItProject.ViewModels
{
    public class JsonResponseViewModel
    {
        public bool IsSuccess { get; set; } = true;
        public object Data { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime ResponseTime { get; set; } = DateTime.UtcNow;
    }
}
