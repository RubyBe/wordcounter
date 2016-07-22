# _Word Counter program with C#, Nancy, and Razor_

#### _Project Specifications_

#### By _** Sid Benavente **_

## Description/Specs

A program which builds a web app which accepts both a single word and then a string of multiple words. The Web app is then able to return a count of full-word matches of the single word within the string of multiple words.

| Behavior        | Input Example           | Output Example  | Input Justification / Other comments |
| ------------- |:-------------:| -----:|
| 1. A player can enter a word and the word is returned for display. | "antelope" | "antelope" | Simplest case is that any stand-alone word can be entered and returned. |
| 2. A player can enter a string of words and the string of words is returned for display. | "An antelope is like a gazelle in a way but it begins with an A actually." | "An antelope is like a gazelle in a way but it begins with an A actually."| Any string of words of whatever length is acceptable to test the class's ability to create objects which can accept and then display a string object of multiple words. |
| 3. A player can enter both a word and a string of words and both the word and string of words are returned for display. | "antelope", "An antelope is like a gazelle in a way but it begins with an A actually." | "antelope", "An antelope is like a gazelle in a way but it begins with an A actually."| Because of the need to use a single constructor which accepts two strings, this spec was tested in test 2. |
| 4. The program can scan the player's string of words and identify occurrences of the player's commonly-stand-alone single word and return "True" if it is found. | "antelope", "An antelope is like a gazelle in a way but it begins with an A actually." | "True" | A word not commonly embedded within other word strings conceptually should be simpler to isolate in the string of words. |
| 5. The program can scan the player's string of words and identify stand-alone occurrences of the player's commonly-stand-alone single word, count the number of times it occurs, and return that count for display. | "antelope", "An antelope is like a gazelle in a way but it begins with an A actually." | 1 | A word not commonly embedded within other word strings conceptually should be simpler to isolate and count in the string of words. |
| 6. The program can scan the player's string of words and identify stand-alone occurrences of the player's commonly-embedded single word, count the number of times it occurs, and return that count for display. | "a", "An antelope is like a gazelle in a way but it begins with an A actually." | 2 | Since single-character words are common, the program must be able to discern a stand-alone instance versus an embedded instance. |
| 7. The program can scan the player's string of words and identify stand-alone occurrences of the player's commonly-embedded single word, count the number of times it occurs, and return that count for display - regardless of case sensitivity. | "a", "An antelope is like a gazelle in a way but it begins with an A actually." | 3 |  |
| 8. The program can scan the player's string of words and identify stand-alone occurrences of the player's single word, count the number of times it occurs, and return that count for display - regardless of surrounding punctuation. | "actually", "An antelope is like a gazelle in a way but it begins with an A actually." | 1 | Any pre- or post-word characters not part of the actually word should not prevent the instance of the word from being included in the count. |

* Web design is two pages: a first page with a form allowing the player to enter the search word and the string of words; and a second page which displays the search and count results.

## Use this program
Clone this repository. Install DNVM per instructions here and then run "DNU restore" at the PowerShell prompt in the top directory of the cloned repository. To start the local server, type in "DNX Kestrel" at the same prompt. Navigate in your browser to "LocalHost:5004" to view the homepage.

## Known Bugs

## Support and contact details
Please contact the authors if you have any questions or comments.

## Technologies Used
This webpage was written using C#, Nancy, Razor, CSS, and Bootstrap.

### License
Copyright (c) 2016 _** Sid Benavente **_

This software is licensed under the MIT license.
