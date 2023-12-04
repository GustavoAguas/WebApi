namespace API.Models
{
    public class Usuario
    {
        public string idUsuario {  get; set; }
        public string usuario { get; set; }
        public string password { get; set; }    
        public string rol {  get; set; }

        public static List<Usuario> DB()
        {
            var list = new List<Usuario>()
            {
                new Usuario
                {
                    idUsuario = "1",
                    usuario = "Gucci",
                    password = "123.",
                    rol = "admin"
                },
                new Usuario
                {
                    idUsuario = "2",
                    usuario = "Sebas",
                    password = "456.",
                    rol = "admin"
                },
                new Usuario
                {
                    idUsuario = "3",
                    usuario = "Jorge",
                    password = "789.",
                    rol = "empleado"
                },
                new Usuario
                {
                    idUsuario = "4",
                    usuario = "BellaKhat",
                    password = "012.",
                    rol = "empleado"
                }
            };
            return list;
        }

    } 
}
