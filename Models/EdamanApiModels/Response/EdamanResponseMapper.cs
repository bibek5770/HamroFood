using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models.EdamanApiModels.Response
{

    public class EdamanResponseMapper
    {
        [JsonProperty(PropertyName = "q")]
        public string Q { get; set; }

        [JsonProperty(PropertyName = "from")]
        public int From { get; set; }

        [JsonProperty(PropertyName = "to")]
        public int To { get; set; }

        [JsonProperty(PropertyName = "_params")]
        public Params Params { get; set; }

        [JsonProperty(PropertyName = "more")]
        public bool More { get; set; }

        [JsonProperty(PropertyName = "count")]
        public int Count { get; set; }

        [JsonProperty(PropertyName = "hits")]
        public IList<Hit> Hits { get; set; }
    }

    public class Params
    {
        [JsonProperty(PropertyName = "sane")]
        public IList<object> Sane { get; set; }

        [JsonProperty(PropertyName = "q")]
        public IList<string> Q { get; set; }

        [JsonProperty(PropertyName = "app_id")]
        public IList<string> AppId { get; set; }

        [JsonProperty(PropertyName = "app_key")]
        public IList<string> AppKey { get; set; }
    }

    public class Hit
    {
        [JsonProperty(PropertyName = "recipe")]
        public Recipe Recipe { get; set; }

        [JsonProperty(PropertyName = "bookmarked")]
        public bool Bookmarked { get; set; }

        [JsonProperty(PropertyName = "bought")]
        public bool Bought { get; set; }
    }

    public class Recipe
    {
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        [JsonProperty(PropertyName = "image")]
        public string Image { get; set; }

        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

        [JsonProperty(PropertyName = "sourceIcon")]
        public string SourceIcon { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "shareAs")]
        public string ShareAs { get; set; }

        [JsonProperty(PropertyName = "yield")]
        public float Yield { get; set; }

        [JsonProperty(PropertyName = "dietLabels")]
        public IList<string> DietLabels { get; set; }

        [JsonProperty(PropertyName = "healthLabels")]
        public IList<string> HealthLabels { get; set; }

        [JsonProperty(PropertyName = "cautions")]
        public IList<object> Cautions { get; set; }

        [JsonProperty(PropertyName = "ingredientLines")]
        public IList<string> IngredientLines { get; set; }

        [JsonProperty(PropertyName = "ingredients")]
        public IList<Ingredient> Ingredients { get; set; }

        [JsonProperty(PropertyName = "calories")]
        public float Calories { get; set; }

        [JsonProperty(PropertyName = "totalWeight")]
        public float TotalWeight { get; set; }

        [JsonProperty(PropertyName = "totalNutrients")]
        public Totalnutrients TotalNutrients { get; set; }

        [JsonProperty(PropertyName = "totalDaily")]
        public Totaldaily TotalDaily { get; set; }

        [JsonProperty(PropertyName = "digest")]
        public IList<Digest> Digest { get; set; }
    }

    public class Totalnutrients
    {

        [JsonProperty(PropertyName = "ENERC_KCAL")]
        public EnercKcal EnercKcal { get; set; }

        [JsonProperty(PropertyName = "FAT")]
        public Fat Fat { get; set; }

        [JsonProperty(PropertyName = "FASAT")]
        public Fasat Fasat { get; set; }

        [JsonProperty(PropertyName = "FATRN")]
        public Fatrn Fatrn { get; set; }

        [JsonProperty(PropertyName = "FAMS")]
        public Fams Fams { get; set; }

        [JsonProperty(PropertyName = "FAPU")]
        public Fapu Fapu { get; set; }

        [JsonProperty(PropertyName = "CHOCDF")]
        public Chocdf Chocdf { get; set; }

        [JsonProperty(PropertyName = "FIBTG")]
        public Fibtg Fibtg { get; set; }

        [JsonProperty(PropertyName = "SUGAR")]
        public Sugar Sugar { get; set; }

        [JsonProperty(PropertyName = "PROCNT")]
        public Procnt Procnt { get; set; }

        [JsonProperty(PropertyName = "CHOLE")]
        public Chole Chole { get; set; }

        [JsonProperty(PropertyName = "")]
        public Na Na { get; set; }

        [JsonProperty(PropertyName = "NA")]
        public Ca Ca { get; set; }

        [JsonProperty(PropertyName = "MG")]
        public Mg Mg { get; set; }

        [JsonProperty(PropertyName = "K")]
        public K K { get; set; }

        [JsonProperty(PropertyName = "FE")]
        public Fe Fe { get; set; }

        [JsonProperty(PropertyName = "ZN")]
        public Zn Zn { get; set; }

        [JsonProperty(PropertyName = "P")]
        public P P { get; set; }

        [JsonProperty(PropertyName = "VITA_RAE")]
        public VitaRae VitaRae { get; set; }

        [JsonProperty(PropertyName = "VITC")]
        public Vitc Vitc { get; set; }

        [JsonProperty(PropertyName = "THIA")]
        public Thia Thia { get; set; }

        [JsonProperty(PropertyName = "RIBF")]
        public Ribf Ribf { get; set; }

        [JsonProperty(PropertyName = "NIA")]
        public Nia Nia { get; set; }

        [JsonProperty(PropertyName = "VITB6A")]
        public Vitb6A Vitb6A { get; set; }

        [JsonProperty(PropertyName = "FOL")]
        public Fol Fol { get; set; }

        [JsonProperty(PropertyName = "VITB12")]
        public Vitb12 Vitb12 { get; set; }

        [JsonProperty(PropertyName = "VITD")]
        public Vitd Vitd { get; set; }

        [JsonProperty(PropertyName = "TOCPHA")]
        public Tocpha Tocpha { get; set; }

        [JsonProperty(PropertyName = "VITK1")]
        public Vitk1 Vitk1 { get; set; }
    }

    public class EnercKcal
    {
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        [JsonProperty(PropertyName = "quantity")]
        public float Quantity { get; set; }

        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }
    }

    public class Fat
    {
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        [JsonProperty(PropertyName = "quantity")]
        public float Quantity { get; set; }

        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }
    }

    public class Fasat
    {

        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        [JsonProperty(PropertyName = "quantity")]
        public float Quantity { get; set; }

        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }
    }

    public class Fatrn
    {

        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        [JsonProperty(PropertyName = "quantity")]
        public float Quantity { get; set; }

        [JsonProperty(PropertyName = "unot")]
        public string Unit { get; set; }
    }

    public class Fams
    {

        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        [JsonProperty(PropertyName = "quantity")]
        public float Quantity { get; set; }

        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }
    }

    public class Fapu
    {
        public string Label { get; set; }
        public float Quantity { get; set; }
        public string Unit { get; set; }
    }

    public class Chocdf
    {
        public string Label { get; set; }
        public float Quantity { get; set; }
        public string Unit { get; set; }
    }

    public class Fibtg
    {
        public string Label { get; set; }
        public float Quantity { get; set; }
        public string Unit { get; set; }
    }

    public class Sugar
    {
        public string Label { get; set; }
        public float Quantity { get; set; }
        public string Unit { get; set; }
    }

    public class Procnt
    {
        public string Label { get; set; }
        public float Quantity { get; set; }
        public string Unit { get; set; }
    }

    public class Chole
    {
        public string Label { get; set; }
        public float Quantity { get; set; }
        public string Unit { get; set; }
    }

    public class Na
    {
        public string Label { get; set; }
        public float Quantity { get; set; }
        public string Unit { get; set; }
    }

    public class Ca
    {
        public string Label { get; set; }
        public float Quantity { get; set; }
        public string Unit { get; set; }
    }

    public class Mg
    {
        public string Label { get; set; }
        public float Quantity { get; set; }
        public string Unit { get; set; }
    }

    public class K
    {
        public string Label { get; set; }
        public float Quantity { get; set; }
        public string Unit { get; set; }
    }

    public class Fe
    {
        public string Label { get; set; }
        public float Quantity { get; set; }
        public string Unit { get; set; }
    }

    public class Zn
    {
        public string Label { get; set; }
        public float Quantity { get; set; }
        public string Unit { get; set; }
    }

    public class P
    {
        public string Label { get; set; }
        public float Quantity { get; set; }
        public string Unit { get; set; }
    }

    public class VitaRae
    {
        public string Label { get; set; }
        public float Quantity { get; set; }
        public string Unit { get; set; }
    }

    public class Vitc
    {
        public string Label { get; set; }
        public float Quantity { get; set; }
        public string Unit { get; set; }
    }

    public class Thia
    {
        public string Label { get; set; }
        public float Quantity { get; set; }
        public string Unit { get; set; }
    }

    public class Ribf
    {
        public string Label { get; set; }
        public float Quantity { get; set; }
        public string Unit { get; set; }
    }

    public class Nia
    {
        public string Label { get; set; }
        public float Quantity { get; set; }
        public string Unit { get; set; }
    }

    public class Vitb6A
    {
        public string Label { get; set; }
        public float Quantity { get; set; }
        public string Unit { get; set; }
    }

    public class Fol
    {
        public string Label { get; set; }
        public float Quantity { get; set; }
        public string Unit { get; set; }
    }

    public class Vitb12
    {
        public string Label { get; set; }
        public float Quantity { get; set; }
        public string Unit { get; set; }
    }

    public class Vitd
    {
        public string Label { get; set; }
        public float Quantity { get; set; }
        public string Unit { get; set; }
    }

    public class Tocpha
    {
        public string Label { get; set; }
        public float Quantity { get; set; }
        public string Unit { get; set; }
    }

    public class Vitk1
    {
        public string Label { get; set; }
        public float Quantity { get; set; }
        public string Unit { get; set; }
    }

    public class Totaldaily
    {
        public EnercKcal EnercKcal { get; set; }
        public Fat Fat { get; set; }
        public Fasat Fasat { get; set; }
        public Chocdf Chocdf { get; set; }
        public Fibtg Fibtg { get; set; }
        public Procnt Procnt { get; set; }
        public Chole Chole { get; set; }
        public Na Na { get; set; }
        public Ca Ca { get; set; }
        public Mg Mg { get; set; }
        public K K { get; set; }
        public Fe Fe { get; set; }
        public Zn Zn { get; set; }
        public P P { get; set; }
        public VitaRae VitaRae { get; set; }
        public Vitc Vitc { get; set; }
        public Thia Thia { get; set; }
        public Ribf Ribf { get; set; }
        public Nia Nia { get; set; }
        public Vitb6A Vitb6A { get; set; }
        public Fol Fol { get; set; }
        public Vitb12 Vitb12 { get; set; }
        public Vitd Vitd { get; set; }
        public Tocpha Tocpha { get; set; }
        public Vitk1 Vitk1 { get; set; }
    }


    public class Ingredient
    {
        public string Text { get; set; }
        public float Quantity { get; set; }
        public string Measure { get; set; }
        public string Food { get; set; }
        public float Weight { get; set; }
    }

    public class Digest
    {
        public string Label { get; set; }
        public string Tag { get; set; }
        public string SchemaOrgTag { get; set; }
        public float Total { get; set; }
        public bool HasRdi { get; set; }
        public float Daily { get; set; }
        public string Unit { get; set; }
        public Sub[] Sub { get; set; }
    }

    public class Sub
    {
        public string Label { get; set; }
        public string Tag { get; set; }
        public string SchemaOrgTag { get; set; }
        public float Total { get; set; }
        public bool HasRdi { get; set; }
        public float Daily { get; set; }
        public string Unit { get; set; }
    }

}