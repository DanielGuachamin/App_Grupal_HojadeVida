using System;
using System.Collections.Generic;
using System.Text;

namespace App_Grupal_HojadeVida
{
    public class Elemento
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }

    public class ListaElementos
    {
        public List<Elemento> _elementos { get; set; }

        public ListaElementos()
        {
            _elementos = new List<Elemento>();
            loadElements();
        }

        public void loadElements()
        {
            _elementos.Add(new Elemento
            {
                Nombre = "Java",
                Descripcion = "Se manejar Java"
            });
            _elementos.Add(new Elemento
            {
                Nombre = "C++",
                Descripcion = "Se manejar C++"
            });
            _elementos.Add(new Elemento
            {
                Nombre = "Python",
                Descripcion = "Se manejar Python"
            });
        }
    }
}
