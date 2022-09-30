using System;
using System.Linq;
using PracticeLinq;


List<string> gameNames = new List<string>()
{"God of war",
"Runescape",
"MultiVersus",
"Roblox",
"Gundam Evolution"};

IEnumerable<string> sorted = gameNames.OrderBy(game => game.Length);
Method.PrintEnumerable(sorted);