# Boot-upBot
 Microgame assignment
Boot-up Bot is a microgame where the player takes the role of an unnamed scientist in their attempt to get an experimental robot running by using a remote connected to said robot. The gameplay is incredibly simple and intuitive, the robot will flash a direction on its chest and the player must respond with the indicated direction, the wrong input or a delay will result in a loss. There is 1 second between the arrows and .75 seconds to respond with the goal being 8 correct inputs to boot up the robot. The game was made in Unity 2D and is single player. The only inputs required are the arrow buttons, while the main gameplay loop can be completed in less than 10 seconds. The game starts with displaying a simple instruction for 2 seconds and the end result is indicated by an animation from the robot, exploding for failure and glowing for success. There is a main background loop, an engine startup SFX for the instructions, chimes for a new direction and correct input, electrical crackle and explosion SFX for failure, and a boot-up jingle for success. All assets, both sprites and animation, are custom made with the player being represented by a scientist, a lab background, and as the game is constrained within 10 seconds there is no need for a timer so instead, the UI is a score tracker out of 8. The main visual aspect is the robot, designed with a screen that changes to show the input.
