
public enum ActorType
{
    UNINITIALIZED, //Something bad happened
    PAWN, //Character that can be controlled by either Player or AI
    NPC, //Interactable (not necessarilly a character)
    PLATFORM, //Walls, floors, ceilings, etc..
    SCENERY //Decorations
}
