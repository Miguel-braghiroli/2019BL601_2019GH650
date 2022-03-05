namespace _2019BL601_2019GH650.Models
{
    public class Materia
    {
        public int id { get; set; }
        public virtual Facultad facultad { get; set; }
        public string materia { get; set; }
        public int unidades_valorativas { get; set; }
        public string estado { get; set; }
    }
}