﻿string[] source_array = new string[4]{"Sevastopol","+7@","234","World"};
int counter = 0;
foreach(string e in source_array)
  if(e.Length < 4)
    counter++;
