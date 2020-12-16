# Assignment-8 

* Shir Avraham
* Yuval Zarbiv
* Matti Stern

On this part the Sections we chose are :
section 4 ,section 5 and section 6.


#### Section 4
**Ocean Scene:** The scene: https://github.com/MYS-games/Assignment-week8-part2/blob/master/Assets/Scenes/4-generation/ocaenScean.unity
We added 6 new tiles that create an ocean with fish and reefs:

**sea tile :** walkable tile. 

<img src="https://user-images.githubusercontent.com/57191216/102313554-8632c900-3f79-11eb-8f99-6c9a31de69bb.png" width="64" height="64">

**fish tile (Player) :**

<img src="https://user-images.githubusercontent.com/57191216/102313426-51bf0d00-3f79-11eb-9690-154941284835.png" width="64" height="64">

**shark tile :** unwalkable tile. 

<img src="https://user-images.githubusercontent.com/57191216/102313420-4d92ef80-3f79-11eb-923f-d4c9bb10c732.png" width="64" height="64">

**orange reef tile :** unwalkable tile. 

<img src="https://user-images.githubusercontent.com/57191216/102313520-75825300-3f79-11eb-86ae-28c72c6493bd.png" width="64" height="64">

**blue reef tile :** walkable tile. 

<img src="https://user-images.githubusercontent.com/57191216/102313507-6ef3db80-3f79-11eb-9eaf-0469ac0e1aec.png" width="64" height="64">

we create 2 new scripts (Based on cave generator scripts) that create a random map with these tiles:
[Ocean generator](https://github.com/MYS-games/Assignment-week8-part2/blob/master/Assets/Scripts/4-generation/OceanGenerator.cs) And
[Tilemap Ocean generator](https://github.com/MYS-games/Assignment-week8-part2/blob/master/Assets/Scripts/4-generation/TilemapOceanGenerator.cs)

<img src="https://user-images.githubusercontent.com/57191216/102317954-27714d80-3f81-11eb-8c90-f9467a0ce7ae.png" width="800" height="400">



#### Section 5
**Carver Scene:** The scene: https://github.com/MYS-games/Assignment-week8-part2/blob/master/Assets/Scenes/4-generation/Carver.unity

We change the scripts  [KeyboardMover](https://github.com/MYS-games/Assignment-week8-part2/blob/master/Assets/Scripts/2-player/KeyboardMover.cs) And
[KeyboardMoverByTile](https://github.com/MYS-games/Assignment-week8-part2/blob/master/Assets/Scripts/2-player/KeyboardMoverByTile.cs) and added conditions that is the X key is pressed and also pressed one of the arrows, the player can carve the mountain and find diamonds.
<img src="https://user-images.githubusercontent.com/57191216/102316166-1d018480-3f7e-11eb-9d05-9787fef44b54.png" width="32" height="32">
we uploaded this scene to the itch : [Carver Game](https://mattistern.itch.io/carver)


<img src="https://user-images.githubusercontent.com/57191216/102317638-90a49100-3f80-11eb-8784-188810b5a83b.png" width="800" height="400">


#### Section 6
**oceanChaser Scene:** The scene: https://github.com/MYS-games/Assignment-week8-part2/blob/master/Assets/Scenes/4-generation/oceanChaser.unity

we create 2 new scripts (Based on cave generator scripts) that create a random map with the ocean tiles we used on section 4 we also added the same 2 chaser enemies from the source code and their scripts and we added a Door on the right top corner that has collider and trigger that enlarges the map by 10 % each time the player touch it.
<img src="https://user-images.githubusercontent.com/57191216/102317228-dd3b9c80-3f7f-11eb-867b-e75595836d07.png" width="32" height="32">

the player can also "eat" the orangeReef by pressing X and one of the arrows (same as the carver scene on section 5), it allows him to get out of "cave".

The scripts : [Ocean generator Chaser](https://github.com/MYS-games/Assignment-week8-part2/blob/master/Assets/Scripts/4-generation/OceanGeneratorChaser.cs) And
[Tilemap Ocean generator chaser](https://github.com/MYS-games/Assignment-week8-part2/blob/master/Assets/Scripts/4-generation/TilemapOceanGeneratorChaser.cs) And the collision script [Door Collider](https://github.com/MYS-games/Assignment-week8-part2/blob/master/Assets/Scripts/4-generation/DoorCollider.cs)

<img src="https://user-images.githubusercontent.com/57191216/102318260-b716fc00-3f81-11eb-8e47-f8f4359e2e7d.png" width="500" height="500">













