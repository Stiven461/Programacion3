using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace DAL.Interface
{
    public interface IMunicipioRepositorio
    {

        Boolean Crear(Municipio municipio);

        List<Municipio>municipios();

    }
}
