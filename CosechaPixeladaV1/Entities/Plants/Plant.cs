using CosechaPixeladaV1.Types;
using Raylib_cs;
using System.Threading.Tasks.Dataflow;

namespace CosechaPixeladaV1.Entities.Plants
{
    public abstract class Plant
    {
        public int GrowthDays { get; protected set; } = 0;
        public abstract int DaysToMature { get; }
        protected abstract Texture2D[] Sprites { get; }
        public bool IsMature => GrowthDays >= DaysToMature;

        public virtual void AdvanceDay() => GrowthDays++;
        public virtual int HarvestValue => 10;

        
    }
}
