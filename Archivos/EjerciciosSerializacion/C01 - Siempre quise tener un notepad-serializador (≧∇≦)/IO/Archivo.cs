namespace IO
{
    public abstract class Archivo
    {
        protected abstract string Extension { get; }
        /*
         El método ValidarExtensión validará que la extensión del archivo sea la que retorna la propiedad abstracta protegida Extension.

De no ser la extensión correcta, lanzará la excepción ArchivoIncorrectoException con el mensaje "El archivo no tiene la extensión [extensión].". Reemplazar el texto entre corchetes por la extensión que se esperaba.
         */
        public bool ValidarExtension(string ruta)
        {
          
            if (Path.GetExtension(ruta) == Extension)
            {
                return true;
            }

            throw new ArchivoIncorrectoException($"El archivo no tiene la extensión {Extension}."); ; 
        }
        /*
         El método ValidarSiExisteElArchivo de la clase Archivo comprobará que el archivo exista. Si existe retornará true. De no existir, lanzará la excepción ArchivoIncorrectoException con el mensaje "El archivo no se encontró.".
         */
        public bool ValidarSiExisteElArchivo(string ruta)
        {         
            if (File.Exists(ruta))
            {
                return true;
            }
            throw new ArchivoIncorrectoException("El archivo no se encontró."); ;
        }
    }
}
