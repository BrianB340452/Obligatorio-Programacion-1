﻿using Dominio.Enums;
using Dominio.Interfaces;

namespace Dominio
{
    public abstract class Publicacion : IValidable
    {
        protected int _id;
        private static int s_ultId = 1;
        protected string _nombre;
        protected EstadoPublicacion _estado;
        protected DateTime _fechaPublicacion;
        protected List<Articulo> _articulos = new List<Articulo>();
        protected Cliente _clienteComprador;
        protected Administrador _usuarioFinalizador;
        protected DateTime _fechaFinalizada;

        protected Publicacion(string nombre, EstadoPublicacion estado, DateTime fechaPublicacion, List<Articulo> articulos)
        {
            _id = s_ultId++;
            _nombre = nombre;
            _estado = estado;
            _fechaPublicacion = fechaPublicacion;
            _articulos = articulos;
        }

        public virtual void Validar()
        {
            if (string.IsNullOrEmpty(_nombre)) throw new Exception("El nombre no puede estar vacío.");
            if (_articulos == null) throw new Exception("Los artículos no pueden ser nulos.");
        }
    }
}
