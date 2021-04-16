using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListServer.Classes
{
    class DataBaseContext : DbContext
    {
        public DataBaseContext() : base("DbConnection")
        {
            Database.SetInitializer<DataBaseContext>(new MyContextInitializer());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Note> Notes { get; set; }
    }
    class MyContextInitializer : DropCreateDatabaseIfModelChanges<DataBaseContext>
    {
        protected override void Seed(DataBaseContext db)
        {
            User user = new User() { Login = "testLogin", Password = "testPass" };
            db.Users.Add(user);
            Group group1 = new Group() { Title = "Покупки", UserId = 1 };
            Group group2 = new Group() { Title = "Продажи", UserId = 1 };
            Group group3 = new Group() { Title = "Дела на завтра", UserId = 1 };
            db.Groups.Add(group1);
            db.Groups.Add(group2);
            db.Groups.Add(group3);
            Note note1 = new Note() { GroupId = 3, Title = "Сделать дизайн", Description = "Нужно сделать дизайн" };
            Note note2 = new Note() { GroupId = 3, Title = "Программировать долго и нудно", Description = "Нужно будет сделать SQL сервер, написать быстрый и качетвенный код для соединения между клиентом и сервером и конечно же быстрое клиентское приложение" };
            Note note3 = new Note() { GroupId = 3, Title = "Искать ошибки", Description = "" };
            Note note4 = new Note() { GroupId = 3, Title = "Придумать идею", Description = "" };
            db.Notes.Add(note1);
            db.Notes.Add(note2);
            db.Notes.Add(note3);
            db.Notes.Add(note4);
            db.SaveChanges();
        }
    }
}
