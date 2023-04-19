using Template_Pattern_Console_App;

FileWriter fw = new DESWriter("C:\\Users\\qusai\\Desktop\\Projects\\UnityProjects\\Template Pattern Console App\\Documents\\encrypted.txt");
fw.Append("All Work and no play makes Jack a dull boy");


fw = new UnencryptedWritter("C:\\Users\\qusai\\Desktop\\Projects\\UnityProjects\\Template Pattern Console App\\Documents\\Unencrypted.txt");
fw.Append("All Work and no play makes Jack a dull girl");


Console.WriteLine("this file have been made");
Console.ReadLine();