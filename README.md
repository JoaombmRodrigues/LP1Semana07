```mermaid
classDiagram
    Weapon <|-- Gun 
    Weapon <|-- Sword
    Character <|-- Player
    Character <|-- Enemy
    Program ..> Character
    Program ..> Weapon
    Character --o Weapon
    class Weapon{
        #float power
        +Weapon()
    }
    class Gun {
        +int Ammo
        +Gun()
        +FireGun()
    }
    class Sword{
        +float BlaseLength
        +Sword()
        +AttackWithSword()
    }
    class Character{
        #Weapon weapons
        +string Name
        +Fight()
    }
    class Player{
        +Player()
    }
    class Enemy{
        +Enemy()
    }
'''
