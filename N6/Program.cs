/*


 */

DateTime[] birthday = new DateTime[] { 
    new DateTime(2010, 01, 23),
    new DateTime(2006,01, 25),
    new DateTime(2001, 03, 05),
    new DateTime(1999,12, 25),
    new DateTime(2015, 11, 11)
};

string[] people = new string[] {
    "Ali",
    "Jahongir",
    "Muzaffar",
    "Asadxon",
    "Sanjar"
};
Console.WriteLine("Saralashdan oldin: ");
for (int j = 0; j < birthday.Length; j++)
{
    Console.WriteLine($"{people[j]}: {birthday[j]}");
}

for (int i = 0; i < birthday.Length - 1; i++)
{
    for (int j = i + 1; j < birthday.Length; j++)
    {
        DateTime sortish;
        string nameing;
        if (birthday[j].Month > birthday[i].Month)
        {
            if (birthday[j].Day < birthday[i].Day)
            {
                nameing = people[j];
                people[j] = people[i];
                people[i] = nameing;
                sortish = birthday[j];
                birthday[j] = birthday[i];
                birthday[i] = sortish;
            }
            else
            {
                nameing = people[j];
                people[j] = people[i];
                people[i] = nameing;
                sortish = birthday[j];
                birthday[j] = birthday[i];
                birthday[i] = sortish;
            }
        }
    }
}


Console.WriteLine("\n\nSaralashdan keyin: ");
for  (int i = birthday.Length - 1; i > -1; i--)
{
    Console.WriteLine($"{people[i]}: {birthday[i]}");
}