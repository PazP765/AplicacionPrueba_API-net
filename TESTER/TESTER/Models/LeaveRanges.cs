namespace TESTER.Models
{
    public class LeaveRanges
    {
        //METODO PARAMETRIZADO (SE REUIERE PARA OBTENER VALORES DESDE LA CONSULTA SQL Ó PROCEDIMIENTO ALMACENADO)
        public LeaveRanges(int id, int years, int days)
        {
            Id = id;
            Years = years;
            Days = days;
        }

        public int Id { get; set; }
        public int Years { get; set; }
        public int Days { get; set; }

        
    }
}
