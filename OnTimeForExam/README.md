#Programming-For-QA.
A student is required to take an exam at a specific time (e.g., at 9:30 a.m.). However, he arrives at the exam room at a given time of arrival (e.g., 9:40 a.m.). The student is considered to have arrived on time if he arrives at the exam time or up to half an hour before it. If they arrive earlier than 30 minutes, he is considered early. If he arrives after the exam time, he is considered late. Write a program that reads the exam time and the time of arrival, and then prints whether the student is on time, early, or late, along with the number of hours or minutes he is early or late.
Input
From the console are read 4 integer values (one per line) entered by the user:
•	The first line contains an exam time – hour - an integer from 0 to 23.
•	The second line contains an exam time – minute - an integer from 0 to 59.
•	The third line contains the time of arrival – hour - an integer from 0 to 23.
•	The fourth line contains the time of arrival – minute - an integer from 0 to 59.
Output
On the first line, print on of the following messages:
•	"Late" - if the student arrives later than the time of the exam.
•	"On time" - if the student arrives exactly at the time of the exam or up to 30 minutes in advance.
•	"Early" - if the student arrives more than 30 minutes before the exam time.
On the second line, print a message, considering the following conditions:
•	If the student arrives with at least a minute difference from the exam time, print on the next line:
o	For being late under an hour: "{mm} minutes after the start"
o	For a delay of 1 hour or more: "{hh:mm} hours after the start". 
	Always print the minutes with 2 digits, such as "1:03".
![image](https://github.com/VladislavHristov/Programming-for-QA/assets/136968279/b0aa749b-ba63-4e34-b92a-f994c22e5a40)

