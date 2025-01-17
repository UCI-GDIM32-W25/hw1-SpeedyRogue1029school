[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity
HW 1 break-down activity
- Player GameObject: The object in the game that the player controls
	- Attributes and Actions: Movement with WASD and planting Seeds with Space Bar. Has a Unique Sprite that is easily identifiable.
- Plant GameObject: The object that is created when player presses a specific command
	- Attributes and Actions: Flower is placed on the location in which the player planted the seed. Has a unique Sprite that is easily identifiable.
- Canvas Gameobject: The Game object that contains all the text elements that appear in the UI	
	- Attributes and Actions: Provides a visual to the player with the number of seeds available. Text changes depending on the number of seeds the player has remaining.

## Devlog
I started off with coding what I was most comfortable and used to. I coded the movement first with .Translate methods and deltaTime. I then switched over to the Unity Editor and attached the player C# script onto player game Object. I moved on to create the Plant Prefab by creating a 2D empty object in the Prefab folder. I added a SpriteRenderer component for the object to utilize the plant sprite. From there I initialized or dragged and dropped the corresponding serialized variables in the Unity Editor. I faced issues when trying to initialize the Plant Count UI. I then realized that I had to first attach the PlantCountUI script onto the Canvas GameObject, and only then could I drag and drop the canvas GameObject into the serialized variable slot in Player script. After, I began working on the PlantSeed() Method. In the PlantSeed() Method, I created a new Vector3 that gets the location of the player and sets the PlantPrefab GameObject the as the player location. Finally for the PlantCountUI I initialized the serialized variables with the corresponding TextMeshPro.

Looking back to the In-Class Activity, for the player GameObject, I already explained what key binds I would utilize for movement. Then knowing that I utilized Input.KeyPress and Transform.Translate() to program the movement. As for the Planting mechanic of the game, I used Input.KeyPress and The PlantSeed() method. For the Plant I explained how the flower appears in the same location as the player. I accomplished this through code by, as explained above, creating a new Vector3 that gets the location of the player and sets the PlantPrefab GameObject the as the player location. from there I would copy the PlantPrefab into a new GameObject and instantiate the copy. For Canvas GameObject I mentioned how the The UI provides visible information in regards to the player's resources. In this case the number of seeds being the resource. As mentioned above I created and updated this UI by, "initialized the serialized variables with the corresponding TextMeshPro." After that I wrote in PlantCountUI to update both Texts to the corresponding number depending on whether or not the player planted a seed.

This was my workflow process and connections I made with the In-Class activity whilst working on HW 1.

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites

## Prof comments
Thank you for clearly connecting your break-down to your code. :)

Please consider formatting your break-down activities with the hyphen '-' symbol as suggested above, and remove the prompts. This will make it a lot easier for me to read. See the [README formatting guide here](https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax).
