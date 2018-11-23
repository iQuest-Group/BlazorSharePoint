# ScrabbleBlazor

An online Scrabble game developed in Blazor, a web UI framework based on C#, Razor, and HTML that runs in browsers via WebAssembly. https://blazor.net/

### Project status  

We took it as far as we could in one day, there is still a lot that can be done, so far the functionalities are:

 - Multiple users can register for the game by entering their name and clicking *Update Name*. Several browsers can be used to test it locally.
 - After a user registers he receives his set of 7 letters, which are shown bellow the game board.
 - A list of registered users is diplayed to the right of the game board. You may need to click *Refresh* to retrieve the most current data.
 - The user can click a letter from his set and then click a square on the game board to place it there.
 - After he places his word on the board, he can press *End Turn* to have his submission sent to the server.
 - The next player should click *Refresh* to get the latest board state and he can then place his own word.

Of course SignalR would be perfect here for all this client - server interaction, we just didn't have the time to put it in.

### Setup

You need Visual Studio 2017 with the  Blazor Language Services extension, you can find all the details on https://blazor.net/docs/get-started.html

To run the game from Visual Studio, you have to start the ScrabbleBlazor.Server project (not ScrabbleBlazor.Client as you would expect).

### Screenshot

![](https://i.imgur.com/y1ic38i.png)
