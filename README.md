- # Hanako: A New Life

<p align="center">
  
  ![Hanakoss](https://github.com/user-attachments/assets/ec110915-dbfd-49b8-badc-0e8b6648e266) 
  
</p>

## 🔴 About This Project
<p align="justify">This project is one of my first project. It helped me to learn about the fundamental things in unity such as component and game object. I also create a lot of script in it to fit the game base on the vision that my team see</p>

<br>

## 📋 Project Info

<b> Developed with Unity 2022 </b>

| **Role** | **Name** | **Development Time** 
| - | - | - |
| Game Designer | Felix Wijaya | 1 week |
| Game Programmer | Steven Putra A | 1 week |

<details>
  <summary> <b>My Contribution (Game programmer)</b> </summary>
  
- Save System for progression
- Inventory System
- Enemy Behaviour
- All 8 unit (4 ally, 4 enemy)
- Turn Base Mechanic
- Generic Tilemap
  
</details>

<br>

## ♦️About Game
<p align="justify">Hanako: A New Life is a typing game where we need to learn braille and the mechanics of the braille machine to write words that is used in the restaurant that we worked in. There is a cheat sheet for us to learn and improve ourself. After each gameplay, our performance will be assesed through some metrics such as BPM(Braille Per Minute)</p>

<br>

## 🎮 Gameplay
<p align="justify">This game is a serious game focused on raising awareness on blind people. We want to educate people about braille by playing this game</p>

<br>

## ⚙️ Game Mechanics I Created
### Progression Saving System
- Logic is located within the `LevelSelectScript.cs` script.
- the script is used to detect unlocked level
- the script is also used to select level from the select level scene.

### Braille Machine System
- Logic is located within the `LetterBehaviour.cs` script.
- the script is used to translate from our input into braille letter.
- the braille letter is then displayed on the UI by this script also.

<br>

## 📜 Scripts

|  Script       | Description                                                  |
| ------------------- | ------------------------------------------------------------ |
| `AudioManager.cs` | Manages all the audio used for the game (BGM & SFX) |
| `WinManager.cs`  | Responsible for giving the recap amount after finishing the level. |
| `LetterBehaviour.cs`  | Responsible for the clicking braille letter system. |
| `OrderContainer.cs`  | Manages all possible order on the last level. |
| `PauseManager.cs`  | Manages all the display of pause menu. |
| `SelectCustomer.cs`  | Responsible for changing order from one customer to another |
| `etc`  |

<br>

## 🕹️ Controls
- **A / S / D / J / K / L** for Braille main input keys
- **Space Bar** to type space
- **F / H** to select customers to the left or right
- **TAB** to open Braille NoteBook

<br>
