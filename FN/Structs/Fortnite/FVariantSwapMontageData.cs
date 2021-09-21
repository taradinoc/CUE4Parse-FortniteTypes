using CUE4Parse.FN.Enums.Fortnite;
using CUE4Parse.FN.Structs.GT;
using CUE4Parse.UE4;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Assets.Utils;
using CUE4Parse.UE4.Objects.UObject;

namespace CUE4Parse.FN.Structs.Fortnite
{
    [StructFallback]
    public class FVariantSwapMontageData : IUStruct
    {
        public FName MontageSectionName;
        public EMontageSelectionPredicateType EvaluationMode;
        public FGameplayTag VariantMetaTagRequired;
        public bool bRequireCharacterPart;
        public FVariantSwapMontagePartRequirement[] PartRequirements;
        public FVariantSwapMontageActiveSwapsRequirement[] SwapRequirements;

        public FVariantSwapMontageData(FStructFallback fallback)
        {
            MontageSectionName = fallback.GetOrDefault<FName>(nameof(MontageSectionName));
            EvaluationMode = fallback.GetOrDefault<EMontageSelectionPredicateType>(nameof(EvaluationMode));
            VariantMetaTagRequired = fallback.GetOrDefault<FGameplayTag>(nameof(VariantMetaTagRequired));
            bRequireCharacterPart = fallback.GetOrDefault<bool>(nameof(bRequireCharacterPart));
            PartRequirements = fallback.GetOrDefault<FVariantSwapMontagePartRequirement[]>(nameof(PartRequirements));
            SwapRequirements = fallback.GetOrDefault<FVariantSwapMontageActiveSwapsRequirement[]>(nameof(SwapRequirements));
        }
    }
}