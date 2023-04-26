
//Using Concat - Combining 2 string to 1 string
string firstName = "Will ";
string lastName = "Smith";
string fullName = string.Concat(firstName, lastName);
System.Console.WriteLine(fullName);


// Using substring to take part of the string and asign it to other string
string fileName = @"C:\LOL\C Sharp";
string part = fileName.Substring(8);
System.Console.WriteLine(part);


// Using Indexof to take the exact letter from whole string
int showIndex = firstName.IndexOf("i");
System.Console.WriteLine(showIndex);

//Using Replace to replace a word with another word
string coctail = "Vodka + Martini + Cherry";
string replaced = coctail.Replace("+", "and");
System.Console.WriteLine(replaced);