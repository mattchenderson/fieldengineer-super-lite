using Microsoft.Azure.Mobile.Server;

namespace FieldEngineer_super_lite_server.DataObjects
{
    public class TodoItem : EntityData
    {
        public string Text { get; set; }

        public bool Complete { get; set; }
    }
}