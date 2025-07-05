using Raylib_cs;

namespace CosechaPixeladaV1.Entities.Plants
{
    public class Tomato : Plant
    {
        public override int DaysToMature => 3;
        public override int HarvestValue => 12;

        protected override Texture2D[] Sprites => throw new NotImplementedException();
    }
}
