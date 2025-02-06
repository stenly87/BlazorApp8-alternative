namespace BlazorApp8.DB
{
    public static class DBEvents
    {
        public static List<Event> Events { get; set; }

        static DBEvents()
        {
            Events = new();

            Events.Add(new Event { Author = "Мария Павловна", Date = DateTime.Now, Description = "Я училко", Title = "Истина где-то рядом" });
            Events.Add(new Event { Author = "Мария Павловна", Date = DateTime.Now, Description = "Я училко", Title = "Истина где-то рядом" });
            Events.Add(new Event { Author = "Мария Павловна", Date = DateTime.Now, Description = "Я училко", Title = "Истина где-то рядом" });
            Events.Add(new Event { Author = "Мария Павловна", Date = DateTime.Now, Description = "Я училко", Title = "Истина где-то рядом" });
            Events.Add(new Event { Author = "Мария Павловна", Date = DateTime.Now, Description = "Я училко", Title = "Истина где-то рядом" });
            Events.Add(new Event { Author = "Мария Павловна", Date = DateTime.Now, Description = "Я училко", Title = "Истина где-то рядом" });
        }
    }
}
