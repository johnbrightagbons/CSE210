using System;
using System.Collections.Generic;

class prompt
{
  public list<string> _promptsList = new List<string>();
  public prompt()

  {

  } 

  public string DisplayPrompts()
  {
     _promptsList.Add("Who was the most interesting person I interacted with today?");
    _promptsList.Add("What was the best part of my day?");
    _promptsList.Add("How did I see the hand of the Lord in my life today?");
    _promptsList.Add("What was the strongest emotion I felt today?");
    _promptsList.Add("If I had one thing I could do over today, what would it be?");
    Random random = new Random();
    int _randIndex = random.Next(_promptsList.Count);
    string _rand = _promptsList[_randIndex];
    return _rand;
  } 
}