# GameDevTV-Skill-Builder - DOUBLE ROOM QUEST
 This quest creates a 3D puzzle game that focuses on basic input movement controls, destroying objects using OnTriggerEnter, Instantiating particle FX, and transparent materials.
 
 Challenges For This Quest
 
See Thru Level:
Adjust the Camera as needed and make some of the top-level game objects transparent to help the player effectively see through the top level down to the bottom level as needed. Hint: There is an example material that can be found in the Materials folder.

Duplicate Player Block:
Set up the 'Player1' cube to also move the same way 'Player2' does. Hint: Check out how the Player2 game object is set up in the inspector. Modify your moveSpeed variable to a speed that you deem appropriate for your player(s) blocks.

Assigning Variables:
In our FinishPad.cs script, assign our gameHandler variable to be assigned to our GameHandler class. Our GameHandler methods won't function correctly until challenge 3 is complete.

Little Bit of Spice:
Instantiate a particle prefab of choice at the position of the pad when a player cube reaches a FinishPad inside our FinishPad.cs script. You can find some free particle VFX in the Imported Assets folder, compliments of Synty Studios.

Then There Was None:
Implement some logic into your GameHandler.cs class to detect if all Player cubes have been destroyed from the Scene. Once that happens, activate the "You Win" text on the screen, which is currently inactive in our hierarchy under the UI_Canvas game object.

Floor Is Lava:
Create a hazard object of some kind that destroys the cube player object and restarts the level if the player cube object is destroyed. E.g., a spike hazard that destroys the player object if touched and restarts the current level in some fashion (find some free assets on the unity asset store to add some flavor!).

Camera Movement Controls:
Create some user controls to allow the user to control basic camera movement. For example, using the arrow keys so the user can navigate the camera around each level, holding right-click and dragging a free look camera around, or even zoom in and out using the mouse wheel. Whatever feels best to you and your game.
