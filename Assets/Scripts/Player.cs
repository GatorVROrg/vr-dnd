using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string playerClass;
    public int hitDie;
    public List<string> primaryAbility = new List<string>();
    public List<string> Saves = new List<string>();
    public string playerRace;
    public List<string> raceTraits = new List<string>();

    void Update()
    {
        if(playerRace == "Dragonborn")
        {
            raceTraits.Add("Breath Weapon");
            raceTraits.Add("Damage Resistance");
            raceTraits.Add("Draconic Ancestry");
        }
        else if(playerRace == "Dwarf")
        {
            raceTraits.Add("Darkvision");
            raceTraits.Add("Dwarven Resilience");
            raceTraits.Add("Dwarven Combat Training"); 
            raceTraits.Add("Tool Proficiency"); 
            raceTraits.Add("Stonecunning"); 
            raceTraits.Add("Dwarven Armor Training");
        }
        else if(playerRace == "Elf") 
        {
            raceTraits.Add("Darkvision"); 
            raceTraits.Add("Keen Senses");
            raceTraits.Add("Fey Ancestry"); 
            raceTraits.Add("Trance"); 
            raceTraits.Add("Elf Weapon Training"); 
            raceTraits.Add("Fleet of Foot"); 
            raceTraits.Add("Mask of the Wild");
        }
        else if(playerRace == "Halfling")
        {
            raceTraits.Add("Lucky");
            raceTraits.Add("Brave"); 
            raceTraits.Add("Halfling Nimbleness"); 
            raceTraits.Add("Stout Resilience");
        }
        else if(playerRace == "Human")
        {
            raceTraits.Add("+1Ability");
        }
        
        if(playerClass == "Barbarian")
        {
            hitDie = 12;
            primaryAbility.Add("Strength");
            Saves.Add("Strength");
            Saves.Add("Constitution");
        }
        else if(playerClass == "Bard")
        {
            hitDie = 8;
            primaryAbility.Add("Charisma");
            Saves.Add("Dexterity");
            Saves.Add("Charisma");
        }
        else if(playerClass == "Cleric")
        {
            hitDie = 8;
            primaryAbility.Add("Wisdom");
            Saves.Add("Wisdom");
            Saves.Add("Charisma");
        }
        else if(playerClass == "Druid")
        {
            hitDie = 8;
            primaryAbility.Add("Wisdom");
            Saves.Add("Intelligence"); 
            Saves.Add("Wisdom");
        }
        else if(playerClass == "Fighter")
        {   
            hitDie = 10;
            primaryAbility.Add("Strength");
            Saves.Add("Strength");
            Saves.Add("Constitution");
        }
        else if(playerClass == "Monk")
        {
            hitDie = 8;
            primaryAbility.Add("Wisdom");
            primaryAbility.Add("Dexterity");
            Saves.Add("Strength");
            Saves.Add("Dexterity");
        }
        else if(playerClass == "Paladin}")
        {
            hitDie = 10;
            primaryAbility.Add("Strength");
            primaryAbility.Add("Charisma");
            Saves.Add("Wisdowm");
            Saves.Add("Charisma");
        }
        else if(playerClass == "Ranger")
        {
            hitDie = 10;
            primaryAbility.Add("Dexterity");
            primaryAbility.Add("Wisdom");
            Saves.Add("Strength");
            Saves.Add("Dexterity");
        }
        else if(playerClass == "Rogue")
        {
            hitDie = 8;
            primaryAbility.Add("Dexterity");
            Saves.Add("Dexterity");
            Saves.Add("Intelligence");
        }
        else if(playerClass == "Sorcerer")
        {
            hitDie = 6;
            primaryAbility.Add("Charisma");
            Saves.Add("Constitution");
            Saves.Add("Charisma");
        }
        else if(playerClass == "Warlock")
        {
            hitDie = 8;
            primaryAbility.Add("Charisma");
            Saves.Add("Wisdom");
            Saves.Add("Charisma");
        }
        else if(playerClass == "Wizard")
        {
            hitDie = 6;
            primaryAbility.Add("Intelligence");
            Saves.Add("Intelligence");
            Saves.Add("Wisdom");
        }
    }
}
