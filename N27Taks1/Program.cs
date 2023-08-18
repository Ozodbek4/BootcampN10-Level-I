using N27Taks1;
var dbContext = new EFCoreContext();

Person person = new Person()
{
    Login = "Admin",
    Age = 10,
    Email = "admin@gmail.com"
};

dbContext.People.Add(person);
dbContext.SaveChanges();
