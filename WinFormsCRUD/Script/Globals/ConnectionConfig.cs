namespace WinFormsCRUD.Script.Globals
{
    public static class ConnectionConfig
    {
        public static string ConnectionString { get; set; }
        public static string GetActiveConnectionString(string server, string db, string user, string pass)
            => $"Data Source={server};Initial Catalog={db};Persist Security Info=True;User ID={user};Password={pass};";
    }
}
