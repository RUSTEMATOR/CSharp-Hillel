using System;
using System.Collections.Generic;
using System.Linq;

string word = "Aboba";

int maxWrongAttempts = 6;
int wrongAttempts = 0;
HashSet<char> guessedLetters = new HashSet<char>();

  while (wrongAttempts < maxWrongAttempts && !word.All(c => guessedLetters.Contains(c)))                                                                                                                                                 
  {
      Console.Write("\nВведіть вашу літеру: ");                                                                                                                                                                                          
      string input = Console.ReadLine();                          
      char letter = input[0];                                                                                                                                                                                                            
   
      if (word.Contains(letter))                                                                                                                                                                                                         
      {                                                           
          guessedLetters.Add(letter);
                                                                                                                                                                                                                                         
          List<int> positions = new List<int>();
          for (int i = 0; i < word.Length; i++)                                                                                                                                                                                          
          {                                                       
              if (word[i] == letter)
                  positions.Add(i + 1);
          }                                                                                                                                                                                                                              
   
          Console.WriteLine($"Така літера є у слові! Позиція літери: {string.Join(",", positions)}");                                                                                                                                    
      }                                                           
      else
      {
          wrongAttempts++;
          Console.WriteLine($"Такої літери немає! Залишилось спроб: {maxWrongAttempts - wrongAttempts}");
      }                                                                                                                                                                                                                                  
  }
                                                                                                                                                                                                                                         
  Console.WriteLine();                                            

  if (word.All(c => guessedLetters.Contains(c)))                                                                                                                                                                                         
      Console.WriteLine($"Вітаємо, ви вгадали слово! Зашифроване слово: {word}.");
  else                                                                                                                                                                                                                                   
      Console.WriteLine($"На жаль, спроби скінчились. Слово було: {word}.");
                                                                                                                                                                                                                                         
  Console.WriteLine("Дякуємо за гру.");