using System;


namespace Resolvendo_exercicios_conjuntos.Entities
{
    class LogRecord
    {
        public string UserName { get; set; }
        public DateTime Instat { get; set; }


        public override int GetHashCode()
        {
            return UserName.GetHashCode();
        }

        public override bool Equals(object obj)
        {

            if (!(obj is LogRecord))
                return false;

            LogRecord other = obj as LogRecord;

            return UserName.Equals(other.UserName);
        }
    }
}
