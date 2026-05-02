Console.Write("Введіть шлях до вихідного файлу: ");                                                                                                                                                                                    
string sourcePath = Console.ReadLine();                                                                                                                                                                                                
                                                                  
Console.Write("Введіть шлях до файлу, в який потрібно скопіювати дані: ");                                                                                                                                                             
string destinationPath = Console.ReadLine();                    
                                                                                                                                                                                                                                         
string content = File.ReadAllText(sourcePath);                  
File.WriteAllText(destinationPath, content);

Console.WriteLine("Файл успішно скопійовано!");