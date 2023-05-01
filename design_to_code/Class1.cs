using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Text;

namespace design_to_code
{
    public class order
    {
        public int id;
        public DateTime dia;
        public float precio;
        public string pais;
        public Dictionary<int, product> product;
        public bool entrega()
        {
            return true;
        }
    }
    public class user
    {
        public int id;
        public string nombre;
        public string apellidos;
        public string DNI;
        public string email;
        public string telefono;
        public Address direccion;
        public List<product> producto;
        public order order;
    }
    public class shopping_list
    {
        public float precio_final;
        public List<product> lista_productos;
        public bool añadir_pago()
        {
            return true;
        }
        public bool añadir_producto()
        {
            return true;
        }
        public bool quitar_producto()
        {
            return true;
        }
        public user user;
    }
    public class Address
    {
        public string calle;
        public string ciudad;
        public int CP;
        public string pais;
        public bool validacion()
        {
            return true;
        }
        public user user;
    }
    public class review
    {
        public string comentarios;
        public int tratamientos_productos;
        public List<product> productos_relacionados;
        public bool add_review()
        {
            return true;
        }
        public user user;
        public product product;
    }

    public class product
    {
        public int id;
        public string nombre;
        public string marca;
        public string descripcion;
        public float precio_base;
        public float porcentaje_descuento;
        public float precio_inicial;
        public float precio_final;
        public List<review> opiniones;
        public enum type { monitor, cpu, teclado, raton }
        public int cantidad;
        public string image;
        public bool visible()
        {
            return true;
        }
        public order order;
    }
    public class producto_simple : product
    {
        public string categoria;
        public string subcategoria;
    }
    public class producto_complejo : product
    {
        public string categoria;
        public string subcategoria1;
        public string subcategoria2;
    }
}
