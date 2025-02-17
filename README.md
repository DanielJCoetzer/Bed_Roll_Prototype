
# **What is it?**

<img width="1087" alt="Screenshot 2025-02-06 at 22 57 44" src="https://github.com/user-attachments/assets/f173eb2a-0490-41d8-b443-35b567a8b37f" />

Get to bed is a concept puzzle prototype where the player’s goal is to get to bed with the lights off and avoid monsters hiding under the furniture on the way. While the lights are on, the player can move the furniture around to create a path for the player to get to bed when they turn off the lights. 

The camera is fixed in one position, with the entire game level in frame, mimicking an isometric perspective. 

The character moves grid based: either 1 cell horizontal or vertical. They can move furniture around and turn the light switch on and off.

The controls are simply W and S to move up and down, and A and S to move left and right. When the player is at a light switch, they can press E to toggle the switch on and off.


**Why did I make it?**

I gave myself the constraint that this prototype should be related to sleep in some way. I got inspired by my childhood and how I ran to bed after turning off the bedroom lights to avoid anything scary. A grid-based puzzle game like Stephen’s Sausage Roll immediately came to mind. I thought this would be a simple game concept to prototype and convey to the playtesters.

# **Implementation**

Wrote down a bunch of ideas for what the rules of the puzzle could be and what the player character’s abilities were. 
Sketched some visual representations of how the game might look.
Made a paper prototype and made other players play it.
Implemented the prototype on Unity

# **Intended Player Experience**

I wanted the game to feel simple and easy to digest. I wanted the player to feel like the puzzle seems easy enough, and then maybe realise its not as easy as it seems. 
Iteration and Process

**Camera**

I chose to keep the camera in a fixed perspective to encourage the feeling that the game is small and simple, and everything you need to know about the game is on the screen. 

At first I kept the camera in an orthographic perspective, but playtesters thought it looked weird and wonky. I let the same playtesters play it with a normal perspective instead, and they thought it made more sense. 

Other than that, the testers enjoyed the simple and easy to look at camera perspective.

**Character**

To promote a simpler, slower pace and encourage lateral thinking, I chose to make the character move on a grid. The game could feel a bit chaotic and unstructured if the player could move in any direction.

Playertesters thought the grid based movement was appropriate, but that it also inhibited the feeling that the player is running to the bed like when you are a kid.

The character pushes furniture using physics, which I intended to change to be more precise. But testers really liked the feeling of the furniture moving!

**Control**

Because players are used to the convention of playing with WASD to move, it only made sense to make the controls familiar to the player. I don’t want the player to be frustrated based on the controls.

The character used to teleport from one cell to a next cell, which felt unresponsive. I used coroutines to make the character move through time and that made the movement feel smoother.


# **Conclusion**

I did not make any pivotal changes of my initial design, but I made small incremental changes throughout the prototyping course which made the overall player experience feel more polished. 

I am very happy with my prototype and am tempted to continue working on it in my own time. If I would work on it further, I would implement a grabbing mechanic so the player can grab and pull furniture, instead of just pushing. I would also make it so the player character has a limited amount of steps when the lights are off to make the player feel like they are running from monsters.

I learned a lot about grid-based movement and lighting in this prototype, but I feel like there’s much more to learn.
