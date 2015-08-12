using Microsoft.Azure.Mobile.Server;
using System;

namespace FieldEngineer_super_lite_server.DataObjects
{
    public class TodoItem : EntityData
    {
        public TodoItem()
        {
            Id = Guid.NewGuid().ToString("N");
        }

        public string Text { get; set; }

        public bool Complete { get; set; }

        public string UserId { get; set; }
    }
}