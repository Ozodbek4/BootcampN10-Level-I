﻿using N24HomeTask1.Services;

UserService obj = new UserService();
//foreach (var user in obj.Get(10, 5))
//{
//    Console.WriteLine($"{user.Id}  {user.FirstName}  {user.LastName}  {user.EmailAddress}");
//}

//obj.Search("ma", 10, 5).ForEach(user => Console.WriteLine($"{user.Id}  {user.FirstName}  {user.LastName}  {user.EmailAddress}"));
//foreach (var user in obj.Filter(new UserFilterModel() { FirstName = "Emma", LastName = null }))
//{
//    Console.WriteLine($"{user.Id}  {user.FirstName}  {user.LastName}  {user.EmailAddress}");
//}
obj.Add("", "", "emma.anderson@example.com");