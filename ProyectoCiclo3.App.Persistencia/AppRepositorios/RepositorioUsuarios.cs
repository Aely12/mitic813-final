using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioUsuarios
    {
        List<Usuario> Usuarios;
 
        public RepositorioUsuarios()
        {
            usuarios= new List<Usuario>()


            {
                new Usuario{id=1,nombre="camila",apellidos= "vasquez",direccion= "calle20",Telefono= 312890,ciudad= "cali"},
                new Usuario{id=1,nombre="pedro",apellidos= "perez",direccion= "calle30",Telefono= 312890,ciudad= "cali"},
                new Usuario{id=1,nombre="maia",apellidos= "montes",direccion= "calle70",Telefono= 312890,ciudad= "cali"}
            };

           
        }
 
        public IEnumerable<usuario> GetAll()
        {
            return Usuarios;
        }
 
        public Usuario GetWithId(int id){
            return usuarios.SingleOrDefault(u => u.id == id);
        }

        public Usuario Update(Usuario newUsuario){
            var usuario = usuarios.SingleOrDefault(u => u.id == newUsuario.id);
            if(usuario != null){
                usuario.nombre = newUsuario.nombre;
                usuario.apellidos = newUsuario.apellidos;
                usuario.direccion = newUsuario.direccion;
                usuario.Telefono = newUsuario.Telefono;
                usuario.ciudad = newUsuario.ciudad;
            }
        return usuario;
        }

        public Usuario Create(Usuario newUsuario)
        {
           if(usuarios.Count > 0){
             newUsuario.id=usuarios.Max(r => r.id) +1; 
            }else{
               newUsuario.id = 1; 
            }
           usuarios.Add(newUsuario);
           return newUsuario;
        }

        public Usuario Delete(int id)
        {
            var usuario = usuarios.SingleOrDefault(u => u.id == id);
            usuarios.Remove(usuario);
            return usuario;
        }

    }
}
