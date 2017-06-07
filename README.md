# cardwar
Simple .NET version of card game War, where player who draws the highest value card wins. This is a singleplayer version versus a computer.

## Gameplay 

![Initial interface](http://i.imgur.com/8vpEwB8.png)

The game uses the standard deck of 52 French playing cards. Click on your deck or "Start game" to shuffle the deck and draw a card. The computer will reveal their card as well.

You gain points depending on the value of your card compared to the computer's.

Points are awarded as follows:
* Having a higher score than the other player is worth 2 points.
* A tie results in both players getting 1 point.

![The human player wins the round because their 8 of clubs is worth more than the computer's 2 of spades.](http://i.imgur.com/8fUSbXp.png)

*The human player wins the round because their 8 of clubs is worth more than the computer's 2 of spades.*

#### Winning the game

After all cards are drawn (points should add up to 52), the player with the highest score wins. Draws are possible.

You can prematurely end the game at any time by hitting "Stop game" and subsequently exit the program by hitting "Quit game".

## Installation

Download from the [Releases page](https://github.com/ErikHumphrey/cardwar/releases) and save to any directory. Double-click `HumphreyErik20CardWars.exe` to play.

#### System requirements

* Windows Vista or later

* [.NET Framework 4.5](https://www.microsoft.com/en-ca/download/details.aspx?id=30653) (included on Windows 8.1 and above)
