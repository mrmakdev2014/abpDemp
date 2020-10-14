namespace Acme.BookStore.Permissions
{
    public static class EventsPermissions
    {
        public const string GroupName = "Events";
         
       

        public static class Events
        {
            public const string Default = GroupName + ".Events";
            public const string Create = Default + ".Create";
            public const string Edit = Default + ".Edit";
            public const string Delete = Default + ".Delete";
        }


    }
}
