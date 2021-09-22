using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Structs.Fortnite
{
    [StructFallback]
    public class FFloatParticleParameter : IUStruct
    {
        public float Value;
        public FName ParameterName;

        public FFloatParticleParameter(FStructFallback fallback)
        {
            Value = fallback.GetOrDefault<float>(nameof(Value));
            ParameterName = fallback.GetOrDefault<FName>(nameof(ParameterName));
        }
    }
}