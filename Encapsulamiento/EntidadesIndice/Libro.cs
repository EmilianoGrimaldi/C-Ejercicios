namespace EntidadesIndice
{
    public class Libro
    {
        List<string> paginas = new();
        
        public string this[int i] 
        {
            get
            {
                if (i >= 0 && i < paginas.Count)
                {
                    return paginas[i];
                }
                return "";
            }
            set
            {
                if (i < paginas.Count)
                {
                    paginas.Insert(i,value);                          
                }
                else 
                {
                    paginas.Add(value);
                }          
            }
        }
    }
}
