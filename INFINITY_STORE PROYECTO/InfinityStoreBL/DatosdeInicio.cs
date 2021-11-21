using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfinityStore.BL
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            var nuevoUsuario1 = new Usuario();
            nuevoUsuario1.Nombre = "Nelson";
            nuevoUsuario1.Contrasena = Encriptar.CodificarContrasena("Chacon");

            var nuevoUsuario2 = new Usuario();
            nuevoUsuario2.Nombre = "Valeria";
            nuevoUsuario2.Contrasena = Encriptar.CodificarContrasena("Sabillon");


            var nuevoUsuario3 = new Usuario();
            nuevoUsuario3.Nombre = "Mabel";
            nuevoUsuario3.Contrasena = Encriptar.CodificarContrasena("Trochez");

            var nuevoUsuario4 = new Usuario();
            nuevoUsuario4.Nombre = "Hesler";
            nuevoUsuario4.Contrasena = Encriptar.CodificarContrasena("Erazo");


            contexto.Usuarios.Add(nuevoUsuario1);
            contexto.Usuarios.Add(nuevoUsuario2);
            contexto.Usuarios.Add(nuevoUsuario3);
            contexto.Usuarios.Add(nuevoUsuario4);


            base.Seed(contexto);
        }
    }
}
