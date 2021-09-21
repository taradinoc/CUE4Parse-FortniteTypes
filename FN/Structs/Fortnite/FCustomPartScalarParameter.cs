using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Structs.Fortnite
{
    [StructFallback]
    public class FCustomPartScalarParameter : IUStruct
    {
        public int MaterialIndexForScalarParameter;
        public FName ScalarParameterNameForMaterial;
        public float ScalarOverride;

        public FCustomPartScalarParameter(FStructFallback fallback)
        {
            MaterialIndexForScalarParameter = fallback.GetOrDefault<int>(nameof(MaterialIndexForScalarParameter));
            ScalarParameterNameForMaterial = fallback.GetOrDefault<FName>(nameof(ScalarParameterNameForMaterial));
            ScalarOverride = fallback.GetOrDefault<float>(nameof(ScalarOverride));
        }
    }
}