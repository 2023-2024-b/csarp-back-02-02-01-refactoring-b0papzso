using Microsoft.AspNetCore.Mvc;

namespace Kreata.Backend.Datas.Responses
{
    public class ControllerResponse : ErrorStore
    {
        public bool Success => !HasError;
        public ControllerResponse() : base() { }
    }
}
