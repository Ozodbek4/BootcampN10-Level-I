using N24HomeTask1.Services;

//foreach (var user in obj.Get(10, 5))
//{
//    Console.WriteLine($"{user.Id}  {user.FirstName}  {user.LastName}  {user.EmailAddress}");
//}

//foreach (var user in obj.Filter(new UserFilterModel() { FirstName = "Emma", LastName = null }))
//{
//    Console.WriteLine($"{user.Id}  {user.FirstName}  {user.LastName}  {user.EmailAddress}");
//}
//obj.Add("", "", "emma.anderson@example.com");

UserCredentialsService obj1 = new UserCredentialsService();
UserCredentials userCredentials = obj1.Add(1, "Secure123");


UserService obj = new UserService();
Console.WriteLine("Kerakli kalit so'zni kiriting: ");
var searching = Console.ReadLine();
obj.Search(searching, 10, 5).ForEach(user => Console.WriteLine($"{user.Id}  {user.FirstName}  {user.LastName}  {user.EmailAddress}"));