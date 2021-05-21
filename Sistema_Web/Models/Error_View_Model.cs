using System;

namespace Sistema.Web.Models
{
    public class Error_View_Model
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
