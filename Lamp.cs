using System.Drawing;
namespace Gloomi
{
    public class Lamp
    {
        public Lamp()
        {
            provincie = "geen provincie";
            stad = "geen stad";
            postcode = "geen postcode";
            apparaatid = "geen apparaatid";
            lichtintensiteit = 100;
            kleur = Color.White;
            temperatuur = 0;
            vochtigheidsgraad = 0;
            luxgraad = 0;
        }
        public string provincie { get; set; }
        public string stad { get; set; }
        public string postcode { get; set; }
        public string apparaatid { get; set; }
        public float lichtintensiteit { get; set; }
        public Color kleur { get; set; }
        public int temperatuur { get; set; }
        public int vochtigheidsgraad { get; set; }
        public int luxgraad { get; set; }
        public int SQLindex { get; set; }
        public override string ToString()
        {
            return "Lamp " + apparaatid + "[ Locatie: " + provincie + ", " + stad + ", " + postcode + "] [L=" + lichtintensiteit + "; C=" + ColorTranslator.ToHtml(kleur) + "]";
        }
    }
}
