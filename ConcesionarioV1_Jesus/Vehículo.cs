using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionarioV1_Jesus
{
    public class Vehículo
    {
        // CONSTANTES

        // MIEMBROS PRIVADOS
        private string _marca;
        private string _modelo;

        // CONSTRUCCIONES
        public Vehículo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        // PROPIEDADES
        public string Marca
        {
            get { return _marca; }
            set {
                // TODO: Proporcionar seguridad y protección al miembro -> _marca
                _marca = value; }
        }

        public string Modelo
        {
            get { return _modelo; }
            set
            { // TODO: Proporcionar seguridad y protección al miembro -> _modelo
              _modelo = value; }
            }
            // MÉTODOS PÚBLICOS

            // MÉTODOS PRIVADOS

        }
}
