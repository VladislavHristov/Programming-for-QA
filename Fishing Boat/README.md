#Programming-For-QA
Tony and his friends were passionate about fishing. They were so enthusiastic about it that they opted to go fishing by boat. The rental cost of the boat depends on both the season and the number of fishermen.
The price depends on the season:
•	The price for renting the boat in the spring is 3000 BGN.
•	The price for renting the boat in the summer and autumn is 4200 BGN.
•	The price for renting the boat in winter is 2600 BGN.
The group receives a discount based on the number of people.
•	If the group is up to 6 people including – a discount of 10%.
•	If the group is from 7 to 11 people – a discount of 15%.
•	If the group is from 12 people and more – a discount of 25%. 
Furthermore, the fishermen receive an extra 5% discount if the total count of fishermen is even. This additional discount is applied after deducting the discounts mentioned above, except during the autumn season. In autumn, this extra discount does not apply.
Write a program to calculate whether the fishermen will be able to gather enough money for the fishing trip. 
Input
You will have to read three values from the Console:
•	Group Budget - integer in the range [1... 8000]
•	Season - string: "Spring", "Summer", "Autumn", "Winter"
•	Fishermen Count - integer in the range [4... 18]
Output
The result should be printed on the Console on a single line:
•	If the budget is sufficient:
"Yes! You have {moneyLeft} leva left."
•	If the budget is not enough:
"Not enough money! You need {moreMoney} leva."
The value of the currency must be formatted to the second decimal place.
![image](https://github.com/VladislavHristov/Programming-for-QA/assets/136968279/9b19e29b-c5e0-44a3-854a-201e5e04f2de)
