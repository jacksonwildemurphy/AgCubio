README
Assignment 7 : AgCubio
Partners : Jackson Murphy and Robert Weischedel

******TA README INFO******
We designed our game to freeze when the serve unexpectly ends while the game is being played. No dialog box is displayed, just simply close the window and the start menu window will open and allow you to reconnect.
In addition we were confused about which scaling method to use, either a constant scaling or by calcualting by player mass. We did it both ways and they can be activated from Form2 if the boolean var 
useContantScaling is set to true/false. We think the constant value looks better, but the assignment appearently required it calcuated by mass. 

Initial Design Thoughts : 
Before the beginning of this assignment we were excited to get started on making and using networks and servers. We believed that the assignment would be difficult and time intensive so we decided to begin working 
early and to meet up almost every day for about 4 or so hours in order to knockout this assignment on time. 

Design Plan : 

Model :

World Class :
Contains all world info including all cubes and their information.

Cube Class :
Contains all info about a cube, size, color, position, etc.

View :
The GUI for the game.

*UPDATE 11/6/15
Form1 – Opening screen to allow players to enter their player and server names.
Form 2 – The gameplay window

*UPDATE 11/11/15
Add and update call backs via the brought in preserved state obj. Use these saved call backs to bring us back to the Form 2 from the network class methods.

Network Controller :
All the network code, methods and Preserved State class

Preserved State Class :
Contains socket, and other info?

*UPDATE 11/11/15
Use callbacks to call to the other methods in network, only store the callbacks from the Form 2 in the preserved state obj. 

Design Updates : 

*UPDATE 11/6/15
Began with making the Model class which was pretty easy and then being unsure of how to go about the network portion we began on the GUI elements. Decided we should have two different Forms, one for entering player 
name and server and the second being the game world window. Got the first Form done, and then got stuck on the second form. 

*UPDATE 11/7/15
Decided that in order to fully understand how the GUI was going to pull information from the network we should start on it first. Didn’t make really any progress today, spinning tires all day… And scouring examples 
online and from the course to help us. 

*UPDATE 11/9/15
Finally found a good MSDN example online that helped us make tremendous progress today, not 100% positive that this is correct or the right direction we should go in but we are going with it. Got a lot of the 
network code done today.

*UPDATE 11/10/15
Learned in class that the example we found was a good one and one the professor suggested. Spent most of the day debugging the network code and trying to get it to print to the output window. Finally began 
understanding all the different callbacks and their specific tasks they are trying to do.

*UPDATE 11/11/15
Continued debugging the network class and hooked up all the callbacks correctly in the network class and Form2 of the GUI. By the end of the day the network was printing all the de-serialized JSON cube information 
to the output window. 

*UPDATE 11/12/15
Tried to get cubes to print to screen, finally got them to appear but it is very slow. Implemented mouse controls. Finally realized the Console.WriteLine() statements were slowing things down dramatically, once 
removed the GUI sped up immediately. 

*UPDATE 11/13/15
Began working on scaling/resizing of the GUI window. Made some progress. 

*UPDATE 11/16/15
Continued working on scaling/resizing of the GUI window, worked on handling server errors.

*UPDATE 11/17/15
Finished adding comments and test cases. 

Take Away/Lessons Learned
Drawing the assignment out before starting on a new section of the code really helped! It allowed us to eventually figure out how all the network and GUI callbacks work. 
